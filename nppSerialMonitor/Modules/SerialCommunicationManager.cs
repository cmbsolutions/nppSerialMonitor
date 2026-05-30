using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Ports;
using System.Linq;
using System.Management;
using System.Text;
using System.Text.RegularExpressions;


namespace nppSerialMonitor.Modules
{
    public class SerialCommunicationManager
    {
        public event UpdateMessageEventHandler UpdateMessage;

        public delegate void UpdateMessageEventHandler(object sender, SerialCommunicationManagerMessageEventArgs e);
        public event ConnectionStateChangedEventHandler ConnectionStateChanged;

        public delegate void ConnectionStateChangedEventHandler(object sender, SerialCommunicationManagerConnectionEventArgs e);

        public SerialPort CommPort { get; set; }
        public int BaudRate { get; set; }
        public Parity Parity { get; set; }
        public int DataBits { get; set; }
        public StopBits StopBits { get; set; }

        public string PortName { get; set; }

        public TransmissionTypes TxTransmissionType { get; set; }
        public TransmissionTypes RxTransmissionType { get; set; }
        public string Message { get; set; }
        public MessageTypes MessageType { get; set; }
        public NewLineTypes NewLineType { get; set; }

        private readonly StringBuilder _rxBuffer = new StringBuilder();
        private readonly object _rxLock = new object();

        public string NewlineString
        {
            get
            {
                return NewLineType.ToString();
            }
        }

        public bool IsOpen
        {
            get
            {
                if (this.CommPort is null)
                    return false;
                return this.CommPort.IsOpen;
            }
        }

        public SerialCommunicationManager(int prmBaud, Parity prmParity, StopBits prmStopBits, int prmDataBits, string prmPortName, NewLineTypes prmNewLine)
        {
            try
            {
                this.BaudRate = prmBaud;
                this.Parity = prmParity;
                this.StopBits = prmStopBits;
                this.DataBits = prmDataBits;
                this.PortName = prmPortName;
                this.NewLineType = prmNewLine;
                this.CommPort = new SerialPort();
                this.CommPort.DataReceived += ComPort_DataReceived;
                this.ConnectionStateChanged?.Invoke(this, new SerialCommunicationManagerConnectionEventArgs(ConnectionStates.Closed));
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }

        public SerialCommunicationManager()
        {
            try
            {
                this.BaudRate = 9600;
                this.Parity = System.IO.Ports.Parity.None;
                this.StopBits = System.IO.Ports.StopBits.One;
                this.DataBits = 8;
                this.NewLineType = NewLineTypes.Lf;

                if (SerialPort.GetPortNames().Length > 0)
                    this.PortName = SerialPort.GetPortNames()[0];

                this.CommPort = new SerialPort();

                this.CommPort.DataReceived += ComPort_DataReceived;
                this.ConnectionStateChanged?.Invoke(this, new SerialCommunicationManagerConnectionEventArgs(ConnectionStates.Closed));
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }

        public void WriteData(string msg)
        {
            try
            {
                if (!(this.CommPort.IsOpen == true))
                {
                    this.CommPort.Open();
                    this.ConnectionStateChanged?.Invoke(this, new SerialCommunicationManagerConnectionEventArgs(ConnectionStates.Open));
                }
                switch (this.TxTransmissionType)
                {
                    case TransmissionTypes.Text:
                        {
                            this.CommPort.WriteLine(msg);
                            this.MessageType = MessageTypes.Outgoing;
                            this.Message = msg;
                            break;
                        }
                    case TransmissionTypes.Hex:
                        {
                            try
                            {
                                byte[] newMsg = HexToByte(msg);
                                this.CommPort.Write(newMsg, 0, newMsg.Length);
                                this.MessageType = MessageTypes.Outgoing;
                                this.Message = ByteToHex(newMsg);
                            }
                            catch (FormatException ex)
                            {
                                this.MessageType = MessageTypes.Error;
                                this.Message = ex.Message;
                            }

                            break;
                        }

                    default:
                        {
                            this.CommPort.Write(msg);
                            this.MessageType = MessageTypes.Outgoing;
                            this.Message = msg;
                            break;
                        }
                }

                this.UpdateMessage?.Invoke(this, new SerialCommunicationManagerMessageEventArgs(this.Message, this.MessageType));
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }

        public void WriteBytes(byte[] msg)
        {
            try
            {
                if (!this.CommPort.IsOpen)
                {
                    this.CommPort.Open();
                    this.ConnectionStateChanged?.Invoke(this, new SerialCommunicationManagerConnectionEventArgs(ConnectionStates.Open));
                }

                this.CommPort.Write(msg, 0, msg.Length);
                this.MessageType = MessageTypes.Outgoing;
                this.Message = ByteToHex(msg);

                UpdateMessage?.Invoke(this, new SerialCommunicationManagerMessageEventArgs(this.Message, this.MessageType, TransmissionTypes.Hex));
            }
            catch (FormatException ex)
            {
                Debug.WriteLine(ex);
            }
        }

        private byte[] HexToByte(string msg)
        {
            try
            {
                if (!Regex.IsMatch(msg, @"\A\b[0-9a-fA-F]+\b\Z", RegexOptions.IgnoreCase))
                    msg = StrToHex(msg);
                if (msg.Length % 2 == 0)
                {
                    this.Message = msg;
                    this.Message = msg.Replace(" ", "");
                    byte[] comBuffer = new byte[((int)Math.Round(this.Message.Length / 2d))];
                    for (int i = 0; i <= this.Message.Length - 1; i += 2)
                        comBuffer[(int)Math.Round(i / 2d)] = Convert.ToByte(this.Message.Substring(i, 2), 16);
                    return comBuffer;
                }
                else
                {
                    this.Message = "Invalid format";
                    this.MessageType = MessageTypes.Error;
                    return null;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            return null;
        }

        private StringBuilder _hexBuilder;
        private string ByteToHex(IEnumerable<byte> comByte)
        {
            try
            {
                if (_hexBuilder is null)
                    _hexBuilder = new StringBuilder();
                _hexBuilder.Clear();
                foreach (byte data in comByte)
                    _hexBuilder.Append(Convert.ToString(data, 16).PadLeft(2, '0').PadRight(3, ' '));
                return _hexBuilder.ToString().ToUpper();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            return null;
        }

        private string StrToHex(string data)
        {
            byte[] byteArray = Encoding.UTF8.GetBytes(data);

            // Convert the byte array to hexadecimal string
            string hexString = BitConverter.ToString(byteArray).Replace("-", "");

            return hexString;
        }

        public bool OpenPort()
        {
            try
            {
                if (this.CommPort.IsOpen == true)
                {
                    this.CommPort.Close();
                    ConnectionStateChanged?.Invoke(this, new SerialCommunicationManagerConnectionEventArgs(ConnectionStates.Closed));
                }
                this.CommPort.BaudRate = this.BaudRate;
                this.CommPort.DataBits = this.DataBits;
                this.CommPort.StopBits = this.StopBits;
                this.CommPort.Parity = this.Parity;
                this.CommPort.PortName = this.PortName;
                this.CommPort.Encoding = Encoding.UTF8;
                this.CommPort.NewLine = NewlineString;

                this.CommPort.WriteTimeout = 1500;
                this.CommPort.ReadTimeout = 1500;

                this.CommPort.Open();
                ConnectionStateChanged?.Invoke(this, new SerialCommunicationManagerConnectionEventArgs(ConnectionStates.Open));
                this.CommPort.DiscardOutBuffer();
                this.CommPort.DiscardInBuffer();

                this.MessageType = MessageTypes.Status;
                this.Message = $"Port opened at {DateTime.Now:dd-MM-yyyy HH:mm:ss.fff}";

                UpdateMessage?.Invoke(this, new SerialCommunicationManagerMessageEventArgs(this.Message, this.MessageType));
                return true;
            }
            catch (Exception ex)
            {
                UpdateMessage?.Invoke(this, new SerialCommunicationManagerMessageEventArgs(ex.Message, MessageTypes.Error));
                ConnectionStateChanged?.Invoke(this, new SerialCommunicationManagerConnectionEventArgs(ConnectionStates.Closed));
                return false;
            }
        }

        public void ClosePort()
        {
            if (this.CommPort.IsOpen)
            {
                this.Message = $"Port closed at {DateTime.Now:dd-MM-yyyy HH:mm:ss.fff}";
                this.MessageType = MessageTypes.Status;
                this.CommPort.Close();
                UpdateMessage?.Invoke(this, new SerialCommunicationManagerMessageEventArgs(this.Message, this.MessageType));
                ConnectionStateChanged?.Invoke(this, new SerialCommunicationManagerConnectionEventArgs(ConnectionStates.Closed));
            }
            else
            {
                this.Message = string.Format("Port already closed");
                this.MessageType = MessageTypes.Warning;
                UpdateMessage?.Invoke(this, new SerialCommunicationManagerMessageEventArgs(this.Message, this.MessageType));
                ConnectionStateChanged?.Invoke(this, new SerialCommunicationManagerConnectionEventArgs(ConnectionStates.Closed));
            }
        }

        public List<string> GetTransmissionValues()
        {
            List<string> values = new List<string>();

            foreach (string str in Enum.GetNames(typeof(TransmissionTypes)))
                values.Add(str);

            return values;
        }

        public List<string> GetNewLineValues()
        {
            List<string> values = new List<string>();

            foreach (string str in Enum.GetNames(typeof(NewLineTypes)))
                values.Add(str);

            return values;
        }

        public List<string> GetParityValues()
        {
            List<string> values = new List<string>();
            foreach (string str in Enum.GetNames(typeof(Parity)))
                values.Add(str);

            return values;
        }

        public List<int> GetBaudValues()
        {
            List<int> values = new List<int> { 9600, 19200, 38400, 57600, 115200, 250000 } ;

            return values;
        }

        public List<string> GetStopBitValues()
        {
            List<string> values = new List<string>();
            foreach (string str in Enum.GetNames(typeof(StopBits)))
                values.Add(str);

            return values;
        }

        public List<int> GetDataBitValues()
        {
            return new List<int> { 4,5,6,7,8 };            
        }

        public List<ComPortInfo> GetPortNames()
        {
            return this.GetComPortsWithDescriptions();
        }

        private void ComPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {

                string chunk = this.CommPort.ReadExisting();
                if (string.IsNullOrEmpty(chunk))
                    return;

                lock (_rxLock)
                {
                    _rxBuffer.Append(chunk);

                    while (true)
                    {
                        string data = _rxBuffer.ToString();
                        int lf = data.IndexOf('\n');
                        if (lf < 0) break; // no complete line yet

                        // Extract a line (without LF)
                        string line = data.Substring(0, lf);

                        // Trim optional CR
                        if (line.EndsWith("\r", StringComparison.Ordinal))
                            line = line.Substring(0, line.Length - 1);

                        // Remove consumed content (+ LF)
                        _rxBuffer.Remove(0, lf + 1);

                        // Fire exactly once per complete line
                        this.MessageType = MessageTypes.Incoming;
                        this.Message = line + "\n";
                        UpdateMessage?.Invoke(this, new SerialCommunicationManagerMessageEventArgs(this.Message, this.MessageType));
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }

        public enum TransmissionTypes
        {
            Text,
            Hex,
            Bin,
            Dec
        }

        public enum MessageTypes
        {
            Incoming,
            Outgoing,
            Normal,
            Warning,
            Error,
            Status
        }

        public enum NewLineTypes
        {
            Cr = 13,
            Lf = 10,
            CrLf = 1310
        }

        public enum ConnectionStates
        {
            Open,
            Closed,
            Error
        }

        private List<ComPortInfo> GetComPortsWithDescriptions()
        {
            var ports = new List<ComPortInfo>();

            // Get all serial ports reported by Windows
            string[] portNames = SerialPort.GetPortNames();

            // Query Win32_PnPEntity for devices that expose COM ports
            using (var searcher = new ManagementObjectSearcher(
                "SELECT * FROM Win32_PnPEntity WHERE Name LIKE '%(COM%'"))
            {
                foreach (ManagementObject device in searcher.Get())
                {
                    string name = device["Name"]?.ToString();
                    if (string.IsNullOrEmpty(name))
                        continue;

                    // Extract COM port from "USB-Serial Device (COM7)"
                    int start = name.LastIndexOf("(COM");
                    if (start < 0)
                        continue;

                    int end = name.IndexOf(")", start);
                    if (end < 0)
                        continue;

                    string port = name.Substring(start + 1, end - start - 1); // COM7

                    if (portNames.Contains(port))
                    {
                        ports.Add(new ComPortInfo
                        {
                            PortName = port,
                            Description = name.Replace($"({port})", "").Trim()
                        });
                    }
                }
            }

            return ports;
        }
    }
    public class ComPortInfo
    {
        public string PortName { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return $"{PortName} - {Description}";
        }
    }

    public class SerialCommunicationManagerMessageEventArgs : EventArgs
    {

        public SerialCommunicationManagerMessageEventArgs()
        {
        }

        public SerialCommunicationManagerMessageEventArgs(string msg, SerialCommunicationManager.MessageTypes mtp) : base()
        {

            this._Message  = msg;
            this.MessageType = mtp;
            this.EventTime = DateTime.Now;
        }

        public SerialCommunicationManagerMessageEventArgs(string msg, SerialCommunicationManager.MessageTypes mtp, SerialCommunicationManager.TransmissionTypes tt) : base()
        {

            this.Message = msg;
            this.MessageType = mtp;
            this.EventTime = DateTime.Now;
            this.TransmissionType = tt;
        }

        public DateTime EventTime { get; set; }

        private string _Message;
        public string Message
        {
            get
            {
                return this._Message;
            }
            set
            {
                this._Message = value;
            }
        }

        public readonly SerialCommunicationManager.MessageTypes MessageType;

        public readonly SerialCommunicationManager.TransmissionTypes TransmissionType;
    }

    public class SerialCommunicationManagerConnectionEventArgs : EventArgs
    {

        public SerialCommunicationManagerConnectionEventArgs()
        {
        }

        public SerialCommunicationManagerConnectionEventArgs(SerialCommunicationManager.ConnectionStates cst) : base()
        {

            this.ConnectionState = cst;
            this.EventTime = DateTime.Now;
        }

        public DateTime EventTime { get; set; }

        public SerialCommunicationManager.ConnectionStates ConnectionState { get; set; }
    }
}