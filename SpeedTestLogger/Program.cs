using System;
using SpeedTest;
using SpeedTest.Models;
using System.Globalization;
using SpeedTestLogger.Models;

namespace SpeedTestLogger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello SpeedTestLogger!");

            var config = new LoggerConfiguration();
            var runner = new SpeedTestRunner(config.LoggerLocation);
            //runner.RunSpeedTest();

            var testData = runner.RunSpeedTest();
            var results = new TestResult
            {
                SessionId = new Guid(),
                User = "cloud-101-testuser",
                Device = 1,
                Timestamp = DateTimeOffset.Now.ToUnixTimeMilliseconds(),
                Data = testData
            };
        }

    }
}
