using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Windows.Forms;

namespace Valheim_Optimizer
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        //Move form
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        //End move form
        private void Main_Load(object sender, EventArgs e)
        {
            string[] args = Environment.GetCommandLineArgs();
            if (args.Contains("reset"))
            {
                resetSettings();
            }

            if (!Directory.Exists(@"C:\Program Files (x86)\Steam\userdata") && Properties.Settings.Default.steamFolder.Length == 0)
            {
                while (true)
                {
                    string steamFolder = Microsoft.VisualBasic.Interaction.InputBox("Could not find the Steam folder.\nPlease enter it. It should look like: \n\nX:/Program Files (x86)/Steam/userdata", "Could not find Steam", "", 0, 0);
                    if (steamFolder.Split('\\').Last().Contains("userdata"))
                    {
                        Properties.Settings.Default.steamFolder = steamFolder;
                        Properties.Settings.Default.Save();
                    }
                    else
                    {
                        MessageBox.Show(null,"Wrong folder. Please re-enter the correct folder. It should end with 'userdata'","Wrong folder", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }
            }
            if (Properties.Settings.Default.steamFolder.Length == 0)
            {
                Properties.Settings.Default.steamFolder = @"C:\Program Files (x86)\Steam\userdata";
                Properties.Settings.Default.Save();
            }

            priority_cb.Checked = Properties.Settings.Default.priority;
            parameter_cb.Checked = Properties.Settings.Default.parameter;
            gfx_cb.Checked = Properties.Settings.Default.gfx;
            gfx_native_cb.Checked = Properties.Settings.Default.gfxnative;

            
            if (args.Contains("-startup"))
            {
                fullyHide();
            }
            if (args.Contains("prioritychecked"))
            {
                priority_cb.Checked = true;
            }
            if (Properties.Settings.Default.priority)
            {
                valheim_priority_checker.Start();
            }
            setToolTip();
        }

        private void fullyHide()
        {
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
            hiddenIcon.Icon = this.Icon;
            hiddenIcon.Visible = true;

        }

        private void fullyShow()
        {
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            hiddenIcon.Icon = this.Icon;
            hiddenIcon.Visible = false;
        }
        private void hiddenIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            fullyShow();
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            fullyHide();
        }

        private void hidebtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Draw white outerline
        private void Main_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.White, 1);
            Rectangle rect = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            e.Graphics.DrawRectangle(pen, rect);
        }

        private void setToolTip()
        {
            ToolTip helpTip = new ToolTip();

            helpTip.AutoPopDelay = 5000;
            helpTip.InitialDelay = 200;
            helpTip.ReshowDelay = 500;
            helpTip.ShowAlways = true;

            helpTip.SetToolTip(this.info_priority, "Sets Valheim to High Priority in Task Manager\nGives around 10% FPS increase.\nNeeds Administrator rights.");
            helpTip.SetToolTip(this.info_launch_parameter, "Sets -window-mode exclusive to the Steam Launch Parameter.\nGives around 10% FPS increase.");
            helpTip.SetToolTip(this.info_gfx, "Will boost performance by more efficiently using CPU threads.\nGives around 5% FPS increase.");
            helpTip.SetToolTip(this.info_gfx_native, "Will boost performance by more efficiently using CPU threads.\nGives around 20% FPS increase.");
        }

        private void Main_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void titlelbl_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void optimizebtn_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.priority = priority_cb.Checked;
            Properties.Settings.Default.parameter = parameter_cb.Checked;
            Properties.Settings.Default.gfx = gfx_cb.Checked;
            Properties.Settings.Default.gfxnative = gfx_native_cb.Checked;
            Properties.Settings.Default.Save();

            if (priority_cb.Checked)
            {
                Scheduler.Add_scheduler();
            }
            else
            {
                Scheduler.Remove_scheduler();
            }
            if (parameter_cb.Checked)
            {
                Parameter.ApplyParameter();
            }
            if (gfx_cb.Checked)
            {
                GFX.ApplyGFX();
            }
            if (gfx_native_cb.Checked)
            {
                GFX.ApplyNativeGFX();
            }

            MessageBox.Show(null, "You have successfully optimized Valheim.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void valheim_priority_checker_Tick(object sender, EventArgs e)
        {
            try
            {
                Process[] valheim = Process.GetProcessesByName("valheim");
                if (valheim != null)
                {
                    if (valheim.First().PriorityClass != ProcessPriorityClass.High)
                    {
                        valheim.First().PriorityClass = ProcessPriorityClass.High;
                    }
                }
            }
            catch {}
        }

        public static bool IsAdministrator()
        {
            return (new WindowsPrincipal(WindowsIdentity.GetCurrent()))
                      .IsInRole(WindowsBuiltInRole.Administrator);
        }

        private void resetlbl_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(null, "Are you sure you want to reset?", "Reset", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                resetSettings();
            }
        }

        private void resetSettings()
        {
            if (!IsAdministrator())
            {
                DialogResult dialogResult = MessageBox.Show(null, "You will need to restart this program as Administrator to reset.\nWould you like to do that now?", "Run as Administrator", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    var exeName = Process.GetCurrentProcess().MainModule.FileName;
                    ProcessStartInfo startInfo = new ProcessStartInfo(exeName);
                    startInfo.Verb = "runas";
                    startInfo.Arguments = "reset";
                    Process.Start(startInfo);
                    Application.Exit();
                }
            }
            else
            {
                Parameter.RemoveParameter();
                GFX.RemoveGFX();
                GFX.RemoveNativeGFX();
                Scheduler.Remove_scheduler();
                Properties.Settings.Default.priority = false;
                Properties.Settings.Default.parameter = false;
                Properties.Settings.Default.gfx = false;
                Properties.Settings.Default.gfxnative = false;
                Properties.Settings.Default.Save();
                parameter_cb.Checked = false;
                gfx_cb.Checked = false;
                gfx_native_cb.Checked = false;
                priority_cb.Checked = false;
                MessageBox.Show(null,"You have successfully reset your optimized settings","Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void priority_cb_Click(object sender, EventArgs e)
        {
            if (priority_cb.Checked && !IsAdministrator())
            {
                DialogResult dialogResult = MessageBox.Show(null, "You will need to restart this program as Administrator to enable this feature.\nWould you like to do that now?", "Run as Administrator", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    var exeName = Process.GetCurrentProcess().MainModule.FileName;
                    ProcessStartInfo startInfo = new ProcessStartInfo(exeName);
                    startInfo.Verb = "runas";
                    startInfo.Arguments = "prioritychecked";
                    Process.Start(startInfo);
                    Application.Exit();
                }
                else if (dialogResult == DialogResult.No)
                {
                    priority_cb.Checked = false;
                }
            }
        }
    }
}
