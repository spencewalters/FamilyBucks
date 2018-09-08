namespace FamilyBucksProgram {
    public interface Authentication {
        void SetUsers(UserRecords _users);
        Credentials GetEmptyCredentials();
        bool IsValidFor(Credentials credentials);
    }
}
