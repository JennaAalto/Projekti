using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace SäähänSopivaOhjelma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna tämänhetkinen säätila (esim. ukkonen, lumisade, sateinen, tuulinen, pilvinen, aurinkoinen):");
            string weather = Console.ReadLine().ToLower();

            Console.WriteLine("Onko sää kova vai pieni? (kirjoita 'kova' tai 'pieni', jos sovellettavissa):");
            string intensity = Console.ReadLine().ToLower();

            Console.WriteLine("Kenen kanssa osallistut? (esim. 'perhe', 'pariskunta', 'ystäväporukka', jos haluat tarkempia ehdotuksia):");
            string activity = Console.ReadLine().ToLower();

            Console.WriteLine("Aktiviteettiehdotus:");

            switch (weather)
            {
                case "ukkonen":
                    if (activity == "perhe")
                    {
                        Console.WriteLine("- Askartelu");
                        Console.WriteLine("- Elokuvamaratooni");
                        Console.WriteLine("- Kotispaa, esimerkiksi kasvonaamiot");
                        Console.WriteLine("- Leivonta");
                        Console.WriteLine("- Palapelit tai lautapelit, esimerkiksi Monopoli");
                        Console.WriteLine("- Salamanmetsästys");
                        Console.WriteLine("- Tarinankerronta");
                        Console.WriteLine("- Tyynymajan rakentaminen");
                        Console.WriteLine("- Ukkosmyrsky-aikakapseli, kirjoitetaan kirje tulevaisuuden itselle");
                        break;
                    }

                    else if (activity == "pariskunta")
                    {
                        Console.WriteLine("- Karaoke kotona");
                        Console.WriteLine("- Kokkailu");
                        Console.WriteLine("- Musiikin kuuntelu tai soittaminen yhdessä");
                        Console.WriteLine("- Spa-päivä");
                        Console.WriteLine("- Romanttinen illallinen");
                        Console.WriteLine("- Tyynymaja");
                        Console.WriteLine("- Yhteinen äänikirjan kuuntelu");
                        Console.WriteLine("- Ukkosen katselu");
                        break;
                    }

                    else if (activity == "ystäväporukka")
                    {
                        Console.WriteLine("- Discord pelituokio");
                        Console.WriteLine("- Kaakaota ja lautapelejä");
                        Console.WriteLine("- Karaoke");
                        Console.WriteLine("- Kauhutarinat");
                        Console.WriteLine("- Kokkailu");
                        Console.WriteLine("- Musiikin kuuntelu tai soittaminen yhdessä");
                        Console.WriteLine("- Teema illallinen, esimerkiksi lempihahmo");
                        Console.WriteLine("- Ukkosen katselu");
                        break;
                    }

                    Console.WriteLine("- Askartelu");
                    Console.WriteLine("- Elokuvailta pimeässä");
                    Console.WriteLine("- Kirjoittaminen");
                    Console.WriteLine("- Kynttilänvalossa rentoutuminen");
                    Console.WriteLine("- Myrskyn katsominen");
                    Console.WriteLine("- Palapelit");
                    Console.WriteLine("- Salamanmetsästys");
                    Console.WriteLine("- Tarinan kerronta");
                    Console.WriteLine("- Tyynymaja");
                    Console.WriteLine("- Sääpäiväkirjan täyttäminen");
                    Console.WriteLine("- Ukkosmyrsky aikakapseli");
                    break;

                case "lumisade":
                    if (activity == "perhe" && intensity == "kova")
                    {
                        Console.WriteLine("- Askartelu");
                        Console.WriteLine("- Elokuvamaraton");
                        Console.WriteLine("- Kokkaus tai leivonta, esimerkiksi piparit tai joulutortut");
                        Console.WriteLine("- Lautapelit tai korttipelit, esimerkiksi Uno");
                        Console.WriteLine("- Lumikoristelut ikkunaan, esimerkiksi paperihiutaleet");
                        Console.WriteLine("- Lämmin kylpy tai saunailta");
                        Console.WriteLine("- Sisämajan rakentaminen tyynyistä ja peitoista");
                        Console.WriteLine("- Vanhojen valokuvien katselu");

                        break;
                    }
                    else if (activity == "perhe" && intensity == "pieni")
                    {
                        Console.WriteLine("- Kuumat juomat");
                        Console.WriteLine("- Luistelu");
                        Console.WriteLine("- Lumisota");
                        Console.WriteLine("- Lumiukon rakentaminen");
                        Console.WriteLine("- Lumilyhdyt");
                        Console.WriteLine("- Lumikenkäily tai talvinen kävely");
                        Console.WriteLine("- Pulkkailu");
                        Console.WriteLine("- Sadetanssi, mutta lumessa");
                        Console.WriteLine("- Takan edessä lämmittely");
                        Console.WriteLine("- Talvimarkkinoille meno");
                    }

                    else if (activity == "pariskunta" && intensity == "kova")
                    {
                        Console.WriteLine("- Kotona Netflix and Chill");
                        Console.WriteLine("- Leffailta herkkujen kera");
                        Console.WriteLine("- Leipominen yhdessä, esimerkiksi suklaakeksit");
                        Console.WriteLine("- Lämmin kylpy yhdessä");
                        Console.WriteLine("- Takkatulen ääressä oleilu");
                        Console.WriteLine("- Videopelit, esimerkiksi Mario Kart");
                        break;
                    }
                    else if (activity == "pariskunta" && intensity == "pieni")
                    {
                        Console.WriteLine("- Hiihtäminen");
                        Console.WriteLine("- Koiravaljakkoajelu");
                        Console.WriteLine("- Luistelu");
                        Console.WriteLine("- Lumikenkäkävely");
                        Console.WriteLine("- Makkarangrillaus");
                        Console.WriteLine("- Sauna ja avantouinti");
                        Console.WriteLine("- Talvinen metsäretki");
                    }

                    else if (activity == "ystäväporukka" && intensity == "kova")
                    {
                        Console.WriteLine("- Leffailta herkkujen kera");
                        Console.WriteLine("- Leipominen yhdessä, esimerkiksi suklaakeksit");
                        Console.WriteLine("- Sisäsauna ja lumessa pyöriskely");
                        Console.WriteLine("- Takkatulen ääressä oleilu");
                        Console.WriteLine("- Videopelit, esimerkiksi Mario Kart");
                        break;
                    }
                    else if (activity == "ystäväporukka" && intensity == "pieni")
                    {
                        Console.WriteLine("- Hiihtäminen");
                        Console.WriteLine("- Luistelu");
                        Console.WriteLine("- Lumikenkäkävely");
                        Console.WriteLine("- Nuotiohetki, esimerkiksi makkaran grillaus ja kaakao");
                        Console.WriteLine("- Sauna ja avantouinti");
                    }

                    else if (intensity == "kova")
                    {
                        Console.WriteLine("- Elokuva maratooni");
                        Console.WriteLine("- Kokkaus tai leivonta");
                        Console.WriteLine("- Lautapelit");
                        Console.WriteLine("- Lumikoristelu");
                        Console.WriteLine("- Lämmittelyhetki takan ääressä");
                        Console.WriteLine("- Opiskelu");
                        Console.WriteLine("- Sisämaja");
                        Console.WriteLine("- Vanhojen valokuvien katselu");
                    }

                    else if (intensity == "pieni")
                    { 
                        Console.WriteLine("- Fondue-ilta, dippaa esimerkiksi hedelmiä suklaaseen tai juustoon");
                        Console.WriteLine("- Iglun rakentaminen");
                        Console.WriteLine("- Kirja ja viltin alla rentoutuminen");
                        Console.WriteLine("- Kuumat juomat");
                        Console.WriteLine("- Laskettelu");
                        Console.WriteLine("- Leivonta, esimerkiksi piparit ja tortut");
                        Console.WriteLine("- Lumiaiheiset askartelut");
                        Console.WriteLine("- Lumienkeli");
                        Console.WriteLine("- Lumilyhdyt");
                        Console.WriteLine("- Lumikenkäily");
                        Console.WriteLine("- Lumisota");
                        Console.WriteLine("- Lumiukon rakentaminen");
                        Console.WriteLine("- Luistelu");
                        Console.WriteLine("- Lämmin kylpy");
                        Console.WriteLine("- Pulkkailu");
                        Console.WriteLine("- Talvikeitto");
                        Console.WriteLine("- Talvimarkkinat");
                        Console.WriteLine("- Talvinen kävely");
                        Console.WriteLine("- Yö kävely lumessa");

                    }
                    else
                        Console.WriteLine("- Lumenveisto tai rentoutuminen sisällä");
                    break;

                case "sateinen":
                    if (activity == "perhe" && intensity == "kova")
                    {
                        Console.WriteLine("- Askartelu");
                        Console.WriteLine("- Elokuvamaraton");
                        Console.WriteLine("- Kokkaus tai leivonta, esimerkiksi pizza tai pannukakku");
                        Console.WriteLine("- Kirjan lukeminen tai satutuokio");
                        Console.WriteLine("- Lautapelit tai korttipelit");
                        Console.WriteLine("- Lämmin kylpy tai saunailta");
                        Console.WriteLine("- Naamiaiset, esimerkiksi pukeutukaa vanhoihin halloween asuihin");
                        Console.WriteLine("- Palapelit");
                        Console.WriteLine("- Sisämajan rakentaminen tyynyistä ja peitoista");
                        Console.WriteLine("- Tanssibileet");
                        break;
                    }
                    else if (activity == "perhe" && intensity == "pieni")
                    {
                        Console.WriteLine("- Kalastus");
                        Console.WriteLine("- Kuralätäkköhyppely kumisaappaissa");
                        Console.WriteLine("- Lintubongaus");
                        Console.WriteLine("- Luontoretki sadevaatteissa");
                        Console.WriteLine("- Sadetanssi");
                        Console.WriteLine("- Sammakkojen etsintä");
                        Console.WriteLine("- Ulkopelit, esimerkiksi frisbeegolf, polttopallo tai hippa");
                    }

                    else if (activity == "pariskunta" && intensity == "kova")
                    {
                        Console.WriteLine("- Netflix ja Chill herkkujen kera");
                        Console.WriteLine("- Kirjan lukeminen yhdessä");
                        Console.WriteLine("- Kotibaarikokeilu");
                        Console.WriteLine("- Kylpy yhdessä");
                        Console.WriteLine("- Romanttinen illallinen kynttilän kera");
                        Console.WriteLine("- Teatterissa käynti");
                        Console.WriteLine("- Videopelien pelaaminen yhdessä");
                        break;
                    }
                    else if (activity == "pariskunta" && intensity == "pieni")
                    {
                        Console.WriteLine("- Metsäretki sadevaatteiden kera");
                        Console.WriteLine("- Kahvilatreffit");
                        Console.WriteLine("- Kirjastossa käynti");
                        Console.WriteLine("- Kirpputorikierros tai shoppailu");
                        Console.WriteLine("- Kylpylässä käynti");
                        Console.WriteLine("- Saunassa käynti yhdessä");
                    }

                    else if (activity == "ystäväporukka" && intensity == "kova")
                    {
                        Console.WriteLine("- Leffamaratooni");
                        Console.WriteLine("- Karaoke-ilta");
                        Console.WriteLine("- Kokkausilta");
                        Console.WriteLine("- Kotibaari, esimerkiksi uusien drinkkien kokeilu");
                        Console.WriteLine("- Palapelit");
                        Console.WriteLine("- Videopelien pelaaminen yhdessä");
                        break;
                    }
                    else if (activity == "ystäväpurkka" && intensity == "pieni")
                    {
                        Console.WriteLine("- Kalastus");
                        Console.WriteLine("- Kaupunkiseikkailu sateenvarjon alla");
                        Console.WriteLine("- Kylpylässä käynti");
                        Console.WriteLine("- Kuralätäköissä hyppiminen");
                        Console.WriteLine("- Lintubongaus");
                        Console.WriteLine("- Shoppailu");
                    }

                    else if (intensity == "kova")
                    {
                        Console.WriteLine("- Discord gaming sessio");
                        Console.WriteLine("- Elokuvamaratooni");
                        Console.WriteLine("- Facetime perheelle tai ystävälle");
                        Console.WriteLine("- Järjestelypäivä");
                        Console.WriteLine("- Kirjapäivä");
                        Console.WriteLine("- Kirjoittaminen päiväkirjaan");
                        Console.WriteLine("- Kylpy tai pitkä suihku");
                        Console.WriteLine("- Lautapelit ja korttipelit");
                        Console.WriteLine("- Leivonta");
                        Console.WriteLine("- Maalaus tai piirtäminen");
                        Console.WriteLine("- Opiskelu");
                        Console.WriteLine("- Rakentaa tyynymaja");
                        Console.WriteLine("- Sateen katselu");
                        Console.WriteLine("- Tee tai viini maistelu");
                        Console.WriteLine("- Trampoliinipuisto");
                        Console.WriteLine("- Treeni sisällä tai kuntosali");
                    }
                    else if (intensity == "pieni")
                    { 
                        Console.WriteLine("- Biljardi");
                        Console.WriteLine("- Elokuvahetki");
                        Console.WriteLine("- Järvessä uinti");
                        Console.WriteLine("- Juoksu sateessa");
                        Console.WriteLine("- Lätäkkö hyppely kumisaappat jalassa");
                        Console.WriteLine("- Piirtäminen");
                        Console.WriteLine("- Sadepäivän tutkimusretki");
                        Console.WriteLine("- Sadetanssi");
                        Console.WriteLine("- Sadevarjo kävely");
                        Console.WriteLine("- Sateenkaaren metsästys");
                        Console.WriteLine("- Sisäspa");
                    }
                    else
                        Console.WriteLine("- Askartelu");
                        Console.WriteLine("- Kokkaaminen ja leipominen");
                        Console.WriteLine("- Pelien pelaaminen tai askartelu");
                        Console.WriteLine("- Rentoutuminen");
                        Console.WriteLine("- Sateenvarjo kävely");
                    break;

                case "tuulinen":
                    if (activity == "perhe" && intensity == "kova")
                    {
                        Console.WriteLine("- Aallonmetsästys tai huojuvien puiden katselu");
                        Console.WriteLine("- Junamatka");
                        Console.WriteLine("- Leijan lennätys");
                        Console.WriteLine("- Kirjan lukeminen tai satutuokio");
                        Console.WriteLine("- Lautapelit tai korttipelit");
                        Console.WriteLine("- Lämmin kylpy");
                        Console.WriteLine("- Saippuakuplat");
                        Console.WriteLine("- Sisäaktiviteetit, esimerkiksi palapelit tai lautapelit");
                        Console.WriteLine("- Surffaus tai purjelautailu");
                        Console.WriteLine("- Tuulen kuunteleminen");
                        break;
                    }
                    else if (activity == "perhe" && intensity == "pieni")
                    {
                        Console.WriteLine("- Aaltojen katsominen");
                        Console.WriteLine("- Leijan lennätys");
                        Console.WriteLine("- Pyöräily");
                        Console.WriteLine("- Rantaretki");
                        Console.WriteLine("- Suppailu");
                        Console.WriteLine("- Veneily tai melonta");
                        Console.WriteLine("- Ulkopelit, esimerkiksi frisbeegolf tai jalkapallo");
                    }

                    else if (activity == "pariskunta" && intensity == "kova")
                    {
                        Console.WriteLine("- Aallonmetsästys tai huojuvien puiden katselu");
                        Console.WriteLine("- Kotona Netflix and Chill");
                        Console.WriteLine("- Konsertissa käynti");
                        Console.WriteLine("- Kotibaarikokeilu");
                        Console.WriteLine("- Kynttilän valossa illallinen");
                        Console.WriteLine("- Lämmin kylpy yhdessä");
                        Console.WriteLine("- Surffaus tai purjelautailu");
                        Console.WriteLine("- Videopelit, esimerkiksi Mario Kart");
                        break;
                    }
                    else if (activity == "pariskunta" && intensity == "pieni")
                    {
                        Console.WriteLine("- Aaltojen katsominen");
                        Console.WriteLine("- Leijan lennätys");
                        Console.WriteLine("- Pyöräily");
                        Console.WriteLine("- Rantaretki");
                        Console.WriteLine("- Suppailu");
                        Console.WriteLine("- Veneily tai melonta");
                        Console.WriteLine("- Ulkopelit, esimerkiksi frisbeegolf tai jalkapallo");
                    }

                    else if (activity == "ystäväporukka" && intensity == "kova")
                    {
                        Console.WriteLine("- Automatka");
                        Console.WriteLine("- Elokuvateatterissa käynti");
                        Console.WriteLine("- Kahvilakierros");
                        Console.WriteLine("- Kokkausilta");
                        Console.WriteLine("- Palapelit");
                        Console.WriteLine("- Videopelien pelaaminen yhdessä");
                        break;
                    }
                    else if (activity == "ystäväpurkka" && intensity == "pieni")
                    { 
                        Console.WriteLine("- Aaltojen katselu");
                        Console.WriteLine("- Kalastus");
                        Console.WriteLine("- Leijan lennätys");
                        Console.WriteLine("- Purjehdus tai suppailu");
                        Console.WriteLine("- Pyöräretki");
                        Console.WriteLine("- Rantakävely");
                    }

                    else if (intensity == "kova")
                    {
                        Console.WriteLine("- Askartelu tai käsityöt");
                        Console.WriteLine("- Elokuvamaratooni tai uuden sarjan aloittaminen");
                        Console.WriteLine("- Kokkaus tai leipominen");
                        Console.WriteLine("- Leijan lennätys");
                        Console.WriteLine("- Opiskelu");
                        Console.WriteLine("- Palapelit ");
                        Console.WriteLine("- Rentoudu tai ota torkut");
                        Console.WriteLine("- Rannalla aaltojen katsominen tai metsässä taipuvat puut");
                        Console.WriteLine("- Spapäivä");
                    }
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
                    if (activity == "perhe")
                    {
                        Console.WriteLine("- Eläintarhassa käynti");
                        Console.WriteLine("- Huvipuistossa käynti");
                        Console.WriteLine("- Kalastus");
                        Console.WriteLine("- Kasvitieteellisessä puutarhassa käynti");
                        Console.WriteLine("- Luontoretki tai patikointi tai telttailu");
                        Console.WriteLine("- Museokierros tai sisäkiipeilykeskukset");
                        Console.WriteLine("- Pihapelit tai urheilu, esimerkiksi mölkky");
                        Console.WriteLine("- Pyöräretki");
                        Console.WriteLine("- Seikkailupuistot tai köysiradat");
                        Console.WriteLine("- Valokuvausretki");
                        break;
                    }

                    else if (activity == "pariskunta")
                    {
                        Console.WriteLine("- Illallinen");
                        Console.WriteLine("- Kahvilatreffit");
                        Console.WriteLine("- Kaupunkiseikkailu");
                        Console.WriteLine("- Kokkailu");
                        Console.WriteLine("- Kävelyretki luonnossa");
                        Console.WriteLine("- Maisemakierros");
                        Console.WriteLine("- Rantapäivä");
                        Console.WriteLine("- Spa-päivä");
                        Console.WriteLine("- Teatterissa tai elokuvissa käynti");
                        Console.WriteLine("- Valokuvausretki");
                        Console.WriteLine("- Veneily");
                        break;
                    }

                    else if (activity == "ystäväporukka")
                    {
                        Console.WriteLine("- Kahvilatreffit");
                        Console.WriteLine("- Kaupunkiseikkailu");
                        Console.WriteLine("- Keilailu");
                        Console.WriteLine("- Kävelyretki luonnossa");
                        Console.WriteLine("- Lautepeli-ilta herkkujen kera");
                        Console.WriteLine("- Maisemakierros");
                        Console.WriteLine("- Museokierros");
                        Console.WriteLine("- Pakohuonepeli");
                        Console.WriteLine("- Roadtrip");
                        Console.WriteLine("- Teatterissa tai elokuvissa käynti");
                        Console.WriteLine("- Valokuvausretki");
                        break;
                    }

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
                    if (activity == "perhe")
                    {
                        Console.WriteLine("- Auringonlaskun katselu");
                        Console.WriteLine("- Kotieläintarhassa vierailu");
                        Console.WriteLine("- Marjastus");
                        Console.WriteLine("- Minigolf tai frisbeegolf");
                        Console.WriteLine("- Piknik");
                        Console.WriteLine("- Rantapäivä");
                        Console.WriteLine("- Telttailu");
                        Console.WriteLine("- Ulkoilu, esimerkiksi urheilu");
                        Console.WriteLine("- Veneily");
                        Console.WriteLine("- Vesipuistossa käynti");
                        Console.WriteLine("- Vesisota");
                        break;
                    }

                    else if (activity == "pariskunta")
                    {
                        Console.WriteLine("- Auringonlaskun katselu");
                        Console.WriteLine("- Huvipuistotreffit");
                        Console.WriteLine("- Jäätelötreffit");
                        Console.WriteLine("- Kahvilatreffit");
                        Console.WriteLine("- Kylpylässä käynti");
                        Console.WriteLine("- Piknik puistossa tai rannalla");
                        Console.WriteLine("- Pyöräilyretki");
                        Console.WriteLine("- Rantapäivä");
                        Console.WriteLine("- Telttailu");
                        Console.WriteLine("- Veneily");
                        Console.WriteLine("- Viinitila tai panimovierailu");
                        break;
                    }

                    else if (activity == "ystäväporukka")
                    {
                        Console.WriteLine("- Auringon ottaminen");
                        Console.WriteLine("- Grillibileet");
                        Console.WriteLine("- Hiekkalinnan rakentaminen");
                        Console.WriteLine("- Huvipuisto-päivä");
                        Console.WriteLine("- Kävelyretki luonnossa");
                        Console.WriteLine("- Maisemakierros");
                        Console.WriteLine("- Minigolf");
                        Console.WriteLine("- Puistopelit tai urheilu, esimerkiksi jalkapallo tai padel");
                        Console.WriteLine("- Pyöräretki");
                        Console.WriteLine("- Rantapäivä");
                        Console.WriteLine("- Roadtrip");
                        Console.WriteLine("- Seikkailupuisto");
                        Console.WriteLine("- Yöuinti");
                        break;
                    }

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
