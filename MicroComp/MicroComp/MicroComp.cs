using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MicroComp
{
    public partial class MicroComp : Form
    {
        public MicroComp()
        {
            InitializeComponent();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            MessageBox.Show("тест загрузки ресурсов");
        }
    }
}
