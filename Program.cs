using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SäähänSopivaOhjelma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna tämänhetkinen säätila (esim. ukkonen, lumisade, sade, tuulinen, pilvinen, aurinkoinen):");
            string weather = Console.ReadLine().ToLower();

            Console.WriteLine("Onko sää kova vai pieni? (kirjoita 'kova' tai 'pieni', jos sovellettavissa):");
            string intensity = Console.ReadLine().ToLower();

            Console.WriteLine("Aktiviteettiehdotus:");

            switch (weather)
            {
                case "ukkonen":
                    Console.WriteLine("- Elokuvailta pimeässä");
                    break;
                case "lumisade":
                    if (intensity == "kova")
                        Console.WriteLine("- Kokkaus / leivonta");
                    else if (intensity == "pieni")
                        Console.WriteLine("- Lumisota");
                    else
                        Console.WriteLine("- Lumenveisto tai rentoutuminen sisällä");
                    break;
                case "sade":
                    if (intensity == "kova")
                        Console.WriteLine("- Opiskelu");
                    else if (intensity == "pieni")
                        Console.WriteLine("- Lukeminen tai rentoutuminen sisällä");
                    else
                        Console.WriteLine("- Pelien pelaaminen tai askartelu");
                    break;
                case "tuulinen":
                    if (intensity == "kova")
                        Console.WriteLine("- Rannalla aaltojen katsominen tai metsässä taipuvat puut");
                    else
                        Console.WriteLine("- Askartelu tai käsityöt");
                        Console.WriteLine("- Aloita uusi sarja");
                        Console.WriteLine("- Elokuvamaratooni");
                        Console.WriteLine("- Kävely rannalla tai puistossa");
                        Console.WriteLine("- Käy elokuvissa tai taidenäyttelyssä");
                        Console.WriteLine("- Käy katsomasa aallokkoa");
                        Console.WriteLine("- Kokeile meditointia");
                        Console.WriteLine("- Kokeile uutta reseptiä tai leipomista");
                        Console.WriteLine("- Kutsu ystäviä kylään");
                        Console.WriteLine("- Leijan lennätys (jos tuuli on tarpeeksi kova)");
                        Console.WriteLine("- Lue kirjaa tai kuuntele podcastia");
                        Console.WriteLine("- Mene käymään uimahallissa tai keilaamassa");
                        Console.WriteLine("- Musiikin kuuntelu, soittaminen tai laulaminen");
                        Console.WriteLine("- Opettele uuden ohjelman käyttöä, esimerkiksi Photoshop");
                        Console.WriteLine("- Osallistu tanssitunnille");
                        Console.WriteLine("- Pelaa videopelejä kavereiden kanssa tai yksin");
                        Console.WriteLine("- Piirtäminen");
                        Console.WriteLine("- Pyöräily");
                        Console.WriteLine("- Shoppailu");
                        Console.WriteLine("- Sisällä rentoutuminen");
                        Console.WriteLine("- Soita instrumenttia tai opettele uusi biisi");
                        Console.WriteLine("- Suppailu tai melonta");
                        Console.WriteLine("- Tee palapeli");
                        Console.WriteLine("- Tee kunnon aamianen tai brunssi");
                        Console.WriteLine("- Tuulen kuuntelu");
                        Console.WriteLine("- Uusiin paikkoihin tutustuminen");
                        Console.WriteLine("- Vieraile trampoliiniparkissa tai sisäkiipeilykeskuksessa");
                    break;
                case "pilvinen":
                    Console.WriteLine("- Askartelu");
                    Console.WriteLine("- Bucket listin tekeminen");
                    Console.WriteLine("- Elokuvailta kotona tai elokuvateatterissa käynti");
                    Console.WriteLine("- Frisbeegolf, minigolf tai sulkapallo");
                    Console.WriteLine("- Järjestä omat tavarasi");
                    Console.WriteLine("- Jooga");
                    Console.WriteLine("- Juoksulenkki");
                    Console.WriteLine("- Kahvila");
                    Console.WriteLine("- Kirjan lukeminen tai kirjastossa käynti");
                    Console.WriteLine("- Kirjoita päiväkirjaa");
                    Console.WriteLine("- Kirjoittaminen puistossa tai rannalla");
                    Console.WriteLine("- Kirpputorit");
                    Console.WriteLine("- Kokeile DIY-projekteja");
                    Console.WriteLine("- Kokeile uutta reseptiä tai leivo jotain hyvää");
                    Console.WriteLine("- Kylpyläpäivä kynttiöiden ja kasvonaamioiden kera");
                    Console.WriteLine("- Laupapeli- tai korttipeli-ilta");
                    Console.WriteLine("- Lukeminen");
                    Console.WriteLine("- Maalaaminen tai piirtäminen");
                    Console.WriteLine("- Marjastus");
                    Console.WriteLine("- Meditaatio");
                    Console.WriteLine("- Mene ostoksille");
                    Console.WriteLine("- Metsäkävely");
                    Console.WriteLine("- Museokierros tai taidenäyttely");
                    Console.WriteLine("- Patikointi tai telttailu");
                    Console.WriteLine("- Pelaaminen tietokoneella");
                    Console.WriteLine("- Piknik");
                    Console.WriteLine("- Pokemon Go");
                    Console.WriteLine("- Pyöräily");
                    Console.WriteLine("- Sarjamaraton");
                    Console.WriteLine("- Terassikahvit tai -lounas");
                    Console.WriteLine("- Ulkokuntosali tai porrastreeni");
                    Console.WriteLine("- Valokuvaus");
                    break;
                case "aurinkoinen":
                    Console.WriteLine("- Auringon otto");
                    Console.WriteLine("- Auringonlaskun tai -nousun katselu");
                    Console.WriteLine("- Frisbeegolffaus tai minigolf");
                    Console.WriteLine("- Grillaus");
                    Console.WriteLine("- Kahvilassa käynti");
                    Console.WriteLine("- Kalastus");
                    Console.WriteLine("- Kaupungin tutkiminen");
                    Console.WriteLine("- Kirpputorikierros");
                    Console.WriteLine("- Koripallon tai jalkapallon pelaaminen");
                    Console.WriteLine("- Lautapelit ulkona");
                    Console.WriteLine("- Lue kirjaa parvekkeella tai riippumatossa");
                    Console.WriteLine("- Luontopäivä, esimerkiksi luonnonsuojelualue tai metsä");
                    Console.WriteLine("- Marjojen poiminta");
                    Console.WriteLine("- Melonta tai suppaus");
                    Console.WriteLine("- Mene kävelylle");
                    Console.WriteLine("- Museokierros tai turistinähtävyydet");
                    Console.WriteLine("- Patikointi tai telttailu");
                    Console.WriteLine("- Piknik (bonus - puistossa tai rannalla");
                    Console.WriteLine("- Pokemon Go");
                    Console.WriteLine("- Pyöräily");
                    Console.WriteLine("- Rantapäivä");
                    Console.WriteLine("- Sulkapallo, tennis tai padel");
                    Console.WriteLine("- Terassilla rentoutuminen kylmän juoman kera");
                    Console.WriteLine("- Uiminen");
                    Console.WriteLine("- Urheilu (bonus - lentopallo)");
                    Console.WriteLine("- Ulkojooga");
                    Console.WriteLine("- Valokuvaus");
                    break;
                default:
                    Console.WriteLine("- Ulkoilu, harrastus tai uuden oppiminen");
                    break;
            }

            Console.WriteLine("Paina mitä tahansa näppäintä lopettaaksesi.");
            Console.ReadKey();
        }
    }
}
