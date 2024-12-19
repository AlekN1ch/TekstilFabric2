namespace TekstilFabric2
{
    partial class Skald
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameItemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countItemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skladTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fabricDataSet = new TekstilFabric2.fabricDataSet();
            this.skladTableTableAdapter = new TekstilFabric2.fabricDataSetTableAdapters.SkladTableTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fabricDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.YellowGreen;
            this.button3.Font = new System.Drawing.Font("Trebuchet MS", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(0, 168);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(161, 66);
            this.button3.TabIndex = 8;
            this.button3.Text = "Рецепты";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MediumOrchid;
            this.button2.Font = new System.Drawing.Font("Trebuchet MS", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(0, 96);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 66);
            this.button2.TabIndex = 7;
            this.button2.Text = "Главное меню";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MediumPurple;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn,
            this.nameItemDataGridViewTextBoxColumn,
            this.countItemDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.skladTableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(267, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(495, 333);
            this.dataGridView1.TabIndex = 9;
            // 
            // кодDataGridViewTextBoxColumn
            // 
            this.кодDataGridViewTextBoxColumn.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn.HeaderText = "Код";
            this.кодDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодDataGridViewTextBoxColumn.Name = "кодDataGridViewTextBoxColumn";
            this.кодDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameItemDataGridViewTextBoxColumn
            // 
            this.nameItemDataGridViewTextBoxColumn.DataPropertyName = "NameItem";
            this.nameItemDataGridViewTextBoxColumn.HeaderText = "NameItem";
            this.nameItemDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameItemDataGridViewTextBoxColumn.Name = "nameItemDataGridViewTextBoxColumn";
            this.nameItemDataGridViewTextBoxColumn.Width = 125;
            // 
            // countItemDataGridViewTextBoxColumn
            // 
            this.countItemDataGridViewTextBoxColumn.DataPropertyName = "CountItem";
            this.countItemDataGridViewTextBoxColumn.HeaderText = "CountItem";
            this.countItemDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.countItemDataGridViewTextBoxColumn.Name = "countItemDataGridViewTextBoxColumn";
            this.countItemDataGridViewTextBoxColumn.Width = 125;
            // 
            // skladTableBindingSource
            // 
            this.skladTableBindingSource.DataMember = "SkladTable";
            this.skladTableBindingSource.DataSource = this.fabricDataSet;
            // 
            // fabricDataSet
            // 
            this.fabricDataSet.DataSetName = "fabricDataSet";
            this.fabricDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // skladTableTableAdapter
            // 
            this.skladTableTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Trebuchet MS", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(12, 361);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 68);
            this.button1.TabIndex = 10;
            this.button1.Text = "Редактировать содержимое";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Skald
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TekstilFabric2.Properties.Resources.фон_текстиль;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(818, 497);
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "Skald";
            this.Text = "Skald";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Skald_FormClosing);
            this.Load += new System.EventHandler(this.Skald_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fabricDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private fabricDataSet fabricDataSet;
        private System.Windows.Forms.BindingSource skladTableBindingSource;
        private fabricDataSetTableAdapters.SkladTableTableAdapter skladTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameItemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countItemDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}