using System;
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
            Number = requestNumber;
            Status = requestStatus;
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
        /// Идентификатор сотрудника, которому предназначен мерч
        /// </summary>
        public long EmployeeId { get; private set; }
        /// <summary>
        /// ID ответственного менеджера за выдачу мерча
        /// </summary>
        public long ResponsibleManagerId { get; private set; }
        
        /// <summary>
        /// Коллекция идентификаторов мерча
        /// </summary>
        public SkuList Items { get ; private set ;}


        // public void ChangeStatus(RequestStatus status)
        // {
        //     if (RequestStatus.Equals(RequestStatus.Done))
        //         throw new MerchRequestStatusException($"Request in done. Change status unavailable");
        //     
        //     RequestStatus = status;
        // }

        public MerchRequest()
            : base()
        {
            Id = 0;
            Status = RequestStatus.Draft;
        }

        public MerchRequest(long employeeId)
            : this()
        {
            EmployeeId = employeeId;
            Status = RequestStatus.Created;
        }

        public MerchRequest(long employeeId, long responsibleManagerId)
            : this(employeeId)
        {
            ResponsibleManagerId = responsibleManagerId;
            Status = RequestStatus.Assigned;
        }

        public MerchRequest(long employeeId, long responsibleManagerId, SkuList items)
            : this(employeeId, responsibleManagerId)
        {
            ResponsibleManagerId = responsibleManagerId;
            Status = RequestStatus.InProgress;
            Items = items;
        }

        /// <summary>
        /// Создаем заявку для конкретного сотрудника
        /// </summary>
        public void Create(long employeeId)
        {
            if (Status != RequestStatus.Draft)
            {
                throw new Exception("Incorrect request status");
            }
            EmployeeId = employeeId;
            Status = RequestStatus.Created;
        }

        /// <summary>
        /// Назначаем заявку на мерч ответственному менеджеру
        /// Если заявка не в статусе Created, то выбрасываем исключение
        /// </summary>
        public void AssignTo(long responsibleManagerId)
        {
            if (Status != RequestStatus.Created)
            {
                throw new Exception("Incorrect request status");
            }

            Status = RequestStatus.Assigned;
            ResponsibleManagerId = responsibleManagerId;
        }

        /// <summary>
        /// Берем заявку на мерч в работу
        /// </summary>
        public void StartWork(SkuList items)
        {
            if (Status != RequestStatus.Assigned)
            {
                throw new Exception("Incorrect request status");
            }

            Items = items;
            Status = RequestStatus.InProgress;
        }

        /// <summary>
        /// Завершить работу по заявке
        /// </summary>
        public void Complete()
        {
            if (Status != RequestStatus.InProgress)
            {
                throw new Exception("Incorrect request status");
            }

            Status = RequestStatus.Done;
        }
    }
}