
namespace GestionEmployeeApp
{
    partial class Employee
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txt_recherche = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.gestion_employeesDataSet2 = new GestionEmployeeApp.gestion_employeesDataSet2();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesTableAdapter = new GestionEmployeeApp.gestion_employeesDataSet2TableAdapters.employeesTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDownAge = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownId = new System.Windows.Forms.NumericUpDown();
            this.comboBoxDep = new System.Windows.Forms.ComboBox();
            this.departementsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestion_employeesDataSet5 = new GestionEmployeeApp.gestion_employeesDataSet5();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_prenom = new System.Windows.Forms.TextBox();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.departementsTableAdapter = new GestionEmployeeApp.gestion_employeesDataSet5TableAdapters.departementsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_employeesDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departementsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_employeesDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(401, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 267);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(397, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Employees";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(357, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 25);
            this.button1.TabIndex = 2;
            this.button1.Text = "Nouveau";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::GestionEmployeeApp.Properties.Resources.cooling_symbol_3318;
            this.button2.Location = new System.Drawing.Point(133, 225);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 36);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = global::GestionEmployeeApp.Properties.Resources.user_logout_304;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.Location = new System.Drawing.Point(269, 225);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 36);
            this.button3.TabIndex = 4;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(755, 68);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(89, 27);
            this.button4.TabIndex = 5;
            this.button4.Text = "Rechercher";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txt_recherche
            // 
            this.txt_recherche.Location = new System.Drawing.Point(578, 72);
            this.txt_recherche.Name = "txt_recherche";
            this.txt_recherche.Size = new System.Drawing.Size(171, 20);
            this.txt_recherche.TabIndex = 6;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button5.Image = global::GestionEmployeeApp.Properties.Resources.house_4278;
            this.button5.Location = new System.Drawing.Point(12, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(101, 35);
            this.button5.TabIndex = 7;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button6.Image = global::GestionEmployeeApp.Properties.Resources.exit_logout_2857;
            this.button6.Location = new System.Drawing.Point(743, 12);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(101, 35);
            this.button6.TabIndex = 8;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // gestion_employeesDataSet2
            // 
            this.gestion_employeesDataSet2.DataSetName = "gestion_employeesDataSet2";
            this.gestion_employeesDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "employees";
            this.employeesBindingSource.DataSource = this.gestion_employeesDataSet2;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDownAge);
            this.groupBox1.Controls.Add(this.numericUpDownId);
            this.groupBox1.Controls.Add(this.comboBoxDep);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_prenom);
            this.groupBox1.Controls.Add(this.txt_nom);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 276);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modifier employee";
            // 
            // numericUpDownAge
            // 
            this.numericUpDownAge.Location = new System.Drawing.Point(140, 140);
            this.numericUpDownAge.Name = "numericUpDownAge";
            this.numericUpDownAge.Size = new System.Drawing.Size(224, 22);
            this.numericUpDownAge.TabIndex = 21;
            // 
            // numericUpDownId
            // 
            this.numericUpDownId.Location = new System.Drawing.Point(140, 29);
            this.numericUpDownId.Name = "numericUpDownId";
            this.numericUpDownId.Size = new System.Drawing.Size(224, 22);
            this.numericUpDownId.TabIndex = 14;
            // 
            // comboBoxDep
            // 
            this.comboBoxDep.BackColor = System.Drawing.Color.White;
            this.comboBoxDep.CausesValidation = false;
            this.comboBoxDep.DataSource = this.departementsBindingSource;
            this.comboBoxDep.DisplayMember = "nom";
            this.comboBoxDep.ForeColor = System.Drawing.Color.Black;
            this.comboBoxDep.FormattingEnabled = true;
            this.comboBoxDep.Location = new System.Drawing.Point(140, 179);
            this.comboBoxDep.Name = "comboBoxDep";
            this.comboBoxDep.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBoxDep.Size = new System.Drawing.Size(225, 24);
            this.comboBoxDep.TabIndex = 20;
            this.comboBoxDep.ValueMember = "id";
            // 
            // departementsBindingSource
            // 
            this.departementsBindingSource.DataMember = "departements";
            this.departementsBindingSource.DataSource = this.gestion_employeesDataSet5;
            // 
            // gestion_employeesDataSet5
            // 
            this.gestion_employeesDataSet5.DataSetName = "gestion_employeesDataSet5";
            this.gestion_employeesDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 19);
            this.label5.TabIndex = 17;
            this.label5.Text = "Departement:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 19);
            this.label4.TabIndex = 16;
            this.label4.Text = "Age:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 19);
            this.label2.TabIndex = 15;
            this.label2.Text = "Prénom:";
            // 
            // txt_prenom
            // 
            this.txt_prenom.Location = new System.Drawing.Point(140, 103);
            this.txt_prenom.Name = "txt_prenom";
            this.txt_prenom.Size = new System.Drawing.Size(224, 22);
            this.txt_prenom.TabIndex = 12;
            // 
            // txt_nom
            // 
            this.txt_nom.Location = new System.Drawing.Point(140, 64);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(224, 22);
            this.txt_nom.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nom:";
            // 
            // departementsTableAdapter
            // 
            this.departementsTableAdapter.ClearBeforeFill = true;
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 444);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.txt_recherche);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Employee";
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.Employee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_employeesDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departementsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_employeesDataSet5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txt_recherche;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private gestion_employeesDataSet2 gestion_employeesDataSet2;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private gestion_employeesDataSet2TableAdapters.employeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_prenom;
        private gestion_employeesDataSet5 gestion_employeesDataSet5;
        private System.Windows.Forms.BindingSource departementsBindingSource;
        private gestion_employeesDataSet5TableAdapters.departementsTableAdapter departementsTableAdapter;
        public System.Windows.Forms.ComboBox comboBoxDep;
        private System.Windows.Forms.NumericUpDown numericUpDownId;
        private System.Windows.Forms.NumericUpDown numericUpDownAge;
    }
}