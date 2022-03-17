﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesAPI.Models
{
    public class Filme
    {
        public int Id { get; internal set; }
        [Required(ErrorMessage = "O campo Título é obrigatório.")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "O campo Diretor é Obrigatório.")]
        public string Diretor { get; set; }
        [StringLength(30, ErrorMessage = "O campo Gênero não pode ultrapassar 30 caracteres.")]
        public string Genero { get; set; }
        [Range(1,600, ErrorMessage = "A duração tever estar entre 1 minuto até 600 minutos.")]
        public int Duracao { get; set; }
    }
}
