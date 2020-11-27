using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demo.Api.Models
{
    public class ReportModel
    {
        public List<PostModel> Posts { get; set; }
        public List<Comment> Comments { get; set; }
    }
}