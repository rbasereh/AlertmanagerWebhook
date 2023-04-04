using AlertmanagerWebhook.Model;

namespace AlertmanagerWebhook.Service
{
    public interface IKavehNegarService
    {
        Task SendSms(AlertManagerModel request);
    }
}
