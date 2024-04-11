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
            if (contador < 20)
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
    }
}