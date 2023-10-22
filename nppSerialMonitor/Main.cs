using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Kbg.NppPluginNET.PluginInfrastructure;
using nppSerialMonitor.Storage;

namespace Kbg.NppPluginNET
{
    class Main
    {
        internal const string PluginName = "nppSerialMonitor";
        static SerialMonitorUI SerialMonitorUI = null;
        static About About = null;
        static Settings MySettings = null;

        public static void OnNotification(ScNotification notification)
        {  
            // This method is invoked whenever something is happening in notepad++
            // use eg. as
            // if (notification.Header.Code == (uint)NppMsg.NPPN_xxx)
            // { ... }
            // or
            //
            // if (notification.Header.Code == (uint)SciMsg.SCNxxx)
            // { ... }

        }

        internal static void CommandMenuInit()
        {
            PluginBase.SetCommand(0, "Show Serial Monitor", myDockableDialog );
            PluginBase.SetCommand(1, "&About", AboutnppSerialMonitor);
        }

        internal static void SetToolBarIcon()
        {

        }

        internal static void PluginCleanUp()
        {

        }


        internal static void myDockableDialog()
        {
            //MySettings = new Settings();
            //MySettings.Load();

            ToggleSerialMonitorUI();
        }
        /// <summary>
        /// Shows the "About" dialog window
        /// </summary>
        public static void AboutnppSerialMonitor()
        {
            About = new About();
            About.ShowDialog();
            About = null;

        }

        private static void ToggleSerialMonitorUI()
        {
            SerialMonitorUIVisible();
        }

        public static void SerialMonitorUIVisible(bool? show = null)
        {
            if (SerialMonitorUI == null)
            {
                SerialMonitorUI = new SerialMonitorUI();

                SerialMonitorUI.RefreshLists();

                var SerialMonitorUIData = new NppTbData
                {
                    hClient = SerialMonitorUI.Handle,
                    pszName = "Serial Monitor",
                    dlgID = 0,
                    uMask = NppTbMsg.DWS_DF_CONT_RIGHT,
                    hIconTab = 0,
                    pszModuleName = PluginName
                };
                var SerialMonitorUIPointer = Marshal.AllocHGlobal(Marshal.SizeOf(SerialMonitorUIData));
                Marshal.StructureToPtr(SerialMonitorUIData, SerialMonitorUIPointer, false);

                Win32.SendMessage(PluginBase.nppData._nppHandle, (uint)NppMsg.NPPM_DMMREGASDCKDLG, 0, SerialMonitorUIPointer);
            }
            else
            {
                if (show ?? !SerialMonitorUI.Visible)
                {
                    Win32.SendMessage(PluginBase.nppData._nppHandle, (uint)NppMsg.NPPM_DMMSHOW, 0, SerialMonitorUI.Handle);
                }
                else
                {
                    Win32.SendMessage(PluginBase.nppData._nppHandle, (uint)NppMsg.NPPM_DMMHIDE, 0, SerialMonitorUI.Handle);
                }
            }
        }

    }

}