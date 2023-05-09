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
    public partial class Form1 : Form
    {
        public Form1()
        {
                InitializeComponent();
  
                this.Controls.Add(new UP_Button(680,180));
                this.Controls.Add(new Right_Button(720,230));
                this.Controls.Add(new Left_Button(640,230));
                this.Controls.Add(new Down_Button(680, 280));
            
        }

        private void Direction_Button_MouseDown(object sender, MouseEventArgs e)
        {
            new Direction_Button(e.X,e.Y).BackColor = Color.PapayaWhip;

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

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //OpenFile.BackgroundImageLayout = ImageLayout.Stretch;
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
            try {
                axMBActX1.InitMBActXEx(MB3Lib4.MarkingUnitTypes.MARKINGUNIT_MDU1000,
               MB3Lib4.LanguageTypes.LANG_JA);
            } catch (System.Runtime.InteropServices.COMException error)
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
            try {
                axMBActX1.SendControllerFile(@"C:\Users\Larry\Documents\Marking Builder 3\Font\aaa.mft");
            } catch (System.Runtime.InteropServices.COMException error)
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

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {
            try
            {
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MB3Lib4.MarkingUnitTypes Series = (MB3Lib4.MarkingUnitTypes)Enum.Parse(typeof(MB3Lib4.MarkingUnitTypes), "MARKINGUNIT_" + Machine_Series.Text, false);

            try
            {
                axMBActX1.InitMBActXEx(Series, MB3Lib4.LanguageTypes.LANG_JA);
            }
            catch (System.Runtime.InteropServices.COMException error)
            {
                MessageBox.Show(error.Message);
                MessageBox.Show("請選擇現在使用的機型");
            }
        }

        private void addText_Click(object sender, EventArgs e)
        {
            if (exist_content != false)
            {
                CanBeSetted();
            }

            else 
            {
                MessageBox.Show("請輸入內容!");            
            }


        }

        bool exist_content = false;
        private void Block_content_TextChanged(object sender, EventArgs e)
        {
            if (Block_Content.Text.Length > 0)
            {
                exist_content = true;
            }
            else
            {
                exist_content = false;
            }
        }


        private void CanBeSetted()
        {

            int Current_Num = Int32.Parse(Block_Number.Text);
            String Current_content = Block_Content.Text;



            try
            {
                axMBActX1.Block(Current_Num).Text = Current_content;

                // 字符串信息组 No.的字符串变更 
            }
            catch (System.Runtime.InteropServices.COMException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            axMBActX1.Context = ContextTypes.CONTEXT_EDITING;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void Button_MouseMove(object sender, MouseEventArgs e)
        {
            

            
        }



    }
}
