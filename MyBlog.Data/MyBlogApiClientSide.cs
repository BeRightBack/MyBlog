using MyBlog.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using MyBlog.Data.Models;
using System.Net.Http.Json;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using MyBlog.Data.Extensions;
using Newtonsoft.Json;

namespace MyBlog.Data
{
    public class MyBlogApiClientSide : IMyBlogApi
    {
        private readonly IHttpClientFactory factory;
        public MyBlogApiClientSide(IHttpClientFactory factory)
        {
            this.factory = factory;
        }

        public Task DeleteBlogPostAsync(BlogPost item)
        {
            throw new NotImplementedException();
        }

        public Task DeleteCategoryAsync(Category item)
        {
            throw new NotImplementedException();
        }

        public Task DeleteTagAsync(Tag item)
        {
            throw new NotImplementedException();
        }

        public Task<BlogPost> GetBlogPostAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> GetBlogPostCountAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<BlogPost>> GetBlogPostsAsync(int numberofposts, int startindex)
        {
            throw new NotImplementedException();
        }

        public Task<List<Category>> GetCategoriesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Category> GetCategoryAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Tag> GetTagAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Tag>> GetTagsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<BlogPost> SaveBlogPostAsync(BlogPost item)
        {
            throw new NotImplementedException();
        }

        public Task<Category> SaveCategoryAsync(Category item)
        {
            throw new NotImplementedException();
        }

        public Task<Tag> SaveTagAsync(Tag item)
        {
            throw new NotImplementedException();
        }
    }
}
