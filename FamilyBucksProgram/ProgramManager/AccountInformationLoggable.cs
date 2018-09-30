using System.Text;

namespace FamilyBucksProgram {
    internal class AccountInformationLoggable {
        private AccountInformation accountInfo;

        public AccountInformationLoggable(AccountInformation accountInfo) {
            this.accountInfo = accountInfo;
        }

        public override string ToString() {
            StringBuilder builder = new StringBuilder();
            builder.Append($"\nAccountInfo Key-> {accountInfo.Key}");
            builder.Append($"\n    Balance-> {accountInfo.AccountBalance}");
            return builder.ToString();
        }
    }
}