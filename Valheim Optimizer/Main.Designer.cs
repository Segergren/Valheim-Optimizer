
namespace Valheim_Optimizer
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.closebtn = new System.Windows.Forms.PictureBox();
            this.hidebtn = new System.Windows.Forms.PictureBox();
            this.titlelbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.optimizebtn = new System.Windows.Forms.Button();
            this.gfx_native_cb = new System.Windows.Forms.CheckBox();
            this.gfx_cb = new System.Windows.Forms.CheckBox();
            this.info_gfx_native = new System.Windows.Forms.PictureBox();
            this.info_gfx = new System.Windows.Forms.PictureBox();
            this.information_box = new System.Windows.Forms.Label();
            this.info_launch_parameter = new System.Windows.Forms.PictureBox();
            this.parameter_cb = new System.Windows.Forms.CheckBox();
            this.info_priority = new System.Windows.Forms.PictureBox();
            this.priority_cb = new System.Windows.Forms.CheckBox();
            this.hiddenIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.valheim_priority_checker = new System.Windows.Forms.Timer(this.components);
            this.resetlbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.closebtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hidebtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.info_gfx_native)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.info_gfx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.info_launch_parameter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.info_priority)).BeginInit();
            this.SuspendLayout();
            // 
            // closebtn
            // 
            this.closebtn.BackColor = System.Drawing.Color.Transparent;
            this.closebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closebtn.Image = ((System.Drawing.Image)(resources.GetObject("closebtn.Image")));
            this.closebtn.Location = new System.Drawing.Point(755, 12);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(33, 32);
            this.closebtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closebtn.TabIndex = 0;
            this.closebtn.TabStop = false;
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // hidebtn
            // 
            this.hidebtn.BackColor = System.Drawing.Color.Transparent;
            this.hidebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hidebtn.Image = ((System.Drawing.Image)(resources.GetObject("hidebtn.Image")));
            this.hidebtn.Location = new System.Drawing.Point(716, 12);
            this.hidebtn.Name = "hidebtn";
            this.hidebtn.Size = new System.Drawing.Size(33, 32);
            this.hidebtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hidebtn.TabIndex = 1;
            this.hidebtn.TabStop = false;
            this.hidebtn.Click += new System.EventHandler(this.hidebtn_Click);
            // 
            // titlelbl
            // 
            this.titlelbl.BackColor = System.Drawing.Color.Transparent;
            this.titlelbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.titlelbl.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlelbl.ForeColor = System.Drawing.Color.White;
            this.titlelbl.Location = new System.Drawing.Point(119, 9);
            this.titlelbl.Name = "titlelbl";
            this.titlelbl.Size = new System.Drawing.Size(563, 38);
            this.titlelbl.TabIndex = 2;
            this.titlelbl.Text = "Valheim Optimizer";
            this.titlelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.titlelbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titlelbl_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 1);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // optimizebtn
            // 
            this.optimizebtn.BackColor = System.Drawing.Color.Transparent;
            this.optimizebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.optimizebtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.optimizebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.optimizebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.optimizebtn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optimizebtn.ForeColor = System.Drawing.Color.White;
            this.optimizebtn.Location = new System.Drawing.Point(306, 357);
            this.optimizebtn.Name = "optimizebtn";
            this.optimizebtn.Size = new System.Drawing.Size(188, 39);
            this.optimizebtn.TabIndex = 4;
            this.optimizebtn.Text = "Optimize";
            this.optimizebtn.UseVisualStyleBackColor = false;
            this.optimizebtn.Click += new System.EventHandler(this.optimizebtn_Click);
            // 
            // gfx_native_cb
            // 
            this.gfx_native_cb.BackColor = System.Drawing.Color.Transparent;
            this.gfx_native_cb.ForeColor = System.Drawing.Color.White;
            this.gfx_native_cb.Location = new System.Drawing.Point(336, 327);
            this.gfx_native_cb.Name = "gfx_native_cb";
            this.gfx_native_cb.Size = new System.Drawing.Size(158, 24);
            this.gfx_native_cb.TabIndex = 5;
            this.gfx_native_cb.Text = "gfx-enable-native-gfx-jobs=1";
            this.gfx_native_cb.UseVisualStyleBackColor = false;
            // 
            // gfx_cb
            // 
            this.gfx_cb.BackColor = System.Drawing.Color.Transparent;
            this.gfx_cb.ForeColor = System.Drawing.Color.White;
            this.gfx_cb.Location = new System.Drawing.Point(336, 297);
            this.gfx_cb.Name = "gfx_cb";
            this.gfx_cb.Size = new System.Drawing.Size(158, 24);
            this.gfx_cb.TabIndex = 6;
            this.gfx_cb.Text = "gfx-enable-gfx-jobs=1";
            this.gfx_cb.UseVisualStyleBackColor = false;
            // 
            // info_gfx_native
            // 
            this.info_gfx_native.BackColor = System.Drawing.Color.Transparent;
            this.info_gfx_native.Cursor = System.Windows.Forms.Cursors.Hand;
            this.info_gfx_native.Image = ((System.Drawing.Image)(resources.GetObject("info_gfx_native.Image")));
            this.info_gfx_native.Location = new System.Drawing.Point(306, 327);
            this.info_gfx_native.Name = "info_gfx_native";
            this.info_gfx_native.Size = new System.Drawing.Size(24, 24);
            this.info_gfx_native.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.info_gfx_native.TabIndex = 7;
            this.info_gfx_native.TabStop = false;
            // 
            // info_gfx
            // 
            this.info_gfx.BackColor = System.Drawing.Color.Transparent;
            this.info_gfx.Cursor = System.Windows.Forms.Cursors.Hand;
            this.info_gfx.Image = ((System.Drawing.Image)(resources.GetObject("info_gfx.Image")));
            this.info_gfx.Location = new System.Drawing.Point(306, 297);
            this.info_gfx.Name = "info_gfx";
            this.info_gfx.Size = new System.Drawing.Size(24, 24);
            this.info_gfx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.info_gfx.TabIndex = 8;
            this.info_gfx.TabStop = false;
            // 
            // information_box
            // 
            this.information_box.BackColor = System.Drawing.Color.Transparent;
            this.information_box.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.information_box.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.information_box.ForeColor = System.Drawing.Color.White;
            this.information_box.Location = new System.Drawing.Point(106, 69);
            this.information_box.Name = "information_box";
            this.information_box.Size = new System.Drawing.Size(589, 165);
            this.information_box.TabIndex = 9;
            this.information_box.Text = "Some players struggle to maintain playable frame rates while taking on bosses or " +
    "moving through dense forest areas. \r\nThis software is a simple solution to this " +
    "and will increase FPS.";
            this.information_box.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // info_launch_parameter
            // 
            this.info_launch_parameter.BackColor = System.Drawing.Color.Transparent;
            this.info_launch_parameter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.info_launch_parameter.Image = ((System.Drawing.Image)(resources.GetObject("info_launch_parameter.Image")));
            this.info_launch_parameter.Location = new System.Drawing.Point(306, 267);
            this.info_launch_parameter.Name = "info_launch_parameter";
            this.info_launch_parameter.Size = new System.Drawing.Size(24, 24);
            this.info_launch_parameter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.info_launch_parameter.TabIndex = 11;
            this.info_launch_parameter.TabStop = false;
            // 
            // parameter_cb
            // 
            this.parameter_cb.BackColor = System.Drawing.Color.Transparent;
            this.parameter_cb.ForeColor = System.Drawing.Color.White;
            this.parameter_cb.Location = new System.Drawing.Point(336, 267);
            this.parameter_cb.Name = "parameter_cb";
            this.parameter_cb.Size = new System.Drawing.Size(158, 24);
            this.parameter_cb.TabIndex = 10;
            this.parameter_cb.Text = "-window-mode exclusive";
            this.parameter_cb.UseVisualStyleBackColor = false;
            // 
            // info_priority
            // 
            this.info_priority.BackColor = System.Drawing.Color.Transparent;
            this.info_priority.Cursor = System.Windows.Forms.Cursors.Hand;
            this.info_priority.Image = ((System.Drawing.Image)(resources.GetObject("info_priority.Image")));
            this.info_priority.Location = new System.Drawing.Point(306, 237);
            this.info_priority.Name = "info_priority";
            this.info_priority.Size = new System.Drawing.Size(24, 24);
            this.info_priority.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.info_priority.TabIndex = 13;
            this.info_priority.TabStop = false;
            // 
            // priority_cb
            // 
            this.priority_cb.BackColor = System.Drawing.Color.Transparent;
            this.priority_cb.ForeColor = System.Drawing.Color.White;
            this.priority_cb.Location = new System.Drawing.Point(336, 237);
            this.priority_cb.Name = "priority_cb";
            this.priority_cb.Size = new System.Drawing.Size(158, 24);
            this.priority_cb.TabIndex = 12;
            this.priority_cb.Text = "High Priority";
            this.priority_cb.UseVisualStyleBackColor = false;
            this.priority_cb.Click += new System.EventHandler(this.priority_cb_Click);
            // 
            // hiddenIcon
            // 
            this.hiddenIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("hiddenIcon.Icon")));
            this.hiddenIcon.Text = "Valheim Optimizer";
            this.hiddenIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.hiddenIcon_MouseDoubleClick);
            // 
            // valheim_priority_checker
            // 
            this.valheim_priority_checker.Interval = 60000;
            this.valheim_priority_checker.Tick += new System.EventHandler(this.valheim_priority_checker_Tick);
            // 
            // resetlbl
            // 
            this.resetlbl.BackColor = System.Drawing.Color.Transparent;
            this.resetlbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resetlbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetlbl.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetlbl.ForeColor = System.Drawing.Color.White;
            this.resetlbl.Location = new System.Drawing.Point(375, 402);
            this.resetlbl.Name = "resetlbl";
            this.resetlbl.Size = new System.Drawing.Size(51, 19);
            this.resetlbl.TabIndex = 14;
            this.resetlbl.Text = "Reset";
            this.resetlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.resetlbl.Click += new System.EventHandler(this.resetlbl_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resetlbl);
            this.Controls.Add(this.info_priority);
            this.Controls.Add(this.priority_cb);
            this.Controls.Add(this.info_launch_parameter);
            this.Controls.Add(this.parameter_cb);
            this.Controls.Add(this.information_box);
            this.Controls.Add(this.info_gfx);
            this.Controls.Add(this.info_gfx_native);
            this.Controls.Add(this.gfx_cb);
            this.Controls.Add(this.gfx_native_cb);
            this.Controls.Add(this.optimizebtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.titlelbl);
            this.Controls.Add(this.hidebtn);
            this.Controls.Add(this.closebtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Main_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.closebtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hidebtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.info_gfx_native)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.info_gfx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.info_launch_parameter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.info_priority)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox closebtn;
        private System.Windows.Forms.PictureBox hidebtn;
        private System.Windows.Forms.Label titlelbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button optimizebtn;
        private System.Windows.Forms.CheckBox gfx_native_cb;
        private System.Windows.Forms.CheckBox gfx_cb;
        private System.Windows.Forms.PictureBox info_gfx_native;
        private System.Windows.Forms.PictureBox info_gfx;
        private System.Windows.Forms.Label information_box;
        private System.Windows.Forms.PictureBox info_launch_parameter;
        private System.Windows.Forms.CheckBox parameter_cb;
        private System.Windows.Forms.PictureBox info_priority;
        private System.Windows.Forms.CheckBox priority_cb;
        private System.Windows.Forms.NotifyIcon hiddenIcon;
        private System.Windows.Forms.Timer valheim_priority_checker;
        private System.Windows.Forms.Label resetlbl;
    }
}

