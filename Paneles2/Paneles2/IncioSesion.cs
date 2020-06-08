using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Paneles2
{
    public partial class FormInicioSesion : Form
    {
        public FormInicioSesion()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            FormInicio ObjFormInicio = new FormInicio(/*txtMensaje.Text*/);
            if (txtUsario.Text == "u" && txtContraseña.Text == "123")
            {
                ObjFormInicio.PropMensaje = txtMensaje.Text;

                DialogResult Confirmacion = ObjFormInicio.ShowDialog();

                if (Confirmacion == DialogResult.OK)
                {
                    lbErrorInicio.Text = ObjFormInicio.PropMensaje;
                    lbErrorInicio.Visible = true;

                }
            }
            else
            {
                lbErrorInicio.Text = "Usuario o caontraseña incorrectos";
                lbErrorInicio.Visible = true;
            }

            ObjFormInicio.Dispose();
        }
    }
}
