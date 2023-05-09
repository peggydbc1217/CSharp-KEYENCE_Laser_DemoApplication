using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEAGA_MFP_TEST
{
    class Right_Button: Direction_Button
    {
        public Right_Button(int x, int y) : base(x, y)  //一定要base回傳回去
        {
            this.Image = Properties.Resources.right_trans;
            //  MessageBox.Show("ogogog");
        }


    }
}
