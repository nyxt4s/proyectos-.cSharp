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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este es un mensaje simple");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este es un mensaje simple con título", "Título del mensaje");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Botones a mostrar con messageBoxButtons", "Titulo", MessageBoxButtons.YesNoCancel);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //creamos y cargamos la variable Resultado que contendrá el valor del             
            //botón presionado por el usuario             
            DialogResult Resultado = MessageBox.Show("Desea salir del programa?", "Título del mensaje", MessageBoxButtons.OKCancel);

            //trabajamos con los posibles valores de la variable Resultado              
            if (Resultado == DialogResult.OK)
            {
                //si el usuario presionó "Aceptar" el programa se cierra                
                this.Close();
            }
            //si el usuario presiona "Cancelar" vuelve al formulario             
            //sin necesidad de más líneas de código 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult Resultado = MessageBox.Show("Desea salir del programa?", "Título del mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (Resultado == DialogResult.Yes)
            {

                this.Close();
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult Resultado = MessageBox.Show("Desea salir del programa?", "Título del mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            if (Resultado == DialogResult.Yes)
            {

                this.Close();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Cambia de posicion------------> MessageBoxOptions.RtlReading
            DialogResult Resultado = MessageBox.Show("Desea salir del programa?", "Título del mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
            if (Resultado == DialogResult.Yes)
            {

                this.Close();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desea salir del programa?", "Título del mensaje", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.RtlReading, true);

        }
         
        private void button9_Click(object sender, EventArgs e)
        {

                    // tenemos que seguir el orden de cada uno de los parametros por ejemplo MessageBoxDefaultButton.button1 --> button1 pertenece al boton que le
                    //haremos focus,  el 0 significa como ordenaremos los parametros del voton y por ultimo el helpfile.chm que parametros le daremos, en este caso
                    //hace abrir el manual
            DialogResult = MessageBox.Show("Desea salir del programa?", "Título del mensaje", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, 0, "helpfile.chm");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form2 FormMensaje = new Form2();

            //creamos una variable del tipo DialogResult que             
            //recibirá el resultado de lo seleccionado por el usuario             
            //en el formulario mensaje            
            DialogResult Result = FormMensaje.ShowDialog();

            //control de la variable             
            if (Result == DialogResult.OK)
            {
                FormMensaje.Text = "OK";
            }
            else
            {
                FormMensaje.Text = "Cancel";
            }
        }
    }
    }

