using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ReportPrinterRemaster
{
    public partial class WndDataInput : Form
    {

        public string Length { get; set; }
        public string Width { get; set; }
        public string Height { get; set; }
        public string WagenHeigh { get; set; }

        public WndDataInput()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Length = txtLength.Text;
            Width = txtWidth.Text;
            Height = txtHeight.Text;
            WagenHeigh = txtLBGD.Text;
            this.Close();
        }
    }
}
