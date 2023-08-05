using System.Security.Cryptography;

namespace Games
{
    public class MarkenlogoEntry
    {
        public MarkenlogoEntry( string theName, string theImagePath, int theDifficulty )
        {
            Name = theName;
            LogoPath = theImagePath;
            Difficulty = theDifficulty;
        }

        public string LogoPath { get; set; }
        public string Name { get; set; }

        public int Difficulty { get; set; }
    }

    public class Markenlogos : GameBase
    {
        public Markenlogos( int theGameNumber, string theName ) : base( theGameNumber, theName, GameType.PictureAndAnswer )
        {
            Logos = new List<MarkenlogoEntry>
            {
                new MarkenlogoEntry("Adobe", Path.Combine(RessourceFolder, "adobe.png"), 2),
                new MarkenlogoEntry("Airbnb", Path.Combine(RessourceFolder, "airbnb.png"), 3),
                new MarkenlogoEntry("Ariel", Path.Combine(RessourceFolder, "ariel.png"), 4),
                new MarkenlogoEntry("Atari", Path.Combine(RessourceFolder, "Atari.png"), 1),
                new MarkenlogoEntry("Bacardi", Path.Combine(RessourceFolder, "bacardi.png"), 1),
                new MarkenlogoEntry("Beck's", Path.Combine(RessourceFolder, "becks.png"), 1),
                new MarkenlogoEntry("Cadillac", Path.Combine(RessourceFolder, "cadillac.png"), 4),
                new MarkenlogoEntry("Captain Morgan", Path.Combine(RessourceFolder, "captain_morgan.png"), 1),
                new MarkenlogoEntry("Citroen", Path.Combine(RessourceFolder, "citroen.png"), 2),
                new MarkenlogoEntry("Deutsche Bank", Path.Combine(RessourceFolder, "deutsche_bank.png"), 1),
                new MarkenlogoEntry("Dr Oetker", Path.Combine(RessourceFolder, "dr_oetker.png"), 2),
                new MarkenlogoEntry("Eizo", Path.Combine(RessourceFolder, "eizo.png"), 3),
                new MarkenlogoEntry("Fiat", Path.Combine(RessourceFolder, "fiat.png"), 5),
                new MarkenlogoEntry("Firefox", Path.Combine(RessourceFolder, "firefox.png"), 1),
                new MarkenlogoEntry("Fisherman's Friend", Path.Combine(RessourceFolder, "fishermans_friend.png"), 4),
                new MarkenlogoEntry("Foster's", Path.Combine(RessourceFolder, "fosters.png"), 5),
                new MarkenlogoEntry("Frosta", Path.Combine(RessourceFolder, "frosta.png"), 3),
                new MarkenlogoEntry("Gardena", Path.Combine(RessourceFolder, "gardena.png"), 3),
                new MarkenlogoEntry("Goodyear", Path.Combine(RessourceFolder, "goodyear.png"), 4),
                new MarkenlogoEntry("Gucci", Path.Combine(RessourceFolder, "gucci.png"), 1),
                new MarkenlogoEntry("Guinness", Path.Combine(RessourceFolder, "guiness.png"), 2),
                new MarkenlogoEntry("Hansaplast", Path.Combine(RessourceFolder, "hansaplast.png"), 3),
                new MarkenlogoEntry("Harley Davidson", Path.Combine(RessourceFolder, "harley_davidson.png"), 3),
                new MarkenlogoEntry("Harry", Path.Combine(RessourceFolder, "harry.png"), 2),
                new MarkenlogoEntry("Heineken", Path.Combine(RessourceFolder, "heineken.png"), 2),
                new MarkenlogoEntry("Hermes", Path.Combine(RessourceFolder, "hermes.png"), 5),
                new MarkenlogoEntry("Hitschies", Path.Combine(RessourceFolder, "hitschies.png"), 5),
                new MarkenlogoEntry("Hornbach", Path.Combine(RessourceFolder, "hornbach.png"), 1),
                new MarkenlogoEntry("Hot Wheels", Path.Combine(RessourceFolder, "hot_wheels.png"), 2),
                new MarkenlogoEntry("Iglo", Path.Combine(RessourceFolder, "iglo.png"), 4),
                new MarkenlogoEntry("Intel", Path.Combine(RessourceFolder, "intel.png"), 4),
                new MarkenlogoEntry("Jaegermeister", Path.Combine(RessourceFolder, "jaegermeister.png"), 2),
                new MarkenlogoEntry("JBL", Path.Combine(RessourceFolder, "jbl.png"), 5),
                new MarkenlogoEntry("John Deere", Path.Combine(RessourceFolder, "john_deere.png"), 3),
                new MarkenlogoEntry("Kalashnikov", Path.Combine(RessourceFolder, "kalashnikov.png"), 5),
                new MarkenlogoEntry("Katjes", Path.Combine(RessourceFolder, "katjes.png"), 2),
                new MarkenlogoEntry("KFC", Path.Combine(RessourceFolder, "kfc.png"), 1),
                new MarkenlogoEntry("KIA", Path.Combine(RessourceFolder, "kia.png"), 1),
                new MarkenlogoEntry("Klosterfrau", Path.Combine(RessourceFolder, "klosterfrau.png"), 3),
                new MarkenlogoEntry("Knorr", Path.Combine(RessourceFolder, "knorr.png"), 1),
                new MarkenlogoEntry("Kodak", Path.Combine(RessourceFolder, "kodak.png"), 1),
                new MarkenlogoEntry("Konica Minolta", Path.Combine(RessourceFolder, "konica_minolta.png"), 5),
                new MarkenlogoEntry("Liqui Moly", Path.Combine(RessourceFolder, "liqui_moly.png"), 4),
                new MarkenlogoEntry("Logitech", Path.Combine(RessourceFolder, "logitech.png"), 2),
                new MarkenlogoEntry("LPKF", Path.Combine(RessourceFolder, "lpkf.png"), 3),
                new MarkenlogoEntry("Lucky Strike", Path.Combine(RessourceFolder, "lucky_strike.png"), 4),
                new MarkenlogoEntry("Lufthansa", Path.Combine(RessourceFolder, "lufthansa.png"), 1),
                new MarkenlogoEntry("Maggi", Path.Combine(RessourceFolder, "maggi.png"), 1),
                new MarkenlogoEntry("Marlboro", Path.Combine(RessourceFolder, "marlboro.png"), 2),
                new MarkenlogoEntry("Martini", Path.Combine(RessourceFolder, "martini.png"), 3),
                new MarkenlogoEntry("Meister Proper", Path.Combine(RessourceFolder, "meister_proper.png"), 1),
                new MarkenlogoEntry("Metro Goldwyn Mayer", Path.Combine(RessourceFolder, "metro_goldwyn_mayer.png"), 2),
                new MarkenlogoEntry("Mueller", Path.Combine(RessourceFolder, "mueller.png"), 4),
                new MarkenlogoEntry("Neckermann", Path.Combine(RessourceFolder, "neckermann.png"), 3),
                new MarkenlogoEntry("Paramount", Path.Combine(RessourceFolder, "paramount.png"), 1),
                new MarkenlogoEntry("Pattex", Path.Combine(RessourceFolder, "pattex.png"), 3),
                new MarkenlogoEntry("Philips", Path.Combine(RessourceFolder, "philips.png"), 4),
                new MarkenlogoEntry("Radeberger", Path.Combine(RessourceFolder, "radeberger.png"), 3),
                new MarkenlogoEntry("Reuters", Path.Combine(RessourceFolder, "reuters.png"), 3),
                new MarkenlogoEntry("RTL 2", Path.Combine(RessourceFolder, "rtl_zwei.png"), 2),
                new MarkenlogoEntry("Saab", Path.Combine(RessourceFolder, "saab.png"), 5),
                new MarkenlogoEntry("SAP", Path.Combine(RessourceFolder, "sap.png"), 2),
                new MarkenlogoEntry("Schwartau", Path.Combine(RessourceFolder, "schwartau.png"), 3),
                new MarkenlogoEntry("Sinalco", Path.Combine(RessourceFolder, "sinalco.png"), 4),
                new MarkenlogoEntry("Skoda", Path.Combine(RessourceFolder, "skoda.png"), 1),
                new MarkenlogoEntry("Telegram", Path.Combine(RessourceFolder, "telegram.png"), 2),
                new MarkenlogoEntry("Tetra Pak", Path.Combine(RessourceFolder, "tetra_pak.png"), 4),
                new MarkenlogoEntry("Trigema", Path.Combine(RessourceFolder, "trigema.png"), 3),
                new MarkenlogoEntry("Volvo", Path.Combine(RessourceFolder, "volvo.png"), 1),
                new MarkenlogoEntry("Wasa", Path.Combine(RessourceFolder, "wasa.png"), 5),
                new MarkenlogoEntry("Wuerth", Path.Combine(RessourceFolder, "wuerth.png"), 2),
            };
            Logos = Shuffle<MarkenlogoEntry>(Logos);
        }

        List<MarkenlogoEntry> Logos { get; set; }

        private string SolutionDir => Common.VisualStudioProvider.TryGetSolutionDirectoryInfo().FullName;

        private string RessourceFolder => Path.Combine( SolutionDir, "res", "Markenlogos" );

        private static List<T> Shuffle<T>(List<T> theList )
        {
            var provider = new RNGCryptoServiceProvider();
            int n = theList.Count;
            while ( n > 1 )
            {
                byte[] box = new byte[1];
                do
                {
                    provider.GetBytes( box );
                }
                while ( !( box[0] < n * ( Byte.MaxValue / n ) ) );
                int k = ( box[0] % n );
                n--;
                T value = theList[k];
                theList[k] = theList[n];
                theList[n] = value;
            }
            return theList;
        }


    }
}
