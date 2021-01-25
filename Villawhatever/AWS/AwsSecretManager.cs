using Amazon;
using Amazon.SecretsManager;
using Amazon.SecretsManager.Model;
using System;
using System.Text.Json;
using System.Threading.Tasks;

namespace Villawhatever.AWS
{
    public static class AwsSecretManager
    {
        public static async Task<SecretInfo> GetSecret()
        {
            var client = new AmazonSecretsManagerClient(RegionEndpoint.USEast2);
            SecretInfo info = null;
            var request = new GetSecretValueRequest
            {
                SecretId = "villablog-db"
            };

            try
            {
                var response = await client.GetSecretValueAsync(request);
                if (response.SecretString != null)
                {
                    var options = new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    };
                    info = JsonSerializer.Deserialize<SecretInfo>(response.SecretString, options);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"{ex} {ex.Message} {ex.StackTrace}");
                throw;
            }
            return info;
        }
    }
}
