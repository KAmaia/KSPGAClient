using KSPGAClient.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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
			cm.connectionStatusUpdateEvent += new ConnectionStatusUpdateHandler( MainForm.updateConnStatus );
			Application.Run( MainForm );
		}

		private static void registerEvents( ) {

		}
	}
}
