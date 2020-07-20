using System;
using System.Collections.Generic;

namespace AbstractFactory.Repository
{
    public class PlanetaRepository
    {
        public IList<PlanetaEntity> GetSistemaSolar()
        {
            return new List<PlanetaEntity>
            {
                new PlanetaEntity
                {
                    Nome = "Mercúrio",
                    Descoberta = null,
                    PeriodoOrbital = 0.24, 
                    NumLuas = 0,
                },
                new PlanetaEntity
                {
                    Nome = "Vênus",
                    Descoberta = null,
                    PeriodoOrbital = 0.61,
                    NumLuas = 0,
                },
                new PlanetaEntity
                {
                    Nome = "Terra",
                    Descoberta = null,
                    PeriodoOrbital = 1, 
                    NumLuas = 1,
                },
                new PlanetaEntity
                {
                    Nome = "Marte",
                    Descoberta = null,
                    PeriodoOrbital = 1.88, 
                    NumLuas = 2,
                },
                new PlanetaEntity
                {
                    Nome = "Jupiter",
                    Descoberta = null,
                    PeriodoOrbital = 11.86,
                    NumLuas = 79,
                },
                new PlanetaEntity
                {
                    Nome = "Saturno",
                    Descoberta = null,
                    PeriodoOrbital = 29.45,
                    NumLuas = 82,
                },
                new PlanetaEntity
                {
                    Nome = "Urano",
                    Descoberta = new DateTime(1781, 03, 13),
                    PeriodoOrbital = 84,
                    NumLuas = 27,
                },
                new PlanetaEntity
                {
                    Nome = "Netuno",
                    Descoberta = new DateTime(1846, 09, 23),
                    PeriodoOrbital = 164.8,
                    NumLuas = 0,
                },
            };
        }
    }
}