using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemesterPlan
{
    /// <summary>
    /// Handles all server functionality.
    /// </summary>
    class Server
    {
        // List of user and plans
        private List<User> userList;
        private List<Plan> planList;

        // Reference to communications module object
        private CommunicationModule comModule;

        /// <summary>
        /// Gets or sets the communications module.
        /// </summary>
        public CommunicationModule ComModule
        {
            get { return comModule; }
            set { comModule = value; }
        }

        /// <summary>
        /// Server object constructor.
        /// </summary>
        public Server()
        {
            // Create lists
            userList = new List<User>();
            planList = new List<Plan>();

            // Hard coded user for testing
            userList.Add(new User("Sigurd", "1234", 0));
        }

        /// <summary>
        /// Searches through the user list to authenticate user credentials.
        /// </summary>
        /// <param name="userName">User name</param>
        /// <param name="password">Password</param>
        /// <returns>Information on the user if succesful, returns null if unsuccesful</returns>
        public User AuthenticateCredentials(string userName, string password)
        {
            // Loop through all users in the user list
            foreach (User curUser in userList)
            {
                // Check for matching user name
                if (curUser.UserName == userName)
                {
                    // Check for matching password
                    if (curUser.Password == password)
                    {
                        // If match was found return the user information
                        return curUser;
                    }
                }
            }

            // User not found
            return null;
        }
    }
}
