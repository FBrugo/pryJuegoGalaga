using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryJuegoGalaga
{
    internal class clsNave
    {
        //constructor
        public clsNave()
        {
            //Inicializar la variable
            vida = 0;
            nombre = "";
            damage = 0;
        }
        //propiedades de la clase variables globales

        public int vida;

        public string nombre;
        int damage; //daño
        public PictureBox imgNave;

        int posX, posY;


        //Metodos (acciones)
        public void CrearJugador()
        {
            vida = 100;
            nombre = "Jugador";
            damage = 1;

            imgNave = new PictureBox();
            imgNave.SizeMode = PictureBoxSizeMode.StretchImage;
            imgNave.Image = Properties.Resources.nave;
        }
        Random aleatorioEnemigo = new Random();
        Random aleatorioPosX = new Random();
        Random aleatorioPosY = new Random();
        int codigoEnemigo;

        public void CrearEnemigo()
        {
            codigoEnemigo = aleatorioEnemigo.Next(0, 2);

            imgNave = new PictureBox();
            imgNave.Size = new System.Drawing.Size(50, 50);
            imgNave.SizeMode = PictureBoxSizeMode.StretchImage;

            posX = aleatorioPosX.Next(0, 750);
            posY = aleatorioPosY.Next(0, 200);
            imgNave.Location = new Point(posX, posY);

            //posX = 50;
            //posY = 50;
            //imgNave.Location = new Point(posX, posY);

            switch (codigoEnemigo)
            {
                case 0:
                    vida = 200;
                    nombre = "enemigo1";
                    damage = 2;
                    imgNave.Image = Properties.Resources.enemigo1;
                    break;
                case 1:
                    vida = 200;
                    nombre = "enemigo2";
                    damage = 2;
                    imgNave.Image = Properties.Resources.enemigo2;
                    break;
            }
            //vida = 200;
            //nombre = "enemigo1";
            //damage = 2;

            //imgNave = new PictureBox();
            //imgNave.SizeMode = PictureBoxSizeMode.StretchImage;
            //imgNave.Image = Properties.Resources.enemigo1;

            //posX = 50;
            //posY = 50;
            //imgNave.Location = new Point(posX, posY);
        }
            
        

    }
}
