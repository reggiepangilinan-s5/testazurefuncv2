using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace TestAzureFuncV2Console2
{
    public static class ServiceBusTopicTest
    {
        [FunctionName("ServiceBusTopicTest")]
        public static void Run([ServiceBusTrigger("vmi-update-pf-aggregate-order", "DefaultSubscription", Connection = "AzureWebJobsStorage")]string mySbMsg, ILogger log)
        {
            log.LogInformation($"C# ServiceBus topic trigger function processed message: {mySbMsg}");
        }
    }
}
