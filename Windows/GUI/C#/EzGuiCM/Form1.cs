using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EzGuiCM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains("MrSaturn"))
            {
                Form3 CorrectForm = new Form3();
                CorrectForm.Show();
            }
            else
            {
                Form2 InCorrectForm = new Form2();
                InCorrectForm.Show();
            }
        }
    }
}
