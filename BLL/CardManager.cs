using DAL;
using DTO;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CardManager : ICardManager
    {
        public ICardDB cardDB { get; }

        public CardManager(IConfiguration configuration)
        {
            cardDB = new CardDB(configuration);
        }
        public Card GetCardByName(string name)
        {
            return cardDB.GetCardByName(name);
        }
    }
}
