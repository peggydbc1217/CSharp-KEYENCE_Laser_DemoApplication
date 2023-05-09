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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            const string targetFile = @"C:\Users\Larry\Desktop\客户资料\20201109晶碩\test_mfp\0088.MFP";
            const string convertedFile = @"C:\Users\Larry\Desktop\客户资料\20201109晶碩\test_mfp\0088.MX4";
            const string convertedLogFile = @"C:\Users\Larry\Desktop\客户资料\20201109晶碩\test_mfp\無題.txt";
            try
            {
                axMBActX1.ConvertMfpToMx(
                    targetFile,
                    convertedFile,
                    convertedLogFile);
            }
            catch (COMException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try{
                // 如果上一次在连接状态下结束了应用程序，相关实例可能会处
                //于联机状态，所以会释放
 if (axMBActX1.Comm.IsOnline)
                {
                    axMBActX1.Comm.Offline();
                }
                axMBActX1.Comm.ConnectionType =
                MB3Lib4.ConnectionTypes.CONNECTION_USB;
                bool is_success = axMBActX1.Comm.Online();
                if (is_success)
                {
                    MessageBox.Show("Online Success");
                }
                else
                {
                    MessageBox.Show("Online Failed");
                }
            }
catch (System.Runtime.InteropServices.COMException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            try
            {
                if (axMBActX1.OpenProgram(""))
                {
                    // TODO 此处为成功时的处理 
                }
            }
            catch (System.Runtime.InteropServices.COMException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try{
                axMBActX1.InitMBActXEx(MB3Lib4.MarkingUnitTypes.MARKINGUNIT_MDU1000,
               MB3Lib4.LanguageTypes.LANG_JA);
            }catch (System.Runtime.InteropServices.COMException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (axMBActX1.ZoomAdjust())
            {
                // TODO 此处为成功时的处理 
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try{
                axMBActX1.SendControllerFile(@"C:\Users\Larry\Documents\Marking Builder 3\Font\aaa.mft");
            }catch (System.Runtime.InteropServices.COMException error)
            {
                MessageBox.Show(error.Message);
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string markingunit_ip_adrress = IpAddress1.Text + "." + IpAddress2.Text + "." + IpAddress3.Text + "." + IpAddress4 + ".";
            try
            {
                // 如果上一次在连接状态下结束了应用程序，相关实例可能会处
                //于联机状态，所以会释放
                if (axMBActX1.Comm.IsOnline)
                {
                    axMBActX1.Comm.Offline();
                }

                axMBActX1.Comm.ConnectionType =
               MB3Lib4.ConnectionTypes.CONNECTION_ETHERNET;
                axMBActX1.Comm.IpAddress = markingunit_ip_adrress;
                bool is_success = axMBActX1.Comm.Online();
                if (is_success)
                {
                    MessageBox.Show("Online Success");
                }
                else
                {
                    MessageBox.Show("Online Failed");
                }
            }
            catch (System.Runtime.InteropServices.COMException error)
            {
                MessageBox.Show(error.Message);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
