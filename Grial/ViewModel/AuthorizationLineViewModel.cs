using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UXDivers.Artina.Grial.Dataprovider;

namespace UXDivers.Artina.Grial
{
    public class AuthorizationLineViewModel
    {

        List<Situation> _lineSituation;

        public string CounterPart { get; set; }

        public SampleCategory RistItemObject { get; set; }

        public List<Situation> LineSituation
        {
            get
            {

                return _lineSituation;
            }

        }

        public List<Situation> LineSituationForPricingCalculation { get; set; }

        public RiskItem RiskItem { get; set; }

        public AuthorizationLineViewModel(string counterpart)
        {
            CounterPart = counterpart;
            var authLine = new AuthorizationLine(CounterPart).Get();
            RiskItem = authLine.SelectedItem;
            _lineSituation = new List<Situation>(authLine.LineSituation);
            LineSituationForPricingCalculation = new List<Situation>() { authLine.LineSituation[0], authLine.LineSituation[1] };
        }
        public string Title
        {
            get
            {
                return CounterPart;
            }
        }



    }
}
