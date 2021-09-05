using Microsoft.AspNetCore.Mvc;

namespace MinimalEndpointResult.AspNetCore.Mvc
{
    public static class EndpointResultExtensions
    {
        public static IActionResult ToActionResult<T>(this IEndpointResult<T> endpointResult)
        {
            return new ObjectResult(endpointResult.Value) { StatusCode = endpointResult.StatusCode };
        }

        public static IActionResult ToActionResult(this IEndpointResult endpointResult)
        {
            return new StatusCodeResult(endpointResult.StatusCode);
        }
    }
}
