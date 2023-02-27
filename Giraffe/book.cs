using System;
namespace Giraffe
{
    public class Book
    {
        public string title;
        public string author;
        public int pages;
        private string rating;

        public Book ()
        {

        }
        public Book(string aTitle, string aAuthor, int aPages, string aRating)
        {
            title = aTitle;
            author = aAuthor;
            pages = aPages;
            Rating = aRating;
        }

        public bool HasHonors()
        {
            if(pages >= 100)
            {
                return true;
            }
            return false;
        }

        public string Rating
        {
            get { return rating; }
            set {
                if (value == "G" || value == "PG" || value == "Good")
                {
                    rating = value;
                }
                else
                {
                    rating = "N/A";
                }
            }
        }
    }
}

