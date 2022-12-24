using BasicToDoListApi.Core.Enum;
using Newtonsoft.Json;

namespace BasicToDoListApi.Core.DTO;

public class StandardResponseDto
{
    [JsonProperty("status", Order = 1)]
    public string Status { get; set; } = ApiResponseStatusEnum.Ok.ToString();

    [JsonProperty("message", Order = 2)] 
    public string Message { get; set; } = "Operation successful!";
    
    [JsonProperty("data", NullValueHandling=NullValueHandling.Ignore, Order = 3)]
    public object[] Data { get; set; }
    
    [JsonProperty("errors", NullValueHandling=NullValueHandling.Ignore, Order = 4)]
    public ErrorDto[] Errors { get; set; }
}