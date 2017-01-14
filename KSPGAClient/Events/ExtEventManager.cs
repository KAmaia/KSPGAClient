using Eventing.Library.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eventing.Library;

namespace KSPGAClient.Events {
	class ExtEventManager : EventManager {
		private static ExtEventManager instance = null;

		public static ExtEventManager GetInstance( ) {
			if ( instance == null ) {
				instance = new ExtEventManager( new MessageBus( ) );
			}
			return instance;
		}

		private ExtEventManager( IMessageBus messageBus ) : base( messageBus ) {

		}
	}
}
