namespace Practicar_Balonmano.Ventanas.Administrar.Equipos
{
    partial class FrmDatosEquipo
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
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.pbEscudo = new System.Windows.Forms.PictureBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPabellon = new System.Windows.Forms.TextBox();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNuevaFoto = new System.Windows.Forms.Button();
            this.abrir = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pbEscudo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(301, 384);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(116, 35);
            this.btnVolver.TabIndex = 19;
            this.btnVolver.Text = "VOLVER";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(59, 384);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(116, 35);
            this.btnAceptar.TabIndex = 18;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // pbEscudo
            // 
            this.pbEscudo.Location = new System.Drawing.Point(170, 189);
            this.pbEscudo.Name = "pbEscudo";
            this.pbEscudo.Size = new System.Drawing.Size(247, 168);
            this.pbEscudo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEscudo.TabIndex = 17;
            this.pbEscudo.TabStop = false;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(170, 32);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(247, 24);
            this.txtNombre.TabIndex = 16;
            // 
            // txtPabellon
            // 
            this.txtPabellon.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPabellon.Location = new System.Drawing.Point(170, 79);
            this.txtPabellon.Name = "txtPabellon";
            this.txtPabellon.Size = new System.Drawing.Size(247, 24);
            this.txtPabellon.TabIndex = 15;
            // 
            // txtCategoria
            // 
            this.txtCategoria.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoria.Location = new System.Drawing.Point(170, 133);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(247, 24);
            this.txtCategoria.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "ESCUDO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "CATEGORÍA:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "PABELLÓN:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "NOMBRE:";
            // 
            // btnNuevaFoto
            // 
            this.btnNuevaFoto.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaFoto.Location = new System.Drawing.Point(8, 256);
            this.btnNuevaFoto.Name = "btnNuevaFoto";
            this.btnNuevaFoto.Size = new System.Drawing.Size(156, 47);
            this.btnNuevaFoto.TabIndex = 20;
            this.btnNuevaFoto.Text = "Nueva foto";
            this.btnNuevaFoto.UseVisualStyleBackColor = true;
            this.btnNuevaFoto.Click += new System.EventHandler(this.btnNuevaFoto_Click);
            // 
            // abrir
            // 
            this.abrir.FileName = "foto";
            this.abrir.Filter = "Imágenenes(*.jpg, *.png)|*.jpg";
            // 
            // FrmDatosEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(472, 450);
            this.Controls.Add(this.btnNuevaFoto);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.pbEscudo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtPabellon);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmDatosEquipo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDatosEquipo";
            this.Load += new System.EventHandler(this.FrmDatosEquipo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbEscudo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.PictureBox pbEscudo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPabellon;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNuevaFoto;
        private System.Windows.Forms.OpenFileDialog abrir;
    }
}