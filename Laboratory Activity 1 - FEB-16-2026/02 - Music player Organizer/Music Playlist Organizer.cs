using System;

class Song
{
    public string Title { get; set; }
    public string Artist { get; set; }
    public double Duration { get; set; }

    public Song() : this("Unknown", "Unknown", 0.0) { }

    public Song(string title, string artist) : this(title, artist, 0.0) { }

    public Song(string title, string artist, double duration)
    {
        Title = title;
        Artist = artist;
        Duration = duration;
    }

    public void DisplaySong()
    {
        Console.WriteLine($"{Title,-20} {Artist,-20} {Duration:F2}");
    }
}

class ProgramB
{
    static void Main()
    {
        Console.Write("Songs to add: ");
        int.TryParse(Console.ReadLine(), out int count);
        
        Song[] playlist = new Song[count];

        for (int i = 0; i < count; i++)
        {
            Console.WriteLine($"\nSong #{i + 1}");
            Console.Write("Title: ");
            string title = Console.ReadLine();
            Console.Write("Artist: ");
            string artist = Console.ReadLine();
            Console.Write("Duration (minutes): ");
            double.TryParse(Console.ReadLine(), out double duration);

            playlist[i] = new Song(title, artist, duration);
        }

        Console.WriteLine("\n=== PLAYLIST ===");
        Console.WriteLine($"{"Title",-20} {"Artist",-20} {"Time"}");
        Console.WriteLine(new string('-', 50));

        double totalDuration = 0;
        foreach (var song in playlist)
        {
            song.DisplaySong();
            totalDuration += song.Duration;
        }

        double average = count > 0 ? totalDuration / count : 0;

        Console.WriteLine();
        Console.WriteLine($"Total Duration: {totalDuration:F2} mins");
        Console.WriteLine($"Average Duration: {average:F2} mins");
    }
}