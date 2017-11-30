using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace TP_BD_Chourrot
{
    public partial class Connection_Form : Form
    {
        private OracleConnection conn = new OracleConnection();

        public Connection_Form()
        {
            InitializeComponent();
        }

        private void BTN_Connect_Click(object sender, EventArgs e)
        {
            try
            {
                string Dsource = "(DESCRIPTION="
                + "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)"
                + "(HOST=205.237.244.251)(PORT=1521)))"
                + "(CONNECT_DATA=(SERVICE_NAME=ORCL.clg.qc.ca)))";
                String ChaineConnexion = "Data Source=" + Dsource
                + ";User Id=" + TB_Username.Text + ";Password=" + TB_Password.Text;
                conn.ConnectionString = ChaineConnexion;
                conn.Open();
                //MessageBox.Show(conn.State.ToString());
                LB_Connect.Text = "Connection ouverte";
                LB_Connect.ForeColor = Color.Blue;
                Dlg_To_Form();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Erreur de connection");
            }
        }

        private void BTN_Cancel_Click(object sender, EventArgs e)
        {

        }

        private void Dlg_To_Form()
        {

        }
    }
}
