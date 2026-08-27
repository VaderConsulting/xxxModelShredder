using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ModelShredder.Demo
{
    public partial class Demo : Form
    {
        public Demo()
        {
            InitializeComponent();

            lblCount.Text = "Rows: " + TestObjects.List.Count;
        }

        private void btnPopulate_Click(object sender, EventArgs e)
        {
            dgvMain.DataSource = TestObjects.List.ToDataTable();
            
        }
    }
}
