// See https://aka.ms/new-console-template for more information

using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Services;



//Console.WriteLine("Hello, World!");

//Plane plane = new Plane();
//plane.Capacity  = 100;
//plane.ManufactureDate = DateTime.Now;
//plane.PlaneType = PlaneType.Airbus;

////initialiseur dobjet

//Plane plane2 = new Plane
//{
//    Capacity = 100,
//    ManufactureDate = new DateTime(2025, 01, 30)
//    , PlaneType = PlaneType.Boeing
//};
//Console.WriteLine(plane);
//Passenger p1 = new Passenger { FirstName = "first", LastName = "last", EmailAddress = "first@gmail.com" };
//Staff staff = new Staff();
//Traveller traveller = new Traveller();

//p1.PassengerType();
//staff.PassengerType();
//traveller.PassengerType();
//Console.WriteLine("*****check profile*****");
////Console.WriteLine(p1.CheckProfile("first","last"));
//Console.WriteLine(p1.CheckProfile("first","last","e"));
Console.WriteLine("**********Get flights*********");
FlightMethods fm = new FlightMethods();
fm.Flights = TestData.listFlights;
List<DateTime> ls = fm.GetFlightDates("Paris");
foreach (DateTime dt in ls) 
     Console.WriteLine(dt);

Console.WriteLine("**********Get flights*********");
fm.GetFlights("Destination", "Madrid");
fm.GetFlights("EstimationDuration", "105");

Console.WriteLine("**********show flights*********");
fm.ShowLightDetails(TestData.BoingPlane);
Console.WriteLine("**********sProgrammedFlightNumbers*********");
Console.WriteLine(fm.ProgrammedFlightNumber(new DateTime(2021, 12, 31)));