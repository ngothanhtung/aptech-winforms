using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AptechWinforms
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Lấy 1 chuỗi thông báo chào hỏi
        /// </summary>
        /// <param name="text">Nhập tên của bạn</param>
        /// <returns>Là một chuỗi chào hỏi + tên</returns>
        private string GetMessage(string text)
        {
            return "Hello " + text;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
            //MessageBox.Show("Text", "Thong bao");
            var s = this.GetMessage("Tung");

        }
    }
}
