namespace Metin2_MD5_Patcher
{
	public partial class RaffaeL_Work : global::System.Windows.Forms.Form
	{
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RaffaeL_Work));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.Status = new System.Windows.Forms.ToolStripStatusLabel();
            this.completeProgress = new System.Windows.Forms.ProgressBar();
            this.currentProgress = new System.Windows.Forms.ProgressBar();
            this.completeProgressText = new System.Windows.Forms.Label();
            this.currentProgressText = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.currentDownloadSpeed = new System.Windows.Forms.Label();
            this.fileInfo = new System.Windows.Forms.Label();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.pbTotal = new System.Windows.Forms.PictureBox();
            this.pbFile = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btn_discord = new System.Windows.Forms.Button();
            this.btn_website = new System.Windows.Forms.Button();
            this.btn_facebook = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.PictureBox();
            this.btnConfig = new System.Windows.Forms.PictureBox();
            this.btnAccount = new System.Windows.Forms.PictureBox();
            this.btnForum = new System.Windows.Forms.PictureBox();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnConfig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnForum)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.AllowMerge = false;
            this.statusStrip.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip.ForeColor = System.Drawing.Color.Black;
            this.statusStrip.GripMargin = new System.Windows.Forms.Padding(0);
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(0, 0);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Status});
            this.statusStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.statusStrip.Location = new System.Drawing.Point(178, 373);
            this.statusStrip.MinimumSize = new System.Drawing.Size(466, 0);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.statusStrip.Size = new System.Drawing.Size(466, 5);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 0;
            this.statusStrip.Text = "Status";
            this.statusStrip.Visible = false;
            // 
            // Status
            // 
            this.Status.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status.ForeColor = System.Drawing.Color.Black;
            this.Status.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Status.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(0, 0);
            this.Status.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // completeProgress
            // 
            this.completeProgress.BackColor = System.Drawing.Color.Black;
            this.completeProgress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.completeProgress.Location = new System.Drawing.Point(683, 246);
            this.completeProgress.Margin = new System.Windows.Forms.Padding(0);
            this.completeProgress.Name = "completeProgress";
            this.completeProgress.Size = new System.Drawing.Size(1, 1);
            this.completeProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.completeProgress.TabIndex = 1;
            this.completeProgress.Visible = false;
            // 
            // currentProgress
            // 
            this.currentProgress.BackColor = System.Drawing.Color.Black;
            this.currentProgress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.currentProgress.Location = new System.Drawing.Point(683, 263);
            this.currentProgress.Name = "currentProgress";
            this.currentProgress.Size = new System.Drawing.Size(1, 1);
            this.currentProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.currentProgress.TabIndex = 2;
            this.currentProgress.Visible = false;
            // 
            // completeProgressText
            // 
            this.completeProgressText.AutoSize = true;
            this.completeProgressText.BackColor = System.Drawing.Color.Transparent;
            this.completeProgressText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.completeProgressText.ForeColor = System.Drawing.Color.Black;
            this.completeProgressText.Location = new System.Drawing.Point(26, 426);
            this.completeProgressText.Name = "completeProgressText";
            this.completeProgressText.Size = new System.Drawing.Size(113, 13);
            this.completeProgressText.TabIndex = 3;
            this.completeProgressText.Text = "Total Progress: 0%";
            // 
            // currentProgressText
            // 
            this.currentProgressText.AutoSize = true;
            this.currentProgressText.BackColor = System.Drawing.Color.Transparent;
            this.currentProgressText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentProgressText.ForeColor = System.Drawing.Color.Black;
            this.currentProgressText.Location = new System.Drawing.Point(30, 399);
            this.currentProgressText.Name = "currentProgressText";
            this.currentProgressText.Size = new System.Drawing.Size(103, 13);
            this.currentProgressText.TabIndex = 4;
            this.currentProgressText.Text = "File progress: 0%";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(44)))));
            this.panel4.Location = new System.Drawing.Point(796, 223);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1, 21);
            this.panel4.TabIndex = 11;
            // 
            // currentDownloadSpeed
            // 
            this.currentDownloadSpeed.AutoSize = true;
            this.currentDownloadSpeed.BackColor = System.Drawing.Color.Transparent;
            this.currentDownloadSpeed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.currentDownloadSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentDownloadSpeed.ForeColor = System.Drawing.Color.Black;
            this.currentDownloadSpeed.Location = new System.Drawing.Point(30, 375);
            this.currentDownloadSpeed.Name = "currentDownloadSpeed";
            this.currentDownloadSpeed.Size = new System.Drawing.Size(116, 13);
            this.currentDownloadSpeed.TabIndex = 16;
            this.currentDownloadSpeed.Text = "Download speed: ∞";
            // 
            // fileInfo
            // 
            this.fileInfo.AutoSize = true;
            this.fileInfo.BackColor = System.Drawing.Color.Transparent;
            this.fileInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fileInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileInfo.ForeColor = System.Drawing.Color.Black;
            this.fileInfo.Location = new System.Drawing.Point(210, 376);
            this.fileInfo.Name = "fileInfo";
            this.fileInfo.Size = new System.Drawing.Size(0, 13);
            this.fileInfo.TabIndex = 17;
            // 
            // webBrowser
            // 
            this.webBrowser.AllowNavigation = false;
            this.webBrowser.AllowWebBrowserDrop = false;
            this.webBrowser.IsWebBrowserContextMenuEnabled = false;
            this.webBrowser.Location = new System.Drawing.Point(45, 133);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.ScriptErrorsSuppressed = true;
            this.webBrowser.ScrollBarsEnabled = false;
            this.webBrowser.Size = new System.Drawing.Size(500, 237);
            this.webBrowser.TabIndex = 18;
            this.webBrowser.WebBrowserShortcutsEnabled = false;
            // 
            // pbTotal
            // 
            this.pbTotal.BackColor = System.Drawing.Color.Transparent;
            this.pbTotal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbTotal.BackgroundImage")));
            this.pbTotal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbTotal.Location = new System.Drawing.Point(161, 424);
            this.pbTotal.Name = "pbTotal";
            this.pbTotal.Size = new System.Drawing.Size(0, 15);
            this.pbTotal.TabIndex = 15;
            this.pbTotal.TabStop = false;
            // 
            // pbFile
            // 
            this.pbFile.BackColor = System.Drawing.Color.Transparent;
            this.pbFile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbFile.BackgroundImage")));
            this.pbFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbFile.Location = new System.Drawing.Point(161, 398);
            this.pbFile.Name = "pbFile";
            this.pbFile.Size = new System.Drawing.Size(0, 15);
            this.pbFile.TabIndex = 15;
            this.pbFile.TabStop = false;
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMinimize.Image = global::Patcher_RaffaeL_Rework.Properties.Resources.btn_minimize_up;
            this.btnMinimize.Location = new System.Drawing.Point(792, 42);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(34, 34);
            this.btnMinimize.TabIndex = 13;
            this.btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            this.btnMinimize.MouseLeave += new System.EventHandler(this.button3_MouseLeave);
            this.btnMinimize.MouseHover += new System.EventHandler(this.button3_MouseHover);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = global::Patcher_RaffaeL_Rework.Properties.Resources.btn_quit_up;
            this.btnClose.Location = new System.Drawing.Point(830, 42);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(34, 34);
            this.btnClose.TabIndex = 7;
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnClose_MouseClick);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            this.btnClose.MouseHover += new System.EventHandler(this.btnClose_MouseHover);
            // 
            // btn_discord
            // 
            this.btn_discord.BackColor = System.Drawing.Color.Transparent;
            this.btn_discord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_discord.FlatAppearance.BorderSize = 0;
            this.btn_discord.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_discord.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_discord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_discord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_discord.Image = global::Patcher_RaffaeL_Rework.Properties.Resources.btn_discord_on;
            this.btn_discord.Location = new System.Drawing.Point(559, 229);
            this.btn_discord.Margin = new System.Windows.Forms.Padding(0);
            this.btn_discord.Name = "btn_discord";
            this.btn_discord.Size = new System.Drawing.Size(42, 42);
            this.btn_discord.TabIndex = 20;
            this.btn_discord.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_discord.UseVisualStyleBackColor = false;
            this.btn_discord.Click += new System.EventHandler(this.btn_discord_Click);
            this.btn_discord.MouseLeave += new System.EventHandler(this.btn_discord_MouseLeave);
            this.btn_discord.MouseHover += new System.EventHandler(this.btn_discord_MouseHover);
            // 
            // btn_website
            // 
            this.btn_website.BackColor = System.Drawing.Color.Transparent;
            this.btn_website.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_website.FlatAppearance.BorderSize = 0;
            this.btn_website.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_website.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_website.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_website.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_website.Image = global::Patcher_RaffaeL_Rework.Properties.Resources.btn_web_on;
            this.btn_website.Location = new System.Drawing.Point(559, 277);
            this.btn_website.Margin = new System.Windows.Forms.Padding(0);
            this.btn_website.Name = "btn_website";
            this.btn_website.Size = new System.Drawing.Size(42, 42);
            this.btn_website.TabIndex = 21;
            this.btn_website.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_website.UseVisualStyleBackColor = false;
            this.btn_website.Click += new System.EventHandler(this.btn_website_Click);
            this.btn_website.MouseLeave += new System.EventHandler(this.btn_website_MouseLeave);
            this.btn_website.MouseHover += new System.EventHandler(this.btn_website_MouseHover);
            // 
            // btn_facebook
            // 
            this.btn_facebook.BackColor = System.Drawing.Color.Transparent;
            this.btn_facebook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_facebook.FlatAppearance.BorderSize = 0;
            this.btn_facebook.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_facebook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_facebook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_facebook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_facebook.Image = global::Patcher_RaffaeL_Rework.Properties.Resources.btn_facebook_on;
            this.btn_facebook.Location = new System.Drawing.Point(559, 325);
            this.btn_facebook.Margin = new System.Windows.Forms.Padding(0);
            this.btn_facebook.Name = "btn_facebook";
            this.btn_facebook.Size = new System.Drawing.Size(42, 42);
            this.btn_facebook.TabIndex = 22;
            this.btn_facebook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_facebook.UseVisualStyleBackColor = false;
            this.btn_facebook.Click += new System.EventHandler(this.btn_facebook_Click);
            this.btn_facebook.MouseLeave += new System.EventHandler(this.btn_facebook_MouseLeave);
            this.btn_facebook.MouseHover += new System.EventHandler(this.btn_facebook_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.label1.Location = new System.Drawing.Point(601, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 18);
            this.label1.TabIndex = 23;
            this.label1.Text = "DISCORD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.label2.Location = new System.Drawing.Point(601, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 24;
            this.label2.Text = "WEBSITE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.label3.Location = new System.Drawing.Point(601, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 18);
            this.label3.TabIndex = 25;
            this.label3.Text = "FACEBOOK";
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.Transparent;
            this.Start.Enabled = false;
            this.Start.Image = global::Patcher_RaffaeL_Rework.Properties.Resources.btn_start_on;
            this.Start.Location = new System.Drawing.Point(718, 224);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(145, 34);
            this.Start.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Start.TabIndex = 26;
            this.Start.TabStop = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            this.Start.MouseLeave += new System.EventHandler(this.Start_MouseLeave);
            this.Start.MouseHover += new System.EventHandler(this.Start_MouseHover);
            // 
            // btnConfig
            // 
            this.btnConfig.BackColor = System.Drawing.Color.Transparent;
            this.btnConfig.Image = global::Patcher_RaffaeL_Rework.Properties.Resources.btn_option_on;
            this.btnConfig.Location = new System.Drawing.Point(718, 262);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(145, 34);
            this.btnConfig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnConfig.TabIndex = 27;
            this.btnConfig.TabStop = false;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            this.btnConfig.MouseLeave += new System.EventHandler(this.btnConfig_MouseLeave);
            this.btnConfig.MouseHover += new System.EventHandler(this.btnConfig_MouseHover);
            // 
            // btnAccount
            // 
            this.btnAccount.BackColor = System.Drawing.Color.Transparent;
            this.btnAccount.Image = global::Patcher_RaffaeL_Rework.Properties.Resources.btn_account_on;
            this.btnAccount.Location = new System.Drawing.Point(718, 301);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(145, 34);
            this.btnAccount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAccount.TabIndex = 28;
            this.btnAccount.TabStop = false;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            this.btnAccount.MouseLeave += new System.EventHandler(this.btnAccount_MouseLeave);
            this.btnAccount.MouseHover += new System.EventHandler(this.btnAccount_MouseHover);
            // 
            // btnForum
            // 
            this.btnForum.BackColor = System.Drawing.Color.Transparent;
            this.btnForum.Image = ((System.Drawing.Image)(resources.GetObject("btnForum.Image")));
            this.btnForum.Location = new System.Drawing.Point(718, 339);
            this.btnForum.Name = "btnForum";
            this.btnForum.Size = new System.Drawing.Size(145, 34);
            this.btnForum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnForum.TabIndex = 29;
            this.btnForum.TabStop = false;
            this.btnForum.Click += new System.EventHandler(this.btnForum_Click);
            this.btnForum.MouseLeave += new System.EventHandler(this.btnForum_MouseLeave);
            this.btnForum.MouseHover += new System.EventHandler(this.btnForum_MouseHover);
            // 
            // RaffaeL_Work
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = global::Patcher_RaffaeL_Rework.Properties.Resources.main_bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 480);
            this.Controls.Add(this.btnForum);
            this.Controls.Add(this.btnAccount);
            this.Controls.Add(this.btnConfig);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_facebook);
            this.Controls.Add(this.btn_website);
            this.Controls.Add(this.btn_discord);
            this.Controls.Add(this.fileInfo);
            this.Controls.Add(this.currentDownloadSpeed);
            this.Controls.Add(this.currentProgressText);
            this.Controls.Add(this.pbTotal);
            this.Controls.Add(this.pbFile);
            this.Controls.Add(this.completeProgressText);
            this.Controls.Add(this.completeProgress);
            this.Controls.Add(this.currentProgress);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.panel4);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(900, 480);
            this.MinimumSize = new System.Drawing.Size(900, 480);
            this.Name = "RaffaeL_Work";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patcher";
            this.TransparencyKey = System.Drawing.Color.DimGray;
            this.Load += new System.EventHandler(this.RaffaeL_Work_Load);
            this.Shown += new System.EventHandler(this.RaffaeL_Work_Shown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RaffaeL_Work_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RaffaeL_Work_MouseMove);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnConfig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnForum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		private global::System.Windows.Forms.StatusStrip statusStrip;
		public global::System.Windows.Forms.ToolStripStatusLabel Status;
		public global::System.Windows.Forms.ProgressBar completeProgress;
		public global::System.Windows.Forms.ProgressBar currentProgress;
		public global::System.Windows.Forms.Label completeProgressText;
        public global::System.Windows.Forms.Label currentProgressText;
		private global::System.Windows.Forms.Button btnClose;
        private global::System.Windows.Forms.Panel panel4;
		private global::System.Windows.Forms.Button btnMinimize;
		public System.Windows.Forms.PictureBox pbFile;
        public System.Windows.Forms.PictureBox pbTotal;
		public System.Windows.Forms.Label currentDownloadSpeed;
        public System.Windows.Forms.Label fileInfo;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.Button btn_discord;
        private System.Windows.Forms.Button btn_website;
        private System.Windows.Forms.Button btn_facebook;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox btnConfig;
        private System.Windows.Forms.PictureBox btnAccount;
        private System.Windows.Forms.PictureBox btnForum;
        protected internal System.Windows.Forms.PictureBox Start;
	}
}
