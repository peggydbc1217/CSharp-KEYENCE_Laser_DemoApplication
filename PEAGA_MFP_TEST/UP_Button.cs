
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
    class UP_Button:Direction_Button
    {

        public UP_Button(int x, int y) : base(x, y)  //一定要base回傳回去
        {
            this.Image = Properties.Resources.up_trans;
                
        }


    }
}
