using MarkGuttman.CoinApp.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MarkGuttman.CoinApp.Models
{
    public class Change
    {
        private ICollection<CoinBase> _change;

        public Change() { }

        public ICollection<CoinBase> ChangeCollection
        {
            get
            {
                return this._change ?? (this._change = new List<CoinBase>());
            }
            set
            {
                this._change = value; 
            }
        }
    }
}