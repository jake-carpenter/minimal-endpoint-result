namespace EndpointResult
{
    internal class Result<T> : IEndpointResult<T>
    {
        public Result(int statusCode)
        {
            StatusCode = statusCode;
        }

        public Result(int statusCode, T value)
        {
            StatusCode = statusCode;
            Value = value;
        }

        public int StatusCode { get; }
        public T Value { get; }
    }
}
