using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdQ.Domain.Shared
{
    public class Response<T>
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public IDictionary<string, string[]> ValidationErrors { get; set; }
        public T Data { get; set; }

        public Response()
        {
            Success = false;
            Data = default(T);
            Message = string.Empty;
        }
        public Response(string message = null)
        {
            Success = true;
            Message = message;
        }

        public Response(string message, bool success, T data)
        {
            Success = success;
            Message = message;
            Data = data;
        }

        public static Response<T> Empty()
        {
            return new Response<T>();
        }
    }
}
