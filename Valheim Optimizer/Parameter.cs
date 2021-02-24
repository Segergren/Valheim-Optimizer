using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Valheim_Optimizer
{
    class Parameter
    {

        public static void ApplyParameter()
        {
            string[] dirs = Directory.GetDirectories(Properties.Settings.Default.steamFolder, "*", SearchOption.TopDirectoryOnly);
            foreach (var user in dirs)
            {
                string localconfig_path = user + @"\config\localconfig.vdf";
                int counter = 0;
                string line;
                int valheimFound = -1;
                int valheimLaunchOptionsFound = -1;
                int valheimend = -1;

                // Read the file and display it line by line.  
                System.IO.StreamReader file =
                    new System.IO.StreamReader(localconfig_path);
                while ((line = file.ReadLine()) != null)
                {
                    counter++;
                    if (line.Replace("	", "").Replace("\"", "") == "892970")
                    {
                        valheimFound = counter;
                        Console.WriteLine(valheimFound);
                        int openingBrackets = 0;
                        int closingBrackets = 0;
                        while (true)
                        {
                            string lineInLoop = file.ReadLine();

                            if (lineInLoop.Contains("{"))
                                openingBrackets++;
                            if (lineInLoop.Contains("}"))
                                closingBrackets++;
                            if (openingBrackets == closingBrackets)
                            {
                                valheimend = counter;
                                break;
                            }
                            else
                            {
                                if (lineInLoop.Contains("LaunchOptions"))
                                {
                                    valheimLaunchOptionsFound = counter;
                                }
                            }
                            counter++;
                        }
                    }
                }
                file.Close();

                if (valheimFound != -1)
                {
                    List<string> lines = System.IO.File.ReadAllLines(localconfig_path).ToList<string>();
                    if (valheimLaunchOptionsFound != -1)
                    {
                        lines[valheimLaunchOptionsFound] = "\"LaunchOptions\"     \"-window-mode exclusive -screen-fullscreen\"";
                        System.IO.File.WriteAllLines(localconfig_path, lines);
                    }
                    else
                    {
                        Console.WriteLine(lines[valheimend]);
                        lines[valheimend] = "\"LaunchOptions\"     \"-window-mode exclusive -screen-fullscreen\" \n}";
                        System.IO.File.WriteAllLines(localconfig_path, lines);
                    }
                }
            }
        }

        public static void RemoveParameter()
        {

            string[] dirs = Directory.GetDirectories(Properties.Settings.Default.steamFolder, "*", SearchOption.TopDirectoryOnly);
            foreach (var user in dirs)
            {
                string localconfig_path = user + @"\config\localconfig.vdf";
                int counter = 0;
                string line;
                int valheimFound = -1;
                int valheimLaunchOptionsFound = -1;

                // Read the file and display it line by line.  
                System.IO.StreamReader file =
                    new System.IO.StreamReader(localconfig_path);
                while ((line = file.ReadLine()) != null)
                {
                    counter++;
                    if (line.Replace("	", "").Replace("\"", "") == "892970")
                    {
                        valheimFound = counter;
                        Console.WriteLine(valheimFound);
                        int openingBrackets = 0;
                        int closingBrackets = 0;
                        while (true)
                        {
                            string lineInLoop = file.ReadLine();

                            if (lineInLoop.Contains("{"))
                                openingBrackets++;
                            if (lineInLoop.Contains("}"))
                                closingBrackets++;
                            if (openingBrackets == closingBrackets)
                            {
                                break;
                            }
                            else
                            {
                                if (lineInLoop.Contains("LaunchOptions"))
                                {
                                    valheimLaunchOptionsFound = counter;
                                }
                            }
                            counter++;
                        }
                    }
                }
                file.Close();

                if (valheimFound != -1)
                {
                    List<string> lines = System.IO.File.ReadAllLines(localconfig_path).ToList<string>();
                    if (valheimLaunchOptionsFound != -1)
                    {
                        lines[valheimLaunchOptionsFound] = "";
                        System.IO.File.WriteAllLines(localconfig_path, lines);
                    }
                }
            }
        }
    }

}

