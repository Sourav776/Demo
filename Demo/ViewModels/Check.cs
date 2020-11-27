﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demo.ViewModels
{
    public class Check
    {
        public string Data { get; set; }
    }
    public class Post
    {
        public long Post_Id { get; set; }
        public string Post_Content { get; set; }
        public string UserId { get; set; }
        public DateTimeOffset Post_Time { get; set; }
    }
     public class Comment
    {
        public long Comment_Id { get; set; }
        public string Post_Id { get; set; }
        public string User_Id { get; set; }
        public string Comment_Content { get; set; }
        public int? Like_count { get; set; }
        public int? Dislike_Count { get; set; }
        public DateTimeOffset Comment_Time { get; set; }
    }
    public class ReportModel
    {
        public List<PostModel> Posts { get; set; }
        public List<Comment> Comments { get; set; }
    }
    public class PostModel
    {
        public long Post_Id { get; set; }
        public string Post_Content { get; set; }
        public string UserId { get; set; }
        public DateTimeOffset Post_Time { get; set; }
        public List<Comment> CommentList { get; set; }
    }
}