using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DwLib.Data
{
    public class WindowDisplay
    {
        public WindowDisplay()
        {

        }

        public void OpenDisplay(System.Windows.Window w1, int wid = 0)
        {
            if (System.Windows.Forms.SystemInformation.MonitorCount > 1)
            {
                System.Drawing.Rectangle secondaryScreenRectangle = System.Windows.Forms.Screen.AllScreens[wid].WorkingArea;


                if (System.Windows.Forms.Screen.AllScreens[wid].Primary == true)
                {

                    w1.WindowStartupLocation = WindowStartupLocation.CenterOwner;
                    w1.Left = secondaryScreenRectangle.Width / 2 - w1.Width / 2;
                    w1.Top = secondaryScreenRectangle.Height / 2 - w1.Height / 2;
                }
                else
                {
                    wid++;
                    //secondaryScreenRectangle = null;
                    secondaryScreenRectangle = System.Windows.Forms.Screen.AllScreens[wid].WorkingArea;
                    w1.WindowStartupLocation = WindowStartupLocation.CenterOwner;
                    w1.Left = secondaryScreenRectangle.Width / 2 - w1.Width / 2;
                    w1.Top = secondaryScreenRectangle.Height / 2 - w1.Height / 2;
                }

                wid = 0;



            }

        }
    }
}
