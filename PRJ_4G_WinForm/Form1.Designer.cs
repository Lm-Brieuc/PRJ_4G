namespace PRJ_4G_WinForm
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox_Selection = new System.Windows.Forms.TextBox();
            this.label_Avaliable_Antennes = new System.Windows.Forms.Label();
            this.listBox_listAntennes = new System.Windows.Forms.ListBox();
            this.textBox_Coords = new System.Windows.Forms.TextBox();
            this.label_Coords = new System.Windows.Forms.Label();
            this.carte = new GMap.NET.WindowsForms.GMapControl();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox_Operateur = new System.Windows.Forms.ComboBox();
            this.comboBox_Communes = new System.Windows.Forms.ComboBox();
            this.textBox_num_antennes_Communes = new System.Windows.Forms.TextBox();
            this.label_Operateur = new System.Windows.Forms.Label();
            this.textBox_Communes = new System.Windows.Forms.TextBox();
            this.comboBox_Departemet = new System.Windows.Forms.ComboBox();
            this.textBox_Departement = new System.Windows.Forms.TextBox();
            this.label_Communes = new System.Windows.Forms.Label();
            this.textBox_num_Tech = new System.Windows.Forms.TextBox();
            this.label_Departement = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label_Technologie = new System.Windows.Forms.Label();
            this.textBox_Operateur = new System.Windows.Forms.TextBox();
            this.textBox_Tech = new System.Windows.Forms.TextBox();
            this.comboBox_Technologie = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_commune = new System.Windows.Forms.Label();
            this.label_tech = new System.Windows.Forms.Label();
            this.label_op = new System.Windows.Forms.Label();
            this.label_dep = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_Selection
            // 
            this.textBox_Selection.Enabled = false;
            this.textBox_Selection.Location = new System.Drawing.Point(271, 102);
            this.textBox_Selection.Multiline = true;
            this.textBox_Selection.Name = "textBox_Selection";
            this.textBox_Selection.ReadOnly = true;
            this.textBox_Selection.Size = new System.Drawing.Size(201, 29);
            this.textBox_Selection.TabIndex = 10;
            this.textBox_Selection.TextChanged += new System.EventHandler(this.textBox_Selection_TextChanged);
            // 
            // label_Avaliable_Antennes
            // 
            this.label_Avaliable_Antennes.AutoSize = true;
            this.label_Avaliable_Antennes.BackColor = System.Drawing.Color.Transparent;
            this.label_Avaliable_Antennes.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Avaliable_Antennes.ForeColor = System.Drawing.Color.Teal;
            this.label_Avaliable_Antennes.Location = new System.Drawing.Point(271, 76);
            this.label_Avaliable_Antennes.Name = "label_Avaliable_Antennes";
            this.label_Avaliable_Antennes.Size = new System.Drawing.Size(175, 23);
            this.label_Avaliable_Antennes.TabIndex = 11;
            this.label_Avaliable_Antennes.Text = "Antennes Disponible";
            this.label_Avaliable_Antennes.Click += new System.EventHandler(this.label_Avaliable_Antennes_Click);
            // 
            // listBox_listAntennes
            // 
            this.listBox_listAntennes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox_listAntennes.FormattingEnabled = true;
            this.listBox_listAntennes.ItemHeight = 20;
            this.listBox_listAntennes.Location = new System.Drawing.Point(852, 265);
            this.listBox_listAntennes.Name = "listBox_listAntennes";
            this.listBox_listAntennes.Size = new System.Drawing.Size(171, 260);
            this.listBox_listAntennes.TabIndex = 22;
            this.listBox_listAntennes.SelectedIndexChanged += new System.EventHandler(this.listBox_listAntennes_SelectedIndexChanged);
            // 
            // textBox_Coords
            // 
            this.textBox_Coords.Enabled = false;
            this.textBox_Coords.Location = new System.Drawing.Point(522, 101);
            this.textBox_Coords.Multiline = true;
            this.textBox_Coords.Name = "textBox_Coords";
            this.textBox_Coords.ReadOnly = true;
            this.textBox_Coords.Size = new System.Drawing.Size(202, 30);
            this.textBox_Coords.TabIndex = 23;
            this.textBox_Coords.TextChanged += new System.EventHandler(this.textBox_Coords_TextChanged);
            // 
            // label_Coords
            // 
            this.label_Coords.AutoSize = true;
            this.label_Coords.BackColor = System.Drawing.Color.Transparent;
            this.label_Coords.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Coords.ForeColor = System.Drawing.Color.Teal;
            this.label_Coords.Location = new System.Drawing.Point(522, 75);
            this.label_Coords.Name = "label_Coords";
            this.label_Coords.Size = new System.Drawing.Size(106, 23);
            this.label_Coords.TabIndex = 24;
            this.label_Coords.Text = "Coordonnés";
            this.label_Coords.Click += new System.EventHandler(this.label_Coords_Click);
            // 
            // carte
            // 
            this.carte.Bearing = 0F;
            this.carte.CanDragMap = true;
            this.carte.EmptyTileColor = System.Drawing.Color.Navy;
            this.carte.GrayScaleMode = false;
            this.carte.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.carte.LevelsKeepInMemory = 5;
            this.carte.Location = new System.Drawing.Point(269, 165);
            this.carte.MarkersEnabled = true;
            this.carte.MaxZoom = 30;
            this.carte.MinZoom = 2;
            this.carte.MouseWheelZoomEnabled = true;
            this.carte.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.carte.Name = "carte";
            this.carte.NegativeMode = false;
            this.carte.PolygonsEnabled = true;
            this.carte.RetryLoadTile = 0;
            this.carte.RoutesEnabled = true;
            this.carte.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.carte.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.carte.ShowTileGridLines = false;
            this.carte.Size = new System.Drawing.Size(552, 364);
            this.carte.TabIndex = 25;
            this.carte.Zoom = 0D;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(188, 120);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(47, 27);
            this.textBox1.TabIndex = 12;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // comboBox_Operateur
            // 
            this.comboBox_Operateur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.comboBox_Operateur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Operateur.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox_Operateur.FormattingEnabled = true;
            this.comboBox_Operateur.Location = new System.Drawing.Point(9, 230);
            this.comboBox_Operateur.Name = "comboBox_Operateur";
            this.comboBox_Operateur.Size = new System.Drawing.Size(173, 28);
            this.comboBox_Operateur.Sorted = true;
            this.comboBox_Operateur.TabIndex = 4;
            this.comboBox_Operateur.SelectedIndexChanged += new System.EventHandler(this.comboBox_Operateur_SelectedIndexChanged);
            // 
            // comboBox_Communes
            // 
            this.comboBox_Communes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.comboBox_Communes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Communes.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox_Communes.FormattingEnabled = true;
            this.comboBox_Communes.Location = new System.Drawing.Point(9, 342);
            this.comboBox_Communes.Name = "comboBox_Communes";
            this.comboBox_Communes.Size = new System.Drawing.Size(170, 28);
            this.comboBox_Communes.Sorted = true;
            this.comboBox_Communes.TabIndex = 21;
            this.comboBox_Communes.SelectedIndexChanged += new System.EventHandler(this.comboBox_Communes_SelectedIndexChanged);
            // 
            // textBox_num_antennes_Communes
            // 
            this.textBox_num_antennes_Communes.Enabled = false;
            this.textBox_num_antennes_Communes.Location = new System.Drawing.Point(188, 452);
            this.textBox_num_antennes_Communes.Name = "textBox_num_antennes_Communes";
            this.textBox_num_antennes_Communes.ReadOnly = true;
            this.textBox_num_antennes_Communes.Size = new System.Drawing.Size(47, 27);
            this.textBox_num_antennes_Communes.TabIndex = 24;
            this.textBox_num_antennes_Communes.TextChanged += new System.EventHandler(this.textBox_num_antennes_Communes_TextChanged);
            // 
            // label_Operateur
            // 
            this.label_Operateur.AutoSize = true;
            this.label_Operateur.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Operateur.ForeColor = System.Drawing.Color.White;
            this.label_Operateur.Location = new System.Drawing.Point(5, 204);
            this.label_Operateur.Name = "label_Operateur";
            this.label_Operateur.Size = new System.Drawing.Size(109, 23);
            this.label_Operateur.TabIndex = 5;
            this.label_Operateur.Text = "Operateur :";
            // 
            // textBox_Communes
            // 
            this.textBox_Communes.Enabled = false;
            this.textBox_Communes.Location = new System.Drawing.Point(117, 109);
            this.textBox_Communes.Name = "textBox_Communes";
            this.textBox_Communes.ReadOnly = true;
            this.textBox_Communes.Size = new System.Drawing.Size(48, 27);
            this.textBox_Communes.TabIndex = 23;
            this.textBox_Communes.TextChanged += new System.EventHandler(this.textBox_Communes_TextChanged);
            // 
            // comboBox_Departemet
            // 
            this.comboBox_Departemet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.comboBox_Departemet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Departemet.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox_Departemet.FormattingEnabled = true;
            this.comboBox_Departemet.Location = new System.Drawing.Point(9, 120);
            this.comboBox_Departemet.Name = "comboBox_Departemet";
            this.comboBox_Departemet.Size = new System.Drawing.Size(173, 28);
            this.comboBox_Departemet.Sorted = true;
            this.comboBox_Departemet.TabIndex = 2;
            this.comboBox_Departemet.SelectedIndexChanged += new System.EventHandler(this.comboBox_Departemet_SelectedIndexChanged);
            this.comboBox_Departemet.SelectedValueChanged += new System.EventHandler(this.comboBox_Departemet_SelectedValueChanged);
            // 
            // textBox_Departement
            // 
            this.textBox_Departement.CausesValidation = false;
            this.textBox_Departement.Enabled = false;
            this.textBox_Departement.Location = new System.Drawing.Point(117, 43);
            this.textBox_Departement.Multiline = true;
            this.textBox_Departement.Name = "textBox_Departement";
            this.textBox_Departement.ReadOnly = true;
            this.textBox_Departement.Size = new System.Drawing.Size(48, 28);
            this.textBox_Departement.TabIndex = 6;
            this.textBox_Departement.TextChanged += new System.EventHandler(this.textBox_Departement_TextChanged);
            // 
            // label_Communes
            // 
            this.label_Communes.AutoSize = true;
            this.label_Communes.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Communes.ForeColor = System.Drawing.Color.White;
            this.label_Communes.Location = new System.Drawing.Point(9, 315);
            this.label_Communes.Name = "label_Communes";
            this.label_Communes.Size = new System.Drawing.Size(111, 23);
            this.label_Communes.TabIndex = 22;
            this.label_Communes.Text = "Communes :";
            this.label_Communes.Click += new System.EventHandler(this.label_Communes_Click);
            // 
            // textBox_num_Tech
            // 
            this.textBox_num_Tech.Enabled = false;
            this.textBox_num_Tech.Location = new System.Drawing.Point(188, 342);
            this.textBox_num_Tech.Name = "textBox_num_Tech";
            this.textBox_num_Tech.ReadOnly = true;
            this.textBox_num_Tech.Size = new System.Drawing.Size(47, 27);
            this.textBox_num_Tech.TabIndex = 20;
            this.textBox_num_Tech.TextChanged += new System.EventHandler(this.textBox_num_Tech_TextChanged);
            // 
            // label_Departement
            // 
            this.label_Departement.AutoSize = true;
            this.label_Departement.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Departement.ForeColor = System.Drawing.Color.White;
            this.label_Departement.Location = new System.Drawing.Point(5, 94);
            this.label_Departement.Name = "label_Departement";
            this.label_Departement.Size = new System.Drawing.Size(133, 23);
            this.label_Departement.TabIndex = 3;
            this.label_Departement.Text = "Departement :";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(188, 231);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(47, 27);
            this.textBox2.TabIndex = 14;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label_Technologie
            // 
            this.label_Technologie.AutoSize = true;
            this.label_Technologie.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Technologie.ForeColor = System.Drawing.Color.White;
            this.label_Technologie.Location = new System.Drawing.Point(11, 425);
            this.label_Technologie.Name = "label_Technologie";
            this.label_Technologie.Size = new System.Drawing.Size(122, 23);
            this.label_Technologie.TabIndex = 17;
            this.label_Technologie.Text = "Technologies :";
            this.label_Technologie.Click += new System.EventHandler(this.label_Technologie_Click);
            // 
            // textBox_Operateur
            // 
            this.textBox_Operateur.Enabled = false;
            this.textBox_Operateur.Location = new System.Drawing.Point(117, 75);
            this.textBox_Operateur.Multiline = true;
            this.textBox_Operateur.Name = "textBox_Operateur";
            this.textBox_Operateur.ReadOnly = true;
            this.textBox_Operateur.Size = new System.Drawing.Size(48, 28);
            this.textBox_Operateur.TabIndex = 7;
            this.textBox_Operateur.TextChanged += new System.EventHandler(this.textBox_Operateur_TextChanged);
            // 
            // textBox_Tech
            // 
            this.textBox_Tech.Enabled = false;
            this.textBox_Tech.Location = new System.Drawing.Point(117, 142);
            this.textBox_Tech.Multiline = true;
            this.textBox_Tech.Name = "textBox_Tech";
            this.textBox_Tech.ReadOnly = true;
            this.textBox_Tech.Size = new System.Drawing.Size(48, 27);
            this.textBox_Tech.TabIndex = 18;
            this.textBox_Tech.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // comboBox_Technologie
            // 
            this.comboBox_Technologie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.comboBox_Technologie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Technologie.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox_Technologie.FormattingEnabled = true;
            this.comboBox_Technologie.Location = new System.Drawing.Point(9, 452);
            this.comboBox_Technologie.Name = "comboBox_Technologie";
            this.comboBox_Technologie.Size = new System.Drawing.Size(170, 28);
            this.comboBox_Technologie.Sorted = true;
            this.comboBox_Technologie.TabIndex = 16;
            this.comboBox_Technologie.SelectedIndexChanged += new System.EventHandler(this.comboBox_Technologie_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(79)))));
            this.panel1.Controls.Add(this.textBox_num_antennes_Communes);
            this.panel1.Controls.Add(this.textBox_num_Tech);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.comboBox_Departemet);
            this.panel1.Controls.Add(this.label_Operateur);
            this.panel1.Controls.Add(this.comboBox_Technologie);
            this.panel1.Controls.Add(this.comboBox_Operateur);
            this.panel1.Controls.Add(this.label_Technologie);
            this.panel1.Controls.Add(this.label_Communes);
            this.panel1.Controls.Add(this.label_Departement);
            this.panel1.Controls.Add(this.comboBox_Communes);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 542);
            this.panel1.TabIndex = 26;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panel2.Location = new System.Drawing.Point(2, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(245, 55);
            this.panel2.TabIndex = 23;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panel3.Location = new System.Drawing.Point(244, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(805, 56);
            this.panel3.TabIndex = 27;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.groupBox1.Controls.Add(this.label_commune);
            this.groupBox1.Controls.Add(this.label_tech);
            this.groupBox1.Controls.Add(this.label_op);
            this.groupBox1.Controls.Add(this.label_dep);
            this.groupBox1.Controls.Add(this.textBox_Departement);
            this.groupBox1.Controls.Add(this.textBox_Communes);
            this.groupBox1.Controls.Add(this.textBox_Operateur);
            this.groupBox1.Controls.Add(this.textBox_Tech);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.No;
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(852, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(171, 182);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Information : ";
            // 
            // label_commune
            // 
            this.label_commune.AutoSize = true;
            this.label_commune.ForeColor = System.Drawing.Color.White;
            this.label_commune.Location = new System.Drawing.Point(6, 109);
            this.label_commune.Name = "label_commune";
            this.label_commune.Size = new System.Drawing.Size(83, 20);
            this.label_commune.TabIndex = 27;
            this.label_commune.Text = "Communes";
            // 
            // label_tech
            // 
            this.label_tech.AutoSize = true;
            this.label_tech.ForeColor = System.Drawing.Color.White;
            this.label_tech.Location = new System.Drawing.Point(6, 145);
            this.label_tech.Name = "label_tech";
            this.label_tech.Size = new System.Drawing.Size(96, 20);
            this.label_tech.TabIndex = 26;
            this.label_tech.Text = "Technologies";
            // 
            // label_op
            // 
            this.label_op.AutoSize = true;
            this.label_op.ForeColor = System.Drawing.Color.White;
            this.label_op.Location = new System.Drawing.Point(8, 78);
            this.label_op.Name = "label_op";
            this.label_op.Size = new System.Drawing.Size(82, 20);
            this.label_op.TabIndex = 25;
            this.label_op.Text = "Opérateurs";
            // 
            // label_dep
            // 
            this.label_dep.AutoSize = true;
            this.label_dep.ForeColor = System.Drawing.Color.White;
            this.label_dep.Location = new System.Drawing.Point(8, 43);
            this.label_dep.Name = "label_dep";
            this.label_dep.Size = new System.Drawing.Size(103, 20);
            this.label_dep.TabIndex = 24;
            this.label_dep.Text = "Départements";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1045, 541);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.carte);
            this.Controls.Add(this.label_Coords);
            this.Controls.Add(this.textBox_Coords);
            this.Controls.Add(this.textBox_Selection);
            this.Controls.Add(this.listBox_listAntennes);
            this.Controls.Add(this.label_Avaliable_Antennes);
            this.Name = "Form1";
            this.Text = "Projet Antennes";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox textBox_Selection;
        private Label label_Avaliable_Antennes;
        private ListBox listBox_listAntennes;
        private TextBox textBox_Coords;
        private Label label_Coords;
        private GMap.NET.WindowsForms.GMapControl carte;
        private TextBox textBox1;
        private ComboBox comboBox_Operateur;
        private ComboBox comboBox_Communes;
        private TextBox textBox_num_antennes_Communes;
        private Label label_Operateur;
        private TextBox textBox_Communes;
        private ComboBox comboBox_Departemet;
        private TextBox textBox_Departement;
        private Label label_Communes;
        private TextBox textBox_num_Tech;
        private Label label_Departement;
        private TextBox textBox2;
        private Label label_Technologie;
        private TextBox textBox_Operateur;
        private TextBox textBox_Tech;
        private ComboBox comboBox_Technologie;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private GroupBox groupBox1;
        private Label label_dep;
        private Label label_op;
        private Label label_tech;
        private Label label_commune;
    }
}