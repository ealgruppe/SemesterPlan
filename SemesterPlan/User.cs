using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemesterPlan
{
    /// <summary>
    /// Contains information related to a specific user.
    /// </summary>
    class User
    {
        // User name, password and unique ID
        private string userName;
        private string password;
        private int id;

        /// <summary>
        /// Gets the user name.
        /// </summary>
        public string UserName
        {
            get { return userName; }
        }

        /// <summary>
        /// Gets the password.
        /// </summary>
        public string Password
        {
            get { return password; }
        }

        /// <summary>
        /// Gets the unique user ID.
        /// </summary>
        public int ID
        {
            get { return id; }
        }

        /// <summary>
        /// Constructor for the user class.
        /// </summary>
        /// <param name="userName">User name</param>
        /// <param name="password">Password</param>
        /// <param name="id">Unique ID</param>
        public User(string userName, string password, int id)
        {
            this.userName = userName;
            this.password = password;
            this.id = id;
        }
    }
}
