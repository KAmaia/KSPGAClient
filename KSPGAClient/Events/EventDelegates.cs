using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSPGAClient.Events {
	class EventDelegates {
		public delegate void ConnectionStatusUpdateHandler( object sender, ConnectionStatusUpdateEventArgs e );
	}
}
