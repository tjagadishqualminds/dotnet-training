using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace NonGenericCollection
{
    internal class Flight
    {
        private string flightname;
        private int flightnumber;
       
        public Flight(string FlightName,int FlightNumber) {
        flightname = FlightName;
        flightnumber = FlightNumber;
      

        } 
        public Flight(int FlightNumber,string FlightName) {
            flightname = FlightName;
            flightnumber = FlightNumber;

        }
        public string FlightName {  get { return flightname; } set { flightname = value; } }
        public int FlightNumber { get {  return flightnumber; } set {  flightnumber = value; } }

        public override string ToString()
        {
            return $"FlightName: {flightname}, FlightNumber: {flightnumber}";
        }
    }
}
