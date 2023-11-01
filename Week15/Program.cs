
using System.Collections.Generic;

List<Movie> myMovies= new List<Movie>();    

string[] data = GetDataFromFile();
//ReadDataFromArray(data);


foreach(string line in data)  //selleks, et filmi pealkiri ja aasta saaks eraldi ridadele
{

    string[] tempArray = line.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
    Movie newMovie = new Movie(tempArray[0], tempArray[2]);
    myMovies.Add(newMovie);
}
foreach(Movie movie in myMovies)
{
    Console.WriteLine($"One of my favorite movies {movie.Title} was released in {movie.Year}.");
}




static string[] GetDataFromFile()

{ 
    string filePath = @"C:\data\movies.txt";
    //string[] dataFromFile = File.ReadAllLines(filePath);   
    
    return File.ReadAllLines(filePath);

}

static void  ReadDataFromArray(string[] someArray )  // kuvab konsoolis andmed 
{
    foreach(string line in  someArray)
    {
        Console.WriteLine(line);

    }

}

class Movie

{
    string title; // ehk fields 
    string year;

    public string Title // filmi pealkirja kuvamine 
    {
        get { return title; } 
    }

    public string Year
    {
        get { return year; }
    }


    public Movie(string _title, string _year)
    {
        title = _title;
        year = _year;
    }   
}

