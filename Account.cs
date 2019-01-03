using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftAssurance
{
    public class Account
    {
        private string Name;
        private DateTime CreatedOn;
        private DateTime ModifiedOn;
        private string CreatedBy;
        private string ModifiedBy;
        private string Website;
        private string State;

        public List<Contact> Contacts
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public List<Address> Addresses
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public List<Opportunity> Opportunities
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public void CreateOpportunity()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateOpportunity()
        {
            throw new System.NotImplementedException();
        }

        public void AddAddress()
        {
            throw new System.NotImplementedException();
        }

        public void RemoveAddress()
        {
            throw new System.NotImplementedException();
        }

        public void AddContact(Contact contact)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateContact()
        {
            throw new System.NotImplementedException();
        }
    }
}