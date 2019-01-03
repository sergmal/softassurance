using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftAssurance
{
    public class Opportunity
    {
        private string Name;
        public string Description;
        private decimal Revenue;
        public string StatusReason {get; set;}
        private DateTime CreatedOn;
        private DateTime ModifiedOn;
        private string CreatedBy;
        private string ModifiedBy;
        public string State {get; set;}
        public Account Account { get; internal set; }
        public Contact Contact { get; internal set; }

        //public Account account;
        //public Contact contact;
        public Guid opportunity_id;

        public Opportunity(Account account, Contact contact, string description)
        {
            this.Account = account;
            this.Contact = contact;
            Description = description;
        }

        public Opportunity()
        {
        }

        public Opportunity(Guid opportunity_id, Account account, Contact contact, string description)
        {
            this.opportunity_id = opportunity_id;
            this.Account = account;
            this.Contact = contact;
            Description = description;
        }

        public void UpdateOpportunity()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateStatus()
        {
            throw new System.NotImplementedException();
        }
    }
}