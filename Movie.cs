using System;
namespace Lab_11
{
    public class Movie : IComparable<Movie>
    {
        private string title;
        public string Title { get{return title; } }
        private string category;
        public string Category { get { return category; } }
        private int categoryNum;
        public int CategoryNum { get { return categoryNum; } }


        public Movie(string title ,string category, int categoryNum)
        {
            this.title = title;
            this.category = category;
            this.categoryNum = categoryNum;

        }

        public int CompareTo(Movie that)
        {
            int result = this.Title.CompareTo(that.Title);
            return result;
        }


    }
}
