using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AptechWinforms.Components;

namespace AptechWinforms
{
    public partial class Form1 : Form
    {
        private int index = 1;
        private Question currentQuestion;


        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            this.display();
        }

        private void display()
        {
            this.currentQuestion = new OneChoiceQuestion();


            if (this.index > 5) this.currentQuestion = new FillInTheBlankQuestion();

            this.currentQuestion.LoadFromFile(this.index);

            lblContent.Text = this.currentQuestion.GetDisplayContent();
            if (this.currentQuestion.QuestionType == "OneChoice")
            {
                pnlOneChoice.Visible = true;
                pnlFillInTheBlank.Visible = false;
            }
            else if (this.currentQuestion.QuestionType == "FillInTheBlank")
            {
                pnlFillInTheBlank.Visible = true;
                pnlOneChoice.Visible = false;
            }
        }

        private void check(string userOption)
        {
            var result = this.currentQuestion.CheckCorrect(userOption);
            if (result == true)
            {
                MessageBox.Show("Congratulation! You are correct.", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Sorry! Try again.", "Result", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            // Next question
            this.index++;
            this.display();

        }


        private void btnA_Click(object sender, EventArgs e)
        {
            this.check("A");
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            this.check("B");
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            this.check("C");
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            this.check("D");
        }


        private void txtAnswerText_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var userOption = txtAnswerText.Text.Trim();
                this.check(userOption);
            }
        }
    }
}
