using Basic_CQRS.CQRSPattern.Queries;
using Basic_CQRS.CQRSPattern.Results;
using Basic_CQRS.DAL;

namespace Basic_CQRS.CQRSPattern.Handlers
{
    public class GetProductUpdateByIDQueryHandler
    {
        private readonly Context _context;

        public GetProductUpdateByIDQueryHandler(Context context)
        {
            _context = context;
        }

        public GetProductUpdateQueryResult Handle(GetProductUpdateByIDQuery query)
        {
            var values = _context.Products.Find(query.Id);
            return new GetProductUpdateQueryResult
            {
                ProductBrand = values.ProductBrand,
                ProductID = values.ProductID,
                ProductName = values.ProductName,
                ProductPrice = values.ProductPrice,
                ProductStatus = true,
                ProductStock = values.ProductStock,
            };
        }
    }
}
