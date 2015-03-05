using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SharpFlashCard.Models
{
    public class GameRules
    {
        Random rnd = new Random();
        public FlashCards RandomCardPick()
        {
            List<FlashCards> _FlashCard = new List<FlashCards>();
            _FlashCard.Add( new FlashCards());
            //int r = rnd.Next(1, 38);
            return _FlashCard[0];
        }
    }
}