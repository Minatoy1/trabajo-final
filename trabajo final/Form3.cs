using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace trabajo_final
{
    public partial class FormConsulta : Form
    {
        public FormConsulta()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabConsulta_Selecting(object sender, TabControlCancelEventArgs e)
        {
           if (e.TabPageIndex > tabConsulta.SelectedIndex)
            {
                e.Cancel = true;
                
        }
    }
    }
}
