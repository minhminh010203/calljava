using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace calljava
{
    public partial class calljavafrm : Form
    {
        public calljavafrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void calljavafrm_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

ProcessStartInfo startsInfo = new ProcessStartInfo();
startsInfo.CreateNoWindow = true;
startsInfo.UseShellExecute = false;
startsInfo.FileName = "D:\\java\\bin\\java.exe";
startsInfo.WindowStyle = ProcessWindowStyle.Hidden;
startsInfo.RedirectStandardOutput = true;
startsInfo.WorkingDirectory = "D:\\java\\New folder";
startsInfo.Arguments = $"duycop {textBox1.Text} {textBox2.Text}";
try
{
    using (Process exe = Process.Start(startsInfo))
    {
        exe.WaitForExit();
        while (!exe.StandardOutput.EndOfStream)
        {
            string line = exe.StandardOutput.ReadLine();
            textBox3.AppendText(line + "\n");

        }
    }
}
catch (Exception ex)
{
    textBox3.AppendText(ex.Message);
}