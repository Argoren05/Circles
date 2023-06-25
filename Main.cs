using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Security.Cryptography;
using System.IO;
using System.Reflection;

namespace Circles
{
    public partial class Main : Form
    {
        // ustalenie rozmiaru okna
        private const int FormWidth = 1380;
        private const int FormHeight = 960;

        // środek płutna
        private int centerX;
        private int centerY;

        // kąt oraz prędkości
        private double angleS2;
        private float V1S2;

        private double angleS3;
        private float V2S3;

        private double angleP3;
        private float V3P3;

        // promienie
        private float R1S1;
        private float R2S2;
        private float R3S3;

        // aktualne punkty
        private PointF currentPointS2;
        private PointF currentPointS3;
        private PointF currentPointP3;

        // ścieżki
        private GraphicsPath pathS2;
        private GraphicsPath pathS3;
        private GraphicsPath pathP3;

        private Timer timer;
        private bool isMoving;

        public Main()
        {
            InitializeComponent();
            InitializeParameters();
            InitializeTimer();
        }

        // incjazlizacja parametrów
        private void InitializeParameters()
        {
            centerX = FormWidth / 2;
            centerY = FormHeight / 2;

            R1S1 = 100;
            R2S2 = 50;
            R3S3 = 30;

            angleS2 = 0;
            angleS3 = 0;
            angleP3 = 0;

            V1S2 = 1;
            V2S3 = 1;
            V3P3 = 1;

            currentPointS2 = CaculateCurrentPointS2();
            currentPointS3 = CaculateCurrentPointS3();
            currentPointP3 = CaculateCurrentPointP3();

            isMoving = false;
            pathS2 = new GraphicsPath();
            pathS3 = new GraphicsPath();
            pathP3 = new GraphicsPath();
        }     

        //inicjalizacja timera
        private void InitializeTimer()
        {
            timer = new Timer();
            timer.Interval = 10;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if(isMoving)
            {
                //obliczanie kąta
                angleS2 += V1S2 * Math.PI / 180.0;
                angleS3 += V2S3 * Math.PI / 60.0;
                angleP3 += V3P3 * Math.PI / 30.0;

                //przypisanie współrzędnych
                currentPointS2 = CaculateCurrentPointS2();
                currentPointS3 = CaculateCurrentPointS3();
                currentPointP3 = CaculateCurrentPointP3();
                
                //dodanie do ścieżki
                pathS2.AddLine(currentPointS2, currentPointS2);
                pathS3.AddLine(currentPointS3, currentPointS3);
                pathP3.AddLine(currentPointP3, currentPointP3);

                pictureBox1.Invalidate();
            }
        }

        //obliczanie współrzędnych dla punktu S2
        private PointF CaculateCurrentPointS2()
        {
            int S2X = centerX + (int)(R1S1 * Math.Cos(angleS2));
            int S2Y = centerY + (int)(R1S1 * Math.Sin(angleS2));
            return new PointF(S2X, S2Y);
        }

        //obliczanie współrzędnych dla punktu S3
        private PointF CaculateCurrentPointS3()
        {
            int S3X = (int)CaculateCurrentPointS2().X + (int)(R2S2 * Math.Cos(angleS3));
            int S3Y = (int)CaculateCurrentPointS2().Y + (int)(R2S2 * Math.Sin(angleS3));
            return new PointF(S3X, S3Y);
        }

        //obliczanie współrzędnych dla punktu P3
        private PointF CaculateCurrentPointP3()
        {
            int P3X = (int)CaculateCurrentPointS3().X + (int)(R3S3 * Math.Cos(angleP3));
            int P3Y = (int)CaculateCurrentPointS3().Y + (int)(R3S3 * Math.Sin(angleP3));
            return new PointF(P3X, P3Y);
        }

        //rysowanie okręgów
        private void DrawCircels_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            StringFormat stringFormat = new StringFormat();
            g.SmoothingMode = SmoothingMode.AntiAlias;
            
            //rysowanie okręgów O1, O2, O3
            if (ShowCirclesO1CheckBox.Checked)
            {
                g.DrawEllipse(Pens.Orange, centerX - R1S1, centerY - R1S1, R1S1 * 2, R1S1 * 2);
            }
            if(ShowCirclesO2CheckBox.Checked)
            {
                g.DrawEllipse(Pens.Green, CaculateCurrentPointS2().X - R2S2, CaculateCurrentPointS2().Y - R2S2, R2S2 * 2, R2S2 * 2);
            }
            if(ShowCirclesO3CheckBox.Checked)
            {
                g.DrawEllipse(Pens.Blue, CaculateCurrentPointS3().X - R3S3, CaculateCurrentPointS3().Y - R3S3, R3S3 * 2, R3S3 * 2);
            }

            //środek okręgu O1
            if (ShowS1CheckBox.Checked)
            {
                g.FillEllipse(Brushes.DarkOrange, centerX - 5, centerY - 5, 10, 10);               
                g.DrawString("S1", Font, new SolidBrush(Color.DarkOrange), centerX + 5, centerY + 5, stringFormat);
            }
            
            //środek okręgu O2 i ścieżka
            if (ShowPathS2CheckBox.Checked)
            {
                g.FillEllipse(Brushes.DarkGreen, CaculateCurrentPointS2().X - 5, CaculateCurrentPointS2().Y - 5, 10, 10);
                g.DrawString("S2", Font, new SolidBrush(Color.DarkGreen), CaculateCurrentPointS2().X + 5, CaculateCurrentPointS2().Y + 5, stringFormat);
                g.DrawPath(Pens.DarkGreen, pathS2);
            }

            //środek okręgu O3 i ścieżka
            if (ShowPathS3CheckBox.Checked)
            {
                g.FillEllipse(Brushes.DarkBlue, CaculateCurrentPointS3().X - 5, CaculateCurrentPointS3().Y - 5, 10, 10);
                g.DrawString("S3", Font, new SolidBrush(Color.DarkBlue), CaculateCurrentPointS3().X + 5, CaculateCurrentPointS3().Y + 5, stringFormat);
                g.DrawPath(Pens.DarkBlue, pathS3);
            }

            //punkt P3 i rysowanie ścieżki
            g.FillEllipse(Brushes.Purple, CaculateCurrentPointP3().X - 5, CaculateCurrentPointP3().Y - 5, 10, 10);
            g.DrawString("P3", Font, new SolidBrush(Color.Purple), CaculateCurrentPointP3().X + 5, CaculateCurrentPointP3().Y + 5, stringFormat);
            g.DrawPath(Pens.Purple, pathP3);

            g.ResetTransform();
        }

        //Przyciski start, stop, reset
        private void StartButton_Click(object sender, EventArgs e)
        {
            isMoving = true;
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            isMoving = false;
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            pathS2.Reset();
            pathS3.Reset();
            pathP3.Reset();
            pictureBox1.Invalidate();
        }

       
        //Modyfikacja promienia okręgu O1
        private void RadiusO1PlusButton_Click_1(object sender, EventArgs e)
        {
            if (R1S1 < 300)
            {
                R1S1 += 10;
            }
            R1S1Label.Text = R1S1.ToString();
        }

        private void RadiusO1MinusButton_Click(object sender, EventArgs e)
        {
            if (R1S1 > 100)
            {
                R1S1 -= 10;
            }
            R1S1Label.Text = R1S1.ToString();
        }

        //Modyfikacja promienia okręgu O2
        private void RadiusO2PlusButton_Click(object sender, EventArgs e)
        {
            if (R2S2 < 200)
            {
                R2S2 += 10;
            }
            R2S2Label.Text = R2S2.ToString();
        }

        private void RadiusO2MinusButton_Click(object sender, EventArgs e)
        {
            if (R2S2 > 50)
            {
                R2S2 -= 10;
            }
            R2S2Label.Text = R2S2.ToString();
        }

        //Modyfikacja promienia okręgu O3
        private void RadiusO3PlusButton_Click(object sender, EventArgs e)
        {
            if (R3S3 < 150)
            {
                R3S3 += 10;
            }
            R3S3Label.Text = R3S3.ToString();
        }

        private void RadiusO3MinusButton_Click(object sender, EventArgs e)
        {
            if (R3S3 > 30)
            {
                R3S3 -= 10;
            }
            R3S3Label.Text = R3S3.ToString();
        }

        //Modyfikacja kierunku i prędkości S2
        private void V1PlusButton_Click(object sender, EventArgs e)
        {
            if (ChengeDirectionS2checkBox.Checked)
            {
                if (V1S2 < 0)
                {
                    V1S2 += 1;
                }
                V1S2ReverseLable.Text = V1S2.ToString();
            }
            else
            {
                if (V1S2 < 100)
                {
                    V1S2 += 1;
                }
                V1S2Label.Text = V1S2.ToString();
            }
        }

        private void V1MinusButton_Click(object sender, EventArgs e)
        {
            if (ChengeDirectionS2checkBox.Checked)
            {
                if (V1S2 > -100)
                {
                    V1S2 -= 1;
                }
                V1S2ReverseLable.Text = V1S2.ToString();
            }
            else
            {
                if (V1S2 > 0)
                {
                    V1S2 -= 1;
                }
                V1S2Label.Text = V1S2.ToString();
            }
        }

        private void ChengeDirectionS2checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ChengeDirectionS2checkBox.Checked)
            {
                V1S2 = -1;
                CDS2LeftLabel.Visible = true;
                CDS2RightLabel.Visible = false;

                V1S2Label.Visible = false;
                V1S2Label.Text = "1";
                V1S2ReverseLable.Visible = true;
            }
            else
            {
                V1S2 = 1;
                CDS2LeftLabel.Visible = false;
                CDS2RightLabel.Visible = true;

                V1S2Label.Visible = true;
                V1S2ReverseLable.Text = "-1";
                V1S2ReverseLable.Visible = false;
            }
        }

        //Modyfikacja kierunku i predkości S3
        private void V2PlusButton_Click(object sender, EventArgs e)
        {
            if (ChengeDirectionS3checkBox.Checked)
            {
                if (V2S3 < 0)
                {
                    V2S3 += 1;
                }
                V2S3ReverseLable.Text = V2S3.ToString();
            }
            else
            {
                if (V2S3 < 100)
                {
                    V2S3 += 1;
                }
                V2S3Label.Text = V2S3.ToString();
            }
        }

        private void V2MinusButton_Click(object sender, EventArgs e)
        {
            if (ChengeDirectionS3checkBox.Checked)
            {
                if (V2S3 > -100)
                {
                    V2S3 -= 1;
                }
                V2S3ReverseLable.Text = V2S3.ToString();
            }
            else
            {
                if (V2S3 > 0)
                {
                    V2S3 -= 1;
                }
                V2S3Label.Text = V2S3.ToString();
            }
        }

        private void ChengeDirectionS3checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ChengeDirectionS3checkBox.Checked)
            {
                V2S3 = -1;
                CDS3LeftLabel.Visible = true;
                CDS3RightLabel.Visible = false;

                V2S3Label.Visible = false;
                V2S3Label.Text = "1";
                V2S3ReverseLable.Visible = true;
            }
            else
            {
                V2S3 = 1;
                CDS3LeftLabel.Visible = false;
                CDS3RightLabel.Visible = true;

                V2S3Label.Visible = true;
                V2S3ReverseLable.Text = "-1";
                V2S3ReverseLable.Visible = false;
            }
        }

        //Modyfikacja kierunku i prędkości P3
        private void V3PlusButton_Click(object sender, EventArgs e)
        {
            if (ChengeDirectionP3checkBox.Checked)
            {
                if (V3P3 < 0)
                {
                    V3P3 += 1;
                }
                V3P3ReverseLable.Text = V3P3.ToString();
            }
            else
            {
                if (V3P3 < 100)
                {
                    V3P3 += 1;
                }
                V3P3Label.Text = V3P3.ToString();
            }
        }

        private void V3MinusButton_Click(object sender, EventArgs e)
        {
            if (ChengeDirectionP3checkBox.Checked)
            {
                if (V3P3 > -100)
                {
                    V3P3 -= 1;
                }
                V3P3ReverseLable.Text = V3P3.ToString();
            }
            else
            {
                if (V3P3 > 0)
                {
                    V3P3 -= 1;
                }
                V3P3Label.Text = V3P3.ToString();
            }
        }

        private void ChengeDirectionP3checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ChengeDirectionP3checkBox.Checked)
            {
                V3P3 = -1;
                CDP3LeftLabel.Visible = true;
                CDP3RightLabel.Visible = false;

                V3P3Label.Visible = false;
                V3P3Label.Text = "1";
                V3P3ReverseLable.Visible = true;
            }
            else
            {
                V3P3 = 1;
                CDP3LeftLabel.Visible = false;
                CDP3RightLabel.Visible = true;

                V3P3Label.Visible = true;
                V3P3ReverseLable.Text = "-1";
                V3P3ReverseLable.Visible = false;
            }
        }
    }
}
