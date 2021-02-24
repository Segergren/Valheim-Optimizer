using System.Collections.Generic;
using System.IO;

namespace Valheim_Optimizer
{
    class GFX
    {
        public static void ApplyGFX()
        {
            string boot_path = Properties.Settings.Default.steamFolder.Replace("userdata", "") + @"steamapps\common\Valheim\valheim_Data\boot.config";
            List<string> graphicsSettingsList = new List<string>();

            string line;
            System.IO.StreamReader file =
                    new System.IO.StreamReader(boot_path);
            while ((line = file.ReadLine()) != null)
            {
                graphicsSettingsList.Add(line);
            }
            file.Close();

            StreamWriter sw = new StreamWriter(boot_path, true);
            if (!graphicsSettingsList.Contains("gfx-enable-gfx-jobs=1"))
            {
                sw.WriteLine("gfx-enable-gfx-jobs=1");
            }
            sw.Close();
        }

        public static void RemoveGFX()
        {
            string boot_path = Properties.Settings.Default.steamFolder.Replace("userdata", "") + @"steamapps\common\Valheim\valheim_Data\boot.config";
            List<string> graphicsSettingsList = new List<string>();

            string line;
            System.IO.StreamReader file =
                    new System.IO.StreamReader(boot_path);
            while ((line = file.ReadLine()) != null)
            {
                graphicsSettingsList.Add(line);
            }
            file.Close();

            StreamWriter sw = new StreamWriter(boot_path);
            foreach (string setting in graphicsSettingsList)
            {
                if (setting != "gfx-enable-gfx-jobs=1")
                {
                    sw.WriteLine(setting);
                }
            }
            sw.Close();
        }

        public static void ApplyNativeGFX()
        {
            string boot_path = Properties.Settings.Default.steamFolder.Replace("userdata", "") + @"steamapps\common\Valheim\valheim_Data\boot.config";
            List<string> graphicsSettingsList = new List<string>();

            string line;
            System.IO.StreamReader file =
                    new System.IO.StreamReader(boot_path);
            while ((line = file.ReadLine()) != null)
            {
                graphicsSettingsList.Add(line);
            }
            file.Close();

            StreamWriter sw = new StreamWriter(boot_path, true);
            if (!graphicsSettingsList.Contains("gfx-enable-native-gfx-jobs=1"))
            {
                sw.WriteLine("gfx-enable-native-gfx-jobs=1");
            }
            sw.Close();
        }

        public static void RemoveNativeGFX()
        {
            string boot_path = Properties.Settings.Default.steamFolder.Replace("userdata", "") + @"steamapps\common\Valheim\valheim_Data\boot.config";
            List<string> graphicsSettingsList = new List<string>();

            string line;
            System.IO.StreamReader file =
                    new System.IO.StreamReader(boot_path);
            while ((line = file.ReadLine()) != null)
            {
                graphicsSettingsList.Add(line);
            }
            file.Close();

            StreamWriter sw = new StreamWriter(boot_path);
            foreach (string setting in graphicsSettingsList)
            {
                if (setting != "gfx-enable-native-gfx-jobs=1")
                {
                    sw.WriteLine(setting);
                }
            }
            sw.Close();
        }


    }
}
