using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEAGA_MFP_TEST
{
    class Left_Button:Direction_Button
    {
        public Left_Button(int x, int y) : base(x, y)  //一定要base回傳回去
        {
            this.Image = Properties.Resources.left_trans;

        }

    }
}
