﻿using Mapster;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using TweetBook.Contracts.V1.Queries.Posts;
using TweetBook.Contracts.V1.Responses;
using TweetBook.Infrastructure.Services;

namespace TweetBook.Contracts.V1.Handlers.Posts
{
    public class GetAllPostsHandler : IRequestHandler<GetAllPostsQuery, List<PostResponse>>
    {
        private readonly IPostService _postService;

        public GetAllPostsHandler(IPostService postService)
        {
            _postService = postService;
        }

        public async Task<List<PostResponse>> Handle(GetAllPostsQuery request, CancellationToken cancellationToken)
        {
            var posts = await _postService.GetPostsAsync();
            var response = posts.Adapt<List<PostResponse>>();

            

            return response;
        }
    }
}