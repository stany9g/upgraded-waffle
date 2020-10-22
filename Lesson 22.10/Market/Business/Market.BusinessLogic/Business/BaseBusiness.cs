using Market.DataAccess;

namespace Market.BusinessLogic.Business
{
    public abstract class BaseBusiness
    {
        protected readonly IContext _context;

        protected BaseBusiness(IContext context)
        {
            _context = context;
        }
    }
}