using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSPGAClient.Events {
	class EventManager {
		private Dictionary<EventArgs, List<iSubscriber>> subscribers;

		public void subscribe( object sender, EventArgs e ) {

		}
	}
}
