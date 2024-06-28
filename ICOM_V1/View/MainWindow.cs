using System.IO.Ports;

namespace ICOM_V1
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();

            PulsihEventhandlers();
        }


        bool connected;

        private void PulsihEventhandlers()
        {
            Load += (s, e) =>
            {
                try
                {
                    // Load Init
                    if (Visa4Net.InitLibrary() != true)
                    {
                        DialogResult rc = MessageBox.Show("Init Visa Library Faiure.", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        if (rc == DialogResult.OK)
                        {
                            Environment.Exit(0);
                        }
                    }
                    // Default settings
                    textBoxIP1.Text = "192";
                    textBoxIP2.Text = "168";
                    textBoxIP3.Text = "1";
                    textBoxIP4.Text = "100";
                    textBoxPort.Text = "60000";

                    // Load COM Ports
                    string[] listCOMPort = SerialPort.GetPortNames();
                    if (listCOMPort.Length > 0 )
                    {
                        comboBoxCOMPort.DataSource = listCOMPort;
                    }
                }
                catch { }
            };
            #region Open the connection event

            // Open the connection via socket
            buttonOpenCloseEth.Click += (s, e) =>
            {
                try
                {
                    string[] tmp = new string[4];
                    string ip = "";
                    int port = 0;

                    // Get ip from view
                    tmp[0] = textBoxIP1.Text;
                    tmp[1] = textBoxIP2.Text;
                    tmp[2] = textBoxIP3.Text;
                    tmp[3] = textBoxIP4.Text;

                    for (int i = 0; i < 4; i++)
                    {
                        ip += tmp[i];
                        if (i != 3)
                            ip += ".";
                    }
                    port = int.Parse(textBoxPort.Text);

                    // Connect to instrument
                    if (!connected)
                    {                      
                        connected = VisaHelper.Open($"TCPIP0::{ip}::{port}::SOCKET");
                        if (connected)
                        {
                            MessageBox.Show("Open the connection OK.", "Info");
                            buttonOpenCloseEth.BackColor = Color.Lime;
                            buttonOpenCloseEth.Text = "Close";
                            groupBoxCOM.Enabled = false;
                            groupBoxUSB.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("Open the connection failure.", "Error");
                            buttonOpenCloseEth.Text = "Open";
                        }
                    }
                    else
                    {
                        connected = false;
                        VisaHelper.Close();
                        buttonOpenCloseEth.Text = "Open";
                        groupBoxCOM.Enabled = true;
                        groupBoxUSB.Enabled = true;
                    }
                }
                catch { }
            };

            // Open COM Port
            buttonOpenCloseCOM.Click += (s, e) =>
            {
                try
                {
                    if (!connected)
                    {
                        connected = VisaHelper.Open($"ASRL{Convert.ToInt32(comboBoxCOMPort.SelectedItem.ToString()?.Substring(3))}::INSTR");
                        if (connected)
                        {
                            MessageBox.Show("Open the connection OK.", "Info");
                            buttonOpenCloseEth.BackColor = Color.Lime;
                            buttonOpenCloseCOM.Text = "Close";
                            groupBoxEth.Enabled = false;
                            groupBoxUSB.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("Open the connection failure.", "Error");
                            buttonOpenCloseCOM.Text = "Open";
                        }
                    }
                    else
                    {
                        connected = false;
                        VisaHelper.Close();
                        buttonOpenCloseCOM.Text = "Open";
                        groupBoxEth.Enabled = true;
                        groupBoxUSB.Enabled = true;
                    }
                }
                catch { }
            };

            // Open USB Port
            buttonOpenCloseUSB.Click += (s, e) =>
            {
                try
                {
                    if (!connected)
                    {
                        connected = VisaHelper.Open(textBoxUSBResource.Text);
                        if (connected)
                        {
                            MessageBox.Show("Open the connection OK.", "Info");
                            buttonOpenCloseUSB.Text = "Close";
                            groupBoxEth.Enabled = false;
                            groupBoxCOM.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("Open the connection failure.", "Error");
                            buttonOpenCloseUSB.Text = "Open";
                        }
                    }
                    else
                    {
                        connected = false;
                        VisaHelper.Close();
                        buttonOpenCloseUSB.Text = "Open";
                        groupBoxEth.Enabled = true;
                        groupBoxCOM.Enabled = true;
                    }
                }
                catch { }
            };

            #endregion

            // Write cmd
            buttonWriteCmd.Click += (s, e) =>
            {
                try
                {
                    if (connected)
                    {
                        string cmd = textBoxDataWrite.Text;
                        bool ferr = VisaHelper.WriteCmd(cmd);
                        if (ferr)
                        {
                            listBoxDataRead.Items.Add($"[ OK ]: {cmd}");
                        }
                        else
                        {
                            listBoxDataRead.Items.Add($"[ ERROR ]: {cmd}");
                        }
                    }
                    else
                    {
                        MessageBox.Show("The instrument isn't connected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch { }
            };

            // Read Cmd
            buttonReadCmd.Click += (s, e) =>
            {
                try
                {
                    if (connected)
                    {
                        string cmd = textBoxDataWrite.Text;
                        bool ferr = VisaHelper.ReadCmd(cmd, out string outStr);
                        if (ferr)
                        {
                            listBoxDataRead.Items.Add($"[ WRITE ]: {cmd}");
                            listBoxDataRead.Items.Add($"[ QUERY ]: {outStr}");
                        }
                        else
                        {
                            listBoxDataRead.Items.Add($"[ ERROR ]: {cmd}");
                        }
                    }
                    else
                    {
                        MessageBox.Show("The instrument isn't connected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch { }
            };

            // Clear data read
            buttonClearScr.Click += (s, e) =>
            {
                try
                {
                    listBoxDataRead.Items.Clear();
                }
                catch { }
            };
        }
    }
}
