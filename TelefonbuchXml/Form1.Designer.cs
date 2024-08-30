namespace TelefonbuchXml
{
    partial class TelefonbuchXml
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtVorname = new TextBox();
            txtName = new TextBox();
            label2 = new Label();
            txtTelefon = new TextBox();
            label3 = new Label();
            txtEmail = new TextBox();
            label4 = new Label();
            btnPersonHinzufügen = new Button();
            btnPresonLöschen = new Button();
            btnBeenden = new Button();
            btnSpechern = new Button();
            btnLaden = new Button();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 8);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Vorname";
            // 
            // txtVorname
            // 
            txtVorname.Location = new Point(13, 26);
            txtVorname.Name = "txtVorname";
            txtVorname.Size = new Size(100, 23);
            txtVorname.TabIndex = 1;
            txtVorname.Text = "Max";
            // 
            // txtName
            // 
            txtName.Location = new Point(119, 26);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 3;
            txtName.Text = "Muster";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(119, 8);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 2;
            label2.Text = "Name";
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(225, 26);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(100, 23);
            txtTelefon.TabIndex = 5;
            txtTelefon.Text = "089 345678";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(225, 8);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 4;
            label3.Text = "Telefon";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(331, 26);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 7;
            txtEmail.Text = "m.m@gm.de";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(331, 8);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 6;
            label4.Text = "Email";
            // 
            // btnPersonHinzufügen
            // 
            btnPersonHinzufügen.Location = new Point(437, 26);
            btnPersonHinzufügen.Name = "btnPersonHinzufügen";
            btnPersonHinzufügen.Size = new Size(123, 23);
            btnPersonHinzufügen.TabIndex = 8;
            btnPersonHinzufügen.Text = "Person hinzufügen";
            btnPersonHinzufügen.UseVisualStyleBackColor = true;
            btnPersonHinzufügen.Click += btnPersonHinzufügen_Click;
            // 
            // btnPresonLöschen
            // 
            btnPresonLöschen.Location = new Point(437, 55);
            btnPresonLöschen.Name = "btnPresonLöschen";
            btnPresonLöschen.Size = new Size(123, 23);
            btnPresonLöschen.TabIndex = 9;
            btnPresonLöschen.Text = "Person löschen";
            btnPresonLöschen.UseVisualStyleBackColor = true;
            btnPresonLöschen.Click += btnPresonLöschen_Click;
            // 
            // btnBeenden
            // 
            btnBeenden.Location = new Point(437, 84);
            btnBeenden.Name = "btnBeenden";
            btnBeenden.Size = new Size(123, 23);
            btnBeenden.TabIndex = 10;
            btnBeenden.Text = "Beenden";
            btnBeenden.UseVisualStyleBackColor = true;
            btnBeenden.Click += btnBeenden_Click;
            // 
            // btnSpechern
            // 
            btnSpechern.Location = new Point(331, 84);
            btnSpechern.Name = "btnSpechern";
            btnSpechern.Size = new Size(100, 23);
            btnSpechern.TabIndex = 11;
            btnSpechern.Text = "Speichern";
            btnSpechern.UseVisualStyleBackColor = true;
            btnSpechern.Click += btnSpechern_Click;
            // 
            // btnLaden
            // 
            btnLaden.Location = new Point(225, 84);
            btnLaden.Name = "btnLaden";
            btnLaden.Size = new Size(100, 23);
            btnLaden.TabIndex = 12;
            btnLaden.Text = "Laden";
            btnLaden.UseVisualStyleBackColor = true;
            btnLaden.Click += btnLaden_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtVorname);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnLaden);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnSpechern);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(btnBeenden);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btnPresonLöschen);
            panel1.Controls.Add(txtTelefon);
            panel1.Controls.Add(btnPersonHinzufügen);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtEmail);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(572, 120);
            panel1.TabIndex = 14;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Location = new Point(319, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(8, 8);
            tableLayoutPanel1.TabIndex = 15;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 120);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(572, 176);
            dataGridView1.TabIndex = 16;
            dataGridView1.CellClick += dataGridView1_CellContentClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // TelefonbuchXml
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(572, 296);
            Controls.Add(dataGridView1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            Name = "TelefonbuchXml";
            Text = "TelefonbuchXml";
            FormClosing += TelefonbuchXml_FormClosing;
            Load += TelefonbuchXml_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox txtVorname;
        private TextBox txtName;
        private Label label2;
        private TextBox txtTelefon;
        private Label label3;
        private TextBox txtEmail;
        private Label label4;
        private Button btnPersonHinzufügen;
        private Button btnPresonLöschen;
        private Button btnBeenden;
        private Button btnSpechern;
        private Button btnLaden;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dataGridView1;
    }
}
