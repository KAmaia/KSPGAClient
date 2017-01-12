using System;
using System.Net;

using MinimalisticTelnet;
using KSPGAClient.Events;

namespace KSPGAClient {
	internal class ConnectionManager {
		public static event ConnectionStatusUpdateHandler connectionStatusUpdateEvent;
		
		
		//handles creating a new connection to either the Master Node, or the KOS telnet server.  

		private TelnetConnection tc;

		private TelnetConnection generateTelnetConn(string hostAddr, int port ) {
			return new TelnetConnection( hostAddr, port );
		}



		public void createConnection(CONNECTIONTYPE type,  string hostname, int port ) {
			switch ( type ) {
				case CONNECTIONTYPE.MASTERNODE:
					break;
				case CONNECTIONTYPE.TELNET:
					//create telnet connection here.
					tc = generateTelnetConn( hostname, port );
					connectionStatusUpdateEvent( this, new Events.ConnectionStatusUpdateEventArgs( CONNECTIONSTATUS.CONNECTED ) );
					break;
			}
		}
	}
}