﻿using MagicVilla_API.Controllers.Modelos.Dto;

namespace MagicVilla_API.Datos
{
    public static class VillaStore
    {
        public static List<VillaDto> villaList = new List<VillaDto>
        {
            new VillaDto{ Id = 1, Nombre="Vista a la piscina"},
            new VillaDto{ Id = 2, Nombre="Vista a la playa"}
        };
    }
}
