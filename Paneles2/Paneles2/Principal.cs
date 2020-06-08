using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Paneles2
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void AbrirForms<F>() where F: Form, new() //Metodo generico
        {
            Form Formulario = pnlFormContenedor.Controls.OfType<F>().FirstOrDefault();

            if (Formulario == null)
            {
                Formulario = new F();
                Formulario.TopLevel = false;
                Formulario.Dock = DockStyle.Fill; // se acopla a todo el panel

                pnlFormContenedor.Controls.Add(Formulario); //Agrega el formulario al panel
                pnlFormContenedor.Tag = Formulario;
                Formulario.Show();
                Formulario.BringToFront();
            }
            else
            {
                Formulario.TopLevel = false;
                Formulario.Dock = DockStyle.Fill;
                Formulario.Show();
                Formulario.BringToFront();

            }
        }

        private void CerrarForm<F2>() where F2: Form, new()
        {
            Form Formulario = pnlFormContenedor.Controls.OfType<F2>().FirstOrDefault();

            if (Formulario != null)
            {
                Formulario.Close();

            }
        }

        private void bntInicio_Click(object sender, EventArgs e)
        {
            CerrarForm<FormInicioSesion>();
            AbrirForms<FormInicio>();

        }

        private void btnInicioSesion_Click(object sender, EventArgs e)
        {
            CerrarForm<FormInicio>();
            AbrirForms<FormInicioSesion>();

        }
    }
}
