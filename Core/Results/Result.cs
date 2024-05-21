using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Results
{
    public class Result : IResult
    {
        public bool IsSuccess { get; }

        public string Message {  get; }

        public Result(bool isSuccess, string message)
        {
            IsSuccess = isSuccess;
            Message = message;
        } 

        public Result(bool isSuccess)
        {
            IsSuccess = isSuccess;
        }
    }
}
