﻿using System.ComponentModel.DataAnnotations;

namespace MagicVilla_API.Controllers.Modelos.Dto
{
    public class VillaDto
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string Nombre { get; set; }
    }
}
