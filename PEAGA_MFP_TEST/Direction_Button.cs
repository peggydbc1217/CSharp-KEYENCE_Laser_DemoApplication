using MB3Lib4;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace PEAGA_MFP_TEST
{
    class Direction_Button : PictureBox
    {
        public Direction_Button(int x, int y)
        {
            this.BackColor = Color.Transparent;
            this.Location = new Point(x, y);
            this.Size = new Size(50, 50);
            this.SizeMode = PictureBoxSizeMode.StretchImage;

        }




    }

}

