using System;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Configurados.Configuration
{
    public class InMemoryConfiguration : IConfiguration
    {
        private readonly dynamic _config = new JObject();

        public string this[string key]
        {
            get => Get(key);
            set => Set(key, value);
        }

        private string Get(string key)
        {
            var segments = key.Split(new []{'.'}, StringSplitOptions.RemoveEmptyEntries);
            var result = _config;

            foreach (var segment in segments)
            {
                result = result[segment];
            }

            return JsonConvert.SerializeObject(result);
        }

        private void Set(string key, string value)
        {
            var parsed = JToken.Parse(value);

            var segments = key.Split(new[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
            var target = _config;

            foreach (var segment in segments.Take(segments.Length - 1))
            {
                target = target[segment];
            }

            target[segments.Last()] = parsed;
        }
    }
}
