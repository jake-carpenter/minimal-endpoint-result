namespace MinimalEndpointResult
{
    /// <summary>
    /// Factory class for <see cref="IEndpointResult"/> and <see cref="IEndpointResult{T}"/>.
    /// </summary>
    public static class EndpointResult
    {
        /// <summary>
        /// Create a "success" result with a typed value and the provided HTTP status code.
        /// </summary>
        /// <param name="statusCode">HTTP status code to apply to the result.</param>
        /// <param name="value">Typed value to include with the response.</param>
        /// <typeparam name="T">Value type for the response body.</typeparam>
        public static IEndpointResult<T> Return<T>(int statusCode, T value)
        {
            return new ResultWithValue<T>(statusCode, value);
        }

        /// <summary>
        /// Create a "success" result with a typed value and an HTTP 200 status code.
        /// </summary>
        /// <param name="value">Typed value to include with the response.</param>
        /// <typeparam name="T">Value type for the response body.</typeparam>
        public static IEndpointResult<T> Return<T>(T value)
        {
            const int okStatusAsDefault = 200;
            return new ResultWithValue<T>(okStatusAsDefault, value);
        }

        /// <summary>
        /// Create a "success" result with no content and an HTTP 200 status code.
        /// </summary>
        public static IEndpointResult Ok()
        {
            return new ResultWithoutValue(200);
        }

        /// <summary>
        /// Create a generic "failure" result with no content and the provided HTTP status code.
        /// </summary>
        /// <param name="statusCode">HTTP status code to apply to the result.</param>
        public static IEndpointResult Fail(int statusCode)
        {
            return new ResultWithoutValue(statusCode);
        }

        /// <summary>
        /// Create a generic "failure" result with a typed value and the provided HTTP status code.
        /// </summary>
        /// <param name="statusCode">HTTP status code to apply to the result.</param>
        /// <param name="value">Typed value to include with the response.</param>
        /// <typeparam name="T">Value type for the response body.</typeparam>
        public static IEndpointResult<T> Fail<T>(int statusCode, T value)
        {
            return new ResultWithValue<T>(statusCode, value);
        }
    }
}
