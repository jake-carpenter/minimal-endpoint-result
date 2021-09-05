using Microsoft.AspNetCore.Mvc;

namespace MinimalEndpointResult.AspNetCore.Mvc
{
    public static class EndpointResultExtensions
    {
        /// <summary>
        /// Convert <see cref="IEndpointResult{T}"/> to an <see cref="IActionResult"/> with
        /// the source HTTP status code and content body.
        /// </summary>
        /// <param name="endpointResult">Source instance of <see cref="IEndpointResult{T}"/> to convert.</param>
        /// <typeparam name="T">Typed value to include with the response.</typeparam>
        public static IActionResult ToActionResult<T>(this IEndpointResult<T> endpointResult)
        {
            return new ObjectResult(endpointResult.Value) { StatusCode = endpointResult.StatusCode };
        }

        /// <summary>
        /// Convert <see cref="IEndpointResult"/> to an <see cref="IActionResult"/> with
        /// the source HTTP status code.
        /// </summary>
        /// <param name="endpointResult">Source instance of <see cref="IEndpointResult"/> to convert.</param>
        public static IActionResult ToActionResult(this IEndpointResult endpointResult)
        {
            return new StatusCodeResult(endpointResult.StatusCode);
        }
    }
}
