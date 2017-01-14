using Eventing.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSPGAClient.Events {
	class ProgramStatusEvent : IEvent {
		public string Message { get; set; }
	}
}
