using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSPGAClient.Events {
	public class ConnectionStatusUpdateEventArgs : EventArgs {
		private CONNECTIONSTATUS status;
		public ConnectionStatusUpdateEventArgs(CONNECTIONSTATUS _status ) {
			status = _status;
		}
		public CONNECTIONSTATUS Status { get { return status; } }
	}
}
