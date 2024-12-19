using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TekstilFabric2
{
    public partial class Skald : Form
    {
        public static string connectionString = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source = fabric.accdb";
        private OleDbConnection myConnection;
        public Skald()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectionString);
            myConnection.Open();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Recepts recepts = new Recepts();
            recepts.Show();
            this.Close();
        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Close();
        }

        private void Skald_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fabricDataSet.SkladTable". При необходимости она может быть перемещена или удалена.
            this.skladTableTableAdapter.Fill(this.fabricDataSet.SkladTable);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditSklad editSklad = new EditSklad();
            editSklad.ShowDialog();
        }

        private void Skald_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }
    }
}
