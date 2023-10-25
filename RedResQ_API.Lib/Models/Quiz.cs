namespace RedResQ_API.Lib.Models
{
    public class Quiz
    {
        
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

        public int Id { get; private set; }

        public string Name { get; private set; }

        public int MaxScore { get; private set; }

        public Question[] Questions { get; private set; }

        #endregion
    }
}