namespace MinimalEndpointResult
{
    internal class ResultWithValue<T> : IEndpointResult<T>
    {
        public ResultWithValue(int statusCode)
        {
            StatusCode = statusCode;
        }

        public ResultWithValue(int statusCode, T value)
        {
            StatusCode = statusCode;
            Value = value;
        }

        public int StatusCode { get; }
        public T Value { get; }
    }
}
