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
    public partial class EditSklad : Form
    {
        public static string connectionString = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source = fabric.accdb";
        private OleDbConnection myConnection;
        public EditSklad()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectionString);
            myConnection.Open();
        }

        private void EditSklad_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fabricDataSet.SkladTable". При необходимости она может быть перемещена или удалена.
            this.skladTableTableAdapter.Fill(this.fabricDataSet.SkladTable);
            Filler();
        }
        public void Filler()
        {
            Filler1();
            Filler2();
        }
        public void Filler1()
        {
            string query = "SELECT NameItem FROM SkladTable ORDER BY Код";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            OleDbDataReader reader = command.ExecuteReader();
            listBox1.Items.Clear();
            while (reader.Read())
            {
                listBox1.Items.Add(reader[0].ToString());
            }
            reader.Close();
        }
        public void Filler2()
        {
            string query = "SELECT CountItem FROM SkladTable ORDER BY Код";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            OleDbDataReader reader = command.ExecuteReader();
            listBox2.Items.Clear();
            while (reader.Read())
            {
                listBox2.Items.Add(reader[0].ToString());
            }
            reader.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex!=-1)button2.Visible = true;
            else button2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool acces;
            try
            {
               
                int a = int.Parse(textBox3.Text);
                acces = true;
            }
            catch
            { MessageBox.Show("Неверный формат ввода"); acces = false; }

            if (acces)
            {
                string query = "INSERT INTO SkladTable ([NameItem],[CountItem]) VALUES " + "('" + textBox1.Text + "','" + textBox3.Text + "')";
                OleDbCommand command = new OleDbCommand(query, myConnection);
                command.ExecuteNonQuery();
                MessageBox.Show("Элемент успешно добавлен");
                Filler();
            }
        }

        private void EditSklad_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string name=listBox1.SelectedItem.ToString();
                int count = int.Parse(textBox2.Text);
                string query = "UPDATE SkladTable SET CountItem = "+"'"+count+"'"+ "WHERE NameItem = "+"'"+name+"'";
                OleDbCommand command = new OleDbCommand(query, myConnection);
                command.ExecuteNonQuery();
                MessageBox.Show("Значение успешно изменено");
                Filler();
            }
            catch { MessageBox.Show("Неверный формат ввода"); }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Skald skald = new Skald();
            skald.Show();
            this.Close();
        }
    }
}
