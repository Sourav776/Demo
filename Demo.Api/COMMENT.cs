//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Demo.Api
{
    using System;
    using System.Collections.Generic;
    
    public partial class COMMENT
    {
        public int COMMENT_ID { get; set; }
        public Nullable<int> POST_ID { get; set; }
        public Nullable<int> USER_ID { get; set; }
        public Nullable<int> LIKE_COUNT { get; set; }
        public Nullable<int> DISLIKE_COUNT { get; set; }
        public Nullable<System.DateTimeOffset> COMMENT_TIME { get; set; }
    }
}
