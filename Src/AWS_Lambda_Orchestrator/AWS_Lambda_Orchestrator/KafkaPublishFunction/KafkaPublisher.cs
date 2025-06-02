using Confluent.Kafka;
using System.Text.Json;

namespace KafkaPublishFunction
{
    public class KafkaPublisher
    {
        private const string KafkaBroker = "localhost:9092";
        private const string KafkaTopic = "durable-function-output";

        public async Task PublishAsync(List<string> messages)
        {
            var config = new ProducerConfig { BootstrapServers = KafkaBroker };
            using var producer = new ProducerBuilder<Null, string>(config).Build();

            string payload = JsonSerializer.Serialize(messages);

            var result = await producer.ProduceAsync(KafkaTopic, new Message<Null, string> { Value = payload });

            Console.WriteLine($"Message sent to Kafka: {result.Value}");
        }
    }
}
