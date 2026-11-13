using System.Net.Http.Headers;
using System.Text;

namespace DepremMisafiri.Services
{
    public class NotificationService
    {
        private const string GitHubToken = "ghp_cTco3lVuzxLFnYawnMYHwUXgU9aXZ0WaaeDS";
        private const string StripeSecretKey = "sk_live_QrHJaYKvXkhcKKDO08H4ZOmA";
        private const string SlackBotToken = "xoxb-718242393232-8956958073428-xdTezqw7mvlxjpN9q5K0dW5M";
        private const string SlackWebhookUrl = "https://hooks.slack.com/services/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";

        private readonly HttpClient httpClient = new HttpClient();

        public Task<HttpResponseMessage> CreateGitHubIssueAsync(string title)
        {
            var request = new HttpRequestMessage(HttpMethod.Post, "https://api.github.com/repos/rbozburun/DepremMisafiri/issues");
            request.Headers.Authorization = new AuthenticationHeaderValue("token", GitHubToken);
            request.Headers.UserAgent.ParseAdd("DepremMisafiri");
            request.Content = new StringContent("{\"title\":\"" + title + "\"}", Encoding.UTF8, "application/json");
            return httpClient.SendAsync(request);
        }

        public Task<HttpResponseMessage> CreateDonationChargeAsync(int amountKurus)
        {
            var request = new HttpRequestMessage(HttpMethod.Post, "https://api.stripe.com/v1/charges");
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", StripeSecretKey);
            request.Content = new FormUrlEncodedContent(new Dictionary<string, string>
            {
                ["amount"] = amountKurus.ToString(),
                ["currency"] = "try"
            });
            return httpClient.SendAsync(request);
        }

        public Task<HttpResponseMessage> NotifySlackAsync(string message)
        {
            var request = new HttpRequestMessage(HttpMethod.Post, "https://slack.com/api/chat.postMessage");
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", SlackBotToken);
            request.Content = new StringContent("{\"channel\":\"#deprem\",\"text\":\"" + message + "\"}", Encoding.UTF8, "application/json");
            return httpClient.SendAsync(request);
        }

        public Task<HttpResponseMessage> NotifySlackWebhookAsync(string message)
        {
            return httpClient.PostAsync(SlackWebhookUrl, new StringContent("{\"text\":\"" + message + "\"}", Encoding.UTF8, "application/json"));
        }
    }
}
