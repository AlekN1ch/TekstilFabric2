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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TekstilFabric2
{
    public partial class ReceptAdd : Form
    {
        public static string connectionString = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source = fabric.accdb";
        private OleDbConnection myConnection;
        public ReceptAdd()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectionString);
            myConnection.Open();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        

        private void ReceptAdd_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }

        private void ReceptAdd_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fabricDataSet.SkladTable". При необходимости она может быть перемещена или удалена.
            this.skladTableTableAdapter.Fill(this.fabricDataSet.SkladTable);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fabricDataSet.ReceptsTable". При необходимости она может быть перемещена или удалена.
            this.receptsTableTableAdapter.Fill(this.fabricDataSet.ReceptsTable);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool acces ;
            try {
                int i=int.Parse(textBox2.Text);
                int a = int.Parse(textBox3.Text);
                acces=true;
            } 
            catch
            { MessageBox.Show("Неверный формат ввода");acces = false; }

            if (acces)
            {
                string query = "INSERT INTO ReceptsTable ([NameRecept],[HlNeed],[NabNeed]) VALUES " + "('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')";
                OleDbCommand command = new OleDbCommand(query, myConnection);
                command.ExecuteNonQuery();

                string count = "0";
                string query1 = "INSERT INTO SkladTable ([NameItem],[CountItem]) VALUES " + "('" + textBox1.Text + "','" + count + "')";
                OleDbCommand command1 = new OleDbCommand(query1, myConnection);
                command1.ExecuteNonQuery();

                MessageBox.Show("Сценарий успешно добавлен");
                Recepts recepts = new Recepts();
                recepts.ShowDialog();

                this.Close();
            }
        }
    }
}
