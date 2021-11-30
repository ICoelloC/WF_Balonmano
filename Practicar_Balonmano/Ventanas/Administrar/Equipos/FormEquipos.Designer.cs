namespace Practicar_Balonmano.Ventanas.Administrar.Equipos
{
    partial class FormEquipos
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
            this.dgEquipos = new System.Windows.Forms.DataGridView();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgEquipos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgEquipos
            // 
            this.dgEquipos.AllowUserToAddRows = false;
            this.dgEquipos.AllowUserToDeleteRows = false;
            this.dgEquipos.AllowUserToOrderColumns = true;
            this.dgEquipos.AllowUserToResizeColumns = false;
            this.dgEquipos.AllowUserToResizeRows = false;
            this.dgEquipos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgEquipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEquipos.Location = new System.Drawing.Point(12, 12);
            this.dgEquipos.MultiSelect = false;
            this.dgEquipos.Name = "dgEquipos";
            this.dgEquipos.ReadOnly = true;
            this.dgEquipos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgEquipos.Size = new System.Drawing.Size(985, 420);
            this.dgEquipos.TabIndex = 0;
            this.dgEquipos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dgEquipos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgEquipos_CellDoubleClick);
            // 
            // btnModificar
            // 
            this.btnModificar.Enabled = false;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(459, 458);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(116, 35);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(12, 458);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(116, 35);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "AÑADIR";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(881, 458);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(116, 35);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // FormEquipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(1009, 523);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.dgEquipos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEquipos";
            this.Text = "FormEquipos";
            this.Load += new System.EventHandler(this.FormEquipos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgEquipos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEliminar;
        public System.Windows.Forms.DataGridView dgEquipos;
    }
}