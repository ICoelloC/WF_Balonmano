using Practicar_Balonmano.LINQ;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practicar_Balonmano.Ventanas.Partidos
{
    public partial class FormPartidos : Form
    {
        ArrayList idEquipos = new ArrayList();

        public byte[] MyData { get; private set; }

        public FormPartidos()
        {
            InitializeComponent();
        }

        private void FormPartidos_Load(object sender, EventArgs e)
        {
            CargarComboCategorias();
        }

        private void CargarComboCategorias()
        {
            using(balonmanoEntities objBD = new balonmanoEntities())
            {
                var categorias = (from e in objBD.EQUIPOS
                                  select e.Categoria).Distinct();
                foreach(var cat in categorias.ToList())
                {
                    cmbCategorías.Items.Add(cat);
                }
                cmbEquipoLocal.Enabled = true;
                
            }
        }

        private void cmbCategorías_SelectedIndexChanged(object sender, EventArgs e)
        {
            String categoria = cmbCategorías.SelectedItem.ToString();
            using (balonmanoEntities objBD = new balonmanoEntities())
            {
                var EquiposCategoria = from eq in objBD.EQUIPOS
                                               where eq.Categoria.Equals(categoria)
                                               select new
                                               {
                                                   Nombre = eq.Nombre,
                                                   IDEquipo = eq.Id_equipo
                                               };
                foreach (var equipo in EquiposCategoria.ToList())
                {
                    idEquipos.Add(equipo.IDEquipo);
                    cmbEquipoLocal.Items.Add(equipo.Nombre);
                }
            }
        }

        private void cmbEquipoLocal_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nombre = cmbEquipoLocal.SelectedItem.ToString();
            string categoria = cmbCategorías.SelectedItem.ToString();
            using (balonmanoEntities objBD = new balonmanoEntities())
            {
                var EquiposCategoria = from eq in objBD.EQUIPOS
                                       where eq.Nombre.Equals(nombre)
                                       select new
                                       {
                                           Nombre = eq.Nombre,
                                           IDEquipo = eq.Id_equipo,
                                           Escudo = eq.Escudo,
                                           Pabellon = eq.Pabellon
                                       };
                foreach (var equipo in EquiposCategoria.ToList())
                {
                    idEquipos.Add(equipo.IDEquipo);
                    cmbEquipoLocal.Items.Add(equipo.Nombre);
                    lblNombrePabellón.Text = equipo.Pabellon;
                    if (equipo.Escudo != null)
                    {
                        MyData = equipo.Escudo;
                        MemoryStream stream = new MemoryStream(MyData);
                        pbEscudoLocal.Image = Image.FromStream(stream);
                    }
                    CargarDataGridEquipo(nombre);
                }
            }
            cmbEquipoVisitante.Enabled = true;
            CargarComboEquipo(nombre, categoria);
        }

        private void CargarComboEquiposVisitantes(string nombre, string categoria)
        {
            using (balonmanoEntities objBD = new balonmanoEntities())
            {
                var equiposVisitantes = from eq in objBD.EQUIPOS
                                        where eq.Categoria.Equals(categoria) && !eq.Nombre.Equals(nombre)
                                        select new
                                        {
                                            Nombre = eq.Nombre,
                                            IDEquipo = eq.Id_equipo,
                                            Escudo = eq.Escudo,
                                            Pabellon = eq.Pabellon
                                        };
                foreach(var equipo in equiposVisitantes.ToList())
                {
                    cmbEquipoVisitante.Items.Add(equipo.Nombre);
                    if (equipo.Escudo != null)
                    {
                        MyData = equipo.Escudo;
                        MemoryStream stream = new MemoryStream(MyData);
                        pbEscudoVisitante.Image = Image.FromStream(stream);
                    }
                    CargarDataGridEquipoVisitante(nombre);
                }
            }
        }

        private void CargarDataGridEquipoVisitante(string nombre)
        {
            using (balonmanoEntities objBD = new balonmanoEntities())
            {
                var jugadoresEquipo = from eq in objBD.EQUIPOS
                                      from j in objBD.JUGADORES
                                      where eq.Nombre.Equals(nombre) && eq.Id_equipo == j.Equipo
                                      select new
                                      {
                                          j.Nombre,
                                          j.GOLES_PARTIDO
                                      };
                dgEquipoVisitante.DataSource = jugadoresEquipo.ToList();
            }
        }

        private void CargarDataGridEquipo(string nombre)
        {
            using (balonmanoEntities objBD = new balonmanoEntities())
            {
                var jugadoresEquipo = from eq in objBD.EQUIPOS
                                      from j in objBD.JUGADORES
                                      where eq.Nombre.Equals(nombre) && eq.Id_equipo == j.Equipo
                                      select new
                                      {
                                          j.Nombre,
                                          j.GOLES_PARTIDO
                                      };
                dgEquipoLocal.DataSource = jugadoresEquipo.ToList();
            }
        }

        private void cmbEquipoVisitante_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
