namespace BackendChallenge.API.Services
{
    public interface IPasswordService
    {
        bool IsValidPassword(string password);

        bool HasMinLength(string password);

        bool HasWhiteSpace(string password);

        bool HasUpperCase(string password);

        bool HasLowerCase(string password);

        bool HasNumber(string password);

        bool HasSpecialChar(string password);
    }
}
