using System;
using DubaiVilla.Models.Dto;

namespace DubaiVilla.Data
{
    public class VillaStore
    {
        public static List<VillaDTO> villaList = new List<VillaDTO>
            {
                new VillaDTO{id=1, Name="Pool View"},
                new VillaDTO{id=2, Name="Sea View"},
            };
    }
}