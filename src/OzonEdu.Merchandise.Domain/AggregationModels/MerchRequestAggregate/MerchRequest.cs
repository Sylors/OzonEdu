using OzonEdu.Merchandise.Domain.AggregatesModels.MerchRequestAggregate;
using OzonEdu.Merchandise.Domain.Exceptions.MerchRequestAggregate;
using OzonEdu.Merchandise.Domain.Models;

namespace OzonEdu.Merchandise.Domain.AggregationModels.MerchRequestAggregate
{
    public class MerchRequest : Entity
    {
        public MerchRequest(RequestNumber requestNumber,
            RequestStatus requestStatus)
        {
            RequestNumber = requestNumber;
            RequestStatus = requestStatus;
        }

        /// <summary>
        /// Номер заявки
        /// </summary>
        public RequestNumber RequestNumber { get; private set; }

        /// <summary>
        /// Статус заявки
        /// </summary>
        public RequestStatus RequestStatus { get; private set; }
        
        public void ChangeStatus(RequestStatus status)
        {
            if (RequestStatus.Equals(RequestStatus.Done))
                throw new MerchRequestStatusException($"Request in done. Change status unavailable");
            
            RequestStatus = status;
        }
    }
}