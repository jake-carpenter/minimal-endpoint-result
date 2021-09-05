namespace MinimalEndpointResult
{
    /// <summary>
    /// Represents a value that can be converted into an HTTP response.
    /// </summary>
    /// <typeparam name="T">Typed value to include with the response.</typeparam>
    public interface IEndpointResult<out T> : IEndpointResult
    {
        /// <summary>
        /// Value to include in HTTP content body.
        /// </summary>
        T Value { get; }
    }

    /// <summary>
    /// Represents a value that can be converted into an HTTP response.
    /// </summary>
    public interface IEndpointResult
    {
        /// <summary>
        /// Status code to include with the HTTP response.
        /// </summary>
        int StatusCode { get; }
    }
}
