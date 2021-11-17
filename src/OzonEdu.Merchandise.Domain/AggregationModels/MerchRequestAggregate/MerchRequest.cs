using System;
using System.Collections.Generic;
using System.Linq;
using OzonEdu.Merchandise.Domain.AggregationModels.MerchRequestAggregate;
using OzonEdu.Merchandise.Domain.AggregationModels.MerchRequestAggregate.DomainEvents;
using OzonEdu.Merchandise.Domain.Exceptions.MerchRequestAggregate;
using OzonEdu.Merchandise.Domain.Root;

namespace OzonEdu.Merchandise.Domain.AggregationModels.MerchRequestAggregate
{
    public class MerchRequest : Entity, IAggregationRoot
    {
        public MerchRequest(RequestNumber number, RequestStatus status, Employee employee, long responsibleManagerId,
            SkuSet skuSet, DateTimeOffset creationDate, DateTimeOffset? giveOutDate)
        {
            Number = number;
            Status = status;
            Employee = employee;
            ResponsibleManagerId = responsibleManagerId;
            SkuSet = skuSet;
            CreationDate = creationDate;
            GiveOutDate = giveOutDate;
        }

        /// <summary>
        /// Номер заявки
        /// </summary>
        public RequestNumber Number { get; private set; }

        /// <summary>
        /// Статус заявки
        /// </summary>
        public RequestStatus Status { get; private set; }

        /// <summary>
        /// Cотрудник, которому предназначен мерч
        /// </summary>
        public Employee Employee { get; }

        /// <summary>
        /// ID ответственного менеджера за выдачу мерча
        /// </summary>
        public long ResponsibleManagerId { get; private set; }

        /// <summary>
        /// Коллекция идентификаторов мерча
        /// </summary>
        public SkuSet SkuSet { get; private set; }

        /// <summary>
        /// Дата создания заявки
        /// </summary>
        public DateTimeOffset CreationDate { get; }

        /// <summary>
        /// Дата выдачи мерча
        /// </summary>
        public DateTimeOffset? GiveOutDate { get; private set; }


        private MerchRequest(Employee employee, SkuSet items, DateTimeOffset creationDate)
        {
            Employee = employee;
            SkuSet = items;
            CreationDate = creationDate;
        }

        public static MerchRequest Create(Employee employee, SkuSet skuList,
            IReadOnlyCollection<MerchRequest> alreadyExistedRequest, DateTimeOffset creationDate)
        {
            MerchRequest merchRequest = new MerchRequest(employee, skuList, creationDate);
            if (!merchRequest.CheckAvailabilityToGiveOut(alreadyExistedRequest, creationDate))
            {
                throw new Exception("");
            }

            return merchRequest;
        }

        public void GiveOut(bool isAvalible, DateTimeOffset giveOutDate)
        {
            if (Equals(Status, RequestStatus.Created) || Equals(Status, RequestStatus.InWork))
            {
                if (isAvalible)
                {
                    Status = RequestStatus.Done;
                    GiveOutDate = giveOutDate;
                    AddDomainEvent(new MerchRequestGiveOut {Employee = Employee, SkuList = SkuSet});
                }
                else
                {
                    Status = RequestStatus.InWork;
                }
            }
            else
            {
                throw new Exception($"Unable to give out merch for request in {Status} status");
            }
        }

        public void Decline()
        {
            if (Equals(Status, RequestStatus.Done) || Equals(Status, RequestStatus.Declined))
            {
                throw new Exception($"Unable to Decline merch request in {Status} status");
            }

            Status = RequestStatus.Declined;
        }

        private bool CheckAvailabilityToGiveOut(IReadOnlyCollection<MerchRequest> alreadyExistedRequest,
            DateTimeOffset giveOutDate)
        {
            return true;
        }
    }
}