using MarkGuttman.CoinApp.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MarkGuttman.CoinApp.Models
{
    public class Penny : CoinBase
    {
        private readonly decimal _value;

        private readonly string _name;

        public Penny()
        {
            _value = .01M;
            _name = "Penny";
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