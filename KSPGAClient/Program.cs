using Eventing.Library.Impl;
using System.Threading;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using KSPGAClient.Events;

namespace KSPGAClient {
	static class Program {
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main( ) {
			Application.EnableVisualStyles( );
			Application.SetCompatibleTextRenderingDefault( false );
			ConnectionManager cm = new ConnectionManager();
			Form1 MainForm = new Form1();

			var synchContext = new SingleThreadSynchronizationContext("Client");
			SynchronizationContext.SetSynchronizationContext( synchContext );

			ExtEventManager.GetInstance( ).RaiseEvent( new ProgramStatusEvent { Message = "Program Starting Up" } );
			
			Application.Run( MainForm );
		}

		private static void registerEvents( ) {

		}
	}
}
