using System.Collections.Generic;

namespace NineStarKi.Models
{
    public static class Constants
    {
        public enum Element
        {
            Water = 1,
            Wood,
            Fire,
            Earth,
            Metal
        }

        public static Dictionary<char, Element> starElement = new Dictionary<char, Element> {
            { '1', Element.Water },
            { '2', Element.Earth},
            { '3', Element.Wood },
            { '4', Element.Wood },
            { '5', Element.Earth },
            { '6', Element.Metal },
            { '7', Element.Metal },
            { '8', Element.Earth },
            { '9', Element.Fire }
        };

        public static Dictionary<char, string[]> starMap = new Dictionary<char, string[]> {
            { '1', new string[] { "8.7", "7.8", "6.9", "5.1", "4.2", "3.3", "2.4", "1.5", "9.6" } },
            { '2', new string[] { "2.5", "1.6", "9.7", "8.8", "7.9", "6.1", "5.2", "4.3", "3.4" } },
            { '3', new string[] { "5.3", "4.4", "3.5", "2.6", "1.7", "9.8", "8.9", "7.1", "6.2" } },
            { '4', new string[] { "8.1", "7.2", "6.3", "5.4", "4.5", "3.6", "2.7", "1.8", "9.9" } },
            { '5', new string[] { "2.8", "1.9", "9.1", "8.2", "7.3", "6.4", "5.5", "4.6", "3.7" } },
            { '6', new string[] { "5.6", "4.7", "3.8", "2.9", "1.1", "9.2", "8.3", "7.4", "6.5" } },
            { '7', new string[] { "8.4", "7.5", "6.6", "5.7", "4.8", "3.9", "2.1", "1.2", "9.3" } },
            { '8', new string[] { "2.2", "1.3", "9.4", "8.5", "7.6", "6.7", "5.8", "4.9", "3.1" } },
            { '9', new string[] { "5.9", "4.1", "3.2", "2.3", "1.4", "9.5", "8.6", "7.7", "6.8" } }
        };
    }
}
