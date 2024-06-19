using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp6
{
    class Card
    {
        private int cardNo;

        public Card(int n)
        {
            cardNo = n;
        }

        public int CardNo 
        {
            get
            {
                return cardNo;
            }
            set
            {
                cardNo = value;
            }
        }
    }
}
