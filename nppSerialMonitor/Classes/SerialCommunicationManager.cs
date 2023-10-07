using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace nppSerialMonitor.Classes
{
    internal class SerialCommunicationManager
    {
        public event UpdateMessageEventHandler UpdateMessage;

        public delegate void UpdateMessageEventHandler(object sender, SerialCommunicationManagerMessageEventArgs e);
        public event ConnectionStateChangedEventHandler ConnectionStateChanged;

        public delegate void ConnectionStateChangedEventHandler(object sender, SerialCommunicationManagerConnectionEventArgs e);

        private SerialPort CommPort { get; set; }
        private int BaudRate { get; set; }
        private int Parity { get; set; }
        private int DataBits { get; set; }
        private StopBits StopBits { get; set; }

    private string PortName { get; set; }

    private TransmissionTypes _txType;
    public TransmissionTypes TxTransmissionType
    {
        get
        {
            return _txType;
        }
        set
        {
            _txType = value;
        }
    }

    private TransmissionTypes _rxType;
    public TransmissionTypes RxTransmissionType
    {
        get
        {
            return _rxType;
        }
        set
        {
            _rxType = value;
        }
    }

    private string _msg;
    public string Message
    {
        get
        {
            return _msg;
        }
        set
        {
            _msg = value;
        }
    }

    private MessageTypes _type;
    public MessageTypes Type
    {
        get
        {
            return _type;
        }
        set
        {
            _type = value;
        }
    }

    private NewLineTypes _serialNewline;
    public NewLineTypes Newline
    {
        get
        {
            return _serialNewline;
        }
        set
        {
            _serialNewline = value;
        }
    }

    public string NewlineString
    {
        get
        {
            switch (_serialNewline)
            {
                case NewLineTypes.Cr:
                    {
                        return Conversions.ToString('\r');
                    }
                case NewLineTypes.Lf:
                    {
                        return Conversions.ToString('\n');
                    }

                default:
                    {
                        return Conversions.ToString('\r') + '\n';
                    }
            }
        }
    }

    public bool IsOpen
    {
        get
        {
            if (_comPort is null)
                return false;
            return _comPort.IsOpen;
        }
    }

    public SerialCommunicationManager(int prmBaud, Parity prmParity, StopBits prmStopBits, int prmDataBits, string prmPortName, NewLineTypes prmNewLine)
    {
        try
        {
            _baudRate = prmBaud;
            _parity = prmParity;
            _stopBits = prmStopBits;
            _dataBits = prmDataBits;
            _portName = prmPortName;
            _serialNewline = prmNewLine;
            _comPort = new SerialPort();
            this._comPort.DataReceived += comPort_DataReceived;
            ConnectionStateChanged?.Invoke(this, new SerialCommunicationManagerConnectionEventArgs(ConnectionStates.Closed));
        }
        catch (Exception ex)
        {
            ExceptionMessageBox.ShowDetailedException(ex);
        }
    }

    public SerialCommunicationManager()
    {
        try
        {
            _baudRate = 9600;
            _parity = System.IO.Ports.Parity.None;
            _stopBits = System.IO.Ports.StopBits.One;
            _dataBits = 8;
            _serialNewline = NewLineTypes.Lf;

            if (SerialPort.GetPortNames().Count > 0)
                _portName = SerialPort.GetPortNames()(0);
            _comPort = new SerialPort();

            this._comPort.DataReceived += comPort_DataReceived;
            ConnectionStateChanged?.Invoke(this, new SerialCommunicationManagerConnectionEventArgs(ConnectionStates.Closed));
        }
        catch (Exception ex)
        {
            ExceptionMessageBox.ShowDetailedException(ex);
        }
    }

    public void WriteData(string msg)
    {
        try
        {
            if (!(_comPort.IsOpen == true))
            {
                _comPort.Open();
                ConnectionStateChanged?.Invoke(this, new SerialCommunicationManagerConnectionEventArgs(ConnectionStates.Open));
            }
            switch (TxTransmissionType)
            {
                case TransmissionTypes.Text:
                    {
                        _comPort.WriteLine(msg);
                        _type = MessageTypes.Outgoing;
                        _msg = msg;
                        break;
                    }
                case TransmissionTypes.Hex:
                    {
                        try
                        {
                            byte[] newMsg = HexToByte(msg);
                            _comPort.Write(newMsg, 0, newMsg.Length);
                            _type = MessageTypes.Outgoing;
                            _msg = ByteToHex(newMsg);
                        }
                        catch (FormatException ex)
                        {
                            _type = MessageTypes.Error;
                            _msg = ex.Message;
                        }

                        break;
                    }

                default:
                    {
                        _comPort.Write(msg);
                        _type = MessageTypes.Outgoing;
                        _msg = msg;
                        break;
                    }
            }

            UpdateMessage?.Invoke(this, new SerialCommunicationManagerMessageEventArgs(_msg, _type));
        }
        catch (Exception ex)
        {
            ExceptionMessageBox.ShowDetailedException(ex);
        }
    }

    public void WriteBytes(byte[] msg)
    {
        try
        {
            if (!_comPort.IsOpen)
            {
                _comPort.Open();
                ConnectionStateChanged?.Invoke(this, new SerialCommunicationManagerConnectionEventArgs(ConnectionStates.Open));
            }

            _comPort.Write(msg, 0, msg.Length);
            _type = MessageTypes.Outgoing;
            _msg = ByteToHex(msg);

            UpdateMessage?.Invoke(this, new SerialCommunicationManagerMessageEventArgs(_msg, _type, TransmissionTypes.Hex));
        }
        catch (FormatException ex)
        {
            ExceptionMessageBox.ShowDetailedException(ex);
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
                _msg = msg;
                _msg = msg.Replace(" ", "");
                byte[] comBuffer = new byte[((int)Math.Round(_msg.Length / 2d))];
                for (int i = 0, loopTo = _msg.Length - 1; i <= loopTo; i += 2)
                    comBuffer[(int)Math.Round(i / 2d)] = Convert.ToByte(_msg.Substring(i, 2), 16);
                return comBuffer;
            }
            else
            {
                _msg = "Invalid format";
                _type = MessageTypes.Error;
                return null;
            }
        }
        catch (Exception ex)
        {
            ExceptionMessageBox.ShowDetailedException(ex);
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
            ExceptionMessageBox.ShowDetailedException(ex);
        }
        return null;
    }

    private string StrToHex(string data)
    {
        return data.Aggregate("", (current, c) => current + Conversion.Hex(Strings.Asc(c)));
    }

    public bool OpenPort()
    {
        try
        {
            if (_comPort.IsOpen == true)
            {
                _comPort.Close();
                ConnectionStateChanged?.Invoke(this, new SerialCommunicationManagerConnectionEventArgs(ConnectionStates.Closed));
            }
            _comPort.BaudRate = _baudRate;
            _comPort.DataBits = _dataBits;
            _comPort.StopBits = _stopBits;
            _comPort.Parity = _parity;
            _comPort.PortName = _portName;
            _comPort.Encoding = Encoding.UTF8;
            _comPort.NewLine = NewlineString;

            _comPort.WriteTimeout = 500;
            _comPort.ReadTimeout = 500;

            _comPort.Open();
            ConnectionStateChanged?.Invoke(this, new SerialCommunicationManagerConnectionEventArgs(ConnectionStates.Open));
            _comPort.DiscardOutBuffer();
            _comPort.DiscardInBuffer();

            _type = MessageTypes.Status;
            _msg = string.Format("Port opened at {0}", DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss.f"));

            UpdateMessage?.Invoke(this, new SerialCommunicationManagerMessageEventArgs(_msg, _type));
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
        if (_comPort.IsOpen)
        {
            _msg = string.Format("Port closed at {0}", DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss.f"));
            _type = MessageTypes.Status;
            _comPort.Close();
            UpdateMessage?.Invoke(this, new SerialCommunicationManagerMessageEventArgs(_msg, _type));
            ConnectionStateChanged?.Invoke(this, new SerialCommunicationManagerConnectionEventArgs(ConnectionStates.Closed));
        }
        else
        {
            _msg = string.Format("Port already closed");
            _type = MessageTypes.Warning;
            UpdateMessage?.Invoke(this, new SerialCommunicationManagerMessageEventArgs(_msg, _type));
            ConnectionStateChanged?.Invoke(this, new SerialCommunicationManagerConnectionEventArgs(ConnectionStates.Closed));
        }
    }

    public void GetTransmissionValues(ref ComboBox obj)
    {
        obj.Items.Clear();
        foreach (string str in Enum.GetNames(typeof(TransmissionTypes)))
            obj.Items.Add(str);
    }

    public void GetNewLineValues(ref ComboBox obj)
    {
        obj.Items.Clear();
        foreach (string str in Enum.GetNames(typeof(NewLineTypes)))
            obj.Items.Add(str);
    }

    public void GetParityValues(ref ComboBox obj)
    {
        obj.Items.Clear();
        foreach (string str in Enum.GetNames(typeof(Parity)))
            obj.Items.Add(str);
    }

    public void GetStopBitValues(ref ComboBox obj)
    {
        obj.Items.Clear();
        foreach (string str in Enum.GetNames(typeof(StopBits)))
            obj.Items.Add(str);
    }

    public void GetDataBitValues(ref ComboBox obj)
    {
        obj.Items.Clear();
        obj.Items.AddRange(new[] { "7", "8", "9" });
    }

    public void GetPortNames(ref ComboBox obj)
    {
        obj.Items.Clear();
        foreach (string str in SerialPort.GetPortNames())
            obj.Items.Add(str);
    }

    private void comPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
    {
        try
        {
            switch (RxTransmissionType)
            {
                case TransmissionTypes.Text:
                    {
                        string msg = _comPort.ReadExisting;
                        _type = MessageTypes.Incoming;
                        _msg = msg;
                        break;
                    }
                case TransmissionTypes.Hex:
                    {
                        int bytes = _comPort.BytesToRead;
                        byte[] comBuffer = new byte[bytes];
                        _comPort.Read(comBuffer, 0, bytes);
                        _type = MessageTypes.Incoming;
                        _msg = ByteToHex(comBuffer);
                        break;
                    }

                default:
                    {
                        string str = _comPort.ReadExisting();
                        _type = MessageTypes.Incoming;
                        _msg = str;
                        break;
                    }
            }

            UpdateMessage?.Invoke(this, new SerialCommunicationManagerMessageEventArgs(_msg, _type));
        }
        catch (Exception ex)
        {
            ExceptionMessageBox.ShowDetailedException(ex);
        }
    }

    public enum TransmissionTypes
    {
        Text,
        Hex
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
        Cr,
        Lf,
        CrLf
    }

    public enum ConnectionStates
    {
        Open,
        Closed,
        Error
    }
}

public partial class SerialCommunicationManagerMessageEventArgs : EventArgs
{

    public SerialCommunicationManagerMessageEventArgs()
    {
    }

    public SerialCommunicationManagerMessageEventArgs(string msg, SerialCommunicationManager.MessageTypes mtp) : base()
    {

        _message = msg;
        _type = mtp;
        _eventTime = DateTime.Now;
    }

    public SerialCommunicationManagerMessageEventArgs(string msg, SerialCommunicationManager.MessageTypes mtp, SerialCommunicationManager.TransmissionTypes tt) : base()
    {

        _message = msg;
        _type = mtp;
        _eventTime = DateTime.Now;
        _tt = tt;
    }

    private readonly DateTime _eventTime;
    public DateTime EventTime
    {
        get
        {
            return _eventTime;
        }
    }

    private readonly string _message;
    public string Message
    {
        get
        {
            string result = Regex.Replace(_message, @"[\r\n]+?", "", RegexOptions.IgnoreCase);
            if (_tt == SerialCommunicationManager.TransmissionTypes.Hex)
            {
                return result;
            }
            else
            {
                return result + Environment.NewLine;
            }
        }
    }

    private readonly SerialCommunicationManager.MessageTypes _type;
    public SerialCommunicationManager.MessageTypes MessageType
    {
        get
        {
            return _type;
        }
    }

    private readonly SerialCommunicationManager.TransmissionTypes _tt;
    public SerialCommunicationManager.TransmissionTypes TransmissionType
    {
        get
        {
            return _tt;
        }
    }

}

public partial class SerialCommunicationManagerConnectionEventArgs : EventArgs
{

    public SerialCommunicationManagerConnectionEventArgs()
    {
    }

    public SerialCommunicationManagerConnectionEventArgs(SerialCommunicationManager.ConnectionStates cst) : base()
    {

        _state = cst;
        _eventTime = DateTime.Now;
    }

    private DateTime _eventTime;
    public DateTime EventTime
    {
        get
        {
            return _eventTime;
        }
        set
        {
            _eventTime = value;
        }
    }

    private SerialCommunicationManager.ConnectionStates _state;
    public SerialCommunicationManager.ConnectionStates State
    {
        get
        {
            return _state;
        }
        set
        {
            _state = value;
        }
    }
}