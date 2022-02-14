using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetProcess
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.GetBtn.Click += GetBtn_Click;
        }

        private void GetBtn_Click(object sender, EventArgs e)
        {
            //var procNames = this.ProcessNameText.Text.Split(new char[] { ',' } );
            //foreach (var proc in procNames)
            //SaveFile f = new SaveFile();
            //var procNames = this.ProcessNameText.Text.Split(new char[] { ',' });
            //int count = 0;
            //foreach (var proc in procNames)
            //{
            //    string result = GetProperty.GetPropertyString(proc);
            //    // SaveFile f = new SaveFile();
            //    f.CreateFile(result);
            //}

        string result = GetProperty.GetPropertyString(ProcessNameText.Text);
        SaveFile f = new SaveFile();
        f.CreateFile(result);
            f.OpenFile();

        }
    }
}
