using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NominaControl
{
    public partial class frmCambiarDiasTrabajados : Form
    {
        public frmCambiarDiasTrabajados()
        {
            InitializeComponent();
        }
        public Empleado Empleado { get; set; }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Empleado.DiasTrabajados = (float)nmrDias.Value;
        }
    }
}
