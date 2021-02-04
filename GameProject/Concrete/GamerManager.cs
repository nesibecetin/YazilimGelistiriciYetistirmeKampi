using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class GamerManager : IGamerservice
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            this._userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if(_userValidationService.CheckIfRealGamer(gamer)==true)
            {
                Console.WriteLine("Gamer Added.\n\n");
            }
            else
            {
                Console.WriteLine("Unsuccessful\n\n");
            }
           
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Oyuncu Silindi.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Oyuncu Bilgileri Güncellendi.");
        }
    }
}
