using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Contactos
{
    public partial class Form1 : Form
    {
        // Lista para almacenar los contactos
        private List<string> contactos = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        // Método para buscar un contacto por nombre (primer botón: Buscar)
        private void button1_Click(object sender, EventArgs e)
        {
            string nombreBuscado = textBox1.Text.Trim();
            if (!string.IsNullOrEmpty(nombreBuscado))
            {
                var resultado = contactos.Find(c => c.Contains(nombreBuscado));
                if (resultado != null)
                {
                    MessageBox.Show($"Contacto encontrado: {resultado}");
                }
                else
                {
                    MessageBox.Show("No se encontró el contacto.");
                }
            }
            else
            {
                MessageBox.Show("Por favor ingrese un nombre para buscar.");
            }
        }

        // Método para agregar un nuevo contacto (segundo botón: Agregar)
        private void button2_Click(object sender, EventArgs e)
        {
            string nuevoContacto = textBox2.Text.Trim();
            if (!string.IsNullOrEmpty(nuevoContacto))
            {
                contactos.Add(nuevoContacto);
                ActualizarListaContactos();
                textBox2.Clear(); // Limpiar el TextBox
            }
            else
            {
                MessageBox.Show("Por favor ingrese un nombre para agregar un contacto.");
            }
        }

        // Método para actualizar un contacto (tercer botón: Actualizar)
        // Método para actualizar un contacto (tercer botón: Actualizar)
        // Método para borrar un contacto seleccionado de la ListBox (tercer botón: Borrar)
        // Método para actualizar un contacto seleccionado en la ListBox
        // Método para actualizar un contacto (tercer botón: Actualizar)
        private void button3_Click(object sender, EventArgs e)
        {
            string nombreViejo = textBox3.Text.Trim(); // Obtener el contacto actual desde textBox3
            string nombreNuevo = textBox4.Text.Trim(); // Obtener el nuevo contacto desde textBox4

            if (!string.IsNullOrEmpty(nombreViejo) && !string.IsNullOrEmpty(nombreNuevo))
            {
                // Buscar el índice del contacto actual en la lista
                int index = contactos.FindIndex(c => c.Equals(nombreViejo, StringComparison.OrdinalIgnoreCase));
                if (index != -1)
                {
                    // Actualizar el contacto en la lista
                    contactos[index] = nombreNuevo;
                    ActualizarListaContactos();
                    textBox3.Clear(); // Limpiar el campo de contacto actual
                    textBox4.Clear(); // Limpiar el campo de nuevo contacto
                    MessageBox.Show("Contacto actualizado correctamente.");
                }
                else
                {
                    MessageBox.Show("El contacto a actualizar no existe.");
                }
            }
            else
            {
                MessageBox.Show("Por favor ingrese ambos campos: el contacto actual y el nuevo.");
            }
        }




        // Método para borrar un contacto (cuarto botón: Borrar)
        private void button4_Click(object sender, EventArgs e)
        {
            string nombreABorrar = listBox1.Text.Trim();
            if (!string.IsNullOrEmpty(nombreABorrar))
            {
                var contactoABorrar = contactos.Find(c => c.Equals(nombreABorrar, StringComparison.OrdinalIgnoreCase));
                if (contactoABorrar != null)
                {
                    contactos.Remove(contactoABorrar);
                    ActualizarListaContactos();
                    textBox1.Clear();
                    MessageBox.Show("Contacto eliminado correctamente.");
                }
                else
                {
                    MessageBox.Show("No se encontró el contacto para eliminar.");
                }
            }
            else
            {
                MessageBox.Show("Por favor ingrese un nombre para eliminar.");
            }
        }

        // Método para actualizar el ListBox con la lista de contactos
        private void ActualizarListaContactos()
        {
            listBox1.Items.Clear();
            foreach (var contacto in contactos)
            {
                listBox1.Items.Add(contacto);
            }
        }

        // Método para salir del programa (quinto botón: Salir)
        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Evento para buscar un contacto mientras se escribe (opcional)
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string nombreBuscado = textBox1.Text.Trim();
            // Lógica para buscar el contacto mientras se escribe
            if (!string.IsNullOrEmpty(nombreBuscado))
            {
                var resultado = contactos.Find(c => c.Contains(nombreBuscado));
                if (resultado != null)
                {
                    MessageBox.Show($"Contacto encontrado: {resultado}");
                }
                else
                {
                    MessageBox.Show("No se encontró el contacto.");
                }
            }
        }

        // Evento para manejar cambios en textBox2 (puedes agregar lógica si lo necesitas)
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Lógica que se ejecutará cuando el texto cambie en textBox2
            // Por ejemplo, podrías validar el texto o hacer algo dinámico
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
