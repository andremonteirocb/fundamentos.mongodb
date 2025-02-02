﻿using Fundamentos.NoSQL.Domain.Interfaces;

namespace Fundamentos.NoSQL.Domain.Settings
{
    public class MongoDBConfig : IMongoDBConfig
    {
        public string Database { get; set; }
        public string Host { get; set; }
        public int Port { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public string ConnectionStringProduction { get; set; }
        public string ConnectionString
        {
            get
            {
                if (!string.IsNullOrEmpty(ConnectionStringProduction)) return ConnectionStringProduction;

                if (string.IsNullOrEmpty(User) || string.IsNullOrEmpty(Password))
                    return $@"mongodb://{Host}:{Port}";
                return $@"mongodb://{User}:{Password}@{Host}:{Port}";
            }
        }
    }
}
