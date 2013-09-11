using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SemesterPlan
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        // Reference to the client object
        private Client client;

        /// <summary>
        /// Login window constructor.
        /// </summary>
        public LoginWindow()
        {
            InitializeComponent();

            client = new Client(this);

            txtUserName.Text = "";
            txtPassword.Text = "";
        }

        /// <summary>
        /// Click event for the login button.
        /// </summary>
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            string userName = txtUserName.Text;
            string password = txtPassword.Text;

            // Sends login request to the client object
            client.AttemptLogin(userName, password);
        }
    }
}
