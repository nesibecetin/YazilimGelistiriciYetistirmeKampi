using GameProject.Concrete;
using GameProject.Entities;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer = new Gamer()
            {
                Id=1,
                IdentityNumber="53536",
                Name = "Nesibe",
                SurName = "Çetin",
                BirthYear =2004,
               
            };

            Gamer gamer2 = new Gamer()
            {
                Id = 1,
                IdentityNumber = "53536",
                Name = "Nesibe",
                SurName = "Çetin",
                BirthYear = 1998,

            };

            Campaign campaign = new Campaign() { CampaignId=1,CampaignName="Gamer Day:):)"};

            Game game = new Game() { Id=1,GameName="GTA"};

            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(gamer);
            gamerManager.Add(gamer2);

            SaleManager saleManager = new SaleManager();
            saleManager.Add(gamer, game);
            saleManager.AddCampaign(campaign);

        }
    }
}
