namespace nppSerialMonitor.Storage.Models
{
    public class SettingsModel
    {
        public string appname { get; set; }
        public string appversion { get; set; }
        public string port { get; set; }
        public int baud { get; set; }
        public int databits { get; set; }
        public string parity { get; set; }
        public string stopbits { get; set; }
    }
}
