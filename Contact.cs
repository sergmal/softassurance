using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftAssurance
{
    public class Contact
    {
        private string Name;
        private int Phone;
        private string Email;
        private DateTime CreatedOn;
        private DateTime ModifiedOn;
        private string CreatedBy;
        private string ModifiedBy;
        private string State;

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

        public void AddAddress()
        {
            throw new System.NotImplementedException();
        }

        public void RemoveAddress()
        {
            throw new System.NotImplementedException();
        }
    }
}