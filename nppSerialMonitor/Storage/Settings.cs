using nppSerialMonitor.Properties;
using System;
using System.IO;
using System.Windows.Forms;
using nppSerialMonitor.Storage.Models;

namespace nppSerialMonitor.Storage
{
    public class Settings
    {
        public SettingsModel settings { get; set; }

        private string FilePath { get; set; }

        public void Load(bool reset = false)
        {
            string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string savePath = Path.Combine(appDataPath, "CMBSolutions", "nppSerialMonitor");
            FilePath = Path.Combine(savePath, "nppSerialMonitor.json");

            if (!File.Exists(FilePath) || reset)
            {
                try
                {
                    if (!Directory.Exists(savePath))
                    {
                        Directory.CreateDirectory(savePath);
                    }
                    using (StreamWriter writer = new StreamWriter(FilePath))
                    {
                        writer.WriteLine(Resources.nppSerialMonitorSettings);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error creating settingsfile");
                    return;
                }
            }

            try
            {
                settings = DeserializeJSonFile(FilePath);


                if (settings.appversion != "0.0.1")
                {
                    SettingsModel defaults = DeserializeJSonFromString(Resources.nppSerialMonitorSettings);

                    settings.appname = "nppSerialMonitor";
                    settings.appversion = "0.0.1";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private SettingsModel DeserializeJSonFile(string jsonfile)
        {
            SettingsModel tmp = Newtonsoft.Json.JsonConvert.DeserializeObject<SettingsModel>(File.ReadAllText(jsonfile));
            return tmp;
        }

        private SettingsModel DeserializeJSonFromString(string json)
        {
            SettingsModel tmp = Newtonsoft.Json.JsonConvert.DeserializeObject<SettingsModel>(json);
            return tmp;
        }

        // Save JSON string to a file
        public void Save()
        {
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(settings, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(FilePath, json);                       
        }
    }
}
