using Basic_CQRS.CQRSPattern.Results;
using Basic_CQRS.DAL;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Basic_CQRS.CQRSPattern.Handlers
{
    public class GetProductQueryHandler
    {
        private readonly Context _context;

        public GetProductQueryHandler(Context context)
        {
            _context = context;
        }

        public List<GetProductQueryResult> Handle()
        {
            var values = _context.Products.Select(x => new GetProductQueryResult
            {
                ProductID = x.ProductID,
                ProductBrand = x.ProductBrand,
                ProductPrice = x.ProductPrice,
                ProductStatus = x.ProductStatus,
                ProductStock = x.ProductStock,
                Name = x.ProductName
            }).ToList();
            return values;
        }
    }
}
