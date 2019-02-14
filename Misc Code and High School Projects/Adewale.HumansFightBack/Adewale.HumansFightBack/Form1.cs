//#define Debug
using Adewale.HumansFightBack.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adewale.HumansFightBack
{
    public partial class frmHFB : Form
    { int GameFrame = 0;
        bool Shot = false;
        bool Greenshot = false;
        int ShotTime = 0;
         const int FrameNum = 15;
       const   int ShotNum = 3;
        int hits = 0;
        int misses = 0;
        int totalShots = 0;
        double AverageHits = 0;
        int [] Pool = new int[7]; 
#if Debug
        int CursX = 0;        
        int CursY =0 ;
#endif
        CAliens Alien;
        CAlien1 Alien1;                                                                    //HERE 
        CAlien2 Alien2;
        CAlien3 Alien3;
        CAlien4 Alien4;
        CBigBadAlien BigBadAlien;
        CScoreBoard ScoreBoard;
        Csign Sign;
        CBlood Blood;
        CGreenBlood GreenBlood;
        Random rnd = new Random();

       
        public frmHFB()
        {
            InitializeComponent();
            Bitmap b = new Bitmap(Resources.gun_sight);
            this.Cursor = Cursorx.CreateCursor(b, b.Height / 2, b.Width / 2);
            Alien = new CAliens() { Left = 10, Top = 350 };
            Alien1 = new CAlien1() { Left = 300, Top = 530 };
            Alien2 = new CAlien2() { Left = 150, Top = 480 };
            Alien3 = new CAlien3() { Left = 700, Top = 570 }; // HERE
           Alien4 = new CAlien4() { Left = 610, Top = 300 };
            BigBadAlien = new CBigBadAlien() { Left = 790, Top = 440 };
            ScoreBoard = new CScoreBoard() { Left = 10, Top = 10 };
            Sign = new Csign() { Left = 1075, Top = 120 };
            Blood = new CBlood();
            GreenBlood = new CGreenBlood();
        }

        private void tmrGame_Tick(object sender, EventArgs e)
        {  
            this.Refresh();
            if (GameFrame >= FrameNum)
            {
               // UpdateAlien();
                 UpdateAlien2();
            UpdateAlien3();
            UpdateBigBadAlien();
                
                GameFrame = 0;
            }
            else if (GameFrame == 8)                            //HERE
            { // specify how fast you want each to appear
                // assign points based on which alien is shot
                
               // UpdateAlien1();
                UpdateAlien4();
            }
            else if (GameFrame == 1)
            { // make each hop based on its own time frame 
                
            }
                if (Shot || Greenshot)
            {
                if (ShotTime >= ShotNum)
                {
                    Shot = false;
                    Greenshot = false;
                    ShotTime = 0;
                    UpdateAlien();              //HERE
                    UpdateAlien1();
                    UpdateAlien2();
                    UpdateAlien3();
                    UpdateAlien4();
                    UpdateBigBadAlien();

                }
                ShotTime++;
            }
            GameFrame++;
            
        }
        protected override void OnPaint(PaintEventArgs e)
        {            Graphics Draw = e.Graphics;

            if (Shot  == true)
            {
                Blood.DrawImage(Draw);
            }
            else if(Greenshot == true)
            {
                GreenBlood.DrawImage(Draw);

            }
            else
            {
            Alien.DrawImage(Draw);
             Alien1.DrawImage(Draw);
                Alien2.DrawImage(Draw);                         //HERE
                Alien3.DrawImage(Draw);
               Alien4.DrawImage(Draw);
                BigBadAlien.DrawImage(Draw);
            }

            ScoreBoard.DrawImage(Draw);
            Sign.DrawImage(Draw);
#if Debug
            TextFormatFlags flagd = TextFormatFlags.HorizontalCenter | TextFormatFlags.EndEllipsis;
            Font Fontd = new System.Drawing.Font("Stencil", 12, FontStyle.Regular);
            TextRenderer.DrawText(Draw, "X=" + CursX.ToString() + ":" + "Y=" + CursY.ToString(), Fontd,
                  new Rectangle(30, 28, 120, 20), SystemColors.ControlText, flagd);
#endif
            //Update Score
            TextFormatFlags flags = TextFormatFlags.Left;
            Font Fontz = new System.Drawing.Font("Stencil", 30, FontStyle.Regular);
            

            TextRenderer.DrawText(Draw, "Shots: " + totalShots.ToString(), Fontz, new Rectangle(35, 32, 300, 100), Color.Teal, flags);
            TextRenderer.DrawText(Draw, "Kills: " + hits.ToString(), Fontz, new Rectangle(35, 72, 300, 100), Color.Teal, flags);
            TextRenderer.DrawText(Draw, "Misses: " + misses.ToString(), Fontz, new Rectangle(35, 112, 300, 100), Color.Teal, flags);
            TextRenderer.DrawText(Draw, "Average: " + AverageHits.ToString(), Fontz, new Rectangle(35, 152, 300, 100), Color.Teal, flags);
            TextRenderer.DrawText(Draw, "%", Fontz, new Rectangle(320, 152, 40, 40), Color.Teal, flags);

            Font FontX = new System.Drawing.Font("Stencil", 28, FontStyle.Regular);


            TextRenderer.DrawText(Draw, "Shots: " + totalShots.ToString(), FontX, new Rectangle(37 + 1/2, 32, 300, 100), Color.White, flags);
            TextRenderer.DrawText(Draw, "Kills: " + hits.ToString(), FontX, new Rectangle(37 + 1 / 2, 72, 300, 100), Color.White, flags);
            TextRenderer.DrawText(Draw, "Misses: " + misses.ToString(), FontX, new Rectangle(37 + 1 / 2, 112, 300, 100), Color.White, flags);
            TextRenderer.DrawText(Draw, "Average: " + AverageHits.ToString(), FontX, new Rectangle(37 + 1 / 2, 152, 300, 100), Color.White, flags);
            TextRenderer.DrawText(Draw, "%", FontX, new Rectangle(322 + 1 / 2, 152, 40, 40), Color.White, flags);

            base.OnPaint(e);
           
           
        }

        private void frmHFB_MouseMove(object sender, MouseEventArgs e)
        {
#if Debug
            CursX = e.X;
            CursY = e.Y;
            this.Refresh();
#endif
            this.DoubleBuffered = true;
           
        }

        private void frmHFB_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.X > 1147 && e.X < 1261 && e.Y > 124 && e.Y < 165) //Game Start
            {
                tmrGame.Start();
            }
            else if (e.X > 1147 && e.X < 1261 && e.Y > 180 && e.Y < 223) //Game stop
            {
                tmrGame.Stop();
            }
            else if (e.X > 1147 && e.X < 1261 && e.Y > 231 && e.Y < 275) //reset
            {
                Shot = true; Blood.Left = Alien.Left - Resources._1040000567_1350309302971.Width / 3;
                Blood.Top = Alien.Top - Resources._1040000567_1350309302971.Height / 3;
            }
            else
            {
                if (Alien.Hit(e.X, e.Y) )
                {
                    Shot = true;
                    Blood.Left = Alien.Left - Resources._1040000567_1350309302971.Width / 3;
                    Blood.Top = Alien.Top - Resources._1040000567_1350309302971.Height / 3;
                    hits++;
                }
                else if ( Alien1.Hit(e.X, e.Y))
                {
                    Greenshot = true;
                    GreenBlood.Left = Alien1.Left - Resources.green_Blood.Width / 3;
                    GreenBlood.Top = Alien1.Top - Resources.green_Blood.Height / 3;
                    hits++;
                }
                else if (Alien3.Hit(e.X, e.Y))
                {
                    Greenshot = true;
                    GreenBlood.Left = Alien3.Left - Resources.green_Blood.Width / 3;
                    GreenBlood.Top = Alien3.Top - Resources.green_Blood.Height / 3;
                    hits++;
                }                                                                                       //HERE
                else if (Alien2.Hit(e.X, e.Y))
                {
                    Shot = true;
                    Blood.Left = Alien2.Left - Resources._1040000567_1350309302971.Width / 3;
                    Blood.Top = Alien2.Top - Resources._1040000567_1350309302971.Height / 3;
                    hits++;
                }
                else if (Alien4.Hit(e.X, e.Y))
                {
                    Shot = true;
                    Blood.Left = Alien4.Left - Resources._1040000567_1350309302971.Width / 3;
                    Blood.Top = Alien4.Top - Resources._1040000567_1350309302971.Height / 3;
                    hits++;
                }
                else if (BigBadAlien.Hit(e.X, e.Y))
                {
                    Shot = true;
                    Blood.Left = BigBadAlien.Left - Resources._1040000567_1350309302971.Width / 3;
                    Blood.Top = BigBadAlien.Top - Resources._1040000567_1350309302971.Height / 3;
                    hits++;
                }


                else
                {
                misses++;

                }
                totalShots = hits + misses;
                AverageHits = (double)hits / (double) totalShots *100.0;
            }
            Laser();
        }
        private void UpdateAlien()
        {
            Alien.Update(rnd.Next(Resources.bloob.Width, this.Width - Resources.bloob.Width), 
                rnd.Next(this.Height/2 , this.Height - Resources.bloob.Height*2)
                );
            
        }
        private void UpdateAlien1()
        {
           Alien1.Update1(rnd.Next(Resources.martian_manhunter.Width, this.Width - Resources.martian_manhunter.Width),
                rnd.Next(this.Height / 2, this.Height - Resources.martian_manhunter.Height * 2)
                );

        }
        private void UpdateAlien2()
        {
            Alien2.Update2(rnd.Next(Resources._2531580_tumblr_m7wqdhyyuq1r1203yo1_1280.Width, this.Width - Resources._2531580_tumblr_m7wqdhyyuq1r1203yo1_1280.Width),
                 rnd.Next(this.Height / 2, this.Height - Resources._2531580_tumblr_m7wqdhyyuq1r1203yo1_1280.Height * 2)
                 );                                                                                 //HERE

        }
        private void UpdateAlien3()
        {
            Alien3.Update3(rnd.Next(Resources.Alien2.Width, this.Width - Resources.Alien2.Width),
                 rnd.Next(this.Height / 2, this.Height - Resources.Alien2.Height * 2)
                 );

        }
        private void UpdateAlien4()
        {
            Alien4.Update4(rnd.Next(Resources.alien1.Width, this.Width - Resources.alien1.Width),
                 rnd.Next(this.Height / 2, this.Height - Resources.alien1.Height * 2)
                 ); // fix his shooting range detection

        }
        private void UpdateBigBadAlien()
        {
            BigBadAlien.Update5(rnd.Next(Resources.Alien21.Width, this.Width - Resources.Alien21.Width),
                rnd.Next(this.Height / 2, this.Height - Resources.Alien21.Height * 2)
                );
        }

        private void Laser()
        {
            SoundPlayer Sound = new SoundPlayer(Resources.Laser);
            Sound.Play();
        }
    }
}
