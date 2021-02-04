using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class UserValidationManager : IUserValidationService
    {
        public bool CheckIfRealGamer(Gamer gamer)
        {
            if (gamer.Name != null && gamer.SurName != null && gamer.IdentityNumber != null && gamer.BirthYear <= 2003)
            {
                Console.WriteLine("user checked");
                return true;
            }
            else
                return false;
        }
    }
}
