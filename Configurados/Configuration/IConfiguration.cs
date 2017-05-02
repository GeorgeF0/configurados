namespace Configurados.Configuration
{
    public interface IConfiguration
    {
        string this[string key] { get; set; }
    }
}