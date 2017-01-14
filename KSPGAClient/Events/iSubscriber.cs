using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSPGAClient.Events {
	interface iSubscriber {
		void subscribe( EventArgs e );
	}
}
