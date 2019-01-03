using SoftAssurance;
using System.Diagnostics.Contracts;

namespace SoftAssurance2
{
    class LoginManager
    {
        public string ValidAddress { get; private set; }
        public Security ValidRoles { get; private set; }

        public DashboardManager Login(User account, Security role, string ip_address)
        {
            Contract.Requires(account != null);
            Contract.Requires(account.Status == StatusReason.Active);
            Contract.Requires(ip_address == ValidAddress);
            Contract.Ensures(((DashboardManager)this).Status != null);

            return new DashboardManager();

        }
    }


}
