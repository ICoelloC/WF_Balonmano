using Practicar_Balonmano.LINQ;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practicar_Balonmano.Ventanas.Administrar.Equipos
{
    public partial class FormEquipos : Form
    {
        public FormEquipos()
        {
            InitializeComponent();
        }

        private void FormEquipos_Load(object sender, EventArgs e)
        {
            CargarEquipos();

        }

        public void CargarEquipos()
        {
            using(balonmanoEntities objBD = new balonmanoEntities())
            {
                var qEquipos = from e in objBD.EQUIPOS
                               orderby e.Nombre ascending
                               select new
                               {
                                   ID = e.Id_equipo,
                                   Nombre = e.Nombre,
                                   Categoria = e.Categoria,
                                   Pabellon = e.Pabellon
                               };

                dgEquipos.DataSource = qEquipos.ToList();
                dgEquipos.Columns[0].Visible = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmDatosEquipo frm = new FrmDatosEquipo(this);
            frm.ShowDialog();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            AbrirVentanaModoModificar();
        }

        private void dgEquipos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AbrirVentanaModoModificar();
        }

        private void AbrirVentanaModoModificar()
        {
            int id = int.Parse(dgEquipos.SelectedRows[0].Cells[0].Value.ToString());
            FrmDatosEquipo frm = new FrmDatosEquipo(this, id);
            frm.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgEquipos.SelectedRows[0].Cells[0].Value.ToString());
            using(balonmanoEntities objBD = new balonmanoEntities())
            {
                EQUIPOS objEq = objBD.EQUIPOS.Find(id);
                if (objEq != null)
                {
                    int numPartidos = (from p in objBD.PARTIDOS
                                       from eq in objBD.EQUIPOS
                                       where p.EQUIPOS1.Id_equipo == id || p.EQUIPOS2.Id_equipo == id && p.EQUIPOS.Id_equipo == eq.Id_equipo
                                       select p).Count();
                    if (numPartidos == 0)
                    {
                        int numJugadores = (from j in objBD.JUGADORES
                                            from eq in objBD.EQUIPOS
                                            where eq.Id_equipo == id && j.Equipo == eq.Id_equipo 
                                            select j).Count();
                        if (numJugadores == 0)
                        {
                            DialogResult resp = new DialogResult();
                            resp = MessageBox.Show("Estás seguro de querer eliminar este equipo", "BORRAR", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);

                            if (resp == DialogResult.Yes)
                            {
                                objBD.EQUIPOS.Remove(objEq);
                                objBD.SaveChanges();
                                MessageBox.Show("Equipo eliminado correctamente", "BORRAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                CargarEquipos();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Este equipo tiene jugadores en su plantilla, por lo tanto no se puede eliminar de la base de datos.", "ELIMINAR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Este equipo tiene un histórico de partidos, por lo tanto no se puede eliminar de la base de datos.", "ELIMINAR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
    }
}
