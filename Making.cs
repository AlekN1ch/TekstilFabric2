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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace TekstilFabric2
{
    public partial class Making : Form
    {
        public static string connectionString = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source = fabric.accdb";
        private OleDbConnection myConnection;
        public Making()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectionString);
            myConnection.Open();
        }
        int i = 0;
        Label[] labels= new Label[4];
        private void Making_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fabricDataSet.SkladTable". При необходимости она может быть перемещена или удалена.
            this.skladTableTableAdapter.Fill(this.fabricDataSet.SkladTable);
            labels[0] = label1;
            labels[1] = label2;
            labels[2] = label3;
            labels[3] = label4;
        }
        public static string name;
        public static string pCount;
        public void NextStep(int ind)
        {
            if (ind > 3)
            {
                int a = 1;
                int b =int.Parse(pCount);
                string count=(b+a).ToString();
                MessageBox.Show("Все этапы работы завершены");
                string query = "UPDATE SkladTable SET CountItem = " + "'" + count + "'" + "WHERE NameItem = " + "'" + name + "'";
                OleDbCommand command = new OleDbCommand(query, myConnection);
                command.ExecuteNonQuery();
                this.Close();
            }
            else
            {
                for (int i = 0; i < labels.Length; i++)
                {
                    if (i == ind)
                    {
                        labels[i].BackColor = SystemColors.Info;

                    }
                    else { labels[i].BackColor = SystemColors.Control; }
                }
            }  
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NextStep(i);
            i++;
        }

        private void Making_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
