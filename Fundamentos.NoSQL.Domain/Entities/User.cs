﻿using MongoDB.Bson.Serialization.Attributes;
using Fundamentos.NoSQL.Domain.Base;

namespace Fundamentos.NoSQL.Domain.Entities
{
    [BsonIgnoreExtraElements]
    public sealed class User : Entity
    {
        public string Mail { get; set; }
        public string Name { get; set; }
    }
}