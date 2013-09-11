using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemesterPlan
{
    class Plan
    {
        private int userID;
        private int id;
        private string title;
        private string subject;
        private DateTime date;
        private string text;

        public int UserID
        {
            get { return userID; }
        }
        
        public int ID
        {
            get { return id; }
        }
        
        public string Title
        {
            get { return title; }
        }
        
        public string Subject
        {
            get { return subject; }
        }

        public DateTime Date
        {
            get { return date; }
        }

        public string Text
        {
            get { return text; }
        }

        public Plan(int userID, int id, string title, string subject, string text)
        {
            this.userID = userID;
            this.id = id;
            this.title = title;
            this.subject = subject;
            this.text = text;
        }
    }
}
