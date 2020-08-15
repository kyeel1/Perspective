using System.Collections.Generic;

namespace Perspective.Domain
{
    public class CatagoryModel : AModel
    {
        string Description{get;set;}
        List<UserModel> Users{get;set;}
        List<RoomModel> Rooms{get;set;}
        public override string ToString()
        {
            return $"{Name}: {Description}";
        }
    }
}