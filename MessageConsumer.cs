using CoreDto;
using MassTransit;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace ornek1
{
    public class MessageConsumer : IConsumer<MyMessage>
    {
        readonly ILogger<MessageConsumer> _logger;

        public MessageConsumer(ILogger<MessageConsumer> logger)
        {
            _logger = logger;
        }

        public Task Consume(ConsumeContext<MyMessage> context)
        {
            _logger.LogInformation($"--->Saat: {context.Message.Text}");
            return Task.CompletedTask;
        }
    }

}