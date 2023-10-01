namespace Games
{
    public class PokerGame : GameBase
    {
        public PokerGame( int theGameNumber, string theName ) : base( theGameNumber, theName, GameType.Category, Game.Poker )
        {
        }


        public IList<CategoryElement> Elements { get; private set; } = new List<CategoryElement>
            {
                new CategoryElement
                {
                    Name = "Wie viele Reaktionen insgesamt (nicht einzigartige Emojis) hatte die Nachricht mit den meisten Reaktionen seit Bestehen unseres Discord Servers? (Stand 30.09.23)",
                    Solutions = new List<string>
                    {
                        "Die Nachricht stammt von Jakob, hat den Inhalt \"Lmao\" und wurde am 29.08.2021 um 21:55 Uhr verschickt.",
                        "Es wurde mit 20 verschiedenen Emojis reagiert",
                        "180"
                    }
                },
                new CategoryElement
                {
                    Name = "EM Quali 1992: Wie viel Punkte holte Deutschland?",
                    Solutions = new List<string>
                    {
                        "Deutschland ging als Gruppensieger aus 4 Mannschaften bestehen Gruppen hervor",
                        "Letzmalig galt die 2 Punkteregel (Sieg 2 Punkte, Unentschieden 1 Punkt, Niederlage 0 Punkte)",
                        "10"
                    }
                },
                new CategoryElement
                {
                    Name = "1992 erschien das Computerspiel Wolfenstein 3D? Wie viel KB RAM wurden mindestens empfohlen?",
                    Solutions = new List<string>
                    {
                        "Das Spiel ist 8 MB groß",
                        "Die Mindestanforderungen für den Prozessor war ein Intel 286 6-12 Mhz Prozessor mit 1,5 µm Fertigungsstruktur",
                        "528 KB"
                    }
                },
                new CategoryElement
                {
                    Name = "Wie viele Nachrichten wurden seit Bestehen in unserem Discord verfasst? (Stand 30.09.23)",
                    Solutions = new List<string>
                    {
                        "Im Schnitt werden seit Bestehen pro Woche etwa 30 Nachrichten geschrieben",
                        "Es wurde auf insgesamt 20.459 Nachrichten mit Emojis reagiert",
                        "93.330"
                    }
                },
                new CategoryElement
                {
                    Name = "Wie hoch war 1992 der durchschnittliche Bruttoverdienst aller vollzeitbeschäftigten Arbeitnehmer in Deutschlan in €?",
                    Solutions = new List<string>
                    {
                        "Der durchschnittliche Bruttoverdienst hat sich bis zum Jahre 2021 mehr als verdoppelt",
                        "In den neuen Bundesländern lag der durchschnittliche Bruttoverdienst bei 1213 €",
                        "2003"
                    }
                },
                new CategoryElement
                {
                    Name = "Wann gewann Hans-Martin Schulze 500.000€ bei Schlag den Raab?",
                    Solutions = new List<string>
                    {
                        "Die erste Schlag den Raab Sendung wurde am 23. September 2006 ausgestrahlt",
                        "Es war die 18. Ausgabe",
                        "12.09.2009"
                    }
                },
                new CategoryElement
                {
                    Name = "Wie hoch war die Weltbevölkerung im Jahre 1992?",
                    Solutions = new List<string>
                    {
                        "In Asien lebten 1992 3.310.377.566 Menschen",
                        "Fünf Jahre zuvor (1987) wurden die 5 Milliarden geknackt",
                        "5.478.009.000"
                    }
                },
                new CategoryElement
                {
                    Name = "Wie teuer war eine Maß Bier beim Oktoberfest 1992? IN DM",
                    Solutions = new List<string>
                    {
                        "Dreißig Jahre zuvor also 1962 lag der Maßbierpreis bei 2,20 DM",
                        "Auf dem Oktoberfest 2022 wird die Maß Bier 13,50€ kosten",
                        "8,50 DM"
                    }
                },
                new CategoryElement
                {
                    Name = "Wie viele Siege hat die deutsche Fußballnationalmannschaft der Männer seit Bestehen errungen? (Stand 30.09.23)",
                    Solutions = new List<string>
                    {
                        "Das erste Länderspiel am 5. April 1908 ging 5:3 gegen die Schweiz verloren.",
                        "Insgesamt wurden 1004 Spiele bestritten.",
                        "579"
                    }
                },
            };
    }
}
