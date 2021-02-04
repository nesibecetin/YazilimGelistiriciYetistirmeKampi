using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public interface ISaleService
    {
        void Add(Gamer gamer,Game game);
        void AddCampaign(Campaign campaign);
    }
}
