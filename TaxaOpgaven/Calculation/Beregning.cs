using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace TaxaOpgaven
{
    public class Beregning
    {
        //skriv KM
        public string[] JsonWhen = new string[] { "Dagtimer", "Aften" };
        public string When { get; set; } = "";

       [JsonPropertyName("StartPrice")]
       public double StartPrice { get; set; }
        public double TheKM { get; set; } = 0;
       public double TheMinutes { get; set; } = 0;

       public double PerKM { get; set; } = 0; 
       public double PerMinutes { get; set; } = 0; 

        //Destination A - B
        public string StartDestination { get; set; } = "";
        public string EndDestination { get; set; } = "";
        public double KMBetweenSE { get; set; } = 0;


        //skriv KM
        public double BeregnPris(double theKM)
        {
            TheKM = theKM;
            TheMinutes = theKM * 1.2;

            return StartPrice + (TheKM * PerKM) + (TheMinutes * PerMinutes);
        }


        //Destination A - B
        //public double BeregnPris(string startDestination, string endDestination)
        //{
        //    startDestination = StartDestination;
        //    endDestination = EndDestination;
        //    KMBetweenSE = (mellem start og end destination);
        //    TheMinutes = KMBetweenSE * 1.2;
        //    return StartPrice + (KMBetweenSE * PerKM) + (TheMinutes * PerMinutes);
        //}
    }
}
