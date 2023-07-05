using System;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;

namespace NetworkLib
{

    public class NetworkDTO
    {
        public NetworkVO nwvo = null;

     
        public NetworkDTO()
        {
            CreateNetworkVo();
        }

        //
        public void CreateNetworkVo()
        {
            nwvo = new NetworkVO();
        }

        public void DeleteNetworkVo()
        {
            nwvo = null;
        }

        public void Connect(String NetworkType)
        {

        }

        public void DisConnect(String NetworkType)
        {

        }

        public bool IsConnectionCheck()
        {
            bool isRtn = false;
            isRtn = nwvo.getNwIsConnect10().Equals("1") ? true : false;
            return isRtn;
        }

 
        public int SendToPing(String strIp)
        {
            int iResult = 0;
            try
            {
                Ping pp = new Ping();
                PingOptions po = new PingOptions();

                po.DontFragment = true;

                byte[] bufData = Encoding.ASCII.GetBytes("");//""pingTest"

                PingReply reply = pp.Send(IPAddress.Parse(strIp), 10, bufData, po);

                if (reply.Status == IPStatus.Success)
                {
                    iResult = 1;
                }
                else
                {
                    iResult = 0;
                }
                return iResult;
            }
            catch
            {
                throw;
            }

        }

        public int SendToTcping(string strIp, string strPort, int millisecondsTimeout)
        {
            int iResult = 0;

            Socket socket = null;
            try
            {
                socket = new Socket(
                    AddressFamily.InterNetwork,
                    SocketType.Stream,
                    ProtocolType.Tcp
                );

                socket.SetSocketOption(
                    SocketOptionLevel.Socket,
                    SocketOptionName.DontLinger,
                    false
                );

                string input = strPort;
    
                int iPort = Int32.Parse(input);
                Console.WriteLine(iPort);

                IAsyncResult ret = socket.BeginConnect(strIp, iPort, null, null);
                iResult = ret.AsyncWaitHandle.WaitOne(millisecondsTimeout, true) ? 1 : 0;
    

            }
            catch { }
            finally
            {
                if (socket != null)
                {
                    socket.Close();
                }
            }
            return iResult;
        }

        public void setTcpConnect(bool isConn)
        {

        }

        public void getTcpConnect()
        {

        }

        public void setRs485Connect(bool isConn)
        {

        }

        public void getRS485Connect()
        {

        }

    }
}
