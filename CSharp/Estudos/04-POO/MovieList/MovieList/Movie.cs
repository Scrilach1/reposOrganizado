using System;

namespace movie
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Gender { get; set; }
        public string Director { get; set; }

        public Movie(int id, string title, DateTime releaseDate, string gender, string director)
        {
            Id = id;
            Title = title;
            ReleaseDate = releaseDate;
            Gender = gender;
            Director = director;
        }
        public Movie(int id, string title)
        {
            Id = id;
            Title = title;
        }
        public override string ToString()
        {
        }

    }
}