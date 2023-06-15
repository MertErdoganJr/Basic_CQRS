using Basic_CQRS.CQRSPattern.Queries;
using Basic_CQRS.CQRSPattern.Results;
using Basic_CQRS.DAL;

namespace Basic_CQRS.CQRSPattern.Handlers
{
    public class GetProductByIDQueryHandler
    {
        private readonly Context _context;

        public GetProductByIDQueryHandler(Context context)
        {
            _context = context;
        }

        public GetProductByIDQueryResult Handle(GetProductByIDQuery query)
        {
            var values = _context.Products.Find(query.Id);
            return new GetProductByIDQueryResult
            {
                ProductID = values.ProductID,
                ProductBrand = values.ProductBrand,
                ProductName = values.ProductName,
            };
        }
    }
}
