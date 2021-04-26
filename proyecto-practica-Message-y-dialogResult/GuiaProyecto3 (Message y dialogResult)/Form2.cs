using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuiaProyecto3__Message_y_dialogResult_
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //si el usuario presiona este botón, la variable "Result"              
            //del formulario de orígen, recibirá como dato "DialogResult.OK"             
            this.DialogResult = DialogResult.OK; 
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //si el usuario presiona este botón, la variable "Result"              
            //del formulario de orígen, recibirá como dato "DialogResult.Cancel"             
            this.DialogResult = DialogResult.Cancel; 
        }
    }
}
