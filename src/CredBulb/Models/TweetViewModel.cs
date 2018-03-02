﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CredBulb.Models
{
    public class TweetViewModel
    {
        [DisplayName("Image")]
        [DataType(DataType.ImageUrl)]
        public string ImageUrl { get; set; }

        [DisplayName("Screen Name")]
        public string ScreenName { get; set; }

        [DisplayName("Tweet")]
        public string Text { get; set; }
    }
}
