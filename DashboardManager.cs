using SoftAssurance;
using System.Diagnostics.Contracts;
using System;

namespace SoftAssurance2
{
    class DashboardManager
    {
        private Opportunity opportunity;

        public object Status { get; internal set; }

        public Opportunity CreateOpportunity(Account account, Contact contact, string description)
        {
            Contract.Requires(account != null);
            Contract.Requires(account != null);
            Contract.Requires(description != null);
            Contract.Requires(description.Length < 2000);
            Contract.Ensures(opportunity.Description.Equals(description));
            Contract.Ensures(opportunity.StatusReason.Equals(StatusReason.Active));
            Contract.Ensures(opportunity.State.Equals(State.Open));

            OpportunityManager opportunityManager = new OpportunityManager();
            opportunity = opportunityManager.CreateOpportunity(account, contact, description);
            opportunity = opportunityManager.UpdateOpportunity(opportunity, account, contact, description, StatusReason.Active, State.Open);

            return opportunity;

        }

        internal Opportunity CloseOpportunity(Opportunity opportunityid, Account account, Contact contact, string description, string statusreason)
        {
            Contract.Requires(account != null);
            Contract.Requires(account != null);
            Contract.Requires(description != null);
            Contract.Requires(description.Length < 2000);
            Contract.Ensures(opportunity.Description.Equals(description));
            Contract.Ensures(opportunity.StatusReason.Equals(statusreason));
            Contract.Ensures(opportunity.State.Equals(State.Closed));

            OpportunityManager opportunityManager = new OpportunityManager();
            opportunity = opportunityManager.UpdateOpportunity(opportunityid, account, contact, description, statusreason, State.Closed);

            return opportunity;
        }

        public Opportunity UpdateOpportunity(Opportunity opportunityid, Account account, Contact contact, string description, string statusreason)
        {
            Contract.Requires(account != null);
            Contract.Requires(account != null);
            Contract.Requires(description != null);
            Contract.Requires(description.Length < 2000);
            Contract.Ensures(opportunity.Description.Equals(description));
            Contract.Ensures(opportunity.StatusReason.Equals(statusreason));
            Contract.Ensures(!opportunity.State.Equals(State.Closed));

            OpportunityManager opportunityManager = new OpportunityManager();
            opportunity = opportunityManager.UpdateOpportunity(opportunityid, account, contact, description, statusreason, State.Open);

            return opportunity;
        }

        public static explicit operator DashboardManager(LoginManager v)
        {
            throw new NotImplementedException();
        }
    }


}
