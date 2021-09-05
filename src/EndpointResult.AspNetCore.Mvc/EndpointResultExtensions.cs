using Microsoft.AspNetCore.Mvc;

namespace EndpointResult.AspNetCore.Mvc
{
    public static class EndpointResultExtensions
    {
        public static IActionResult ToActionResult<T>(this IEndpointResult<T> endpointResult)
        {
            return endpointResult switch
            {
                IEndpointResult<None> => new StatusCodeResult(endpointResult.StatusCode),
                _ => new ObjectResult(endpointResult.Value) { StatusCode = endpointResult.StatusCode }
            };
        }
    }
}
