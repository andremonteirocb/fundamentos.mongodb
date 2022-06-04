﻿using MongoDB.Bson.Serialization.Attributes;
using Fundamentos.NoSQL.Domain.Base;
using System;
using System.Collections.Generic;

namespace Fundamentos.NoSQL.Domain.Entities
{
    [BsonIgnoreExtraElements]
    public sealed class Publicacao : Entity
    {
        public Publicacao(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public List<Autor> Autores { get; set; }
        public List<Comentario> Comentarios { get; set; }

        public void AtualizarPublicacao(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public void AdicionarAutor(string name)
        {
            if (Autores == null) Autores = new List<Autor>();
            Autores.Add(new Autor(name));
        }

        public void AdicionarComentario(string name, string conteudo)
        {
            if (Comentarios == null) Comentarios = new List<Comentario>();
            Comentarios.Add(new Comentario(name, conteudo, DateTime.Now));
        }
    }

    public class Autor
    {
        public Autor(string name)
        {
            Name = name;
        }

        public string Name { get; private set; }
    }

    public class Comentario
    {
        public Comentario(string name, string conteudo, DateTime dataCriacao)
        {
            Name = name;
            Conteudo = conteudo;
            DataCriacao = dataCriacao;
        }

        public string Name { get; private set; }
        public string Conteudo { get; private set; }
        public DateTime DataCriacao { get; private set; }
    }
}