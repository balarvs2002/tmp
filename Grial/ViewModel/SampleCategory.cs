using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace UXDivers.Artina.Grial
{
	public class SampleCategory
	{
		public string Name { get; set; }
		public string StartLetter
        {
            get
            {
                return Name.Substring(0, 1).ToUpper();
            }
        }

        public string Country { get; set; }
        
        public Color BackgroundColor { get; set; }

        public int Rating { get; set; }

        public String BackgroundImage { get; set; }
        public Color RatingBackgroundColor { get; set; }
        public Color TileBGColor { get; set; }
        public Color IconColor { get; set; }
        public List<Sample> SamplesList { get; set; }

		public char Icon { get; set; }

	}
}