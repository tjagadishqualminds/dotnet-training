using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightReservationSystem
{
    class InternationalFlight : FlightReservation
    {
        //declaration fields 
        private string passportnumber;


        //constructor for initialization fields of base class and internationalflight class
        public InternationalFlight(string PassportNumber, string AirLineName, string FlightNumber, string FromJourney, string ToJourney, DateTime SpecificDate, int BookingId) : base(AirLineName, FlightNumber, FromJourney, ToJourney, SpecificDate, BookingId) {
            PassportNumber = passportnumber;
        }

        //Properties to access the fields
        public string PassportNumber { get { return passportnumber; }  } 

        //methods
        public string GetPassportNumber()
        {
            return passportnumber;
        }
        //implementing abstract method
        public override string Booking()
        {
            return "Booking completed successfully";
        }

        //implementing virtual method and overriding it and executing base method without calling it base method can be useless
        public override string CheckAvailability()
        {
           base.CheckAvailability();
            return "Checking";
        }
    }
}
