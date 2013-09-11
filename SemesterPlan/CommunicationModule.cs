using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemesterPlan
{
    /// <summary>
    /// Base class for communications modules.
    /// </summary>
    abstract class CommunicationModule
    {
        // Attempts to log a user in through a client
        public abstract void AttemptLogin(string userName, string password);
    }
}
