namespace Alison.Demo
{
	partial class AlisonDemoSettingsDialog
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlisonDemoSettingsDialog));
			this._btOk = new System.Windows.Forms.Button();
			this._btCancel = new System.Windows.Forms.Button();
			this._pgSettings = new System.Windows.Forms.PropertyGrid();
			this.SuspendLayout();
			// 
			// _btOk
			// 
			this._btOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this._btOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this._btOk.Location = new System.Drawing.Point(12, 311);
			this._btOk.Margin = new System.Windows.Forms.Padding(0);
			this._btOk.Name = "_btOk";
			this._btOk.Size = new System.Drawing.Size(80, 25);
			this._btOk.TabIndex = 0;
			this._btOk.Text = "OK";
			this._btOk.UseVisualStyleBackColor = true;
			this._btOk.Click += new System.EventHandler(this.OnOk);
			// 
			// _btCancel
			// 
			this._btCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this._btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this._btCancel.Location = new System.Drawing.Point(108, 311);
			this._btCancel.Margin = new System.Windows.Forms.Padding(0);
			this._btCancel.Name = "_btCancel";
			this._btCancel.Size = new System.Drawing.Size(80, 25);
			this._btCancel.TabIndex = 1;
			this._btCancel.Text = "Cancel";
			this._btCancel.UseVisualStyleBackColor = true;
			this._btCancel.Click += new System.EventHandler(this.OnCancel);
			// 
			// _pgSettings
			// 
			this._pgSettings.Dock = System.Windows.Forms.DockStyle.Top;
			this._pgSettings.Location = new System.Drawing.Point(0, 0);
			this._pgSettings.Name = "_pgSettings";
			this._pgSettings.Size = new System.Drawing.Size(467, 283);
			this._pgSettings.TabIndex = 2;
			// 
			// AlisonDemoSettingsDialog
			// 
			this.AcceptButton = this._btOk;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this._btCancel;
			this.ClientSize = new System.Drawing.Size(467, 346);
			this.Controls.Add(this._pgSettings);
			this.Controls.Add(this._btCancel);
			this.Controls.Add(this._btOk);
			this.Font = new System.Drawing.Font("Consolas", 10F);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "AlisonDemoSettingsDialog";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Alison Demo Settings";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button _btOk;
		private System.Windows.Forms.Button _btCancel;
		private System.Windows.Forms.PropertyGrid _pgSettings;
	}
}