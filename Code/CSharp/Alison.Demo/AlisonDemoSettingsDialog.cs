using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alison.Demo
{
	public partial class AlisonDemoSettingsDialog : Form
	{
		public AlisonDemoSettingsDialog()
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

		public AlisonDemoSettings Settings
		{
			get
			{
				try
				{
					return this._pgSettings.SelectedObject as AlisonDemoSettings;
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
