using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace core.test
{
    public class MiddleWareDemo
    {

        public MiddleWareDemo(RequestDelegate next)
        {
        }

        public  async Task Invoke(HttpContext context)
        {

            Console.WriteLine("AAAAAAAAAAAAA");
            await context.Response.WriteAsync("BBBBBBBBBBBBBB");
        }

    }
}
