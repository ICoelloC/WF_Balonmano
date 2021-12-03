namespace Practicar_Balonmano.Ventanas.Partidos
{
    partial class FormPartidos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCategorías = new System.Windows.Forms.ComboBox();
            this.cmbEquipoLocal = new System.Windows.Forms.ComboBox();
            this.cmbEquipoVisitante = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.lblNombrePabellón = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblNumGolesLocal = new System.Windows.Forms.Label();
            this.lblGolesVisitante = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgEquipoLocal = new System.Windows.Forms.DataGridView();
            this.dgEquipoVisitante = new System.Windows.Forms.DataGridView();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pbEscudoVisitante = new System.Windows.Forms.PictureBox();
            this.pbEscudoLocal = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.dsBD = new Practicar_Balonmano.dsBD();
            ((System.ComponentModel.ISupportInitialize)(this.dgEquipoLocal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgEquipoVisitante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEscudoVisitante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEscudoLocal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBD)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "CATEGORÍA:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "EQUIPO LOCAL:";
            // 
            // cmbCategorías
            // 
            this.cmbCategorías.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategorías.FormattingEnabled = true;
            this.cmbCategorías.Location = new System.Drawing.Point(233, 29);
            this.cmbCategorías.Name = "cmbCategorías";
            this.cmbCategorías.Size = new System.Drawing.Size(206, 27);
            this.cmbCategorías.TabIndex = 2;
            this.cmbCategorías.SelectedIndexChanged += new System.EventHandler(this.cmbCategorías_SelectedIndexChanged);
            // 
            // cmbEquipoLocal
            // 
            this.cmbEquipoLocal.Enabled = false;
            this.cmbEquipoLocal.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEquipoLocal.FormattingEnabled = true;
            this.cmbEquipoLocal.Location = new System.Drawing.Point(233, 71);
            this.cmbEquipoLocal.Name = "cmbEquipoLocal";
            this.cmbEquipoLocal.Size = new System.Drawing.Size(206, 27);
            this.cmbEquipoLocal.TabIndex = 3;
            this.cmbEquipoLocal.SelectedIndexChanged += new System.EventHandler(this.cmbEquipoLocal_SelectedIndexChanged);
            // 
            // cmbEquipoVisitante
            // 
            this.cmbEquipoVisitante.Enabled = false;
            this.cmbEquipoVisitante.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEquipoVisitante.FormattingEnabled = true;
            this.cmbEquipoVisitante.Location = new System.Drawing.Point(715, 74);
            this.cmbEquipoVisitante.Name = "cmbEquipoVisitante";
            this.cmbEquipoVisitante.Size = new System.Drawing.Size(206, 27);
            this.cmbEquipoVisitante.TabIndex = 5;
            this.cmbEquipoVisitante.SelectedIndexChanged += new System.EventHandler(this.cmbEquipoVisitante_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(554, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "EQUIPO LOCAL:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(554, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "FECHA:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(721, 32);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 25);
            this.dtpFecha.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(452, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "PABELLÓN:";
            // 
            // lblNombrePabellón
            // 
            this.lblNombrePabellón.AutoSize = true;
            this.lblNombrePabellón.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombrePabellón.Location = new System.Drawing.Point(430, 162);
            this.lblNombrePabellón.Name = "lblNombrePabellón";
            this.lblNombrePabellón.Size = new System.Drawing.Size(57, 19);
            this.lblNombrePabellón.TabIndex = 9;
            this.lblNombrePabellón.Text = "nombre";
            this.lblNombrePabellón.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(115, 325);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "GOLES LOCAL: ";
            // 
            // lblNumGolesLocal
            // 
            this.lblNumGolesLocal.AutoSize = true;
            this.lblNumGolesLocal.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumGolesLocal.ForeColor = System.Drawing.Color.Ivory;
            this.lblNumGolesLocal.Location = new System.Drawing.Point(240, 315);
            this.lblNumGolesLocal.Name = "lblNumGolesLocal";
            this.lblNumGolesLocal.Size = new System.Drawing.Size(79, 31);
            this.lblNumGolesLocal.TabIndex = 13;
            this.lblNumGolesLocal.Text = "goles";
            // 
            // lblGolesVisitante
            // 
            this.lblGolesVisitante.AutoSize = true;
            this.lblGolesVisitante.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGolesVisitante.ForeColor = System.Drawing.Color.Ivory;
            this.lblGolesVisitante.Location = new System.Drawing.Point(826, 315);
            this.lblGolesVisitante.Name = "lblGolesVisitante";
            this.lblGolesVisitante.Size = new System.Drawing.Size(79, 31);
            this.lblGolesVisitante.TabIndex = 15;
            this.lblGolesVisitante.Text = "goles";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(701, 325);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 19);
            this.label8.TabIndex = 14;
            this.label8.Text = "GOLES LOCAL: ";
            // 
            // dgEquipoLocal
            // 
            this.dgEquipoLocal.AllowUserToAddRows = false;
            this.dgEquipoLocal.AllowUserToDeleteRows = false;
            this.dgEquipoLocal.AllowUserToOrderColumns = true;
            this.dgEquipoLocal.AllowUserToResizeColumns = false;
            this.dgEquipoLocal.AllowUserToResizeRows = false;
            this.dgEquipoLocal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgEquipoLocal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEquipoLocal.Enabled = false;
            this.dgEquipoLocal.Location = new System.Drawing.Point(113, 352);
            this.dgEquipoLocal.MultiSelect = false;
            this.dgEquipoLocal.Name = "dgEquipoLocal";
            this.dgEquipoLocal.ReadOnly = true;
            this.dgEquipoLocal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgEquipoLocal.Size = new System.Drawing.Size(329, 198);
            this.dgEquipoLocal.TabIndex = 16;
            // 
            // dgEquipoVisitante
            // 
            this.dgEquipoVisitante.AllowUserToAddRows = false;
            this.dgEquipoVisitante.AllowUserToDeleteRows = false;
            this.dgEquipoVisitante.AllowUserToOrderColumns = true;
            this.dgEquipoVisitante.AllowUserToResizeColumns = false;
            this.dgEquipoVisitante.AllowUserToResizeRows = false;
            this.dgEquipoVisitante.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgEquipoVisitante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEquipoVisitante.Enabled = false;
            this.dgEquipoVisitante.Location = new System.Drawing.Point(548, 352);
            this.dgEquipoVisitante.MultiSelect = false;
            this.dgEquipoVisitante.Name = "dgEquipoVisitante";
            this.dgEquipoVisitante.ReadOnly = true;
            this.dgEquipoVisitante.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgEquipoVisitante.Size = new System.Drawing.Size(329, 198);
            this.dgEquipoVisitante.TabIndex = 17;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Enabled = false;
            this.pictureBox4.Image = global::Practicar_Balonmano.Properties.Resources.boton_menos;
            this.pictureBox4.Location = new System.Drawing.Point(27, 460);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(63, 63);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 19;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Enabled = false;
            this.pictureBox3.Image = global::Practicar_Balonmano.Properties.Resources.mas;
            this.pictureBox3.Location = new System.Drawing.Point(27, 368);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(63, 63);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            // 
            // pbEscudoVisitante
            // 
            this.pbEscudoVisitante.Enabled = false;
            this.pbEscudoVisitante.Location = new System.Drawing.Point(699, 125);
            this.pbEscudoVisitante.Name = "pbEscudoVisitante";
            this.pbEscudoVisitante.Size = new System.Drawing.Size(178, 178);
            this.pbEscudoVisitante.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEscudoVisitante.TabIndex = 11;
            this.pbEscudoVisitante.TabStop = false;
            // 
            // pbEscudoLocal
            // 
            this.pbEscudoLocal.Enabled = false;
            this.pbEscudoLocal.Location = new System.Drawing.Point(113, 125);
            this.pbEscudoLocal.Name = "pbEscudoLocal";
            this.pbEscudoLocal.Size = new System.Drawing.Size(178, 178);
            this.pbEscudoLocal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEscudoLocal.TabIndex = 10;
            this.pbEscudoLocal.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Enabled = false;
            this.pictureBox5.Image = global::Practicar_Balonmano.Properties.Resources.boton_menos;
            this.pictureBox5.Location = new System.Drawing.Point(896, 460);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(63, 63);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 21;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Enabled = false;
            this.pictureBox6.Image = global::Practicar_Balonmano.Properties.Resources.mas;
            this.pictureBox6.Location = new System.Drawing.Point(896, 368);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(63, 63);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 20;
            this.pictureBox6.TabStop = false;
            // 
            // dsBD
            // 
            this.dsBD.DataSetName = "dsBD";
            this.dsBD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormPartidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(1025, 562);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.dgEquipoVisitante);
            this.Controls.Add(this.dgEquipoLocal);
            this.Controls.Add(this.lblGolesVisitante);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblNumGolesLocal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pbEscudoVisitante);
            this.Controls.Add(this.pbEscudoLocal);
            this.Controls.Add(this.lblNombrePabellón);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbEquipoVisitante);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbEquipoLocal);
            this.Controls.Add(this.cmbCategorías);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPartidos";
            this.Text = "FormPartidos";
            this.Load += new System.EventHandler(this.FormPartidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgEquipoLocal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgEquipoVisitante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEscudoVisitante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEscudoLocal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCategorías;
        private System.Windows.Forms.ComboBox cmbEquipoLocal;
        private System.Windows.Forms.ComboBox cmbEquipoVisitante;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblNombrePabellón;
        private System.Windows.Forms.PictureBox pbEscudoLocal;
        private System.Windows.Forms.PictureBox pbEscudoVisitante;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblNumGolesLocal;
        private System.Windows.Forms.Label lblGolesVisitante;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.DataGridView dgEquipoLocal;
        public System.Windows.Forms.DataGridView dgEquipoVisitante;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private dsBD dsBD;
    }
}