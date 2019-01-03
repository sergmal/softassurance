using System;
using SoftAssurance;

namespace SoftAssurance2
{
    internal class OpportunityManager
    {
        private Account account;
        private Contact contact;
        private string description;
        public Guid opportunity_id;

        public OpportunityManager()
        {
        }


        internal Opportunity CreateOpportunity(Account account, Contact contact, string description)
        {
            this.account = account;
            this.contact = contact;
            this.description = description;
            this.opportunity_id = new Guid();
            Opportunity opportunity = new Opportunity(opportunity_id, account, contact, description);
            return opportunity;
        }

        internal Opportunity UpdateOpportunity(Opportunity opportunity, Account account, Contact contact, string description, string statusreason, string state)
        {
            opportunity.Account = account;
            opportunity.Contact = contact;
            opportunity.Description = description;
            opportunity.StatusReason = statusreason;
            opportunity.State = state;
            return opportunity;
        }
    }
}