using System;

namespace NetworkLib
{
    public class NetworkVO
    {
        private String NwId = String.Empty;
        private String NwIsAlive10 = String.Empty;
        private String NwType = String.Empty;
        private String NwIp = String.Empty;//NwHostIp;
        private String NwPort = String.Empty;
        private String NwIsConnect10 = String.Empty;

        //public string NwxId1 { get => NwxId; set => NwxId = value; }//Ctrl+R,E

        public String getNetworkType() { return NwType; }
        public void setNetworkType(String nwType) { NwType = nwType; }
        public String getNwxId() { return NwId; }
        public void setNwxId(String nwId) { NwId = nwId; }
        public String getNwIsAlive10() { return NwIsAlive10; }
        public void setNwIsAlive10(String nwIsAlive10) { NwIsAlive10 = nwIsAlive10; }
        public String getNwType() { return NwType; }
        public void setNwType(String nwType) { NwType = nwType; }
        public String getNwIp() { return NwIp; }
        public void setNwIp(String nwIp) { NwIp = nwIp; }
        public String getNwPort() { return NwPort; }
        public void setNwPort(String nwPort) { NwPort = nwPort; }
        public String getNwIsConnect10() { return NwIsConnect10; }
        public void setNwIsConnect10(String nwIsConnect10) { NwIsConnect10 = nwIsConnect10; }

        //[SupportedOSPlatform("windows")]
        public NetworkVO()
        {

        }
    }
}
