﻿using System;

namespace RedResQ_API.Lib.Models
{
    public class Article
    {
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

        public int Id { get; private set; }

        public string Title { get; private set; }

        public string Content { get; private set; }

        public string Author { get; private set; }

        public DateTime Date { get; private set; }

        public Language Language { get; private set; }

        public Image Image { get; private set; }

        public Location Location { get; private set; }

        #endregion
    }
}