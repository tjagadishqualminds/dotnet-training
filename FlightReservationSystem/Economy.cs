using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightReservationSystem
{
    internal class Economy : FlightReservation

    {
        //declaration fields
        private decimal classprice;

        //constructor for initializationfields of base class and Economy class and it's derived class
        public Economy(decimal ClassPrice, string AirLineName, string FlightNumber, string FromJourney, string ToJourney, DateTime SpecificDate, int BookingId):base(AirLineName, FlightNumber, FromJourney, ToJourney, SpecificDate, BookingId) {

            this.classprice = ClassPrice;

        }

        //Properties
        public decimal ClassPrice {  get { return classprice; }  }

        //methods
        //implementing abstract method
        public override string Booking()
        {
            return "Booking completed successfully";
        }

        // implementing overriding method
        public override string CheckAvailability()
        {
            base.CheckAvailability();
            return "Checking";
        }
    }
}
