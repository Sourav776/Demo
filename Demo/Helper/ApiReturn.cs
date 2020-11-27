using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demo.Helper
{
    public class ApiReturn
    {
        public bool IsError { get; set; } = true;
        public dynamic ApiData { get; set; } = 404;
    }
}