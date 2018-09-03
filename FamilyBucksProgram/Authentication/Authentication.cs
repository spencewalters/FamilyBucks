namespace FamilyBucksProgram {
    public interface Authentication {
        Credentials GetEmptyCredentials();
        void SetActualCredentials(Credentials actual);
        bool IsValidFor(Credentials credentials);
    }
}
