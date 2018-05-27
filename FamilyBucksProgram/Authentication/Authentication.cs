namespace FamilyBucksProgram {
    public interface Authentication {
        Credentials GetEmptyCredentials();
        bool IsValidFor(Credentials credentials);
    }
}
