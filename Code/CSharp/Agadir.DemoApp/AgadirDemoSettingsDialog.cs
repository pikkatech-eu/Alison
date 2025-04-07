using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agadir.Demo
{
	public partial class AgadirDemoSettingsDialog : Form
	{
		public AgadirDemoSettingsDialog()
		{
			InitializeComponent();
		}

		private void OnOk(object sender, EventArgs e)
		{
			this.Close();
		}

		private void OnCancel(object sender, EventArgs e)
		{

		}

		public AgadirDemoSettings Settings
		{
			get
			{
				try
				{
					return this._pgSettings.SelectedObject as AgadirDemoSettings;
				}
				catch (Exception)
				{
					return null;
				}
			}

			set
			{
				this._pgSettings.SelectedObject = value;
			}
		}
	}
}
