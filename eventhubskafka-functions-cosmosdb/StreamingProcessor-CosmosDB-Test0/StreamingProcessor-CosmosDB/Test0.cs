using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.Text;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using Microsoft.Azure.WebJobs.Extensions.Kafka;

namespace StreamingProcessor
{
    public static class Test0
    {
        /*
         * Cosmos DB output using Azure Function binding
         */
        [FunctionName("Test0")]
        public static async Task RunAsync(
            [KafkaTrigger("ehkafkafn", "default",
            ConsumerGroup = "azfunc",
            EventHubConnectionString = "Endpoint=sb://ehkafkafn.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=n2M0bWQ7JpmFtwG7zvBhKF7w1jKkLkgDkuqrhyuZP7U=")

            ] KafkaEventData kafkaEvent,
            //[CosmosDB(databaseName: "%CosmosDBDatabaseName%", collectionName: "%CosmosDBCollectionName%", ConnectionStringSetting = "CosmosDBConnectionString")] IAsyncCollector<JObject> cosmosMessage,
            ILogger log)
        {
            log.LogInformation(kafkaEvent.Value.ToString());

            //foreach (var data in eventHubData)
            //    KafkaEventData
            //    try
            //    {
            //        string message = Encoding.UTF8.GetString(data.Body.Array);

            //        var document = JObject.Parse(message);
            //        document["id"] = document["eventId"];
            //        document["enqueuedAt"] = data.SystemProperties.EnqueuedTimeUtc;
            //        document["processedAt"] = DateTime.UtcNow;

            //        tasks.Add(cosmosMessage.AddAsync(document));
            //    }
            //    catch (Exception ex)
            //    {
            //        log.LogError($"{ex} - {ex.Message}");
            //    }
            //}

            //await Task.WhenAll(tasks);

            //sw.Stop();

            //string logMessage = $"[Test0] T:{eventHubData.Length} doc - E:{sw.ElapsedMilliseconds} msec";
            //if (eventHubData.Length > 0)
            //{
            //    logMessage += Environment.NewLine + $"AVG:{(sw.ElapsedMilliseconds / eventHubData.Length):N3} msec";
            //}

            //log.LogInformation(logMessage);
        }
    }
}
