namespace Practicar_Balonmano
{
    partial class FormPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aDMINISTRARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equiposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jugadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pARTIDOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iNFORMESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.búsquedaPartidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sALIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aDMINISTRARToolStripMenuItem,
            this.pARTIDOSToolStripMenuItem,
            this.iNFORMESToolStripMenuItem,
            this.sALIRToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1025, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aDMINISTRARToolStripMenuItem
            // 
            this.aDMINISTRARToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.equiposToolStripMenuItem,
            this.jugadoresToolStripMenuItem});
            this.aDMINISTRARToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 12.25F);
            this.aDMINISTRARToolStripMenuItem.Name = "aDMINISTRARToolStripMenuItem";
            this.aDMINISTRARToolStripMenuItem.Size = new System.Drawing.Size(142, 29);
            this.aDMINISTRARToolStripMenuItem.Text = "ADMINISTRAR";
            // 
            // equiposToolStripMenuItem
            // 
            this.equiposToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 12.25F);
            this.equiposToolStripMenuItem.Name = "equiposToolStripMenuItem";
            this.equiposToolStripMenuItem.Size = new System.Drawing.Size(163, 28);
            this.equiposToolStripMenuItem.Text = "Equipos";
            this.equiposToolStripMenuItem.Click += new System.EventHandler(this.equiposToolStripMenuItem_Click);
            // 
            // jugadoresToolStripMenuItem
            // 
            this.jugadoresToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 12.25F);
            this.jugadoresToolStripMenuItem.Name = "jugadoresToolStripMenuItem";
            this.jugadoresToolStripMenuItem.Size = new System.Drawing.Size(163, 28);
            this.jugadoresToolStripMenuItem.Text = "Jugadores";
            // 
            // pARTIDOSToolStripMenuItem
            // 
            this.pARTIDOSToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pARTIDOSToolStripMenuItem.Name = "pARTIDOSToolStripMenuItem";
            this.pARTIDOSToolStripMenuItem.Size = new System.Drawing.Size(118, 29);
            this.pARTIDOSToolStripMenuItem.Text = "PARTIDOS";
            this.pARTIDOSToolStripMenuItem.Click += new System.EventHandler(this.pARTIDOSToolStripMenuItem_Click);
            // 
            // iNFORMESToolStripMenuItem
            // 
            this.iNFORMESToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.búsquedaPartidosToolStripMenuItem,
            this.informesToolStripMenuItem1});
            this.iNFORMESToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iNFORMESToolStripMenuItem.Name = "iNFORMESToolStripMenuItem";
            this.iNFORMESToolStripMenuItem.Size = new System.Drawing.Size(122, 29);
            this.iNFORMESToolStripMenuItem.Text = "INFORMES";
            // 
            // búsquedaPartidosToolStripMenuItem
            // 
            this.búsquedaPartidosToolStripMenuItem.Name = "búsquedaPartidosToolStripMenuItem";
            this.búsquedaPartidosToolStripMenuItem.Size = new System.Drawing.Size(256, 30);
            this.búsquedaPartidosToolStripMenuItem.Text = "Búsqueda Partidos";
            // 
            // informesToolStripMenuItem1
            // 
            this.informesToolStripMenuItem1.Name = "informesToolStripMenuItem1";
            this.informesToolStripMenuItem1.Size = new System.Drawing.Size(256, 30);
            this.informesToolStripMenuItem1.Text = "Informes";
            // 
            // sALIRToolStripMenuItem
            // 
            this.sALIRToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sALIRToolStripMenuItem.Name = "sALIRToolStripMenuItem";
            this.sALIRToolStripMenuItem.Size = new System.Drawing.Size(76, 29);
            this.sALIRToolStripMenuItem.Text = "SALIR";
            this.sALIRToolStripMenuItem.Click += new System.EventHandler(this.sALIRToolStripMenuItem_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(1025, 602);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPrincipal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aDMINISTRARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pARTIDOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iNFORMESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sALIRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem equiposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jugadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem búsquedaPartidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informesToolStripMenuItem1;
    }
}