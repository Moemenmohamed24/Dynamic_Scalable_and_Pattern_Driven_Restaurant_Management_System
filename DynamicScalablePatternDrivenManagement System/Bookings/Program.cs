using System;
using System.Data;
using System.Diagnostics.Contracts;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using System.Xml.Linq;

class Program
{
    static void Main(string[] args)
    {
        //<------------------------------------------------Testing Factory Method design pattern---------------------------->


        // FullBooking fullBooking = new CoupleBooking();
        //FullBooking fullBooking = new GroupBooking();

        //Booking booking = fullBooking.BookingOrder("Group");

        /*
        In other words, BGroup is also BPersonalData.

        This is a fundamental rule of inheritance:

        If BGroup inherits from BPersonalData, then any object of type BGroup can also be considered BPersonalData.

        if (myBooking is BPersonalData personalData)
            Here, the runtime asks:
        Does the actual object(BGroup) inherit from BPersonalData ?
        */

        //if (booking is PersonalData bPersonalData)
        //{
        //    //  bPersonalData.AddExtrSeats(2);
        //    bPersonalData.UpgradeSeats();

        //}
        //casting BPersonalData personalData = (BPersonalData)myBooking; 

        //<------------------------------------------------Testing Decorator design pattern--------------------------------->

        //Tableseats oder1 = new SimpleTable();
        //oder1 = new Centerpieces(oder1);
        //oder1 = new LightCandle(oder1);
        //oder1 = new Tablecloth(oder1);
        //oder1 = new ColorsTheme(oder1);
        //Console.WriteLine($" all sheap of tabel : {oder1.Discribtion()} \n  cost of the tabel = {oder1.getPrice()} $ ");


        //<-------------------------------------------------Testing Strategy design pattern--------------------------------->

        //PaymentInterface Sterategy = new BankTransferPayment();
        //PaymentProcessor process = new PaymentProcessor(Sterategy);
        //process.Pay(4);


        //<-------------------------------------------------Simple Factory Design Pattern in food--------------------------------->
        //FoodFactory foodFactory = new FoodFactory();
        //IFood IFood = foodFactory.CreateFood("pizza");
        //IFood.Make();




        //<-------------------------------------------------Simple Factory Design Pattern in drinks--------------------------------->

        String category = "hot";

        // return HotDrinkFactory object , which DrinkFactory Factory  static object and HotDrinkFactory is a dynamic object
        //HotDrinkFactory dynamic object that will work GetFactory using the polymorphism 
        DrinkFactory Factory = DrinkFactory.GetFactory("hot");

        //work GreatFactory of the HotDrinkFactory
        IDrinks Drink = Factory.CreateDrink("Coffee");
        //return Coffee object , which Drink static object  , and Coffee is a dynamic object
        //Coffee dynamic object that will work Prepare using the polymorphism 

        Drink.Prepare();






    }
}

