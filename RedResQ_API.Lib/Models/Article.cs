using System;

namespace RedResQ_API.Lib.Models
{
    public class Article
    {
        #region Instance variables

        private int _id;
        private string _title;
        private string _content;
        private string _author;
        private DateTime _date;
        private Language _language;
        private Image _image;
        private Location _location;

        #endregion

        #region Constructor

        public Article(int id, string title, string content, string author, DateTime date, Language language,
            Image image, Location location)
        {
            Id = id;
            Title = title;
            Content = content;
            Author = author;
            Date = date;
            Language = language;
            Image = image;
            Location = location;
        }

        #endregion

        #region Properties

        public int Id
        {
            get => _id;
            private set => _id = value;
        }
        
        public string Title
        {
            get => _title;
            private set => _title = value;
        }
        
        public string Content
        {
            get => _content;
            private set => _content = value;
        }
        
        public string Author
        {
            get => _author;
            private set => _author = value;
        }
        
        public DateTime Date
        {
            get => _date;
            private set => _date = value;
        }
        
        public Language Language
        {
            get => _language;
            private set => _language = value;
        }
        
        public Image Image
        {
            get => _image;
            private set => _image = value;
        }
        
        public Location Location
        {
            get => _location;
            private set => _location = value;
        }

        #endregion
    }
}