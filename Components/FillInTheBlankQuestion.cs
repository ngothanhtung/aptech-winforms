using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AptechWinforms.Components
{
    public class FillInTheBlankQuestion : Question
    {

        public override void LoadFromFile(int index)
        {
            var lines = System.IO.File.ReadAllLines(@"Data\" + index + ".txt");

            this.QuestionType = lines[0];
            this.QuestionContent = lines[1];
            this.CorrectOption = lines[2];

        }

        public override string GetDisplayContent()
        {
            StringBuilder content = new StringBuilder("");
            content.AppendLine(this.QuestionContent);
            content.AppendLine();

            return content.ToString();
        }
    }
}
