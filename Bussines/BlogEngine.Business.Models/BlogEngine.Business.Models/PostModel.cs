﻿namespace BlogEngine.Business.Models
{
    public class PostModel:BaseEntityModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
    }
}
