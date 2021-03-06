using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace karti
{
    public partial class Form1 : Form
    {
        const byte hkart = 90;
        const byte wkart = 60;
        const byte probel = 5;
        bool nowisvopr;
        bool[,] colodabool = new bool[4, 13];
        string[] colodastring = new string[13] {  "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        byte[,] polcol32 = new byte[2, 36];
        byte otstup = probel + hkart;
        Random R = new Random();
        int botonx;
        int botony;
        byte[] karta=new byte[2];
        int scoreeee=0;

        public Form1()
        {
            InitializeComponent();
        }        
        protected override void OnPaint(PaintEventArgs e)
        {
            //if 32kart            
            //проверочная карта
            e.Graphics.FillRectangle(
                        brush: Brushes.LightGray,
                            rect: new Rectangle(
                            x: 5,
                            y: 5,
                        width: wkart,
                        height: hkart));
            //их номера
            if (nowisvopr)
            {
                e.Graphics.DrawString(
                s: colodastring[karta[1]],
                font: kart36.Font,
            brush: karta[0] == 0 ? Brushes.DarkRed : karta[0] == 1 ? Brushes.Red : karta[0] == 2 ? Brushes.Blue : Brushes.Cyan,
                x: 5,
                y: 5);
            }
            // РИСОВАНИЕ ввсех остальних карт
            for (int y = 0; y < 3; y++) 
            {
                for (int x=0;x<12;x++) 
                {
                    e.Graphics.FillRectangle(
                        brush: botonx != x || botony - 1 != y ? Brushes.LightGray :polcol32[1, 12 * y + x] ==karta[0] && polcol32[0, 12 * y + x] == karta[1] ? Brushes.Green : Brushes.DarkOrange ,
                            x: probel + (wkart+ probel) *x, 
                            y: otstup+probel + (hkart + probel) * y, 
                        width: wkart,
                        height: hkart) ;
                    //их номера
                    if (!nowisvopr)
                    {
                        e.Graphics.DrawString(
                            s: colodastring[polcol32[0, 12 * y + x]],
                            font: kart36.Font,
                        brush: polcol32[1, 12 * y + x] == 0 ? Brushes.DarkRed : polcol32[1, 12 * y + x] == 1 ? Brushes.Red : polcol32[1, 12 * y + x] == 2 ? Brushes.Blue : Brushes.Cyan,
                            x: probel + (wkart + probel) * x,
                            y: otstup + probel + (hkart + probel) * y);
                    }
                }
                    
            }
            //чистим масив
            Array.Clear(colodabool, 0, colodabool.Length);
        }
        public void RandomCart()
        {
            for (int i = 0; i < 36; i++)
            {
                byte t1 = (byte)R.Next(0, 4), t0 = (byte)R.Next(4, 13);
                while (colodabool[t1, t0])
                {
                    t1 = (byte)R.Next(0, 4);
                    t0 = (byte)R.Next(4, 13);
                }
                polcol32[0, i] = t0;
                polcol32[1, i] = t1;
                colodabool[t1, t0] = true;
            }
        }       
        //при нажатии на кнопку карт36
        private void kart36_Click(object sender, EventArgs e)
        {
            ActiveForm.Height = 425;
            ActiveForm.Width = 800;
            panel1.Visible = false;
            RandomCart();
            Invalidate();

        }
        //при нажатии на кнопку карт54
        private void kart52_Click(object sender, EventArgs e)
        {
            ActiveForm.Height = 665;
            ActiveForm.Width = 590;
            panel1.Visible = false;
            RandomCart();
            Invalidate();
        }
        //когда нажата кнопка миши
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            botonx = e.X / (wkart + probel);
            botony = e.Y / (hkart + probel);
            if (polcol32[1, 12 * (botony-1)+botonx] == karta[0] && polcol32[0, 12 * (botony-1) + botonx] == karta[1])
            {
                if (nowisvopr)
                {
                    scoreeee++;                    
                }
                else
                {
                    karta[0] = (byte)R.Next(0, 4);
                    karta[1] = (byte)R.Next(4, 13);
                }
                nowisvopr = !nowisvopr;
                score.Text = "Score " + scoreeee;
            }
            Invalidate();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {           
            if (!nowisvopr)
            {
                karta[0] = (byte)R.Next(0, 4);
                karta[1] = (byte)R.Next(4, 13);
            }            
            nowisvopr=!nowisvopr;
            Invalidate();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            RandomCart();
            Invalidate();
        }
    }
}
