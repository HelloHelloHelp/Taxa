
namespace TaxaOpgaven.Components.Pages
{
    public partial class Home
    {
        private Beregning beregning = new Beregning();

        private double KM { get; set; }
        private string When { get; set; } = "";

        private string ErrorMessage { get; set; } = "";
        private string Result { get; set; } = "";

        public void Calculate()
        {
            ErrorMessage = "";
            Result = "";

            if (KM <= 0)
            {
                ErrorMessage = "Indtast en gyldig distance.";
                return;
            }

            if (string.IsNullOrWhiteSpace(When))
            {
                ErrorMessage = "Indtast et tidspunkt.";
                return;
            }

            if (beregning.JsonWhen.Contains(When))
            {
                ErrorMessage = "Det valgte tidspunkt er ikke gyldigt.";
                return;
            }

            Result = $"{beregning.BeregnPris(KM)} kr. " +
                     $"{beregning.TheMinutes} minutter.";
        }
        public double BeregnPris(double theKM)
        {
            TheKM = theKM;
            TheMinutes = theKM * 1.2;

            return StartPrice + (TheKM * PerKM) + (TheMinutes * PerMinutes);
        }
    }
}
