using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SharpFlashCard.Models
{
    public class GameRules
    {
                //public bool IsCorrect
        //{
        //    get { return answer == cardAnswer; }
        //}
        GetQA getQA = new GetQA();

        public string answer;
        public string cardAnswer;
        public string question;
        FlashCards card;
        

        public GameRules(string A)
        {
            answer = A;
        }

        public string Response()
        {
            return answer == cardAnswer ? "Correct!!!" : "You got it Wrong :( ";
        }

        public void Card()
        {
            card = getQA.RandomCardPick();
            cardAnswer = card.Answer;
            question = card.Question;
        }

    }
    
}