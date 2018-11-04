using System;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace SpeedTestLogger.Models
{
    public class TestResult
    {
        // [Required]
        // [JsonProperty("guid")]
        // public Guid SessionId { get; set; }

        [Required]
        [StringLength(500, MinimumLength = 2)]
        [JsonProperty("user")]
        public string User { get; set; }

        [Range(1, int.MaxValue)]
        [Required]
        [JsonProperty("device")]
        public int Device { get; set; }

        [Range(0, long.MaxValue)]
        [Required]
        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }

        [Required]
        [JsonProperty("data")]
        public TestData Data { get; set; }
    }

    public class TestData
    {
        [Required]
        [JsonProperty("speeds")]
        public TestSpeeds Speeds { get; set; }

        [Required]
        [JsonProperty("client")]
        public TestClient Client { get; set; }

        [Required]
        [JsonProperty("server")]
        public TestServer Server { get; set; }
    }

    public class TestSpeeds
    {
        [Range(0, 3000)]
        [Required]
        [JsonProperty("download")]
        public double Download { get; set; }

        [Range(0, 3000)]
        [Required]
        [JsonProperty("upload")]
        public double Upload { get; set; }
    }

    public class TestClient
    {
        [RegularExpression(@"^(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$")]
        [Required]
        [JsonProperty("ip")]
        public string Ip { get; set; }

        [Range(-90, 90)]
        [JsonProperty("lat")]
        public double Latitude { get; set; }

        [Range(-180, 180)]
        [JsonProperty("lon")]
        public double Longitude { get; set; }

        [StringLength(500, MinimumLength = 2)]
        [Required]
        [JsonProperty("isp")]
        public string Isp { get; set; }

        [RegularExpression(@"^([A-Z]){2}$")]
        [Required]
        [JsonProperty("country")]
        public string Country { get; set; }
    }

    public class TestServer
    {
        [StringLength(500, MinimumLength = 2)]
        [Required]
        [JsonProperty("host")]
        public string Host { get; set; }

        [Range(-90, 90)]
        [Required]
        [JsonProperty("lat")]
        public double Latitude { get; set; }

        [Range(-180, 180)]
        [Required]
        [JsonProperty("lon")]
        public double Longitude { get; set; }

        [RegularExpression(@"^([A-Z]){2}$")]
        [Required]
        [JsonProperty("country")]
        public string Country { get; set; }

        [Range(0, 21000000)]
        [Required]
        [JsonProperty("distance")]
        //public double Distance { get; set; }
        public decimal Distance { get; set; }

        [Range(0, int.MaxValue)]
        [Required]
        [JsonProperty("ping")]
        public int Ping { get; set; }

        [Range(0, int.MaxValue)]
        [Required]
        [JsonProperty("id")]
        public int Id { get; set; }
    }
}
