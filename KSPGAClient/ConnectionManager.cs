using System;
using System.Net;

using MinimalisticTelnet;
using KSPGAClient.Events;
using KSPGAClient.Events.NetworkEvents.TelNetEvents;

namespace KSPGAClient {
	public class ConnectionManager {
		//handles creating a new connection to either the Master Node, or the KOS telnet server.  

		public ConnectionManager( ) {
			ExtEventManager.GetInstance( ).StartReceiving<TelnetLoginEvent>( @event => generateTelnetConn( @event ) );
			
		}

		private TelnetConnection tc;


		private void generateTelnetConn( TelnetLoginEvent @event ) {
			string connectionHostName = @event.Hostname;
			int port = int.Parse(@event.Port);
			string user = @event.User;
			string password = @event.Password;
			tc = new TelnetConnection( connectionHostName, port );
		}



		
	}
}