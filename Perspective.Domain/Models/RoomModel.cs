using System.Collections.Generic;

namespace Perspective.Domain
{
    public class RoomModel: AModel
    {
        string Description{get;set;}
        List<UserModel> Users {get;set;}
        List<MessageModel> Messages{get;set;}
        
        public override string ToString()
        {
            return $"{Name}: {Description}";
        }
    }
}