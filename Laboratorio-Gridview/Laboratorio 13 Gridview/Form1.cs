using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_13_Gridview
{
    public partial class Form1 : Form
    {
        int index;
      
        public Form1()
        {
            InitializeComponent();
        }

        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Agregamos un nuevo renglón 
            int n = dgvDatos.Rows.Add();
            int x = dgvDatos.Rows.Count;
            lblCelda.Text =  Convert.ToString(x);
           
                //Asignamos el valor del textBox a la celda que            
                //corresponda de esa fila          
                dgvDatos.Rows[n].Cells[0].Value = txtCodigo.Text;
                dgvDatos.Rows[n].Cells[1].Value = txtProducto.Text;
                dgvDatos.Rows[n].Cells[2].Value = txtPrecio.Text;
            
            //OTRA FORMA DE CREAR UNA NUEVA FILA 

            //creamos un objeto con la estructura de una fila  
            //object[] fila = { txtCodigo.Text, txtProducto.Text, txtPrecio.Text }; 

            //lo asignamos a la colección Rows de la grilla   
            //dgvProductos.Rows.Add(fila); 
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //obtenemos el índice (de tipo int) de la fila seleccionada          
            //mediante la información que brinda el evento en su argumento e          
            index = e.RowIndex;

            //controlamos que exista una fila seleccionada         
            if (index != -1)
            {
                txtCodigo.Text = dgvDatos.Rows[index].Cells[0].Value.ToString();
                txtProducto.Text = dgvDatos.Rows[index].Cells[1].Value.ToString();
                txtPrecio.Text = dgvDatos.Rows[index].Cells[2].Value.ToString();

                //asignamos al label el valor de la celda seleccionada   
                lblCelda.Text = dgvDatos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

                //otra forma de obtener el valor de la celda:  
                //lblCelda.Text = dgvProductos.CurrentCell.Value.ToString(); 
            }


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //al hacer click para seleccionar la fila a eliminar        
            //se asigna el indice de la misma a la veriable index 

            if (index != -1)
            {                 //eliminamos la fila seleccionada                
                dgvDatos.Rows.RemoveAt(index);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //obtenemos el índice (de tipo int) de la fila seleccionada          
            //mediante la información que brinda el evento en su argumento e          
            if (index != -1)
            {
                dgvDatos.Rows[index].Cells[0].Value = txtCodigo.Text;
                dgvDatos.Rows[index].Cells[1].Value = txtProducto.Text;
                dgvDatos.Rows[index].Cells[2].Value = txtPrecio.Text;
            }
        }
    }
    
}
      