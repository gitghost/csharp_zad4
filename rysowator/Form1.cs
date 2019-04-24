using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rysowator
{
    public partial class Form1 : Form
    {
        //ZMIENNE POCZĄTKOWE
        bool print_on_panel=false;
        SolidBrush color = new SolidBrush(Color.Black);
        Pen linia = new Pen(Color.Black);
        Point start_point = new Point(0,0);
        Point end_point = new Point (0,0);

        public delegate void Print_Now(object sender, MouseEventArgs e);
        Print_Now print_delegate_up;
        Print_Now print_delegate_down;
        Print_Now print_delegate_move;

        public Form1()
        {
            InitializeComponent();
        }

        private void Print_Panel_MouseDown(object sender, MouseEventArgs e)
        {
            try{
                print_on_panel = true;
                print_delegate_down(sender, e);
            }
            catch(NullReferenceException){}
        }

        private void Print_Panel_MouseUp(object sender, MouseEventArgs e)
        {

            try
            {
                print_delegate_up(sender, e);
                print_on_panel = false;
            }
            catch (NullReferenceException){print_on_panel = false;
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
            if (print_on_panel)
            {
                linia.Width = 3;
                linia.Color = color.Color;
                start_point.X = e.X;
                start_point.Y = e.Y;
            }
        }

        private void Line_Button_MouseUp(object sender, MouseEventArgs e)
        {
            if (print_on_panel)
            {
                end_point.X = e.X;
                end_point.Y = e.Y;
                Graphics g = print_panel.CreateGraphics();
                g.DrawLine(linia, start_point, end_point);
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
        }

        private void Pencil_Button_MouseUp(object sender, MouseEventArgs e)
        {
        }

        private void Pencil_Button_MouseMove(object sender, MouseEventArgs e)
        {
            if (print_on_panel)
            {
                Graphics g = print_panel.CreateGraphics();
                g.FillEllipse(color, e.X, e.Y, 5, 5);
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
            if (print_on_panel)
            {
                linia.Color = color.Color;
                linia.Width = 3;
                start_point.X = e.X;
                start_point.Y = e.Y;
            }
        }

        private void Rect_Button_MouseUp(object sender, MouseEventArgs e)
        {
            if (print_on_panel)
            {
                end_point.X = e.X;
                end_point.Y = e.Y;
                Graphics g = print_panel.CreateGraphics();
                if (end_point.X - start_point.X > 0 & end_point.Y - start_point.Y > 0)
                {
                    g.DrawRectangle(linia, start_point.X, start_point.Y, end_point.X - start_point.X, end_point.Y - start_point.Y);
                }
                else if(end_point.X - start_point.X > 0 & end_point.Y - start_point.Y < 0)
                    {
                        g.DrawRectangle(linia, start_point.X, end_point.Y, end_point.X - start_point.X, start_point.Y - end_point.Y);
                    }
                    else if(end_point.X - start_point.X < 0 & end_point.Y - start_point.Y < 0)
                        {
                            g.DrawRectangle(linia, end_point.X, end_point.Y, start_point.X-end_point.X, start_point.Y - end_point.Y);
                        }
                        else
                        {
                            g.DrawRectangle(linia, end_point.X, start_point.Y, start_point.X-end_point.X, end_point.Y-start_point.Y);
                        }
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
    }
}
