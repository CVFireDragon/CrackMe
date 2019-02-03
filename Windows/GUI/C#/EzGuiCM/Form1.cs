using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace EzGuiCM
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern int SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)]string lParam);
        const int EM_SETCUEBANNER = 0x1501;

        public Form1()
        {
            InitializeComponent();
            SendMessage(textBox1.Handle, EM_SETCUEBANNER, 1, "Case Sensitive!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains("MrSaturn"))
            {
                MessageBox.Show("Correct Key!","Nice!");
            }
            else
            {
                MessageBox.Show("Incorrect Key!", "Nope...");
            }
        }
    }
}
