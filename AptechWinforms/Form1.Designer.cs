namespace AptechWinforms
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblContent = new System.Windows.Forms.Label();
            this.btnA = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.pnlOneChoice = new System.Windows.Forms.Panel();
            this.txtAnswerText = new System.Windows.Forms.TextBox();
            this.pnlFillInTheBlank = new System.Windows.Forms.Panel();
            this.pnlOneChoice.SuspendLayout();
            this.pnlFillInTheBlank.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContent.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblContent.Location = new System.Drawing.Point(12, 31);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(86, 23);
            this.lblContent.TabIndex = 1;
            this.lblContent.Text = "Content";
            // 
            // btnA
            // 
            this.btnA.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnA.Location = new System.Drawing.Point(34, 24);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(75, 50);
            this.btnA.TabIndex = 2;
            this.btnA.Text = "A";
            this.btnA.UseVisualStyleBackColor = true;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnB
            // 
            this.btnB.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnB.Location = new System.Drawing.Point(246, 24);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(75, 50);
            this.btnB.TabIndex = 3;
            this.btnB.Text = "B";
            this.btnB.UseVisualStyleBackColor = true;
            this.btnB.Click += new System.EventHandler(this.btnB_Click);
            // 
            // btnC
            // 
            this.btnC.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.Location = new System.Drawing.Point(458, 24);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(75, 50);
            this.btnC.TabIndex = 4;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnD
            // 
            this.btnD.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnD.Location = new System.Drawing.Point(670, 24);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(75, 50);
            this.btnD.TabIndex = 5;
            this.btnD.Text = "D";
            this.btnD.UseVisualStyleBackColor = true;
            this.btnD.Click += new System.EventHandler(this.btnD_Click);
            // 
            // pnlOneChoice
            // 
            this.pnlOneChoice.Controls.Add(this.btnA);
            this.pnlOneChoice.Controls.Add(this.btnC);
            this.pnlOneChoice.Controls.Add(this.btnD);
            this.pnlOneChoice.Controls.Add(this.btnB);
            this.pnlOneChoice.Location = new System.Drawing.Point(16, 338);
            this.pnlOneChoice.Name = "pnlOneChoice";
            this.pnlOneChoice.Size = new System.Drawing.Size(772, 100);
            this.pnlOneChoice.TabIndex = 7;
            // 
            // txtAnswerText
            // 
            this.txtAnswerText.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswerText.ForeColor = System.Drawing.Color.Blue;
            this.txtAnswerText.Location = new System.Drawing.Point(13, 18);
            this.txtAnswerText.Name = "txtAnswerText";
            this.txtAnswerText.Size = new System.Drawing.Size(741, 30);
            this.txtAnswerText.TabIndex = 8;
            this.txtAnswerText.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtAnswerText_KeyUp);
            // 
            // pnlFillInTheBlank
            // 
            this.pnlFillInTheBlank.Controls.Add(this.txtAnswerText);
            this.pnlFillInTheBlank.Location = new System.Drawing.Point(16, 226);
            this.pnlFillInTheBlank.Name = "pnlFillInTheBlank";
            this.pnlFillInTheBlank.Size = new System.Drawing.Size(772, 100);
            this.pnlFillInTheBlank.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlFillInTheBlank);
            this.Controls.Add(this.pnlOneChoice);
            this.Controls.Add(this.lblContent);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlOneChoice.ResumeLayout(false);
            this.pnlFillInTheBlank.ResumeLayout(false);
            this.pnlFillInTheBlank.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Panel pnlOneChoice;
        private System.Windows.Forms.TextBox txtAnswerText;
        private System.Windows.Forms.Panel pnlFillInTheBlank;
    }
}

