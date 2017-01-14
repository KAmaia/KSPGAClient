using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using KSPGAClient.Utils;

using KSPGAClient.Events;
using KSPGAClient.Events.NetworkEvents.TelNetEvents;

namespace KSPGAClient {
	public partial class Form1 : Form {

		public Form1( ) {

			InitializeComponent( );
			ExtEventManager.GetInstance( ).StartReceiving<ProgramStatusEvent>(@event=> this.updateProgramStatus(@event));
			ExtEventManager.GetInstance( ).StartReceiving<NetworkStatusEvent>(@event=> this.updateConnStatus(@event));

		}

		private void updateProgramStatus( ProgramStatusEvent @event ) {
			ts_ProgramStatus.Text = "Program Status: " + @event.Message;
		}

		private void updateConnStatus( NetworkStatusEvent @event ) {
			switch ( @event.NetworkType ) {
				case NETWORKTYPE.TELNET:
					ts_TelnetStatus.Text = "TELNET STATUS: " + @event.Status;
					break;
				case NETWORKTYPE.OTHER:
					break;
			}
		}


		private void Form1_Load( object sender, EventArgs e ) {
			ts_TelnetStatus.ForeColor = Color.Red;
			ts_TelnetStatus.Text = "TELNET STATUS: DISCONNECTED";
		}

		private void label1_Click( object sender, EventArgs e ) {

		}

		private void textBox3_TextChanged( object sender, EventArgs e ) {

		}

		private void btn_login_Click( object sender, EventArgs e ) {
			ExtEventManager.GetInstance( ).RaiseEvent( new TelnetLoginEvent {
				Hostname = txt_Hostname.Text,
				Port = txt_port.Text,
				User = txt_user.Text,
				Password = txt_pass.Text
			} );
		}
	}
}
