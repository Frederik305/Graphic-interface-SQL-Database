﻿namespace Form_Fontions
{
    partial class ListTablesForm
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
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            panel2 = new Panel();
            panel4 = new Panel();
            checkBox1 = new CheckBox();
            buttonUpdate = new Button();
            checkBoxEdit = new CheckBox();
            label3 = new Label();
            panel3 = new Panel();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            Epreuve = new Button();
            Tournoi = new Button();
            MatchTennis = new Button();
            Joueur = new Button();
            ScoresVainqueurs = new Button();
            label2 = new Label();
            buttonClear = new Button();
            panel1 = new Panel();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox1.Location = new Point(30, 68);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Search";
            textBox1.Size = new Size(136, 23);
            textBox1.TabIndex = 17;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(30, 39);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(136, 23);
            comboBox1.TabIndex = 18;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 450);
            panel2.TabIndex = 19;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ControlLightLight;
            panel4.Controls.Add(checkBox1);
            panel4.Controls.Add(buttonUpdate);
            panel4.Controls.Add(checkBoxEdit);
            panel4.Controls.Add(label3);
            panel4.Location = new Point(0, 131);
            panel4.Name = "panel4";
            panel4.Size = new Size(200, 135);
            panel4.TabIndex = 20;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Enabled = false;
            checkBox1.Location = new Point(39, 64);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(65, 19);
            checkBox1.TabIndex = 22;
            checkBox1.Text = "Edit IDs";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Enabled = false;
            buttonUpdate.Location = new Point(30, 89);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(113, 31);
            buttonUpdate.TabIndex = 21;
            buttonUpdate.Text = "Save Changes";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // checkBoxEdit
            // 
            checkBoxEdit.AutoSize = true;
            checkBoxEdit.Enabled = false;
            checkBoxEdit.Location = new Point(39, 39);
            checkBoxEdit.Name = "checkBoxEdit";
            checkBoxEdit.Size = new Size(46, 19);
            checkBoxEdit.TabIndex = 20;
            checkBoxEdit.Text = "Edit";
            checkBoxEdit.UseVisualStyleBackColor = true;
            checkBoxEdit.CheckedChanged += checkBoxEdit_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 21);
            label3.Name = "label3";
            label3.Size = new Size(113, 15);
            label3.TabIndex = 19;
            label3.Text = "Edit content in table";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlLightLight;
            panel3.Controls.Add(label1);
            panel3.Controls.Add(comboBox1);
            panel3.Controls.Add(textBox1);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 125);
            panel3.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 21);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 19;
            label1.Text = "Search by columns";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ControlLight;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(200, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(709, 393);
            dataGridView1.TabIndex = 25;
            dataGridView1.CellEndEdit += dataGridView1_CellEndEdit_1;
            // 
            // Epreuve
            // 
            Epreuve.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Epreuve.Location = new Point(520, 411);
            Epreuve.Name = "Epreuve";
            Epreuve.Size = new Size(75, 23);
            Epreuve.TabIndex = 11;
            Epreuve.Text = "Epreuve";
            Epreuve.UseVisualStyleBackColor = true;
            Epreuve.Click += Epreuve_Click;
            // 
            // Tournoi
            // 
            Tournoi.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Tournoi.Location = new Point(439, 411);
            Tournoi.Name = "Tournoi";
            Tournoi.Size = new Size(75, 23);
            Tournoi.TabIndex = 10;
            Tournoi.Text = "Tournoi";
            Tournoi.UseVisualStyleBackColor = true;
            Tournoi.Click += Tournoi_Click;
            // 
            // MatchTennis
            // 
            MatchTennis.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            MatchTennis.Location = new Point(601, 411);
            MatchTennis.Name = "MatchTennis";
            MatchTennis.Size = new Size(89, 23);
            MatchTennis.TabIndex = 12;
            MatchTennis.Text = "Match tennis";
            MatchTennis.UseVisualStyleBackColor = true;
            MatchTennis.Click += MatchTennis_Click;
            // 
            // Joueur
            // 
            Joueur.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Joueur.Location = new Point(358, 411);
            Joueur.Name = "Joueur";
            Joueur.Size = new Size(75, 23);
            Joueur.TabIndex = 8;
            Joueur.Text = "Joueur";
            Joueur.UseVisualStyleBackColor = true;
            Joueur.Click += Joueur_Click;
            // 
            // ScoresVainqueurs
            // 
            ScoresVainqueurs.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ScoresVainqueurs.Location = new Point(696, 411);
            ScoresVainqueurs.Name = "ScoresVainqueurs";
            ScoresVainqueurs.Size = new Size(115, 23);
            ScoresVainqueurs.TabIndex = 13;
            ScoresVainqueurs.Text = "Scores Vainqueurs";
            ScoresVainqueurs.UseVisualStyleBackColor = true;
            ScoresVainqueurs.Click += ScoresVainqueurs_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(206, 415);
            label2.Name = "label2";
            label2.Size = new Size(146, 15);
            label2.TabIndex = 14;
            label2.Text = "Choisire la table a afficher:";
            // 
            // buttonClear
            // 
            buttonClear.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonClear.Location = new Point(817, 411);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(75, 23);
            buttonClear.TabIndex = 15;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(200, 450);
            panel1.Name = "panel1";
            panel1.Size = new Size(709, 0);
            panel1.TabIndex = 16;
            // 
            // ListTablesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(909, 450);
            Controls.Add(buttonClear);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(ScoresVainqueurs);
            Controls.Add(panel1);
            Controls.Add(Joueur);
            Controls.Add(panel2);
            Controls.Add(MatchTennis);
            Controls.Add(Epreuve);
            Controls.Add(Tournoi);
            MinimumSize = new Size(925, 489);
            Name = "ListTablesForm";
            Text = "ListTablesForm";
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private Panel panel4;
        private Label label3;
        private CheckBox checkBoxEdit;
        private Button buttonUpdate;
        private CheckBox checkBox1;
        private DataGridView dataGridView1;
        private Button Epreuve;
        private Button Tournoi;
        private Button MatchTennis;
        private Button Joueur;
        private Button ScoresVainqueurs;
        private Label label2;
        private Button buttonClear;
        private Panel panel1;
    }
}