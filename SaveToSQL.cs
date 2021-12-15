using IoTHubTrigger = Microsoft.Azure.WebJobs.EventHubTriggerAttribute;

using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Azure.EventHubs;
using System.Text;
using System.Net.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SaveToSqlDB.Models;

namespace SendDataToSqlDataBase
{
    public static class SaveToSQL
    {
        private static HttpClient client = new HttpClient();
        [FunctionName("SaveDataToSqlDataBase")]
        public static void Run([IoTHubTrigger("messages/events", Connection = "IOTHUB-2021")]EventData message, ILogger log)
        {
            log.LogInformation($"Message: {Encoding.UTF8.GetString(message.Body.Array)}");
            var msg = JsonConvert.DeserializeObject<DhtMeasurment>(Encoding.UTF8.GetString(message.Body.Array));
            using (var conn = new SqlConnection(Environment.GetEnvironmentVariable("SqlConnection"))){
                conn.Open();
                using (var cmd = new SqlCommand("", conn)){
                    cmd.CommandText = "INSERT INTO DhtMeasurements OUTPUT inserted.Id VALUES(@DeviceId, @Temperature, @Humidity, @epochTime)";
                    cmd.Parameters.AddWithValue("@DeviceId", msg.deviceId);
                    cmd.Parameters.AddWithValue("@Temperature", msg.temperature);
                    cmd.Parameters.AddWithValue("@Humidity", msg.humidity);
                    cmd.Parameters.AddWithValue("@epochTime", msg.epochTime);
                    cmd.ExecuteNonQuery();
                    return;
                }
            }
        }
    }
}