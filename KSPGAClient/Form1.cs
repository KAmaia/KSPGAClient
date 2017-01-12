using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KSPGAClient {
	public partial class Form1 : Form {
		public Form1( ClientController clientController ) {
			InitializeComponent( );
		}

		private void toolStripStatusLabel1_Click( object sender, EventArgs e ) {

		}
		public delegate void updateConnectionStatus( string status );

		private void Form1_Load( object sender, EventArgs e ) {
			ts_TelnetStatus.ForeColor = Color.Red;
			ts_TelnetStatus.Text = "TELNET STATUS: DISCONNECTED";
		}
	}
}
