
namespace GestionEmployeeApp
{
    partial class Departement
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewDep = new System.Windows.Forms.DataGridView();
            this.departementsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestion_employeesDataSet4 = new GestionEmployeeApp.gestion_employeesDataSet4();
            this.text_recherche = new System.Windows.Forms.TextBox();
            this.gestion_employeesDataSet3 = new GestionEmployeeApp.gestion_employeesDataSet3();
            this.gestionemployeesDataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departementsTableAdapter = new GestionEmployeeApp.gestion_employeesDataSet4TableAdapters.departementsTableAdapter();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.nom_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button5 = new System.Windows.Forms.Button();
            this.Home = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departementsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_employeesDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_employeesDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionemployeesDataSet3BindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(340, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Departements";
            // 
            // dataGridViewDep
            // 
            this.dataGridViewDep.AllowUserToAddRows = false;
            this.dataGridViewDep.AutoGenerateColumns = false;
            this.dataGridViewDep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDep.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn});
            this.dataGridViewDep.DataSource = this.departementsBindingSource;
            this.dataGridViewDep.Location = new System.Drawing.Point(456, 155);
            this.dataGridViewDep.Name = "dataGridViewDep";
            this.dataGridViewDep.Size = new System.Drawing.Size(326, 239);
            this.dataGridViewDep.TabIndex = 3;
            this.dataGridViewDep.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // departementsBindingSource
            // 
            this.departementsBindingSource.DataMember = "departements";
            this.departementsBindingSource.DataSource = this.gestion_employeesDataSet4;
            // 
            // gestion_employeesDataSet4
            // 
            this.gestion_employeesDataSet4.DataSetName = "gestion_employeesDataSet4";
            this.gestion_employeesDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // text_recherche
            // 
            this.text_recherche.Location = new System.Drawing.Point(527, 110);
            this.text_recherche.Name = "text_recherche";
            this.text_recherche.Size = new System.Drawing.Size(160, 20);
            this.text_recherche.TabIndex = 7;
            // 
            // gestion_employeesDataSet3
            // 
            this.gestion_employeesDataSet3.DataSetName = "gestion_employeesDataSet3";
            this.gestion_employeesDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gestionemployeesDataSet3BindingSource
            // 
            this.gestionemployeesDataSet3BindingSource.DataSource = this.gestion_employeesDataSet3;
            this.gestionemployeesDataSet3BindingSource.Position = 0;
            // 
            // departementsTableAdapter
            // 
            this.departementsTableAdapter.ClearBeforeFill = true;
            // 
            // txt_nom
            // 
            this.txt_nom.Location = new System.Drawing.Point(58, 32);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(224, 22);
            this.txt_nom.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nom:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_nom);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(37, 145);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 82);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Noveau departement";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numericUpDown1);
            this.groupBox2.Controls.Add(this.nom_txt);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(43, 257);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(363, 127);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modifier departement";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(133, 21);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(224, 22);
            this.numericUpDown1.TabIndex = 19;
            // 
            // nom_txt
            // 
            this.nom_txt.Location = new System.Drawing.Point(133, 55);
            this.nom_txt.Name = "nom_txt";
            this.nom_txt.Size = new System.Drawing.Size(224, 22);
            this.nom_txt.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nom:";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(693, 106);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 27);
            this.button2.TabIndex = 14;
            this.button2.Text = "Rechercher";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "nom";
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button5.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Image = global::GestionEmployeeApp.Properties.Resources.exit_logout_2857;
            this.button5.Location = new System.Drawing.Point(690, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(89, 39);
            this.button5.TabIndex = 20;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Home
            // 
            this.Home.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Home.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home.Image = global::GestionEmployeeApp.Properties.Resources.house_4278;
            this.Home.Location = new System.Drawing.Point(21, 12);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(89, 39);
            this.Home.TabIndex = 19;
            this.Home.UseVisualStyleBackColor = false;
            this.Home.Click += new System.EventHandler(this.button3_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Image = global::GestionEmployeeApp.Properties.Resources.cooling_symbol_3318;
            this.button7.Location = new System.Drawing.Point(133, 94);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(89, 27);
            this.button7.TabIndex = 5;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = global::GestionEmployeeApp.Properties.Resources.trash_can_10417;
            this.button4.Location = new System.Drawing.Point(268, 94);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(89, 27);
            this.button4.TabIndex = 8;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::GestionEmployeeApp.Properties.Resources.blue_add_button_12024;
            this.button1.Location = new System.Drawing.Point(288, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 31);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Departement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.text_recherche);
            this.Controls.Add(this.dataGridViewDep);
            this.Controls.Add(this.label1);
            this.Name = "Departement";
            this.Text = "Departement";
            this.Load += new System.EventHandler(this.Departement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departementsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_employeesDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_employeesDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionemployeesDataSet3BindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewDep;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox text_recherche;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.BindingSource gestionemployeesDataSet3BindingSource;
        private gestion_employeesDataSet3 gestion_employeesDataSet3;
        private gestion_employeesDataSet4 gestion_employeesDataSet4;
        private System.Windows.Forms.BindingSource departementsBindingSource;
        private gestion_employeesDataSet4TableAdapters.departementsTableAdapter departementsTableAdapter;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox nom_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
    }
}