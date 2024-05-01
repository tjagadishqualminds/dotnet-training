using System;

namespace FlightReservationSystem
{
     class DomesticFlight : FlightReservation
    {
        //declaration fields
        private decimal luggageweight;
        private const int MAX_WEIGHT = 50;

        //constructor for initializationfields of base class and domestic class it's derived class
        public DomesticFlight( decimal LuggageWeight, string AirLineName, string FlightNumber, string FromJourney, string ToJourney, DateTime SpecificDate, int BookingId)
            : base(AirLineName, FlightNumber, FromJourney, ToJourney, SpecificDate, BookingId)
        {
            luggageweight=LuggageWeight;
        }

        //Properties
        public decimal LuggageWeight
        {
            get { return luggageweight; }
        }
        public decimal GetLuggageWeight()
        {
            return luggageweight;
        }


        public bool isLuggageWeightVaild()
        {
            return luggageweight <= MAX_WEIGHT;
        }

        //implementing abstract method
        public override string Booking()
        {
            return "Booking completed successfully";
        }

        //implementing virtual method can override it
        public override string CheckAvailability()
        {
            base.CheckAvailability();
            return "Checking";
        }
    }
}
