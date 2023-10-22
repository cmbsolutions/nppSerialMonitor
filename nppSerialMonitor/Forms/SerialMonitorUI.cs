using Kbg.NppPluginNET.PluginInfrastructure;
using nppSerialMonitor.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kbg.NppPluginNET
{
    public partial class SerialMonitorUI : Form
    {
        private IScintillaGateway Editor;
        private INotepadPPGateway Notepad;
        private SerialCommunicationManager Manager;

        public SerialMonitorUI()
        {
            InitializeComponent();
            this.Editor = new ScintillaGateway(PluginBase.GetCurrentScintilla());
            this.Notepad = new NotepadPPGateway();
            this.Manager = new SerialCommunicationManager();

            this.Manager.UpdateMessage += Manager_UpdateMessage;
        }

        private void Manager_UpdateMessage(object sender, SerialCommunicationManagerMessageEventArgs e)
        {
            this.Editor.AddText(e.Message.Length, e.Message);
        }

        public void RefreshLists()
        {
            this.ComboBoxPort.DataSource = this.Manager.GetPortNames();
            this.ComboBoxBaud.DataSource = this.Manager.GetBaudValues();
            this.ComboBoxDataBits.DataSource = this.Manager.GetDataBitValues();
            this.ComboBoxParity.DataSource = this.Manager.GetParityValues();
            this.ComboBoxStopBits.DataSource = this.Manager.GetStopBitValues();
        }

        private void ButtonOpen_Click(object sender, EventArgs e)
        {
            this.Notepad.FileNew();
            this.Manager.OpenPort();
        }
    }
}
