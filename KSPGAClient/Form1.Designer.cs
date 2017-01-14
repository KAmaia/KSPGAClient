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

		#region	Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent( ) {
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.ts_TelnetStatus = new System.Windows.Forms.ToolStripStatusLabel();
			this.gbx_controls = new System.Windows.Forms.GroupBox();
			this.lbl_hostName = new System.Windows.Forms.Label();
			this.txt_Hostname = new System.Windows.Forms.TextBox();
			this.ts_ProgramStatus = new System.Windows.Forms.ToolStripStatusLabel();
			this.label1 = new System.Windows.Forms.Label();
			this.txt_port = new System.Windows.Forms.TextBox();
			this.btn_login = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.txt_user = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txt_pass = new System.Windows.Forms.TextBox();
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
            this.ts_TelnetStatus,
            this.ts_ProgramStatus});
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
			// 
			// gbx_controls
			// 
			this.gbx_controls.Controls.Add(this.label3);
			this.gbx_controls.Controls.Add(this.txt_pass);
			this.gbx_controls.Controls.Add(this.label2);
			this.gbx_controls.Controls.Add(this.txt_user);
			this.gbx_controls.Controls.Add(this.btn_login);
			this.gbx_controls.Controls.Add(this.label1);
			this.gbx_controls.Controls.Add(this.txt_port);
			this.gbx_controls.Controls.Add(this.lbl_hostName);
			this.gbx_controls.Controls.Add(this.txt_Hostname);
			this.gbx_controls.Location = new System.Drawing.Point(429, 11);
			this.gbx_controls.Name = "gbx_controls";
			this.gbx_controls.Size = new System.Drawing.Size(182, 385);
			this.gbx_controls.TabIndex = 2;
			this.gbx_controls.TabStop = false;
			// 
			// lbl_hostName
			// 
			this.lbl_hostName.AutoSize = true;
			this.lbl_hostName.Location = new System.Drawing.Point(26, 16);
			this.lbl_hostName.Name = "lbl_hostName";
			this.lbl_hostName.Size = new System.Drawing.Size(129, 13);
			this.lbl_hostName.TabIndex = 1;
			this.lbl_hostName.Text = "Host Name or IP Address:";
			// 
			// txt_Hostname
			// 
			this.txt_Hostname.Location = new System.Drawing.Point(6, 36);
			this.txt_Hostname.Name = "txt_Hostname";
			this.txt_Hostname.Size = new System.Drawing.Size(163, 20);
			this.txt_Hostname.TabIndex = 0;
			// 
			// ts_ProgramStatus
			// 
			this.ts_ProgramStatus.Name = "ts_ProgramStatus";
			this.ts_ProgramStatus.Size = new System.Drawing.Size(0, 17);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(77, 62);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(29, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Port:";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// txt_port
			// 
			this.txt_port.Location = new System.Drawing.Point(112, 59);
			this.txt_port.Name = "txt_port";
			this.txt_port.Size = new System.Drawing.Size(57, 20);
			this.txt_port.TabIndex = 2;
			this.txt_port.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
			// 
			// btn_login
			// 
			this.btn_login.Location = new System.Drawing.Point(94, 145);
			this.btn_login.Name = "btn_login";
			this.btn_login.Size = new System.Drawing.Size(75, 31);
			this.btn_login.TabIndex = 4;
			this.btn_login.Text = "Login";
			this.btn_login.UseVisualStyleBackColor = true;
			this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 86);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(57, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "UserName";
			// 
			// txt_user
			// 
			this.txt_user.Location = new System.Drawing.Point(69, 83);
			this.txt_user.Name = "txt_user";
			this.txt_user.Size = new System.Drawing.Size(100, 20);
			this.txt_user.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 113);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(53, 13);
			this.label3.TabIndex = 8;
			this.label3.Text = "Password";
			// 
			// txt_pass
			// 
			this.txt_pass.Location = new System.Drawing.Point(69, 110);
			this.txt_pass.Name = "txt_pass";
			this.txt_pass.PasswordChar = '*';
			this.txt_pass.Size = new System.Drawing.Size(100, 20);
			this.txt_pass.TabIndex = 7;
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
		private System.Windows.Forms.TextBox txt_Hostname;
		private System.Windows.Forms.ToolStripStatusLabel ts_ProgramStatus;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txt_port;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txt_pass;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txt_user;
		private System.Windows.Forms.Button btn_login;
	}
}

