using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mtmu97.Application.Common.Results
{
    public class Result<T>
    {
        public bool IsSuccess { get; set; }
        public T? Data { get; set; }
        public string? Message { get; set; }
        public ErrorType ErrorType { get; set; }

        public static Result<T> Ok(T data, string? message = null) => new()
        {
            IsSuccess = true,
            Data = data,
            Message = message
        };

        public static Result<T> Fail(string message, ErrorType errorType = ErrorType.Unknown) => new()
        {
            IsSuccess = false,
            Message = message,
            ErrorType = errorType
        };
    }
}
