using System;

namespace baru
{
    public class properties
    {
        static void Main(string[] args)
        {
            taxi taxi = new taxi();

            taxi.Drivername = "Bambang";
            taxi.OnDuty = true;
            taxi.NumPassenger = 10;

            taxi.TaxiInfo();
            taxi.PickUpPassenger();
            taxi.DropOffPassenger();


        }
    }
}