namespace PEAGA_MFP_TEST
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.axMBActX1 = new AxMB3Lib4.AxMBActX();
            this.button2 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.IpAddress1 = new System.Windows.Forms.TextBox();
            this.IpAddress2 = new System.Windows.Forms.TextBox();
            this.IpAddress3 = new System.Windows.Forms.TextBox();
            this.IpAddress4 = new System.Windows.Forms.TextBox();
            this.Ethernet_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Machine_Series = new System.Windows.Forms.ComboBox();
            this.addText = new System.Windows.Forms.Button();
            this.Block_Content = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Block_Number = new System.Windows.Forms.TextBox();
            this.Up_Button = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Ethernet_connect = new System.Windows.Forms.PictureBox();
            this.OpenFile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axMBActX1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Up_Button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ethernet_connect)).BeginInit();
            this.SuspendLayout();
            // 
            // axMBActX1
            // 
            this.axMBActX1.Enabled = true;
            this.axMBActX1.Location = new System.Drawing.Point(12, 37);
            this.axMBActX1.Name = "axMBActX1";
            this.axMBActX1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMBActX1.OcxState")));
            this.axMBActX1.Size = new System.Drawing.Size(382, 294);
            this.axMBActX1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1074, 311);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(177, 75);
            this.button2.TabIndex = 2;
            this.button2.Text = "MFP Convert";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1144, 157);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(107, 49);
            this.button6.TabIndex = 7;
            this.button6.Text = "斷開連線";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button7.Location = new System.Drawing.Point(1118, 24);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(126, 45);
            this.button7.TabIndex = 8;
            this.button7.Text = "調節顯示";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(1118, 263);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(132, 33);
            this.button8.TabIndex = 9;
            this.button8.Text = "傳檔案進雷雕機";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // IpAddress1
            // 
            this.IpAddress1.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.IpAddress1.Location = new System.Drawing.Point(556, 367);
            this.IpAddress1.Name = "IpAddress1";
            this.IpAddress1.Size = new System.Drawing.Size(39, 25);
            this.IpAddress1.TabIndex = 10;
            this.IpAddress1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.IpAddress1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // IpAddress2
            // 
            this.IpAddress2.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.IpAddress2.Location = new System.Drawing.Point(602, 367);
            this.IpAddress2.Name = "IpAddress2";
            this.IpAddress2.Size = new System.Drawing.Size(39, 25);
            this.IpAddress2.TabIndex = 15;
            this.IpAddress2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // IpAddress3
            // 
            this.IpAddress3.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.IpAddress3.Location = new System.Drawing.Point(648, 367);
            this.IpAddress3.Name = "IpAddress3";
            this.IpAddress3.Size = new System.Drawing.Size(39, 25);
            this.IpAddress3.TabIndex = 16;
            this.IpAddress3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // IpAddress4
            // 
            this.IpAddress4.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.IpAddress4.Location = new System.Drawing.Point(694, 367);
            this.IpAddress4.Name = "IpAddress4";
            this.IpAddress4.Size = new System.Drawing.Size(39, 25);
            this.IpAddress4.TabIndex = 17;
            this.IpAddress4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Ethernet_label
            // 
            this.Ethernet_label.AutoSize = true;
            this.Ethernet_label.BackColor = System.Drawing.SystemColors.Info;
            this.Ethernet_label.Font = new System.Drawing.Font("標楷體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Ethernet_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Ethernet_label.Location = new System.Drawing.Point(546, 314);
            this.Ethernet_label.Name = "Ethernet_label";
            this.Ethernet_label.Size = new System.Drawing.Size(116, 17);
            this.Ethernet_label.TabIndex = 19;
            this.Ethernet_label.Text = "Ethernet連線";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Font = new System.Drawing.Font("標楷體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(546, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "USB連線";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Info;
            this.label2.Font = new System.Drawing.Font("標楷體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(546, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "選擇機型";
            // 
            // Machine_Series
            // 
            this.Machine_Series.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Machine_Series.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Machine_Series.FormattingEnabled = true;
            this.Machine_Series.Items.AddRange(new object[] {
            "MDU1000",
            "MDU1020",
            "MDX1000",
            "MDX1500",
            "MLZ9610",
            "MLZ9620",
            "MLZ9650"});
            this.Machine_Series.Location = new System.Drawing.Point(633, 157);
            this.Machine_Series.Name = "Machine_Series";
            this.Machine_Series.Size = new System.Drawing.Size(121, 23);
            this.Machine_Series.TabIndex = 23;
            this.Machine_Series.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // addText
            // 
            this.addText.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.addText.Location = new System.Drawing.Point(819, 198);
            this.addText.Name = "addText";
            this.addText.Size = new System.Drawing.Size(83, 27);
            this.addText.TabIndex = 24;
            this.addText.Text = "確定創建";
            this.addText.UseVisualStyleBackColor = true;
            this.addText.Click += new System.EventHandler(this.addText_Click);
            // 
            // Block_Content
            // 
            this.Block_Content.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.Block_Content.Location = new System.Drawing.Point(937, 164);
            this.Block_Content.Name = "Block_Content";
            this.Block_Content.Size = new System.Drawing.Size(139, 25);
            this.Block_Content.TabIndex = 25;
            this.Block_Content.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Block_Content.TextChanged += new System.EventHandler(this.Block_content_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1159, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "編輯";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Info;
            this.label3.Font = new System.Drawing.Font("標楷體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(816, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "信息組編號";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Info;
            this.label4.Font = new System.Drawing.Font("標楷體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(816, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 17);
            this.label4.TabIndex = 28;
            this.label4.Text = "信息組內容";
            // 
            // Block_Number
            // 
            this.Block_Number.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.Block_Number.Location = new System.Drawing.Point(937, 129);
            this.Block_Number.Name = "Block_Number";
            this.Block_Number.Size = new System.Drawing.Size(35, 25);
            this.Block_Number.TabIndex = 29;
            this.Block_Number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Up_Button
            // 
            this.Up_Button.BackColor = System.Drawing.Color.Transparent;
            this.Up_Button.Image = global::PEAGA_MFP_TEST.Properties.Resources.left_trans;
            this.Up_Button.Location = new System.Drawing.Point(1174, 88);
            this.Up_Button.Name = "Up_Button";
            this.Up_Button.Size = new System.Drawing.Size(60, 60);
            this.Up_Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Up_Button.TabIndex = 30;
            this.Up_Button.TabStop = false;
            this.Up_Button.Click += new System.EventHandler(this.pictureBox2_Click);
           
            // 
            // pictureBox1
            // 
           
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.pictureBox1.Image = global::PEAGA_MFP_TEST.Properties.Resources.USB_PNP;
            this.pictureBox1.Location = new System.Drawing.Point(667, 222);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_2);
            // 
            // Ethernet_connect
            // 
            this.Ethernet_connect.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Ethernet_connect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Ethernet_connect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Ethernet_connect.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.Ethernet_connect.Image = global::PEAGA_MFP_TEST.Properties.Resources.ethernet;
            this.Ethernet_connect.Location = new System.Drawing.Point(668, 306);
            this.Ethernet_connect.Name = "Ethernet_connect";
            this.Ethernet_connect.Size = new System.Drawing.Size(66, 55);
            this.Ethernet_connect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ethernet_connect.TabIndex = 14;
            this.Ethernet_connect.TabStop = false;
            this.Ethernet_connect.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // OpenFile
            // 
            this.OpenFile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.OpenFile.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OpenFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OpenFile.Image = global::PEAGA_MFP_TEST.Properties.Resources.openfile1;
            this.OpenFile.Location = new System.Drawing.Point(807, 24);
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(126, 76);
            this.OpenFile.TabIndex = 5;
            this.OpenFile.Text = "打開檔案";
            this.OpenFile.UseVisualStyleBackColor = true;
            this.OpenFile.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1262, 465);
            this.Controls.Add(this.Up_Button);
            this.Controls.Add(this.Block_Number);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Block_Content);
            this.Controls.Add(this.addText);
            this.Controls.Add(this.Machine_Series);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Ethernet_label);
            this.Controls.Add(this.IpAddress4);
            this.Controls.Add(this.IpAddress3);
            this.Controls.Add(this.IpAddress2);
            this.Controls.Add(this.Ethernet_connect);
            this.Controls.Add(this.IpAddress1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.OpenFile);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.axMBActX1);
            this.HelpButton = true;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axMBActX1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Up_Button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ethernet_connect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxMB3Lib4.AxMBActX axMBActX1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button OpenFile;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.PictureBox Ethernet_connect;
        private System.Windows.Forms.TextBox IpAddress1;
        private System.Windows.Forms.TextBox IpAddress2;
        private System.Windows.Forms.TextBox IpAddress3;
        private System.Windows.Forms.TextBox IpAddress4;
        private System.Windows.Forms.Label Ethernet_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Machine_Series;
        private System.Windows.Forms.Button addText;
        private System.Windows.Forms.TextBox Block_Content;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Block_Number;
        private System.Windows.Forms.PictureBox Up_Button;
    }
}

