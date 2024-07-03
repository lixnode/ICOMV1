using Ivi.Visa;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading;
using System.Windows;
using System.Windows.Documents;

namespace ICOM_V2
{
    public class MainViewModel : ViewModelBase
    {
        #region Constructors

        public MainViewModel()
        {
            QueryList = new ObservableCollection<string>();
        }

        #endregion

        #region Private members

        private IVisaSession VisaSession;
        private IMessageBasedSession MessageBasedSession;
        private bool connected;
        #endregion



        #region Properties

        private string resourceName = "TCPIP0::192.168.0.123::7000::SOCKET";
        public string ResourceName
        {
            get { return resourceName; }
            set
            {
                resourceName = value;
                OnPropertyChanged(nameof(ResourceName));
            }
        }

        private string cmdString;
        public string CmdString
        {
            get { return  cmdString; }
            set
            {
                cmdString = value;
                OnPropertyChanged(nameof(CmdString));
            }
        }

        public ObservableCollection<string> QueryList { get; set; }

        #endregion

        #region Commands

        private RelayCommand openCommand;
        public RelayCommand OpenCommand
        {
            get
            {
                if (openCommand == null)
                {
                    openCommand = new RelayCommand(obj =>
                    {
                        try
                        {
                            if (!string.IsNullOrEmpty(resourceName))
                            {
                                VisaSession = GlobalResourceManager.Open(resourceName, AccessModes.None, 2000);
                                MessageBasedSession = VisaSession as IMessageBasedSession;
                                // Check the connection
                                if (MessageBasedSession != null)
                                {
                                    MessageBasedSession.TerminationCharacterEnabled = true;
                                    connected = true;
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "ERROR");
                        }
                    }, obj => !connected);
                }
                return openCommand;
            }
        }

        private RelayCommand closeCommand;
        public RelayCommand CloseCommand
        {
            get
            {
                if (closeCommand == null)
                {
                    closeCommand = new RelayCommand(obj =>
                    {
                        if (VisaSession != null)
                        {
                            VisaSession.Dispose();
                            connected = false;
                        }
                    }, obj => connected);
                }
                return closeCommand;
            }
        }


        private RelayCommand writeCMD;
        public RelayCommand WriteCMD
        {
            get
            {
                if (writeCMD == null)
                {
                    writeCMD = new RelayCommand(obj =>
                    {
                        try
                        {
                            if (!string.IsNullOrEmpty(CmdString))
                            {
                                MessageBasedSession.FormattedIO.WriteLine(CmdString);
                                QueryList.Add($"> {CmdString}");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "ERROR");
                        }
                    }, obj => connected);
                }
                return writeCMD;
            }
        }

        private RelayCommand readCMD;
        public RelayCommand ReadCMD
        {
            get
            {
                if (readCMD == null)
                {
                    readCMD = new RelayCommand(obj =>
                    {
                        try
                        {
                            if (!string.IsNullOrEmpty(CmdString))
                            {
                                MessageBasedSession.FormattedIO.WriteLine(CmdString);
                                string chain = MessageBasedSession.FormattedIO.ReadLine();
                                QueryList.Add($"> {CmdString}");
                                QueryList.Add($"< {chain.Trim('\n')}");
                            }
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show(ex.Message, "ERROR");
                        }
                    }, obj => connected);
                }
                return readCMD;
            }
        }

        private RelayCommand clearHistory;
        public RelayCommand ClearHistory
        {
            get
            {
                if (clearHistory == null)
                {
                    clearHistory = new RelayCommand(obj =>
                    {
                        QueryList.Clear();
                    }, obj => QueryList.Count > 0);
                }
                return clearHistory;
            }
        }
        #endregion
    }
}
