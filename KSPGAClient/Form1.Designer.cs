namespace KSPGAClient {
	partial class Form1 {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing ) {
			if ( disposing && ( components != null ) ) {
				components.Dispose( );
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent( ) {
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.ts_TelnetStatus = new System.Windows.Forms.ToolStripStatusLabel();
			this.gbx_controls = new System.Windows.Forms.GroupBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.lbl_hostName = new System.Windows.Forms.Label();
			this.statusStrip1.SuspendLayout();
			this.gbx_controls.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(12, 11);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(404, 386);
			this.textBox1.TabIndex = 0;
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_TelnetStatus});
			this.statusStrip1.Location = new System.Drawing.Point(0, 419);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(624, 22);
			this.statusStrip1.TabIndex = 1;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// ts_TelnetStatus
			// 
			this.ts_TelnetStatus.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
			this.ts_TelnetStatus.Name = "ts_TelnetStatus";
			this.ts_TelnetStatus.Size = new System.Drawing.Size(42, 17);
			this.ts_TelnetStatus.Text = "Telnet:";
			this.ts_TelnetStatus.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
			// 
			// gbx_controls
			// 
			this.gbx_controls.Controls.Add(this.lbl_hostName);
			this.gbx_controls.Controls.Add(this.textBox2);
			this.gbx_controls.Location = new System.Drawing.Point(429, 11);
			this.gbx_controls.Name = "gbx_controls";
			this.gbx_controls.Size = new System.Drawing.Size(182, 385);
			this.gbx_controls.TabIndex = 2;
			this.gbx_controls.TabStop = false;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(6, 36);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(163, 20);
			this.textBox2.TabIndex = 0;
			// 
			// lbl_hostName
			// 
			this.lbl_hostName.AutoSize = true;
			this.lbl_hostName.Location = new System.Drawing.Point(36, 16);
			this.lbl_hostName.Name = "lbl_hostName";
			this.lbl_hostName.Size = new System.Drawing.Size(63, 13);
			this.lbl_hostName.TabIndex = 1;
			this.lbl_hostName.Text = "Host Name:";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(624, 441);
			this.Controls.Add(this.gbx_controls);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.textBox1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.gbx_controls.ResumeLayout(false);
			this.gbx_controls.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel ts_TelnetStatus;
		private System.Windows.Forms.GroupBox gbx_controls;
		private System.Windows.Forms.Label lbl_hostName;
		private System.Windows.Forms.TextBox textBox2;
	}
}

