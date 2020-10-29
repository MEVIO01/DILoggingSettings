using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DILoggingSettings
{
    class MeetingService : IMeetingService
    {
        private readonly ILogger<MeetingService> logger;
        private readonly IConfiguration configuration;
        public MeetingService(ILogger<MeetingService> logger, IConfiguration configuration)
        {
            this.logger = logger;
            this.configuration = configuration;
        }
        public void Run()
        {
            for (int i = 0; i < this.configuration.GetValue<int>("LoopTimes"); i++)
            {
                this.logger.LogInformation("Running {runNumber}", i);
            }
        }
    }
}
