using Ivi.Visa;

namespace ICOM_V1
{
    public class VisaHelper
    {
        static IVisaSession? visaresource;
        static IMessageBasedSession? visasession;

        /// <summary>
        /// TCPIP0::{IPAddress}::{Port}::SOCKET"
        /// ASRL{COMPort}::INSTR
        /// USB0::0x05E6::0x2636::4351628::INSTR
        /// </summary>
        /// <param name="rc"></param>
        /// <param name="phy"></param>
        /// <returns></returns>
        public static bool Open(string rc)
        {
            try
            {
                visaresource = GlobalResourceManager.Open(rc, AccessModes.None, 2000);
                visasession = visaresource as IMessageBasedSession;
                // Check the connection
                if (visasession != null)
                {
                    visasession.TerminationCharacterEnabled = true;
                    return true;
                }
                return false;
            }
            catch { return false; }
        }

        public static void Close()
        {
            try
            {
                if (visaresource != null)
                    visaresource.Dispose();
            }
            catch { }
        }

        public static bool WriteCmd(string cmd)
        {
            try
            {
                if (visasession != null)
                {
                    visasession.FormattedIO.WriteLine(cmd);
                    return true;
                }
                return false;
            }
            catch { return false; }
        }

        public static bool ReadCmd(string cmd, out string outStr)
        {
            outStr = "";
            try
            {
                if (visasession != null)
                {
                    WriteCmd(cmd);
                    Thread.Sleep(30);
                    outStr = visasession.FormattedIO.ReadLine();
                    return true;
                }
                return false;
            }
            catch { return false; }
        }
    }
}
