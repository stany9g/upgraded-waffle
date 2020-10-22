using Market.Data.Access;

namespace Market.BusinessLogic.Business
{
    public abstract class BaseBusiness
    {
        private readonly IContext _context;

        protected BaseBusiness(IContext context)
        {
            _context = context;
        }
    }
}