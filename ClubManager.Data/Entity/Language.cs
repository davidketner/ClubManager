using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace ClubManager.Data.Entity
{
    public class Language
    {
        public string ShortName { get; set; }
        public string LongName { get; set; }
    }

    public static class Languages
    {
        public static IList<CultureInfo> SupportedCultures => SupportedLangs.SelectMany(x => new List<CultureInfo>{new CultureInfo(x.ShortName)}).ToList();

        public static List<Language> SupportedLangs = new List<Language>
        {
            new Language { ShortName = "cs", LongName = "Česky"},
            new Language { ShortName = "da", LongName = "Dansk"},
            new Language { ShortName = "de", LongName = "Deutsch"},
            new Language { ShortName = "en", LongName = "English"},
            new Language { ShortName = "es", LongName = "Español"},
            new Language { ShortName = "fr", LongName = "Français"},
            new Language { ShortName = "it", LongName = "Italiano"},
            new Language { ShortName = "hu", LongName = "Magyar"},
            new Language { ShortName = "nl", LongName = "Nederlands"},
            new Language { ShortName = "no", LongName = "Norsk"},
            new Language { ShortName = "pl", LongName = "Polski"},
            new Language { ShortName = "pt", LongName = "Português"},
            new Language { ShortName = "ro", LongName = "Română"},
            new Language { ShortName = "sk", LongName = "Slovenčina"},
            new Language { ShortName = "sr", LongName = "Srpski"},
            new Language { ShortName = "fi", LongName = "Suomi"},
            new Language { ShortName = "sv", LongName = "Svenska"},
            new Language { ShortName = "tr", LongName = "Türkçe"},
            new Language { ShortName = "el", LongName = "Ελληνικά"},
            new Language { ShortName = "bg", LongName = "Български"},
            new Language { ShortName = "ru", LongName = "Русский"},
            new Language { ShortName = "ja", LongName = "日本語"}
        };

    }
}
