using System.Threading.Tasks;
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

        /// <summary>
        /// Convert <see cref="IEndpointResult{T}"/> to an <see cref="IActionResult"/> with
        /// the source HTTP status code and content body.
        /// </summary>
        /// <param name="endpointResultTask">Source instance of <see cref="IEndpointResult{T}"/> to convert.</param>
        /// <typeparam name="T">Typed value to include with the response.</typeparam>
        public static async Task<IActionResult> ToActionResult<T>(this Task<IEndpointResult<T>> endpointResultTask)
        {
            var result = await endpointResultTask;
            return result.ToActionResult();
        }

        /// <summary>
        /// Convert <see cref="IEndpointResult"/> to an <see cref="IActionResult"/> with
        /// the source HTTP status code.
        /// </summary>
        /// <param name="endpointResultTask">Source instance of <see cref="IEndpointResult"/> to convert.</param>
        public static async Task<IActionResult> ToActionResult(this Task<IEndpointResult> endpointResultTask)
        {
            var result = await endpointResultTask;
            return result.ToActionResult();
        }
    }
}
