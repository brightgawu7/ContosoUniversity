namespace ContosoUniversity.API.Common;
public class ResponseFormat<T>
{
    public string Status { get; set; } = "success";

    public T Data { get; set; }
}
