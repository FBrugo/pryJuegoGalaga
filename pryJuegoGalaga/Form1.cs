namespace pryJuegoGalaga
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        clsNave objNaveJugador = new clsNave();
        clsNave objNaveEnemigo = new clsNave();
        private void Form1_Load(object sender, EventArgs e)
        {
            objNaveJugador.CrearJugador();
            objNaveJugador.imgNave.Size = new System.Drawing.Size(50,50);
            objNaveJugador.imgNave.Location = new Point(350, 400);
            Controls.Add(objNaveJugador.imgNave);

            //objNaveEnemigo.CrearEnemigo();
            //objNaveEnemigo.imgNave.Size = new System.Drawing.Size(50, 50);
            //objNaveEnemigo.imgNave.Location = new Point(100, 0);
            //Controls.Add(objNaveEnemigo.imgNave);


        }
        int  auxiliarX = 0;
        int contador = 0;
        private void timerEnemigo_Tick(object sender, EventArgs e)
        {
            if (contador < 10)
            {
                objNaveEnemigo.CrearEnemigo();
                //objNaveEnemigo.imgNave.Size = new System.Drawing.Size(50, 50);
                //objNaveEnemigo.imgNave.Location = new Point(50, 50);
                //objNaveEnemigo.imgNave.Location = new Point
                //    (auxiliarX += 50,
                //    objNaveEnemigo.imgNave.Location.Y);
                Controls.Add(objNaveEnemigo.imgNave);
                contador++;
            }
            else
            {
                timerEnemigo.Enabled = false;
            }
        }

        private void Disparo_Tick(object sender, EventArgs e)
        {
            

                if (pictureBoxDisparo.Location.Y > 0)
                {
                    if (pictureBoxDisparo.Bounds.IntersectsWith(pictureBox2.Bounds))
                    {
                        pictureBoxDisparo.Dispose();
                        pictureBox2.BackColor = Color.Blue;
                    }

                        foreach(Control imagen in this.Controls)
                        {
                            if (imagen.Tag == "Disparo")
                            {
                                imagen.Location =
                                new Point(
                                imagen.Location.X,
                                imagen.Location.Y - 10);
                            }

                        }
                }

            
        }
    }
}