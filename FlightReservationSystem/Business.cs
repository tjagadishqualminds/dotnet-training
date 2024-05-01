using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightReservationSystem
{
    internal class Business : FlightReservation
    {
        //declaration fields 
        private bool lougeAccess;

        //constructor for initializationfields of base class and business class it's derived class
        public Business(bool LoungeAccess, string AirLineName, string FlightNumber, string FromJourney, string ToJourney, DateTime SpecificDate, int BookingId):base(AirLineName, FlightNumber, FromJourney, ToJourney, SpecificDate, BookingId)
        {
            LoungeAccess = lougeAccess;
        }

        //methods
        public bool loungeAccess
    {
        get { return lougeAccess; }
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