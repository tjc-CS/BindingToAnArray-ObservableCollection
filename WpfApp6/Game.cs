using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp6
{
    class Game 
    {
        private ObservableCollection<Card> C = new ObservableCollection<Card>();

        public Game()
        {
            C.Add(new Card(1));
            C.Add(new Card(2));
            C.Add(new Card(3));
            C.Add(new Card(4));
        }

        public ObservableCollection<Card> Cards
        {
            set
            {
                C = value;
            }
            get
            {
                return C;
            }
        }

        public void update()
        {
            Card temp = C[0];
            C[0] = C[1];
            C[1] = temp;
            


        }

    }
}
