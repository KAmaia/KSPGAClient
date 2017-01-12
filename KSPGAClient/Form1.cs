using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using KSPGAClient.Events;

namespace KSPGAClient {
	public partial class Form1 : Form {

		


		public Form1(  ) {
			InitializeComponent( );
		}

		private void updateConnStatus(object sender, ConnectionStatusUpdateEventArgs e ) {
			switch ( e.Status ) {
				case CONNECTIONSTATUS.CONNECTED:
					ts_TelnetStatus.ForeColor = Color.Green;
					ts_TelnetStatus.Text = "Telnet: Connected!";
					break;
				case CONNECTIONSTATUS.DISCONNECTED:
				
				case CONNECTIONSTATUS.NULL:
					ts_TelnetStatus.ForeColor = Color.Red;
					ts_TelnetStatus.Text = "Telnet: Disconnected!";
					break;	
				}

		private void toolStripStatusLabel1_Click( object sender, EventArgs e ) {

		}

		private void Form1_Load( object sender, EventArgs e ) {
			ts_TelnetStatus.ForeColor = Color.Red;
			ts_TelnetStatus.Text = "TELNET STATUS: DISCONNECTED";
		}
	}
}
