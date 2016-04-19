using MarkGuttman.CoinApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MarkGuttman.CoinApp.Implementation
{
    public abstract class CoinBase : ICoin
    {
        public abstract decimal Value();

        public abstract string Name(); 
    }
}