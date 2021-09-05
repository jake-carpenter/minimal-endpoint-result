namespace EndpointResult
{
    public static class EndpointResult
    {
        public static IEndpointResult<T> Return<T>(int statusCode, T value)
        {
            return new Result<T>(statusCode, value);
        }
    }
}
