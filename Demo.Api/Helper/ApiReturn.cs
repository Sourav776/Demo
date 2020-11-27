using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demo.Api.Helper
{
    public class ApiReturn
    {
        public bool IsError { get; set; } = true;
        public dynamic ApiData { get; set; } = 404;
    }
}