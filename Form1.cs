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

namespace TekstilFabric2
{
    public partial class Form1 : Form
    {
        public static string connectionString = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source = fabric.accdb";
        private OleDbConnection myConnection;

        public Form1()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectionString);
            myConnection.Open();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fabricDataSet.SkladTable". При необходимости она может быть перемещена или удалена.
            this.skladTableTableAdapter.Fill(this.fabricDataSet.SkladTable);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fabricDataSet.ReceptsTable". При необходимости она может быть перемещена или удалена.
            this.receptsTableTableAdapter.Fill(this.fabricDataSet.ReceptsTable);
            Filler();
        }
        public void Filler()
        {
            string query = "SELECT NameRecept,HlNeed,NabNeed FROM ReceptsTable ORDER BY Код";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            OleDbDataReader reader = command.ExecuteReader();
            listBox1.Items.Clear();
            while (reader.Read())
            {
                listBox1.Items.Add(reader[0].ToString());
            }
            reader.Close();

        }
        private void button3_Click(object sender, EventArgs e)
        {
            Recepts recepts = new Recepts();
            recepts.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Skald skald = new Skald();
            skald.Show();

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1) button1.Visible = false;
            else button1.Visible = true;
            
            Stats(button1.Visible);
            
        }
        public static string end;
        public void StatsRaschet2()
        {
            
            
            string query = "SELECT HlNeed FROM ReceptsTable WHERE [NameRecept] =" + "'" + listBox1.SelectedItem.ToString() + "'";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            string hlNeed = command.ExecuteScalar().ToString();
            string qqery = "SELECT NabNeed FROM ReceptsTable WHERE [NameRecept] =" + "'" + listBox1.SelectedItem.ToString() + "'";
            OleDbCommand command1 = new OleDbCommand(qqery, myConnection);
            string nabNeed = command1.ExecuteScalar().ToString();
            string queryq = "SELECT CountItem FROM SkladTable WHERE [NameItem] =" + "'" + listBox1.SelectedItem.ToString() + "'";
            OleDbCommand commandq = new OleDbCommand(queryq, myConnection);
            end = commandq.ExecuteScalar().ToString();
            Making.pCount = end;
            int hlRaz = int.Parse(hlNeed);
            int NabRaz=int.Parse(nabNeed);
            int hl = int.Parse(label9.Text);
            int nab=int.Parse(label6.Text);
            label8.Text=(hl-hlRaz).ToString();
            label7.Text=(nab-NabRaz).ToString() ;
            if (hl - hlRaz < 0 || nab - NabRaz < 0)
            {
                MessageBox.Show("Материалов недостаточно");
                label8.Text = (hl + hlRaz).ToString();
                label7.Text = (nab + NabRaz).ToString();
            }
        }

        public void Stats(bool a)
        {
            label2.Visible = a;
            label3.Visible = a;
            label4.Visible = a;
            label5.Visible = a;
            label6.Visible = a;
            label7.Visible = a;
            label8.Visible = a;
            label9.Visible = a;
            StatsRachet();
        }
        public void StatsRachet()
        {
            string hl = "Хлопок";
            string nab = "Набор для отделки";
            string query = "SELECT [CountItem] FROM SkladTable WHERE [NameItem] =" + "'"+hl+"'";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            label9.Text = command.ExecuteScalar().ToString();
            string qqery = "SELECT [CountItem] FROM SkladTable WHERE [NameItem] ="+ "'"+nab+"'";
            OleDbCommand command1 = new OleDbCommand(qqery, myConnection);
            label6.Text = command1.ExecuteScalar().ToString();
            StatsRaschet2();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string hl = "Хлопок";
            string nab = "Набор для отделки";
            string name = label8.Text;
            string  count = label7.Text;

            string query = "UPDATE SkladTable SET CountItem = " + "'" + name + "'" + "WHERE NameItem = " + "'" + hl + "'";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();

            string query1 = "UPDATE SkladTable SET CountItem = " + "'" + count + "'" + "WHERE NameItem = " + "'" + nab + "'";
            OleDbCommand command1 = new OleDbCommand(query1, myConnection);
            command1.ExecuteNonQuery();

            Making.name=listBox1.SelectedItem.ToString();
            Making making = new Making();
            making.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
