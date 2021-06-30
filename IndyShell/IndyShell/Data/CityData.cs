using System;
using System.Collections.Generic;

namespace IndyShell
{
    public static class CityData
    {
        public static List<string> CityNames { get; private set; }

        static CityData()
        {
            CityNames = new List<string>()
            {
                "Seattle",
                "Bellevue",
                "Kirkland",
                "Bainbridge",
                "Edmonds",
                "Tacoma",
                "Burien",
                "South Park",
                "Redmond",
                "Gig Harbor",
                "Port Townsend",
                "Friday Harbor",
                "Bellingham",
                "Monroe",
                "Lake City",
                "Olympia"
            };
        }
    }
}
