﻿using System;
using System.Security.Cryptography;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoDB.DataEntities
{
    [BsonIgnoreExtraElements]
    public class Post
    {
        public int PostId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime DateAdded { get; set; }

        public User User { get; set; }

        public bool isUrgent { get; set; }

        public Item ItemInfo { get; set; }
       
        public Recommendation RecommendationPost { get; set; }

        public LookingFor LookingForPost { get; set; }

        public LostAndFound LostAndFoundPost { get; set; }

       

    }
}
