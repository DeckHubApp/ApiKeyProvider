namespace Slidable.ApiKeyProvider
{
    public interface IApiKeyProvider
    {
        string GetBase64(string userHandle);
        bool CheckBase64(string userHandle, string hash);
    }
}
