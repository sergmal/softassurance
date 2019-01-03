using NUnit.Framework;
using SoftAssurance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftAssurance2.Tests
{
    [TestFixture]
    class UnitTests
    {
        [Test]
        public void TestCreateOpportunity()
        {
            var opportunityManager = new DashboardManager();
            var account = new Account();
            var contact = new Contact();
            Opportunity opportunity = opportunityManager.CreateOpportunity(account, contact, "test opportunity");
            Assert.IsNotNull(opportunity.Account);
            Assert.IsNotNull(opportunity.Contact);
            Assert.IsNotNull(opportunity.Description);
            Assert.AreEqual("Active", opportunity.StatusReason);
            Assert.AreEqual("Open", opportunity.State);
        }

        [Test]
        public void TestCloseOpportunity()
        {
            var opportunityManager = new DashboardManager();
            var account = new Account();
            var contact = new Contact();
            var description = "test description";
            Opportunity opportunity = opportunityManager.CreateOpportunity(account, contact, description);
            opportunity = opportunityManager.CloseOpportunity(opportunity, account, contact, description, StatusReason.Lost);
            Assert.AreEqual("Lost", opportunity.StatusReason);
            Assert.AreEqual("Closed", opportunity.State);
        }

        [Test]
        public void TestUpdateOpportunity()
        {
            var opportunityManager = new DashboardManager();
            var account = new Account();
            var contact = new Contact();
            var description = "test description";
            Opportunity opportunity = opportunityManager.CreateOpportunity(account, contact, description);
            opportunity = opportunityManager.UpdateOpportunity(opportunity, account, contact, description, StatusReason.Awarded);
            Assert.AreEqual("Awarded", opportunity.StatusReason);
            Assert.AreEqual("Open", opportunity.State);
        }
    }
}
