using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemesterPlan
{
    /// <summary>
    /// Communications module for direct communication between client and server.
    /// </summary>
    class DirectCommunicationModule : CommunicationModule
    {
        // References to client and server objects
        private Client client;
        private Server server;

        /// <summary>
        /// Direct communications module constructor.
        /// </summary>
        /// <param name="server">Server object</param>
        /// <param name="client">Client object</param>
        public DirectCommunicationModule(Server server, Client client)
        {
            this.server = server;
            this.client = client;
        }

        /// <summary>
        /// Sends a request to the server to authenticate user credentials.
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        public override void AttemptLogin(string userName, string password)
        {
            client.UserInfo = server.AuthenticateCredentials(userName, password);
        }
    }
}
