using System.Collections.Generic;

namespace Perspective.Domain
{
    public class UserModel : AModel
    {
        public string Password{get;set;}
        public List<RoomModel> RoomModel{get;set;}
        public List<CatagoryModel> Catagories {get;set;}
    }
}