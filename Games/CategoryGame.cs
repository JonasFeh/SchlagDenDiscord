namespace Games
{
    internal class CategoryGame : GameBase
    {
        public CategoryGame( int theGameNumber, string theName ) : base( theGameNumber, theName, GameType.Category, Game.Category )
        {
        }

        public IList<CategoryElement> Elements { get; private set; } = new List<CategoryElement>
        {
            // Reihenfolge der Abarbeitung
            new CategoryElement
            {
                Name = "Zehnkampf Disziplinen",
                // 10
                Solutions =
                {
                    "100m",
                    "Weitsprung",
                    "Kugelstoßen",
                    "Hochsprung",
                    "400m",
                    "110m Hürden",
                    "Diskus",
                    "Stabhochsprung",
                    "Speerwurf",
                    "1500m"
                }
            },
            // Reihenfolge auf der Website
            new CategoryElement
            {
                Name = "Aktuelle Bundesregierung",
                // 17
                Solutions =
                {
                    "Olaf Scholz (Bundeskanzler)",
                    "Robert Habeck (Wirtschaft und Klimaschutz)",
                    "Christian Lindner (Finanzen)",
                    "Nancy Faeser (Inneres und Heimat)",
                    "Annalena Baerbock (Außenministerium)",
                    "Marco Buschmann (Justiz)",
                    "Hubertus Heil (Arbeit und Soziales)",
                    "Boris Pistorius (Verteidigung)",
                    "Cem Özdemir (Ernährung und Landwirtschaft)",
                    "Lisa Paus (Familie, Senioren, Frauen, Jugend)",
                    "Karl Lauterbach (Gesundheit)",
                    "Volker Wissing (Verkehr)",
                    "Steffi Lemke \n(Umwelt, Naturschutz, nukl. Sicherheit und Verbraucherschutz",
                    "Bettina Stark-Watzinger (Bildung und Foschung)",
                    "Svenja Schulze (Entwicklung)",
                    "Klara Geywitz (Wohnen, Stadtentwicklung und Bauwesen)",
                    "Wolfgang Schmidt (Kanzleramtschef)"
                }
            },
            // Alphabetisch
            new CategoryElement
            {
                Name = "Staaten der Sowjetunion",
                // 15
                Solutions =
                {
                    "Armenien",
                    "Aserbaidschan",
                    "Belarus",
                    "Estland",
                    "Georgien",
                    "Kasachstan",
                    "Kirgisien",
                    "Lettland",
                    "Litauen",
                    "Moldawien",
                    "Russland",
                    "Tadschikistan",
                    "Turkmenistan",
                    "Ukraine",
                    "Usbekistan",
                }
            },
            // Reihenfolge im Spiel
            new CategoryElement
            {
                Name = "Monopolyfelder",
                // 37
                Solutions =
                {
                    "Los",
                    "Badstraße",
                    "Gemeinschaftsfeld",
                    "Turmstraße",
                    "Einkommenssteuer",
                    "Südbahnhof",
                    "Chausseestraße",
                    "Ereignisfeld",
                    "Elisenstraße",
                    "Poststraße",
                    "Gefängnis",
                    "Seestraße",
                    "E-Werk",
                    "Hafenstraße",
                    "Neue Straße",
                    "Westbahnhof",
                    "Münchener Straße",
                    "Wiener Straße",
                    "Berliner Straße",
                    "Frei Parken",
                    "Theaterstraße",
                    "Museumsstraße",
                    "Opernplatz",
                    "Nordbahnhof",
                    "Lessingstraße",
                    "Schillerstraße",
                    "Wasserwerk",
                    "Geothestraße",
                    "Gehen sie in das Gefängnis",
                    "Rathausplatz",
                    "Hauptstraße",
                    "Hauptstraße",
                    "Bahnhofsstraße",
                    "Hauptbahnhof",
                    "Parkstraße",
                    "Zusatzsteuer",
                    "Schlossallee"
                }
            },
            // Chronologisch
            new CategoryElement
            {
                Name = "Gesetzliche Feiertage",
                // 18
                Solutions =
                {
                    "Neujahr",
                    "Heilige drei Könige",
                    "Karfreitag",
                    "Ostersonntag",
                    "Ostermontag",
                    "Tag der Arbeit",
                    "Christi Himmelfahrt",
                    "Pfingstsonntag",
                    "Pfingstmontag",
                    "Fronleichnam",
                    "Augsburger Friedensfest",
                    "Mariä Himmelfahrt",
                    "Tag der deutschen Einheit",
                    "Reformationstag",
                    "Allerheiligen",
                    "Buß- und Bettag",
                    "1. Weihnachtstag",
                    "2. Weihnachtstag"
                }
            },

        };
    }
}
