using MarkGuttman.CoinApp.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MarkGuttman.CoinApp.Models
{
    public class Quarter : CoinBase
    {
        private readonly decimal _value;

        private readonly string _name;
        
        public Quarter() 
        {
            _value = .25M;
            _name = "Quarter";
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