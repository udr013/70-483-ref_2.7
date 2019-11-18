using System;
using System.Collections.Generic;
using System.Text;

namespace CustomStringFormatting
{
    class MusicTrack : IFormattable
    {
        /// constructor
        public MusicTrack(string artist, string title, string year)
        {
            Artist = artist;
            Title = title;
            Year = year;
        }

        string Artist { get; set; }
        string Title { get; set; }
        string Year { get; set; }

        /// ToString implements the formatting behaviour
        public string ToString(string format, IFormatProvider formatProvider)
        {
            //Select the default behaviour if no format specified
            if (string.IsNullOrWhiteSpace(format))
            {
                format = "G";
            }

            switch (format)
            {
                case "A": return Artist;
                case "T": return Title;
                case "Y": return Year;
                case "D": // Default format fall thru
                case "F": return Artist + " " + Title + " " + Year;
                default:
                    throw new FormatException("Format specifier was invalid.");
            }
        }

        /// ToString that overrides the behavior in the base class
        public override string ToString()
        {
            return Artist + " " + Title;
        }
    }
}
