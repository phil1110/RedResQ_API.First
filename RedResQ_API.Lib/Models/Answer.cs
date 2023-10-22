namespace RedResQ_API.Lib.Models
{
    public class Answer
    {
        #region Instance variables
        
        private int _id;
        private string _text;
        private bool _isTrue;
        
        #endregion

        #region Constructor

        public Answer(int id, string text, bool isTrue)
        {
            Id = id;
            Text = text;
            IsTrue = isTrue;
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

        public bool IsTrue
        {
            get => _isTrue;
            private set => _isTrue = value;
        }

        #endregion
    }
}