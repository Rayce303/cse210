using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome! Type anything to begin.");
        Console.WriteLine("You will be directed to a random scripture.");
        Console.WriteLine("Press the Enter key to keep removing words from the scripture.");
        Console.WriteLine("Type 'q' at any time to quit.");
        Console.ReadLine();

        List<Scripture> scriptures = new List<Scripture>
        {
            new Scripture("Moses", 1, 39, "This is my work and my glory — to bring to pass the immortality and eternal life of man."),
            new Scripture("Matthew", 11, 28, 30, "Come unto me, all ye that labour and are heavy laden, and I will give you rest."),
            new Scripture("John", 3, 16, "For God so loved the world, that he gave his only begotten Son."),
            new Scripture("James", 1, 5, 6, "If any of you lack wisdom, let him ask of God."),
            new Scripture("2 Nephi", 2, 25, "Adam fell that men might be; and men are, that they might have joy."),
            new Scripture("D&C", 6, 36, "Look unto me in every thought; doubt not, fear not."),
            new Scripture("Proverbs", 3, 5, 6, "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."),
            new Scripture("Matthew", 22, 37, 39, "Jesus said unto him, Thou shalt love the Lord thy God with all thy heart, and with all thy soul, and with all thy mind. This is the first and great commandment. And the second is like unto it, Thou shalt love thy neighbour as thyself."),
            new Scripture("1 Corinthians", 6, 19, 20, "What? know ye not that your body is the temple of the Holy Ghost which is in you, which ye have of God, and ye are not your own? For ye are bought with a price: therefore glorify God in your body, and in your spirit, which are God’s."),
            new Scripture("Mosiah", 2, 17, "When ye are in the service of your fellow beings ye are only in the service of your God.")
        };
        Random randomScripture = new Random();
        Scripture chosenScripture = scriptures[randomScripture.Next(scriptures.Count)];

        string userInput = "";

        while (userInput != "q")
        {
            chosenScripture.ShowScripture();

            userInput = Console.ReadLine();
            if (userInput != "q")
            {
                chosenScripture.HideSomeWords();
            }
        }
    }
}