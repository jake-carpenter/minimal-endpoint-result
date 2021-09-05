using Microsoft.AspNetCore.Mvc;

namespace EndpointResult.AspNetCore.Mvc
{
    public static class EndpointResultExtensions
    {
        public static IActionResult ToActionResult<T>(IEndpointResult<T> endpointResult)
        {
            return new ObjectResult(endpointResult.Value) { StatusCode = endpointResult.StatusCode };
        }
    }
}
