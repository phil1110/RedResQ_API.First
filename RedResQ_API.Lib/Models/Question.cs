namespace RedResQ_API.Lib.Models
{
    public class Question
    {
        #region Instance variables

        private int _id;
        private string _text;
        private Answer[] _answers;

        #endregion

        #region Constructor

        public Question(int id, string text, Answer[] answers)
        {
            Id = id;
            Text = text;
            Answers = answers;
        }

        #endregion

        #region Properties

        public int Id
        {
            get => _id;
            private set => _id = value;
        }

        public string Text
        {
            get => _text;
            private set => _text = value;
        }

        public Answer[] Answers
        {
            get => _answers;
            private set => _answers = value;
        }

        #endregion
    }
}