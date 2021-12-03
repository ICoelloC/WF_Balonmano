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
        dsBDTableAdapters.EQUIPOSTableAdapter equiposTA = new dsBDTableAdapters.EQUIPOSTableAdapter();
        dsBDTableAdapters.JUGADORESTableAdapter jugadoresTA = new dsBDTableAdapters.JUGADORESTableAdapter();
        dsBDTableAdapters.PARTIDOSTableAdapter partidosTA = new dsBDTableAdapters.PARTIDOSTableAdapter();
        dsBDTableAdapters.GOLES_PARTIDOTableAdapter golesPartidoTA = new dsBDTableAdapters.GOLES_PARTIDOTableAdapter();

        ArrayList idEquipos = new ArrayList();

        public byte[] MyData { get; private set; }

        public FormPartidos()
        {
            InitializeComponent();
        }

        private void FormPartidos_Load(object sender, EventArgs e)
        {
            CargarEquipos();
            CargarComboCategorias();
        }

        private void CargarEquipos()
        {
            this.equiposTA.Fill(dsBD.EQUIPOS);
            for (int i = 0; i < dsBD.EQUIPOS.Count; i++)
            {
                idEquipos.Add(dsBD.EQUIPOS[i].Id_equipo);
            }
        }

        private void CargarComboCategorias()
        {
            // Como puede haber equipos que no tengan categoría, vamos a cargar las categorías a mano
            cmbCategorías.Items.Add("Alevín");
            cmbCategorías.Items.Add("Cadete");
            cmbCategorías.Items.Add("Infantil");
            cmbCategorías.Items.Add("Juvenil");
            cmbEquipoLocal.Enabled = true;
        }

        private void cmbCategorías_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbEquipoLocal.Items.Clear();
            cmbEquipoLocal.Text = "";
            string categoria = cmbCategorías.SelectedItem.ToString();
            equiposTA.FillByCategoria(dsBD.EQUIPOS, categoria);
            foreach(var eq in dsBD.EQUIPOS)
            {
                cmbEquipoLocal.Items.Add(eq.Nombre);
            }
        }

        private void cmbEquipoLocal_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nombreEquipo = cmbEquipoLocal.SelectedItem.ToString();
            string categoria = cmbCategorías.SelectedItem.ToString();

            cmbEquipoVisitante.Enabled = true;

            cmbEquipoVisitante.Items.Clear();
            cmbEquipoVisitante.Text = "";

            CargarDatosEquipoLocal(nombreEquipo, categoria);
            CargarComboEquiposVisitantes(nombreEquipo, categoria);

        }

        private void CargarDatosEquipoLocal(string nombre, string categoria)
        {
            equiposTA.FillBy_NombreCategoria(dsBD.EQUIPOS, nombre, categoria);
            lblNombrePabellón.Text = dsBD.EQUIPOS[0].Pabellon;
        }

        private void CargarComboEquiposVisitantes(string nombre, string categoria)
        {
            equiposTA.FillBy_EquipoVisitante(dsBD.EQUIPOS, nombre, categoria);
            foreach (var eq in dsBD.EQUIPOS)
            {
                cmbEquipoVisitante.Items.Add(eq.Nombre);
            }
            
        }

        private void cmbEquipoVisitante_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nombreEquipo = cmbEquipoVisitante.SelectedItem.ToString();
            string categoria = cmbCategorías.SelectedItem.ToString();
            CargarDatosEquipoVisitante(nombreEquipo, categoria);
        }

        private void CargarDatosEquipoVisitante(string nombre, string categoria)
        {
            equiposTA.FillBy_NombreCategoria(dsBD.EQUIPOS, nombre, categoria);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
