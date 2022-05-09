using API.GymManagementSystem.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace API.GymManagementSystem.Middleware
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        public ExceptionMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(httpContext, ex);
            }
        }


        private Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            if (typeof(ApplicationException) == exception.GetType())
            {
                return context.Response.WriteAsync(new CommonResponse<Exception>()
                {
                    StatusCode = HttpStatusCode.InternalServerError,
                    Message = exception.Message
                }.ToString());
            }
            else
            {
                return context.Response.WriteAsync(new CommonResponse<Exception>()
                {
                    StatusCode = HttpStatusCode.InternalServerError,
                    Message = exception.ToString()
                }.ToString());
            }

        }
    }
}
