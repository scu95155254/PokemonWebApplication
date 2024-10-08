﻿using PokemonWebAPI.Entities;

namespace PokemonWebAPI.Services
{
    public interface IPokemonService
    {
        Task<List<Pokemon>> GetPokemonsAsync();
    }
}