using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        enum Dir {Left,Rigth, up,down,None}
        int Speed = 20;
        int score = 0;
        Dir dir = Dir.None ;
        Random r = new Random();

        private void Timer_Tick(object sender, EventArgs e)
        {
            L1.Top += Speed;
            L2.Top += Speed;
            L3.Top += Speed;
            L4.Top += Speed;
            L5.Top += Speed;
            L6.Top += Speed;
            if (L1.Top > pnlGame.Height) L1.Top = -L1.Height;
            if (L2.Top > pnlGame.Height) L2.Top = -L2.Height;
            if (L3.Top > pnlGame.Height) L3.Top = -L3.Height;
            if (L4.Top > pnlGame.Height) L4.Top = -L4.Height;
            if (L5.Top > pnlGame.Height) L5.Top = -L5.Height;
            if (L6.Top > pnlGame.Height) L6.Top = -L6.Height;

            if (car.Visible)
            {
                car.Top += Speed;
            }
            if (car.Top>pnlGame.Height)
            { 
                car.Visible = false;
                car.Top = -car.Height;
                car.Left = r.Next((pnlGame.Width - car.Width) / 4);
                int c = r.Next(1, 6);
                if (c == 1) car.Image = Properties.Resources.car1;
               else if (c == 2) car.Image = Properties.Resources.car2;
                else if (c == 3) car.Image = Properties.Resources.car3;
                else if (c == 4) car.Image = Properties.Resources.car4;
                else  { car.Image = Properties.Resources.car5; }
                car.Visible = true;
            }
            if (car1.Visible)
            {
                car1.Top += Speed;
            }
            if (car1.Top > pnlGame.Height)
            {
                car1.Visible = false;
                car1.Top = -car1.Height;
                car1.Left = r.Next(pnlGame.Width*3/4 , pnlGame.Width-car1.Width  );
                int c = r.Next(1, 6);
                if (c == 1) car1.Image = Properties.Resources.car1;
                else if (c == 2) car1.Image = Properties.Resources.car2;
                else if (c == 3) car1.Image = Properties.Resources.car3;
                else if (c == 4) car1.Image = Properties.Resources.car4;
                else { car1.Image = Properties.Resources.car5; }
                car1.Visible = true;
            }
            if (car2.Visible)
            {
                car2.Top += Speed;
            }
            if (car2.Top > pnlGame.Height)
            {
                car2.Visible = false;
                car2.Top = -car1.Height;
                car2.Left = r.Next(pnlGame.Width / 4, (pnlGame.Width*3 /4)-car2.Width);
                int c = r.Next(1, 6);
                if (c == 1) car2.Image = Properties.Resources.car1;
                else if (c == 2) car2.Image = Properties.Resources.car2;
                else if (c == 3) car2.Image = Properties.Resources.car3;
                else if (c == 4) car2.Image = Properties.Resources.car4;
                else { car2.Image = Properties.Resources.car5; }
                car2.Visible = true;
            }
            if (player.Bounds.IntersectsWith(car1.Bounds)|| player.Bounds.IntersectsWith(car.Bounds) || player.Bounds.IntersectsWith(car2.Bounds))
                {
                    Timer.Enabled = false;
                GameOver.Visible = true;
                    }
            score++;
            Lblscore.Text = "score : " + score/2;
            
            for (int i = 0; i <100000 ; i+=100)
            {
                if (score/2 == i) { Speed += 2; }
             
            }

            if (dir==Dir.Left&&player.Left>0)
            {
                player.Left -= Speed;
            }
            if (dir == Dir.Rigth&&player.Left<pnlGame.Width-player.Width)
            {
                player.Left += Speed;
            }
            if (dir == Dir.up&&player.Top>0)
            {
                player.Top -= Speed;
            }
            if (dir == Dir.down&&player.Top<pnlGame.Height-player.Height)
            {
                player.Top += Speed;
            }
        }

        private void player_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left)
            {
                dir = Dir.Left;
            }
            else if(e.KeyData == Keys.Right)
            {
                dir = Dir.Rigth;
            }
            else if (e.KeyData == Keys.Up)
            {
                dir = Dir.up;
            }
            else if (e.KeyData == Keys.Down)
            {
                dir = Dir.down;
            }
            if (e.KeyData==Keys.Enter)
            {
                GameOver.Visible = false;
                player.Left = pnlGame.Width / 2;
                car.Left = 0;
                car1.Left = pnlGame.Width - car1.Width;
                car2.Left = pnlGame.Width / 4;
                 Speed = 20;
                 score = 0;
                Timer.Enabled = true; 
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            dir = Dir.None;
        }
    }
}
