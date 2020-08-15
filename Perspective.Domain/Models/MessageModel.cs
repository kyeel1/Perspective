namespace Perspective.Domain
{
    public class MessageModel :AModel
    {
        public string Message{get;set;}
        public UserModel Owner{get;set;}

        public override string ToString()
        {
            return $"{Owner} said : {Message}";
        }

    }
}