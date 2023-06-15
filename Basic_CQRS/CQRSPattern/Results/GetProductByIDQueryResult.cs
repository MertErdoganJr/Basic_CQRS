namespace Basic_CQRS.CQRSPattern.Results
{
    public class GetProductByIDQueryResult
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductBrand { get; set; }
    }
}
