namespace Games
{
    internal class WhoThatGame : PictureAndAnswerBase
    {
        public WhoThatGame( int theGameNumber, string theName ) : base( theGameNumber, theName, Game.WhoThat )
        {
            Elements = new List<PictureAndAnswerElement>
            {
                new PictureAndAnswerElement("Arno Dübel", Path.Combine( RessourceFolder, "ArnoDübel.jpg") ),
                new PictureAndAnswerElement("Bernd Lucke", Path.Combine( RessourceFolder, "BerndLucke.jpg") ),
                new PictureAndAnswerElement("Carsten Maschmeyer", Path.Combine( RessourceFolder, "CarstenMaschmeyer.jpg") ),
                new PictureAndAnswerElement("Carsten Stahl", Path.Combine( RessourceFolder, "CarstenStahl.jpg") ),
                new PictureAndAnswerElement("Chris Martin", Path.Combine( RessourceFolder, "ChrisMartin.jpg") ),
                new PictureAndAnswerElement("Christoper Nolan", Path.Combine( RessourceFolder, "ChristopherNolan.jpg") ),
                new PictureAndAnswerElement("Constantin Schreiber", Path.Combine( RessourceFolder, "ConstantinSchreiber.jpeg") ),
                new PictureAndAnswerElement("Dan Reynolds", Path.Combine( RessourceFolder, "DanReynolds.jpg") ),
                new PictureAndAnswerElement("Arno Dübel", Path.Combine( RessourceFolder, "ArnoDübel.jpg") ),
                new PictureAndAnswerElement("Der Graf", Path.Combine( RessourceFolder, "DerGraf.jpg") ),
                new PictureAndAnswerElement("Faker", Path.Combine( RessourceFolder, "Faker.jpg") ),
                new PictureAndAnswerElement("Frank Thelen", Path.Combine( RessourceFolder, "FrankThelen.jpg") ),
                new PictureAndAnswerElement("Frauke Ludowig", Path.Combine( RessourceFolder, "FraukeLudowig.jpg") ),
                new PictureAndAnswerElement("Gordon Ramsay", Path.Combine( RessourceFolder, "GordonRamsey.jpg") ),
                new PictureAndAnswerElement("Hans Entertainment", Path.Combine( RessourceFolder, "HansEntertainment.jpg") ),
                new PictureAndAnswerElement("Hans Zimmer", Path.Combine( RessourceFolder, "HansZimmer.jpg") ),
                new PictureAndAnswerElement("Howard Stern", Path.Combine( RessourceFolder, "HowardStern.jpg") ),
                new PictureAndAnswerElement("Joseph Goebbels", Path.Combine( RessourceFolder, "JosephGoebbels.jpg") ),
                new PictureAndAnswerElement("Jos Verstappen", Path.Combine( RessourceFolder, "JosVerstappen.jpg") ),
                new PictureAndAnswerElement("Judith Rakers", Path.Combine( RessourceFolder, "JudithRakers.jpg") ),
                new PictureAndAnswerElement("Julian Sommer", Path.Combine( RessourceFolder, "JulianSommer.jpg") ),
                new PictureAndAnswerElement("Konny Reimann", Path.Combine( RessourceFolder, "KonnyReimann.jpg") ),
                new PictureAndAnswerElement("Lana Rhoades", Path.Combine( RessourceFolder, "LanaRhoades.jpg") ),
                new PictureAndAnswerElement("Mick Schumacher", Path.Combine( RessourceFolder, "MickSchumacher.jpg") ),
                new PictureAndAnswerElement("Peter Klöppel", Path.Combine( RessourceFolder, "PeterKlöppel.jpg") ),
                new PictureAndAnswerElement("Reza Parastesh", Path.Combine( RessourceFolder, "RezaParastesh.jpg") ),
                new PictureAndAnswerElement("Simon Cowell", Path.Combine( RessourceFolder, "SimonCowell.jpg") ),
                new PictureAndAnswerElement("Standartskill", Path.Combine( RessourceFolder, "Standartskill.jpg") ),
                new PictureAndAnswerElement("Thorsten Legat", Path.Combine( RessourceFolder, "ThorstenLegat.jpg") ),
                new PictureAndAnswerElement("Timothée Chalamet", Path.Combine( RessourceFolder, "TimotheeChalamet.jpg") ),
                new PictureAndAnswerElement("Tim Wiese", Path.Combine( RessourceFolder, "TimWiese.jpg") ),
                new PictureAndAnswerElement("Wolfgang Schmidt", Path.Combine( RessourceFolder, "WolfgangSchmidt.jpg") ),
            };
            Elements = Shuffle<PictureAndAnswerElement>( Elements );
        }

        protected override string RessourceFolder => Path.Combine( SolutionDir, "App", "res", "WerIstDas" );
    }
}
