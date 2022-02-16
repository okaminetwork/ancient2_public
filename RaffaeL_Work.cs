using System;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using Metin2_MD5_Patcher.Source_files;
using Patcher_RaffaeL_Rework.Properties;
using System.Diagnostics;
using Patcher_RaffaeL_Rework.Source_files;

namespace Metin2_MD5_Patcher
{
	public partial class RaffaeL_Work : Form
	{
		public RaffaeL_Work()
		{
			this.InitializeComponent();
			DefinireElemente.RaffaeL_Work = this;
		}

		private void btnClose_MouseHover(object sender, EventArgs e)
		{
			btnClose.Image = Resources.btn_quit_dn;
		}

		private void btnClose_MouseClick(object sender, MouseEventArgs e)
		{
			btnClose.Image = Resources.btn_quit_dn;
		}

		private void btnClose_MouseLeave(object sender, EventArgs e)
		{
			btnClose.Image = Resources.btn_quit_up;
		}

		private void button3_MouseHover(object sender, EventArgs e)
		{
			btnMinimize.Image = Resources.btn_minimize_dn;
		}

		private void button3_MouseLeave(object sender, EventArgs e)
		{
			btnMinimize.Image = Resources.btn_minimize_up;
		}

		private void Start_MouseHover(object sender, EventArgs e)
		{
			Start.Image = Resources.btn_start_dn;
		}

		private void Start_MouseLeave(object sender, EventArgs e)
		{
			Start.Image = Resources.btn_start_up;
		}

        private void btnConfig_MouseHover(object sender, EventArgs e)
        {
            btnConfig.Image = Resources.btn_option_dn;
        }

        private void btnConfig_MouseLeave(object sender, EventArgs e)
        {
            btnConfig.Image = Resources.btn_option_up;
        }

        private void btnAccount_MouseHover(object sender, EventArgs e)
        {
            btnAccount.Image = Resources.btn_account_dn;
        }

        private void btnAccount_MouseLeave(object sender, EventArgs e)
        {
            btnAccount.Image = Resources.btn_account_up;
        }

        private void btnForum_MouseHover(object sender, EventArgs e)
        {
            btnForum.Image = Resources.btn_forum_dn;
        }

        private void btnForum_MouseLeave(object sender, EventArgs e)
        {
            btnForum.Image = Resources.btn_forum_up;
        }

        private void btn_discord_MouseHover(object sender, EventArgs e)
        {
            btn_discord.Image = Resources.btn_discord_dn;
        }

        private void btn_discord_MouseLeave(object sender, EventArgs e)
        {
            btn_discord.Image = Resources.btn_discord_up;
        }

        private void btn_website_MouseHover(object sender, EventArgs e)
        {
            btn_website.Image = Resources.btn_web_dn;
        }

        private void btn_website_MouseLeave(object sender, EventArgs e)
        {
            btn_website.Image = Resources.btn_web_up;
        }

        private void btn_facebook_MouseHover(object sender, EventArgs e)
        {
            btn_facebook.Image = Resources.btn_facebook_dn;
        }

        private void btn_facebook_MouseLeave(object sender, EventArgs e)
        {
            btn_facebook.Image = Resources.btn_facebook_up;
        }

		private void RaffaeL_Work_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				this.Left += e.X - lastPoint.X;
				this.Top += e.Y - lastPoint.Y;
			}
		}
		Point lastPoint;
		private void RaffaeL_Work_MouseDown(object sender, MouseEventArgs e)
		{
			lastPoint = new Point(e.X, e.Y);
		}

		private void RaffaeL_Work_Shown(object sender, EventArgs e)
		{
			if (Executor.IsGameRunning())
			{
				Executor.EnableStart();
				return;
			}
			ActivitateRetea.CheckNetwork();
		}

		private void Start_Click(object sender, EventArgs e)
		{
			Starter.Start();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btnConfig_Click(object sender, EventArgs e)
		{
			Configurare.Start();
		}

		private void btnMinimize_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		private void RaffaeL_Work_Load(object sender, EventArgs e)
		{
            Start.Image = Resources.btn_start_ds;
            webBrowser.Refresh();
            webBrowser.Navigate(new Uri(DefinireLinkuri.newsUrl));
			webBrowser.Refresh();
		}

		private void btnAccount_Click(object sender, EventArgs e)
		{
			Process.Start(DefinireLinkuri.registerUrl);
		}

        private void btnForum_Click(object sender, EventArgs e)
        {
            Process.Start(DefinireLinkuri.forumUrl);
        }

        private void btn_discord_Click(object sender, EventArgs e)
        {
            Process.Start(DefinireLinkuri.discordUrl);
        }

        private void btn_website_Click(object sender, EventArgs e)
        {
            Process.Start(DefinireLinkuri.websiteUrl);
        }

        private void btn_facebook_Click(object sender, EventArgs e)
        {
            Process.Start(DefinireLinkuri.facebookUrl);
        }
	}
}
