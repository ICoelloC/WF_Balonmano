using Practicar_Balonmano.LINQ;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practicar_Balonmano.Ventanas.Administrar.Equipos
{
    public partial class FrmDatosEquipo : Form
    {

        private int idEquipoSeleccionado;
        private FormEquipos frm;

        public byte[] MyData { get; private set; }

        public FrmDatosEquipo(FormEquipos formEquipos)
        {

            InitializeComponent();
            this.frm = formEquipos;
            this.idEquipoSeleccionado = 0;
        }

        public FrmDatosEquipo(FormEquipos formEquipos, int id)
        {
            InitializeComponent();
            this.frm = formEquipos;
            this.idEquipoSeleccionado=id;
        }

        private void CargarDatosEquipo(int idEquipoSeleccionado)
        {
            using (balonmanoEntities objBD = new balonmanoEntities())
            {
                var equipo = (from e in objBD.EQUIPOS
                              where e.Id_equipo == idEquipoSeleccionado
                              select e).First();

                txtNombre.Text = equipo.Nombre;
                txtPabellon.Text = equipo.Pabellon;
                txtCategoria.Text = equipo.Categoria;
                if (equipo.Escudo != null)
                {
                    MyData = equipo.Escudo;
                    MemoryStream stream = new MemoryStream(MyData);
                    pbEscudo.Image = Image.FromStream(stream);
                }
                
            }
        }

        public byte[] ImageToByteArray(System.Drawing.Image imagen)
        {
            MemoryStream ms = new MemoryStream();
            imagen.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }

        public Image byteArrayToImage(byte[] bytesArr)
        {
            MemoryStream ms = new MemoryStream(bytesArr);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        private void FrmDatosEquipo_Load(object sender, EventArgs e)
        {
            if (this.idEquipoSeleccionado != 0)
            {
                CargarDatosEquipo(idEquipoSeleccionado);
            }
        }

        private void btnNuevaFoto_Click(object sender, EventArgs e)
        {
            if (abrir.ShowDialog() == DialogResult.OK)
            {
                pbEscudo.Image = Image.FromFile(abrir.FileName);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (idEquipoSeleccionado == 0)
            {
                InsertarEquipo();
            }
            else
            {
                ModificarEquipo();
            }
        }

        private void ModificarEquipo()
        {
            using(balonmanoEntities objBD = new balonmanoEntities())
            {
                EQUIPOS objEq =  objBD.EQUIPOS.Find(idEquipoSeleccionado);
                if (objEq != null)
                {
                    if (txtNombre.Text != "")
                    {
                        objEq.Nombre = txtNombre.Text;
                    }
                    if(txtCategoria.Text != "")
                    {
                        objEq.Categoria = txtCategoria.Text;
                    }
                    if(txtPabellon.Text != "")
                    {
                        objEq.Pabellon = txtPabellon.Text;
                    }
                    if (pbEscudo.Image != null)
                    {
                        objEq.Escudo = ImageToByteArray(pbEscudo.Image);
                    }
                    objBD.SaveChanges();
                    MessageBox.Show("Datos del equipo modificados correctamente", "MODIFICAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.frm.CargarEquipos();
                    this.Close();
                }
            }
        }

        private void InsertarEquipo()
        {
            using (balonmanoEntities objBD = new balonmanoEntities())
            {
                bool valido = true;
                EQUIPOS objEq = new EQUIPOS();

                if (txtNombre.Text != "")
                {
                    objEq.Nombre = txtNombre.Text;

                }
                else
                {
                    valido = false;
                }
                if (txtCategoria.Text != "")
                {
                    objEq.Categoria = txtCategoria.Text;
                }
                else
                {
                    valido = false;
                }
                if (txtPabellon.Text != "")
                {
                    objEq.Pabellon = txtPabellon.Text;
                }
                else
                {
                    valido = false;
                }
                if (pbEscudo.Image != null)
                {
                    objEq.Escudo = ImageToByteArray(pbEscudo.Image);
                }

                if (valido)
                {
                    var equipos = (from e in objBD.EQUIPOS
                                  where e.Nombre.Equals(txtNombre.Text) && e.Pabellon.Equals(txtPabellon.Text) && e.Categoria.Equals(txtCategoria.Text) 
                                   select e).Count();
                    if (equipos == 0)
                    {
                        objBD.EQUIPOS.Add(objEq);
                        objBD.SaveChanges();
                        MessageBox.Show("Equipo insertado correctamente", "INSERTAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.frm.CargarEquipos();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("El equipo a registrar ya existe", "INSERTAR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Todos los campos menos el escudo son obligatorios", "INSERTAR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                


            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.frm.CargarEquipos();
            this.Close();
        }
    }
}
