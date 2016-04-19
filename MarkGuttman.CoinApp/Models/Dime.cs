using MarkGuttman.CoinApp.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MarkGuttman.CoinApp.Models
{
    public class Dime : CoinBase
    {
        private readonly decimal _value;

        private readonly string _name;
        
        public Dime() 
        {
            _value = .10M;
            _name = "Dime";
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