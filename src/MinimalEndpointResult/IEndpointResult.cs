namespace MinimalEndpointResult
{
    public interface IEndpointResult<out T> : IEndpointResult
    {
        T Value { get; }
    }

    public interface IEndpointResult
    {
        int StatusCode { get; }
    }
}
