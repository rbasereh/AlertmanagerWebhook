using AlertmanagerWebhook.Model;

namespace AlertmanagerWebhook.Service
{
    public class KavehNegarService : IKavehNegarService
    {
        public KavehNegarService()
        {
            HttpClient = new HttpClient();
        }

        public HttpClient HttpClient { get; }

        public async Task SendSms(AlertManagerModel request)
        {
            var message = $"{request.Status} : {request.CommonAnnotations.Description}";
            var apiurl = $"https://api.kavenegar.com/v1/{AppSettings.APIKey}/sms/send.json?message={message}&receptor={AppSettings.Receptor}";
            var kavehNegarResponse = await HttpClient.PostAsync(apiurl, new StringContent(string.Empty));
            var content = await kavehNegarResponse.Content.ReadAsStringAsync();
            Console.WriteLine(content);
        }

    }
}
