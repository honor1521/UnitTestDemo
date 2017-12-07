namespace SecurityFramework.Interfaces
{
    public interface IThirdPartyAuthService
    {
        string DoAuthection(string userName, string password);
    }
}
