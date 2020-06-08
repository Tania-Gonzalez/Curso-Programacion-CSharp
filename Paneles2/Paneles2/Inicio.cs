using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paneles2
{
    public partial class FormInicio : Form
    {
        public FormInicio(/*string mensaje*/)
        {
            InitializeComponent();

           // lbMensaje.Text = mensaje;
        }

        private string mensaje;
        public string PropMensaje
        {
            get
            {
                return txtMensajeRetorno.Text;
            }
            set 
            {
                mensaje = value;
                lbMensaje.Text = mensaje;
            }
        }


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            //Application.Exit();
        }

        private void FormInicio_Load(object sender, EventArgs e)
        {

        }
    }
}
