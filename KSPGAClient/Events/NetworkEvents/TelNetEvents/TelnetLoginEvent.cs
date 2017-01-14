using Eventing.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSPGAClient.Events.NetworkEvents.TelNetEvents {
	class TelnetLoginEvent : IEvent {
		public string Status { get; set; }
		public string Hostname { get; set; }
		public string Port { get; set; }
		public string User { get; set; }
		public string Password { get; set; }
	}
}
