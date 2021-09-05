namespace EndpointResult
{
    public static class EndpointResult
    {
        public static IEndpointResult<T> Return<T>(int statusCode, T value)
        {
            return new Result<T>(statusCode, value);
        }

        public static IEndpointResult<None> Ok()
        {
            return new Result<None>(200);
        }

        public static IEndpointResult<None> Fail(int statusCode)
        {
            return new Result<None>(statusCode);
        }

        public static IEndpointResult<T> Fail<T>(int statusCode, T value)
        {
            return new Result<T>(statusCode, value);
        }
    }
}
