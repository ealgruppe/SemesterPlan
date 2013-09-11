using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SemesterPlan
{
    /// <summary>
    /// Client class handling all client side functionality.
    /// </summary>
    class Client
    {
        // Info on the user currently logged in
        private User userInfo;
        // Reference to the communications module associated with the client
        private CommunicationModule comModule;

        // References to the 3 main program windows
        private LoginWindow loginWindow;
        private BrowseWindow browseWindow;
        private PlanWindow planWindow;

        /// <summary>
        /// Gets or sets the info on the user currently logged in.
        /// </summary>
        public User UserInfo
        {
            get { return userInfo; }
            set { userInfo = value; }
        }

        /// <summary>
        /// Constructor fo the client class. Creates the server and communications modules.
        /// </summary>
        /// <param name="loginWindow">Reference to the login window</param>
        public Client(LoginWindow loginWindow)
        {
            this.loginWindow = loginWindow;

            Server server = new Server();
            comModule = new DirectCommunicationModule(server, this);
        }

        /// <summary>
        /// Sends a login request to the communications module.
        /// </summary>
        /// <param name="userName">User name</param>
        /// <param name="password">User password</param>
        public void AttemptLogin(string userName, string password)
        {
            comModule.AttemptLogin(userName, password);

            // Check if any user info was returned
            if (userInfo == null)
            {
                // No user info - Login attempt was unsuccesful
                MessageBox.Show("User info not found by server.");
            }
            else
            {
                // User info found - Loggin attempt was succesful
                MessageBox.Show("Du er logget ind som: " + userInfo.UserName);
                loginWindow.Hide();

                // Create and show the browse window
                browseWindow = new BrowseWindow();
                browseWindow.Show();
            }
        }
    }
}
