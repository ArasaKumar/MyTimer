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
            this.mlblActionLabel = new MaterialSkin.Controls.MaterialLabel();
            this.mbtnStart = new MaterialSkin.Controls.MaterialButton();
            this.mbtnStop = new MaterialSkin.Controls.MaterialButton();
            this.mbtnMinimize = new MaterialSkin.Controls.MaterialButton();
            this.mbtnQuit = new MaterialSkin.Controls.MaterialButton();
            this.bswtTheme = new MaterialSkin.Controls.MaterialSwitch();
            this.mlblStatusLabel = new MaterialSkin.Controls.MaterialLabel();
            this.mtlpFooter = new System.Windows.Forms.TableLayoutPanel();
            this.mlblMessage = new MaterialSkin.Controls.MaterialLabel();
            this.mmtbxData = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.cmMenu.SuspendLayout();
            this.mtlpMain.SuspendLayout();
            this.mtlpHeader.SuspendLayout();
            this.mtlpFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
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
            this.mtlpMain.Controls.Add(this.mtlpFooter, 0, 2);
            this.mtlpMain.Controls.Add(this.mmtbxData, 0, 1);
            this.mtlpMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mtlpMain.Location = new System.Drawing.Point(0, 64);
            this.mtlpMain.Name = "mtlpMain";
            this.mtlpMain.RowCount = 3;
            this.mtlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.mtlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mtlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.mtlpMain.Size = new System.Drawing.Size(985, 551);
            this.mtlpMain.TabIndex = 5;
            // 
            // mtlpHeader
            // 
            this.mtlpHeader.ColumnCount = 6;
            this.mtlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.mtlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.mtlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.mtlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.mtlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.mtlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mtlpHeader.Controls.Add(this.mbtnQuit, 4, 0);
            this.mtlpHeader.Controls.Add(this.mbtnMinimize, 3, 0);
            this.mtlpHeader.Controls.Add(this.mbtnStop, 2, 0);
            this.mtlpHeader.Controls.Add(this.mlblActionLabel, 0, 0);
            this.mtlpHeader.Controls.Add(this.mbtnStart, 1, 0);
            this.mtlpHeader.Controls.Add(this.bswtTheme, 5, 0);
            this.mtlpHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mtlpHeader.Location = new System.Drawing.Point(3, 3);
            this.mtlpHeader.Name = "mtlpHeader";
            this.mtlpHeader.RowCount = 1;
            this.mtlpHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mtlpHeader.Size = new System.Drawing.Size(979, 74);
            this.mtlpHeader.TabIndex = 0;
            // 
            // mlblActionLabel
            // 
            this.mlblActionLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mlblActionLabel.AutoSize = true;
            this.mlblActionLabel.Depth = 0;
            this.mlblActionLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mlblActionLabel.Location = new System.Drawing.Point(20, 27);
            this.mlblActionLabel.Margin = new System.Windows.Forms.Padding(20, 5, 5, 5);
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
            this.mbtnStart.HighEmphasis = true;
            this.mbtnStart.Icon = null;
            this.mbtnStart.Location = new System.Drawing.Point(103, 19);
            this.mbtnStart.Margin = new System.Windows.Forms.Padding(20, 5, 5, 5);
            this.mbtnStart.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnStart.Name = "mbtnStart";
            this.mbtnStart.Size = new System.Drawing.Size(67, 36);
            this.mbtnStart.TabIndex = 1;
            this.mbtnStart.Text = "Start";
            this.mbtnStart.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mbtnStart.UseAccentColor = false;
            this.mbtnStart.UseVisualStyleBackColor = true;
            this.mbtnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // mbtnStop
            // 
            this.mbtnStop.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mbtnStop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnStop.Depth = 0;
            this.mbtnStop.DrawShadows = true;
            this.mbtnStop.HighEmphasis = true;
            this.mbtnStop.Icon = null;
            this.mbtnStop.Location = new System.Drawing.Point(195, 19);
            this.mbtnStop.Margin = new System.Windows.Forms.Padding(20, 5, 5, 5);
            this.mbtnStop.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnStop.Name = "mbtnStop";
            this.mbtnStop.Size = new System.Drawing.Size(58, 36);
            this.mbtnStop.TabIndex = 2;
            this.mbtnStop.Text = "Stop";
            this.mbtnStop.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mbtnStop.UseAccentColor = false;
            this.mbtnStop.UseVisualStyleBackColor = true;
            this.mbtnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // mbtnMinimize
            // 
            this.mbtnMinimize.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mbtnMinimize.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnMinimize.Depth = 0;
            this.mbtnMinimize.DrawShadows = true;
            this.mbtnMinimize.HighEmphasis = true;
            this.mbtnMinimize.Icon = null;
            this.mbtnMinimize.Location = new System.Drawing.Point(278, 19);
            this.mbtnMinimize.Margin = new System.Windows.Forms.Padding(20, 5, 5, 5);
            this.mbtnMinimize.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnMinimize.Name = "mbtnMinimize";
            this.mbtnMinimize.Size = new System.Drawing.Size(88, 36);
            this.mbtnMinimize.TabIndex = 3;
            this.mbtnMinimize.Text = "Minimize";
            this.mbtnMinimize.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mbtnMinimize.UseAccentColor = false;
            this.mbtnMinimize.UseVisualStyleBackColor = true;
            this.mbtnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // mbtnQuit
            // 
            this.mbtnQuit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mbtnQuit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnQuit.Depth = 0;
            this.mbtnQuit.DrawShadows = true;
            this.mbtnQuit.HighEmphasis = true;
            this.mbtnQuit.Icon = null;
            this.mbtnQuit.Location = new System.Drawing.Point(391, 19);
            this.mbtnQuit.Margin = new System.Windows.Forms.Padding(20, 5, 5, 5);
            this.mbtnQuit.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnQuit.Name = "mbtnQuit";
            this.mbtnQuit.Size = new System.Drawing.Size(54, 36);
            this.mbtnQuit.TabIndex = 4;
            this.mbtnQuit.Text = "Quit";
            this.mbtnQuit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mbtnQuit.UseAccentColor = false;
            this.mbtnQuit.UseVisualStyleBackColor = true;
            this.mbtnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // bswtTheme
            // 
            this.bswtTheme.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bswtTheme.AutoSize = true;
            this.bswtTheme.Depth = 0;
            this.bswtTheme.Location = new System.Drawing.Point(470, 18);
            this.bswtTheme.Margin = new System.Windows.Forms.Padding(20, 5, 5, 5);
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
            // mlblStatusLabel
            // 
            this.mlblStatusLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mlblStatusLabel.AutoSize = true;
            this.mlblStatusLabel.Depth = 0;
            this.mlblStatusLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mlblStatusLabel.Location = new System.Drawing.Point(20, 27);
            this.mlblStatusLabel.Margin = new System.Windows.Forms.Padding(20, 5, 5, 5);
            this.mlblStatusLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlblStatusLabel.Name = "mlblStatusLabel";
            this.mlblStatusLabel.Size = new System.Drawing.Size(51, 19);
            this.mlblStatusLabel.TabIndex = 1;
            this.mlblStatusLabel.Text = "Status:";
            // 
            // mtlpFooter
            // 
            this.mtlpFooter.ColumnCount = 2;
            this.mtlpFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.mtlpFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.mtlpFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mtlpFooter.Controls.Add(this.mlblMessage, 1, 0);
            this.mtlpFooter.Controls.Add(this.mlblStatusLabel, 0, 0);
            this.mtlpFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mtlpFooter.Location = new System.Drawing.Point(3, 474);
            this.mtlpFooter.Name = "mtlpFooter";
            this.mtlpFooter.RowCount = 1;
            this.mtlpFooter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mtlpFooter.Size = new System.Drawing.Size(979, 74);
            this.mtlpFooter.TabIndex = 2;
            // 
            // mlblMessage
            // 
            this.mlblMessage.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mlblMessage.AutoSize = true;
            this.mlblMessage.Depth = 0;
            this.mlblMessage.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mlblMessage.Location = new System.Drawing.Point(96, 27);
            this.mlblMessage.Margin = new System.Windows.Forms.Padding(20, 5, 5, 5);
            this.mlblMessage.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlblMessage.Name = "mlblMessage";
            this.mlblMessage.Size = new System.Drawing.Size(108, 19);
            this.mlblMessage.TabIndex = 2;
            this.mlblMessage.Text = "Not yet started!";
            // 
            // mmtbxData
            // 
            this.mmtbxData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mmtbxData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mmtbxData.Depth = 0;
            this.mmtbxData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mmtbxData.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mmtbxData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mmtbxData.Hint = "";
            this.mmtbxData.Location = new System.Drawing.Point(3, 83);
            this.mmtbxData.MouseState = MaterialSkin.MouseState.HOVER;
            this.mmtbxData.Name = "mmtbxData";
            this.mmtbxData.ReadOnly = true;
            this.mmtbxData.Size = new System.Drawing.Size(979, 385);
            this.mmtbxData.TabIndex = 3;
            this.mmtbxData.Text = "";
            // 
            // Monitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 615);
            this.Controls.Add(this.mtlpMain);
            this.Name = "Monitor";
            this.Text = "App Time Monitor";
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
        private MaterialSkin.Controls.MaterialButton mbtnQuit;
        private MaterialSkin.Controls.MaterialButton mbtnMinimize;
        private MaterialSkin.Controls.MaterialButton mbtnStop;
        private MaterialSkin.Controls.MaterialButton mbtnStart;
        private MaterialSkin.Controls.MaterialSwitch bswtTheme;
        private MaterialSkin.Controls.MaterialLabel mlblStatusLabel;
        private System.Windows.Forms.TableLayoutPanel mtlpFooter;
        private MaterialSkin.Controls.MaterialLabel mlblMessage;
        private MaterialSkin.Controls.MaterialMultiLineTextBox mmtbxData;
    }
}

