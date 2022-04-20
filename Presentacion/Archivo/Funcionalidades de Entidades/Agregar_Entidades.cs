using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Archivo.Funcionalidades_de_Entidades
{
    public partial class Agregar_Entidades : Form
    {
        public Agregar_Entidades()
        {
            InitializeComponent();
        }

        private void Agregar_Entidades_Load(object sender, EventArgs e)
        {

        }

        private void btnNuevaEntidad_Click(object sender, EventArgs e)
        {
            LimpiarTextBox();
        }

        public void LimpiarTextBox()
        {
            txtDescripcion.Clear();
            txtComentario.Clear();
            txtDireccion.Clear();
            txtEmail.Clear();
            txtLocalidad.Clear();
            txtPasswordEntidad.Clear();
            txtTelefono.Clear();
            txtUsernameEntidad.Clear();

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            //this.Close();
            //Menu_Principal.Intance.Show();

            Entidades entidades = new Entidades();
            this.Hide();
            entidades.Show();
        }
    }
}
