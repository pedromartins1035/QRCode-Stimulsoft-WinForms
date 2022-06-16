using Stimulsoft.Report;
using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StiReport report = new StiReport();
            report = QReport;

            report.Dictionary.Variables["Link"].Value = "https://github.com/pedromartins1035";
            report.Show();
        }
    }
}
