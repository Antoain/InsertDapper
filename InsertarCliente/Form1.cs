using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Acceso_a_Datos;

namespace InsertarCliente
{
    public partial class Form1 : Form
    {
        CategoriaRepositorio categR = new CategoriaRepositorio();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnObtenerTodos_Click(object sender, EventArgs e)
        {
            var cliente = categR .ObtenerTodo();
            dgvObtenerTodos.DataSource = cliente;

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            var nuevaCat = CrearCategoria();
            var insertado = categR.insertarCateg(nuevaCat);
            MessageBox.Show($"Se ha registrado la nueva categoria");
            


        }

        private Categorias CrearCategoria()
        {
            var nuevo = new Categorias
            {
                
                CategoryName = txtboxCatName.Text,
                Description = txtboxDescripccion.Text

            };
            return nuevo;

        }

       


        private void btnActualizar_Click(object sender, EventArgs e)
        {
            var updatedcategory = CrearCategoria();
            var actualizados = categR.UpdateCategory(updatedcategory);
            MessageBox.Show($"Se ha actualizado{actualizados} filas");
        }

        private void btnObtenerID_Click(object sender, EventArgs e)
        {

            int id;
            if (int.TryParse(txtBObtnerID.Text, out id))
            {
                var category = categR.ObtenerID(id);
                if (category != null)
                {
                    llenarCampos(category);  
                }
                else
                {
                    MessageBox.Show("No se encontró la categoría con ese ID.");
                }
            }
            else
            {
                MessageBox.Show("Escriba un número válido por favor.");
            }
        }

        private void llenarCampos(Categorias categorias)
        {
            txtboxCatID.Text = categorias.CategoryID.ToString();
            txtboxCatName.Text = categorias.CategoryName;
            txtboxDescripccion.Text = categorias.Description;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
