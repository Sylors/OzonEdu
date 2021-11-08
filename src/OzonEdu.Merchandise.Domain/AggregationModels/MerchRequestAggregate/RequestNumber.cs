namespace OzonEdu.Merchandise.Domain.AggregatesModels.MerchRequestAggregate
{
    public class RequestNumber
    {
        public RequestNumber(long value)
        {
            Value = value;
        }

        public long Value { get; }
    }
}