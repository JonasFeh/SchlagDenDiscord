namespace Games
{
    public class CategoryGame : GameBase
    {
        public CategoryGame( int theGameNumber, string theName ) : base( theGameNumber, theName, GameType.Category, Game.Category )
        {
        }

        public IList<CategoryElement> Elements { get; private set; } = new List<CategoryElement>
        {
            // Nach Position laut Kicker
            new CategoryElement
            {
                Name = "Deutsche Startelf des WM Finales 2014",
                // 11
                Solutions = new List<string>
                {
                    "Neuer",
                    "Lahm",
                    "Boateng",
                    "Hummels",
                    "Höwedes",
                    "Schweinsteiger",
                    "Kramer",
                    "Kroos",
                    "Müller",
                    "Özil",
                    "Klose",
                }
            },
            // Nach Einwohnerzahl
            new CategoryElement
            {
                Name = "Deutsche Städte >500.000 Einwohner",
                // 14
                Solutions = new List<string>
                {
                    "Berlin",
                    "Hamburg",
                    "München",
                    "Köln",
                    "Frankfurt am Main",
                    "Stuttgart",
                    "Düsseldorf",
                    "Leipzig",
                    "Dortmund",
                    "Essen",
                    "Bremen",
                    "Dresden",
                    "Hannover",
                    "Nürnberg",
                }
            },
            // Reihenfolge der Abarbeitung
            new CategoryElement
            {
                Name = "Zehnkampf Disziplinen",
                // 10
                Solutions = new List<string>
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
                Solutions = new List<string>
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
                Solutions = new List<string>
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
                Solutions = new List<string>
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
                    "Gehen Sie in das Gefängnis",
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
                Solutions = new List<string>
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
            // Zufall
            new CategoryElement
            {
                Name = "Zweistellige Primzahlen",
                // 21
                Solutions = new List<string>
                {
                    "89",
                    "23",
                    "47",
                    "13",
                    "79",
                    "61",
                    "17",
                    "43",
                    "83",
                    "11",
                    "37",
                    "67",
                    "71",
                    "53",
                    "19",
                    "31",
                    "73",
                    "29",
                    "97",
                    "41",
                    "59",
                }
            },
            // Alphabetisch
            new CategoryElement
            {
                Name = "EU Mitgliedsstaaten",
                // 27
                Solutions = new List<string>
                {
                    "Belgien",
                    "Bulgarien",
                    "Dänemark",
                    "Deutschland",
                    "Estland",
                    "Finnland",
                    "Frankreich",
                    "Griechenland",
                    "Irland",
                    "Italien",
                    "Kroatien",
                    "Lettland",
                    "Litauen",
                    "Luxemburg",
                    "Malta",
                    "Niederlande",
                    "Österreich",
                    "Polen",
                    "Portugal",
                    "Rumänien",
                    "Schweden",
                    "Slowakei",
                    "Slowenien",
                    "Spanien",
                    "Tschechische Republik",
                    "Ungarn",
                    "Zypern",
                }
            },
            // Zufall
            new CategoryElement
            {
                Name="Nachbarländer von Ungarn",
                // 7
                Solutions = new List<string>
                {
                    "Österreich",
                    "Rumänien",
                    "Ukraine",
                    "Slowakei",
                    "Serbien",
                    "Slowenien",
                    "Kroatien"
                }
            },
            // Chronologisch
            new CategoryElement
            {
                Name="Bundeskanzler seit 1949",
                Solutions = new List<string>
                {
                    "Konrad Adenauer",
                    "Ludwig Erhard",
                    "Kurt Georg Kiesinger",
                    "Willy Brandt",
                    "Helmut Schmidt",
                    "Helmut Kohl",
                    "Gerhard Schröder",
                    "Angela Merkel",
                    "Olaf Scholz"
                }
            },
            // Nach Indexgewichtung
            new CategoryElement
            {
                Name="Unternehmen des Dax",
                Solutions = new List<string>
                {
                    "SAP",
                    "Siemens",
                    "Allianz",
                    "Airbus",
                    "Telekom",
                    "Mercedes Benz",
                    "Bayer",
                    "Infineon",
                    "Münchener Rück",
                    "BASF",
                    "Deutsche Post",
                    "BMW",
                    "Deutsche Börse",
                    "Adidas",
                    "Volkswagen",
                    "RWE",
                    "E.ON",
                    "Merck",
                    "Deutsche Bank",
                    "Daimler Truck",
                    "Siemens Healthineers",
                    "Vonovia",
                    "Porsche AG",
                    "Henkel",
                    "MTU Aero Engines",
                    "Symrise",
                    "Beiersdorf",
                    "Hannover Rück",
                    "Brenntag",
                    "Rheinmetall",
                    "Commerzbank",
                    "Fresenius",
                    "Siemens Energy",
                    "Heidelberg Materials",
                    "Qiagen",
                    "Porsche SE",
                    "Sartorius",
                    "Continental",
                    "Covestro",
                    "Zalando",
                },
            },
        };
    }
}
