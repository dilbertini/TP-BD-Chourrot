using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_BD_Chourrot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTN_Connect_Click(object sender, EventArgs e)
        {
            Connection_Form dlg = new Connection_Form();
            dlg.ShowDialog();
        }

        private void BTN_Deconnect_Click(object sender, EventArgs e)
        {

        }
    }
}
