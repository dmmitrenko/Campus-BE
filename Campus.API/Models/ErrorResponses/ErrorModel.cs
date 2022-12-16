using System.Text.Json;

namespace Campus.API.Models.ErrorResponses;

public class ErrorModel
{
    public string Message { get; set; }
    public int StatusCode { get; set; }
    public object? Body { get; set; }

    public override string ToString()
        => JsonSerializer.Serialize(this);
}
