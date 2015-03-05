using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace SharpFlashCard.Models
{
    public class FlashCards
    {
        public int Id { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }

        public FlashCards() { }

        public FlashCards(int Id, string Question, string Answer)
        {
            this.Id = Id;
            this.Question = Question;
            this.Answer = Answer;
        }
    }
}