using Kbg.NppPluginNET.PluginInfrastructure;
using nppSerialMonitor.Modules;
using nppSerialMonitor.Storage;
using System;
using System.Reflection;
using System.Windows.Forms;

namespace Kbg.NppPluginNET
{
    public partial class SerialMonitorUI : Form
    {
        private IScintillaGateway Editor;
        private INotepadPPGateway Notepad;
        private SerialCommunicationManager Manager;

        public Settings settings { get; set; }
        private bool RefreshOrLoad = false;
        public SerialMonitorUI()
        {
            InitializeComponent();
            this.Editor = new ScintillaGateway(PluginBase.GetCurrentScintilla());
            this.Notepad = new NotepadPPGateway();
            this.Manager = new SerialCommunicationManager();

            this.Manager.UpdateMessage += Manager_UpdateMessage;
        }

        public void LoadSettings()
        {
            RefreshOrLoad = true;
            RefreshLists();
            RefreshOrLoad = false;
        }

        private void SaveSettings()
        {
            settings.Save();
        }

        private void Manager_UpdateMessage(object sender, SerialCommunicationManagerMessageEventArgs e)
        {
            this.Editor.AddText(e.Message.Length, e.Message);

            this.Editor.EnsureVisibleEnforcePolicy(this.Editor.GetLineCount() - 1);
        }

        public void RefreshLists()
        {
            RefreshOrLoad = true;
            this.ComboBoxPort.DataSource = this.Manager.GetPortNames();
            this.ComboBoxBaud.DataSource = this.Manager.GetBaudValues();
            this.ComboBoxDataBits.DataSource = this.Manager.GetDataBitValues();
            this.ComboBoxParity.DataSource = this.Manager.GetParityValues();
            this.ComboBoxStopBits.DataSource = this.Manager.GetStopBitValues();
            RefreshOrLoad = false;
        }

        private void ButtonOpen_Click(object sender, EventArgs e)
        {
            this.Notepad.FileNew();
            if (this.Manager.OpenPort())
            {
                this.ComboBoxPort.Enabled = false;
                this.ComboBoxBaud.Enabled = false;  
                this.ComboBoxDataBits.Enabled = false;  
                this.ComboBoxParity.Enabled = false;
                this.ComboBoxStopBits.Enabled = false;
            }
        }

        private void ComboBoxPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Manager.PortName = this.ComboBoxPort.Text;
            if (!RefreshOrLoad) this.SaveSettings();
        }

        private void ComboBoxBaud_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Manager.BaudRate = Convert.ToInt32(this.ComboBoxBaud.Text);
            if (!RefreshOrLoad) this.SaveSettings();
        }

        private void ComboBoxDataBits_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Manager.DataBits = Convert.ToInt32(this.ComboBoxDataBits.Text);
            if (!RefreshOrLoad) this.SaveSettings();
        }

        private void ComboBoxParity_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Manager.Parity = (System.IO.Ports.Parity)Enum.Parse(typeof(System.IO.Ports.Parity), this.ComboBoxParity.Text);
            if (!RefreshOrLoad) this.SaveSettings();
        }

        private void ComboBoxStopBits_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Manager.StopBits = (System.IO.Ports.StopBits)Enum.Parse(typeof(System.IO.Ports.StopBits), this.ComboBoxStopBits.Text);
            if (!RefreshOrLoad) this.SaveSettings();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.Manager.IsOpen) this.Manager.ClosePort();

            this.ComboBoxPort.Enabled = true;
            this.ComboBoxBaud.Enabled = true;
            this.ComboBoxDataBits.Enabled = true;
            this.ComboBoxParity.Enabled = true;
            this.ComboBoxStopBits.Enabled = true;

        }

        private void TriggerCheckBoxChangeEvent(System.Windows.Forms.CheckBox check)
        {
            // Find the event handler delegate for CheckedChanged event using reflection
            EventInfo checkedChangedEvent = check.GetType().GetEvent("CheckedChanged", BindingFlags.Instance | BindingFlags.NonPublic);
            if (checkedChangedEvent != null)
            {
                Delegate eventHandler = (Delegate)check.GetType().GetField("EventClick", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(check);

                // Invoke the event handler delegate
                if (eventHandler != null)
                {
                    foreach (Delegate handler in eventHandler.GetInvocationList())
                    {
                        handler.Method.Invoke(handler.Target, new object[] { check, EventArgs.Empty });
                    }
                }
            }
        }
    }
}
