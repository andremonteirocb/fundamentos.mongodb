﻿using MongoDB.Bson.Serialization.Attributes;
using Fundamentos.NoSQL.Domain.Base;
using System;

namespace Fundamentos.NoSQL.Domain.Entities
{
    [BsonIgnoreExtraElements]
    public sealed class User : Entity
    {
        public User(string mail, string name)
        {
            Mail = mail;
            Name = name;
        }

        public string Mail { get; private set; }
        public string Name { get; private set; }

        public void AtualizarUsuario(string mail, string name)
        {
            Mail = mail;
            Name = name;
        }
    }
}