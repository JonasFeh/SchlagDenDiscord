﻿using System.Security.Cryptography;

namespace Games
{
    public abstract class PictureAndAnswerBase : GameBase
    {
        public PictureAndAnswerBase( int theGameNumber, string theName ) : base( theGameNumber, theName, GameType.PictureAndAnswer )
        {
            Elements = new List<PictureAndAnswerElement>
            {
                new PictureAndAnswerElement("Adobe", Path.Combine(RessourceFolder, "adobe.png"), 2),
                new PictureAndAnswerElement("Airbnb", Path.Combine(RessourceFolder, "airbnb.png"), 3),
                new PictureAndAnswerElement("Ariel", Path.Combine(RessourceFolder, "ariel.png"), 4),
                new PictureAndAnswerElement("Atari", Path.Combine(RessourceFolder, "Atari.png"), 1),
                new PictureAndAnswerElement("Bacardi", Path.Combine(RessourceFolder, "bacardi.png"), 1),
                new PictureAndAnswerElement("Beck's", Path.Combine(RessourceFolder, "becks.png"), 1),
                new PictureAndAnswerElement("Cadillac", Path.Combine(RessourceFolder, "cadillac.png"), 4),
                new PictureAndAnswerElement("Captain Morgan", Path.Combine(RessourceFolder, "captain_morgan.png"), 1),
                new PictureAndAnswerElement("Citroen", Path.Combine(RessourceFolder, "citroen.png"), 2),
                new PictureAndAnswerElement("Deutsche Bank", Path.Combine(RessourceFolder, "deutsche_bank.png"), 1),
                new PictureAndAnswerElement("Dr Oetker", Path.Combine(RessourceFolder, "dr_oetker.png"), 2),
                new PictureAndAnswerElement("Eizo", Path.Combine(RessourceFolder, "eizo.png"), 3),
                new PictureAndAnswerElement("Fiat", Path.Combine(RessourceFolder, "fiat.png"), 5),
                new PictureAndAnswerElement("Firefox", Path.Combine(RessourceFolder, "firefox.png"), 1),
                new PictureAndAnswerElement("Fisherman's Friend", Path.Combine(RessourceFolder, "fishermans_friend.png"), 4),
                new PictureAndAnswerElement("Foster's", Path.Combine(RessourceFolder, "fosters.png"), 5),
                new PictureAndAnswerElement("Frosta", Path.Combine(RessourceFolder, "frosta.png"), 3),
                new PictureAndAnswerElement("Gardena", Path.Combine(RessourceFolder, "gardena.png"), 3),
                new PictureAndAnswerElement("Goodyear", Path.Combine(RessourceFolder, "goodyear.png"), 4),
                new PictureAndAnswerElement("Gucci", Path.Combine(RessourceFolder, "gucci.png"), 1),
                new PictureAndAnswerElement("Guinness", Path.Combine(RessourceFolder, "guiness.png"), 2),
                new PictureAndAnswerElement("Hansaplast", Path.Combine(RessourceFolder, "hansaplast.png"), 3),
                new PictureAndAnswerElement("Harley Davidson", Path.Combine(RessourceFolder, "harley_davidson.png"), 3),
                new PictureAndAnswerElement("Harry", Path.Combine(RessourceFolder, "harry.png"), 2),
                new PictureAndAnswerElement("Heineken", Path.Combine(RessourceFolder, "heineken.png"), 2),
                new PictureAndAnswerElement("Hermes", Path.Combine(RessourceFolder, "hermes.png"), 5),
                new PictureAndAnswerElement("Hitschies", Path.Combine(RessourceFolder, "hitschies.png"), 5),
                new PictureAndAnswerElement("Hornbach", Path.Combine(RessourceFolder, "hornbach.png"), 1),
                new PictureAndAnswerElement("Hot Wheels", Path.Combine(RessourceFolder, "hot_wheels.png"), 2),
                new PictureAndAnswerElement("Iglo", Path.Combine(RessourceFolder, "iglo.png"), 4),
                new PictureAndAnswerElement("Intel", Path.Combine(RessourceFolder, "intel.png"), 4),
                new PictureAndAnswerElement("Jaegermeister", Path.Combine(RessourceFolder, "jaegermeister.png"), 2),
                new PictureAndAnswerElement("JBL", Path.Combine(RessourceFolder, "jbl.png"), 5),
                new PictureAndAnswerElement("John Deere", Path.Combine(RessourceFolder, "john_deere.png"), 3),
                new PictureAndAnswerElement("Kalashnikov", Path.Combine(RessourceFolder, "kalashnikov.png"), 5),
                new PictureAndAnswerElement("Katjes", Path.Combine(RessourceFolder, "katjes.png"), 2),
                new PictureAndAnswerElement("KFC", Path.Combine(RessourceFolder, "kfc.png"), 1),
                new PictureAndAnswerElement("KIA", Path.Combine(RessourceFolder, "kia.png"), 1),
                new PictureAndAnswerElement("Klosterfrau", Path.Combine(RessourceFolder, "klosterfrau.png"), 3),
                new PictureAndAnswerElement("Knorr", Path.Combine(RessourceFolder, "knorr.png"), 1),
                new PictureAndAnswerElement("Kodak", Path.Combine(RessourceFolder, "kodak.png"), 1),
                new PictureAndAnswerElement("Konica Minolta", Path.Combine(RessourceFolder, "konica_minolta.png"), 5),
                new PictureAndAnswerElement("Liqui Moly", Path.Combine(RessourceFolder, "liqui_moly.png"), 4),
                new PictureAndAnswerElement("Logitech", Path.Combine(RessourceFolder, "logitech.png"), 2),
                new PictureAndAnswerElement("LPKF", Path.Combine(RessourceFolder, "lpkf.png"), 3),
                new PictureAndAnswerElement("Lucky Strike", Path.Combine(RessourceFolder, "lucky_strike.png"), 4),
                new PictureAndAnswerElement("Lufthansa", Path.Combine(RessourceFolder, "lufthansa.png"), 1),
                new PictureAndAnswerElement("Maggi", Path.Combine(RessourceFolder, "maggi.png"), 1),
                new PictureAndAnswerElement("Marlboro", Path.Combine(RessourceFolder, "marlboro.png"), 2),
                new PictureAndAnswerElement("Martini", Path.Combine(RessourceFolder, "martini.png"), 3),
                new PictureAndAnswerElement("Meister Proper", Path.Combine(RessourceFolder, "meister_proper.png"), 1),
                new PictureAndAnswerElement("Metro Goldwyn Mayer", Path.Combine(RessourceFolder, "metro_goldwyn_mayer.png"), 2),
                new PictureAndAnswerElement("Mueller", Path.Combine(RessourceFolder, "mueller.png"), 4),
                new PictureAndAnswerElement("Neckermann", Path.Combine(RessourceFolder, "neckermann.png"), 3),
                new PictureAndAnswerElement("Paramount", Path.Combine(RessourceFolder, "paramount.png"), 1),
                new PictureAndAnswerElement("Pattex", Path.Combine(RessourceFolder, "pattex.png"), 3),
                new PictureAndAnswerElement("Philips", Path.Combine(RessourceFolder, "philips.png"), 4),
                new PictureAndAnswerElement("Radeberger", Path.Combine(RessourceFolder, "radeberger.png"), 3),
                new PictureAndAnswerElement("Reuters", Path.Combine(RessourceFolder, "reuters.png"), 3),
                new PictureAndAnswerElement("RTL 2", Path.Combine(RessourceFolder, "rtl_zwei.png"), 2),
                new PictureAndAnswerElement("Saab", Path.Combine(RessourceFolder, "saab.png"), 5),
                new PictureAndAnswerElement("SAP", Path.Combine(RessourceFolder, "sap.png"), 2),
                new PictureAndAnswerElement("Schwartau", Path.Combine(RessourceFolder, "schwartau.png"), 3),
                new PictureAndAnswerElement("Sinalco", Path.Combine(RessourceFolder, "sinalco.png"), 4),
                new PictureAndAnswerElement("Skoda", Path.Combine(RessourceFolder, "skoda.png"), 1),
                new PictureAndAnswerElement("Telegram", Path.Combine(RessourceFolder, "telegram.png"), 2),
                new PictureAndAnswerElement("Tetra Pak", Path.Combine(RessourceFolder, "tetra_pak.png"), 4),
                new PictureAndAnswerElement("Trigema", Path.Combine(RessourceFolder, "trigema.png"), 3),
                new PictureAndAnswerElement("Volvo", Path.Combine(RessourceFolder, "volvo.png"), 1),
                new PictureAndAnswerElement("Wasa", Path.Combine(RessourceFolder, "wasa.png"), 5),
                new PictureAndAnswerElement("Wuerth", Path.Combine(RessourceFolder, "wuerth.png"), 2),
            };
            Elements = Shuffle<PictureAndAnswerElement>( Elements );
        }

        List<PictureAndAnswerElement> Elements { get; }

        protected string SolutionDir => Common.VisualStudioProvider.TryGetSolutionDirectoryInfo().FullName;

        protected abstract string RessourceFolder { get; }

        private static List<T> Shuffle<T>( List<T> theList )
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
