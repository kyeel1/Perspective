using System.Collections.Generic;
using Perspective.Domain;

namespace Perspective.Storing
{
    public class MessageRepository : ARepository<MessageModel>
    {
        public void Add(MessageModel t)
        {
            throw new System.NotImplementedException();
        }

        public MessageModel Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public MessageModel Get(string name)
        {
            throw new System.NotImplementedException();
        }

        public List<MessageModel> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public void Update(MessageModel t, string name)
        {
            throw new System.NotImplementedException();
        }
    }
}
