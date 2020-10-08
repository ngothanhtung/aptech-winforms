using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AptechWinforms.Components
{
    public abstract class Question : IQuestion
    {
        public string QuestionType { get; set; }
        public string QuestionContent { get; set; }
        public string CorrectOption { get; set; }

        public bool CheckCorrect(string userOption)
        {
            if (string.IsNullOrEmpty(this.CorrectOption))
            {
                return false;
            }

            if (userOption == null)
            {
                return false;
            }

            return userOption.Equals(this.CorrectOption);
        }

        public abstract void LoadFromFile(int index);
        public abstract string GetDisplayContent();
    }
}
