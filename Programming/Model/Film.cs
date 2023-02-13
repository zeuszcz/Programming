using System;

namespace Programming.Model
{
    public class Film
    {
         private string _title { get; set; }
         private int _durationmin { get; set; }
         private int _release;
         private string _genre { set; get; }
         private double _rating;
         public int Release
         {
             get
             {
                 return _release;
             }
             set
             {
                 if ((value < 1900) & (value > 2022))
                 {
                     throw new ArgumentException("Не верно указан год выхода фильма");
                 }

                 _release = value;
             }
         }

         public double Rating
         {
             get
             {
                 return _rating;
             }
             set
             {
                 if ((value < 0)&(value> 10))
                 {
                     throw new AggregateException("Укажите рейтинг фильма от 1 до 10");
                 }

                 _rating = value;
             }
         }

         public Film()
         {
             
         }

         public Film(string title, int durationmin, int release, string genre, double rating)
         {
             _title = title;
             _durationmin = durationmin;
             _release = release;
             _genre = genre;
             _rating = rating;
         }

    }
}