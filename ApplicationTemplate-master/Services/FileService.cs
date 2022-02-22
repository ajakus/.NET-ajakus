using System;
using System.IO;

namespace ApplicationTemplate.Services;

/// <summary>
///     This concrete service and method only exists an example.
///     It can either be copied and modified, or deleted.
/// </summary>
public class FileService : IFileService

    
{
    string file = "C:/Users/jakus/Downloads/ApplicationTemplate-master/ApplicationTemplate-master/movies.csv";
    public void Read()
    {
        StreamReader sr = new StreamReader(file);

        string line = sr.ReadLine();

        while (!sr.EndOfStream)
        {
            line = sr.ReadLine();
            var column = line.Split(',');
            var sv = string.Join(',', column);
            Console.WriteLine(sv);

        }
        sr.Close();
        
    }

    public void Write()
    {
        Console.WriteLine("What is movie ID ?");
        var movieID = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("What is the movie title ?");
        var movieTitle = Console.ReadLine();

        Console.WriteLine("How many genres ?");
        var genreNum = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("What is the genre ?");
        string[] genreAr = new string[genreNum];

        //loop for multiple genres
        for (int i = 0; i < genreNum; i++)
        {
            Console.WriteLine("Genre (" + (i + 1) + ")");
            var movieGenre = Console.ReadLine();
            genreAr[i] = movieGenre;


        }
        
        var ss = string.Join('|', genreAr);
        var se = string.Join(',', movieID, movieTitle, ss);

        StreamWriter sw = new StreamWriter(file, append: true);
        var dataLine = (se);
        sw.WriteLineAsync(dataLine);
        sw.Close();
    }
}
