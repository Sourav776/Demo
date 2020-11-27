using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Demo.Api;
using Demo.Api.Helper;
using Demo.Api.Models;

namespace Demo.Api.Controllers
{
    public class PostController : ApiController
    {
        private readonly StationContext _context;
        private readonly ApiReturn _return;
        // GET: api/Post
        public PostController(StationContext context,ApiReturn apiReturn)
        {
            _context = context;
            _return = apiReturn;
        }
        [HttpPost]
        [Route("api/Post/GetAll")]
        public IHttpActionResult GetAll( dynamic str)
        {
            try
            {
                var result = _context.POSTs.Select(x => new Post { Post_Id = x.POST_ID, Post_Content = x.POST_CONTENT, UserId = x.USER_ID}).ToList();
                _return.IsError = false;
                _return.ApiData = result;
                return Ok(result);
            }
            catch(Exception e)
            {
                Error.ErrorLog("Something", e.Message);
                return Json(_return);
            }
        }

        [HttpPost]
        [Route("api/Post/GetReport")]
        public IHttpActionResult GetReport(dynamic str)
        {
            try
            {
                string userName = str.ToString();
                var result = new ReportModel();
                var Comments = new List <Comment>();
                var posts = _context.POSTs.AsQueryable().Where(x=>x.USER_ID== userName).Select(x => new PostModel { Post_Id = x.POST_ID, Post_Content = x.POST_CONTENT, UserId = x.USER_ID, Post_Time=x.POST_TIME }).ToList();
                foreach(var item in posts)
                {
                     Comments = _context.COMMENTs.AsQueryable().Where(x => x.POST_ID == item.Post_Id).
                        Select(x => new Comment
                        {
                         Comment_Id=x.COMMENT_ID,
                         Comment_Time=x.COMMENT_TIME,
                         Like_count=x.LIKE_COUNT,
                         Dislike_Count=x.DISLIKE_COUNT,
                         User_Id=x.USER_ID,
                         Comment_Content=x.COMMNET_CONTENT
                        }).ToList();
                    item.CommentList = Comments;
                }
               
                result.Posts = posts;
                result.Comments = Comments;
                _return.IsError = false;
                _return.ApiData = result;
                return Ok(result);
            }
            catch (Exception e)
            {
                Error.ErrorLog("Something", e.Message);
                return Json(_return);
            }
        }

    }
}