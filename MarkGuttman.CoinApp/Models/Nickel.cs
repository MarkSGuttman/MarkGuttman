using MarkGuttman.CoinApp.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MarkGuttman.CoinApp.Models
{
    public class Nickel : CoinBase
    {
        private readonly decimal _value;

        private readonly string _name;
        
        public Nickel() 
        {
            _value = .05M;
            _name = "Nickel";
        }

        public override string Name()
        {
            return _name;
        }

        public override decimal Value()
        {
            return _value;
        }
    }
}