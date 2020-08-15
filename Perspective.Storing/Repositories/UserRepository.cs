using System.Collections.Generic;
using Perspective.Domain;

namespace Perspective.Storing
{
    public class UserRepository : ARepository<UserModel>
    {
        public void Add(UserModel t)
        {
            throw new System.NotImplementedException();
        }

        public UserModel Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public UserModel Get(string name)
        {
            throw new System.NotImplementedException();
        }

        public List<UserModel> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public void Update(UserModel t, string name)
        {
            throw new System.NotImplementedException();
        }
    }
}
