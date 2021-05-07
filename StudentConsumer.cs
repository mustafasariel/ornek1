using CoreDto;
using MassTransit;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace ornek1
{
    public class StudentConsumer : IConsumer<Student>
    {
        readonly ILogger<StudentConsumer> _logger;

        public StudentConsumer(ILogger<StudentConsumer> logger)
        {
            _logger = logger;
        }

        public Task Consume(ConsumeContext<Student> context)
        {
            _logger.LogInformation($"==================  > Student {context.Message.ToString()}");
            return Task.CompletedTask;
        }
    }

}