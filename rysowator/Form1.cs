using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rysowator
{
    public partial class Form1 : Form
    {
        //ZMIENNE POCZĄTKOWE
        Bitmap bitmap_workspace;
        bool print_on=false;
        SolidBrush color = new SolidBrush(Color.Black);
        Pen linia = new Pen(Color.Black);
        Point start_point = new Point(0,0);
        Point end_point = new Point (0,0);

        
        public Form1()
        {
            InitializeComponent();   
        }

        private void Form1_Load (object sender, EventArgs e)
        {
            bitmap_workspace = new Bitmap(print_panel.Width,print_panel.Height);
        }

        private void Print_Panel_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphicsObj = e.Graphics;
            graphicsObj.DrawImage(bitmap_workspace, 0, 0, bitmap_workspace.Width, bitmap_workspace.Height);
            graphicsObj.Dispose();
        }


        public delegate void Print_Now(object sender, MouseEventArgs e);
        Print_Now print_delegate_up;
        Print_Now print_delegate_down;
        Print_Now print_delegate_move;


        private void Print_Panel_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                print_delegate_down(sender, e);
               
            }
            catch (NullReferenceException) { }
        }

        private void Print_Panel_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                print_delegate_up(sender, e);
                print_panel.Invalidate();               //odświeżam panel tylko tutaj
            }
            catch (NullReferenceException)
            {
            }
        }

        private void Print_Panel_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                print_delegate_move(sender, e);
            }
            catch (NullReferenceException) { }
        }

        private void Line_Button_MouseDown(object sender, MouseEventArgs e)
        {
                using (Graphics g = Graphics.FromImage(bitmap_workspace))
                {
                    linia.Width = 3;
                    linia.Color = color.Color;
                    start_point.X = e.X;
                    start_point.Y = e.Y;
                }
        }

        private void Line_Button_MouseUp(object sender, MouseEventArgs e)
        {         
            using (Graphics g = Graphics.FromImage(bitmap_workspace))
            {
                end_point.X = e.X;
                end_point.Y = e.Y;
                g.DrawLine(linia, start_point, end_point);
                g.Dispose();
            }
            
        }

        private void Line_Button_MouseClick(object sender, MouseEventArgs e)
        {
            print_delegate_down = Line_Button_MouseDown;
            print_delegate_up = Line_Button_MouseUp;
            print_delegate_move = null;
        }

        private void Pencil_Button_MouseDown(object sender, MouseEventArgs e)
        {
            print_on = true;
        }

        private void Pencil_Button_MouseUp(object sender, MouseEventArgs e)
        {
            print_on = false;
        }

        private void Pencil_Button_MouseMove(object sender, MouseEventArgs e)
        {
            using (Graphics g = Graphics.FromImage(bitmap_workspace))
            {
                if(print_on)g.FillEllipse(color, e.X, e.Y, 5, 5);
                g.Dispose();
            }
            
        }

        private void Pencil_Button_MouseClick(object sender, MouseEventArgs e)
        {
            print_delegate_down = Pencil_Button_MouseDown;
            print_delegate_up = Pencil_Button_MouseUp;
            print_delegate_move = Pencil_Button_MouseMove;
        }

        private void Rect_Button_MouseDown(object sender, MouseEventArgs e)
        {
            using (Graphics g = Graphics.FromImage(bitmap_workspace))
            {
                linia.Color = color.Color;
                linia.Width = 3;
                start_point.X = e.X;
                start_point.Y = e.Y;
            }                          
        }

        private void Rect_Button_MouseUp(object sender, MouseEventArgs e)
        {
            using (Graphics g = Graphics.FromImage(bitmap_workspace))
            {
                end_point.X = e.X;
                end_point.Y = e.Y;
                if (end_point.X - start_point.X > 0 & end_point.Y - start_point.Y > 0)
                {
                    g.DrawRectangle(linia, start_point.X, start_point.Y, end_point.X - start_point.X, end_point.Y - start_point.Y);
                }
                else if (end_point.X - start_point.X > 0 & end_point.Y - start_point.Y < 0)
                {
                    g.DrawRectangle(linia, start_point.X, end_point.Y, end_point.X - start_point.X, start_point.Y - end_point.Y);
                }
                else if (end_point.X - start_point.X < 0 & end_point.Y - start_point.Y < 0)
                {
                    g.DrawRectangle(linia, end_point.X, end_point.Y, start_point.X - end_point.X, start_point.Y - end_point.Y);
                }
                else
                {
                    g.DrawRectangle(linia, end_point.X, start_point.Y, start_point.X - end_point.X, end_point.Y - start_point.Y);
                }
                g.Dispose();
            }                         
        }

        private void Rect_Button_MouseClick(object sender, MouseEventArgs e)
        {
            print_delegate_down = Rect_Button_MouseDown;
            print_delegate_up = Rect_Button_MouseUp;
            print_delegate_move = null;
        }

        private void Color_Name_Click(object sender, EventArgs e)
        {
            Pick_Color.ShowDialog();
            color.Color = Pick_Color.Color;
        }

        private void Save_Button_Click(object sender, EventArgs e)
        {
            bitmap_workspace.Save("..\\..\\..\\bohomazy.bmp");    
        }
    }
}
