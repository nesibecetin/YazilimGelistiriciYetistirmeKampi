using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class SaleManager : ISaleService
    {

        public void Add(Gamer gamer, Game game)
        {
            Console.WriteLine(game.GameName + " oyunun satışı " + gamer.Name + " kişisine satıldı.");
        }

        public void AddCampaign(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName+"kampanyası eklendi");
        }
    }
}
