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
        string [] nombres = new string[tam];
        // Numero de telefono
        int[] numTlf = new int[tam]; 

        //Funciones
        void AddContacto(string[] nombres, int[] numeros)
        {
            string nombreTem;
            int numTlf;
            try
            {
                nombreTem = Interaction.InputBox("Introduce nombre de cantacto");
                numTlf = int.Parse(Interaction.InputBox("Introduce su numero de telefono"));
                
                for (int i = 0; i < nombres.Length; i++)
                {
                    if (nombreTem == nombres[i])
                    {
                        MessageBox.Show("Este nombre ya existe");
                    }
                    else if(numTlf == numeros[i]) 
                    {
                        MessageBox.Show("Este nombre ya existe");
                    }
                    else
                    {
                        numeros[i] = numTlf;
                        nombres[i] = nombreTem;
                        MessageBox.Show($"El contacto {nombres[i]} con telefono {numeros[i]} han sido introducidos correctamente");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Formato incorrecto");
            }
        }

        private void btnAddContac_Click(object sender, EventArgs e)
        {
            AddContacto(nombres, numTlf);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string nombreTem = Interaction.InputBox("Introduce el nombre que quieres borrar");
            for (int i = 0; i < nombres.Length; i++)
            {
                if (nombreTem == nombres[i])
                {
                    nombres[i] = null;
                    numTlf[i] = 0;
                }
                else
                {
                    MessageBox.Show("Nombre no encotrado");
                }
            }
        }
}
