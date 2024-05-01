using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FlightReservationSystem
{
    internal abstract class FlightReservation
    {


        //declaration fields 
        private string airlinename;
        private string flightnumber;
        private string fromjourney;
        private string tojourney;
        private DateTime specificdate;
        private int bookingid;

        //constructor for initializationfields of  flightReservation and it is a base class
        public FlightReservation(string AirLineName, string FlightNumber,string FromJourney,string ToJourney,DateTime SpecificDate,int BookingId)
        {
            airlinename = AirLineName;
            flightnumber = FlightNumber;   
            fromjourney = FromJourney;
            tojourney = ToJourney;
            specificdate = SpecificDate;
            bookingid = BookingId;
                
        }

   

        //Properties
        public string AirLineName { get {  return airlinename; } }  
        public string FlightNumber { get {  return flightnumber; } }
         public  string FromJourney { get {  return fromjourney; } }
        public string ToJourney { get { return tojourney; } }
        public DateTime SpecificDate { get {  return specificdate; } }
        public int BookingId { get {  return bookingid; } }

        public bool LuggageWeight { get; internal set; }




        //methods

       //declaring abstract method
        public abstract string Booking();


        public string CancelBooking()
        {
            return "Booking cancelled successfully";
        }

        //implementing virtual method can override it
        public virtual string CheckAvailability()
        {
            return "checking availability for flights";
        }


    }
}
