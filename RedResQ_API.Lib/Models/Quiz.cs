namespace RedResQ_API.Lib.Models
{
    public class Quiz
    {
        #region Instance variables

        private int _id;
        private string _name;
        private int _maxScore;
        private Question[] _questions;

        #endregion

        #region Constructor

        public Quiz(int id, string name, int maxScore, Question[] questions)
        {
            Id = id;
            Name = name;
            MaxScore = maxScore;
            Questions = questions;
        }

        #endregion

        #region Properties

        public int Id
        {
            get => _id;
            private set => _id = value;
        }

        public string Name
        {
            get => _name;
            private set => _name = value;
        }

        public int MaxScore
        {
            get => _maxScore;
            private set => _maxScore = value;
        }

        public Question[] Questions
        {
            get => _questions;
            private set => _questions = value;
        }

        #endregion
    }
}