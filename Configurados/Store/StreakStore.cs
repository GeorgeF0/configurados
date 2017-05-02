using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Streak.Core;

namespace Configurados.Store
{
    public class StreakStore : IStore
    {
        private readonly object _sync = new object();
        private readonly Streak.Core.Streak _streak = new Streak.Core.Streak("store/streak", writer: true);

        public IEnumerable<ConfigUpdate> Load()
        {
            lock (_sync)
            {
                return _streak.Get().Select(x => JsonConvert.DeserializeObject<ConfigUpdate>(x.Data));
            }
        }

        public void Save(ConfigUpdate update)
        {
            lock (_sync)
            {
                _streak.Save(new[]
                {
                    new Event
                    {
                        Data = JsonConvert.SerializeObject(update),
                        Meta = "",
                        Type = nameof(ConfigUpdate)
                    }
                });
            }
        }
    }
}
