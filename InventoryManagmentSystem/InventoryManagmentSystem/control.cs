using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace InventoryManagmentSystem
{
    static class control
    {
        static bool isMax = false, isfull = false;
        static Point old_loc, default_loc;
        static Size old_size, default_size;


        public static void SetIntial(Form form)
        {
            old_loc = form.Location;
            old_size = form.Size;
            default_loc = form.Location;
            default_size = form.Size;

        }
        public static void DoMaximize(Form form, Button Maxbtn)
        {
            if (isMax == false)  //application is not maximized so maximized it
            {
                old_loc = new Point(form.Location.X, form.Location.Y);
                old_size = new Size(form.Size.Width, form.Size.Height);
                Maximize(form);
                isMax = true;
                isfull = false;
                Maxbtn.Text = "2";
            }
            else //appliication is currently maximized; then mak it normal
            {
                form.Location = old_loc;
                form.Size = old_size;
                isMax = false;
                isfull = false;
            }

        }

        public static void DoFullscreen(Form form)
        {
            if (isfull == false) // app is not fullscreen then full screen it
            {
                old_loc = new Point(form.Location.X, form.Location.Y);
                old_size = new Size(form.Size.Width, form.Size.Height);
                Fullscreen(form);
                isMax = false;
                isfull = true;

            }
            else //app is fullScreen then make it normal it
            {
                form.Location = old_loc;
                form.Size = old_size;
                Fullscreen(form);
                isMax = false;
                isfull = false;
            }
        }



        static void Fullscreen(Form form)
        {
            if (form.WindowState == FormWindowState.Maximized)
                form.WindowState = FormWindowState.Normal;
            else if (form.WindowState == FormWindowState.Normal)
                form.WindowState = FormWindowState.Maximized;
        }

        static void Maximize(Form form)
        {
            int x = SystemInformation.WorkingArea.Width;
            int y = SystemInformation.WorkingArea.Height;
            form.WindowState = FormWindowState.Normal;
            form.Location = new Point(0, 0);
            form.Size = new Size(x, y);
        }

        public static void Minimize(Form form)
        {
            if (form.WindowState == FormWindowState.Minimized)
                form.WindowState = FormWindowState.Normal;
            else if (form.WindowState == FormWindowState.Normal)
                form.WindowState = FormWindowState.Minimized;
        }
        static void Exit()
        {
            Application.Exit();
        }

    }
}
