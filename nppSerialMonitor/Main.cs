using System.Drawing;
using System.Windows.Forms;
using Kbg.NppPluginNET.PluginInfrastructure;
using nppSerialMonitor.Storage;

namespace Kbg.NppPluginNET
{
    class Main
    {
        internal const string PluginName = "nppSerialMonitor";
        static ConfigAndGenerate ConfigAndGenerate = null;
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
            MySettings = new Settings();
            MySettings.Load();

            ConfigAndGenerate = new ConfigAndGenerate();
            ConfigAndGenerate.settings = MySettings;
            ConfigAndGenerate.LoadSettings();
            ConfigAndGenerate.ShowDialog();

            ConfigAndGenerate = null;
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

    }

}