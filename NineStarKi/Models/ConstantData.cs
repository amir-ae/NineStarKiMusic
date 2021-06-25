using System.Collections.Generic;

namespace NineStarKi.Models
{
    public class ConstantData
    {
        public Dictionary<char, Element> StarElement => starElement;

        public Dictionary<char, string[]> StarMap => starMap;

        public IEnumerable<Genre> Genres => genres;

        public IEnumerable<Occasion> Occasions => occasions;

        public IEnumerable<Musician> Musicians => musicians;

        public enum Element
        {
            Water = 1,
            Wood,
            Fire,
            Earth,
            Metal
        }

        private static Dictionary<char, Element> starElement = new Dictionary<char, Element> {
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

        private static Dictionary<char, string[]> starMap = new Dictionary<char, string[]> {
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

        private static List<Genre> genres = new List<Genre> {
            new Genre { Id = 0, Name = "BLUES" },
            new Genre { Id = 1, Name = "CLASSICAL" },
            new Genre { Id = 2, Name = "COUNTRY" },
            new Genre { Id = 3, Name = "ELECTRONICA" },
            new Genre { Id = 4, Name = "FOLK" },
            new Genre { Id = 5, Name = "GOSPEL" },
            new Genre { Id = 6, Name = "HIP-HOP" },
            new Genre { Id = 7, Name = "JAZZ" },
            new Genre { Id = 8, Name = "MUSICALS" },
            new Genre { Id = 9, Name = "OPERA" },
            new Genre { Id = 10, Name = "POP" },
            new Genre { Id = 11, Name = "R&B" },
            new Genre { Id = 12, Name = "ROCK" },
            new Genre { Id = 13, Name = "VOCALS" },
            new Genre { Id = 14, Name = "WORLD" },
            new Genre { Id = 15, Name = "Algeria" },
            new Genre { Id = 16, Name = "Andes" },
            new Genre { Id = 17, Name = "Angola" },
            new Genre { Id = 18, Name = "Argentina" },
            new Genre { Id = 19, Name = "Armenia" },
            new Genre { Id = 20, Name = "Brazil" },
            new Genre { Id = 21, Name = "Bulgaria" },
            new Genre { Id = 22, Name = "Cameroon" },
            new Genre { Id = 23, Name = "Cape Verde" },
            new Genre { Id = 24, Name = "Celtic" },
            new Genre { Id = 25, Name = "China" },
            new Genre { Id = 26, Name = "Colombia" },
            new Genre { Id = 27, Name = "Congo" },
            new Genre { Id = 28, Name = "Cuba" },
            new Genre { Id = 29, Name = "Dominican Republic" },
            new Genre { Id = 30, Name = "Egypt" },
            new Genre { Id = 31, Name = "Ethiopia" },
            new Genre { Id = 32, Name = "Germany" },
            new Genre { Id = 33, Name = "Greece" },
            new Genre { Id = 34, Name = "Guinea" },
            new Genre { Id = 35, Name = "Haiti" },
            new Genre { Id = 36, Name = "Hawaii" },
            new Genre { Id = 37, Name = "Hebrew" },
            new Genre { Id = 38, Name = "Hungary" },
            new Genre { Id = 39, Name = "India" },
            new Genre { Id = 40, Name = "Indonesia" },
            new Genre { Id = 41, Name = "Iran" },
            new Genre { Id = 42, Name = "Jamaica" },
            new Genre { Id = 43, Name = "Japan" },
            new Genre { Id = 44, Name = "Klezmer" },
            new Genre { Id = 45, Name = "Latin" },
            new Genre { Id = 46, Name = "Latin America" },
            new Genre { Id = 47, Name = "Madagascar" },
            new Genre { Id = 48, Name = "Mali" },
            new Genre { Id = 49, Name = "Mauritania" },
            new Genre { Id = 50, Name = "Mexico" },
            new Genre { Id = 51, Name = "Middle East" },
            new Genre { Id = 52, Name = "Morocco" },
            new Genre { Id = 53, Name = "Nigeria" },
            new Genre { Id = 54, Name = "Pakistan" },
            new Genre { Id = 55, Name = "Puerto Rico" },
            new Genre { Id = 56, Name = "Portugal" },
            new Genre { Id = 57, Name = "Romania" },
            new Genre { Id = 58, Name = "Russia" },
            new Genre { Id = 59, Name = "Senegal" },
            new Genre { Id = 60, Name = "South Africa" },
            new Genre { Id = 61, Name = "Spain" },
            new Genre { Id = 62, Name = "Tanzania" },
            new Genre { Id = 63, Name = "Trinidad" },
            new Genre { Id = 64, Name = "Turkey" },
            new Genre { Id = 65, Name = "Venezuela" },
            new Genre { Id = 66, Name = "Zimbabwe" }
            };

        private static List<Occasion> occasions = new List<Occasion> {
            new Occasion { Id = 0, Name = "COCKTAIL HOUR" },
            new Occasion { Id = 1, Name = "GET THE PARTY STARTED" },
            new Occasion { Id = 2, Name = "MUSIC TO INSPIRE REFLECTION" },
            new Occasion { Id = 3, Name = "ROMANCE ENHANCERS" },
            new Occasion { Id = 4, Name = "CARDIO WORKOUT" },
            new Occasion { Id = 5, Name = "PLAY THIS FOR THE KIDS" },
            new Occasion { Id = 6, Name = "ROADTRIP SOUNDTRACK AM" },
            new Occasion { Id = 7, Name = "ROADTRIP SOUNDTRACK PM" },
            new Occasion { Id = 8, Name = "LAZY SUNDAY MORNING" },
            new Occasion { Id = 9, Name = "HEADPHONE JOURNEY" },
            new Occasion { Id = 10, Name = "SUPERMAN'S EARBUDS" },
            new Occasion { Id = 11, Name = "MUSICAL ADVENTURE" }
            };

        private static List<Musician> musicians = new List<Musician> {
            new Musician
            {
                Name = "ABBA",
                Genres = new List<Genre> { genres[10] },
                Recording = "Gold",
                Occasions = new List<Occasion> { occasions[5] },
                Numbers = "519, 187, 169, 941"
            },
            new Musician
            {
                Name = "The Abyssinian Baptist Choir",
                Genres = new List<Genre> { genres[5] },
                Recording = "Shakin' the Rafters",
                Occasions = new List<Occasion> { occasions[5] },
                Numbers = "297"
            },
            new Musician
            {
                Name = "The Almanac Singers",
                Genres = new List<Genre> { genres[4] },
                Recording = "Complete General Recordings",
                Occasions = new List<Occasion> { occasions[5] },
                Numbers = "739, 519, 169, 932, 187"
            },
            new Musician
            {
                Name = "Albert Ammons and Meade 'Lux' Lewis",
                Genres = new List<Genre> { genres[7] },
                Recording = "The First Day",
                Occasions = new List<Occasion> { occasions[5] },
                Numbers = "353, 555"
            },
            new Musician
            {
                Name = "Louis Armstrong",
                Genres = new List<Genre> { genres[7] },
                Recording = "The Complete Hot Fives and Hot Sevens",
                Occasions = new List<Occasion> { occasions[5] },
                Numbers = "995"
            },
            new Musician
            {
                Name = "Erykah Badu",
                Genres = new List<Genre> { genres[11] },
                Recording = "Mama's Gun",
                Occasions = new List<Occasion> { occasions[5] },
                Numbers = "225"
            },
            new Musician
            {
                Name = "The Balfa Brothers",
                Genres = new List<Genre> { genres[4] },
                Recording = "The Balfa Brothers Play Traditional Cajun Music",
                Occasions = new List<Occasion> { occasions[5], occasions[1] },
                Numbers = "178, 234, 326"
            },
            new Musician
            {
                Name = "Béla Bartók",
                Genres = new List<Genre> { genres[1] },
                Recording = "Concerto for Orchestra; Music for Strings, Percussion, and Celesta",
                Occasions = new List<Occasion> { occasions[5] },
                Numbers = "216"
            },
            new Musician
            {
                Name = "The Beach Boys",
                Genres = new List<Genre> { genres[10] },
                Recording = "'Good Vibrations'",
                Occasions = new List<Occasion> { occasions[5] },
                Numbers = "445, 519, 427, 445, 941, 225"
            },
            new Musician
            {
                Name = "The Beatles",
                Genres = new List<Genre> { genres[12] },
                Recording = "A Hard Day's Night",
                Occasions = new List<Occasion> { occasions[5] },
                Numbers = "665, 445, 611, 353, 528"
            },
            new Musician
            {
                Name = "The Beatles",
                Genres = new List<Genre> { genres[12] },
                Recording = "Rubber Soul",
                Occasions = new List<Occasion> { occasions[5] },
                Numbers = "665, 445, 611, 353, 528"
            },
            new Musician
            {
                Name = "Harry Belafonte",
                Genres = new List<Genre> { genres[7], genres[13] },
                Recording = "At Carnegie Hall",
                Occasions = new List<Occasion> { occasions[5] },
                Numbers = "216"
            },
            new Musician
            {
                Name = "Leonard Bernstein and Stephen Sondheim",
                Genres = new List<Genre> { genres[8] },
                Recording = "West Side Story",
                Occasions = new List<Occasion> { occasions[5] },
                Numbers = "124, 775"
            },
            new Musician
            {
                Name = "Blind Blake",
                Genres = new List<Genre> { genres[0] },
                Recording = "Ragtime Guitar's Foremost Fingerpicker",
                Occasions = new List<Occasion> { occasions[5] },
                Numbers = "5"
            },
            new Musician
            {
                Name = "Jerry Bock and Sheldon Harnick",
                Genres = new List<Genre> { genres[8] },
                Recording = "Fiddler on the Roof",
                Occasions = new List<Occasion> { occasions[5] },
                Numbers = "959, 463"
            },
            new Musician
            {
                Name = "James Booker",
                Genres = new List<Genre> { genres[7], genres[11] },
                Recording = "New Orleans Piano Wizard Live!",
                Occasions = new List<Occasion> { occasions[5], occasions[1] },
                Numbers = "775"
            },
            new Musician
            {
                Name = "Boston",
                Genres = new List<Genre> { genres[12] },
                Recording = "Boston",
                Occasions = new List<Occasion> { occasions[5], occasions[10] },
                Numbers = "813, 445, 528, 831, 647"
            },
            new Musician
            {
                Name = "The Caravans",
                Genres = new List<Genre> { genres[5] },
                Recording = "The Best of the Caravans",
                Occasions = new List<Occasion> { occasions[5] },
                Numbers = "941, 858, 611, 932, 288, 894, 831, 656"
            },
            new Musician
            {
                Name = "The Original Carter Family",
                Genres = new List<Genre> { genres[2] },
                Recording = "The Carter Family: 1927-1934",
                Occasions = new List<Occasion> { occasions[5] },
                Numbers = "178, 151, 398, 573, 115, 876, 472, 187, 353, 977"
            },
            new Musician
            {
                Name = "Pablo Casals",
                Genres = new List<Genre> { genres[1] },
                Recording = "J. S. Bach, Suites for Cello, Vols. 1 and 2",
                Occasions = new List<Occasion> { occasions[5] },
                Numbers = "775, 941"
            },
            new Musician
            {
                Name = "Chicago",
                Genres = new List<Genre> { genres[12] },
                Recording = "The Chicago Transit Authority",
                Occasions = new List<Occasion> { occasions[5], occasions[6] },
                Numbers = "234, 968, 178, 858, 885, 986, 297"
            },
            new Musician
            {
                Name = "The Chieftains",
                Genres = new List<Genre> { genres[14], genres[24] },
                Recording = "The Chieftains 4",
                Occasions = new List<Occasion> { occasions[5] },
                Numbers = "867, 932, 297, 234, 995, 712, 115"
            },
            new Musician
            {
                Name = "Frédéric Chopin",
                Genres = new List<Genre> { genres[1] },
                Recording = "Ballades and Scherzos",
                Occasions = new List<Occasion> { occasions[5], occasions[8] },
                Numbers = "187"
            },
            new Musician
            {
                Name = "The Coasters",
                Genres = new List<Genre> { genres[12] },
                Recording = "'Yakety Yak'",
                Occasions = new List<Occasion> { occasions[5] },
                Numbers = "932, 142, 371, 582, 766, 178, 923, 187, 326"
            },
            new Musician
            {
                Name = "Joe Cocker",
                Genres = new List<Genre> { genres[12] },
                Recording = "Mad Dogs and Englishmen",
                Occasions = new List<Occasion> { occasions[5] },
                Numbers = "288"
            },
            new Musician
            {
                Name = "Sam Cooke and the Soul Stirrers",
                Genres = new List<Genre> { genres[5] },
                Recording = "Sam Cooke with the Soul Stirrers",
                Occasions = new List<Occasion> { occasions[5] },
                Numbers = "766, 867, 355, 481, 344, 885"
            },
            new Musician
            {
                Name = "Dick Dale and His Del-Tones",
                Genres = new List<Genre> { genres[12] },
                Recording = "King of the Surf Guitar",
                Occasions = new List<Occasion> { occasions[5] },
                Numbers = "932"
            },
            new Musician
            {
                Name = "Miles Davis Quintet",
                Genres = new List<Genre> { genres[7] },
                Recording = "Highlights from the Plugged Nickel",
                Occasions = new List<Occasion> { occasions[5] },
                Numbers = "9"
            },
            new Musician
            {
                Name = "The Dixie Chicks",
                Genres = new List<Genre> { genres[2] },
                Recording = "Wide Open Spaces",
                Occasions = new List<Occasion> { occasions[5] },
                Numbers = "831, 124, 499, 656"
            },
            new Musician
            {
                Name = "Michael Doucet and BeauSoleil",
                Genres = new List<Genre> { genres[0] },
                Recording = "Bayou Deluxe",
                Occasions = new List<Occasion> { occasions[5] },
                Numbers = "481"
            },
            new Musician
            {
                Name = "Bob Dylan",
                Genres = new List<Genre> { genres[12] },
                Recording = "Highway 61 Revisited",
                Occasions = new List<Occasion> { occasions[5] },
                Numbers = "582"
            },
            new Musician
            {
                Name = "The Eagles",
                Genres = new List<Genre> { genres[12] },
                Recording = "Hotel California",
                Occasions = new List<Occasion> { occasions[5] },
                Numbers = "867, 831, 793, 867, 941, 849"
            },
            new Musician
            {
                Name = "Ramblin' Jack Elliott",
                Genres = new List<Genre> { genres[4] },
                Recording = "The Essential Ramblin' Jack Elliott",
                Occasions = new List<Occasion> { occasions[5] },
                Numbers = "692"
            },
            new Musician
            {
                Name = "Tal Farlow",
                Genres = new List<Genre> { genres[7] },
                Recording = "The Swinging Guitar of Tal Farlow",
                Occasions = new List<Occasion> { occasions[5] },
                Numbers = "748"
            },
            new Musician
            {
                Name = "Fleetwood Mac",
                Genres = new List<Genre> { genres[12] },
                Recording = "Fleetwood Mac",
                Occasions = new List<Occasion> { occasions[5] },
                Numbers = "968, 876, 398, 674, 757"
            },
            new Musician
            {
                Name = "Judy Garland",
                Genres = new List<Genre> { genres[13] },
                Recording = "Judy at Carnegie Hall",
                Occasions = new List<Occasion> { occasions[5] },
                Numbers = "611"
            },
            new Musician
            {
                Name = "George Gershwin",
                Genres = new List<Genre> { genres[9] },
                Recording = "Porgy and Bess",
                Occasions = new List<Occasion> { occasions[5] },
                Numbers = "371"
            },
            new Musician
            {
                Name = "Benny Goodman and His Orchestra",
                Genres = new List<Genre> { genres[7] },
                Recording = "The Complete 1938 Carnegie Hall Concert",
                Occasions = new List<Occasion> { occasions[5] },
                Numbers = "151"
            },
            new Musician
            {
                Name = "The Grateful Dead",
                Genres = new List<Genre> { genres[12] },
                Recording = "American Beauty",
                Occasions = new List<Occasion> { occasions[5] },
                Numbers = "436, 831, 647, 923, 371, 115"
            },
            new Musician
            {
                Name = "Woody Guthrie",
                Genres = new List<Genre> { genres[4] },
                Recording = "Dust Bowl Ballads",
                Occasions = new List<Occasion> { occasions[5] },
                Numbers = "739"
            },
            new Musician
            {
                Name = "The Jimi Hendrix Experience",
                Genres = new List<Genre> { genres[12] },
                Recording = "Are You Experienced",
                Occasions = new List<Occasion> { occasions[5], occasions[10] },
                Numbers = "481, 995, 178"
            },
            new Musician
            {
                Name = "Jerry Herman",
                Genres = new List<Genre> { genres[8] },
                Recording = "Hello, Dolly!",
                Occasions = new List<Occasion> { occasions[5] },
                Numbers = "692"
            },
            new Musician
            {
                Name = "Vladimir Horowitz",
                Genres = new List<Genre> { genres[1] },
                Recording = "Horowitz at the Met",
                Occasions = new List<Occasion> { occasions[5] },
                Numbers = "712"
            },
            new Musician
            {
                Name = "The Incredible String Band",
                Genres = new List<Genre> { genres[4] },
                Recording = "The Hangman's Beautiful Daughter",
                Occasions = new List<Occasion> { occasions[5] },
                Numbers = "472, 353, 326, 115, 647"
            },
            new Musician
            {
                Name = "Burl Ives",
                Genres = new List<Genre> { genres[4] },
                Recording = "The Wayfaring Stranger",
                Occasions = new List<Occasion> { occasions[5] },
                Numbers = "142"
            },
            new Musician
            {
                Name = "Joe Jackson",
                Genres = new List<Genre> { genres[12] },
                Recording = "Night and Day",
                Occasions = new List<Occasion> { occasions[5] },
                Numbers = "124"
            },
            new Musician
            {
                Name = "Elton John",
                Genres = new List<Genre> { genres[10] },
                Recording = "Goodbye Yellow Brick Road",
                Occasions = new List<Occasion> { occasions[5] },
                Numbers = "813"
            },
            new Musician
            {
                Name = "Lonnie Johnson",
                Genres = new List<Genre> { genres[0] },
                Recording = "The Original Guitar Wizard",
                Occasions = new List<Occasion> { occasions[5] },
                Numbers = "225"
            },
            new Musician
            {
                Name = "Robert Johnson",
                Genres = new List<Genre> { genres[0] },
                Recording = "The Complete Recordings",
                Occasions = new List<Occasion> { occasions[5], occasions[9] },
                Numbers = "885"
            },
            new Musician
            {
                Name = "Henry Kaiser and David Lindley with Musicians from Madagascar",
                Genres = new List<Genre> { genres[14], genres[47] },
                Recording = "A World Out of Time",
                Occasions = new List<Occasion> { occasions[5], occasions[8] },
                Numbers = "151, 216"
            },
            new Musician
            {
                Name = "The Kinks",
                Genres = new List<Genre> { genres[12] },
                Recording = "The Kinks Are the Village Green Preservation Society",
                Occasions = new List<Occasion> { occasions[5] },
                Numbers = "279, 932, 344, 225"
            },
            new Musician
            {
                Name = "Leadbelly",
                Genres = new List<Genre> { genres[0], genres[4] },
                Recording = "Where Did You Sleep Last Night?",
                Occasions = new List<Occasion> { occasions[5] },
                Numbers = "591"
            },
            new Musician
            {
                Name = "Led Zeppelin",
                Genres = new List<Genre> { genres[12] },
                Recording = "How the West Was Won",
                Occasions = new List<Occasion> { occasions[5] },
                Numbers = "721, 335, 757, 178"
            },
            new Musician
            {
                Name = "Jerry Lee Lewis",
                Genres = new List<Genre> { genres[12] },
                Recording = "Live at the Star Club, Hamburg",
                Occasions = new List<Occasion> { occasions[5], occasions[1] },
                Numbers = "243"
            },
            new Musician
            {
                Name = "Lyle Lovett",
                Genres = new List<Genre> { genres[2] },
                Recording = "Joshua Judges Ruth",
                Occasions = new List<Occasion> { occasions[5] },
                Numbers = "793"
            },
            new Musician
            {
                Name = "Henry Mancini",
                Genres = new List<Genre> { genres[10] },
                Recording = "Breakfast at Tiffany's",
                Occasions = new List<Occasion> { occasions[5] },
                Numbers = "463"
            },
            new Musician
            {
                Name = "Bob Marley and the Wailers",
                Genres = new List<Genre> { genres[14], genres[42] },
                Recording = "Natty Dread",
                Occasions = new List<Occasion> { occasions[5], occasions[1] },
                Numbers = "187"
            },
            new Musician
            {
                Name = "John Mayall with Eric Clapton",
                Genres = new List<Genre> { genres[0], genres[12] },
                Recording = "Blues Breakers",
                Occasions = new List<Occasion> { occasions[5], occasions[6] },
                Numbers = "481, 178"
            },
            new Musician
            {
                Name = "Curtis Mayfield",
                Genres = new List<Genre> { genres[11] },
                Recording = "There's No Place like America Today",
                Occasions = new List<Occasion> { occasions[5], occasions[2] },
                Numbers = "454"
            },
            new Musician
            {
                Name = "The Mighty Diamonds",
                Genres = new List<Genre> { genres[14], genres[42] },
                Recording = "Right Time",
                Occasions = new List<Occasion> { occasions[5] },
                Numbers = ""
            },
            new Musician
            {
                Name = "Joni Mitchell",
                Genres = new List<Genre> { genres[10] },
                Recording = "Court and Spark",
                Occasions = new List<Occasion> { occasions[5], occasions[2] },
                Numbers = "362"
            },
            new Musician
            {
                Name = "Bill Monroe",
                Genres = new List<Genre> { genres[2] },
                Recording = "The Music of Bill Monroe",
                Occasions = new List<Occasion> { occasions[5], occasions[6] },
                Numbers = "849"
            },
            new Musician
            {
                Name = "Milton Nascimento with Lô Borges",
                Genres = new List<Genre> { genres[14], genres[20] },
                Recording = "Clube da esquina",
                Occasions = new List<Occasion> { occasions[5], occasions[6] },
                Numbers = "499, 463"
            },
            new Musician
            {
                Name = "Ricky Nelson",
                Genres = new List<Genre> { genres[12] },
                Recording = "Greatest Hits",
                Occasions = new List<Occasion> { occasions[5] },
                Numbers = "629"
            },
            new Musician
            {
                Name = "Harry Nilsson",
                Genres = new List<Genre> { genres[12] },
                Recording = "Nilsson Schmilsson",
                Occasions = new List<Occasion> { occasions[5], occasions[9] },
                Numbers = "766"
            },
            new Musician
            {
                Name = "Laura Nyro",
                Genres = new List<Genre> { genres[10] },
                Recording = "Eli and the Thirteenth Confession",
                Occasions = new List<Occasion> { occasions[5] },
                Numbers = "831"
            },
            new Musician
            {
                Name = "Odetta",
                Genres = new List<Genre> { genres[4] },
                Recording = "Odetta Sings Ballads and Blues",
                Occasions = new List<Occasion> { occasions[5] },
                Numbers = "775"
            },
            new Musician
            {
                Name = "King Oliver and His Creole Jazz Band",
                Genres = new List<Genre> { genres[7] },
                Recording = "Off the Record: The Complete 1923 Jazz Band Recordings",
                Occasions = new List<Occasion> { occasions[5] },
                Numbers = "216"
            },
            new Musician
            {
                Name = "Ivo Papasov and His Orchestra",
                Genres = new List<Genre> { genres[14], genres[21] },
                Recording = "Balkanology",
                Occasions = new List<Occasion> { occasions[5] },
                Numbers = "353"
            },
            new Musician
            {
                Name = "Charlie Parker",
                Genres = new List<Genre> { genres[7] },
                Recording = "A Studio Chronicle, 1940-1948",
                Occasions = new List<Occasion> { occasions[5] },
                Numbers = "858"
            },
            new Musician
            {
                Name = "Dolly Parton",
                Genres = new List<Genre> { genres[2] },
                Recording = "Coat of Many Colors",
                Occasions = new List<Occasion> { occasions[5] },
                Numbers = "169"
            },
            new Musician
            {
                Name = "Peter, Paul and Mary",
                Genres = new List<Genre> { genres[4] },
                Recording = "Peter, Paul and Mary",
                Occasions = new List<Occasion> { occasions[5] },
                Numbers = "885, 941, 187"
            },
            new Musician
            {
                Name = "Bud Powell",
                Genres = new List<Genre> { genres[7] },
                Recording = "The Amazing Bud Powell, Vol. 1",
                Occasions = new List<Occasion> { occasions[5] },
                Numbers = "418"
            },
            new Musician
            {
                Name = "Sergey Rachmaninoff",
                Genres = new List<Genre> { genres[1] },
                Recording = "His Complete Recordings",
                Occasions = new List<Occasion> { occasions[5] },
                Numbers = "178"
            },
            new Musician
            {
                Name = "Richard Rodgers and Oscar Hammerstein II",
                Genres = new List<Genre> { genres[8] },
                Recording = "The Sound of Music",
                Occasions = new List<Occasion> { occasions[5] },
                Numbers = "876, 692"
            },
            new Musician
            {
                Name = "Jimmie Rodgers",
                Genres = new List<Genre> { genres[2] },
                Recording = "The Essential Jimmie Rodgers",
                Occasions = new List<Occasion> { occasions[5] },
                Numbers = "418"
            },
            new Musician
            {
                Name = "Sonny Rollins",
                Genres = new List<Genre> { genres[7] },
                Recording = "A Night at the Village Vanguard",
                Occasions = new List<Occasion> { occasions[5] },
                Numbers = "721"
            },
            new Musician
            {
                Name = "Pete Seeger",
                Genres = new List<Genre> { genres[4] },
                Recording = "We Shall Overcome: The Complete Carnegie Hall Concert",
                Occasions = new List<Occasion> { occasions[5], occasions[8] },
                Numbers = "932"
            },
            new Musician
            {
                Name = "Paul Simon",
                Genres = new List<Genre> { genres[10] },
                Recording = "Graceland",
                Occasions = new List<Occasion> { occasions[5], occasions[4] },
                Numbers = "537"
            },
            new Musician
            {
                Name = "Willie 'The Lion' Smith",
                Genres = new List<Genre> { genres[7] },
                Recording = "The Lion Roars! His Greatest 1934-1944",
                Occasions = new List<Occasion> { occasions[5] },
                Numbers = "822"
            },
            new Musician
            {
                Name = "The Stanley Brothers",
                Genres = new List<Genre> { genres[2] },
                Recording = "The Complete Columbia Recordings",
                Occasions = new List<Occasion> { occasions[5] },
                Numbers = "389, 187"
            },
            new Musician
            {
                Name = "Steely Dan",
                Genres = new List<Genre> { genres[12] },
                Recording = "Aja",
                Occasions = new List<Occasion> { occasions[5], occasions[9] },
                Numbers = "528, 894"
            },
            new Musician
            {
                Name = "Art Tatum",
                Genres = new List<Genre> { genres[7] },
                Recording = "Piano Starts Here",
                Occasions = new List<Occasion> { occasions[5] },
                Numbers = "196"
            },
            new Musician
            {
                Name = "Pyotr Ilyich Tchaikovsky",
                Genres = new List<Genre> { genres[1] },
                Recording = "The Nutcracker",
                Occasions = new List<Occasion> { occasions[5] },
                Numbers = "757, 297"
            },
            new Musician
            {
                Name = "Sister Rosetta Tharpe",
                Genres = new List<Genre> { genres[5] },
                Recording = "Complete Recorded Works in Chronological Order, 1938-1947",
                Occasions = new List<Occasion> { occasions[5], occasions[8] },
                Numbers = "472"
            },
            new Musician
            {
                Name = "The Tokens",
                Genres = new List<Genre> { genres[10] },
                Recording = "'The Lion Sleeps Tonight'",
                Occasions = new List<Occasion> { occasions[5] },
                Numbers = "793, 885, 775, 472, 822"
            },
            new Musician
            {
                Name = "United Sacred Harp Musical Association Singing Convention",
                Genres = new List<Genre> { genres[4], genres[5] },
                Recording = "Southern Journey, Vol 9: Harp of a Thousand Strings",
                Occasions = new List<Occasion> { occasions[5] },
                Numbers = ""
            },
            new Musician
            {
                Name = "Ritchie Valens",
                Genres = new List<Genre> { genres[12] },
                Recording = "'La bamba'",
                Occasions = new List<Occasion> { occasions[5] },
                Numbers = "582"
            },
            new Musician
            {
                Name = "Various Artists",
                Genres = new List<Genre> { genres[4] },
                Recording = "edited by Harry Smith, Anthology of American Folk Music",
                Occasions = new List<Occasion> { occasions[5] },
                Numbers = ""
            },
            new Musician
            {
                Name = "Various Artists",
                Genres = new List<Genre> { genres[10] },
                Recording = "The Doo Wop Box",
                Occasions = new List<Occasion> { occasions[5] },
                Numbers = ""
            },
            new Musician
            {
                Name = "Various Artists",
                Genres = new List<Genre> { genres[2] },
                Recording = "O Brother, Where Art Thou?",
                Occasions = new List<Occasion> { occasions[5] },
                Numbers = ""
            },
            new Musician
            {
                Name = "Speedy West and Jimmy Bryant",
                Genres = new List<Genre> { genres[2] },
                Recording = "Stratosphere Boogie",
                Occasions = new List<Occasion> { occasions[5] },
                Numbers = "591, 353"
            },
            new Musician
            {
                Name = "Stevie Wonder",
                Genres = new List<Genre> { genres[11] },
                Recording = "Songs in the Key of Life",
                Occasions = new List<Occasion> { occasions[5] },
                Numbers = "582"
            },
            new Musician
            {
                Name = "Anita Baker",
                Genres = new List<Genre> { genres[11] },
                Recording = "Rapture",
                Occasions = new List<Occasion> { occasions[3] },
                Numbers = "766"
            },
            new Musician
            {
                Name = "Chet Baker",
                Genres = new List<Genre> { genres[7] },
                Recording = "Let's Get Lost: The Best of Chet Baker Sings",
                Occasions = new List<Occasion> { occasions[3] },
                Numbers = "813"
            },
            new Musician
            {
                Name = "Ludwig van Beethoven",
                Genres = new List<Genre> { genres[1] },
                Recording = "Piano Concertos Nos. 4 and 5",
                Occasions = new List<Occasion> { occasions[3] },
                Numbers = "519"
            },
            new Musician
            {
                Name = "Asha Bhosle",
                Genres = new List<Genre> { genres[14], genres[39] },
                Recording = "The Rough Guide to Asha Bhosle",
                Occasions = new List<Occasion> { occasions[3] },
                Numbers = "418"
            },
            new Musician
            {
                Name = "Camarón de la Isla",
                Genres = new List<Genre> { genres[14], genres[61] },
                Recording = "La leyenda del tiempo",
                Occasions = new List<Occasion> { occasions[3] },
                Numbers = "528"
            },
            new Musician
            {
                Name = "James Carr",
                Genres = new List<Genre> { genres[11] },
                Recording = "You Got My Mind Messed Up",
                Occasions = new List<Occasion> { occasions[3] },
                Numbers = "445"
            },
            new Musician
            {
                Name = "Cartola",
                Genres = new List<Genre> { genres[14], genres[20] },
                Recording = "Cartola",
                Occasions = new List<Occasion> { occasions[3] },
                Numbers = "234"
            },
            new Musician
            {
                Name = "Dorival Caymmi",
                Genres = new List<Genre> { genres[14], genres[20] },
                Recording = "Caymmi e seu violão",
                Occasions = new List<Occasion> { occasions[3] },
                Numbers = "591"
            },
            new Musician
            {
                Name = "Frédéric Chopin",
                Genres = new List<Genre> { genres[1] },
                Recording = "Piano Concertos Nos. 1 and 2",
                Occasions = new List<Occasion> { occasions[3] },
                Numbers = "187"
            },
            new Musician
            {
                Name = "Jimmy Cliff",
                Genres = new List<Genre> { genres[14], genres[42] },
                Recording = "The Harder They Come",
                Occasions = new List<Occasion> { occasions[3], occasions[2] },
                Numbers = "775"
            },
            new Musician
            {
                Name = "Nat King Cole and His Trio",
                Genres = new List<Genre> { genres[13] },
                Recording = "The Complete After Midnight Sessions",
                Occasions = new List<Occasion> { occasions[3], occasions[0] },
                Numbers = "941"
            },
            new Musician
            {
                Name = "D'Angelo",
                Genres = new List<Genre> { genres[11] },
                Recording = "Brown Sugar",
                Occasions = new List<Occasion> { occasions[3] },
                Numbers = "822"
            },
            new Musician
            {
                Name = "Miles Davis and Gil Evans",
                Genres = new List<Genre> { genres[7] },
                Recording = "Sketches of Spain",
                Occasions = new List<Occasion> { occasions[3] },
                Numbers = "288, 757"
            },
            new Musician
            {
                Name = "Claude Debussy",
                Genres = new List<Genre> { genres[1] },
                Recording = "Preludes",
                Occasions = new List<Occasion> { occasions[3] },
                Numbers = "389"
            },
            new Musician
            {
                Name = "Djavan",
                Genres = new List<Genre> { genres[14], genres[20] },
                Recording = "Luz",
                Occasions = new List<Occasion> { occasions[3] },
                Numbers = "766"
            },
            new Musician
            {
                Name = "Jacqueline du Pré",
                Genres = new List<Genre> { genres[1] },
                Recording = "Elgar: Cello Concerto",
                Occasions = new List<Occasion> { occasions[3] },
                Numbers = "297"
            },
            new Musician
            {
                Name = "ESG",
                Genres = new List<Genre> { genres[6], genres[11] },
                Recording = "A South Bronx Story",
                Occasions = new List<Occasion> { occasions[3], occasions[4] },
                Numbers = ""
            },
            new Musician
            {
                Name = "Cesaria Evora",
                Genres = new List<Genre> { genres[14], genres[23] },
                Recording = "Cesaria",
                Occasions = new List<Occasion> { occasions[3] },
                Numbers = "555"
            },
            new Musician
            {
                Name = "Cheo Feliciano",
                Genres = new List<Genre> { genres[14], genres[54] },
                Recording = "Cheo",
                Occasions = new List<Occasion> { occasions[3] },
                Numbers = "279"
            },
            new Musician
            {
                Name = "Jose Feliciano",
                Genres = new List<Genre> { genres[13] },
                Recording = "El sentimiento, la voz, y la guitarra",
                Occasions = new List<Occasion> { occasions[3] },
                Numbers = "115"
            },
            new Musician
            {
                Name = "Aretha Franklin",
                Genres = new List<Genre> { genres[11] },
                Recording = "I Never Loved a Man the Way I Love You",
                Occasions = new List<Occasion> { occasions[3] },
                Numbers = "472"
            },
            new Musician
            {
                Name = "Carlos Gardel",
                Genres = new List<Genre> { genres[14], genres[18] },
                Recording = "The Best of Carlos Gardel",
                Occasions = new List<Occasion> { occasions[3] },
                Numbers = "216"
            },
            new Musician
            {
                Name = "Marvin Gaye",
                Genres = new List<Genre> { genres[11] },
                Recording = "Let's Get It On",
                Occasions = new List<Occasion> { occasions[3] },
                Numbers = "775"
            },
            new Musician
            {
                Name = "Bebel Gilberto",
                Genres = new List<Genre> { genres[14], genres[20] },
                Recording = "Tanto tempo",
                Occasions = new List<Occasion> { occasions[3] },
                Numbers = "757"
            },
            new Musician
            {
                Name = "João Gilberto",
                Genres = new List<Genre> { genres[14], genres[20] },
                Recording = "João Gilberto",
                Occasions = new List<Occasion> { occasions[3], occasions[2] },
                Numbers = "611"
            },
            new Musician
            {
                Name = "The Jimmy Giuffre Three",
                Genres = new List<Genre> { genres[7] },
                Recording = "1961",
                Occasions = new List<Occasion> { occasions[3] },
                Numbers = "766"
            },
            new Musician
            {
                Name = "Al Green",
                Genres = new List<Genre> { genres[11] },
                Recording = "Call Me",
                Occasions = new List<Occasion> { occasions[3] },
                Numbers = "932"
            },
            new Musician
            {
                Name = "Edvard Grieg",
                Genres = new List<Genre> { genres[1] },
                Recording = "Lyric Pieces",
                Occasions = new List<Occasion> { occasions[3] },
                Numbers = "445"
            },
            new Musician
            {
                Name = "Donny Hathaway",
                Genres = new List<Genre> { genres[11] },
                Recording = "Everything Is Everything",
                Occasions = new List<Occasion> { occasions[3] },
                Numbers = "115"
            },
            new Musician
            {
                Name = "Coleman Hawkins",
                Genres = new List<Genre> { genres[7] },
                Recording = "'Body and Soul'",
                Occasions = new List<Occasion> { occasions[3] },
                Numbers = "454"
            },
            new Musician
            {
                Name = "Whitney Houston",
                Genres = new List<Genre> { genres[11] },
                Recording = "Whitney Houston",
                Occasions = new List<Occasion> { occasions[3] },
                Numbers = "124"
            },
            new Musician
            {
                Name = "Antonio Carlos Jobim",
                Genres = new List<Genre> { genres[14], genres[20] },
                Recording = "The Composer of 'Desafinado' Plays",
                Occasions = new List<Occasion> { occasions[3] },
                Numbers = "297"
            },
            new Musician
            {
                Name = "Antonio Carlos Jobim and Elis Regina",
                Genres = new List<Genre> { genres[14], genres[20] },
                Recording = "Elis, Tom",
                Occasions = new List<Occasion> { occasions[3] },
                Numbers = "297, 178"
            },
            new Musician
            {
                Name = "Little Willie John",
                Genres = new List<Genre> { genres[11] },
                Recording = "The Very Best of Little Willie John",
                Occasions = new List<Occasion> { occasions[3], occasions[0] },
                Numbers = "959"
            },
            new Musician
            {
                Name = "Norah Jones",
                Genres = new List<Genre> { genres[13] },
                Recording = "Come Away with Me",
                Occasions = new List<Occasion> { occasions[3] },
                Numbers = "344"
            },
            new Musician
            {
                Name = "Gladys Knight and the Pips",
                Genres = new List<Genre> { genres[11] },
                Recording = "Imagination",
                Occasions = new List<Occasion> { occasions[3] },
                Numbers = "288, 427, 573, 721"
            },
            new Musician
            {
                Name = "Steve Lacy and Mal Waldron",
                Genres = new List<Genre> { genres[7] },
                Recording = "Hot House",
                Occasions = new List<Occasion> { occasions[3] },
                Numbers = "288, 389"
            },
            new Musician
            {
                Name = "Peggy Lee",
                Genres = new List<Genre> { genres[13] },
                Recording = "Black Coffee",
                Occasions = new List<Occasion> { occasions[3], occasions[0] },
                Numbers = "885"
            },
            new Musician
            {
                Name = "Franz Liszt",
                Genres = new List<Genre> { genres[1] },
                Recording = "The Two Piano Concertos, The Piano Sonata",
                Occasions = new List<Occasion> { occasions[3] },
                Numbers = "968"
            },
            new Musician
            {
                Name = "Julie London",
                Genres = new List<Genre> { genres[13] },
                Recording = "At Home/Around Midnight",
                Occasions = new List<Occasion> { occasions[3] },
                Numbers = "243"
            },
            new Musician
            {
                Name = "Loretta Lynn",
                Genres = new List<Genre> { genres[2] },
                Recording = "The Definitive Collection",
                Occasions = new List<Occasion> { occasions[3] },
                Numbers = "591"
            },
            new Musician
            {
                Name = "Johnny Mathis",
                Genres = new List<Genre> { genres[13] },
                Recording = "Open Fire, Two Guitars",
                Occasions = new List<Occasion> { occasions[3] },
                Numbers = "243"
            },
            new Musician
            {
                Name = "The Modern Jazz Quartet",
                Genres = new List<Genre> { genres[7] },
                Recording = "European Concert",
                Occasions = new List<Occasion> { occasions[3], occasions[0] },
                Numbers = "638, 647, 894, 591, 169, 555, 288"
            },
            new Musician
            {
                Name = "Gabriel Montero",
                Genres = new List<Genre> { genres[1] },
                Recording = "Bach and Beyond",
                Occasions = new List<Occasion> { occasions[3], occasions[8] },
                Numbers = "326"
            },
            new Musician
            {
                Name = "Beny Moré",
                Genres = new List<Genre> { genres[14], genres[28] },
                Recording = "Cuban Originals",
                Occasions = new List<Occasion> { occasions[3] },
                Numbers = "986"
            },
            new Musician
            {
                Name = "Maria Muldaur",
                Genres = new List<Genre> { genres[10], genres[12] },
                Recording = "Maria Muldaur",
                Occasions = new List<Occasion> { occasions[3] },
                Numbers = "371"
            },
            new Musician
            {
                Name = "Willie Nelson",
                Genres = new List<Genre> { genres[2] },
                Recording = "Stardust",
                Occasions = new List<Occasion> { occasions[3], occasions[8] },
                Numbers = "463"
            },
            new Musician
            {
                Name = "Aaron Neville",
                Genres = new List<Genre> { genres[11] },
                Recording = "Tell It like It Is",
                Occasions = new List<Occasion> { occasions[3] },
                Numbers = "638"
            },
            new Musician
            {
                Name = "Les Nubians",
                Genres = new List<Genre> { genres[11] },
                Recording = "Princesses Nubiennes",
                Occasions = new List<Occasion> { occasions[3], occasions[1] },
                Numbers = "418, 849"
            },
            new Musician
            {
                Name = "Roy Orbison",
                Genres = new List<Genre> { genres[12] },
                Recording = "For the Lonely: Eighteen Greatest Hits",
                Occasions = new List<Occasion> { occasions[3] },
                Numbers = "169"
            },
            new Musician
            {
                Name = "Orquesta Casino de la Playa",
                Genres = new List<Genre> { genres[14], genres[28] },
                Recording = "Memories of Cuba",
                Occasions = new List<Occasion> { occasions[3] },
                Numbers = "858, 784, 721, 849, 344"
            },
            new Musician
            {
                Name = "Billy Paul",
                Genres = new List<Genre> { genres[11] },
                Recording = "'Me and Mrs. Jones'",
                Occasions = new List<Occasion> { occasions[3] },
                Numbers = "353"
            },
            new Musician
            {
                Name = "Baden Powell",
                Genres = new List<Genre> { genres[14], genres[20] },
                Recording = "O universe musical de Baden Powell",
                Occasions = new List<Occasion> { occasions[3] },
                Numbers = "995"
            },
            new Musician
            {
                Name = "Maurice Ravel",
                Genres = new List<Genre> { genres[1] },
                Recording = "Complete Works for Piano",
                Occasions = new List<Occasion> { occasions[3], occasions[2] },
                Numbers = "813"
            },
            new Musician
            {
                Name = "Elis Regina",
                Genres = new List<Genre> { genres[14], genres[20] },
                Recording = "Como, porque",
                Occasions = new List<Occasion> { occasions[3] },
                Numbers = "178"
            },
            new Musician
            {
                Name = "Django Reinhardt",
                Genres = new List<Genre> { genres[7] },
                Recording = "The Classic Early Recordings in Chronological Order",
                Occasions = new List<Occasion> { occasions[3] },
                Numbers = "169"
            },
            new Musician
            {
                Name = "Smokey Robinson and the Miracles",
                Genres = new List<Genre> { genres[7], genres[11] },
                Recording = "The Ultimate Collection",
                Occasions = new List<Occasion> { occasions[3] },
                Numbers = "656, 995, 775, 822, 656, 445, 573, 555"
            },
            new Musician
            {
                Name = "Amália Rodrigues",
                Genres = new List<Genre> { genres[14], genres[56] },
                Recording = "The Art of Amália Rodrigues",
                Occasions = new List<Occasion> { occasions[3] },
                Numbers = "867"
            },
            new Musician
            {
                Name = "Roxy Music",
                Genres = new List<Genre> { genres[12] },
                Recording = "Avalon",
                Occasions = new List<Occasion> { occasions[3] },
                Numbers = "115, 591, 995, 454"
            },
            new Musician
            {
                Name = "Gustavo Santaolalla",
                Genres = new List<Genre> { genres[14], genres[18] },
                Recording = "Ronroco",
                Occasions = new List<Occasion> { occasions[3], occasions[2] },
                Numbers = "427"
            },
            new Musician
            {
                Name = "Jill Scott",
                Genres = new List<Genre> { genres[11] },
                Recording = "Who Is Jill Scott? Words and Sounds, Vol. 1",
                Occasions = new List<Occasion> { occasions[3] },
                Numbers = "178"
            },
            new Musician
            {
                Name = "Jimmy Scott",
                Genres = new List<Genre> { genres[13] },
                Recording = "Falling in Love Is Wonderful",
                Occasions = new List<Occasion> { occasions[3] },
                Numbers = "398"
            },
            new Musician
            {
                Name = "Wayne Shorter featuring Milton Nascimento",
                Genres = new List<Genre> { genres[7] },
                Recording = "Native Dancer",
                Occasions = new List<Occasion> { occasions[3] },
                Numbers = "427"
            },
            new Musician
            {
                Name = "Simply Red",
                Genres = new List<Genre> { genres[12] },
                Recording = "Picture Book",
                Occasions = new List<Occasion> { occasions[3] },
                Numbers = "445, 178"
            },
            new Musician
            {
                Name = "Frank Sinatra",
                Genres = new List<Genre> { genres[13] },
                Recording = "Sings for Only the Lonely",
                Occasions = new List<Occasion> { occasions[3] },
                Numbers = "472"
            },
            new Musician
            {
                Name = "Frank Sinatra and Antonio Carlos Jobim",
                Genres = new List<Genre> { genres[13] },
                Recording = "Francis Albert Sinatra, Antonio Carlos Jobim",
                Occasions = new List<Occasion> { occasions[3] },
                Numbers = "472, 297"
            },
            new Musician
            {
                Name = "Percy Sledge",
                Genres = new List<Genre> { genres[11] },
                Recording = "'When a Man Loves a Woman'",
                Occasions = new List<Occasion> { occasions[3] },
                Numbers = "528"
            },
            new Musician
            {
                Name = "Stephen Sondheim",
                Genres = new List<Genre> { genres[8] },
                Recording = "A Little Night Music",
                Occasions = new List<Occasion> { occasions[3] },
                Numbers = "775"
            },
            new Musician
            {
                Name = "Dusty Springfield",
                Genres = new List<Genre> { genres[13] },
                Recording = "Dusty in Memphis",
                Occasions = new List<Occasion> { occasions[3], occasions[0] },
                Numbers = "766"
            },
            new Musician
            {
                Name = "Rod Stewart",
                Genres = new List<Genre> { genres[12] },
                Recording = "Every Picture Tells a Story",
                Occasions = new List<Occasion> { occasions[3] },
                Numbers = "297"
            },
            new Musician
            {
                Name = "Howard Tate",
                Genres = new List<Genre> { genres[11] },
                Recording = "Get It While You Can",
                Occasions = new List<Occasion> { occasions[3] },
                Numbers = "721"
            },
            new Musician
            {
                Name = "Pyotr Ilyich Tchaikovsky",
                Genres = new List<Genre> { genres[1] },
                Recording = "Symphony No. 6 'Pathétique'",
                Occasions = new List<Occasion> { occasions[3] },
                Numbers = "757"
            },
            new Musician
            {
                Name = "The Temptations",
                Genres = new List<Genre> { genres[11] },
                Recording = "'Ain't Too Proud to Beg'",
                Occasions = new List<Occasion> { occasions[3] },
                Numbers = "537, 638, 775, 748, 499, 178, 712"
            },
            new Musician
            {
                Name = "Various Artists",
                Genres = new List<Genre> { genres[14], genres[28] },
                Recording = "Buena Vista Social Club",
                Occasions = new List<Occasion> { occasions[3] },
                Numbers = ""
            },
            new Musician
            {
                Name = "Barry White",
                Genres = new List<Genre> { genres[11] },
                Recording = "Can't Get Enough",
                Occasions = new List<Occasion> { occasions[3] },
                Numbers = "243"
            },
            new Musician
            {
                Name = "Bill Withers",
                Genres = new List<Genre> { genres[11] },
                Recording = "Still Bill",
                Occasions = new List<Occasion> { occasions[3] },
                Numbers = "876"
            },
            new Musician
            {
                Name = "Alice in Chains",
                Genres = new List<Genre> { genres[12] },
                Recording = "Dirt",
                Occasions = new List<Occasion> { occasions[10] },
                Numbers = "775, 757, 757, 683, 683, 775"
            },
            new Musician
            {
                Name = "The Arcade Fire",
                Genres = new List<Genre> { genres[12] },
                Recording = "Neon Bible",
                Occasions = new List<Occasion> { occasions[10], occasions[9] },
                Numbers = "297, 683, 546, 977, 445, 389"
            },
            new Musician
            {
                Name = "Bad Brains",
                Genres = new List<Genre> { genres[12] },
                Recording = "I Against I",
                Occasions = new List<Occasion> { occasions[10] },
                Numbers = "822, 674, 499, 775, 519, 914"
            },
            new Musician
            {
                Name = "The Beach Boys",
                Genres = new List<Genre> { genres[12] },
                Recording = "Pet Sounds",
                Occasions = new List<Occasion> { occasions[10] },
                Numbers = "445, 519, 427, 445, 941, 225"
            },
            new Musician
            {
                Name = "Ludwig van Beethoven",
                Genres = new List<Genre> { genres[1] },
                Recording = "String Quartets, Opp. 131, 135, 66-67",
                Occasions = new List<Occasion> { occasions[10] },
                Numbers = "519"
            },
            new Musician
            {
                Name = "Ludwig van Beethoven",
                Genres = new List<Genre> { genres[1] },
                Recording = "Symphonies Nos. 1-9",
                Occasions = new List<Occasion> { occasions[10] },
                Numbers = "519"
            },
            new Musician
            {
                Name = "Ludwig van Beethoven",
                Genres = new List<Genre> { genres[1] },
                Recording = "Violin Concerto",
                Occasions = new List<Occasion> { occasions[10] },
                Numbers = "519"
            },
            new Musician
            {
                Name = "Black Flag",
                Genres = new List<Genre> { genres[12] },
                Recording = "Damaged",
                Occasions = new List<Occasion> { occasions[10] },
                Numbers = "142, 977, 297, 353"
            },
            new Musician
            {
                Name = "Café Tacuba",
                Genres = new List<Genre> { genres[14], genres[50] },
                Recording = "Cuatro caminos",
                Occasions = new List<Occasion> { occasions[10] },
                Numbers = "472, 683, 472"
            },
            new Musician
            {
                Name = "Johnny Cash",
                Genres = new List<Genre> { genres[2] },
                Recording = "At Folsom Prison",
                Occasions = new List<Occasion> { occasions[10], occasions[6] },
                Numbers = "528"
            },
            new Musician
            {
                Name = "The Clash",
                Genres = new List<Genre> { genres[12] },
                Recording = "London Calling",
                Occasions = new List<Occasion> { occasions[10] },
                Numbers = "389, 914, 941, 923, 876, 739, 959, 481, 472"
            },
            new Musician
            {
                Name = "Elvis Costello and the Attractions",
                Genres = new List<Genre> { genres[12] },
                Recording = "Armed Forces",
                Occasions = new List<Occasion> { occasions[10] },
                Numbers = "124, 721, 656, 124"
            },
            new Musician
            {
                Name = "Bob Dylan",
                Genres = new List<Genre> { genres[12] },
                Recording = "Blonde on Blonde",
                Occasions = new List<Occasion> { occasions[10] },
                Numbers = "582"
            },
            new Musician
            {
                Name = "Fishbone",
                Genres = new List<Genre> { genres[12] },
                Recording = "Truth and Soul",
                Occasions = new List<Occasion> { occasions[10], occasions[1] },
                Numbers = "831, 849, 169, 692, 481, 959"
            },
            new Musician
            {
                Name = "Aretha Franklin",
                Genres = new List<Genre> { genres[5] },
                Recording = "Amazing Grace",
                Occasions = new List<Occasion> { occasions[10], occasions[8] },
                Numbers = "472"
            },
            new Musician
            {
                Name = "Fugazi",
                Genres = new List<Genre> { genres[12] },
                Recording = "Repeater",
                Occasions = new List<Occasion> { occasions[10] },
                Numbers = "297, 187, 775, 849"
            },
            new Musician
            {
                Name = "Gang of Four",
                Genres = new List<Genre> { genres[12] },
                Recording = "Entertainment!",
                Occasions = new List<Occasion> { occasions[10] },
                Numbers = "914, 813, 941"
            },
            new Musician
            {
                Name = "Marvin Gaye",
                Genres = new List<Genre> { genres[11] },
                Recording = "What's Going On",
                Occasions = new List<Occasion> { occasions[10] },
                Numbers = "775"
            },
            new Musician
            {
                Name = "Green Day",
                Genres = new List<Genre> { genres[12] },
                Recording = "American Idiot",
                Occasions = new List<Occasion> { occasions[10] },
                Numbers = "187, 169, 178"
            },
            new Musician
            {
                Name = "George Frideric Handel",
                Genres = new List<Genre> { genres[1] },
                Recording = "Messiah",
                Occasions = new List<Occasion> { occasions[10] },
                Numbers = "959"
            },
            new Musician
            {
                Name = "Hüsker Dü",
                Genres = new List<Genre> { genres[12] },
                Recording = "Zen Arcade",
                Occasions = new List<Occasion> { occasions[10] },
                Numbers = "499, 519, 344"
            },
            new Musician
            {
                Name = "Iggy and the Stooges",
                Genres = new List<Genre> { genres[12] },
                Recording = "Raw Power",
                Occasions = new List<Occasion> { occasions[10] },
                Numbers = "894, 739, 683, 885"
            },
            new Musician
            {
                Name = "Mahalia Jackson",
                Genres = new List<Genre> { genres[5] },
                Recording = "The Apollo Sessions: 1946-1951",
                Occasions = new List<Occasion> { occasions[10] },
                Numbers = "831"
            },
            new Musician
            {
                Name = "Jane's Addiction",
                Genres = new List<Genre> { genres[12] },
                Recording = "Ritual de lo Habitual",
                Occasions = new List<Occasion> { occasions[10] },
                Numbers = "519, 611, 674, 317"
            },
            new Musician
            {
                Name = "Kodo",
                Genres = new List<Genre> { genres[14], genres[43] },
                Recording = "Live at Acropolis, Athens, Greece",
                Occasions = new List<Occasion> { occasions[10] },
                Numbers = "656, 463"
            },
            new Musician
            {
                Name = "The Mahavishnu Orchestra",
                Genres = new List<Genre> { genres[7] },
                Recording = "The Inner Mounting Flame",
                Occasions = new List<Occasion> { occasions[10] },
                Numbers = "519, 288, 766, 647, 528"
            },
            new Musician
            {
                Name = "Gustav Mahler",
                Genres = new List<Genre> { genres[1] },
                Recording = "Symphony No. 9",
                Occasions = new List<Occasion> { occasions[10] },
                Numbers = "573"
            },
            new Musician
            {
                Name = "Thomas Mapfumo and the Blacks Unlimited",
                Genres = new List<Genre> { genres[14], genres[66] },
                Recording = "Chimurenga Singles, 1976-1980",
                Occasions = new List<Occasion> { occasions[10] },
                Numbers = "142"
            },
            new Musician
            {
                Name = "Bob Marley and the Wailers",
                Genres = new List<Genre> { genres[14], genres[42] },
                Recording = "Exodus",
                Occasions = new List<Occasion> { occasions[10] },
                Numbers = "187, 959, 611, 288, 519, 775, 885, 335"
            },
            new Musician
            {
                Name = "MC5",
                Genres = new List<Genre> { genres[12] },
                Recording = "Kick Out the Jams",
                Occasions = new List<Occasion> { occasions[10] },
                Numbers = "766, 674, 216, 326, 721"
            },
            new Musician
            {
                Name = "Yehudi Menuhin",
                Genres = new List<Genre> { genres[1] },
                Recording = "Beethoven Violin Concerto, Mendelssohn Violin Concerto",
                Occasions = new List<Occasion> { occasions[10] },
                Numbers = "335,  519"
            },
            new Musician
            {
                Name = "Metallica",
                Genres = new List<Genre> { genres[12] },
                Recording = "Master of Puppets",
                Occasions = new List<Occasion> { occasions[10] },
                Numbers = "133, 178, 225, 968"
            },
            new Musician
            {
                Name = "Ministry",
                Genres = new List<Genre> { genres[12] },
                Recording = "The Mind Is a Terrible Thing to Taste",
                Occasions = new List<Occasion> { occasions[10] },
                Numbers = "528, 665, 418"
            },
            new Musician
            {
                Name = "Mother Love Bone",
                Genres = new List<Genre> { genres[12] },
                Recording = "Apple",
                Occasions = new List<Occasion> { occasions[10] },
                Numbers = "178, 472, 344, 739, 894"
            },
            new Musician
            {
                Name = "My Morning Jacket",
                Genres = new List<Genre> { genres[12] },
                Recording = "It Still Moves",
                Occasions = new List<Occasion> { occasions[10] },
                Numbers = "463, 481, 858, 932"
            },
            new Musician
            {
                Name = "Nirvana",
                Genres = new List<Genre> { genres[12] },
                Recording = "Nevermind",
                Occasions = new List<Occasion> { occasions[10] },
                Numbers = "656, 885, 591"
            },
            new Musician
            {
                Name = "Pantera",
                Genres = new List<Genre> { genres[12] },
                Recording = "Vulgar Display of Power",
                Occasions = new List<Occasion> { occasions[10] },
                Numbers = "721, 941, 959, 995, 573"
            },
            new Musician
            {
                Name = "Pearl Jam",
                Genres = new List<Genre> { genres[12] },
                Recording = "Ten",
                Occasions = new List<Occasion> { occasions[10] },
                Numbers = "941, 775, 739, 178, 225, 638, 463, 234, 472"
            },
            new Musician
            {
                Name = "The Police",
                Genres = new List<Genre> { genres[12] },
                Recording = "Synchronicity",
                Occasions = new List<Occasion> { occasions[10] },
                Numbers = "418, 398, 362, 472"
            },
            new Musician
            {
                Name = "Public Enemy",
                Genres = new List<Genre> { genres[6] },
                Recording = "It Takes a Nation of Millions to Hold Us Back",
                Occasions = new List<Occasion> { occasions[10] },
                Numbers = "436, 775, 721, 436, 519"
            },
            new Musician
            {
                Name = "Radiohead",
                Genres = new List<Genre> { genres[12] },
                Recording = "OK Computer",
                Occasions = new List<Occasion> { occasions[10], occasions[9] },
                Numbers = "546, 234, 591, 445, 629"
            },
            new Musician
            {
                Name = "Max Roach",
                Genres = new List<Genre> { genres[7] },
                Recording = "We Insist! Freedom Now Suite",
                Occasions = new List<Occasion> { occasions[10] },
                Numbers = "591"
            },
            new Musician
            {
                Name = "The Rolling Stones",
                Genres = new List<Genre> { genres[12] },
                Recording = "Exile on Main St",
                Occasions = new List<Occasion> { occasions[10] },
                Numbers = "398, 344, 582, 885, 481, 867, 196, 766"
            },
            new Musician
            {
                Name = "Franz Schubert",
                Genres = new List<Genre> { genres[1] },
                Recording = "Symphony No. 9",
                Occasions = new List<Occasion> { occasions[10] },
                Numbers = "638"
            },
            new Musician
            {
                Name = "Sepultura",
                Genres = new List<Genre> { genres[12] },
                Recording = "Roots",
                Occasions = new List<Occasion> { occasions[10] },
                Numbers = "528, 436, 389, 463, 555, 335, 169"
            },
            new Musician
            {
                Name = "Sleater-Kinney",
                Genres = new List<Genre> { genres[12] },
                Recording = "Call the Doctor",
                Occasions = new List<Occasion> { occasions[10], occasions[6] },
                Numbers = "849, 187, 849"
            },
            new Musician
            {
                Name = "Sly and the Family Stone",
                Genres = new List<Genre> { genres[11] },
                Recording = "Stand!",
                Occasions = new List<Occasion> { occasions[10] },
                Numbers = "344, 885, 335, 418, 986, 721, 178, 591"
            },
            new Musician
            {
                Name = "Sonic Youth",
                Genres = new List<Genre> { genres[12] },
                Recording = "Daydream Nation",
                Occasions = new List<Occasion> { occasions[10] },
                Numbers = "692, 297, 932, 216, 279, 968, 591, 234"
            },
            new Musician
            {
                Name = "Soundgarden",
                Genres = new List<Genre> { genres[12] },
                Recording = "Superunknown",
                Occasions = new List<Occasion> { occasions[10] },
                Numbers = "427, 546, 225, 995, 335, 665"
            },
            new Musician
            {
                Name = "Bruce Springsteen",
                Genres = new List<Genre> { genres[12] },
                Recording = "Born to Run",
                Occasions = new List<Occasion> { occasions[10] },
                Numbers = "674"
            },
            new Musician
            {
                Name = "Karlheinz Stockhausen",
                Genres = new List<Genre> { genres[1] },
                Recording = "Stimmung Richard Strauss, Also sprach Zarathustra",
                Occasions = new List<Occasion> { occasions[10] },
                Numbers = "986, 142"
            },
            new Musician
            {
                Name = "System of a Down",
                Genres = new List<Genre> { genres[12] },
                Recording = "Toxicity",
                Occasions = new List<Occasion> { occasions[10] },
                Numbers = "683, 739, 894, 995, 766"
            },
            new Musician
            {
                Name = "A Tribe Called Quest",
                Genres = new List<Genre> { genres[6] },
                Recording = "The Low End Theory",
                Occasions = new List<Occasion> { occasions[10] },
                Numbers = "335, 353, 389, 279"
            },
            new Musician
            {
                Name = "U2",
                Genres = new List<Genre> { genres[12] },
                Recording = "The Joshua Tree",
                Occasions = new List<Occasion> { occasions[10] },
                Numbers = "454, 389, 472, 362"
            },
            new Musician
            {
                Name = "Richard Wagner",
                Genres = new List<Genre> { genres[9] },
                Recording = "Götterdämmerung",
                Occasions = new List<Occasion> { occasions[10] },
                Numbers = "757"
            },
            new Musician
            {
                Name = "Kanye West",
                Genres = new List<Genre> { genres[6] },
                Recording = "College Dropout",
                Occasions = new List<Occasion> { occasions[10] },
                Numbers = "573"
            },
            new Musician
            {
                Name = "The Who",
                Genres = new List<Genre> { genres[12] },
                Recording = "Tommy",
                Occasions = new List<Occasion> { occasions[10] },
                Numbers = "225, 151, 234, 784, 986, 712"
            },
            new Musician
            {
                Name = "The Who",
                Genres = new List<Genre> { genres[12] },
                Recording = "Who's Next",
                Occasions = new List<Occasion> { occasions[10] },
                Numbers = "225, 151, 234, 784, 986, 712"
            },
            new Musician
            {
                Name = "Stevie Wonder",
                Genres = new List<Genre> { genres[11] },
                Recording = "Innervisions",
                Occasions = new List<Occasion> { occasions[10], occasions[1] },
                Numbers = "582"
            },
            new Musician
            {
                Name = "X",
                Genres = new List<Genre> { genres[12] },
                Recording = "Wild Gift",
                Occasions = new List<Occasion> { occasions[10] },
                Numbers = "225, 784, 932, 941, 959, 398"
            },
            new Musician
            {
                Name = "Frank Zappa",
                Genres = new List<Genre> { genres[12] },
                Recording = "The Best Band You Never Heard in Your Life",
                Occasions = new List<Occasion> { occasions[10] },
                Numbers = "647"
            },
            new Musician
            {
                Name = "Marian Anderson",
                Genres = new List<Genre> { genres[1], genres[5] },
                Recording = "Spirituals",
                Occasions = new List<Occasion> { occasions[8] },
                Numbers = "481"
            },
            new Musician
            {
                Name = "Martha Argerich",
                Genres = new List<Genre> { genres[1] },
                Recording = "Prokofiev: Piano Concerto No. 3; Ravel: Piano Concerto in G",
                Occasions = new List<Occasion> { occasions[8] },
                Numbers = "582"
            },
            new Musician
            {
                Name = "J. S. Bach",
                Genres = new List<Genre> { genres[1] },
                Recording = "The Brandenburg Concertos",
                Occasions = new List<Occasion> { occasions[8] },
                Numbers = "941"
            },
            new Musician
            {
                Name = "J. S. Bach",
                Genres = new List<Genre> { genres[1] },
                Recording = "Complete Sonatas and Partitas for Solo Violin",
                Occasions = new List<Occasion> { occasions[8] },
                Numbers = "941"
            },
            new Musician
            {
                Name = "Cecilia Bartoli",
                Genres = new List<Genre> { genres[1] },
                Recording = "The Vivaldi Album",
                Occasions = new List<Occasion> { occasions[8] },
                Numbers = "757"
            },
            new Musician
            {
                Name = "Ludwig van Beethoven",
                Genres = new List<Genre> { genres[1] },
                Recording = "'Archduke' Trio, Kreutzer Sonata",
                Occasions = new List<Occasion> { occasions[8] },
                Numbers = "519"
            },
            new Musician
            {
                Name = "Dock Boggs",
                Genres = new List<Genre> { genres[4] },
                Recording = "Dock Boggs: His Folkway Years, 1963-1968",
                Occasions = new List<Occasion> { occasions[8] },
                Numbers = "353"
            },
            new Musician
            {
                Name = "Johannes Brahms",
                Genres = new List<Genre> { genres[1] },
                Recording = "Sonatas for Cello and Piano, Opp. 38, 99, 108, 111",
                Occasions = new List<Occasion> { occasions[8] },
                Numbers = "582"
            },
            new Musician
            {
                Name = "Johannes Brahms",
                Genres = new List<Genre> { genres[1] },
                Recording = "Violin Sonatas, Opp. 78, 100, 108, 113",
                Occasions = new List<Occasion> { occasions[8] },
                Numbers = "582"
            },
            new Musician
            {
                Name = "Johannes Brahms",
                Genres = new List<Genre> { genres[1] },
                Recording = "Piano Concerto No. 2",
                Occasions = new List<Occasion> { occasions[8] },
                Numbers = "582"
            },
            new Musician
            {
                Name = "R. L. Burnside",
                Genres = new List<Genre> { genres[0] },
                Recording = "Wish I Was in Heaven Sitting Down",
                Occasions = new List<Occasion> { occasions[8] },
                Numbers = "225"
            },
            new Musician
            {
                Name = "The Byrds",
                Genres = new List<Genre> { genres[12], genres[4] },
                Recording = "Mr. Tambourine Man",
                Occasions = new List<Occasion> { occasions[8] },
                Numbers = "436, 225, 555, 923, 225, 968, 279, 252"
            },
            new Musician
            {
                Name = "Charlie Christian",
                Genres = new List<Genre> { genres[7] },
                Recording = "The Genius of the Electric Guitar",
                Occasions = new List<Occasion> { occasions[8] },
                Numbers = "398"
            },
            new Musician
            {
                Name = "Guy Clark",
                Genres = new List<Genre> { genres[2] },
                Recording = "Old No. 1",
                Occasions = new List<Occasion> { occasions[8] },
                Numbers = "537"
            },
            new Musician
            {
                Name = "Crosby, Stills, Nash, and Young",
                Genres = new List<Genre> { genres[12] },
                Recording = "Déjà vu",
                Occasions = new List<Occasion> { occasions[8] },
                Numbers = "555, 216, 591, 187"
            },
            new Musician
            {
                Name = "Rev. Gary Davis",
                Genres = new List<Genre> { genres[0], genres[5] },
                Recording = "Harlem Street Singer",
                Occasions = new List<Occasion> { occasions[8] },
                Numbers = "739"
            },
            new Musician
            {
                Name = "Miles Davis",
                Genres = new List<Genre> { genres[7] },
                Recording = "The Complete In a Silent Way Sessions",
                Occasions = new List<Occasion> { occasions[8] },
                Numbers = "288"
            },
            new Musician
            {
                Name = "Sandy Denny",
                Genres = new List<Genre> { genres[4] },
                Recording = "Sandy",
                Occasions = new List<Occasion> { occasions[8] },
                Numbers = "932"
            },
            new Musician
            {
                Name = "Paul Desmond with Jim Hall",
                Genres = new List<Genre> { genres[7] },
                Recording = "Take Ten",
                Occasions = new List<Occasion> { occasions[8], occasions[0] },
                Numbers = "481, 784"
            },
            new Musician
            {
                Name = "Toumani Diabaté and Ballake Sissoko",
                Genres = new List<Genre> { genres[14], genres[48] },
                Recording = "New Ancient Strings",
                Occasions = new List<Occasion> { occasions[8], occasions[2] },
                Numbers = "858, 5"
            },
            new Musician
            {
                Name = "Thomas A. Dorsey",
                Genres = new List<Genre> { genres[5] },
                Recording = "Precious Lord Snooks Eaglin, New Orleans Street Singer",
                Occasions = new List<Occasion> { occasions[8] },
                Numbers = "279"
            },
            new Musician
            {
                Name = "Bill Evans and Jim Hall",
                Genres = new List<Genre> { genres[7] },
                Recording = "Undercurrent",
                Occasions = new List<Occasion> { occasions[8] },
                Numbers = "858, 784"
            },
            new Musician
            {
                Name = "John Fahey",
                Genres = new List<Genre> { genres[4] },
                Recording = "The Transfiguration of Blind Joe Death",
                Occasions = new List<Occasion> { occasions[8] },
                Numbers = "784"
            },
            new Musician
            {
                Name = "Gabriel Fauré",
                Genres = new List<Genre> { genres[1] },
                Recording = "Requiem, Pelléas et Mélisande, Pavane",
                Occasions = new List<Occasion> { occasions[8] },
                Numbers = "288"
            },
            new Musician
            {
                Name = "Bernarda Fink",
                Genres = new List<Genre> { genres[1] },
                Recording = "Brahms: Lieder",
                Occasions = new List<Occasion> { occasions[8] },
                Numbers = "986, 582"
            },
            new Musician
            {
                Name = "Sergio Fiorentino",
                Genres = new List<Genre> { genres[1] },
                Recording = "J. S. Bach, Volume 1",
                Occasions = new List<Occasion> { occasions[8] },
                Numbers = "178, 941"
            },
            new Musician
            {
                Name = "Frank Emilio Flynn",
                Genres = new List<Genre> { genres[14], genres[28] },
                Recording = "Musica original de Cuba",
                Occasions = new List<Occasion> { occasions[8] },
                Numbers = "766"
            },
            new Musician
            {
                Name = "George Gershwin",
                Genres = new List<Genre> { genres[1] },
                Recording = "Complete Works for Piano and Orchestra, with Rhapsody in Blue",
                Occasions = new List<Occasion> { occasions[8] },
                Numbers = "371"
            },
            new Musician
            {
                Name = "Glenn Gould",
                Genres = new List<Genre> { genres[1] },
                Recording = "A State of Wonder: J. S. Bach Goldberg Variations",
                Occasions = new List<Occasion> { occasions[8] },
                Numbers = "546, 941"
            },
            new Musician
            {
                Name = "Grant Green",
                Genres = new List<Genre> { genres[7] },
                Recording = "Feelin' the Spirit",
                Occasions = new List<Occasion> { occasions[8] },
                Numbers = "279"
            },
            new Musician
            {
                Name = "Edvard Grieg and Robert Schumann",
                Genres = new List<Genre> { genres[1] },
                Recording = "Grieg, Schumann Piano Concertos",
                Occasions = new List<Occasion> { occasions[8] },
                Numbers = "445, 142"
            },
            new Musician
            {
                Name = "Clara Haskil",
                Genres = new List<Genre> { genres[1] },
                Recording = "Mozart: Piano Concerto No. 20 in D Minor; Scarlatti: Eleven Sonatas",
                Occasions = new List<Occasion> { occasions[8] },
                Numbers = "766"
            },
            new Musician
            {
                Name = "Ted Hawkins",
                Genres = new List<Genre> { genres[0] },
                Recording = "The Next Hundred Years",
                Occasions = new List<Occasion> { occasions[8] },
                Numbers = "196"
            },
            new Musician
            {
                Name = "Joe Henderson",
                Genres = new List<Genre> { genres[7] },
                Recording = "Power to the People",
                Occasions = new List<Occasion> { occasions[8] },
                Numbers = "932"
            },
            new Musician
            {
                Name = "Roscoe Holcomb",
                Genres = new List<Genre> { genres[4] },
                Recording = "The High Lonesome Sound",
                Occasions = new List<Occasion> { occasions[8] },
                Numbers = "721"
            },
            new Musician
            {
                Name = "Son House",
                Genres = new List<Genre> { genres[0] },
                Recording = "Martin Scorsese Presents the Blues: Son House",
                Occasions = new List<Occasion> { occasions[8] },
                Numbers = "813"
            },
            new Musician
            {
                Name = "Freddie Hubbard",
                Genres = new List<Genre> { genres[7] },
                Recording = "Red Clay",
                Occasions = new List<Occasion> { occasions[8] },
                Numbers = "894"
            },
            new Musician
            {
                Name = "Lorraine Hunt Lieberson",
                Genres = new List<Genre> { genres[1] },
                Recording = "Bach: Cantatas",
                Occasions = new List<Occasion> { occasions[8] },
                Numbers = "187, 941"
            },
            new Musician
            {
                Name = "Mississippi John Hurt",
                Genres = new List<Genre> { genres[0] },
                Recording = "Today!",
                Occasions = new List<Occasion> { occasions[8] },
                Numbers = "813"
            },
            new Musician
            {
                Name = "Abdullah Ibrahim Trio",
                Genres = new List<Genre> { genres[7] },
                Recording = "Yarona",
                Occasions = new List<Occasion> { occasions[8] },
                Numbers = "362"
            },
            new Musician
            {
                Name = "Ahmad Jamal",
                Genres = new List<Genre> { genres[7] },
                Recording = "But Not for Me: Live at the Pershing",
                Occasions = new List<Occasion> { occasions[8], occasions[0] },
                Numbers = "748"
            },
            new Musician
            {
                Name = "Skip James",
                Genres = new List<Genre> { genres[0] },
                Recording = "The Complete Early Recordings of Skip James",
                Occasions = new List<Occasion> { occasions[8] },
                Numbers = "876"
            },
            new Musician
            {
                Name = "Keith Jarrett",
                Genres = new List<Genre> { genres[7] },
                Recording = "My Song",
                Occasions = new List<Occasion> { occasions[8], occasions[2] },
                Numbers = "151"
            },
            new Musician
            {
                Name = "Blind Willie Johnson",
                Genres = new List<Genre> { genres[0], genres[5] },
                Recording = "The Complete Blind Willie Johnson",
                Occasions = new List<Occasion> { occasions[8] },
                Numbers = "591"
            },
            new Musician
            {
                Name = "Fern Jones",
                Genres = new List<Genre> { genres[2], genres[5] },
                Recording = "The Glory Road",
                Occasions = new List<Occasion> { occasions[8] },
                Numbers = "5"
            },
            new Musician
            {
                Name = "Ali Akbar Khan",
                Genres = new List<Genre> { genres[14], genres[39] },
                Recording = "Traditional Music of India",
                Occasions = new List<Occasion> { occasions[8], occasions[2] },
                Numbers = "638"
            },
            new Musician
            {
                Name = "Leo Kottke",
                Genres = new List<Genre> { genres[4] },
                Recording = "6-and 12-String Guitar",
                Occasions = new List<Occasion> { occasions[8] },
                Numbers = "115"
            },
            new Musician
            {
                Name = "Lili Kraus",
                Genres = new List<Genre> { genres[1] },
                Recording = "Mozart Piano Sonata No. 11, Piano Concertos Nos. 12 and 18",
                Occasions = new List<Occasion> { occasions[8] },
                Numbers = "775"
            },
            new Musician
            {
                Name = "The Louvin Brothers",
                Genres = new List<Genre> { genres[2] },
                Recording = "Satan Is Real",
                Occasions = new List<Occasion> { occasions[8] },
                Numbers = "463, 142"
            },
            new Musician
            {
                Name = "Joe Lovano",
                Genres = new List<Genre> { genres[7] },
                Recording = "Quartets: Live at the Village Vanguard",
                Occasions = new List<Occasion> { occasions[8] },
                Numbers = "344"
            },
            new Musician
            {
                Name = "Irén Marik",
                Genres = new List<Genre> { genres[1] },
                Recording = "Bartók in the Desert: The Art of Irén Marik",
                Occasions = new List<Occasion> { occasions[8] },
                Numbers = "5"
            },
            new Musician
            {
                Name = "The Pat Metheny Group",
                Genres = new List<Genre> { genres[7] },
                Recording = "The Pat Metheny Group",
                Occasions = new List<Occasion> { occasions[8], occasions[9] },
                Numbers = "124, 178, 234, 344"
            },
            new Musician
            {
                Name = "Arturo Benedetti Michelangeli",
                Genres = new List<Genre> { genres[1] },
                Recording = "Ravel: Piano Concerto in G; Rachmaninoff: Piano Concerto No. 4",
                Occasions = new List<Occasion> { occasions[8] },
                Numbers = "941, 178"
            },
            new Musician
            {
                Name = "Thelonious Monk",
                Genres = new List<Genre> { genres[7] },
                Recording = "The Unique Thelonious Monk",
                Occasions = new List<Occasion> { occasions[8] },
                Numbers = "234"
            },
            new Musician
            {
                Name = "Lee Morgan",
                Genres = new List<Genre> { genres[7] },
                Recording = "Search for the New Land",
                Occasions = new List<Occasion> { occasions[8] },
                Numbers = "867"
            },
            new Musician
            {
                Name = "Ennio Morricone",
                Genres = new List<Genre> { genres[1] },
                Recording = "A Fistful of Film Music",
                Occasions = new List<Occasion> { occasions[8] },
                Numbers = "959"
            },
            new Musician
            {
                Name = "Fats Navarro and Tadd Dameron",
                Genres = new List<Genre> { genres[7] },
                Recording = "The Complete Blue Note and Capitol Recordings",
                Occasions = new List<Occasion> { occasions[8] },
                Numbers = "546, 225"
            },
            new Musician
            {
                Name = "Herbie Nichols",
                Genres = new List<Genre> { genres[7] },
                Recording = "The Complete Blue Note Recordings",
                Occasions = new List<Occasion> { occasions[8] },
                Numbers = "178"
            },
            new Musician
            {
                Name = "Remmy Ongala and Orchestre Super Matimila",
                Genres = new List<Genre> { genres[14], genres[62] },
                Recording = "Songs for the Poor Man",
                Occasions = new List<Occasion> { occasions[8] },
                Numbers = "822"
            },
            new Musician
            {
                Name = "Gabby Pahinui",
                Genres = new List<Genre> { genres[14], genres[36] },
                Recording = "Best of the Gabby Band 1972-1977",
                Occasions = new List<Occasion> { occasions[8] },
                Numbers = "766"
            },
            new Musician
            {
                Name = "Art Pepper",
                Genres = new List<Genre> { genres[7] },
                Recording = "Art Pepper Meets the Rhythm Section",
                Occasions = new List<Occasion> { occasions[8] },
                Numbers = "389"
            },
            new Musician
            {
                Name = "Washington Phillips",
                Genres = new List<Genre> { genres[5] },
                Recording = "The Keys to the Kingdom",
                Occasions = new List<Occasion> { occasions[8] },
                Numbers = "463"
            },
            new Musician
            {
                Name = "Elvis Presley",
                Genres = new List<Genre> { genres[10], genres[5] },
                Recording = "How Great Thou Art",
                Occasions = new List<Occasion> { occasions[8] },
                Numbers = "335"
            },
            new Musician
            {
                Name = "John Prine",
                Genres = new List<Genre> { genres[12], genres[4] },
                Recording = "John Prine",
                Occasions = new List<Occasion> { occasions[8], occasions[2] },
                Numbers = "968"
            },
            new Musician
            {
                Name = "Procol Harum",
                Genres = new List<Genre> { genres[12] },
                Recording = "'A Whiter Shade of Pale'",
                Occasions = new List<Occasion> { occasions[8] },
                Numbers = "151, 968, 941, 427, 216, 353, 748, 813, 178"
            },
            new Musician
            {
                Name = "Bonnie Raitt",
                Genres = new List<Genre> { genres[12] },
                Recording = "Give It Up",
                Occasions = new List<Occasion> { occasions[8] },
                Numbers = "656"
            },
            new Musician
            {
                Name = "Ernest Ranglin",
                Genres = new List<Genre> { genres[14], genres[42] },
                Recording = "Below the Bassline",
                Occasions = new List<Occasion> { occasions[8] },
                Numbers = "573"
            },
            new Musician
            {
                Name = "Maurice Ravel",
                Genres = new List<Genre> { genres[1] },
                Recording = "Claude Debussy, Modest Mussorgsky/Ravel, Boléro, La mer, Pictures at an Exhibition",
                Occasions = new List<Occasion> { occasions[8] },
                Numbers = "813, 389, 813"
            },
            new Musician
            {
                Name = "R.E.M.",
                Genres = new List<Genre> { genres[12] },
                Recording = "Murmur",
                Occasions = new List<Occasion> { occasions[8] },
                Numbers = "692, 822, 647, 519"
            },
            new Musician
            {
                Name = "Minnie Riperton",
                Genres = new List<Genre> { genres[11] },
                Recording = "Perfect Angel",
                Occasions = new List<Occasion> { occasions[8] },
                Numbers = "822"
            },
            new Musician
            {
                Name = "Linda Ronstadt",
                Genres = new List<Genre> { genres[12] },
                Recording = "Heart like a Wheel",
                Occasions = new List<Occasion> { occasions[8] },
                Numbers = "995"
            },
            new Musician
            {
                Name = "Marta Sebestyen and Muzsikás",
                Genres = new List<Genre> { genres[14], genres[38] },
                Recording = "Marta Sebestyen and Muzsikas",
                Occasions = new List<Occasion> { occasions[8] },
                Numbers = "721"
            },
            new Musician
            {
                Name = "Andrés Segovia",
                Genres = new List<Genre> { genres[1] },
                Recording = "The Art of Segovia",
                Occasions = new List<Occasion> { occasions[8], occasions[2] },
                Numbers = "822"
            },
            new Musician
            {
                Name = "The Horace Silver Quintet",
                Genres = new List<Genre> { genres[7] },
                Recording = "Song for My Father",
                Occasions = new List<Occasion> { occasions[8] },
                Numbers = "986"
            },
            new Musician
            {
                Name = "Bessie Smith",
                Genres = new List<Genre> { genres[0] },
                Recording = "The Essential Bessie Smith",
                Occasions = new List<Occasion> { occasions[8] },
                Numbers = "766"
            },
            new Musician
            {
                Name = "Elliott Smith",
                Genres = new List<Genre> { genres[12] },
                Recording = "XO",
                Occasions = new List<Occasion> { occasions[8], occasions[2] },
                Numbers = "436"
            },
            new Musician
            {
                Name = "Davy Spillane and Kevin Glackin",
                Genres = new List<Genre> { genres[14], genres[24] },
                Recording = "Forgotten Days",
                Occasions = new List<Occasion> { occasions[8] },
                Numbers = "638, 187"
            },
            new Musician
            {
                Name = "The Staple Singers",
                Genres = new List<Genre> { genres[5], genres[11] },
                Recording = "The Best of the Staple Singers",
                Occasions = new List<Occasion> { occasions[8], occasions[6] },
                Numbers = "739, 519, 1, 2, 335"
            },
            new Musician
            {
                Name = "Isaac Stern",
                Genres = new List<Genre> { genres[1] },
                Recording = "Lalo: Symphonie espagnole; Bruch: Violin Concerto No. 1",
                Occasions = new List<Occasion> { occasions[8] },
                Numbers = "867"
            },
            new Musician
            {
                Name = "The Swan Silvertones",
                Genres = new List<Genre> { genres[5] },
                Recording = "The Swan Silvertones/Saviour Pass Me Not Taj Mahal, The Natch'l Blues",
                Occasions = new List<Occasion> { occasions[8] },
                Numbers = "537, 436"
            },
            new Musician
            {
                Name = "Pyotr Ilyich Tchaikovsky",
                Genres = new List<Genre> { genres[1] },
                Recording = "Violin Concerto, Piano Concerto No. 1",
                Occasions = new List<Occasion> { occasions[8] },
                Numbers = "757"
            },
            new Musician
            {
                Name = "10cc",
                Genres = new List<Genre> { genres[12] },
                Recording = "I'm Not in Love",
                Occasions = new List<Occasion> { occasions[8] },
                Numbers = "923, 297, 115, 849, 546, 288, 739, 6"
            },
            new Musician
            {
                Name = "Ali Farka Touré",
                Genres = new List<Genre> { genres[14], genres[48] },
                Recording = "The River",
                Occasions = new List<Occasion> { occasions[8] },
                Numbers = "793"
            },
            new Musician
            {
                Name = "Lennie Tristano",
                Genres = new List<Genre> { genres[7] },
                Recording = "Tristano/The New Tristano",
                Occasions = new List<Occasion> { occasions[8] },
                Numbers = "941"
            },
            new Musician
            {
                Name = "McCoy Tyner",
                Genres = new List<Genre> { genres[7] },
                Recording = "The Real McCoy",
                Occasions = new List<Occasion> { occasions[8] },
                Numbers = "813"
            },
            new Musician
            {
                Name = "Various Artists",
                Genres = new List<Genre> { genres[1] },
                Recording = "Concert of the Century",
                Occasions = new List<Occasion> { occasions[8] },
                Numbers = ""
            },
            new Musician
            {
                Name = "Various Artists",
                Genres = new List<Genre> { genres[14], genres[25] },
                Recording = "Phases of the Moon: Traditional Chinese Music",
                Occasions = new List<Occasion> { occasions[8], occasions[2] },
                Numbers = ""
            },
            new Musician
            {
                Name = "Caetano Veloso and Gilberto Gil",
                Genres = new List<Genre> { genres[14], genres[20] },
                Recording = "Tropicália 2",
                Occasions = new List<Occasion> { occasions[8] },
                Numbers = "436, 445"
            },
            new Musician
            {
                Name = "Heitor Villa-Lobos",
                Genres = new List<Genre> { genres[1] },
                Recording = "Bachianas brasileiras",
                Occasions = new List<Occasion> { occasions[8], occasions[2] },
                Numbers = "528"
            },
            new Musician
            {
                Name = "Antonio Vivaldi",
                Genres = new List<Genre> { genres[1] },
                Recording = "The Four Seasons",
                Occasions = new List<Occasion> { occasions[8] },
                Numbers = "784"
            },
            new Musician
            {
                Name = "Rufus Wainwright",
                Genres = new List<Genre> { genres[12] },
                Recording = "Want One",
                Occasions = new List<Occasion> { occasions[8] },
                Numbers = "995"
            },
            new Musician
            {
                Name = "Gillian Welch",
                Genres = new List<Genre> { genres[2] },
                Recording = "Time (The Revelator)",
                Occasions = new List<Occasion> { occasions[8], occasions[2] },
                Numbers = "674"
            },
            new Musician
            {
                Name = "Kenny Wheeler",
                Genres = new List<Genre> { genres[7] },
                Recording = "Gnu High",
                Occasions = new List<Occasion> { occasions[8], occasions[2] },
                Numbers = "894"
            },
            new Musician
            {
                Name = "Marion Williams",
                Genres = new List<Genre> { genres[5] },
                Recording = "Strong Again",
                Occasions = new List<Occasion> { occasions[8] },
                Numbers = "124"
            },
            new Musician
            {
                Name = "Mary Lou Williams",
                Genres = new List<Genre> { genres[7] },
                Recording = "Zodiac Suite",
                Occasions = new List<Occasion> { occasions[8] },
                Numbers = "923"
            },
            new Musician
            {
                Name = "Tammy Wynette",
                Genres = new List<Genre> { genres[2] },
                Recording = "Anniversary: Twenty Years of Hits Neil Young, After the Gold Rush",
                Occasions = new List<Occasion> { occasions[8] },
                Numbers = "463"
            },
            new Musician
            {
                Name = "AC/DC",
                Genres = new List<Genre> { genres[12] },
                Recording = "Back in Black",
                Occasions = new List<Occasion> { occasions[4] },
                Numbers = "941, 813, 849, 151, 647, 335, 995, 822, 968, 142"
            },
            new Musician
            {
                Name = "Count Basie and His Orchestra",
                Genres = new List<Genre> { genres[7] },
                Recording = "Complete Decca Recordings",
                Occasions = new List<Occasion> { occasions[4] },
                Numbers = "683"
            },
            new Musician
            {
                Name = "Batacumbele",
                Genres = new List<Genre> { genres[14], genres[28] },
                Recording = "Con un poco de songo",
                Occasions = new List<Occasion> { occasions[4] },
                Numbers = "546, 656, 261, 813, 766, 261, 793, 187"
            },
            new Musician
            {
                Name = "Big Daddy Kane",
                Genres = new List<Genre> { genres[6] },
                Recording = "Long Live the Kane",
                Occasions = new List<Occasion> { occasions[4] },
                Numbers = "546"
            },
            new Musician
            {
                Name = "Black Sabbath",
                Genres = new List<Genre> { genres[12] },
                Recording = "Paranoid",
                Occasions = new List<Occasion> { occasions[4] },
                Numbers = "784, 784, 692, 766, 225"
            },
            new Musician
            {
                Name = "James Brown",
                Genres = new List<Genre> { genres[11] },
                Recording = "Live at the Apollo (1962)",
                Occasions = new List<Occasion> { occasions[4] },
                Numbers = "463"
            },
            new Musician
            {
                Name = "James Brown",
                Genres = new List<Genre> { genres[11] },
                Recording = "Soul Pride: The Instrumentals, 1960-1969",
                Occasions = new List<Occasion> { occasions[4] },
                Numbers = "463, 591"
            },
            new Musician
            {
                Name = "Clifton Chenier",
                Genres = new List<Genre> { genres[0] },
                Recording = "Bogalusa Boogie",
                Occasions = new List<Occasion> { occasions[4], occasions[1] },
                Numbers = "317"
            },
            new Musician
            {
                Name = "Chic",
                Genres = new List<Genre> { genres[11] },
                Recording = "C'est Chic",
                Occasions = new List<Occasion> { occasions[4], occasions[1] },
                Numbers = "371, 8, 362, 187, 463, 784, 142, 528, 169, 932, 591, 216, 261, 775"
            },
            new Musician
            {
                Name = "Sam Cooke",
                Genres = new List<Genre> { genres[11] },
                Recording = "Live at the Harlem Square Club",
                Occasions = new List<Occasion> { occasions[4] },
                Numbers = "766"
            },
            new Musician
            {
                Name = "I. K. Dairo and His Blue Spots",
                Genres = new List<Genre> { genres[14], genres[53] },
                Recording = "Definitie Dairo",
                Occasions = new List<Occasion> { occasions[4] },
                Numbers = "7"
            },
            new Musician
            {
                Name = "De La Soul",
                Genres = new List<Genre> { genres[6] },
                Recording = "Three Feet High and Rising",
                Occasions = new List<Occasion> { occasions[4] },
                Numbers = "427, 546, 344"
            },
            new Musician
            {
                Name = "Manu Dibango",
                Genres = new List<Genre> { genres[14], genres[22] },
                Recording = "'Soul Makossa'",
                Occasions = new List<Occasion> { occasions[4] },
                Numbers = "472"
            },
            new Musician
            {
                Name = "Digital Underground",
                Genres = new List<Genre> { genres[6] },
                Recording = "Sex Packets",
                Occasions = new List<Occasion> { occasions[4], occasions[1] },
                Numbers = "124, 279, 692, 813, 427"
            },
            new Musician
            {
                Name = "DJ Shadow",
                Genres = new List<Genre> { genres[3] },
                Recording = "Endtroducing",
                Occasions = new List<Occasion> { occasions[4] },
                Numbers = "142"
            },
            new Musician
            {
                Name = "Earth Wind, Fire",
                Genres = new List<Genre> { genres[11] },
                Recording = "All 'n' All",
                Occasions = new List<Occasion> { occasions[4] },
                Numbers = "519, 454, 537, 436, 445, 546"
            },
            new Musician
            {
                Name = "Duke Ellington and His Orchestra",
                Genres = new List<Genre> { genres[7] },
                Recording = "Never No Lament: The Blanton-Webster Band",
                Occasions = new List<Occasion> { occasions[4] },
                Numbers = "297"
            },
            new Musician
            {
                Name = "Estrellas de Areito",
                Genres = new List<Genre> { genres[14], genres[28] },
                Recording = "Los Heroes",
                Occasions = new List<Occasion> { occasions[4] },
                Numbers = "923, 537, 932, 297, 665, 748, 757"
            },
            new Musician
            {
                Name = "Fatboy Slim",
                Genres = new List<Genre> { genres[3] },
                Recording = "Better Living Through Chemistry",
                Occasions = new List<Occasion> { occasions[4] },
                Numbers = "133"
            },
            new Musician
            {
                Name = "The Four Tops",
                Genres = new List<Genre> { genres[11] },
                Recording = "Anthology",
                Occasions = new List<Occasion> { occasions[4] },
                Numbers = "142, 216, 472, 822, 463"
            },
            new Musician
            {
                Name = "Franco and the TPOK Jazz",
                Genres = new List<Genre> { genres[14], genres[27] },
                Recording = "The Rough Guide to Franco",
                Occasions = new List<Occasion> { occasions[4] },
                Numbers = "876, 519, 813"
            },
            new Musician
            {
                Name = "Funkadelic",
                Genres = new List<Genre> { genres[11] },
                Recording = "Maggot Brain",
                Occasions = new List<Occasion> { occasions[4], occasions[1] },
                Numbers = "564"
            },
            new Musician
            {
                Name = "Dizzy Gillespie and His Orchestra",
                Genres = new List<Genre> { genres[7] },
                Recording = "Afro",
                Occasions = new List<Occasion> { occasions[4] },
                Numbers = "234"
            },
            new Musician
            {
                Name = "El Gran Combo de Puerto Rico",
                Genres = new List<Genre> { genres[14], genres[54] },
                Recording = "30 Aniversario",
                Occasions = new List<Occasion> { occasions[4] },
                Numbers = "252, 674, 225, 454"
            },
            new Musician
            {
                Name = "Juan Luis Guerra y 440",
                Genres = new List<Genre> { genres[14], genres[29] },
                Recording = "Fogaraté!",
                Occasions = new List<Occasion> { occasions[4], occasions[1] },
                Numbers = "748"
            },
            new Musician
            {
                Name = "Guns N' Roses",
                Genres = new List<Genre> { genres[12] },
                Recording = "Appetite for Destruction",
                Occasions = new List<Occasion> { occasions[4] },
                Numbers = "225, 959, 867, 142, 784, 775, 187, 712, 353, 234"
            },
            new Musician
            {
                Name = "Herbie Hancock",
                Genres = new List<Genre> { genres[7] },
                Recording = "Head Hunters",
                Occasions = new List<Occasion> { occasions[4] },
                Numbers = "638"
            },
            new Musician
            {
                Name = "Isaac Hayes",
                Genres = new List<Genre> { genres[11] },
                Recording = "Shaft",
                Occasions = new List<Occasion> { occasions[4] },
                Numbers = "427"
            },
            new Musician
            {
                Name = "Ilê Aiyê",
                Genres = new List<Genre> { genres[14], genres[20] },
                Recording = "Canto Negro",
                Occasions = new List<Occasion> { occasions[4] },
                Numbers = ""
            },
            new Musician
            {
                Name = "The Isley Brothers",
                Genres = new List<Genre> { genres[11] },
                Recording = "The Heat Is On",
                Occasions = new List<Occasion> { occasions[4], occasions[1] },
                Numbers = "582, 344, 775, 941, 472"
            },
            new Musician
            {
                Name = "Flaco Jiménez",
                Genres = new List<Genre> { genres[14], genres[50] },
                Recording = "Squeeze Box King",
                Occasions = new List<Occasion> { occasions[4] },
                Numbers = "775"
            },
            new Musician
            {
                Name = "Joi",
                Genres = new List<Genre> { genres[3] },
                Recording = "We Are Three",
                Occasions = new List<Occasion> { occasions[4], occasions[9] },
                Numbers = "537, 822"
            },
            new Musician
            {
                Name = "Louis Jordan",
                Genres = new List<Genre> { genres[11] },
                Recording = "The Best of Louis Jordan",
                Occasions = new List<Occasion> { occasions[4], occasions[1] },
                Numbers = "261"
            },
            new Musician
            {
                Name = "Pepe Kalle",
                Genres = new List<Genre> { genres[14], genres[27] },
                Recording = "Gigantafrique!",
                Occasions = new List<Occasion> { occasions[4] },
                Numbers = "481"
            },
            new Musician
            {
                Name = "Khaled",
                Genres = new List<Genre> { genres[14], genres[15] },
                Recording = "N'ssi, N'ssi",
                Occasions = new List<Occasion> { occasions[4], occasions[1] },
                Numbers = "481"
            },
            new Musician
            {
                Name = "Konono No. 1",
                Genres = new List<Genre> { genres[14], genres[27] },
                Recording = "Congotronics",
                Occasions = new List<Occasion> { occasions[4] },
                Numbers = ""
            },
            new Musician
            {
                Name = "Fela Kuti and the Afrika 70",
                Genres = new List<Genre> { genres[14], genres[53] },
                Recording = "Confusion/Gentleman",
                Occasions = new List<Occasion> { occasions[4] },
                Numbers = "831"
            },
            new Musician
            {
                Name = "Héctor Lavoe",
                Genres = new List<Genre> { genres[14], genres[53] },
                Recording = "De ti depende",
                Occasions = new List<Occasion> { occasions[4] },
                Numbers = "977"
            },
            new Musician
            {
                Name = "Little Richard",
                Genres = new List<Genre> { genres[11] },
                Recording = "The Georgia Peach",
                Occasions = new List<Occasion> { occasions[4], occasions[1] },
                Numbers = "528"
            },
            new Musician
            {
                Name = "Israel 'Cachao' López y Su Ritmo Caliente",
                Genres = new List<Genre> { genres[14], genres[28] },
                Recording = "Descargas: Cuban Jam Sessions in Miniature",
                Occasions = new List<Occasion> { occasions[4] },
                Numbers = "115"
            },
            new Musician
            {
                Name = "Madonna",
                Genres = new List<Genre> { genres[10] },
                Recording = "Ray of Light",
                Occasions = new List<Occasion> { occasions[4] },
                Numbers = "683"
            },
            new Musician
            {
                Name = "Mahlathini and the Mahotella Queens",
                Genres = new List<Genre> { genres[14], genres[60] },
                Recording = "Paris/Soweto",
                Occasions = new List<Occasion> { occasions[4], occasions[1] },
                Numbers = "8, 4, 169, 335"
            },
            new Musician
            {
                Name = "Martha and the Vandellas",
                Genres = new List<Genre> { genres[11] },
                Recording = "'Dancing in the Street'",
                Occasions = new List<Occasion> { occasions[4], occasions[1] },
                Numbers = "317, 389, 436, 564, 766, 243, 151"
            },
            new Musician
            {
                Name = "The Meters",
                Genres = new List<Genre> { genres[11] },
                Recording = "Look-Ka Py Py",
                Occasions = new List<Occasion> { occasions[4], occasions[1] },
                Numbers = "813, 914, 775, 941"
            },
            new Musician
            {
                Name = "Mighty Sparrow and Lord Kitchener",
                Genres = new List<Genre> { genres[14], genres[63] },
                Recording = "Sixteen Carnival Hits",
                Occasions = new List<Occasion> { occasions[4], occasions[1] },
                Numbers = "261, 638"
            },
            new Musician
            {
                Name = "Hugh Mundell",
                Genres = new List<Genre> { genres[14], genres[42] },
                Recording = "Africa Must Be Free by 1983",
                Occasions = new List<Occasion> { occasions[4] },
                Numbers = "279"
            },
            new Musician
            {
                Name = "Los Muñequitos de Matanzas",
                Genres = new List<Genre> { genres[14], genres[28] },
                Recording = "Ito Iban Echu: Sacred Yoruba Music of Cuba",
                Occasions = new List<Occasion> { occasions[4] },
                Numbers = ""
            },
            new Musician
            {
                Name = "Nas",
                Genres = new List<Genre> { genres[6] },
                Recording = "Illmatic",
                Occasions = new List<Occasion> { occasions[4] },
                Numbers = "977"
            },
            new Musician
            {
                Name = "Youssou N'Dour",
                Genres = new List<Genre> { genres[14], genres[59] },
                Recording = "Immigrés",
                Occasions = new List<Occasion> { occasions[4] },
                Numbers = "546"
            },
            new Musician
            {
                Name = "No Doubt",
                Genres = new List<Genre> { genres[10], genres[12] },
                Recording = "Rock Steady",
                Occasions = new List<Occasion> { occasions[4], occasions[1] },
                Numbers = "418, 638, 389, 427, 611"
            },
            new Musician
            {
                Name = "The O'Jays",
                Genres = new List<Genre> { genres[11] },
                Recording = "Back Stabbers",
                Occasions = new List<Occasion> { occasions[4] },
                Numbers = "445, 389, 591, 519, 6"
            },
            new Musician
            {
                Name = "Orchestra Baobab",
                Genres = new List<Genre> { genres[14], genres[59] },
                Recording = "Pirates Choice",
                Occasions = new List<Occasion> { occasions[4] },
                Numbers = "9, 941"
            },
            new Musician
            {
                Name = "Outkast",
                Genres = new List<Genre> { genres[11] },
                Recording = "Stankonia",
                Occasions = new List<Occasion> { occasions[4], occasions[1] },
                Numbers = "757, 894"
            },
            new Musician
            {
                Name = "Eddie Palmieri",
                Genres = new List<Genre> { genres[14], genres[45] },
                Recording = "La perfecta",
                Occasions = new List<Occasion> { occasions[4] },
                Numbers = "178"
            },
            new Musician
            {
                Name = "Prince",
                Genres = new List<Genre> { genres[11], genres[12] },
                Recording = "Sign o' the Times",
                Occasions = new List<Occasion> { occasions[4], occasions[1] },
                Numbers = "611"
            },
            new Musician
            {
                Name = "Professor Longhair",
                Genres = new List<Genre> { genres[0], genres[11] },
                Recording = "New Orleans Piano",
                Occasions = new List<Occasion> { occasions[4] },
                Numbers = "178"
            },
            new Musician
            {
                Name = "Tito Puente and His Orchestra",
                Genres = new List<Genre> { genres[14], genres[45] },
                Recording = "Dance Mania!",
                Occasions = new List<Occasion> { occasions[4], occasions[1] },
                Numbers = "591"
            },
            new Musician
            {
                Name = "Ismael Rivera con Kako y Su Orquesta",
                Genres = new List<Genre> { genres[14], genres[54] },
                Recording = "Lo último en la avenida",
                Occasions = new List<Occasion> { occasions[4] },
                Numbers = "674, 142"
            },
            new Musician
            {
                Name = "Tabu Ley Rochereau",
                Genres = new List<Genre> { genres[14], genres[27] },
                Recording = "The Voice of Lightness: Congo Classics, 1961-1977",
                Occasions = new List<Occasion> { occasions[4] },
                Numbers = "656"
            },
            new Musician
            {
                Name = "Arsenio Rodríguez y Su Conjunto",
                Genres = new List<Genre> { genres[14], genres[28] },
                Recording = "Montuneando",
                Occasions = new List<Occasion> { occasions[4] },
                Numbers = "858"
            },
            new Musician
            {
                Name = "Mongo Santamaria",
                Genres = new List<Genre> { genres[14], genres[28] },
                Recording = "Drums and Chants",
                Occasions = new List<Occasion> { occasions[4] },
                Numbers = "297"
            },
            new Musician
            {
                Name = "Sasha",
                Genres = new List<Genre> { genres[3] },
                Recording = "Global Underground 013: Ibiza",
                Occasions = new List<Occasion> { occasions[4], occasions[9] },
                Numbers = "427"
            },
            new Musician
            {
                Name = "Chico Science and Nação Zumbi",
                Genres = new List<Genre> { genres[14], genres[20] },
                Recording = "Da lama ao caos",
                Occasions = new List<Occasion> { occasions[4] },
                Numbers = "766, 216, 656, 775, 7"
            },
            new Musician
            {
                Name = "Shakira",
                Genres = new List<Genre> { genres[14], genres[26] },
                Recording = "¿Dónde están los ladrones?",
                Occasions = new List<Occasion> { occasions[4] },
                Numbers = "638"
            },
            new Musician
            {
                Name = "The Soul Brothers",
                Genres = new List<Genre> { genres[14], genres[60] },
                Recording = "The Rough Guide to the Soul Brothers",
                Occasions = new List<Occasion> { occasions[4] },
                Numbers = ""
            },
            new Musician
            {
                Name = "The Stone Roses",
                Genres = new List<Genre> { genres[12] },
                Recording = "The Stone Roses",
                Occasions = new List<Occasion> { occasions[4] },
                Numbers = "187, 225, 225, 932, 297, 941, 3"
            },
            new Musician
            {
                Name = "Talking Heads",
                Genres = new List<Genre> { genres[12] },
                Recording = "Remain in Light",
                Occasions = new List<Occasion> { occasions[4], occasions[1] },
                Numbers = "326, 454, 528, 656"
            },
            new Musician
            {
                Name = "Taraf de Haïdouks",
                Genres = new List<Genre> { genres[14], genres[57] },
                Recording = "Taraf de Haïdouks",
                Occasions = new List<Occasion> { occasions[4] },
                Numbers = "133, 959, 4"
            },
            new Musician
            {
                Name = "Touré Kunda",
                Genres = new List<Genre> { genres[14], genres[59] },
                Recording = "Paris-Ziguinchor Live",
                Occasions = new List<Occasion> { occasions[4] },
                Numbers = "5, 5, 959"
            },
            new Musician
            {
                Name = "Ike and Tina Turner",
                Genres = new List<Genre> { genres[11] },
                Recording = "Proud Mary",
                Occasions = new List<Occasion> { occasions[4], occasions[1] },
                Numbers = "665, 784"
            },
            new Musician
            {
                Name = "Various Artists",
                Genres = new List<Genre> { genres[14], genres[60] },
                Recording = "The Indestructible Beat of Soweto",
                Occasions = new List<Occasion> { occasions[4] },
                Numbers = ""
            },
            new Musician
            {
                Name = "Various Artists",
                Genres = new List<Genre> { genres[10] },
                Recording = "Saturday Night Fever",
                Occasions = new List<Occasion> { occasions[4], occasions[1] },
                Numbers = ""
            },
            new Musician
            {
                Name = "Various Artists",
                Genres = new List<Genre> { genres[14], genres[42] },
                Recording = "Ska Bonanza: The Studio One Ska Years",
                Occasions = new List<Occasion> { occasions[4] },
                Numbers = ""
            },
            new Musician
            {
                Name = "Various Artists",
                Genres = new List<Genre> { genres[11] },
                Recording = "A Tom Moulton Mix",
                Occasions = new List<Occasion> { occasions[4], occasions[1] },
                Numbers = ""
            },
            new Musician
            {
                Name = "Dimi Mint Abba and Khalifa Ould Eide",
                Genres = new List<Genre> { genres[14], genres[49] },
                Recording = "Moorish Music from Mauritania",
                Occasions = new List<Occasion> { occasions[2] },
                Numbers = "647"
            },
            new Musician
            {
                Name = "John Adams",
                Genres = new List<Genre> { genres[1] },
                Recording = "Harmonium",
                Occasions = new List<Occasion> { occasions[2] },
                Numbers = "822"
            },
            new Musician
            {
                Name = "Mahmoud Ahmed",
                Genres = new List<Genre> { genres[14], genres[31] },
                Recording = "éthiopiques, Vol. 7: Erè Mèla Mèla",
                Occasions = new List<Occasion> { occasions[2] },
                Numbers = "582"
            },
            new Musician
            {
                Name = "Aphex Twin",
                Genres = new List<Genre> { genres[3] },
                Recording = "Selected Ambient Works",
                Occasions = new List<Occasion> { occasions[2], occasions[9] },
                Numbers = "252"
            },
            new Musician
            {
                Name = "J. S. Bach",
                Genres = new List<Genre> { genres[1] },
                Recording = "The Well-Tempered Clavier, Book 1",
                Occasions = new List<Occasion> { occasions[2] },
                Numbers = "941"
            },
            new Musician
            {
                Name = "J. S. Bach",
                Genres = new List<Genre> { genres[1] },
                Recording = "Mass in B Minor",
                Occasions = new List<Occasion> { occasions[2] },
                Numbers = "941"
            },
            new Musician
            {
                Name = "The Band",
                Genres = new List<Genre> { genres[12] },
                Recording = "The Band",
                Occasions = new List<Occasion> { occasions[2], occasions[9] },
                Numbers = "344, 629, 995, 344, 317, 472, 481, 959"
            },
            new Musician
            {
                Name = "Samuel Barber",
                Genres = new List<Genre> { genres[1] },
                Recording = "Adagio for Strings",
                Occasions = new List<Occasion> { occasions[2] },
                Numbers = "941"
            },
            new Musician
            {
                Name = "Béla Bartók",
                Genres = new List<Genre> { genres[1] },
                Recording = "Six String Quartets",
                Occasions = new List<Occasion> { occasions[2] },
                Numbers = "216"
            },
            new Musician
            {
                Name = "Waldemar Bastos",
                Genres = new List<Genre> { genres[14], genres[17] },
                Recording = "Pretaluz",
                Occasions = new List<Occasion> { occasions[2] },
                Numbers = "216"
            },
            new Musician
            {
                Name = "Ludwig van Beethoven",
                Genres = new List<Genre> { genres[1] },
                Recording = "Missa Solemnis",
                Occasions = new List<Occasion> { occasions[2] },
                Numbers = "519"
            },
            new Musician
            {
                Name = "Benedictine Monks of the Abbey of St. Maurice and St. Maur",
                Genres = new List<Genre> { genres[1] },
                Recording = "Clervaux, Salve Regina: Gregorian Chant",
                Occasions = new List<Occasion> { occasions[2] },
                Numbers = ""
            },
            new Musician
            {
                Name = "Vishwa Mohan Bhatt and Ry Cooder",
                Genres = new List<Genre> { genres[14], genres[39] },
                Recording = "A Meeting by the River",
                Occasions = new List<Occasion> { occasions[2] },
                Numbers = "564, 813"
            },
            new Musician
            {
                Name = "Paul Bley",
                Genres = new List<Genre> { genres[7] },
                Recording = "Fragments",
                Occasions = new List<Occasion> { occasions[2] },
                Numbers = "528"
            },
            new Musician
            {
                Name = "The Blind Boys of Alabama",
                Genres = new List<Genre> { genres[5] },
                Recording = "Spirit of the Century",
                Occasions = new List<Occasion> { occasions[2] },
                Numbers = "822, 398, 739, 858, 279"
            },
            new Musician
            {
                Name = "Bonnie 'Prince' Billy",
                Genres = new List<Genre> { genres[12] },
                Recording = "I See a Darkness",
                Occasions = new List<Occasion> { occasions[2] },
                Numbers = "463"
            },
            new Musician
            {
                Name = "Boukman Eksperyans",
                Genres = new List<Genre> { genres[14], genres[35] },
                Recording = "Kalfou Danjere",
                Occasions = new List<Occasion> { occasions[2], occasions[1] },
                Numbers = "822, 849, 279"
            },
            new Musician
            {
                Name = "Bright Eyes",
                Genres = new List<Genre> { genres[12] },
                Recording = "I'm Wide Awake, It's Morning",
                Occasions = new List<Occasion> { occasions[2] },
                Numbers = "885, 225, 472"
            },
            new Musician
            {
                Name = "Jackson Browne",
                Genres = new List<Genre> { genres[12] },
                Recording = "Late for the Sky",
                Occasions = new List<Occasion> { occasions[2] },
                Numbers = "793"
            },
            new Musician
            {
                Name = "The Bulgarian Women's National Radio and Television Chorus",
                Genres = new List<Genre> { genres[14], genres[21] },
                Recording = "Le mystère des voix bulgares",
                Occasions = new List<Occasion> { occasions[2] },
                Numbers = ""
            },
            new Musician
            {
                Name = "Neko Case",
                Genres = new List<Genre> { genres[12] },
                Recording = "Fox Confessor Brings the Flood",
                Occasions = new List<Occasion> { occasions[2] },
                Numbers = "371"
            },
            new Musician
            {
                Name = "Johnny Cash",
                Genres = new List<Genre> { genres[2] },
                Recording = "American Recordings",
                Occasions = new List<Occasion> { occasions[2] },
                Numbers = "528"
            },
            new Musician
            {
                Name = "Tracy Chapman",
                Genres = new List<Genre> { genres[12] },
                Recording = "Tracy Chapman",
                Occasions = new List<Occasion> { occasions[2] },
                Numbers = "941"
            },
            new Musician
            {
                Name = "Hariprasad Chaurasia",
                Genres = new List<Genre> { genres[14], genres[39] },
                Recording = "Raga Darbari Kanada",
                Occasions = new List<Occasion> { occasions[2] },
                Numbers = "876"
            },
            new Musician
            {
                Name = "Sonny Chillingworth",
                Genres = new List<Genre> { genres[14], genres[36] },
                Recording = "Endlessly",
                Occasions = new List<Occasion> { occasions[2] },
                Numbers = "564"
            },
            new Musician
            {
                Name = "Frédéric Chopin",
                Genres = new List<Genre> { genres[1] },
                Recording = "Nocturnes",
                Occasions = new List<Occasion> { occasions[2] },
                Numbers = "187"
            },
            new Musician
            {
                Name = "Van Cliburn",
                Genres = new List<Genre> { genres[1] },
                Recording = "Rachmaninoff: Piano Concerto No. 3; Prokofiev: Piano Concerto No. 3",
                Occasions = new List<Occasion> { occasions[2] },
                Numbers = "398, 178"
            },
            new Musician
            {
                Name = "Leonard Cohen",
                Genres = new List<Genre> { genres[12] },
                Recording = "Songs of Leonard Cohen",
                Occasions = new List<Occasion> { occasions[2] },
                Numbers = "371"
            },
            new Musician
            {
                Name = "John Coltrane",
                Genres = new List<Genre> { genres[7] },
                Recording = "A Love Supreme",
                Occasions = new List<Occasion> { occasions[2] },
                Numbers = "243"
            },
            new Musician
            {
                Name = "Karen Dalton",
                Genres = new List<Genre> { genres[4] },
                Recording = "It's So Hard to Tell Who's Going to Love You the Best",
                Occasions = new List<Occasion> { occasions[2] },
                Numbers = "995"
            },
            new Musician
            {
                Name = "Miles Davis",
                Genres = new List<Genre> { genres[7] },
                Recording = "Kind of Blue",
                Occasions = new List<Occasion> { occasions[2] },
                Numbers = "288"
            },
            new Musician
            {
                Name = "Miles Davis Quintet",
                Genres = new List<Genre> { genres[7] },
                Recording = "In a Silent Way",
                Occasions = new List<Occasion> { occasions[2] },
                Numbers = "582, 932, 297, 288, 178, 564, 638, 427, 216, 546, 739"
            },
            new Musician
            {
                Name = "De Danann with Mary Black",
                Genres = new List<Genre> { genres[14], genres[24] },
                Recording = "Song for Ireland",
                Occasions = new List<Occasion> { occasions[2] },
                Numbers = "923, 8, 288, 739, 243, 445, 353, 968, 142, 674, 288"
            },
            new Musician
            {
                Name = "Nick Drake",
                Genres = new List<Genre> { genres[12], genres[4] },
                Recording = "Five Leaves Left",
                Occasions = new List<Occasion> { occasions[2] },
                Numbers = "748"
            },
            new Musician
            {
                Name = "Bob Dylan",
                Genres = new List<Genre> { genres[12] },
                Recording = "Blood on the Tracks",
                Occasions = new List<Occasion> { occasions[2] },
                Numbers = "582"
            },
            new Musician
            {
                Name = "Brian Eno",
                Genres = new List<Genre> { genres[3] },
                Recording = "Ambient 1: Music for Airports",
                Occasions = new List<Occasion> { occasions[2] },
                Numbers = "757"
            },
            new Musician
            {
                Name = "Alejandro Escovedo",
                Genres = new List<Genre> { genres[12] },
                Recording = "Gravity",
                Occasions = new List<Occasion> { occasions[2] },
                Numbers = "591"
            },
            new Musician
            {
                Name = "Bill Evans Trio",
                Genres = new List<Genre> { genres[7] },
                Recording = "Sunday at the Village Vanguard/Waltz for Debby",
                Occasions = new List<Occasion> { occasions[2] },
                Numbers = "858, 178, 647"
            },
            new Musician
            {
                Name = "Fairport Convention",
                Genres = new List<Genre> { genres[4] },
                Recording = "Liege and Lief",
                Occasions = new List<Occasion> { occasions[2] },
                Numbers = "537, 831, 344, 813, 849, 647, 297, 683, 656, 914, 932, 519, 775, 968, 766"
            },
            new Musician
            {
                Name = "Roberta Flack",
                Genres = new List<Genre> { genres[11] },
                Recording = "'The First Time Ever I Saw Your Face'",
                Occasions = new List<Occasion> { occasions[2] },
                Numbers = "959"
            },
            new Musician
            {
                Name = "Jan Garbarek and Ralph Towner",
                Genres = new List<Genre> { genres[7] },
                Recording = "Dis",
                Occasions = new List<Occasion> { occasions[2] },
                Numbers = "822, 656"
            },
            new Musician
            {
                Name = "Djivan Gasparyan",
                Genres = new List<Genre> { genres[14], genres[19] },
                Recording = "I Will Not Be Sad in This World",
                Occasions = new List<Occasion> { occasions[2] },
                Numbers = "968"
            },
            new Musician
            {
                Name = "Henryk Górecki",
                Genres = new List<Genre> { genres[1] },
                Recording = "Symphony No. 3, Op. 26: Symphony of Sorrowful Songs",
                Occasions = new List<Occasion> { occasions[2] },
                Numbers = "481"
            },
            new Musician
            {
                Name = "Gothic Voices with Emma Kirkby",
                Genres = new List<Genre> { genres[1] },
                Recording = "A Feather on the Breath of God: Sequences and Hymns by Abbess Hildegard of Bingen",
                Occasions = new List<Occasion> { occasions[2] },
                Numbers = "656, 335, 216, 813, 133, 225"
            },
            new Musician
            {
                Name = "Charlie Haden",
                Genres = new List<Genre> { genres[7] },
                Recording = "Nocturne",
                Occasions = new List<Occasion> { occasions[2] },
                Numbers = "995"
            },
            new Musician
            {
                Name = "Herbie Hancock",
                Genres = new List<Genre> { genres[7] },
                Recording = "Maiden Voyage",
                Occasions = new List<Occasion> { occasions[2] },
                Numbers = "638"
            },
            new Musician
            {
                Name = "George Harrison",
                Genres = new List<Genre> { genres[12] },
                Recording = "All Things Must Pass",
                Occasions = new List<Occasion> { occasions[2] },
                Numbers = "353"
            },
            new Musician
            {
                Name = "Ofra Haza",
                Genres = new List<Genre> { genres[14], genres[51] },
                Recording = "Fifty Gates of Wisdom: Yemenite Songs",
                Occasions = new List<Occasion> { occasions[2] },
                Numbers = "784"
            },
            new Musician
            {
                Name = "Andrew Hill",
                Genres = new List<Genre> { genres[7] },
                Recording = "Point of Departure",
                Occasions = new List<Occasion> { occasions[2] },
                Numbers = "611"
            },
            new Musician
            {
                Name = "Lauryn Hill",
                Genres = new List<Genre> { genres[6], genres[11] },
                Recording = "The Miseducation of Lauryn Hill",
                Occasions = new List<Occasion> { occasions[2] },
                Numbers = "757"
            },
            new Musician
            {
                Name = "Shirley Horn",
                Genres = new List<Genre> { genres[7], genres[13] },
                Recording = "Close Enough for Love",
                Occasions = new List<Occasion> { occasions[2], occasions[0] },
                Numbers = "335"
            },
            new Musician
            {
                Name = "Howlin' Wolf",
                Genres = new List<Genre> { genres[0] },
                Recording = "Moanin' in the Moonlight",
                Occasions = new List<Occasion> { occasions[2] },
                Numbers = "914"
            },
            new Musician
            {
                Name = "Leoš Janáček",
                Genres = new List<Genre> { genres[1] },
                Recording = "Piano Works",
                Occasions = new List<Occasion> { occasions[2] },
                Numbers = "279"
            },
            new Musician
            {
                Name = "Keith Jarrett",
                Genres = new List<Genre> { genres[7] },
                Recording = "The Köln Concert",
                Occasions = new List<Occasion> { occasions[2] },
                Numbers = "151"
            },
            new Musician
            {
                Name = "Rickie Lee Jones",
                Genres = new List<Genre> { genres[12] },
                Recording = "Pirates",
                Occasions = new List<Occasion> { occasions[2] },
                Numbers = "187"
            },
            new Musician
            {
                Name = "Josquin des Prez",
                Genres = new List<Genre> { genres[1] },
                Recording = "Missa pange lingua, Motets",
                Occasions = new List<Occasion> { occasions[2] },
                Numbers = ""
            },
            new Musician
            {
                Name = "Oum Kalthoum",
                Genres = new List<Genre> { genres[14], genres[30] },
                Recording = "Legend of Arab Music",
                Occasions = new List<Occasion> { occasions[2] },
                Numbers = "638"
            },
            new Musician
            {
                Name = "Salif Keita",
                Genres = new List<Genre> { genres[14], genres[48] },
                Recording = "Moffou",
                Occasions = new List<Occasion> { occasions[2] },
                Numbers = "683, 638"
            },
            new Musician
            {
                Name = "Nusrat Fateh Ali Khan and Party",
                Genres = new List<Genre> { genres[14], genres[54] },
                Recording = "In Concert in Paris",
                Occasions = new List<Occasion> { occasions[2] },
                Numbers = "793"
            },
            new Musician
            {
                Name = "Carole King",
                Genres = new List<Genre> { genres[10] },
                Recording = "Tapestry",
                Occasions = new List<Occasion> { occasions[2] },
                Numbers = "481"
            },
            new Musician
            {
                Name = "Alison Krauss",
                Genres = new List<Genre> { genres[2] },
                Recording = "I've Got That Old Feeling",
                Occasions = new List<Occasion> { occasions[2] },
                Numbers = "261"
            },
            new Musician
            {
                Name = "Dinu Lipatti",
                Genres = new List<Genre> { genres[1] },
                Recording = "Besançon Festival, 1950 Madredeus, O espírito da paz",
                Occasions = new List<Occasion> { occasions[2] },
                Numbers = "216"
            },
            new Musician
            {
                Name = "Gustav Mahler",
                Genres = new List<Genre> { genres[1] },
                Recording = "Das Lied von der Erde",
                Occasions = new List<Occasion> { occasions[2] },
                Numbers = "573"
            },
            new Musician
            {
                Name = "John Martyn",
                Genres = new List<Genre> { genres[4], genres[12] },
                Recording = "Solid Air",
                Occasions = new List<Occasion> { occasions[2] },
                Numbers = "712"
            },
            new Musician
            {
                Name = "Kate and Anna McGarrigle",
                Genres = new List<Genre> { genres[4], genres[12] },
                Recording = "Kate and Anna McGarrigle",
                Occasions = new List<Occasion> { occasions[2] },
                Numbers = "959, 225"
            },
            new Musician
            {
                Name = "Loreena McKennitt",
                Genres = new List<Genre> { genres[14], genres[24] },
                Recording = "The Visit",
                Occasions = new List<Occasion> { occasions[2] },
                Numbers = "784"
            },
            new Musician
            {
                Name = "Brad Mehldau",
                Genres = new List<Genre> { genres[7] },
                Recording = "Largo",
                Occasions = new List<Occasion> { occasions[2] },
                Numbers = "389"
            },
            new Musician
            {
                Name = "Olivier Messiaen",
                Genres = new List<Genre> { genres[1] },
                Recording = "Vingt regards sur l'enfant-Jésus",
                Occasions = new List<Occasion> { occasions[2] },
                Numbers = "216"
            },
            new Musician
            {
                Name = "Tete Montoliu",
                Genres = new List<Genre> { genres[7] },
                Recording = "Solo Piano",
                Occasions = new List<Occasion> { occasions[2] },
                Numbers = "472"
            },
            new Musician
            {
                Name = "Van Morrison",
                Genres = new List<Genre> { genres[12] },
                Recording = "Astral Weeks",
                Occasions = new List<Occasion> { occasions[2] },
                Numbers = "124"
            },
            new Musician
            {
                Name = "Modest Mussorgsky",
                Genres = new List<Genre> { genres[1] },
                Recording = "Sunless, The Nursery, Songs and Dances of Death and Other Songs",
                Occasions = new List<Occasion> { occasions[2] },
                Numbers = "813"
            },
            new Musician
            {
                Name = "Randy Newman",
                Genres = new List<Genre> { genres[12] },
                Recording = "Twelve Songs",
                Occasions = new List<Occasion> { occasions[2] },
                Numbers = "353"
            },
            new Musician
            {
                Name = "Beth Orton",
                Genres = new List<Genre> { genres[12] },
                Recording = "Central Reservation",
                Occasions = new List<Occasion> { occasions[2] },
                Numbers = "344"
            },
            new Musician
            {
                Name = "Parisa",
                Genres = new List<Genre> { genres[14], genres[41] },
                Recording = "Baz Amadam: Parisa at Royal Festival Hall",
                Occasions = new List<Occasion> { occasions[2] },
                Numbers = "519"
            },
            new Musician
            {
                Name = "Gram Parsons",
                Genres = new List<Genre> { genres[12] },
                Recording = "GP/Grievous Angel",
                Occasions = new List<Occasion> { occasions[2] },
                Numbers = "968"
            },
            new Musician
            {
                Name = "Arvo Pärt",
                Genres = new List<Genre> { genres[1] },
                Recording = "Tabula Rasa",
                Occasions = new List<Occasion> { occasions[2] },
                Numbers = "243"
            },
            new Musician
            {
                Name = "Sam Phillips",
                Genres = new List<Genre> { genres[12] },
                Recording = "Fan Dance",
                Occasions = new List<Occasion> { occasions[2] },
                Numbers = "647"
            },
            new Musician
            {
                Name = "Astor Piazzolla",
                Genres = new List<Genre> { genres[14], genres[18] },
                Recording = "Tango: Zero Hour",
                Occasions = new List<Occasion> { occasions[2] },
                Numbers = "775"
            },
            new Musician
            {
                Name = "Portishead",
                Genres = new List<Genre> { genres[12] },
                Recording = "Dummy",
                Occasions = new List<Occasion> { occasions[2], occasions[9] },
                Numbers = "941, 216, 766"
            },
            new Musician
            {
                Name = "Sergey Rachmaninoff",
                Genres = new List<Genre> { genres[1] },
                Recording = "All-Night Vigil, op. 37, 6526",
                Occasions = new List<Occasion> { occasions[2] },
                Numbers = "178"
            },
            new Musician
            {
                Name = "Steve Reich",
                Genres = new List<Genre> { genres[1] },
                Recording = "Music for 18 Musicians",
                Occasions = new List<Occasion> { occasions[2], occasions[9] },
                Numbers = "115"
            },
            new Musician
            {
                Name = "Kaija Saariaho",
                Genres = new List<Genre> { genres[9] },
                Recording = "L'Amour de loin",
                Occasions = new List<Occasion> { occasions[2] },
                Numbers = "362"
            },
            new Musician
            {
                Name = "Dino Saluzzi",
                Genres = new List<Genre> { genres[7] },
                Recording = "Cité de la musique",
                Occasions = new List<Occasion> { occasions[2] },
                Numbers = "288"
            },
            new Musician
            {
                Name = "Oumou Sangare",
                Genres = new List<Genre> { genres[14], genres[48] },
                Recording = "Ko sira",
                Occasions = new List<Occasion> { occasions[2] },
                Numbers = "528"
            },
            new Musician
            {
                Name = "Erik Satie",
                Genres = new List<Genre> { genres[1] },
                Recording = "Gymnopédies/Gnossiennes",
                Occasions = new List<Occasion> { occasions[2] },
                Numbers = "885"
            },
            new Musician
            {
                Name = "Franz Schubert",
                Genres = new List<Genre> { genres[1] },
                Recording = "B-Flat Piano Sonata",
                Occasions = new List<Occasion> { occasions[2] },
                Numbers = "638"
            },
            new Musician
            {
                Name = "Tony Scott",
                Genres = new List<Genre> { genres[7], genres[14], genres[43] },
                Recording = "Music for Zen Meditation and Other Joys",
                Occasions = new List<Occasion> { occasions[2] },
                Numbers = "279"
            },
            new Musician
            {
                Name = "Gil Scott-Heron",
                Genres = new List<Genre> { genres[11] },
                Recording = "Pieces of a Man",
                Occasions = new List<Occasion> { occasions[2] },
                Numbers = "647"
            },
            new Musician
            {
                Name = "Ravi Shankar",
                Genres = new List<Genre> { genres[14], genres[39] },
                Recording = "Three Ragas",
                Occasions = new List<Occasion> { occasions[2] },
                Numbers = "894"
            },
            new Musician
            {
                Name = "Archie Shepp and Horace Parlan",
                Genres = new List<Genre> { genres[7], genres[5] },
                Recording = "Goin' Home",
                Occasions = new List<Occasion> { occasions[2] },
                Numbers = "923, 766"
            },
            new Musician
            {
                Name = "Simon and Garfunkel",
                Genres = new List<Genre> { genres[12] },
                Recording = "Bridge Over Troubled Water",
                Occasions = new List<Occasion> { occasions[2] },
                Numbers = "537, 537"
            },
            new Musician
            {
                Name = "Jimmie Spheeris",
                Genres = new List<Genre> { genres[12] },
                Recording = "Isle of View",
                Occasions = new List<Occasion> { occasions[2] },
                Numbers = "665"
            },
            new Musician
            {
                Name = "Andy Statman",
                Genres = new List<Genre> { genres[14] },
                Recording = "Between Heaven and Earth: Music of the Jewish Mystics",
                Occasions = new List<Occasion> { occasions[2] },
                Numbers = "555"
            },
            new Musician
            {
                Name = "Cat Stevens",
                Genres = new List<Genre> { genres[12] },
                Recording = "Tea for the Tillerman",
                Occasions = new List<Occasion> { occasions[2] },
                Numbers = "739"
            },
            new Musician
            {
                Name = "Sufjan Stevens",
                Genres = new List<Genre> { genres[12] },
                Recording = "Illinoise",
                Occasions = new List<Occasion> { occasions[2] },
                Numbers = "748"
            },
            new Musician
            {
                Name = "Richard Strauss",
                Genres = new List<Genre> { genres[1] },
                Recording = "Four Last Songs",
                Occasions = new List<Occasion> { occasions[2] },
                Numbers = "142"
            },
            new Musician
            {
                Name = "Igor Stravinsky",
                Genres = new List<Genre> { genres[1] },
                Recording = "Rite of Spring",
                Occasions = new List<Occasion> { occasions[2] },
                Numbers = "142"
            },
            new Musician
            {
                Name = "James Taylor",
                Genres = new List<Genre> { genres[12] },
                Recording = "Sweet Baby",
                Occasions = new List<Occasion> { occasions[2] },
                Numbers = "775"
            },
            new Musician
            {
                Name = "James Ralph Towner",
                Genres = new List<Genre> { genres[7] },
                Recording = "Solstice",
                Occasions = new List<Occasion> { occasions[2] },
                Numbers = "656"
            },
            new Musician
            {
                Name = "Various Artists",
                Genres = new List<Genre> { genres[14], genres[37] },
                Recording = "The Great Cantors",
                Occasions = new List<Occasion> { occasions[2] },
                Numbers = ""
            },
            new Musician
            {
                Name = "Various Artists",
                Genres = new List<Genre> { genres[14], genres[52] },
                Recording = "World of Gnawa",
                Occasions = new List<Occasion> { occasions[2] },
                Numbers = ""
            },
            new Musician
            {
                Name = "Suzanne Vega",
                Genres = new List<Genre> { genres[4], genres[10] },
                Recording = "Solitude Standing",
                Occasions = new List<Occasion> { occasions[2] },
                Numbers = "564"
            },
            new Musician
            {
                Name = "Caetano Veloso",
                Genres = new List<Genre> { genres[14], genres[20] },
                Recording = "Livro",
                Occasions = new List<Occasion> { occasions[2] },
                Numbers = "436"
            },
            new Musician
            {
                Name = "Randy Weston",
                Genres = new List<Genre> { genres[7] },
                Recording = "The Spirits of Our Ancestors",
                Occasions = new List<Occasion> { occasions[2] },
                Numbers = "297"
            },
            new Musician
            {
                Name = "Chris Whitley",
                Genres = new List<Genre> { genres[0], genres[12] },
                Recording = "Living with the Law",
                Occasions = new List<Occasion> { occasions[2] },
                Numbers = "427"
            },
            new Musician
            {
                Name = "Lucinda Williams",
                Genres = new List<Genre> { genres[2] },
                Recording = "Sweet Old World",
                Occasions = new List<Occasion> { occasions[2], occasions[9] },
                Numbers = "335"
            },
            new Musician
            {
                Name = "Cassandra Wilson",
                Genres = new List<Genre> { genres[7], genres[13] },
                Recording = "Blue Light 'til Dawn",
                Occasions = new List<Occasion> { occasions[2], occasions[0] },
                Numbers = "959"
            },
            new Musician
            {
                Name = "Robert Wyatt",
                Genres = new List<Genre> { genres[12] },
                Recording = "Rock Bottom",
                Occasions = new List<Occasion> { occasions[2] },
                Numbers = "297"
            },
            new Musician
            {
                Name = "Goro Yamaguchi",
                Genres = new List<Genre> { genres[14], genres[43] },
                Recording = "Shakuhachi Music: A Bell Ringing in the Empty Sky",
                Occasions = new List<Occasion> { occasions[2] },
                Numbers = "481"
            },
            new Musician
            {
                Name = "Neil Young",
                Genres = new List<Genre> { genres[12] },
                Recording = "After the Gold Rush",
                Occasions = new List<Occasion> { occasions[2], occasions[9] },
                Numbers = "187"
            },
            new Musician
            {
                Name = "Warren Zevon",
                Genres = new List<Genre> { genres[12] },
                Recording = "Excitable Boy",
                Occasions = new List<Occasion> { occasions[2] },
                Numbers = "932"
            },
            new Musician
            {
                Name = "Johnny Adams",
                Genres = new List<Genre> { genres[0] },
                Recording = "The Real Me: Johnny Adams Sings Doc Pomus",
                Occasions = new List<Occasion> { occasions[0] },
                Numbers = "647"
            },
            new Musician
            {
                Name = "The Cannonball Adderley Quintet",
                Genres = new List<Genre> { genres[7] },
                Recording = "At the Lighthouse",
                Occasions = new List<Occasion> { occasions[0] },
                Numbers = "977"
            },
            new Musician
            {
                Name = "Arthur Alexander",
                Genres = new List<Genre> { genres[11] },
                Recording = "The Ultimate Arthur Alexander",
                Occasions = new List<Occasion> { occasions[0] },
                Numbers = "629"
            },
            new Musician
            {
                Name = "Mose Allison",
                Genres = new List<Genre> { genres[13] },
                Recording = "Allison Wonderland",
                Occasions = new List<Occasion> { occasions[0] },
                Numbers = "187"
            },
            new Musician
            {
                Name = "Herb Alpert and the Tijuana Brass",
                Genres = new List<Genre> { genres[10] },
                Recording = "Whipped Cream and Other Delights",
                Occasions = new List<Occasion> { occasions[0] },
                Numbers = "216, 225, 656, 914, 775, 252"
            },
            new Musician
            {
                Name = "Fred Astaire",
                Genres = new List<Genre> { genres[13] },
                Recording = "Steppin' Out: Astaire Sings",
                Occasions = new List<Occasion> { occasions[0] },
                Numbers = "288"
            },
            new Musician
            {
                Name = "Chet Atkins and Les Paul",
                Genres = new List<Genre> { genres[2], genres[7] },
                Recording = "Chester and Lester",
                Occasions = new List<Occasion> { occasions[0] },
                Numbers = "445, 445"
            },
            new Musician
            {
                Name = "Harry Belafonte",
                Genres = new List<Genre> { genres[13] },
                Recording = "Live at Carnegie Hall",
                Occasions = new List<Occasion> { occasions[0] },
                Numbers = "187"
            },
            new Musician
            {
                Name = "Tony Bennett and Bill Evans",
                Genres = new List<Genre> { genres[13] },
                Recording = "The Tony Bennett-Bill Evans Album",
                Occasions = new List<Occasion> { occasions[0] },
                Numbers = "261, 858"
            },
            new Musician
            {
                Name = "Art Blakey and the Jazz Messengers",
                Genres = new List<Genre> { genres[7] },
                Recording = "Moanin'",
                Occasions = new List<Occasion> { occasions[0] },
                Numbers = "519, 335, 959, 216, 867, 178, 178, 463, 519, 225, 418, 573, 638, 555, 932"
            },
            new Musician
            {
                Name = "Bobby 'Blue' Bland",
                Genres = new List<Genre> { genres[0] },
                Recording = "Two Steps from the Blues",
                Occasions = new List<Occasion> { occasions[0] },
                Numbers = "894"
            },
            new Musician
            {
                Name = "Clifford Brown-Max Roach Quintet",
                Genres = new List<Genre> { genres[7] },
                Recording = "Clifford Brown and Max Roach",
                Occasions = new List<Occasion> { occasions[0] },
                Numbers = "721, 683, 389, 941, 793, 591"
            },
            new Musician
            {
                Name = "Lord Buckley",
                Genres = new List<Genre> { genres[13] },
                Recording = "His Royal Hipness",
                Occasions = new List<Occasion> { occasions[0] },
                Numbers = "472"
            },
            new Musician
            {
                Name = "Sonny Clark",
                Genres = new List<Genre> { genres[7] },
                Recording = "Cool Struttin'",
                Occasions = new List<Occasion> { occasions[0] },
                Numbers = "692"
            },
            new Musician
            {
                Name = "John Coltrane and Johnny Hartman",
                Genres = new List<Genre> { genres[7], genres[13] },
                Recording = "John Coltrane and Johnny Hartman",
                Occasions = new List<Occasion> { occasions[0] },
                Numbers = "243, 573"
            },
            new Musician
            {
                Name = "Bing Crosby",
                Genres = new List<Genre> { genres[13] },
                Recording = "A Centennial Anthology of Decca Recordings",
                Occasions = new List<Occasion> { occasions[0] },
                Numbers = "766"
            },
            new Musician
            {
                Name = "Bobby Darin",
                Genres = new List<Genre> { genres[13] },
                Recording = "That's All",
                Occasions = new List<Occasion> { occasions[0] },
                Numbers = "151"
            },
            new Musician
            {
                Name = "Sammy Davis Jr.",
                Genres = new List<Genre> { genres[13] },
                Recording = "I Gotta Right to Swing",
                Occasions = new List<Occasion> { occasions[0] },
                Numbers = "344"
            },
            new Musician
            {
                Name = "Ella Fitzgerald",
                Genres = new List<Genre> { genres[7], genres[13] },
                Recording = "Ella Fitzgerald Sings the Cole Porter Songbook",
                Occasions = new List<Occasion> { occasions[0] },
                Numbers = "297"
            },
            new Musician
            {
                Name = "Ella Fitzgerald and Louis Armstrong",
                Genres = new List<Genre> { genres[7], genres[13] },
                Recording = "Ella and Louis",
                Occasions = new List<Occasion> { occasions[0] },
                Numbers = "297, 995"
            },
            new Musician
            {
                Name = "The Four Freshmen",
                Genres = new List<Genre> { genres[13] },
                Recording = "The Four Freshmen and Five Trombones",
                Occasions = new List<Occasion> { occasions[0] },
                Numbers = "941, 252, 894, 894, 472, 3"
            },
            new Musician
            {
                Name = "Serge Gainsbourg",
                Genres = new List<Genre> { genres[12], genres[13] },
                Recording = "Histoire de Melody Nelson",
                Occasions = new List<Occasion> { occasions[0] },
                Numbers = "941"
            },
            new Musician
            {
                Name = "Erroll Garner",
                Genres = new List<Genre> { genres[7] },
                Recording = "Concert by the Sea",
                Occasions = new List<Occasion> { occasions[0] },
                Numbers = "748"
            },
            new Musician
            {
                Name = "Stan Getz and João Gilberto",
                Genres = new List<Genre> { genres[7] },
                Recording = "Getz/Gilberto",
                Occasions = new List<Occasion> { occasions[0] },
                Numbers = "297, 611"
            },
            new Musician
            {
                Name = "Dexter Gordon",
                Genres = new List<Genre> { genres[7] },
                Recording = "Go!",
                Occasions = new List<Occasion> { occasions[0] },
                Numbers = "528"
            },
            new Musician
            {
                Name = "Billie Holiday",
                Genres = new List<Genre> { genres[7], genres[11], genres[13] },
                Recording = "The Ultimate Collection",
                Occasions = new List<Occasion> { occasions[0] },
                Numbers = "463"
            },
            new Musician
            {
                Name = "Etta James",
                Genres = new List<Genre> { genres[11] },
                Recording = "Tell Mama",
                Occasions = new List<Occasion> { occasions[0] },
                Numbers = "932"
            },
            new Musician
            {
                Name = "George Jones",
                Genres = new List<Genre> { genres[2] },
                Recording = "The Grand Tour",
                Occasions = new List<Occasion> { occasions[0] },
                Numbers = "674"
            },
            new Musician
            {
                Name = "Ernesto Lecuona",
                Genres = new List<Genre> { genres[1], genres[14], genres[28] },
                Recording = "The Ultimate Collection: Lecuona Plays Lecuona",
                Occasions = new List<Occasion> { occasions[0] },
                Numbers = "564"
            },
            new Musician
            {
                Name = "Les McCann and Eddie Harris",
                Genres = new List<Genre> { genres[7] },
                Recording = "Swiss Movement",
                Occasions = new List<Occasion> { occasions[0] },
                Numbers = "243, 362"
            },
            new Musician
            {
                Name = "Hank Mobley",
                Genres = new List<Genre> { genres[7] },
                Recording = "Soul Station",
                Occasions = new List<Occasion> { occasions[0], occasions[9] },
                Numbers = "748"
            },
            new Musician
            {
                Name = "Wes Montgomery",
                Genres = new List<Genre> { genres[7] },
                Recording = "Smokin' at the Half Note",
                Occasions = new List<Occasion> { occasions[0], occasions[6] },
                Numbers = "519"
            },
            new Musician
            {
                Name = "Oliver Nelson",
                Genres = new List<Genre> { genres[7] },
                Recording = "The Blues and the Abstract Truth",
                Occasions = new List<Occasion> { occasions[0] },
                Numbers = "582"
            },
            new Musician
            {
                Name = "Phineas Newborn Jr.",
                Genres = new List<Genre> { genres[7] },
                Recording = "A World of Piano!",
                Occasions = new List<Occasion> { occasions[0] },
                Numbers = "647"
            },
            new Musician
            {
                Name = "Charlie Parker",
                Genres = new List<Genre> { genres[7] },
                Recording = "Charlie Parker with Strings",
                Occasions = new List<Occasion> { occasions[0] },
                Numbers = "858"
            },
            new Musician
            {
                Name = "Les Paul with Mary Ford",
                Genres = new List<Genre> { genres[7], genres[13] },
                Recording = "The Best of the Capitol Masters: Ninetieth Birthday Edition",
                Occasions = new List<Occasion> { occasions[0], occasions[6] },
                Numbers = "445, 445"
            },
            new Musician
            {
                Name = "The Oscar Peterson Trio",
                Genres = new List<Genre> { genres[7] },
                Recording = "Night Train",
                Occasions = new List<Occasion> { occasions[0] },
                Numbers = "389"
            },
            new Musician
            {
                Name = "Charlie Rich",
                Genres = new List<Genre> { genres[2] },
                Recording = "Behind Closed Doors",
                Occasions = new List<Occasion> { occasions[0] },
                Numbers = "519"
            },
            new Musician
            {
                Name = "Nina Simone",
                Genres = new List<Genre> { genres[7] },
                Recording = "Anthology",
                Occasions = new List<Occasion> { occasions[0] },
                Numbers = "481"
            },
            new Musician
            {
                Name = "Frank Sinatra",
                Genres = new List<Genre> { genres[13] },
                Recording = "Songs for Swingin' Lovers",
                Occasions = new List<Occasion> { occasions[0] },
                Numbers = "472"
            },
            new Musician
            {
                Name = "Cal Tjader",
                Genres = new List<Genre> { genres[7] },
                Recording = "Primo",
                Occasions = new List<Occasion> { occasions[0] },
                Numbers = "398"
            },
            new Musician
            {
                Name = "Sarah Vaughan",
                Genres = new List<Genre> { genres[7] },
                Recording = "Live in Japan",
                Occasions = new List<Occasion> { occasions[0] },
                Numbers = "472"
            },
            new Musician
            {
                Name = "Dinah Washington",
                Genres = new List<Genre> { genres[7], genres[13] },
                Recording = "Dinah!",
                Occasions = new List<Occasion> { occasions[0] },
                Numbers = "427"
            },
            new Musician
            {
                Name = "Muddy Waters",
                Genres = new List<Genre> { genres[0] },
                Recording = "At Newport 1960",
                Occasions = new List<Occasion> { occasions[0], occasions[6] },
                Numbers = "647"
            },
            new Musician
            {
                Name = "Joe Williams with the Count Basie Orchestra",
                Genres = new List<Genre> { genres[7] },
                Recording = "Count Basie Swings, Joe Williams Sings",
                Occasions = new List<Occasion> { occasions[0] },
                Numbers = "178, 683, 124, 813, 519, 849, 178, 187, 977, 822, 775, 813, 499, 279, 297, 683, 344"
            },
            new Musician
            {
                Name = "Lester Young",
                Genres = new List<Genre> { genres[7] },
                Recording = "The 'Kansas City' Sessions",
                Occasions = new List<Occasion> { occasions[0] },
                Numbers = "124"
            },
            new Musician
            {
                Name = "King Sunny Ade",
                Genres = new List<Genre> { genres[14], genres[53] },
                Recording = "The Best of the Classic Years",
                Occasions = new List<Occasion> { occasions[1] },
                Numbers = "977"
            },
            new Musician
            {
                Name = "Aerosmith",
                Genres = new List<Genre> { genres[12] },
                Recording = "Toys in the Attic",
                Occasions = new List<Occasion> { occasions[1] },
                Numbers = "775, 472, 546, 353, 573, 941, 142, 353"
            },
            new Musician
            {
                Name = "Los Amigos Invisibles",
                Genres = new List<Genre> { genres[14], genres[65] },
                Recording = "Arepa 3000: A Venezuelan Journey into Space",
                Occasions = new List<Occasion> { occasions[1] },
                Numbers = ""
            },
            new Musician
            {
                Name = "Arrested Development",
                Genres = new List<Genre> { genres[6] },
                Recording = "Three Years, Five Months, and Two Days in the Life of…",
                Occasions = new List<Occasion> { occasions[1] },
                Numbers = "537, 481, 692, 813, 582, 528"
            },
            new Musician
            {
                Name = "Baby Huey and the Babysitters",
                Genres = new List<Genre> { genres[11] },
                Recording = "The Baby Huey Story: The Living Legend",
                Occasions = new List<Occasion> { occasions[1] },
                Numbers = "252, 454, 344"
            },
            new Musician
            {
                Name = "Afrika Bambaataa and the Soul Sonic Force",
                Genres = new List<Genre> { genres[6] },
                Recording = "'Planet Rock'",
                Occasions = new List<Occasion> { occasions[1] },
                Numbers = "766, 1, 353, 582"
            },
            new Musician
            {
                Name = "Ray Barretto",
                Genres = new List<Genre> { genres[14], genres[45] },
                Recording = "Barretto Power",
                Occasions = new List<Occasion> { occasions[1] },
                Numbers = "894"
            },
            new Musician
            {
                Name = "The Beastie Boys",
                Genres = new List<Genre> { genres[6] },
                Recording = "Paul's Boutique",
                Occasions = new List<Occasion> { occasions[1] },
                Numbers = "151, 822, 813, 995, 793"
            },
            new Musician
            {
                Name = "Bembeya Jazz National",
                Genres = new List<Genre> { genres[14], genres[34] },
                Recording = "The Syliphone Years",
                Occasions = new List<Occasion> { occasions[1] },
                Numbers = ""
            },
            new Musician
            {
                Name = "Jorge Ben",
                Genres = new List<Genre> { genres[14], genres[20] },
                Recording = "Africa/Brazil",
                Occasions = new List<Occasion> { occasions[1] },
                Numbers = "472"
            },
            new Musician
            {
                Name = "Chuck Berry",
                Genres = new List<Genre> { genres[12] },
                Recording = "The Anthology",
                Occasions = new List<Occasion> { occasions[1] },
                Numbers = "234"
            },
            new Musician
            {
                Name = "Rubén Blades and Willie Colón",
                Genres = new List<Genre> { genres[14], genres[45] },
                Recording = "Siembra",
                Occasions = new List<Occasion> { occasions[1] },
                Numbers = "591, 739"
            },
            new Musician
            {
                Name = "Bloque",
                Genres = new List<Genre> { genres[14], genres[26] },
                Recording = "Bloque",
                Occasions = new List<Occasion> { occasions[1] },
                Numbers = ""
            },
            new Musician
            {
                Name = "Booker T. and the MGs",
                Genres = new List<Genre> { genres[11] },
                Recording = "Melting Pot",
                Occasions = new List<Occasion> { occasions[1] },
                Numbers = "225, 537, 225, 418, 528, 187, 169, 555, 894"
            },
            new Musician
            {
                Name = "Chuck Brown and the Soul Searchers",
                Genres = new List<Genre> { genres[11] },
                Recording = "Any Other Way to Go?",
                Occasions = new List<Occasion> { occasions[1] },
                Numbers = "124, 894"
            },
            new Musician
            {
                Name = "James Brown and the JB's",
                Genres = new List<Genre> { genres[11] },
                Recording = "'Sex Machine'",
                Occasions = new List<Occasion> { occasions[1] },
                Numbers = "463, 317, 353, 344, 831, 335, 499, 362, 398, 712, 279"
            },
            new Musician
            {
                Name = "Buckwheat Zydeco",
                Genres = new List<Genre> { genres[0] },
                Recording = "Buckwheat's Zydeco Party",
                Occasions = new List<Occasion> { occasions[1] },
                Numbers = "822"
            },
            new Musician
            {
                Name = "Manu Chao",
                Genres = new List<Genre> { genres[14] },
                Recording = "Clandestino",
                Occasions = new List<Occasion> { occasions[1] },
                Numbers = "317"
            },
            new Musician
            {
                Name = "Ray Charles",
                Genres = new List<Genre> { genres[11] },
                Recording = "The Best of Ray Charles: The Atlantic Years",
                Occasions = new List<Occasion> { occasions[1] },
                Numbers = "712"
            },
            new Musician
            {
                Name = "Creedence Clearwater Revival",
                Genres = new List<Genre> { genres[12] },
                Recording = "Willie and the Poor Boys",
                Occasions = new List<Occasion> { occasions[1] },
                Numbers = "151, 528, 169, 169"
            },
            new Musician
            {
                Name = "Celia Cruz and Johnny Pacheco",
                Genres = new List<Genre> { genres[14], genres[45] },
                Recording = "Celia y Johnny",
                Occasions = new List<Occasion> { occasions[1] },
                Numbers = "362, 216"
            },
            new Musician
            {
                Name = "Deep Purple",
                Genres = new List<Genre> { genres[12] },
                Recording = "Machine Head",
                Occasions = new List<Occasion> { occasions[1] },
                Numbers = "748, 187, 124, 133, 748, 573, 169"
            },
            new Musician
            {
                Name = "Bo Diddley",
                Genres = new List<Genre> { genres[12] },
                Recording = "Bo Diddley",
                Occasions = new List<Occasion> { occasions[1] },
                Numbers = "941"
            },
            new Musician
            {
                Name = "Dizzee Rascal",
                Genres = new List<Genre> { genres[6] },
                Recording = "Boy in da Corner",
                Occasions = new List<Occasion> { occasions[1] },
                Numbers = "712"
            },
            new Musician
            {
                Name = "Antoine 'Fats' Domino",
                Genres = new List<Genre> { genres[12] },
                Recording = "They Call Me the Fat Man: The Legendary Imperial Recordings",
                Occasions = new List<Occasion> { occasions[1] },
                Numbers = "959"
            },
            new Musician
            {
                Name = "Missy Elliott",
                Genres = new List<Genre> { genres[6] },
                Recording = "Respect M.E.",
                Occasions = new List<Occasion> { occasions[1] },
                Numbers = "279"
            },
            new Musician
            {
                Name = "The Fugees",
                Genres = new List<Genre> { genres[6] },
                Recording = "The Score",
                Occasions = new List<Occasion> { occasions[1] },
                Numbers = "757, 499, 196"
            },
            new Musician
            {
                Name = "Bill Haley and His Comets",
                Genres = new List<Genre> { genres[12] },
                Recording = "'Rock Around the Clock'",
                Occasions = new List<Occasion> { occasions[1] },
                Numbers = "317, 894, 353, 463, 995, 712, 427, 876, 784, 647"
            },
            new Musician
            {
                Name = "Buddy Holly",
                Genres = new List<Genre> { genres[12] },
                Recording = "The Buddy Holly Collection",
                Occasions = new List<Occasion> { occasions[1] },
                Numbers = "124"
            },
            new Musician
            {
                Name = "The Jackson Five",
                Genres = new List<Genre> { genres[10], genres[11] },
                Recording = "'I Want You Back'",
                Occasions = new List<Occasion> { occasions[1] },
                Numbers = "463, 234, 178, 775, 683"
            },
            new Musician
            {
                Name = "Michael Jackson",
                Genres = new List<Genre> { genres[10] },
                Recording = "Thriller",
                Occasions = new List<Occasion> { occasions[1] },
                Numbers = "683"
            },
            new Musician
            {
                Name = "Elmore James",
                Genres = new List<Genre> { genres[0] },
                Recording = "The Sky Is Crying",
                Occasions = new List<Occasion> { occasions[1] },
                Numbers = "297"
            },
            new Musician
            {
                Name = "Rick James",
                Genres = new List<Genre> { genres[11] },
                Recording = "Street Songs",
                Occasions = new List<Occasion> { occasions[1] },
                Numbers = "894"
            },
            new Musician
            {
                Name = "Albert King",
                Genres = new List<Genre> { genres[0] },
                Recording = "Born Under a Bad Sign",
                Occasions = new List<Occasion> { occasions[1] },
                Numbers = "591"
            },
            new Musician
            {
                Name = "B.B. King",
                Genres = new List<Genre> { genres[0] },
                Recording = "Live at the Regal",
                Occasions = new List<Occasion> { occasions[1] },
                Numbers = "371"
            },
            new Musician
            {
                Name = "Kiss",
                Genres = new List<Genre> { genres[12] },
                Recording = "'Rock and Roll All Nite'",
                Occasions = new List<Occasion> { occasions[1] },
                Numbers = "463, 683, 564, 178"
            },
            new Musician
            {
                Name = "Magic Sam",
                Genres = new List<Genre> { genres[0] },
                Recording = "West Side Soul",
                Occasions = new List<Occasion> { occasions[1], occasions[6] },
                Numbers = "959"
            },
            new Musician
            {
                Name = "Augustus Pablo",
                Genres = new List<Genre> { genres[14], genres[42] },
                Recording = "King Tubbys Meets Rockers Uptown",
                Occasions = new List<Occasion> { occasions[1] },
                Numbers = "142"
            },
            new Musician
            {
                Name = "Parliament",
                Genres = new List<Genre> { genres[11] },
                Recording = "Mothership Connection",
                Occasions = new List<Occasion> { occasions[1] },
                Numbers = "564, 647, 573, 454, 647, 591, 591, 712, 288, 297, 499, 362, 261, 867, 216, 822, 555, 317, 353, 187"
            },
            new Musician
            {
                Name = "Carl Perkins",
                Genres = new List<Genre> { genres[12] },
                Recording = "Dance Album",
                Occasions = new List<Occasion> { occasions[1] },
                Numbers = "591"
            },
            new Musician
            {
                Name = "Itzhak Perlman",
                Genres = new List<Genre> { genres[14], genres[44] },
                Recording = "Live in the Fiddler's House",
                Occasions = new List<Occasion> { occasions[1] },
                Numbers = "124"
            },
            new Musician
            {
                Name = "Wilson Pickett",
                Genres = new List<Genre> { genres[11] },
                Recording = "The Exciting Wilson Pickett",
                Occasions = new List<Occasion> { occasions[1] },
                Numbers = "519"
            },
            new Musician
            {
                Name = "Elvis Presley",
                Genres = new List<Genre> { genres[12] },
                Recording = "Elvis at Sun",
                Occasions = new List<Occasion> { occasions[1] },
                Numbers = "335"
            },
            new Musician
            {
                Name = "Louis Prima",
                Genres = new List<Genre> { genres[13] },
                Recording = "The Wildest!",
                Occasions = new List<Occasion> { occasions[1] },
                Numbers = "959"
            },
            new Musician
            {
                Name = "Otis Redding",
                Genres = new List<Genre> { genres[11] },
                Recording = "Otis Blue",
                Occasions = new List<Occasion> { occasions[1] },
                Numbers = "546"
            },
            new Musician
            {
                Name = "Jimmy Reed",
                Genres = new List<Genre> { genres[0] },
                Recording = "The Very Best of Jimmy Reed",
                Occasions = new List<Occasion> { occasions[1] },
                Numbers = "389"
            },
            new Musician
            {
                Name = "Tito Rodriguez",
                Genres = new List<Genre> { genres[14], genres[45] },
                Recording = "Live at the Palladium",
                Occasions = new List<Occasion> { occasions[1] },
                Numbers = "647"
            },
            new Musician
            {
                Name = "Run-DMC",
                Genres = new List<Genre> { genres[6] },
                Recording = "Raising Hell",
                Occasions = new List<Occasion> { occasions[1] },
                Numbers = "959, 923, 932"
            },
            new Musician
            {
                Name = "Otis Rush",
                Genres = new List<Genre> { genres[0] },
                Recording = "The Classic Cobra Recordings, 1956-1958",
                Occasions = new List<Occasion> { occasions[1] },
                Numbers = "335"
            },
            new Musician
            {
                Name = "Mitch Ryder and the Detroit Wheels",
                Genres = new List<Genre> { genres[12] },
                Recording = "'Devil with a Blue Dress On' and 'Good Golly Miss Molly'",
                Occasions = new List<Occasion> { occasions[1] },
                Numbers = "187, 151, 178, 674, 748"
            },
            new Musician
            {
                Name = "Huey 'Piano' Smith and His Clowns",
                Genres = new List<Genre> { genres[11] },
                Recording = "This Is…",
                Occasions = new List<Occasion> { occasions[1] },
                Numbers = "463"
            },
            new Musician
            {
                Name = "Britney Spears",
                Genres = new List<Genre> { genres[10] },
                Recording = "'Toxic'",
                Occasions = new List<Occasion> { occasions[1] },
                Numbers = "187"
            },
            new Musician
            {
                Name = "The Streets",
                Genres = new List<Genre> { genres[6] },
                Recording = "Original Pirate Material",
                Occasions = new List<Occasion> { occasions[1] },
                Numbers = "353, 234, 582"
            },
            new Musician
            {
                Name = "Donna Summer",
                Genres = new List<Genre> { genres[11] },
                Recording = "'I Feel Love'",
                Occasions = new List<Occasion> { occasions[1] },
                Numbers = "775"
            },
            new Musician
            {
                Name = "The Supremes",
                Genres = new List<Genre> { genres[10], genres[11] },
                Recording = "'You Keep Me Hangin' On'",
                Occasions = new List<Occasion> { occasions[1] },
                Numbers = "216, 216, 317, 573, 317, 775, 225, 656, 234, 674"
            },
            new Musician
            {
                Name = "Big Mama Thornton",
                Genres = new List<Genre> { genres[0] },
                Recording = "Hound Dog: The Peacock Recordings",
                Occasions = new List<Occasion> { occasions[1] },
                Numbers = "216"
            },
            new Musician
            {
                Name = "Toots and the Maytals",
                Genres = new List<Genre> { genres[14], genres[42] },
                Recording = "Funky Kingston/In the Dark",
                Occasions = new List<Occasion> { occasions[1] },
                Numbers = "472, 2, 5, 813, 225, 243"
            },
            new Musician
            {
                Name = "Allen Toussaint",
                Genres = new List<Genre> { genres[11] },
                Recording = "Finger Poppin' and Stompin' Feet",
                Occasions = new List<Occasion> { occasions[1] },
                Numbers = "932"
            },
            new Musician
            {
                Name = "Big Joe Turner",
                Genres = new List<Genre> { genres[11] },
                Recording = "Big, Bad, and Blue",
                Occasions = new List<Occasion> { occasions[1] },
                Numbers = "885"
            },
            new Musician
            {
                Name = "Ultramagnetic MCs",
                Genres = new List<Genre> { genres[6] },
                Recording = "Critical Beatdown",
                Occasions = new List<Occasion> { occasions[1] },
                Numbers = "115, 124"
            },
            new Musician
            {
                Name = "Usher",
                Genres = new List<Genre> { genres[11] },
                Recording = "Confessions",
                Occasions = new List<Occasion> { occasions[1] },
                Numbers = "499"
            },
            new Musician
            {
                Name = "Various Artists",
                Genres = new List<Genre> { genres[6] },
                Recording = "The Best of Sugar Hill Records",
                Occasions = new List<Occasion> { occasions[1] },
                Numbers = ""
            },
            new Musician
            {
                Name = "Various Artists",
                Genres = new List<Genre> { genres[12] },
                Recording = "Dazed and Confused",
                Occasions = new List<Occasion> { occasions[1] },
                Numbers = ""
            },
            new Musician
            {
                Name = "Various Artists",
                Genres = new List<Genre> { genres[7] },
                Recording = "The Fabulous Swing Collection",
                Occasions = new List<Occasion> { occasions[1] },
                Numbers = ""
            },
            new Musician
            {
                Name = "Fats Waller",
                Genres = new List<Genre> { genres[7] },
                Recording = "If You Got to Ask, You Ain't Got It",
                Occasions = new List<Occasion> { occasions[1] },
                Numbers = "629"
            },
            new Musician
            {
                Name = "War",
                Genres = new List<Genre> { genres[11] },
                Recording = "Why Can't We Be Friends?",
                Occasions = new List<Occasion> { occasions[1] },
                Numbers = "784, 4"
            },
            new Musician
            {
                Name = "The White Stripes",
                Genres = new List<Genre> { genres[12] },
                Recording = "Elephant",
                Occasions = new List<Occasion> { occasions[1] },
                Numbers = "739, 813"
            },
            new Musician
            {
                Name = "The Wild Tchoupitoulas",
                Genres = new List<Genre> { genres[0], genres[12] },
                Recording = "The Wild Tchoupitoulas",
                Occasions = new List<Occasion> { occasions[1] },
                Numbers = ""
            },
            new Musician
            {
                Name = "Jackie Wilson",
                Genres = new List<Genre> { genres[11] },
                Recording = "The Very Best of Jackie Wilson",
                Occasions = new List<Occasion> { occasions[1] },
                Numbers = "317"
            },
            new Musician
            {
                Name = "Fiona Apple",
                Genres = new List<Genre> { genres[12] },
                Recording = "When the Pawn…",
                Occasions = new List<Occasion> { occasions[6] },
                Numbers = "546"
            },
            new Musician
            {
                Name = "The Beatles",
                Genres = new List<Genre> { genres[12] },
                Recording = "Revolver",
                Occasions = new List<Occasion> { occasions[6] },
                Numbers = "665, 445, 611, 353, 528"
            },
            new Musician
            {
                Name = "Buffalo Springfield",
                Genres = new List<Genre> { genres[12] },
                Recording = "Retrospective",
                Occasions = new List<Occasion> { occasions[6] },
                Numbers = "288, 216, 187, 674, 977, 822, 923, 849"
            },
            new Musician
            {
                Name = "Patsy Cline",
                Genres = new List<Genre> { genres[2] },
                Recording = "The Patsy Cline Collection",
                Occasions = new List<Occasion> { occasions[6] },
                Numbers = "546"
            },
            new Musician
            {
                Name = "Lester Flatt",
                Genres = new List<Genre> { genres[2] },
                Recording = "Earl Scruggs, and the Foggy Mountain Boys, Foggy Mountain Jamboree",
                Occasions = new List<Occasion> { occasions[6] },
                Numbers = "573, 591, 326, 115, 941, 216, 418, 923, 638, 528, 445, 793"
            },
            new Musician
            {
                Name = "Emmylou Harris",
                Genres = new List<Genre> { genres[2] },
                Recording = "Pieces of the Sky",
                Occasions = new List<Occasion> { occasions[6] },
                Numbers = "813"
            },
            new Musician
            {
                Name = "Jascha Heifetz",
                Genres = new List<Genre> { genres[1] },
                Recording = "Brahms, Tchaikovsky Violin Concertos",
                Occasions = new List<Occasion> { occasions[6] },
                Numbers = "169, 528, 757"
            },
            new Musician
            {
                Name = "Waylon Jennings",
                Genres = new List<Genre> { genres[2] },
                Recording = "Honky Tonk Heroes",
                Occasions = new List<Occasion> { occasions[6] },
                Numbers = "914"
            },
            new Musician
            {
                Name = "Booker Little",
                Genres = new List<Genre> { genres[7] },
                Recording = "Out Front",
                Occasions = new List<Occasion> { occasions[6] },
                Numbers = "813"
            },
            new Musician
            {
                Name = "The Dave Matthews Band",
                Genres = new List<Genre> { genres[12] },
                Recording = "The Gorge",
                Occasions = new List<Occasion> { occasions[6] },
                Numbers = "766, 665, 885, 775, 463, 867, 389, 472, 335, 923"
            },
            new Musician
            {
                Name = "Blind Willie McTell",
                Genres = new List<Genre> { genres[0] },
                Recording = "The Definitive Blind Willie McTell",
                Occasions = new List<Occasion> { occasions[6] },
                Numbers = "335"
            },
            new Musician
            {
                Name = "Charles Mingus",
                Genres = new List<Genre> { genres[7] },
                Recording = "Mingus Ah Um",
                Occasions = new List<Occasion> { occasions[6] },
                Numbers = "638"
            },
            new Musician
            {
                Name = "Nitty Gritty Dirt Band",
                Genres = new List<Genre> { genres[2], genres[12] },
                Recording = "Will the Circle Be Unbroken",
                Occasions = new List<Occasion> { occasions[6] },
                Numbers = "867, 178, 775, 932, 793, 867, 261"
            },
            new Musician
            {
                Name = "Marty Robbins",
                Genres = new List<Genre> { genres[2] },
                Recording = "Gunfighter Ballads and Trail Songs",
                Occasions = new List<Occasion> { occasions[6] },
                Numbers = "371"
            },
            new Musician
            {
                Name = "Santana",
                Genres = new List<Genre> { genres[12] },
                Recording = "Abraxis",
                Occasions = new List<Occasion> { occasions[6] },
                Numbers = "867"
            },
            new Musician
            {
                Name = "Hank Snow",
                Genres = new List<Genre> { genres[2] },
                Recording = "The Essential",
                Occasions = new List<Occasion> { occasions[6] },
                Numbers = "582"
            },
            new Musician
            {
                Name = "T. Rex",
                Genres = new List<Genre> { genres[12] },
                Recording = "Electric Warrior",
                Occasions = new List<Occasion> { occasions[6] },
                Numbers = "849, 692, 885, 885, 914, 196, 472, 216, 169, 885, 344, 9"
            },
            new Musician
            {
                Name = "Hank Williams",
                Genres = new List<Genre> { genres[2] },
                Recording = "Forty Greatest Hits",
                Occasions = new List<Occasion> { occasions[6] },
                Numbers = "546"
            },
            new Musician
            {
                Name = "The Allman Brothers Band",
                Genres = new List<Genre> { genres[12] },
                Recording = "At Fillmore East",
                Occasions = new List<Occasion> { occasions[7] },
                Numbers = "959, 813, 344, 261, 775, 885, 335, 766, 712"
            },
            new Musician
            {
                Name = "Solomon Burke",
                Genres = new List<Genre> { genres[11] },
                Recording = "Don't Give Up on Me",
                Occasions = new List<Occasion> { occasions[7] },
                Numbers = "647"
            },
            new Musician
            {
                Name = "Burning Spear",
                Genres = new List<Genre> { genres[14], genres[42] },
                Recording = "Marcus Garvey",
                Occasions = new List<Occasion> { occasions[7] },
                Numbers = "187"
            },
            new Musician
            {
                Name = "Vic Chesnutt",
                Genres = new List<Genre> { genres[12] },
                Recording = "Is the Actor Happy?",
                Occasions = new List<Occasion> { occasions[7] },
                Numbers = "959"
            },
            new Musician
            {
                Name = "Codona",
                Genres = new List<Genre> { genres[7], genres[14] },
                Recording = "Codona 3",
                Occasions = new List<Occasion> { occasions[7] },
                Numbers = "187, 261, 169"
            },
            new Musician
            {
                Name = "Ry Cooder",
                Genres = new List<Genre> { genres[12] },
                Recording = "Paradise and Lunch",
                Occasions = new List<Occasion> { occasions[7] },
                Numbers = "813"
            },
            new Musician
            {
                Name = "Bob Dylan",
                Genres = new List<Genre> { genres[12] },
                Recording = "Love and Theft",
                Occasions = new List<Occasion> { occasions[7] },
                Numbers = "582"
            },
            new Musician
            {
                Name = "Fleetwood Mac",
                Genres = new List<Genre> { genres[12] },
                Recording = "Then Play On",
                Occasions = new List<Occasion> { occasions[7] },
                Numbers = "968, 876, 398, 674, 757"
            },
            new Musician
            {
                Name = "Rory Gallagher",
                Genres = new List<Genre> { genres[12] },
                Recording = "Irish Tour 1974",
                Occasions = new List<Occasion> { occasions[7] },
                Numbers = "784"
            },
            new Musician
            {
                Name = "Merle Haggard",
                Genres = new List<Genre> { genres[2] },
                Recording = "Mama Tried",
                Occasions = new List<Occasion> { occasions[7] },
                Numbers = "932"
            },
            new Musician
            {
                Name = "John Lee Hooker",
                Genres = new List<Genre> { genres[0] },
                Recording = "John Lee Hooker Plays and Sings the Blues",
                Occasions = new List<Occasion> { occasions[7] },
                Numbers = "252"
            },
            new Musician
            {
                Name = "Lightnin' Hopkins",
                Genres = new List<Genre> { genres[0] },
                Recording = "Lightnin' Hopkins",
                Occasions = new List<Occasion> { occasions[9] },
                Numbers = "775"
            },
            new Musician
            {
                Name = "Bobby Hutcherson",
                Genres = new List<Genre> { genres[7] },
                Recording = "Components",
                Occasions = new List<Occasion> { occasions[7] },
                Numbers = "638"
            },
            new Musician
            {
                Name = "Janis Joplin",
                Genres = new List<Genre> { genres[12] },
                Recording = "Pearl",
                Occasions = new List<Occasion> { occasions[7] },
                Numbers = "463"
            },
            new Musician
            {
                Name = "Led Zeppelin",
                Genres = new List<Genre> { genres[12] },
                Recording = "Led Zeppelin II",
                Occasions = new List<Occasion> { occasions[7] },
                Numbers = "721, 335, 757, 178"
            },
            new Musician
            {
                Name = "Baaba Maal (with Mansour Seck)",
                Genres = new List<Genre> { genres[14], genres[59] },
                Recording = "Djam leelii",
                Occasions = new List<Occasion> { occasions[7] },
                Numbers = "225"
            },
            new Musician
            {
                Name = "Pink Floyd",
                Genres = new List<Genre> { genres[12] },
                Recording = "Dark Side of the Moon",
                Occasions = new List<Occasion> { occasions[7], occasions[9] },
                Numbers = "335, 389, 398, 169, 941"
            },
            new Musician
            {
                Name = "The Rolling Stones",
                Genres = new List<Genre> { genres[12] },
                Recording = "Singles Collection: The London Years",
                Occasions = new List<Occasion> { occasions[7] },
                Numbers = "398, 344, 582, 885, 481, 867, 196, 766"
            },
            new Musician
            {
                Name = "Lonnie Smith",
                Genres = new List<Genre> { genres[7] },
                Recording = "Live at the Club Mozambique",
                Occasions = new List<Occasion> { occasions[7] },
                Numbers = "445"
            },
            new Musician
            {
                Name = "Taj Mahal",
                Genres = new List<Genre> { genres[0] },
                Recording = "The Natch'l Blues",
                Occasions = new List<Occasion> { occasions[7] },
                Numbers = "454"
            },
            new Musician
            {
                Name = "Television",
                Genres = new List<Genre> { genres[12] },
                Recording = "Marquee Moon",
                Occasions = new List<Occasion> { occasions[7], occasions[9] },
                Numbers = "647, 528, 766, 499, 674, 8"
            },
            new Musician
            {
                Name = "Richard and Linda Thompson",
                Genres = new List<Genre> { genres[4], genres[12] },
                Recording = "Shoot Out the Lights",
                Occasions = new List<Occasion> { occasions[7] },
                Numbers = "647, 858"
            },
            new Musician
            {
                Name = "Traffic",
                Genres = new List<Genre> { genres[12] },
                Recording = "John Barleycorn Must Die",
                Occasions = new List<Occasion> { occasions[7] },
                Numbers = "757, 261, 279, 923, 968, 133, 225, 196, 371, 353"
            },
            new Musician
            {
                Name = "Stevie Ray Vaughan and Double Trouble",
                Genres = new List<Genre> { genres[0] },
                Recording = "The Sky Is Crying",
                Occasions = new List<Occasion> { occasions[7] },
                Numbers = ""
            },
            new Musician
            {
                Name = "Weather Report",
                Genres = new List<Genre> { genres[7] },
                Recording = "Heavy Weather",
                Occasions = new List<Occasion> { occasions[7] },
                Numbers = "573, 427, 481, 822, 784, 775, 564, 472, 398, 813, 721, 591"
            },
            new Musician
            {
                Name = "Alban Berg and Igor Stravinsky",
                Genres = new List<Genre> { genres[1] },
                Recording = "Alban Berg: Violin Concerto; Igor Stravinsky: Violin Concerto",
                Occasions = new List<Occasion> { occasions[9] },
                Numbers = "784, 142"
            },
            new Musician
            {
                Name = "Hector Berlioz",
                Genres = new List<Genre> { genres[1] },
                Recording = "Symphonie fantastique",
                Occasions = new List<Occasion> { occasions[9] },
                Numbers = "813"
            },
            new Musician
            {
                Name = "Aaron Copland",
                Genres = new List<Genre> { genres[1] },
                Recording = "Symphony No. 3",
                Occasions = new List<Occasion> { occasions[9] },
                Numbers = "187"
            },
            new Musician
            {
                Name = "Antonín Dvořák",
                Genres = new List<Genre> { genres[1] },
                Recording = "Symphony No. 9",
                Occasions = new List<Occasion> { occasions[9] },
                Numbers = "674"
            },
            new Musician
            {
                Name = "Gustav Holst",
                Genres = new List<Genre> { genres[1] },
                Recording = "The Planets",
                Occasions = new List<Occasion> { occasions[9] },
                Numbers = "977"
            },
            new Musician
            {
                Name = "Olivier Messiaen",
                Genres = new List<Genre> { genres[1] },
                Recording = "Quartet for the End of Time",
                Occasions = new List<Occasion> { occasions[9] },
                Numbers = "216"
            },
            new Musician
            {
                Name = "Giuseppe Verdi",
                Genres = new List<Genre> { genres[1] },
                Recording = "Requiem",
                Occasions = new List<Occasion> { occasions[9] },
                Numbers = "784"
            },
            new Musician
            {
                Name = "Kraftwerk",
                Genres = new List<Genre> { genres[3], genres[12] },
                Recording = "Trans-Europe Express",
                Occasions = new List<Occasion> { occasions[9] },
                Numbers = "986, 885, 216, 894, 941, 4, 555, 968, 867, 766, 326, 4"
            },
            new Musician
            {
                Name = "M83",
                Genres = new List<Genre> { genres[3] },
                Recording = "Dead Cities, Red Seas, and Lost Ghosts",
                Occasions = new List<Occasion> { occasions[9] },
                Numbers = "216, 766, 8, 5, 225"
            },
            new Musician
            {
                Name = "Neu!",
                Genres = new List<Genre> { genres[3] },
                Recording = "Neu! '75",
                Occasions = new List<Occasion> { occasions[9] },
                Numbers = "941, 555, 178, 546, 362"
            },
            new Musician
            {
                Name = "Paul Oakenfold",
                Genres = new List<Genre> { genres[3] },
                Recording = "Tranceport",
                Occasions = new List<Occasion> { occasions[9] },
                Numbers = "124"
            },
            new Musician
            {
                Name = "Tangerine Dream",
                Genres = new List<Genre> { genres[3], genres[12] },
                Recording = "Rubycon",
                Occasions = new List<Occasion> { occasions[9] },
                Numbers = "528, 1, 5, 279, 638, 867, 941, 297, 335, 472, 528, 216, 6, 353, 555, 481"
            },
            new Musician
            {
                Name = "Various Artists",
                Genres = new List<Genre> { genres[3] },
                Recording = "Trainspotting",
                Occasions = new List<Occasion> { occasions[9] },
                Numbers = ""
            },
            new Musician
            {
                Name = "Steeleye Span",
                Genres = new List<Genre> { genres[4] },
                Recording = "Parcel of Rogues",
                Occasions = new List<Occasion> { occasions[9] },
                Numbers = "858, 721, 6, 885, 582, 894, 528, 297, 822, 712, 582, 216, 766, 858"
            },
            new Musician
            {
                Name = "Dr. Dre",
                Genres = new List<Genre> { genres[6] },
                Recording = "The Chronic",
                Occasions = new List<Occasion> { occasions[9] },
                Numbers = "822"
            },
            new Musician
            {
                Name = "Eminem",
                Genres = new List<Genre> { genres[6] },
                Recording = "The Marshall Mathers LP",
                Occasions = new List<Occasion> { occasions[9] },
                Numbers = "196"
            },
            new Musician
            {
                Name = "The Notorious B.I.G.",
                Genres = new List<Genre> { genres[6] },
                Recording = "Ready to Die",
                Occasions = new List<Occasion> { occasions[9] },
                Numbers = "151"
            },
            new Musician
            {
                Name = "The Roots",
                Genres = new List<Genre> { genres[6] },
                Recording = "Phrenology",
                Occasions = new List<Occasion> { occasions[9] },
                Numbers = "243, 335, 977, 766, 8, 187, 546"
            },
            new Musician
            {
                Name = "Anthony Braxton",
                Genres = new List<Genre> { genres[7] },
                Recording = "For Alto",
                Occasions = new List<Occasion> { occasions[9] },
                Numbers = "151"
            },
            new Musician
            {
                Name = "Uri Caine",
                Genres = new List<Genre> { genres[7] },
                Recording = "Urlicht/Primal Light",
                Occasions = new List<Occasion> { occasions[9] },
                Numbers = "876"
            },
            new Musician
            {
                Name = "Don Cherry, Dewey Redman, Charlie Haden, and Ed Blackwell",
                Genres = new List<Genre> { genres[7] },
                Recording = "Old and New",
                Occasions = new List<Occasion> { occasions[9] },
                Numbers = "187, 629, 995, 831"
            },
            new Musician
            {
                Name = "Chick Corea and Return to Forever",
                Genres = new List<Genre> { genres[7] },
                Recording = "Light as a Feather",
                Occasions = new List<Occasion> { occasions[9] },
                Numbers = "573, 445, 647, 647, 418, 941, 564, 472, 169, 243, 133"
            },
            new Musician
            {
                Name = "Miles Davis",
                Genres = new List<Genre> { genres[7] },
                Recording = "Bitches Brew",
                Occasions = new List<Occasion> { occasions[9] },
                Numbers = "288"
            },
            new Musician
            {
                Name = "Dave Douglas",
                Genres = new List<Genre> { genres[7] },
                Recording = "Charms of the Night Sky",
                Occasions = new List<Occasion> { occasions[9] },
                Numbers = "178"
            },
            new Musician
            {
                Name = "Rahsaan Roland Kirk",
                Genres = new List<Genre> { genres[7] },
                Recording = "Volunteered Slavery",
                Occasions = new List<Occasion> { occasions[9] },
                Numbers = "261"
            },
            new Musician
            {
                Name = "Pat Martino",
                Genres = new List<Genre> { genres[7] },
                Recording = "Consciousness/Live!",
                Occasions = new List<Occasion> { occasions[9] },
                Numbers = "252"
            },
            new Musician
            {
                Name = "Jason Moran",
                Genres = new List<Genre> { genres[7] },
                Recording = "The Bandwagon",
                Occasions = new List<Occasion> { occasions[9] },
                Numbers = "894"
            },
            new Musician
            {
                Name = "Paul Motian",
                Genres = new List<Genre> { genres[7] },
                Recording = "On Broadway Vol. 1",
                Occasions = new List<Occasion> { occasions[9] },
                Numbers = "647"
            },
            new Musician
            {
                Name = "Sun Ra and His Arkestra",
                Genres = new List<Genre> { genres[7] },
                Recording = "Jazz in Silhouette",
                Occasions = new List<Occasion> { occasions[9] },
                Numbers = "582, 454, 674, 187"
            },
            new Musician
            {
                Name = "The Tony Williams Lifetime",
                Genres = new List<Genre> { genres[7] },
                Recording = "Emergency!",
                Occasions = new List<Occasion> { occasions[9] },
                Numbers = "178, 519, 674, 326, 995, 317, 169, 326, 775, 784, 932, 959, 638"
            },
            new Musician
            {
                Name = "Alban Berg",
                Genres = new List<Genre> { genres[9] },
                Recording = "Wozzeck",
                Occasions = new List<Occasion> { occasions[9] },
                Numbers = "784"
            },
            new Musician
            {
                Name = "Georges Bizet",
                Genres = new List<Genre> { genres[9] },
                Recording = "Carmen",
                Occasions = new List<Occasion> { occasions[9] },
                Numbers = "968"
            },
            new Musician
            {
                Name = "Philip Glass",
                Genres = new List<Genre> { genres[9] },
                Recording = "Einstein on the Beach",
                Occasions = new List<Occasion> { occasions[9] },
                Numbers = "169"
            },
            new Musician
            {
                Name = "Osvaldo Golijov",
                Genres = new List<Genre> { genres[9] },
                Recording = "Ainadamar",
                Occasions = new List<Occasion> { occasions[9] },
                Numbers = "481"
            },
            new Musician
            {
                Name = "Jean-Philippe Rameau",
                Genres = new List<Genre> { genres[9] },
                Recording = "Platée",
                Occasions = new List<Occasion> { occasions[9] },
                Numbers = "243"
            },
            new Musician
            {
                Name = "Kate Bush",
                Genres = new List<Genre> { genres[10] },
                Recording = "The Kick Inside",
                Occasions = new List<Occasion> { occasions[9] },
                Numbers = "692"
            },
            new Musician
            {
                Name = "Dr. John",
                Genres = new List<Genre> { genres[11] },
                Recording = "Gris-Gris",
                Occasions = new List<Occasion> { occasions[9] },
                Numbers = "528"
            },
            new Musician
            {
                Name = "Shuggie Otis",
                Genres = new List<Genre> { genres[11] },
                Recording = "Inspiration Information",
                Occasions = new List<Occasion> { occasions[9] },
                Numbers = "225"
            },
            new Musician
            {
                Name = "Bauhaus",
                Genres = new List<Genre> { genres[12] },
                Recording = "In the Flat Field",
                Occasions = new List<Occasion> { occasions[9] },
                Numbers = "739, 739, 436, 766"
            },
            new Musician
            {
                Name = "The Beatles",
                Genres = new List<Genre> { genres[12] },
                Recording = "Sgt. Pepper's Lonely Hearts Club Band",
                Occasions = new List<Occasion> { occasions[9] },
                Numbers = "665, 445, 611, 353, 528"
            },
            new Musician
            {
                Name = "The Beatles",
                Genres = new List<Genre> { genres[12] },
                Recording = "The Beatles (The White Album)",
                Occasions = new List<Occasion> { occasions[9] },
                Numbers = "665, 445, 611, 353, 528"
            },
            new Musician
            {
                Name = "The Beatles",
                Genres = new List<Genre> { genres[12] },
                Recording = "Abbey Road",
                Occasions = new List<Occasion> { occasions[9] },
                Numbers = "665, 445, 611, 353, 528"
            },
            new Musician
            {
                Name = "Beck",
                Genres = new List<Genre> { genres[12] },
                Recording = "Mutations",
                Occasions = new List<Occasion> { occasions[9] },
                Numbers = "398"
            },
            new Musician
            {
                Name = "Belle and Sebastian",
                Genres = new List<Genre> { genres[12] },
                Recording = "If You're Feeling Sinister",
                Occasions = new List<Occasion> { occasions[9] },
                Numbers = "555, 822, 398, 178, 591, 793, 638, 941"
            },
            new Musician
            {
                Name = "Björk",
                Genres = new List<Genre> { genres[12] },
                Recording = "Homogenic",
                Occasions = new List<Occasion> { occasions[9] },
                Numbers = "822"
            },
            new Musician
            {
                Name = "Blind Faith",
                Genres = new List<Genre> { genres[12] },
                Recording = "Blind Faith",
                Occasions = new List<Occasion> { occasions[9] },
                Numbers = "757, 178, 721, 196"
            },
            new Musician
            {
                Name = "David Bowie",
                Genres = new List<Genre> { genres[12] },
                Recording = "The Rise and Fall of Ziggy Stardust and the Spiders from Mars",
                Occasions = new List<Occasion> { occasions[9] },
                Numbers = "932"
            },
            new Musician
            {
                Name = "Jeff Buckley",
                Genres = new List<Genre> { genres[12] },
                Recording = "Grace",
                Occasions = new List<Occasion> { occasions[9] },
                Numbers = "784"
            },
            new Musician
            {
                Name = "David Byrne and Brian Eno",
                Genres = new List<Genre> { genres[12] },
                Recording = "My Life in the Bush of Ghosts",
                Occasions = new List<Occasion> { occasions[9] },
                Numbers = "326, 757"
            },
            new Musician
            {
                Name = "CAN",
                Genres = new List<Genre> { genres[12] },
                Recording = "Tago Mago",
                Occasions = new List<Occasion> { occasions[9] },
                Numbers = "766, 885, 923, 813, 2, 638, 766, 225"
            },
            new Musician
            {
                Name = "Captain Beefheart and His Magic Band",
                Genres = new List<Genre> { genres[12] },
                Recording = "Trout Mask Replica",
                Occasions = new List<Occasion> { occasions[9] },
                Numbers = "638, 546, 712, 629, 766, 692, 721, 243, 555, 335, 813, 326, 867, 932, 353"
            },
            new Musician
            {
                Name = "Cream",
                Genres = new List<Genre> { genres[12] },
                Recording = "Disraeli Gears",
                Occasions = new List<Occasion> { occasions[9] },
                Numbers = "721, 326, 178"
            },
            new Musician
            {
                Name = "The Cure",
                Genres = new List<Genre> { genres[12] },
                Recording = "The Head on the Door",
                Occasions = new List<Occasion> { occasions[9] },
                Numbers = "591, 454, 968, 766, 885, 656, 481, 591, 519, 638, 766, 427, 784"
            },
            new Musician
            {
                Name = "The Decemberists",
                Genres = new List<Genre> { genres[12] },
                Recording = "The Crane Wife",
                Occasions = new List<Occasion> { occasions[9] },
                Numbers = "849, 225, 216, 986, 481, 234"
            },
            new Musician
            {
                Name = "Derek and the Dominos",
                Genres = new List<Genre> { genres[12] },
                Recording = "Layla and Other Assorted Love Songs",
                Occasions = new List<Occasion> { occasions[9] },
                Numbers = "178, 775, 445, 133, 923, 959"
            },
            new Musician
            {
                Name = "The Doors",
                Genres = new List<Genre> { genres[12] },
                Recording = "The Doors",
                Occasions = new List<Occasion> { occasions[9] },
                Numbers = "344, 784, 169, 225"
            },
            new Musician
            {
                Name = "Emerson, Lake, and Palmer",
                Genres = new List<Genre> { genres[12] },
                Recording = "Brain Salad Surgery",
                Occasions = new List<Occasion> { occasions[9] },
                Numbers = "234, 822, 519"
            },
            new Musician
            {
                Name = "Brian Eno",
                Genres = new List<Genre> { genres[12] },
                Recording = "Another Green World",
                Occasions = new List<Occasion> { occasions[9] },
                Numbers = "757"
            },
            new Musician
            {
                Name = "Faust",
                Genres = new List<Genre> { genres[12] },
                Recording = "Faust/So Far",
                Occasions = new List<Occasion> { occasions[9] },
                Numbers = "5, 629, 9, 4, 2, 546"
            },
            new Musician
            {
                Name = "The Flaming Lips",
                Genres = new List<Genre> { genres[12] },
                Recording = "The Soft Bulletin",
                Occasions = new List<Occasion> { occasions[9] },
                Numbers = "463, 178, 445, 225, 757, 914"
            },
            new Musician
            {
                Name = "Peter Gabriel",
                Genres = new List<Genre> { genres[12] },
                Recording = "Peter Gabriel 3",
                Occasions = new List<Occasion> { occasions[9] },
                Numbers = "528"
            },
            new Musician
            {
                Name = "Genesis",
                Genres = new List<Genre> { genres[12] },
                Recording = "The Lamb Lies Down on Broadwa",
                Occasions = new List<Occasion> { occasions[9] },
                Numbers = "519, 546, 591, 528, 472, 472, 5, 813, 528, 546"
            },
            new Musician
            {
                Name = "Gong",
                Genres = new List<Genre> { genres[12] },
                Recording = "Gazeuse!",
                Occasions = new List<Occasion> { occasions[9] },
                Numbers = "463, 4, 225, 932, 454, 463, 629"
            },
            new Musician
            {
                Name = "Jimi Hendrix",
                Genres = new List<Genre> { genres[12] },
                Recording = "Band of Gypsys",
                Occasions = new List<Occasion> { occasions[9] },
                Numbers = "481"
            },
            new Musician
            {
                Name = "The Jesus and Mary Chain",
                Genres = new List<Genre> { genres[12] },
                Recording = "Psychocandy",
                Occasions = new List<Occasion> { occasions[9] },
                Numbers = "344, 665, 894, 279, 573, 335, 941"
            },
            new Musician
            {
                Name = "Joy Division",
                Genres = new List<Genre> { genres[12] },
                Recording = "Unknown Pleasures",
                Occasions = new List<Occasion> { occasions[9] },
                Numbers = "867, 941, 822, 793"
            },
            new Musician
            {
                Name = "King Crimson",
                Genres = new List<Genre> { genres[12] },
                Recording = "In the Court of the Crimson King",
                Occasions = new List<Occasion> { occasions[9] },
                Numbers = "923, 858, 914, 977, 151, 611, 115, 344, 822, 481, 914, 932, 977, 995, 629, 611, 638, 647"
            },
            new Musician
            {
                Name = "The Magnetic Fields",
                Genres = new List<Genre> { genres[12] },
                Recording = "Sixty-nine Love Songs",
                Occasions = new List<Occasion> { occasions[9] },
                Numbers = "822, 519, 463"
            },
            new Musician
            {
                Name = "The Mars Volta",
                Genres = new List<Genre> { genres[12] },
                Recording = "The Bedlam in Goliath",
                Occasions = new List<Occasion> { occasions[9] },
                Numbers = "721, 831, 124, 849, 537, 822, 638, 739, 353, 353, 234"
            },
            new Musician
            {
                Name = "Sarah McLachlan",
                Genres = new List<Genre> { genres[12] },
                Recording = "Surfacing",
                Occasions = new List<Occasion> { occasions[9] },
                Numbers = "638"
            },
            new Musician
            {
                Name = "My Bloody Valentine",
                Genres = new List<Genre> { genres[12] },
                Recording = "Loveless",
                Occasions = new List<Occasion> { occasions[9] },
                Numbers = "151, 968, 234, 371, 1"
            },
            new Musician
            {
                Name = "Nine Inch Nails",
                Genres = new List<Genre> { genres[12] },
                Recording = "The Downward Spiral",
                Occasions = new List<Occasion> { occasions[9] },
                Numbers = "885, 638, 234, 629, 317, 656, 582, 225, 712, 344, 142, 243, 436, 279, 344, 178, 932, 344, 564, 793, 656"
            },
            new Musician
            {
                Name = "Queen",
                Genres = new List<Genre> { genres[12] },
                Recording = "A Night at the Opera",
                Occasions = new List<Occasion> { occasions[9] },
                Numbers = "867, 692, 986, 427"
            },
            new Musician
            {
                Name = "Lou Reed",
                Genres = new List<Genre> { genres[12] },
                Recording = "New York",
                Occasions = new List<Occasion> { occasions[9] },
                Numbers = "481"
            },
            new Musician
            {
                Name = "Todd Rundgren",
                Genres = new List<Genre> { genres[12] },
                Recording = "Something/Anything?",
                Occasions = new List<Occasion> { occasions[9] },
                Numbers = "748"
            },
            new Musician
            {
                Name = "Sigur Rós",
                Genres = new List<Genre> { genres[12] },
                Recording = "Ágætis byrjun",
                Occasions = new List<Occasion> { occasions[9] },
                Numbers = "766, 638, 674, 519, 573"
            },
            new Musician
            {
                Name = "Spiritualized",
                Genres = new List<Genre> { genres[12] },
                Recording = "Ladies and Gentlemen We Are Floating in Space",
                Occasions = new List<Occasion> { occasions[9] },
                Numbers = "822, 656, 656, 638, 656, 923"
            },
            new Musician
            {
                Name = "Stereolab",
                Genres = new List<Genre> { genres[12] },
                Recording = "Emperor Tomato Ketchup",
                Occasions = new List<Occasion> { occasions[9] },
                Numbers = "995, 582, 793, 591"
            },
            new Musician
            {
                Name = "The Velvet Underground",
                Genres = new List<Genre> { genres[12] },
                Recording = "The Velvet Underground and Nico",
                Occasions = new List<Occasion> { occasions[9] },
                Numbers = "481, 472, 427, 813, 252, 822, 995, 463"
            },
            new Musician
            {
                Name = "Tom Waits",
                Genres = new List<Genre> { genres[12] },
                Recording = "Rain Dogs",
                Occasions = new List<Occasion> { occasions[9] },
                Numbers = "656"
            },
            new Musician
            {
                Name = "Wilco",
                Genres = new List<Genre> { genres[12] },
                Recording = "Yankee Hotel Foxtrot",
                Occasions = new List<Occasion> { occasions[9] },
                Numbers = "683, 656, 344, 151, 941, 445, 398, 187"
            },
            new Musician
            {
                Name = "Yes",
                Genres = new List<Genre> { genres[12] },
                Recording = "The Yes Album",
                Occasions = new List<Occasion> { occasions[9] },
                Numbers = "894, 611, 389, 813, 335, 234, 784, 867, 629, 297, 629, 748, 692, 297, 932, 867, 187, 766"
            },
            new Musician
            {
                Name = "The Zombies",
                Genres = new List<Genre> { genres[12] },
                Recording = "Odessey and Oracle",
                Occasions = new List<Occasion> { occasions[9] },
                Numbers = "142, 142, 941, 178, 344, 573, 151"
            },
            new Musician
            {
                Name = "Juana Molina",
                Genres = new List<Genre> { genres[14], genres[18] },
                Recording = "Segundo",
                Occasions = new List<Occasion> { occasions[9] },
                Numbers = "371"
            },
            new Musician
            {
                Name = "Lô Borges",
                Genres = new List<Genre> { genres[14], genres[20] },
                Recording = "Lô Borges",
                Occasions = new List<Occasion> { occasions[9] },
                Numbers = "463"
            },
            new Musician
            {
                Name = "Os Mutantes",
                Genres = new List<Genre> { genres[14], genres[20] },
                Recording = "Mutantes",
                Occasions = new List<Occasion> { occasions[9] },
                Numbers = "528, 748, 813, 4, 968, 8"
            },
            new Musician
            {
                Name = "Hermeto Pascoal",
                Genres = new List<Genre> { genres[14], genres[20] },
                Recording = "Slaves Mass",
                Occasions = new List<Occasion> { occasions[9] },
                Numbers = "142"
            },
            new Musician
            {
                Name = "Tom Zé",
                Genres = new List<Genre> { genres[14], genres[20] },
                Recording = "Fabrication Defect",
                Occasions = new List<Occasion> { occasions[9] },
                Numbers = "196"
            },
            new Musician
            {
                Name = "Lee 'Scratch' Perry",
                Genres = new List<Genre> { genres[14], genres[42] },
                Recording = "Arkology",
                Occasions = new List<Occasion> { occasions[9] },
                Numbers = "178"
            },
            new Musician
            {
                Name = "Eddie Palmieri",
                Genres = new List<Genre> { genres[14], genres[45] },
                Recording = "Eddie Palmieri",
                Occasions = new List<Occasion> { occasions[9] },
                Numbers = "178"
            },
            new Musician
            {
                Name = "Love",
                Genres = new List<Genre> { genres[12] },
                Recording = "Forever Changes",
                Occasions = new List<Occasion> { occasions[9] },
                Numbers = "822, 178, 977, 344"
            },
            new Musician
            {
                Name = "Wu-Tang Clan",
                Genres = new List<Genre> { genres[6] },
                Recording = "Enter the Wu-Tang (36 Chambers)",
                Occasions = new List<Occasion> { occasions[9] },
                Numbers = "445, 721, 317, 353, 389, 225, 463, 427, 528"
            },
            new Musician
            {
                Name = "Big Bill Broonzy",
                Genres = new List<Genre> { genres[0] },
                Recording = "The Young Big Bill Broonzy, 1928-1935",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "748"
            },
            new Musician
            {
                Name = "Buddy Guy",
                Genres = new List<Genre> { genres[0] },
                Recording = "Damn Right, I've Got the Blues",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "133"
            },
            new Musician
            {
                Name = "Tommy Johnson",
                Genres = new List<Genre> { genres[0] },
                Recording = "Complete Recorded Works in Chronological Order",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "638"
            },
            new Musician
            {
                Name = "Junior Kimbrough",
                Genres = new List<Genre> { genres[0] },
                Recording = "All Night Long",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "739"
            },
            new Musician
            {
                Name = "Memphis Minnie",
                Genres = new List<Genre> { genres[0] },
                Recording = "Hoodoo Lady, 1933-1937",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "454"
            },
            new Musician
            {
                Name = "The Mississippi Sheiks",
                Genres = new List<Genre> { genres[0] },
                Recording = "Honey Babe Let the Deal Go Down",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "876, 591"
            },
            new Musician
            {
                Name = "Charley Patton",
                Genres = new List<Genre> { genres[0] },
                Recording = "Founder of the Delta Blues",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "169"
            },
            new Musician
            {
                Name = "Various Artists",
                Genres = new List<Genre> { genres[0], genres[7] },
                Recording = "From Spirituals to Swing",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = ""
            },
            new Musician
            {
                Name = "Ma Rainey",
                Genres = new List<Genre> { genres[0] },
                Recording = "Ma Rainey's Black Bottom",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "638"
            },
            new Musician
            {
                Name = "Sonny Boy Williamson II",
                Genres = new List<Genre> { genres[0] },
                Recording = "One Way Out",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "784"
            },
            new Musician
            {
                Name = "J. S. Bach",
                Genres = new List<Genre> { genres[1] },
                Recording = "Volume 1 (Florentino)",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "941"
            },
            new Musician
            {
                Name = "Béla Bartók and Pyotr Ilyich Tchaikovsky",
                Genres = new List<Genre> { genres[1] },
                Recording = "Bartók: Concerto No. 3 for Piano and Orchestra; Tchaikovsky: Symphony No. 6",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "216, 757"
            },
            new Musician
            {
                Name = "Ludwig van Beethoven",
                Genres = new List<Genre> { genres[1] },
                Recording = "Piano Concertos Nos. 1-5",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "519"
            },
            new Musician
            {
                Name = "Luciano Berio",
                Genres = new List<Genre> { genres[1] },
                Recording = "Sinfonia for Eight Voices and Orchestra",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "362"
            },
            new Musician
            {
                Name = "Johannes Brahms",
                Genres = new List<Genre> { genres[1] },
                Recording = "The Four Symphonies",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "582"
            },
            new Musician
            {
                Name = "Anton Bruckner",
                Genres = new List<Genre> { genres[1] },
                Recording = "Symphony No. 7 in E",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "555"
            },
            new Musician
            {
                Name = "Max Bruch",
                Genres = new List<Genre> { genres[1] },
                Recording = "Violin Concerto No. 1",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "169"
            },
            new Musician
            {
                Name = "William Byrd",
                Genres = new List<Genre> { genres[1] },
                Recording = "Harpsichord Music",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "7"
            },
            new Musician
            {
                Name = "Elliott Carter",
                Genres = new List<Genre> { genres[1] },
                Recording = "Symphonia: Sum fluxae pretium spei, Clarinet Concerto",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "216"
            },
            new Musician
            {
                Name = "Enrico Caruso",
                Genres = new List<Genre> { genres[1] },
                Recording = "Twenty-one Favorite Arias",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "187"
            },
            new Musician
            {
                Name = "Regine Crespin",
                Genres = new List<Genre> { genres[1] },
                Recording = "Crespin Sings Berlioz and Ravel",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "187, 813, 813"
            },
            new Musician
            {
                Name = "George Crumb",
                Genres = new List<Genre> { genres[1] },
                Recording = "Black Angels",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "831"
            },
            new Musician
            {
                Name = "Henri Dutilleux",
                Genres = new List<Genre> { genres[1] },
                Recording = "Cello Concerto 'Tout un monde lointain'",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "463"
            },
            new Musician
            {
                Name = "Edward Elgar",
                Genres = new List<Genre> { genres[1] },
                Recording = "Cello Concerto",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "885"
            },
            new Musician
            {
                Name = "Edward Elgar",
                Genres = new List<Genre> { genres[1] },
                Recording = "Symphony No. 1",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "885"
            },
            new Musician
            {
                Name = "Manuel de Falla",
                Genres = new List<Genre> { genres[1] },
                Recording = "El sombrero de tres picos",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "784"
            },
            new Musician
            {
                Name = "George Frideric Handel",
                Genres = new List<Genre> { genres[1] },
                Recording = "Water Music, Music for Royal Fireworks",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "959"
            },
            new Musician
            {
                Name = "Franz Josef Haydn",
                Genres = new List<Genre> { genres[1] },
                Recording = "Twelve London Symphonies",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "775"
            },
            new Musician
            {
                Name = "Bernard Herrmann",
                Genres = new List<Genre> { genres[1] },
                Recording = "Psycho",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "876"
            },
            new Musician
            {
                Name = "Edouard Lalo",
                Genres = new List<Genre> { genres[1] },
                Recording = "Symphonie espagnole",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "766"
            },
            new Musician
            {
                Name = "Guillaume de Machaut",
                Genres = new List<Genre> { genres[1] },
                Recording = "Motets",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "7"
            },
            new Musician
            {
                Name = "Gustav Mahler",
                Genres = new List<Genre> { genres[1] },
                Recording = "Symphony No. 4",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "573"
            },
            new Musician
            {
                Name = "Nicholas Maw",
                Genres = new List<Genre> { genres[1] },
                Recording = "Violin Concerto",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "234"
            },
            new Musician
            {
                Name = "Felix Mendelssohn",
                Genres = new List<Genre> { genres[1] },
                Recording = "Violin Concerto",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "335"
            },
            new Musician
            {
                Name = "Claudio Monteverdi",
                Genres = new List<Genre> { genres[1] },
                Recording = "Vespers of the Blessed Virgin 1610",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "151"
            },
            new Musician
            {
                Name = "Wolfgang Amadeus Mozart",
                Genres = new List<Genre> { genres[1] },
                Recording = "The Late Symphonies",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "297"
            },
            new Musician
            {
                Name = "Sergey Prokofiev",
                Genres = new List<Genre> { genres[1] },
                Recording = "Romeo and Juliet, op. 64, 617",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "169"
            },
            new Musician
            {
                Name = "Maurice Ravel",
                Genres = new List<Genre> { genres[1] },
                Recording = "Piano Concerto in G",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "813"
            },
            new Musician
            {
                Name = "Nikolai Rimsky-Korsakov",
                Genres = new List<Genre> { genres[1] },
                Recording = "Scheherazade",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "344"
            },
            new Musician
            {
                Name = "Domenico Scarlatti",
                Genres = new List<Genre> { genres[1] },
                Recording = "Eleven Sonatas",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "968"
            },
            new Musician
            {
                Name = "Arnold Schoenberg",
                Genres = new List<Genre> { genres[1] },
                Recording = "Gurrelieder",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "977"
            },
            new Musician
            {
                Name = "Franz Schubert",
                Genres = new List<Genre> { genres[1] },
                Recording = "Twelve lieder, Moments musicaux",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "638"
            },
            new Musician
            {
                Name = "Dmitri Shostakovich",
                Genres = new List<Genre> { genres[1] },
                Recording = "Symphony No. 5",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "418"
            },
            new Musician
            {
                Name = "Dmitri Shostakovich",
                Genres = new List<Genre> { genres[1] },
                Recording = "Violin Concerto No. 1, Cello Concerto No. 1",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "418"
            },
            new Musician
            {
                Name = "Jean Sibelius",
                Genres = new List<Genre> { genres[1] },
                Recording = "Symphony No. 5, Symphony No. 7",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "941"
            },
            new Musician
            {
                Name = "Bedřich Smetana",
                Genres = new List<Genre> { genres[1] },
                Recording = "Má vlast",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "528"
            },
            new Musician
            {
                Name = "Johann Strauss II",
                Genres = new List<Genre> { genres[1] },
                Recording = "Die Fledermaus, New Year's Concert",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "499"
            },
            new Musician
            {
                Name = "Igor Stravinsky",
                Genres = new List<Genre> { genres[1] },
                Recording = "Violin Concerto",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "142"
            },
            new Musician
            {
                Name = "Pyotr Ilyich Tchaikovsky",
                Genres = new List<Genre> { genres[1] },
                Recording = "Violin Concertos",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "757"
            },
            new Musician
            {
                Name = "Edgar Varèse",
                Genres = new List<Genre> { genres[1] },
                Recording = "The Complete Works",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "941"
            },
            new Musician
            {
                Name = "Kevin Volans",
                Genres = new List<Genre> { genres[1] },
                Recording = "Hunting: Gathering",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "611"
            },
            new Musician
            {
                Name = "William Walton",
                Genres = new List<Genre> { genres[1] },
                Recording = "Symphony No. 1, Belshazzar's Feast",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "813"
            },
            new Musician
            {
                Name = "Ray Charles",
                Genres = new List<Genre> { genres[2] },
                Recording = "Modern Sounds in Country, Western, Vols. 1 and 2",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "712"
            },
            new Musician
            {
                Name = "Narvel Felts",
                Genres = new List<Genre> { genres[2] },
                Recording = "Drift Away: The Best of Narvel Felts, 1973-1979",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "822"
            },
            new Musician
            {
                Name = "Lefty Frizzell",
                Genres = new List<Genre> { genres[2] },
                Recording = "Look What Thoughts Can Do",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "941"
            },
            new Musician
            {
                Name = "Tom T. Hall",
                Genres = new List<Genre> { genres[2] },
                Recording = "In Search of a Song",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "151"
            },
            new Musician
            {
                Name = "Willie Nelson",
                Genres = new List<Genre> { genres[2] },
                Recording = "Red Headed Stranger",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "463"
            },
            new Musician
            {
                Name = "Buck Owens",
                Genres = new List<Genre> { genres[2] },
                Recording = "Buck Owens Sings Harlan Howard",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "858"
            },
            new Musician
            {
                Name = "Johnny Paycheck",
                Genres = new List<Genre> { genres[2] },
                Recording = "On His Way",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "885"
            },
            new Musician
            {
                Name = "Charlie Poole",
                Genres = new List<Genre> { genres[2] },
                Recording = "You Ain't Talkin' to Me: Charlie Poole and the Roots of Country Music",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "941"
            },
            new Musician
            {
                Name = "Willis Alan Ramsey",
                Genres = new List<Genre> { genres[2] },
                Recording = "Willis Alan Ramsey",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "481"
            },
            new Musician
            {
                Name = "Jimmy Sturr and His Orchestra",
                Genres = new List<Genre> { genres[2] },
                Recording = "Polkapalooza",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "546"
            },
            new Musician
            {
                Name = "Ernest Tubb",
                Genres = new List<Genre> { genres[2] },
                Recording = "The Definitive Collection",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "528"
            },
            new Musician
            {
                Name = "Townes Van Zandt",
                Genres = new List<Genre> { genres[2] },
                Recording = "Live at the Old Quarter",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "216"
            },
            new Musician
            {
                Name = "Various Artists",
                Genres = new List<Genre> { genres[2] },
                Recording = "Great American Train Songs",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = ""
            },
            new Musician
            {
                Name = "Bob Wills and His Texas Playboys",
                Genres = new List<Genre> { genres[2] },
                Recording = "The Tiffany Transcriptions, Vols. 2 and 3",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "519"
            },
            new Musician
            {
                Name = "Faron Young",
                Genres = new List<Genre> { genres[2] },
                Recording = "The Complete Capitol Hits of Faron Young",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "528"
            },
            new Musician
            {
                Name = "The Chemical Brothers",
                Genres = new List<Genre> { genres[3] },
                Recording = "Dig Your Own Hole",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "335, 317"
            },
            new Musician
            {
                Name = "Joan Baez",
                Genres = new List<Genre> { genres[4] },
                Recording = "Joan Baez",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "638"
            },
            new Musician
            {
                Name = "Peter Bellamy",
                Genres = new List<Genre> { genres[4] },
                Recording = "The Transports",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "243"
            },
            new Musician
            {
                Name = "Tim Buckley",
                Genres = new List<Genre> { genres[4], genres[12] },
                Recording = "Dream Letter: Live in London, 1968",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "822"
            },
            new Musician
            {
                Name = "Martin Carthy with Dave Swarbrick",
                Genres = new List<Genre> { genres[4] },
                Recording = "Byker Hill",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "582, 519"
            },
            new Musician
            {
                Name = "Tom Rush",
                Genres = new List<Genre> { genres[4] },
                Recording = "The Circle Game",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "528"
            },
            new Musician
            {
                Name = "Michelle Shocked",
                Genres = new List<Genre> { genres[4] },
                Recording = "Short Sharp Shocked",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "225"
            },
            new Musician
            {
                Name = "Dave Van Ronk",
                Genres = new List<Genre> { genres[4] },
                Recording = "Inside Dave Van Ronk",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "142"
            },
            new Musician
            {
                Name = "The Dixie Hummingbirds",
                Genres = new List<Genre> { genres[5] },
                Recording = "Thank You for One More Day",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "986, 656, 317, 326, 537, 436, 499, 353"
            },
            new Musician
            {
                Name = "Bessie Griffin and the Gospel Pearls",
                Genres = new List<Genre> { genres[5] },
                Recording = "Recorded Live at 'The Bear' in Chicago",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "611"
            },
            new Musician
            {
                Name = "Little Richard",
                Genres = new List<Genre> { genres[5] },
                Recording = "Sings the Gospel",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "528"
            },
            new Musician
            {
                Name = "The Clara Ward Singers",
                Genres = new List<Genre> { genres[5] },
                Recording = "Take My Hand, Precious LordMarion Williams, Strong Again",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "463"
            },
            new Musician
            {
                Name = "Boogie Down Productions",
                Genres = new List<Genre> { genres[6] },
                Recording = "By All Means Necessary",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "858, 317, 225"
            },
            new Musician
            {
                Name = "Cypress Hill",
                Genres = new List<Genre> { genres[6] },
                Recording = "Black Sunday",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "326, 638, 822, 555, 638"
            },
            new Musician
            {
                Name = "Danger Mouse",
                Genres = new List<Genre> { genres[6] },
                Recording = "The Grey Album",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "564"
            },
            new Musician
            {
                Name = "Eric B. and Rakim",
                Genres = new List<Genre> { genres[6] },
                Recording = "Paid in Full",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "187, 638"
            },
            new Musician
            {
                Name = "Mos Def and Talib Kweli",
                Genres = new List<Genre> { genres[6] },
                Recording = "Mos Def and Talib Kweli Are Black Star",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "941, 712"
            },
            new Musician
            {
                Name = "N.W.A.",
                Genres = new List<Genre> { genres[6] },
                Recording = "Straight Outta Compton",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "876, 647, 822, 986, 445, 445, 234"
            },
            new Musician
            {
                Name = "Orishas",
                Genres = new List<Genre> { genres[6] },
                Recording = "Antidiotico",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "674, 288, 151"
            },
            new Musician
            {
                Name = "Slum Village",
                Genres = new List<Genre> { genres[6] },
                Recording = "Fantastic, Vol. 1",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "712, 822, 454, 537, 813"
            },
            new Musician
            {
                Name = "2Pac",
                Genres = new List<Genre> { genres[6] },
                Recording = "All Eyez on Me",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "279"
            },
            new Musician
            {
                Name = "The Muhal Richard Abrams Orchestra",
                Genres = new List<Genre> { genres[7] },
                Recording = "Blu Blu Blu",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "712"
            },
            new Musician
            {
                Name = "Air",
                Genres = new List<Genre> { genres[7] },
                Recording = "Air Lore",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "472, 427"
            },
            new Musician
            {
                Name = "Art Ensemble of Chicago",
                Genres = new List<Genre> { genres[7] },
                Recording = "Urban Bushmen",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "692, 923, 537, 124, 977, 546, 178"
            },
            new Musician
            {
                Name = "Albert Ayler",
                Genres = new List<Genre> { genres[7] },
                Recording = "Spiritual Unity",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "133"
            },
            new Musician
            {
                Name = "Billy Bean",
                Genres = new List<Genre> { genres[7] },
                Recording = "The Trio: Rediscovered",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "923"
            },
            new Musician
            {
                Name = "Sidney Bechet",
                Genres = new List<Genre> { genres[7] },
                Recording = "Sidney Bechet: Ken Burns Jazz",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "454"
            },
            new Musician
            {
                Name = "Bix Beiderbecke",
                Genres = new List<Genre> { genres[7] },
                Recording = "Singin' the Blues, Vol. 1",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "775"
            },
            new Musician
            {
                Name = "Oscar Brown Jr.",
                Genres = new List<Genre> { genres[7], genres[13] },
                Recording = "Sin and Soul",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "234"
            },
            new Musician
            {
                Name = "Ornette Coleman",
                Genres = new List<Genre> { genres[7] },
                Recording = "The Shape of Jazz to Come",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "775"
            },
            new Musician
            {
                Name = "John Coltrane",
                Genres = new List<Genre> { genres[7] },
                Recording = "Blue Train",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "243"
            },
            new Musician
            {
                Name = "Eric Dolphy",
                Genres = new List<Genre> { genres[7] },
                Recording = "Out to Lunch",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "914"
            },
            new Musician
            {
                Name = "Duke Ellington",
                Genres = new List<Genre> { genres[7] },
                Recording = "Far East Suite",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "297"
            },
            new Musician
            {
                Name = "Joe Harriott Double Quintet",
                Genres = new List<Genre> { genres[7] },
                Recording = "Indo-Jazz Suite",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "995"
            },
            new Musician
            {
                Name = "Fletcher Henderson",
                Genres = new List<Genre> { genres[7] },
                Recording = "A Study in Frustration",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "472"
            },
            new Musician
            {
                Name = "Dave Holland",
                Genres = new List<Genre> { genres[7] },
                Recording = "Conference of the Birds",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "977"
            },
            new Musician
            {
                Name = "Eddie Jefferson",
                Genres = new List<Genre> { genres[7], genres[13] },
                Recording = "The Jazz Singer",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "133"
            },
            new Musician
            {
                Name = "James P. Johnson",
                Genres = new List<Genre> { genres[7] },
                Recording = "The Original James P. Johnson",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "894"
            },
            new Musician
            {
                Name = "Scott Joplin",
                Genres = new List<Genre> { genres[7] },
                Recording = "Elite Syncopations",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "656"
            },
            new Musician
            {
                Name = "Lambert, Hendricks, and Ross",
                Genres = new List<Genre> { genres[7], genres[13] },
                Recording = "The Hottest New Group in Jazz",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "279, 712, 739, 454, 959, 225"
            },
            new Musician
            {
                Name = "Michel Legrand",
                Genres = new List<Genre> { genres[7] },
                Recording = "Legrand Jazz",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "528"
            },
            new Musician
            {
                Name = "Moondog",
                Genres = new List<Genre> { genres[7] },
                Recording = "The Viking of Sixth Avenue",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "326"
            },
            new Musician
            {
                Name = "Jelly Roll Morton",
                Genres = new List<Genre> { genres[7] },
                Recording = "Birth of the Hot",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "234"
            },
            new Musician
            {
                Name = "Lalo Schifrin",
                Genres = new List<Genre> { genres[7] },
                Recording = "Bullitt",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "573"
            },
            new Musician
            {
                Name = "Sonny Sharrock",
                Genres = new List<Genre> { genres[7] },
                Recording = "Ask the Ages",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "683"
            },
            new Musician
            {
                Name = "Wayne Shorter",
                Genres = new List<Genre> { genres[7] },
                Recording = "Juju",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "427"
            },
            new Musician
            {
                Name = "Jimmy Smith",
                Genres = new List<Genre> { genres[7] },
                Recording = "Back at the Chicken Shack",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "941"
            },
            new Musician
            {
                Name = "Carl Stalling",
                Genres = new List<Genre> { genres[7] },
                Recording = "The Carl Stalling Project",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "187"
            },
            new Musician
            {
                Name = "Cecil Taylor",
                Genres = new List<Genre> { genres[7] },
                Recording = "Silent Tongues",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "813"
            },
            new Musician
            {
                Name = "Leon Thomas",
                Genres = new List<Genre> { genres[7], genres[13] },
                Recording = "Spirits Known and Unknown",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "977"
            },
            new Musician
            {
                Name = "Larry Young",
                Genres = new List<Genre> { genres[7] },
                Recording = "Unity",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "674"
            },
            new Musician
            {
                Name = "Vernon Duke and Ira Gershwin",
                Genres = new List<Genre> { genres[8] },
                Recording = "The Ziegfeld Follies of 1936",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "793, 528"
            },
            new Musician
            {
                Name = "Oscar Hammerstein II and Jerome Kern",
                Genres = new List<Genre> { genres[8] },
                Recording = "Show Boat",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "692, 894"
            },
            new Musician
            {
                Name = "John Kander and Fred Ebb",
                Genres = new List<Genre> { genres[8] },
                Recording = "Chicago",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "178, 932"
            },
            new Musician
            {
                Name = "Alan Jay Lerner and Frederick Loewe",
                Genres = new List<Genre> { genres[8] },
                Recording = "My Fair Lady",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "124, 914"
            },
            new Musician
            {
                Name = "Cole Porter",
                Genres = new List<Genre> { genres[8] },
                Recording = "Anything Goes",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "142"
            },
            new Musician
            {
                Name = "Jule Styne and Bob Merrill",
                Genres = new List<Genre> { genres[8] },
                Recording = "Funny Girl",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "519, 757"
            },
            new Musician
            {
                Name = "Various Artists",
                Genres = new List<Genre> { genres[8], genres[13] },
                Recording = "Stormy Weather",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = ""
            },
            new Musician
            {
                Name = "Andrew Lloyd Webber and Tim Rice",
                Genres = new List<Genre> { genres[8] },
                Recording = "Jesus Christ Superstar",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "775, 225"
            },
            new Musician
            {
                Name = "Kurt Weill and Bertolt Brecht",
                Genres = new List<Genre> { genres[8] },
                Recording = "The Seven Deadly Sins",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "187, 353"
            },
            new Musician
            {
                Name = "John Adams",
                Genres = new List<Genre> { genres[9] },
                Recording = "The Death of Klinghoffer",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "822"
            },
            new Musician
            {
                Name = "Vincenzo Bellini",
                Genres = new List<Genre> { genres[9] },
                Recording = "Norma",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "196"
            },
            new Musician
            {
                Name = "Hector Berlioz",
                Genres = new List<Genre> { genres[9] },
                Recording = "Les Troyens",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "813"
            },
            new Musician
            {
                Name = "Benjamin Britten",
                Genres = new List<Genre> { genres[9] },
                Recording = "Peter Grimes",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "656"
            },
            new Musician
            {
                Name = "Emmanuel Chabrier",
                Genres = new List<Genre> { genres[9] },
                Recording = "Le roi malgré lui",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "766"
            },
            new Musician
            {
                Name = "Marc-Antoine Charpentier",
                Genres = new List<Genre> { genres[9] },
                Recording = "Médée Claude",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "6"
            },
            new Musician
            {
                Name = "Debussy",
                Genres = new List<Genre> { genres[9] },
                Recording = "Pelléas et Mélisande",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "389"
            },
            new Musician
            {
                Name = "Gilbert and Sullivan",
                Genres = new List<Genre> { genres[9] },
                Recording = "The Mikado",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "225, 582"
            },
            new Musician
            {
                Name = "George Frideric Handel",
                Genres = new List<Genre> { genres[9] },
                Recording = "Giulio Cesare",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "959"
            },
            new Musician
            {
                Name = "Bohuslav Martin",
                Genres = new List<Genre> { genres[9] },
                Recording = "Julietta",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "216"
            },
            new Musician
            {
                Name = "Jules Massenet",
                Genres = new List<Genre> { genres[9] },
                Recording = "Manon",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "582"
            },
            new Musician
            {
                Name = "Douglas Moore and John Latouche",
                Genres = new List<Genre> { genres[9] },
                Recording = "The Ballad of Baby Doe",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "858, 528"
            },
            new Musician
            {
                Name = "Wolfgang Amadeus Mozart",
                Genres = new List<Genre> { genres[9] },
                Recording = "The Marriage of Figaro",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "297"
            },
            new Musician
            {
                Name = "Modest Mussorgsky",
                Genres = new List<Genre> { genres[9] },
                Recording = "Boris Godunov",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "813"
            },
            new Musician
            {
                Name = "Giacomo Puccini",
                Genres = new List<Genre> { genres[9] },
                Recording = "La bohème",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "775"
            },
            new Musician
            {
                Name = "Giacomo Puccini",
                Genres = new List<Genre> { genres[9] },
                Recording = "Turandot",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "775"
            },
            new Musician
            {
                Name = "Maurice Ravel",
                Genres = new List<Genre> { genres[9] },
                Recording = "L'heure espagnole, L'enfant et les sortilèges",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "813"
            },
            new Musician
            {
                Name = "Richard Strauss",
                Genres = new List<Genre> { genres[9] },
                Recording = "Elektra",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "142"
            },
            new Musician
            {
                Name = "Richard Strauss",
                Genres = new List<Genre> { genres[9] },
                Recording = "Der Rosenkavalier",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "142"
            },
            new Musician
            {
                Name = "Giuseppe Verdi",
                Genres = new List<Genre> { genres[9] },
                Recording = "Aida",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "793"
            },
            new Musician
            {
                Name = "Giuseppe Verdi",
                Genres = new List<Genre> { genres[9] },
                Recording = "Falstaff",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "793"
            },
            new Musician
            {
                Name = "Richard Wagner",
                Genres = new List<Genre> { genres[9] },
                Recording = "Tristan und Isolde",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "757"
            },
            new Musician
            {
                Name = "Richard Wagner",
                Genres = new List<Genre> { genres[9] },
                Recording = "Die Walküre",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "757"
            },
            new Musician
            {
                Name = "Neil Diamond",
                Genres = new List<Genre> { genres[10] },
                Recording = "Hot August Night",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "638"
            },
            new Musician
            {
                Name = "The Shangri-Las",
                Genres = new List<Genre> { genres[10] },
                Recording = "'Leader of the Pack'",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "775, 784, 959, 784"
            },
            new Musician
            {
                Name = "Dionne Warwick",
                Genres = new List<Genre> { genres[10], genres[13] },
                Recording = "The Dionne Warwick Collection",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "647"
            },
            new Musician
            {
                Name = "Ruth Brown",
                Genres = new List<Genre> { genres[11] },
                Recording = "Miss Rhythm",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "169"
            },
            new Musician
            {
                Name = "Doris Duke",
                Genres = new List<Genre> { genres[11] },
                Recording = "I'm a Loser",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "784"
            },
            new Musician
            {
                Name = "Snooks Eaglin",
                Genres = new List<Genre> { genres[11] },
                Recording = "New Orleans Street Singer",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "169"
            },
            new Musician
            {
                Name = "Marvin Gaye (and others)",
                Genres = new List<Genre> { genres[11] },
                Recording = "'I Heard It Through the Grapevine'",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "775"
            },
            new Musician
            {
                Name = "Eugene McDaniels",
                Genres = new List<Genre> { genres[11] },
                Recording = "Headless Heroes of the Apocalypse",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "225"
            },
            new Musician
            {
                Name = "Dan Penn and Spooner Oldham",
                Genres = new List<Genre> { genres[11] },
                Recording = "Live from This Theater",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "528, 317"
            },
            new Musician
            {
                Name = "Sade",
                Genres = new List<Genre> { genres[11] },
                Recording = "Promise",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "638"
            },
            new Musician
            {
                Name = "Ryan Adams",
                Genres = new List<Genre> { genres[12] },
                Recording = "Heartbreaker",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "831"
            },
            new Musician
            {
                Name = "The Animals",
                Genres = new List<Genre> { genres[12] },
                Recording = "'The House of the Rising Sun'",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "582, 463, 528, 196, 216, 326, 813, 436, 611, 169, 564, 573, 169, 647, 573, 959, 822, 1"
            },
            new Musician
            {
                Name = "Hank Ballard and the Midnighters",
                Genres = new List<Genre> { genres[12] },
                Recording = "Singin' and Swingin' with… ",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "187, 894"
            },
            new Musician
            {
                Name = "The Beau Brummels",
                Genres = new List<Genre> { genres[12] },
                Recording = "Triangle",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "418, 362, 546, 813, 591, 977"
            },
            new Musician
            {
                Name = "Blondie",
                Genres = new List<Genre> { genres[12] },
                Recording = "Parallel Lines",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "142, 647, 187, 169, 463, 481, 941, 766, 757"
            },
            new Musician
            {
                Name = "Alice Cooper",
                Genres = new List<Genre> { genres[12] },
                Recording = "'School's Out'",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "784"
            },
            new Musician
            {
                Name = "Dion",
                Genres = new List<Genre> { genres[12] },
                Recording = "'The Wanderer'",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "739"
            },
            new Musician
            {
                Name = "Steve Earle",
                Genres = new List<Genre> { genres[12] },
                Recording = "Transcendental Blues",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "169"
            },
            new Musician
            {
                Name = "The Everly Brothers",
                Genres = new List<Genre> { genres[12] },
                Recording = "Cadence Classics: Their Twenty Greatest Hits",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "169, 894"
            },
            new Musician
            {
                Name = "Guided by Voices",
                Genres = new List<Genre> { genres[12] },
                Recording = "Bee Thousand",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "793, 813, 748, 519, 932, 519"
            },
            new Musician
            {
                Name = "PJ Harvey",
                Genres = new List<Genre> { genres[12] },
                Recording = "Stories from the City, Stories from the Sea",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "499"
            },
            new Musician
            {
                Name = "Freedy Johnston",
                Genres = new List<Genre> { genres[12] },
                Recording = "Can You Fly",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "344"
            },
            new Musician
            {
                Name = "John Lennon",
                Genres = new List<Genre> { genres[12] },
                Recording = "Imagine",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "665"
            },
            new Musician
            {
                Name = "Los Lobos",
                Genres = new List<Genre> { genres[12] },
                Recording = "Kiko",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "115, 335, 115, 472, 977"
            },
            new Musician
            {
                Name = "Lynyrd Skynyrd",
                Genres = new List<Genre> { genres[12] },
                Recording = "'Free Bird'",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "481, 528, 481, 279, 775, 885, 894, 398, 528, 611, 436, 344, 326, 674, 739, 389, 418, 766"
            },
            new Musician
            {
                Name = "The Mamas and the Papas",
                Genres = new List<Genre> { genres[12] },
                Recording = "'California Dreamin''",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "656, 546, 252, 288, 445"
            },
            new Musician
            {
                Name = "The Mekons",
                Genres = new List<Genre> { genres[12] },
                Recording = "Rock 'n' Roll",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "793, 831, 528, 1, 591, 712, 555, 243, 463"
            },
            new Musician
            {
                Name = "Charles Ives",
                Genres = new List<Genre> { genres[1] },
                Recording = "Symphony No. 2, Symphony No. 3",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "968"
            },
            new Musician
            {
                Name = "Wolfgang Amadeus Mozart",
                Genres = new List<Genre> { genres[1] },
                Recording = "Requiem",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "297"
            },
            new Musician
            {
                Name = "Stephen Sondheim",
                Genres = new List<Genre> { genres[8] },
                Recording = "Sweeney Todd Live at the New York Philharmonic",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "775"
            },
            new Musician
            {
                Name = "The Pogues",
                Genres = new List<Genre> { genres[12] },
                Recording = "If I Should Fall from Grace with God",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "775, 647, 995, 591, 941, 196, 748, 389"
            },
            new Musician
            {
                Name = "Carmen McRae",
                Genres = new List<Genre> { genres[13] },
                Recording = "Carmen Sings Monk",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "894"
            },
            new Musician
            {
                Name = "The Minutemen",
                Genres = new List<Genre> { genres[12] },
                Recording = "Double Nickels on the Dime",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "647, 775, 683"
            },
            new Musician
            {
                Name = "The Modern Lovers",
                Genres = new List<Genre> { genres[12] },
                Recording = "The Modern Lovers",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "454, 9, 519, 656, 3"
            },
            new Musician
            {
                Name = "Alanis Morissette",
                Genres = new List<Genre> { genres[12] },
                Recording = "Jagged Little Pill",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "885"
            },
            new Musician
            {
                Name = "Sinéad O'Connor",
                Genres = new List<Genre> { genres[12] },
                Recording = "I Do Not Want What I Haven't Got",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "775"
            },
            new Musician
            {
                Name = "Graham Parker and the Rumour",
                Genres = new List<Genre> { genres[12] },
                Recording = "Squeezing Out Sparks/Live Sparks",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "528, 611, 813, 775, 115, 1"
            },
            new Musician
            {
                Name = "Pavement",
                Genres = new List<Genre> { genres[12] },
                Recording = "Crooked Rain, Crooked Rain",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "757, 683, 721, 775, 234, 297"
            },
            new Musician
            {
                Name = "Pere Ubu",
                Genres = new List<Genre> { genres[12] },
                Recording = "Dub Housing",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "279, 941, 5, 582, 3, 389, 371, 876, 225, 519, 941, 932, 766"
            },
            new Musician
            {
                Name = "Liz Phair",
                Genres = new List<Genre> { genres[12] },
                Recording = "Exile in Guyville",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "638"
            },
            new Musician
            {
                Name = "Pixies",
                Genres = new List<Genre> { genres[12] },
                Recording = "Doolittle",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "894, 876, 353, 941, 317, 133"
            },
            new Musician
            {
                Name = "The Pretenders",
                Genres = new List<Genre> { genres[12] },
                Recording = "Learning to Crawl",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "427, 427, 335, 986, 831, 317, 793, 793, 436, 196, 169"
            },
            new Musician
            {
                Name = "The Pretty Things",
                Genres = new List<Genre> { genres[12] },
                Recording = "Get the Picture?",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "225, 463, 297, 297, 555, 297, 225, 472, 692, 784"
            },
            new Musician
            {
                Name = "Prince and the Revolution",
                Genres = new List<Genre> { genres[12] },
                Recording = "Purple Rain",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "611, 766, 932, 427, 216, 169, 995, 611, 775, 463, 3, 169, 243"
            },
            new Musician
            {
                Name = "Ramones",
                Genres = new List<Genre> { genres[12] },
                Recording = "Ramones",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "454, 712, 418, 766, 398, 721, 187, 849"
            },
            new Musician
            {
                Name = "The Replacements",
                Genres = new List<Genre> { genres[12] },
                Recording = "Let It Be",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "519, 712, 335, 519, 427, 582"
            },
            new Musician
            {
                Name = "Screaming Trees",
                Genres = new List<Genre> { genres[12] },
                Recording = "Dust",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "959, 252, 647, 638, 923"
            },
            new Musician
            {
                Name = "Bob Seger and the Silver Bullet Band",
                Genres = new List<Genre> { genres[12] },
                Recording = "'Turn the Page'",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "151, 932, 757, 766, 115, 721, 757, 665, 4"
            },
            new Musician
            {
                Name = "Sex Pistols",
                Genres = new List<Genre> { genres[12] },
                Recording = "Never Mind the Bollocks Here's the Sex Pistols",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "932, 986, 858, 867, 757"
            },
            new Musician
            {
                Name = "The Sir Douglas Quintet",
                Genres = new List<Genre> { genres[12] },
                Recording = "Mendocino",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "537, 629, 591"
            },
            new Musician
            {
                Name = "Slayer",
                Genres = new List<Genre> { genres[12] },
                Recording = "Reign in Blood",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "923, 317, 169, 822, 959, 335, 932"
            },
            new Musician
            {
                Name = "Patti Smith",
                Genres = new List<Genre> { genres[12] },
                Recording = "Horses",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "941"
            },
            new Musician
            {
                Name = "The Smiths",
                Genres = new List<Genre> { genres[12] },
                Recording = "The Queen Is Dead",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "582, 196, 169, 151, 344"
            },
            new Musician
            {
                Name = "Phil Spector",
                Genres = new List<Genre> { genres[12] },
                Recording = "Back to Mono",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "775"
            },
            new Musician
            {
                Name = "Alexander 'Skip' Spence",
                Genres = new List<Genre> { genres[12] },
                Recording = "Oar",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "932"
            },
            new Musician
            {
                Name = "13th Floor Elevators",
                Genres = new List<Genre> { genres[12] },
                Recording = "Easter Everywhere",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "867, 371, 923, 7, 674"
            },
            new Musician
            {
                Name = "Uncle Tupelo",
                Genres = new List<Genre> { genres[12] },
                Recording = "Anodyne",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "775, 683, 6, 499, 656"
            },
            new Musician
            {
                Name = "Various Artists",
                Genres = new List<Genre> { genres[12] },
                Recording = "Cameo-Parkway, 1957-1967",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = ""
            },
            new Musician
            {
                Name = "Various Artists",
                Genres = new List<Genre> { genres[12] },
                Recording = "The Concert for Bangladesh",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = ""
            },
            new Musician
            {
                Name = "Various Artists",
                Genres = new List<Genre> { genres[12] },
                Recording = "Nuggets: Original Artyfacts from the First Psychedelic Era",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = ""
            },
            new Musician
            {
                Name = "XTC",
                Genres = new List<Genre> { genres[12] },
                Recording = "Skylarking",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "225, 986, 371, 995, 849"
            },
            new Musician
            {
                Name = "The Yardbirds",
                Genres = new List<Genre> { genres[12] },
                Recording = "Over Under Sideways Down (U.S.)/Roger the Engineer (U.K.)",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "398, 335, 6, 187, 344, 326, 876, 178, 279, 335, 436, 472, 739, 977, 353"
            },
            new Musician
            {
                Name = "ZZ Top",
                Genres = new List<Genre> { genres[12] },
                Recording = "Tres Hombres",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "647, 611, 629, 721"
            },
            new Musician
            {
                Name = "Edith Piaf",
                Genres = new List<Genre> { genres[13] },
                Recording = "The Voice of the Sparrow",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "472"
            },
            new Musician
            {
                Name = "Mel Tormé",
                Genres = new List<Genre> { genres[13] },
                Recording = "Swings Shubert Alley",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "371"
            },
            new Musician
            {
                Name = "Sukay",
                Genres = new List<Genre> { genres[14], genres[16] },
                Recording = "Cumbre",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "683"
            },
            new Musician
            {
                Name = "Cascabulho",
                Genres = new List<Genre> { genres[14], genres[20] },
                Recording = "Hunger Gives You a Headache",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "335"
            },
            new Musician
            {
                Name = "Moacir Santos",
                Genres = new List<Genre> { genres[14], genres[20] },
                Recording = "Coisas",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "261"
            },
            new Musician
            {
                Name = "The Bothy Band",
                Genres = new List<Genre> { genres[14], genres[24] },
                Recording = "Old Hag You Have Killed Me",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "133, 932, 638, 813, 418, 712, 5"
            },
            new Musician
            {
                Name = "The Boys of the Lough",
                Genres = new List<Genre> { genres[14], genres[24] },
                Recording = "Live at Passim",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "279, 923, 775, 757"
            },
            new Musician
            {
                Name = "The Clancy Brothers and the Dubliners",
                Genres = new List<Genre> { genres[14], genres[24] },
                Recording = "Irish Drinking Songs",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "225, 371, 656, 775, 216, 757, 656, 793, 234, 692, 436"
            },
            new Musician
            {
                Name = "Clannad",
                Genres = new List<Genre> { genres[14], genres[24] },
                Recording = "Macalla",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "187, 398, 894, 766, 766, 326"
            },
            new Musician
            {
                Name = "Silly Wizard",
                Genres = new List<Genre> { genres[14], genres[24] },
                Recording = "Wild and Beautiful",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "371, 721, 591, 822, 932, 115"
            },
            new Musician
            {
                Name = "Los Van Van",
                Genres = new List<Genre> { genres[14], genres[28] },
                Recording = "¡Ay Dios, ampárame!",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "436, 894, 463, 977, 418"
            },
            new Musician
            {
                Name = "Francisco Ulloa",
                Genres = new List<Genre> { genres[14], genres[29] },
                Recording = "Ultramerengue",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = ""
            },
            new Musician
            {
                Name = "The Comedian Harmonists",
                Genres = new List<Genre> { genres[14], genres[32] },
                Recording = "The Comedian Harmonists",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "169, 885, 499, 317, 445, 252"
            },
            new Musician
            {
                Name = "Mikis Theodorakis",
                Genres = new List<Genre> { genres[14], genres[33] },
                Recording = "The Best of Mikis Theodorakis",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "398"
            },
            new Musician
            {
                Name = "Various Artists",
                Genres = new List<Genre> { genres[14], genres[33] },
                Recording = "Rembetica: Historic Urban Folk Songs from Greece",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = ""
            },
            new Musician
            {
                Name = "Sol Ho'opi'i",
                Genres = new List<Genre> { genres[14], genres[36] },
                Recording = "Master of the Hawaiian Guitar, Vols. 1 and 2",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "8"
            },
            new Musician
            {
                Name = "Kayhan Khalhor, Shujaat Husain Khan, Swapan Chaudhuri",
                Genres = new List<Genre> { genres[14], genres[39] },
                Recording = "Ghazal: Lost Songs of the Silk Road",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "187, 454, 813"
            },
            new Musician
            {
                Name = "Various Artists",
                Genres = new List<Genre> { genres[14], genres[40] },
                Recording = "Music from the Morning of the World",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = ""
            },
            new Musician
            {
                Name = "Linton Kwesi Johnson",
                Genres = new List<Genre> { genres[14], genres[42] },
                Recording = "Dread Beat an' Blood",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "389"
            },
            new Musician
            {
                Name = "Peter Tosh",
                Genres = new List<Genre> { genres[14], genres[42] },
                Recording = "Live at the One Love Peace Concert",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "234"
            },
            new Musician
            {
                Name = "Various Artists",
                Genres = new List<Genre> { genres[14], genres[42] },
                Recording = "The Mighty Two",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = ""
            },
            new Musician
            {
                Name = "Larry Harlow",
                Genres = new List<Genre> { genres[14], genres[45] },
                Recording = "Salsa",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "775"
            },
            new Musician
            {
                Name = "Various Artists",
                Genres = new List<Genre> { genres[14], genres[46] },
                Recording = "The Spirit Cries",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = ""
            },
            new Musician
            {
                Name = "Nati Cano's Mariachi los Camperos",
                Genres = new List<Genre> { genres[14], genres[50] },
                Recording = "¡Viva el mariachi!",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "445"
            },
            new Musician
            {
                Name = "Puerto Rico Cortijo y su Máquina del Tiempo",
                Genres = new List<Genre> { genres[14], genres[54] },
                Recording = "La Máquina del Tiempo",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "169, 674"
            },
            new Musician
            {
                Name = "Madredeus",
                Genres = new List<Genre> { genres[14], genres[56] },
                Recording = "O espírito da paz",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "564, 196, 591, 968, 813, 591"
            },
            new Musician
            {
                Name = "Huun-Huur-Tu",
                Genres = new List<Genre> { genres[14], genres[58] },
                Recording = "The Orphan's Lament",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "427, 876, 297, 822, 225"
            },
            new Musician
            {
                Name = "özel Türkbas",
                Genres = new List<Genre> { genres[14], genres[64] },
                Recording = "How to Make Your Husband a Sultan",
                Occasions = new List<Occasion> { occasions[11] },
                Numbers = "858"
            }
        };
    }
}
