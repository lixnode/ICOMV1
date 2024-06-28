namespace ICOM_V1
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            menuStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            panel2 = new Panel();
            groupBox3 = new GroupBox();
            groupBoxUSB = new GroupBox();
            textBoxUSBResource = new TextBox();
            label6 = new Label();
            buttonOpenCloseUSB = new Button();
            groupBoxCOM = new GroupBox();
            comboBoxCOMPort = new ComboBox();
            textBoxBaudrate = new TextBox();
            buttonOpenCloseCOM = new Button();
            label3 = new Label();
            label4 = new Label();
            groupBoxEth = new GroupBox();
            textBoxIP3 = new TextBox();
            textBoxIP2 = new TextBox();
            buttonOpenCloseEth = new Button();
            textBoxIP1 = new TextBox();
            textBoxIP4 = new TextBox();
            textBoxPort = new TextBox();
            label2 = new Label();
            label1 = new Label();
            listBoxDataRead = new ListBox();
            textBoxDataWrite = new TextBox();
            buttonClearScr = new Button();
            buttonReadCmd = new Button();
            buttonWriteCmd = new Button();
            menuStrip.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBoxUSB.SuspendLayout();
            groupBoxCOM.SuspendLayout();
            groupBoxEth.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(7, 3, 0, 3);
            menuStrip.Size = new Size(1150, 30);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 30);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1150, 627);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox3);
            panel2.Controls.Add(groupBoxUSB);
            panel2.Controls.Add(groupBoxCOM);
            panel2.Controls.Add(groupBoxEth);
            panel2.Controls.Add(listBoxDataRead);
            panel2.Controls.Add(textBoxDataWrite);
            panel2.Controls.Add(buttonClearScr);
            panel2.Controls.Add(buttonReadCmd);
            panel2.Controls.Add(buttonWriteCmd);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1150, 627);
            panel2.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Location = new Point(758, 159);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(383, 464);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Command List";
            // 
            // groupBoxUSB
            // 
            groupBoxUSB.Controls.Add(textBoxUSBResource);
            groupBoxUSB.Controls.Add(label6);
            groupBoxUSB.Controls.Add(buttonOpenCloseUSB);
            groupBoxUSB.Location = new Point(758, 3);
            groupBoxUSB.Name = "groupBoxUSB";
            groupBoxUSB.Size = new Size(383, 152);
            groupBoxUSB.TabIndex = 4;
            groupBoxUSB.TabStop = false;
            groupBoxUSB.Text = "USB";
            // 
            // textBoxUSBResource
            // 
            textBoxUSBResource.Location = new Point(18, 61);
            textBoxUSBResource.Margin = new Padding(3, 4, 3, 4);
            textBoxUSBResource.Name = "textBoxUSBResource";
            textBoxUSBResource.Size = new Size(329, 27);
            textBoxUSBResource.TabIndex = 0;
            textBoxUSBResource.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 38);
            label6.Name = "label6";
            label6.Size = new Size(69, 20);
            label6.TabIndex = 1;
            label6.Text = "Resource";
            // 
            // buttonOpenCloseUSB
            // 
            buttonOpenCloseUSB.FlatStyle = FlatStyle.System;
            buttonOpenCloseUSB.Location = new Point(248, 106);
            buttonOpenCloseUSB.Margin = new Padding(3, 4, 3, 4);
            buttonOpenCloseUSB.Name = "buttonOpenCloseUSB";
            buttonOpenCloseUSB.Size = new Size(99, 32);
            buttonOpenCloseUSB.TabIndex = 2;
            buttonOpenCloseUSB.Text = "Open";
            buttonOpenCloseUSB.UseVisualStyleBackColor = true;
            // 
            // groupBoxCOM
            // 
            groupBoxCOM.Controls.Add(comboBoxCOMPort);
            groupBoxCOM.Controls.Add(textBoxBaudrate);
            groupBoxCOM.Controls.Add(buttonOpenCloseCOM);
            groupBoxCOM.Controls.Add(label3);
            groupBoxCOM.Controls.Add(label4);
            groupBoxCOM.Location = new Point(377, 3);
            groupBoxCOM.Name = "groupBoxCOM";
            groupBoxCOM.Size = new Size(378, 152);
            groupBoxCOM.TabIndex = 4;
            groupBoxCOM.TabStop = false;
            groupBoxCOM.Text = "COM Setting";
            // 
            // comboBoxCOMPort
            // 
            comboBoxCOMPort.FormattingEnabled = true;
            comboBoxCOMPort.Location = new Point(24, 61);
            comboBoxCOMPort.Name = "comboBoxCOMPort";
            comboBoxCOMPort.Size = new Size(216, 28);
            comboBoxCOMPort.TabIndex = 2;
            // 
            // textBoxBaudrate
            // 
            textBoxBaudrate.Location = new Point(263, 61);
            textBoxBaudrate.Margin = new Padding(3, 4, 3, 4);
            textBoxBaudrate.Name = "textBoxBaudrate";
            textBoxBaudrate.Size = new Size(99, 27);
            textBoxBaudrate.TabIndex = 0;
            textBoxBaudrate.Text = "115200";
            // 
            // buttonOpenCloseCOM
            // 
            buttonOpenCloseCOM.FlatStyle = FlatStyle.System;
            buttonOpenCloseCOM.Location = new Point(263, 106);
            buttonOpenCloseCOM.Margin = new Padding(3, 4, 3, 4);
            buttonOpenCloseCOM.Name = "buttonOpenCloseCOM";
            buttonOpenCloseCOM.Size = new Size(99, 32);
            buttonOpenCloseCOM.TabIndex = 2;
            buttonOpenCloseCOM.Text = "Open";
            buttonOpenCloseCOM.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(263, 36);
            label3.Name = "label3";
            label3.Size = new Size(43, 20);
            label3.TabIndex = 1;
            label3.Text = "Baud";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 38);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 1;
            label4.Text = "COM Port";
            // 
            // groupBoxEth
            // 
            groupBoxEth.Controls.Add(textBoxIP3);
            groupBoxEth.Controls.Add(textBoxIP2);
            groupBoxEth.Controls.Add(buttonOpenCloseEth);
            groupBoxEth.Controls.Add(textBoxIP1);
            groupBoxEth.Controls.Add(textBoxIP4);
            groupBoxEth.Controls.Add(textBoxPort);
            groupBoxEth.Controls.Add(label2);
            groupBoxEth.Controls.Add(label1);
            groupBoxEth.Location = new Point(3, 3);
            groupBoxEth.Name = "groupBoxEth";
            groupBoxEth.Size = new Size(368, 152);
            groupBoxEth.TabIndex = 4;
            groupBoxEth.TabStop = false;
            groupBoxEth.Text = "IP Setting";
            // 
            // textBoxIP3
            // 
            textBoxIP3.BorderStyle = BorderStyle.FixedSingle;
            textBoxIP3.Location = new Point(135, 62);
            textBoxIP3.Margin = new Padding(3, 4, 3, 4);
            textBoxIP3.Name = "textBoxIP3";
            textBoxIP3.Size = new Size(54, 27);
            textBoxIP3.TabIndex = 0;
            textBoxIP3.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxIP2
            // 
            textBoxIP2.BorderStyle = BorderStyle.FixedSingle;
            textBoxIP2.Location = new Point(75, 62);
            textBoxIP2.Margin = new Padding(3, 4, 3, 4);
            textBoxIP2.Name = "textBoxIP2";
            textBoxIP2.Size = new Size(54, 27);
            textBoxIP2.TabIndex = 0;
            textBoxIP2.TextAlign = HorizontalAlignment.Center;
            // 
            // buttonOpenCloseEth
            // 
            buttonOpenCloseEth.FlatStyle = FlatStyle.System;
            buttonOpenCloseEth.Location = new Point(265, 106);
            buttonOpenCloseEth.Margin = new Padding(3, 4, 3, 4);
            buttonOpenCloseEth.Name = "buttonOpenCloseEth";
            buttonOpenCloseEth.Size = new Size(99, 32);
            buttonOpenCloseEth.TabIndex = 2;
            buttonOpenCloseEth.Text = "Open";
            buttonOpenCloseEth.UseVisualStyleBackColor = true;
            // 
            // textBoxIP1
            // 
            textBoxIP1.BorderStyle = BorderStyle.FixedSingle;
            textBoxIP1.Location = new Point(15, 62);
            textBoxIP1.Margin = new Padding(3, 4, 3, 4);
            textBoxIP1.Name = "textBoxIP1";
            textBoxIP1.Size = new Size(54, 27);
            textBoxIP1.TabIndex = 0;
            textBoxIP1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxIP4
            // 
            textBoxIP4.BorderStyle = BorderStyle.FixedSingle;
            textBoxIP4.Location = new Point(195, 62);
            textBoxIP4.Margin = new Padding(3, 4, 3, 4);
            textBoxIP4.Name = "textBoxIP4";
            textBoxIP4.Size = new Size(54, 27);
            textBoxIP4.TabIndex = 0;
            textBoxIP4.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxPort
            // 
            textBoxPort.BorderStyle = BorderStyle.FixedSingle;
            textBoxPort.Location = new Point(265, 62);
            textBoxPort.Margin = new Padding(3, 4, 3, 4);
            textBoxPort.Name = "textBoxPort";
            textBoxPort.Size = new Size(99, 27);
            textBoxPort.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(265, 37);
            label2.Name = "label2";
            label2.Size = new Size(35, 20);
            label2.TabIndex = 1;
            label2.Text = "Port";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 38);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 1;
            label1.Text = "IP Address";
            // 
            // listBoxDataRead
            // 
            listBoxDataRead.FormattingEnabled = true;
            listBoxDataRead.ItemHeight = 20;
            listBoxDataRead.Location = new Point(3, 199);
            listBoxDataRead.Margin = new Padding(3, 4, 3, 4);
            listBoxDataRead.Name = "listBoxDataRead";
            listBoxDataRead.Size = new Size(624, 424);
            listBoxDataRead.TabIndex = 3;
            // 
            // textBoxDataWrite
            // 
            textBoxDataWrite.Location = new Point(3, 162);
            textBoxDataWrite.Margin = new Padding(3, 4, 3, 4);
            textBoxDataWrite.Name = "textBoxDataWrite";
            textBoxDataWrite.Size = new Size(621, 27);
            textBoxDataWrite.TabIndex = 0;
            textBoxDataWrite.Text = "*IDN?";
            // 
            // buttonClearScr
            // 
            buttonClearScr.FlatStyle = FlatStyle.System;
            buttonClearScr.Location = new Point(630, 239);
            buttonClearScr.Margin = new Padding(3, 4, 3, 4);
            buttonClearScr.Name = "buttonClearScr";
            buttonClearScr.Size = new Size(122, 32);
            buttonClearScr.TabIndex = 2;
            buttonClearScr.Text = "Clear";
            buttonClearScr.UseVisualStyleBackColor = true;
            // 
            // buttonReadCmd
            // 
            buttonReadCmd.FlatStyle = FlatStyle.System;
            buttonReadCmd.Location = new Point(630, 199);
            buttonReadCmd.Margin = new Padding(3, 4, 3, 4);
            buttonReadCmd.Name = "buttonReadCmd";
            buttonReadCmd.Size = new Size(122, 32);
            buttonReadCmd.TabIndex = 2;
            buttonReadCmd.Text = "ReadCmd";
            buttonReadCmd.UseVisualStyleBackColor = true;
            // 
            // buttonWriteCmd
            // 
            buttonWriteCmd.FlatStyle = FlatStyle.System;
            buttonWriteCmd.Location = new Point(630, 159);
            buttonWriteCmd.Margin = new Padding(3, 4, 3, 4);
            buttonWriteCmd.Name = "buttonWriteCmd";
            buttonWriteCmd.Size = new Size(122, 32);
            buttonWriteCmd.TabIndex = 2;
            buttonWriteCmd.Text = "WriteCmd";
            buttonWriteCmd.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1150, 657);
            Controls.Add(panel1);
            Controls.Add(menuStrip);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "MainWindow";
            Text = "ICOM V1.0.3";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBoxUSB.ResumeLayout(false);
            groupBoxUSB.PerformLayout();
            groupBoxCOM.ResumeLayout(false);
            groupBoxCOM.PerformLayout();
            groupBoxEth.ResumeLayout(false);
            groupBoxEth.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private Panel panel1;
        private Label label1;
        private TextBox textBoxIP1;
        private Panel panel2;
        private Label label2;
        private TextBox textBoxPort;
        private TextBox textBoxIP4;
        private TextBox textBoxIP3;
        private TextBox textBoxIP2;
        private Button buttonOpenCloseEth;
        private ListBox listBoxDataRead;
        private TextBox textBoxDataWrite;
        private Button buttonReadCmd;
        private Button buttonWriteCmd;
        private Button buttonClearScr;
        private GroupBox groupBoxEth;
        private GroupBox groupBoxCOM;
        private TextBox textBoxBaudrate;
        private Label label3;
        private Label label4;
        private GroupBox groupBoxUSB;
        private TextBox textBoxUSBResource;
        private Label label6;
        private GroupBox groupBox3;
        private ComboBox comboBoxCOMPort;
        private Button buttonOpenCloseUSB;
        private Button buttonOpenCloseCOM;
    }
}
