using System;
class ForEachLoopExample{
    public static void Main(String[] args){
        String[] movies = {
            "Iron man",
            "Avengers",
            "Final Destination"
        };
        foreach(String movie in movies){
            Console.WriteLine(movie);
        }
    }
}