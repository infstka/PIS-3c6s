using LR8b.Context;

namespace LR8b.Repository
{
    public class UserRepository: GenericRepository<User>
    {
        public UserRepository(UserContext context) : base(context)
        {
        }
    }
}
