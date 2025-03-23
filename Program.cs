using System;
using System.Collections.Generic;

namespace SaahanSopivaOhjelma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna tämänhetkinen säätila (esim. ukkonen, lumisade, sateinen, tuulinen, pilvinen, aurinkoinen):");
            string weather = Console.ReadLine()?.ToLower() ?? "";

            Console.WriteLine("Onko sää kova vai pieni? (kirjoita 'kova' tai 'pieni', jos sovellettavissa):");
            string intensity = Console.ReadLine()?.ToLower() ?? "";

            Console.WriteLine("Kenen kanssa osallistut? (esim. 'perhe', 'pariskunta', 'ystäväporukka'): ");
            string group = Console.ReadLine()?.ToLower() ?? "";

            Console.WriteLine("\nAktiviteettiehdotus:");

            WeatherActivity? activitySuggestion = weather switch
            {
                "ukkonen" => new ThunderstormActivity(),
                "lumisade" => new SnowActivity(),
                "sateinen" => new RainyActivity(),
                "tuulinen" => new WindyActivity(),
                "pilvinen" => new CloudyActivity(),
                "aurinkoinen" => new SunnyActivity(),
                _ => null
            };

            if (activitySuggestion != null)
            {
                activitySuggestion.SuggestActivity(intensity, group);
            }
            else
            {
                Console.WriteLine("Tuntematon säätila. Yritä uudelleen.");
            }

            Console.WriteLine("\nPaina mitä tahansa näppäintä lopettaaksesi.");
            Console.ReadKey();
        }
    }

    abstract class WeatherActivity
    {
        public abstract void SuggestActivity(string intensity, string group);
    }

    class ThunderstormActivity : WeatherActivity
    {
        public override void SuggestActivity(string intensity, string activity)
        {
            var activities = activity switch
            {
                "perhe" => new List<string>
                {
                    "- Askartelu", "- Elokuvamaratooni", "- Kotispaa", "- Leivonta", "- Palapelit", "- Salamanmetsästys", "- Tarinankerronta", "- Tyynymaja", "- Ukkosmyrsky-aikakapseli"
                },
                "pariskunta" => new List<string>
                {
                    "- Karaoke kotona", "- Kokkailu", "- Musiikin kuuntelu", "- Spa-päivä", "- Romanttinen illallinen", "- Tyynymaja", "- Yhteinen äänikirjan kuuntelu", "- Ukkosen katselu"
                },
                "ystäväporukka" => new List<string>
                {
                    "- Discord pelituokio", "- Kaakaota ja lautapelejä", "- Karaoke", "- Kauhutarinat", "- Kokkailu", "- Musiikin kuuntelu", "- Teema illallinen", "- Ukkosen katselu"
                },
                _ => new List<string>
                {
                    "- Askartelu", "- Elokuvailta pimeässä", "- Kirjoittaminen", "- Kynttilänvalossa rentoutuminen", "- Myrskyn katsominen", "- Palapelit", "- Salamanmetsästys", "- Tarinan kerronta", "- Tyynymaja", "- Sääpäiväkirjan täyttäminen", "- Ukkosmyrsky aikakapseli"
                }
            };

            ActivityHelper.PrintActivities(activities);
        }
    }

    class SnowActivity : WeatherActivity
    {
        public override void SuggestActivity(string intensity, string activity)
        {
            var activities = (activity, intensity) switch
            {
                ("perhe", "kova") => new List<string>
                {
                    "- Askartelu", "- Elokuvamaraton", "- Kokkaus tai leivonta", "- Lautapelit", "- Lumikoristelut", "- Lämmin kylpy", "- Sisämaja", "- Vanhojen valokuvien katselu"
                },
                ("perhe", "pieni") => new List<string>
                {
                    "- Kuumat juomat", "- Luistelu", "- Lumisota", "- Lumiukon rakentaminen", "- Lumilyhdyt", "- Lumikenkäily", "- Pulkkailu", "- Sadetanssi", "- Takan edessä lämmittely", "- Talvimarkkinoille meno"
                },
                ("pariskunta", "kova") => new List<string>
                {
                    "- Netflix and Chill", "- Leffailta herkkujen kera", "- Leipominen", "- Lämmin kylpy", "- Takkatulen ääressä oleilu", "- Videopelit"
                },
                ("pariskunta", "pieni") => new List<string>
                {
                    "- Hiihtäminen", "- Koiravaljakkoajelu", "- Luistelu", "- Lumikenkäkävely", "- Makkarangrillaus", "- Sauna ja avantouinti", "- Talvinen metsäretki"
                },
                ("ystäväporukka", "kova") => new List<string>
                {
                    "- Leffailta herkkujen kera", "- Leipominen", "- Sisäsauna", "- Takkatulen ääressä oleilu", "- Videopelit"
                },
                ("ystäväporukka", "pieni") => new List<string>
                {
                    "- Hiihtäminen", "- Luistelu", "- Lumikenkäkävely", "- Nuotiohetki", "- Sauna ja avantouinti"
                },
                _ => intensity == "kova" ? new List<string>
                {
                    "- Elokuva maratooni", "- Kokkaus tai leivonta", "- Lautapelit", "- Lumikoristelu", "- Lämmittelyhetki", "- Opiskelu", "- Sisämaja", "- Vanhojen valokuvien katselu"
                } : new List<string>
                {
                    "- Fondue-ilta", "- Iglun rakentaminen", "- Kirja ja viltin alla rentoutuminen", "- Kuumat juomat", "- Laskettelu", "- Leivonta", "- Lumiaiheiset askartelut", "- Lumienkeli", "- Lumilyhdyt", "- Lumikenkäily", "- Lumisota", "- Lumiukon rakentaminen", "- Luistelu", "- Lämmin kylpy", "- Pulkkailu", "- Talvikeitto", "- Talvimarkkinat", "- Talvinen kävely", "- Yö kävely lumessa"
                }
            };

            ActivityHelper.PrintActivities(activities);
        }
    }

    class RainyActivity : WeatherActivity
    {
        public override void SuggestActivity(string intensity, string activity)
        {
            var activities = (activity, intensity) switch
            {
                ("perhe", "kova") => new List<string>
                {
                    "- Askartelu", "- Elokuvamaraton", "- Kokkaus tai leivonta", "- Kirjan lukeminen", "- Lautapelit", "- Lämmin kylpy", "- Naamiaiset", "- Palapelit", "- Sisämaja", "- Tanssibileet"
                },
                ("perhe", "pieni") => new List<string>
                {
                    "- Kalastus", "- Kuralätäkköhyppely", "- Lintubongaus", "- Luontoretki", "- Sadetanssi", "- Sammakkojen etsintä", "- Ulkopelit"
                },
                ("pariskunta", "kova") => new List<string>
                {
                    "- Netflix ja Chill", "- Kirjan lukeminen", "- Kotibaarikokeilu", "- Kylpy", "- Romanttinen illallinen", "- Teatterissa käynti", "- Videopelien pelaaminen"
                },
                ("pariskunta", "pieni") => new List<string>
                {
                    "- Metsäretki", "- Kahvilatreffit", "- Kirjastossa käynti", "- Kirpputorikierros", "- Kylpylässä käynti", "- Saunassa käynti"
                },
                ("ystäväporukka", "kova") => new List<string>
                {
                    "- Leffamaratooni", "- Karaoke-ilta", "- Kokkausilta", "- Kotibaari", "- Palapelit", "- Videopelien pelaaminen"
                },
                ("ystäväporukka", "pieni") => new List<string>
                {
                    "- Kalastus", "- Kaupunkiseikkailu", "- Kylpylässä käynti", "- Kuralätäköissä hyppiminen", "- Lintubongaus", "- Shoppailu"
                },
                _ => intensity == "kova" ? new List<string>
                {
                    "- Discord gaming sessio", "- Elokuvamaratooni", "- Facetime", "- Järjestelypäivä", "- Kirjapäivä", "- Kirjoittaminen", "- Kylpy", "- Lautapelit", "- Leivonta", "- Maalaus", "- Opiskelu", "- Rakentaa tyynymaja", "- Sateen katselu", "- Tee tai viini maistelu", "- Trampoliinipuisto", "- Treeni"
                } : new List<string>
                {
                    "- Biljardi", "- Elokuvahetki", "- Järvessä uinti", "- Juoksu sateessa", "- Lätäkkö hyppely", "- Piirtäminen", "- Sadepäivän tutkimusretki", "- Sadetanssi", "- Sadevarjo kävely", "- Sateenkaaren metsästys", "- Sisäspa"
                }
            };

            ActivityHelper.PrintActivities(activities);
        }
    }

    class WindyActivity : WeatherActivity
    {
        public override void SuggestActivity(string intensity, string activity)
        {
            var activities = (activity, intensity) switch
            {
                ("perhe", "kova") => new List<string>
                {
                    "- Aallonmetsästys", "- Junamatka", "- Leijan lennätys", "- Kirjan lukeminen", "- Lautapelit", "- Lämmin kylpy", "- Saippuakuplat", "- Sisäaktiviteetit", "- Surffaus", "- Tuulen kuunteleminen"
                },
                ("perhe", "pieni") => new List<string>
                {
                    "- Aaltojen katsominen", "- Leijan lennätys", "- Pyöräily", "- Rantaretki", "- Suppailu", "- Veneily", "- Ulkopelit"
                },
                ("pariskunta", "kova") => new List<string>
                {
                    "- Aallonmetsästys", "- Netflix and Chill", "- Konsertissa käynti", "- Kotibaarikokeilu", "- Kynttilän valossa illallinen", "- Lämmin kylpy", "- Surffaus", "- Videopelit"
                },
                ("pariskunta", "pieni") => new List<string>
                {
                    "- Aaltojen katsominen", "- Leijan lennätys", "- Pyöräily", "- Rantaretki", "- Suppailu", "- Veneily", "- Ulkopelit"
                },
                ("ystäväporukka", "kova") => new List<string>
                {
                    "- Automatka", "- Elokuvateatterissa käynti", "- Kahvilakierros", "- Kokkausilta", "- Palapelit", "- Videopelien pelaaminen"
                },
                ("ystäväporukka", "pieni") => new List<string>
                {
                    "- Aaltojen katselu", "- Kalastus", "- Leijan lennätys", "- Purjehdus", "- Pyöräretki", "- Rantakävely"
                },
                _ => intensity == "kova" ? new List<string>
                {
                    "- Askartelu", "- Elokuvamaratooni", "- Kokkaus", "- Leijan lennätys", "- Opiskelu", "- Palapelit", "- Rentoutuminen", "- Rannalla aaltojen katselu", "- Spapäivä"
                } : new List<string>
                {
                    "- Askartelu", "- Aloita uusi sarja", "- Elokuvamaratooni", "- Kävely", "- Käy elokuvissa", "- Käy katsomasa aallokkoa", "- Kokeile meditointia", "- Kokeile uutta reseptiä", "- Kutsu ystäviä kylään", "- Leijan lennätys", "- Lue kirjaa", "- Mene uimahalliin", "- Musiikin kuuntelu", "- Opettele uusi ohjelma", "- Osallistu tanssitunnille", "- Pelaa videopelejä", "- Piirtäminen", "- Pyöräily", "- Shoppailu", "- Sisällä rentoutuminen", "- Soita instrumenttia", "- Suppailu", "- Tee palapeli", "- Tee aamiainen", "- Tuulen kuuntelu", "- Uusiin paikkoihin tutustuminen", "- Vieraile trampoliiniparkissa"
                }
            };

            ActivityHelper.PrintActivities(activities);
        }
    }

    class CloudyActivity : WeatherActivity
    {
        public override void SuggestActivity(string intensity, string activity)
        {
            var activities = activity switch
            {
                "perhe" => new List<string>
                {
                    "- Eläintarhassa käynti", "- Huvipuistossa käynti", "- Kalastus", "- Kasvitieteellisessä puutarhassa käynti", "- Luontoretki", "- Museokierros", "- Pihapelit", "- Pyöräretki", "- Seikkailupuistot", "- Valokuvausretki"
                },
                "pariskunta" => new List<string>
                {
                    "- Illallinen", "- Kahvilatreffit", "- Kaupunkiseikkailu", "- Kokkailu", "- Kävelyretki", "- Maisemakierros", "- Rantapäivä", "- Spa-päivä", "- Teatterissa käynti", "- Valokuvausretki", "- Veneily"
                },
                "ystäväporukka" => new List<string>
                {
                    "- Kahvilatreffit", "- Kaupunkiseikkailu", "- Keilailu", "- Kävelyretki", "- Lautepeli-ilta", "- Maisemakierros", "- Museokierros", "- Pakohuonepeli", "- Roadtrip", "- Teatterissa käynti", "- Valokuvausretki"
                },
                _ => new List<string>
                {
                    "- Askartelu", "- Bucket listin tekeminen", "- Elokuvailta", "- Frisbeegolf", "- Järjestä tavarasi", "- Jooga", "- Juoksulenkki", "- Kahvila", "- Kirjan lukeminen", "- Kirjoita päiväkirjaa", "- Kirjoittaminen", "- Kirpputorit", "- Kokeile DIY-projekteja", "- Kokeile uutta reseptiä", "- Kylpyläpäivä", "- Laupapeli-ilta", "- Lukeminen", "- Maalaaminen", "- Marjastus", "- Meditaatio", "- Mene ostoksille", "- Metsäkävely", "- Museokierros", "- Patikointi", "- Pelaaminen", "- Piknik", "- Pokemon Go", "- Pyöräily", "- Sarjamaraton", "- Terassikahvit", "- Ulkokuntosali", "- Valokuvaus"
                }
            };

            ActivityHelper.PrintActivities(activities);
        }
    }

    class SunnyActivity : WeatherActivity
    {
        public override void SuggestActivity(string intensity, string activity)
        {
            var activities = activity switch
            {
                "perhe" => new List<string>
                {
                    "- Auringonlaskun katselu", "- Kotieläintarhassa vierailu", "- Marjastus", "- Minigolf", "- Piknik", "- Rantapäivä", "- Telttailu", "- Ulkoilu", "- Veneily", "- Vesipuistossa käynti", "- Vesisota"
                },
                "pariskunta" => new List<string>
                {
                    "- Auringonlaskun katselu", "- Huvipuistotreffit", "- Jäätelötreffit", "- Kahvilatreffit", "- Kylpylässä käynti", "- Piknik", "- Pyöräilyretki", "- Rantapäivä", "- Telttailu", "- Veneily", "- Viinitila"
                },
                "ystäväporukka" => new List<string>
                {
                    "- Auringon ottaminen", "- Grillibileet", "- Hiekkalinnan rakentaminen", "- Huvipuisto-päivä", "- Kävelyretki", "- Maisemakierros", "- Minigolf", "- Puistopelit", "- Pyöräretki", "- Rantapäivä", "- Roadtrip", "- Seikkailupuisto", "- Yöuinti"
                },
                _ => new List<string>
                {
                    "- Auringon otto", "- Auringonlaskun katselu", "- Frisbeegolf", "- Grillaus", "- Kahvilassa käynti", "- Kalastus", "- Kaupungin tutkiminen", "- Kirpputorikierros", "- Koripallo", "- Lautapelit", "- Lue kirjaa", "- Luontopäivä", "- Marjojen poiminta", "- Melonta", "- Mene kävelylle", "- Museokierros", "- Patikointi", "- Piknik", "- Pokemon Go", "- Pyöräily", "- Rantapäivä", "- Sulkapallo", "- Terassilla rentoutuminen", "- Uiminen", "- Urheilu", "- Ulkojooga", "- Valokuvaus"
                }
            };

            ActivityHelper.PrintActivities(activities);
        }
    }
}

    static class ActivityHelper
    {
        public static void PrintActivities(List<string> activities)
        {
            foreach (var activity in activities)
            {
                Console.WriteLine(activity);
            }
        }
    }
