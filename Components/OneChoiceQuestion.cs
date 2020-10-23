using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AptechWinforms.Components
{
    public class OneChoiceQuestion : Question
    {
        public string Option1 { get; set; }
        public string Option2 { get; set; }
        public string Option3 { get; set; }
        public string Option4 { get; set; }


        public override void LoadFromFile(int index)
        {
            var lines = System.IO.File.ReadAllLines(@"Data\" + index + ".txt");

            this.QuestionType = lines[0];
            this.QuestionContent = lines[1];
            this.Option1 = lines[2];
            this.Option2 = lines[3];
            this.Option3 = lines[4];
            this.Option4 = lines[5];
            this.CorrectOption = lines[6];

        }

        public override string GetDisplayContent()
        {
            StringBuilder content = new StringBuilder("");

            content.AppendLine(this.QuestionContent);

            content.AppendLine();

            content.AppendLine("A. " + this.Option1);
            content.AppendLine("B. " + this.Option2);
            content.AppendLine("C. " + this.Option3);
            content.AppendLine("D. " + this.Option4);

            return content.ToString();
        }
    }
}
