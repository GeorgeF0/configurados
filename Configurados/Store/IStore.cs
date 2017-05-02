using System.Collections.Generic;

namespace Configurados.Store
{
    public interface IStore
    {
        IEnumerable<ConfigUpdate> Load();
        void Save(ConfigUpdate update);
    }
}