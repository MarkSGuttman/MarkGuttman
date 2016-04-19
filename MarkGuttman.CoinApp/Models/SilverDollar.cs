using MarkGuttman.CoinApp.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MarkGuttman.CoinApp.Models
{
    public class SilverDollar : CoinBase
    {
        private readonly decimal _value;

        private readonly string _name;
        
        public SilverDollar() 
        {
            _value = 1M;
            _name = "Silver Dollar";
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