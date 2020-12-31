namespace Timer
{
    partial class Monitor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Monitor));
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.maximizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mtlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.mtlpHeader = new System.Windows.Forms.TableLayoutPanel();
            this.mbtnStop = new MaterialSkin.Controls.MaterialButton();
            this.mlblActionLabel = new MaterialSkin.Controls.MaterialLabel();
            this.mbtnStart = new MaterialSkin.Controls.MaterialButton();
            this.bswtTheme = new MaterialSkin.Controls.MaterialSwitch();
            this.mbtnClear = new MaterialSkin.Controls.MaterialButton();
            this.mbtnSave = new MaterialSkin.Controls.MaterialButton();
            this.mtlpFooter = new System.Windows.Forms.TableLayoutPanel();
            this.mlblMessage = new MaterialSkin.Controls.MaterialLabel();
            this.mlblStatusLabel = new MaterialSkin.Controls.MaterialLabel();
            this.mmtbxData = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.mlblTotalTime = new MaterialSkin.Controls.MaterialLabel();
            this.mlblMsg = new MaterialSkin.Controls.MaterialLabel();
            this.cmMenu.SuspendLayout();
            this.mtlpMain.SuspendLayout();
            this.mtlpHeader.SuspendLayout();
            this.mtlpFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipText = "Personal Time Tracker";
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "notifyIcon";
            // 
            // cmMenu
            // 
            this.cmMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maximizeToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.stopToolStripMenuItem,
            this.startToolStripMenuItem,
            this.showStatusToolStripMenuItem});
            this.cmMenu.Name = "cmMenu";
            this.cmMenu.Size = new System.Drawing.Size(159, 124);
            // 
            // maximizeToolStripMenuItem
            // 
            this.maximizeToolStripMenuItem.Name = "maximizeToolStripMenuItem";
            this.maximizeToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
            this.maximizeToolStripMenuItem.Text = "Maximize";
            this.maximizeToolStripMenuItem.Click += new System.EventHandler(this.maximizeToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
            this.stopToolStripMenuItem.Text = "Stop";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // showStatusToolStripMenuItem
            // 
            this.showStatusToolStripMenuItem.Name = "showStatusToolStripMenuItem";
            this.showStatusToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
            this.showStatusToolStripMenuItem.Text = "Show Status";
            this.showStatusToolStripMenuItem.Click += new System.EventHandler(this.showStatusToolStripMenuItem_Click);
            // 
            // mtlpMain
            // 
            this.mtlpMain.ColumnCount = 1;
            this.mtlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.mtlpMain.Controls.Add(this.mtlpHeader, 0, 0);
            this.mtlpMain.Controls.Add(this.mtlpFooter, 0, 3);
            this.mtlpMain.Controls.Add(this.mmtbxData, 0, 1);
            this.mtlpMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mtlpMain.Location = new System.Drawing.Point(1, 59);
            this.mtlpMain.Name = "mtlpMain";
            this.mtlpMain.RowCount = 4;
            this.mtlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.mtlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mtlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mtlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.mtlpMain.Size = new System.Drawing.Size(860, 517);
            this.mtlpMain.TabIndex = 5;
            // 
            // mtlpHeader
            // 
            this.mtlpHeader.ColumnCount = 8;
            this.mtlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.mtlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.mtlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.mtlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.mtlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.mtlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.mtlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mtlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.mtlpHeader.Controls.Add(this.mbtnStop, 2, 0);
            this.mtlpHeader.Controls.Add(this.mlblActionLabel, 0, 0);
            this.mtlpHeader.Controls.Add(this.mbtnStart, 1, 0);
            this.mtlpHeader.Controls.Add(this.bswtTheme, 6, 0);
            this.mtlpHeader.Controls.Add(this.mbtnClear, 3, 0);
            this.mtlpHeader.Controls.Add(this.mbtnSave, 4, 0);
            this.mtlpHeader.Controls.Add(this.mlblMsg, 5, 0);
            this.mtlpHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mtlpHeader.Location = new System.Drawing.Point(3, 3);
            this.mtlpHeader.Name = "mtlpHeader";
            this.mtlpHeader.RowCount = 1;
            this.mtlpHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mtlpHeader.Size = new System.Drawing.Size(857, 39);
            this.mtlpHeader.TabIndex = 0;
            // 
            // mbtnStop
            // 
            this.mbtnStop.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mbtnStop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnStop.Depth = 0;
            this.mbtnStop.DrawShadows = true;
            this.mbtnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mbtnStop.HighEmphasis = true;
            this.mbtnStop.Icon = null;
            this.mbtnStop.Location = new System.Drawing.Point(187, 5);
            this.mbtnStop.Margin = new System.Windows.Forms.Padding(18, 5, 4, 5);
            this.mbtnStop.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnStop.Name = "mbtnStop";
            this.mbtnStop.Size = new System.Drawing.Size(58, 29);
            this.mbtnStop.TabIndex = 2;
            this.mbtnStop.Text = "Stop";
            this.mbtnStop.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mbtnStop.UseAccentColor = false;
            this.mbtnStop.UseVisualStyleBackColor = true;
            this.mbtnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // mlblActionLabel
            // 
            this.mlblActionLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mlblActionLabel.AutoSize = true;
            this.mlblActionLabel.Depth = 0;
            this.mlblActionLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mlblActionLabel.Location = new System.Drawing.Point(18, 10);
            this.mlblActionLabel.Margin = new System.Windows.Forms.Padding(18, 5, 4, 5);
            this.mlblActionLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlblActionLabel.Name = "mlblActionLabel";
            this.mlblActionLabel.Size = new System.Drawing.Size(58, 19);
            this.mlblActionLabel.TabIndex = 0;
            this.mlblActionLabel.Text = "Actions:";
            // 
            // mbtnStart
            // 
            this.mbtnStart.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mbtnStart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnStart.Depth = 0;
            this.mbtnStart.DrawShadows = true;
            this.mbtnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mbtnStart.HighEmphasis = true;
            this.mbtnStart.Icon = null;
            this.mbtnStart.Location = new System.Drawing.Point(98, 5);
            this.mbtnStart.Margin = new System.Windows.Forms.Padding(18, 5, 4, 5);
            this.mbtnStart.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnStart.Name = "mbtnStart";
            this.mbtnStart.Size = new System.Drawing.Size(67, 29);
            this.mbtnStart.TabIndex = 1;
            this.mbtnStart.Text = "Start";
            this.mbtnStart.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mbtnStart.UseAccentColor = false;
            this.mbtnStart.UseVisualStyleBackColor = true;
            this.mbtnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // bswtTheme
            // 
            this.bswtTheme.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bswtTheme.AutoSize = true;
            this.bswtTheme.Depth = 0;
            this.bswtTheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bswtTheme.Location = new System.Drawing.Point(695, 1);
            this.bswtTheme.Margin = new System.Windows.Forms.Padding(0);
            this.bswtTheme.MouseLocation = new System.Drawing.Point(-1, -1);
            this.bswtTheme.MouseState = MaterialSkin.MouseState.HOVER;
            this.bswtTheme.Name = "bswtTheme";
            this.bswtTheme.Ripple = true;
            this.bswtTheme.Size = new System.Drawing.Size(144, 37);
            this.bswtTheme.TabIndex = 5;
            this.bswtTheme.Text = "Dark Theme";
            this.bswtTheme.UseVisualStyleBackColor = true;
            this.bswtTheme.CheckedChanged += new System.EventHandler(this.bswtTheme_CheckedChanged);
            // 
            // mbtnClear
            // 
            this.mbtnClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnClear.Depth = 0;
            this.mbtnClear.DrawShadows = true;
            this.mbtnClear.HighEmphasis = true;
            this.mbtnClear.Icon = null;
            this.mbtnClear.Location = new System.Drawing.Point(253, 6);
            this.mbtnClear.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbtnClear.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnClear.Name = "mbtnClear";
            this.mbtnClear.Size = new System.Drawing.Size(108, 27);
            this.mbtnClear.TabIndex = 6;
            this.mbtnClear.Text = "Clear Data";
            this.mbtnClear.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mbtnClear.UseAccentColor = false;
            this.mbtnClear.UseVisualStyleBackColor = true;
            this.mbtnClear.Click += new System.EventHandler(this.mbtnClear_Click);
            // 
            // mbtnSave
            // 
            this.mbtnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnSave.Depth = 0;
            this.mbtnSave.DrawShadows = true;
            this.mbtnSave.HighEmphasis = true;
            this.mbtnSave.Icon = null;
            this.mbtnSave.Location = new System.Drawing.Point(369, 6);
            this.mbtnSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbtnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnSave.Name = "mbtnSave";
            this.mbtnSave.Size = new System.Drawing.Size(113, 27);
            this.mbtnSave.TabIndex = 7;
            this.mbtnSave.Text = "Save to File";
            this.mbtnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mbtnSave.UseAccentColor = false;
            this.mbtnSave.UseVisualStyleBackColor = true;
            this.mbtnSave.Click += new System.EventHandler(this.mbtnSave_Click);
            // 
            // mtlpFooter
            // 
            this.mtlpFooter.ColumnCount = 4;
            this.mtlpFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.mtlpFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.mtlpFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.mtlpFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.mtlpFooter.Controls.Add(this.mlblMessage, 1, 0);
            this.mtlpFooter.Controls.Add(this.mlblStatusLabel, 0, 0);
            this.mtlpFooter.Controls.Add(this.mlblTotalTime, 3, 0);
            this.mtlpFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mtlpFooter.Location = new System.Drawing.Point(3, 475);
            this.mtlpFooter.Name = "mtlpFooter";
            this.mtlpFooter.RowCount = 1;
            this.mtlpFooter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mtlpFooter.Size = new System.Drawing.Size(857, 39);
            this.mtlpFooter.TabIndex = 2;
            // 
            // mlblMessage
            // 
            this.mlblMessage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mlblMessage.AutoSize = true;
            this.mlblMessage.Depth = 0;
            this.mlblMessage.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mlblMessage.Location = new System.Drawing.Point(91, 10);
            this.mlblMessage.Margin = new System.Windows.Forms.Padding(18, 5, 4, 5);
            this.mlblMessage.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlblMessage.Name = "mlblMessage";
            this.mlblMessage.Size = new System.Drawing.Size(108, 19);
            this.mlblMessage.TabIndex = 2;
            this.mlblMessage.Text = "Not yet started!";
            this.mlblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mlblStatusLabel
            // 
            this.mlblStatusLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mlblStatusLabel.AutoSize = true;
            this.mlblStatusLabel.Depth = 0;
            this.mlblStatusLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mlblStatusLabel.Location = new System.Drawing.Point(18, 10);
            this.mlblStatusLabel.Margin = new System.Windows.Forms.Padding(18, 5, 4, 5);
            this.mlblStatusLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlblStatusLabel.Name = "mlblStatusLabel";
            this.mlblStatusLabel.Size = new System.Drawing.Size(51, 19);
            this.mlblStatusLabel.TabIndex = 1;
            this.mlblStatusLabel.Text = "Status:";
            this.mlblStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mmtbxData
            // 
            this.mmtbxData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mmtbxData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mmtbxData.Depth = 0;
            this.mmtbxData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mmtbxData.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.mmtbxData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mmtbxData.Hint = "";
            this.mmtbxData.Location = new System.Drawing.Point(3, 48);
            this.mmtbxData.MouseState = MaterialSkin.MouseState.HOVER;
            this.mmtbxData.Name = "mmtbxData";
            this.mmtbxData.ReadOnly = true;
            this.mmtbxData.Size = new System.Drawing.Size(857, 421);
            this.mmtbxData.TabIndex = 3;
            this.mmtbxData.Text = "";
            // 
            // mlblTotalTime
            // 
            this.mlblTotalTime.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.mlblTotalTime.AutoSize = true;
            this.mlblTotalTime.Depth = 0;
            this.mlblTotalTime.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mlblTotalTime.Location = new System.Drawing.Point(708, 10);
            this.mlblTotalTime.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.mlblTotalTime.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlblTotalTime.Name = "mlblTotalTime";
            this.mlblTotalTime.Size = new System.Drawing.Size(139, 19);
            this.mlblTotalTime.TabIndex = 3;
            this.mlblTotalTime.Text = "Total Time Tracked";
            this.mlblTotalTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mlblMsg
            // 
            this.mlblMsg.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mlblMsg.AutoSize = true;
            this.mlblMsg.Depth = 0;
            this.mlblMsg.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mlblMsg.Location = new System.Drawing.Point(506, 19);
            this.mlblMsg.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.mlblMsg.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlblMsg.Name = "mlblMsg";
            this.mlblMsg.Size = new System.Drawing.Size(1, 0);
            this.mlblMsg.TabIndex = 8;
            // 
            // Monitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(862, 577);
            this.Controls.Add(this.mtlpMain);
            this.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "Monitor";
            this.Opacity = 0.98D;
            this.Padding = new System.Windows.Forms.Padding(1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "App Time Monitor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Monitor_FormClosing);
            this.Resize += new System.EventHandler(this.Monitor_Resize);
            this.cmMenu.ResumeLayout(false);
            this.mtlpMain.ResumeLayout(false);
            this.mtlpHeader.ResumeLayout(false);
            this.mtlpHeader.PerformLayout();
            this.mtlpFooter.ResumeLayout(false);
            this.mtlpFooter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip cmMenu;
        private System.Windows.Forms.ToolStripMenuItem maximizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showStatusToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel mtlpMain;
        private System.Windows.Forms.TableLayoutPanel mtlpHeader;
        private MaterialSkin.Controls.MaterialLabel mlblActionLabel;
        private MaterialSkin.Controls.MaterialButton mbtnStop;
        private MaterialSkin.Controls.MaterialButton mbtnStart;
        private MaterialSkin.Controls.MaterialLabel mlblStatusLabel;
        private System.Windows.Forms.TableLayoutPanel mtlpFooter;
        private MaterialSkin.Controls.MaterialLabel mlblMessage;
        private MaterialSkin.Controls.MaterialMultiLineTextBox mmtbxData;
        private MaterialSkin.Controls.MaterialSwitch bswtTheme;
        private MaterialSkin.Controls.MaterialButton mbtnClear;
        private MaterialSkin.Controls.MaterialButton mbtnSave;
        private MaterialSkin.Controls.MaterialLabel mlblTotalTime;
        private MaterialSkin.Controls.MaterialLabel mlblMsg;
    }
}

