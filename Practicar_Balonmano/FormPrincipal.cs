using Practicar_Balonmano.Ventanas.Administrar.Equipos;
using Practicar_Balonmano.Ventanas.Partidos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practicar_Balonmano
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void equiposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                if (this.MdiChildren[0].Name != "FormEquipos")
                {
                    DialogResult rs = MessageBox.Show("¿Desea salir del formulario?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rs == DialogResult.Yes)
                    {
                        this.MdiChildren[0].Close();
                        FormEquipos f = new FormEquipos();
                        f.MdiParent = this;
                        f.Dock = DockStyle.Fill;
                        f.Show();
                    }
                }
            }
            else
            {
                FormEquipos f = new FormEquipos();
                f.MdiParent = this;
                f.Dock = DockStyle.Fill;
                f.Show();
            }
        }

        private void pARTIDOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                if (this.MdiChildren[0].Name != "FormPartidos")
                {
                    DialogResult rs = MessageBox.Show("¿Desea salir del formulario?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rs == DialogResult.Yes)
                    {
                        this.MdiChildren[0].Close();
                        FormPartidos f = new FormPartidos();
                        f.MdiParent = this;
                        f.Dock = DockStyle.Fill;
                        f.Show();
                    }
                }
            }
            else
            {
                FormPartidos f = new FormPartidos();
                f.MdiParent = this;
                f.Dock = DockStyle.Fill;
                f.Show();
            }
        }
    }
}
