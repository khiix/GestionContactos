using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionContactos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static int tam = 10;
        // Nombre Contacto
        string[] nombres = new string[tam];
        // Numero de telefono
        int[] numTlf = new int[tam];

        //Funciones
        void AddContacto(string[] nombres, int[] numeros)
        {
            string nombre = "";
            int numTlf, i = 0;
            bool ayadir = false;
            try
            {

                DialogResult more;
                do
                {
                    nombre = Interaction.InputBox("Introduce nombre de cantacto");
                    numTlf = int.Parse(Interaction.InputBox("Introduce su numero de telefono"));
                    // Verificar si ya existe el contacto
                    for (i = 0; i < nombres.Length; i++)
                    {
                        if (nombres[i] == nombre || numeros[i] == numTlf)
                        {
                            MessageBox.Show("Nombre de contacto o número ya introducidos");
                            ayadir = true;
                            break;
                        }
                    }

                    // Si no existe, añadir el nuevo contacto
                    if (ayadir == false)
                    {
                        for (i = 0; i < nombres.Length; i++)
                        {
                            if (nombres[i] == null)
                            {
                                nombres[i] = nombre;
                                numeros[i] = numTlf;
                                break;
                            }
                        }
                    }

                    more = MessageBox.Show("¿Quieres introducir mas contactos?", "Nuevo contacto", MessageBoxButtons.OKCancel);
                }

                while (more == DialogResult.OK);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Formato incorrecto");
            }
        }

        void ModificarContacto(string[] nombres)
        {
            string nombreEditar = Interaction.InputBox("Introduce el nombre a editar");
            bool encontrado = false;

            for (int i = 0; i < nombres.Length; i++)
            {
                if (nombreEditar == nombres[i])
                {
                    nombres[i] = Interaction.InputBox("Introduce el nuevo nombre");
                    MessageBox.Show("Nombre de contacto editado");
                    encontrado = true;
                    break;
                }
            }
            if (!encontrado)
            {
                MessageBox.Show("El nombre que deseas editar no existe");
            }
        }

        void MostrarContactos(string[] nombreContacto, int[] numTelefono)
        {
            int contador = 0;
            string texto = "";

            while (nombreContacto.Length > contador && numTelefono.Length > contador)
            {
                texto += $"Contacto: {nombreContacto[contador]} Telefono: {numTelefono[contador]} \n ";
                contador++;

            }
            MessageBox.Show(texto);
        }
        void ModificarTlf(int[] num)
        {
            try
            {
                int numEditar = int.Parse(Interaction.InputBox("Introduce el número a editar"));
                bool encontrado = false;

                for (int i = 0; i < num.Length; i++)
                {
                    if (numEditar == num[i])
                    {
                        num[i] = int.Parse(Interaction.InputBox("Introduce el número nuevo"));
                        MessageBox.Show("Número de teléfono editado");
                        encontrado = true;
                        break;
                    }
                }
                if (!encontrado)
                {
                    MessageBox.Show("El número que deseas editar no se ha encontrado");
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Error de formato: " + ex.Message);
            }
        }


        void BorrarContacto(string[] nombres, int[] numeros)
        {
            string nombreTem = Interaction.InputBox("Introduce el nombre que quieres borrar");
            bool encontrado = false;

            for (int i = 0; i < nombres.Length; i++)
            {
                if (nombreTem == nombres[i])
                {
                    nombres[i] = null;
                    numeros[i] = 0;
                    MessageBox.Show("Contacto borrado");
                    encontrado = true;
                    break;
                }
            }
            if (!encontrado)
            {
                MessageBox.Show("Nombre no encontrado");
            }
        }

        //botones
        private void btnAddContac_Click(object sender, EventArgs e)
        {
            AddContacto(nombres, numTlf);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            BorrarContacto(nombres, numTlf);
        }

        private void btnEditContac_Click(object sender, EventArgs e)
        {
            ModificarContacto(nombres);
            ModificarTlf(numTlf);
        }

        private void btnShowContac_Click(object sender, EventArgs e)
        {
            MostrarContactos(nombres, numTlf);
        }
    }
}
