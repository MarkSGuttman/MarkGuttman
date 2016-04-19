using MarkGuttman.CoinApp.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MarkGuttman.CoinApp.Models
{
    public class HalfDollar : CoinBase
    {
        private readonly decimal _value;

        private readonly string _name;
        
        public HalfDollar() 
        {
            _value = .5M;
            _name = "Half Dollar";
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