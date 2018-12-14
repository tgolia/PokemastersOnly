using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PokemastersOnly.Api.Models
{
    public class Trade
    {
        public int TradeId { get; set; }
        public Trainer TradePartnerOne { get; set; }
        public Pokemon PokemonOne { get; set; }
        public Trainer TradePartnerTwo { get; set; }
        public Pokemon PokemonTwo { get; set; }

    }
}