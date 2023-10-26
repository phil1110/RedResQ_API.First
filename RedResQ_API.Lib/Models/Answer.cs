namespace RedResQ_API.Lib.Models
{
    public class Answer
    {
        #region Constructor

        public Answer(int id, string text, bool isTrue)
        {
            Id = id;
            Text = text;
            IsTrue = isTrue;
        }

        #endregion

        #region Properties

        public int Id { get; private set; }

        public string Text { get; private set; }

        public bool IsTrue { get; private set; }

        #endregion
    }
}