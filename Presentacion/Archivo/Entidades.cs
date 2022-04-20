using Presentacion.Archivo.Funcionalidades_de_Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Entidades : Form
    {
        public Entidades()
        {
            InitializeComponent();
        }

        public static string Id { get; internal set; }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Agregar_RedesSociales agregar_RedesSociales = new Agregar_RedesSociales();
            this.Hide();
            agregar_RedesSociales.Show();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }
    }
}
