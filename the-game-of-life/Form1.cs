using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace the_game_of_life
{
    public partial class Form1 : Form
    {
        private int longitud = 40;
        private int longitudPixel = 10;
        int[,] celulas;
        public Form1()
        {
            InitializeComponent();

            celulas = new int[longitud, longitud];
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PintarMatriz()
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            for (int x = 0; x < longitud; x++)
            {
                for (int y = 0; y < longitud; y++)
                {
                    if (celulas[x,y] == 0)
                        PintarPixel(bmp, x, y, Color.White);
                    else
                        PintarPixel(bmp, x, y, Color.Black);
                }
            }
        }
        private void PintarPixel(Bitmap bmp, int x, int y, Color color)
        {
            for (int i=0; i<longitudPixel; i++)
            {
                for (int j = 0; j < longitudPixel; j++)
                bmp.SetPixel(i + (x*longitudPixel),j+(y*longitudPixel),color);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // reiniciar
            for (int i = 0; i < longitud; i++)
                for (int j = 0; j < longitud; j++)
                    celulas[i, j] = 0;

            Random r = new Random();
            // llenar random
            for (int i = 0; i < longitud; i++)
                for (int j = 0; j < longitud; j++)
                    celulas[i, j] = r.Next(0,2);
        }
    }
}
