using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryArroyoLisandro_Biblioteca
{
    public partial class frmBiblioteca : Form
    {
        public frmBiblioteca()
        {
            InitializeComponent();
        }
        
        //declaro variables globales
        public string[,] matLibros = new string[20,5];
        int Contador = 0;
        private void frmBiblioteca_Load(object sender, EventArgs e)
        {
            int i = 0;
            
            StreamReader srLibro = new StreamReader("./LIBRO.TXT");
            while (!srLibro.EndOfStream)
            {
                string line = srLibro.ReadLine(); //manejo el archivo a traves de una variable
                string[] vecDatosLibro = line.Split(','); //cargo en el vector lo que se encuentra en la variable, separandolo con un caracter

                if (i < 20 )
                {
                    matLibros[i, 0] = vecDatosLibro[0]; //cargo la matriz con los datos que se encuentra en dicha posicion del vector
                    matLibros[i, 1] = vecDatosLibro[1];
                    matLibros[i, 2] = vecDatosLibro[2];
                    matLibros[i, 3] = vecDatosLibro[3];
                    matLibros[i, 4] = vecDatosLibro[4];

                    NombreEditorial(i); //llamo a los procedimientos creados
                    NombreDistribuidora(i);//llamo a los procedimientos creados

                    i++;
                }
            }
            srLibro.Close();
            //muestro lo que se encuentra cargado en la matriz
            txtCodigo.Text = matLibros[0,0];
            txtNombreLibro.Text = matLibros[0,1];
            txtCodigoEditorial.Text = matLibros[0,2];
            txtCodigoAutor.Text = matLibros[0,3];
            txtCodigoDistribuidor.Text = matLibros[0,4];

            cmdRetroceder.Enabled = false;
        }

        private void cmdAvanzar_Click(object sender, EventArgs e)
        {


            txtCodigo.Text = matLibros[Contador, 0];
            txtNombreLibro.Text = matLibros[Contador, 1];
            txtCodigoEditorial.Text = matLibros[Contador, 2];
            txtCodigoAutor.Text = matLibros[Contador, 3];
            txtCodigoDistribuidor.Text = matLibros[Contador, 4];

            cmdRetroceder.Enabled = true;

            if (Contador == matLibros.GetLength(0) - 1)
            {
                cmdAvanzar.Enabled = false;
            }

            Contador++;







        }

        private void cmdRetroceder_Click(object sender, EventArgs e)
        {
            Contador--;

            if (Contador >= 0) 
            {
                txtCodigo.Text = matLibros[Contador, 0];
                txtNombreLibro.Text = matLibros[Contador, 1];
                txtCodigoEditorial.Text = matLibros[Contador, 2];
                txtCodigoAutor.Text = matLibros[Contador, 3];
                txtCodigoDistribuidor.Text = matLibros[Contador, 4];

                if (Contador == 0)
                {
                    cmdRetroceder.Enabled = false;
                    cmdAvanzar.Enabled = true;
                }
            }
            else
            {
                cmdRetroceder.Enabled = false;
            }

            if (Contador <= 19)
            {
                cmdAvanzar.Enabled = true;
            }


            
                  
        }
        private void NombreEditorial(int indiceM)
        {

            StreamReader srEditorial = new StreamReader("./EDITORIAL.txt"); //abro y leo el archivo

            while (!srEditorial.EndOfStream) //mientra sea diferente a fin de archivo
            {
                string[] vecEditorial = srEditorial.ReadLine().Split(','); //cargo el vector con lo que se encuentra dentro del archivo separandolo a traves de un caracter

                if (vecEditorial[0] == matLibros[indiceM, 2]) // comparo si lo que esta en la posicion 0 del vector es igual a lo que se encuentra 
                                                              //en la matriz
                {
                    matLibros[indiceM, 2] = vecEditorial[1]; //si entra cargamos la matriz con lo que se encuentra en el vector en la posicion 1
                }

            }

            srEditorial.Close();

        }

        private void NombreDistribuidora(int indiceM)
        {

            StreamReader srDistribuidora = new StreamReader("./DISTRIBUIDORA.txt"); //abro y leo el archivo

            while (!srDistribuidora.EndOfStream) //mientra sea diferente a fin de archivo
            {
                string[] vecDistribuidora = srDistribuidora.ReadLine().Split(',');

                if (vecDistribuidora[0] == matLibros[indiceM, 4])// comparo si lo que esta en la posicion 0 del vector es igual a lo que se encuentra 
                                                                 //en la matriz
                {
                    matLibros[indiceM, 4] = vecDistribuidora[1];//si entra cargamos la matriz con lo que se encuentra en el vector en la posicion 1
                }

            }

            srDistribuidora.Close();

        }




    }
}
