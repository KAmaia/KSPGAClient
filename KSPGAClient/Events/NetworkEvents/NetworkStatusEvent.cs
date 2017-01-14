using Eventing.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using KSPGAClient.Utils;

namespace KSPGAClient.Events {
	class NetworkStatusEvent : IEvent {
		public NETWORKTYPE NetworkType { get; set; }
		public string Status { get; set; }
	}

}
