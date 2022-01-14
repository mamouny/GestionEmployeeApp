
namespace GestionEmployeeApp
{
    partial class AjoutEmployee
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
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txt_prenom = new System.Windows.Forms.TextBox();
            this.txt_departement = new System.Windows.Forms.ComboBox();
            this.departementsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestion_employeesDataSet = new GestionEmployeeApp.gestion_employeesDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.departementsTableAdapter = new GestionEmployeeApp.gestion_employeesDataSetTableAdapters.departementsTableAdapter();
            this.numericUpDownAge = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.departementsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_employeesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAge)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_nom
            // 
            this.txt_nom.Location = new System.Drawing.Point(236, 25);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(278, 26);
            this.txt_nom.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txt_prenom
            // 
            this.txt_prenom.Location = new System.Drawing.Point(236, 65);
            this.txt_prenom.Name = "txt_prenom";
            this.txt_prenom.Size = new System.Drawing.Size(278, 26);
            this.txt_prenom.TabIndex = 3;
            // 
            // txt_departement
            // 
            this.txt_departement.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txt_departement.DataSource = this.departementsBindingSource;
            this.txt_departement.DisplayMember = "nom";
            this.txt_departement.FormattingEnabled = true;
            this.txt_departement.Location = new System.Drawing.Point(236, 145);
            this.txt_departement.Name = "txt_departement";
            this.txt_departement.Size = new System.Drawing.Size(278, 26);
            this.txt_departement.TabIndex = 4;
            this.txt_departement.ValueMember = "id";
            // 
            // departementsBindingSource
            // 
            this.departementsBindingSource.DataMember = "departements";
            this.departementsBindingSource.DataSource = this.gestion_employeesDataSet;
            // 
            // gestion_employeesDataSet
            // 
            this.gestion_employeesDataSet.DataSetName = "gestion_employeesDataSet";
            this.gestion_employeesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nom:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Prenom:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Age:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Departement:";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button1.Image = global::GestionEmployeeApp.Properties.Resources.blue_add_button_12024;
            this.button1.Location = new System.Drawing.Point(236, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 39);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // departementsTableAdapter
            // 
            this.departementsTableAdapter.ClearBeforeFill = true;
            // 
            // numericUpDownAge
            // 
            this.numericUpDownAge.Location = new System.Drawing.Point(236, 103);
            this.numericUpDownAge.Name = "numericUpDownAge";
            this.numericUpDownAge.Size = new System.Drawing.Size(278, 26);
            this.numericUpDownAge.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button2.Image = global::GestionEmployeeApp.Properties.Resources.cooling_symbol_33182;
            this.button2.Location = new System.Drawing.Point(398, 177);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 39);
            this.button2.TabIndex = 12;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_nom);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.txt_departement);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.numericUpDownAge);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_prenom);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(232, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(538, 225);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nouveau";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GestionEmployeeApp.Properties.Resources.add_user_302__1_;
            this.pictureBox1.Location = new System.Drawing.Point(34, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 225);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // AjoutEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "AjoutEmployee";
            this.Text = "AjoutEmployee";
            this.Load += new System.EventHandler(this.AjoutEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.departementsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_employeesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAge)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txt_prenom;
        private System.Windows.Forms.ComboBox txt_departement;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private gestion_employeesDataSet gestion_employeesDataSet;
        private System.Windows.Forms.BindingSource departementsBindingSource;
        private gestion_employeesDataSetTableAdapters.departementsTableAdapter departementsTableAdapter;
        private System.Windows.Forms.NumericUpDown numericUpDownAge;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}