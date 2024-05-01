

namespace FlightReservationSystem
{
    /// <summary>
    /// This project is all about dynamic polymorphism
    /// Taking  one parent class declaration and initializing with child classes
    /// and access all method and properties
    /// in short
    /// 
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime specificDate = DateTime.Today;
            //using parent class declaration creating child class instance 
            FlightReservation flightReservation = new DomesticFlight(12,"BritishAirlines","F223D","HYD","Delhi",specificDate,1245);
            FlightReservation flightReservation1 = new InternationalFlight( "vasdlf","BritisadfshAirlines", "F223D", "HYD", "Delhi", specificDate, 1245);
            FlightReservation flightReservation2 = new Economy(12.23m, "airIndia", "F223D", "HYD", "Delhi", specificDate, 1245);
            FlightReservation flightReservation3 = new Business(true, "BritishAirlines", "F223D", "HYD", "Delhi", specificDate, 1245);

            Console.WriteLine("flightname :{0},flightnumber :{1},fromJourney :{2},ToJourney :{3},Date:{4},BookingId:{5}",flightReservation.AirLineName,flightReservation.FlightNumber,flightReservation.ToJourney,flightReservation.FromJourney,flightReservation.SpecificDate,flightReservation.BookingId);
            Console.WriteLine("flightname :{0},flightnumber :{1},fromJourney :{2},ToJourney :{3},Date:{4},BookingId:{5}", flightReservation1.AirLineName,flightReservation1.FlightNumber,flightReservation1.ToJourney,flightReservation1.FromJourney,flightReservation1.SpecificDate,flightReservation1.BookingId);
            Console.WriteLine("flightname :{0},flightnumber :{1},fromJourney :{2},ToJourney :{3},Date:{4},BookingId:{5}", flightReservation2.AirLineName,flightReservation2.FlightNumber,flightReservation2.ToJourney,flightReservation2.FromJourney,flightReservation2.SpecificDate,flightReservation2.BookingId);
            Console.WriteLine("flightname :{0},flightnumber :{1},fromJourney :{2},ToJourney :{3},Date:{4},BookingId:{5}", flightReservation3.AirLineName,flightReservation3.FlightNumber,flightReservation3.ToJourney,flightReservation3.FromJourney,flightReservation3.SpecificDate,flightReservation3.BookingId);

            DomesticFlight domesticFlight = new DomesticFlight(12, "BritishAirlines", "F223D", "HYD", "Delhi", specificDate, 1245);
            Console.WriteLine("LuggageWeight:{0} ,flightname :{1},flightnumber :{2},fromJourney :{3},ToJourney :{4},Date:{5} ,BookingId:{6}", domesticFlight.LuggageWeight , domesticFlight.AirLineName,domesticFlight.FlightNumber,domesticFlight.ToJourney,domesticFlight.FromJourney,domesticFlight.SpecificDate,domesticFlight.BookingId);

            InternationalFlight internationalFlight = new InternationalFlight("vasdlf", "BritisadfshAirlines", "F223D", "HYD", "Delhi", specificDate, 1245);
            Console.WriteLine("PassportNumber:{0} ,flightname :{1},flightnumber :{2},fromJourney :{3},ToJourney :{4},Date:{5} ,BookingId:{6}", internationalFlight.PassportNumber , internationalFlight.AirLineName, internationalFlight.FlightNumber, internationalFlight.ToJourney, internationalFlight.FromJourney,internationalFlight.SpecificDate,internationalFlight.BookingId);

            Economy economy = new Economy(12.23m, "airIndia", "F223D", "HYD", "Delhi", specificDate, 1245);
            Console.WriteLine("Classprice:{0} ,flightname :{1},flightnumber :{2},fromJourney :{3},ToJourney :{4},Date:{5} ,BookingId:{6}", economy.ClassPrice , economy.AirLineName, economy.FlightNumber, economy.ToJourney, economy.FromJourney, economy.SpecificDate, economy.BookingId);

            Business business = new Business(true, "BritishAirlines", "F223D", "HYD", "Delhi", specificDate, 1245);
            Console.WriteLine("LougeAcess:{0} ,flightname :{1},flightnumber :{2},fromJourney :{3},ToJourney :{4},Date:{5} ,BookingId:{6}", business.loungeAccess, business.AirLineName, business.FlightNumber, business.ToJourney, business.FromJourney, business.SpecificDate, business.BookingId);



        }
    }
}
