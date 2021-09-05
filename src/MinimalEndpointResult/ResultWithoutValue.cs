namespace MinimalEndpointResult
{
    internal class ResultWithoutValue : IEndpointResult
    {
        public ResultWithoutValue(int statusCode)
        {
            StatusCode = statusCode;
        }

        public int StatusCode { get; }
    }
}
