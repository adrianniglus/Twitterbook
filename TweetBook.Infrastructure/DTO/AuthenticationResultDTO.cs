﻿using System.Collections.Generic;

namespace TweetBook.Infrastructure.DTO
{
    public class AuthenticationResultDTO
    {
        public string Token { get; set; }
        public bool Success { get; set; }
        public IEnumerable<string> Errors { get; set; }
    }
}