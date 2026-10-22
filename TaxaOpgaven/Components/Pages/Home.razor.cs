
using TaxaOpgaven;

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

            if (!beregning.JsonWhen.Contains(When))
            {
                ErrorMessage = "Det valgte tidspunkt er ikke gyldigt.";
                return;
            }

            beregning.When = When;

            double pris = beregning.BeregnPris(KM);

          
        }
    }
}
