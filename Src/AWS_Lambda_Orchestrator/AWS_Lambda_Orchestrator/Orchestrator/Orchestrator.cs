using SayHelloFunction;
using KafkaPublishFunction;

namespace Orchestrator
{
    public class Workflow
    {
        public async Task Run()
        {
            var greeter = new SayHelloHandler();

            var tasks = new[]
            {
                Task.Run(() => greeter.Handle("Tokyo")),
                Task.Run(() => greeter.Handle("Seattle")),
                Task.Run(() => greeter.Handle("London"))
            };

            var results = (await Task.WhenAll(tasks)).ToList();

            var kafka = new KafkaPublisher();
            await kafka.PublishAsync(results);
        }
    }
}
