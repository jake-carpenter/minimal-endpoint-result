namespace MinimalEndpointResult
{
    public static class EndpointResult
    {
        public static IEndpointResult<T> Return<T>(int statusCode, T value)
        {
            return new ResultWithValue<T>(statusCode, value);
        }

        public static IEndpointResult<T> Return<T>(T value)
        {
            const int okStatusAsDefault = 200;
            return new ResultWithValue<T>(okStatusAsDefault, value);
        }

        public static IEndpointResult Ok()
        {
            return new ResultWithoutValue(200);
        }

        public static IEndpointResult Fail(int statusCode)
        {
            return new ResultWithoutValue(statusCode);
        }

        public static IEndpointResult<T> Fail<T>(int statusCode, T value)
        {
            return new ResultWithValue<T>(statusCode, value);
        }
    }
}
