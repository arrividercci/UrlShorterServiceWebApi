﻿using System.ComponentModel.DataAnnotations;

namespace UrlShorterServiceWebApi.Models
{
    public class UrlModel
    {
        [Url]
        public string? OriginalUrl { get; set; }
        public string? ShortUrl { get; set; }
    }
}
