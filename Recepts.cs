using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TekstilFabric2
{
    public partial class Recepts : Form
    {
        public static string connectionString = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source = fabric.accdb";
        private OleDbConnection myConnection;
        public Recepts()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectionString);
            myConnection.Open();
        }
        public void Filler()
        {
            string query = "SELECT NameRecept,HlNeed,NabNeed FROM ReceptsTable ORDER BY Код";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            OleDbDataReader reader = command.ExecuteReader();
            listBox1.Items.Clear();
            while (reader.Read())
            {
                listBox1.Items.Add(reader[0].ToString()+" "+ reader[1].ToString() + " " + reader[2].ToString());
            }
            reader.Close();

        }
           
    private void button3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Skald skald = new Skald();
            skald.Show();
            this.Close();
        }

        private void Recepts_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }

        private void Recepts_Load(object sender, EventArgs e)
        {
            Filler();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReceptAdd receptAdd = new ReceptAdd();
            receptAdd.Show();
        }
    }
}
