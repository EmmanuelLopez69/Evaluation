using System.Text.Json.Serialization;

namespace Evaluation.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum UserType
    {
        Comprador = 1,
        Vendedor = 2
    }
}