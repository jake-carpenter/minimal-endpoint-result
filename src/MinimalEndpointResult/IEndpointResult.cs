namespace MinimalEndpointResult
{
    public interface IEndpointResult<out T>
    {
        int StatusCode { get; }
        T Value { get; }
    }
}
