using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geometry
{

    public partial class GraphicObjects : Form
    {
        public Bitmap bmp;
        public Graphics graph;

        Sprite snowMan;
        Sprite demo;
        Circle circle;
        Box box;
        Line line;

        public GraphicObjects()
        {
            InitializeComponent();

            bmp = new Bitmap(picture.Width, picture.Height);
            graph = Graphics.FromImage(bmp);

            //Demo();
            InitSnowMan1();
            snowMan.Move(new Pixel(300,650));
            snowMan.Draw();

            picture.Image = bmp;
        }
        public void InitSnowMan1()
        {
            Pixel OB, OA, OC, D, E, J, F, K, L, M, N; 
            int RB, RA, RC;           
           
            snowMan = new Sprite();
            snowMan.SetGraphics(graph);


            OB = new Pixel(20,  - 520);
            RB = 80;
            OA = new Pixel( + 20,  - 340);
            RA = 100;
            OC = new Pixel( + 20,  - 120);
            RC = 120;
            D = new Pixel( - 160,  - 340);
            E = new Pixel( - 44,  - 417);
            J = new Pixel( + 180,  - 340);
            F = new Pixel( + 84,  - 417);
            K = new Pixel( - 60, 0);
            L = new Pixel( - 20,  - 40);
            M = new Pixel( + 60,  - 40);
            N = new Pixel( + 100, 0);

            snowMan.AddShape(new Circle(OB, RB));
            snowMan.AddShape(new Circle(OA, RA, Color.Red));
            snowMan.AddShape(new Circle(OC, RC));
            snowMan.AddShape(new Box(K, L));
            snowMan.AddShape(new Box(M, N,Color.Green));
            snowMan.AddShape(new Line(D, E));
            snowMan.AddShape(new Line(F, J,Color.Orange));
        }

        private void ButtonMoveMe_Click(object sender, EventArgs e)
        {
            Pixel p = new Pixel(350, 700);
            snowMan.Move(p);
            snowMan.Draw();

            picture.Image = bmp;
        }
    }
}