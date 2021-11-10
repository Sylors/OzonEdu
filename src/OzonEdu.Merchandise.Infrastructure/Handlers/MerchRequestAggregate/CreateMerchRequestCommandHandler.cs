using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using OzonEdu.Merchandise.Domain.AggregatesModels.MerchRequestAggregate;
using OzonEdu.Merchandise.Infrastructure.Commands.MerchRequestAggregate;
using OzonEdu.Merchandise.Domain.AggregationModels.MerchRequestAggregate;

namespace OzonEdu.Merchandise.Infrastructure.Handlers.MerchRequestAggregate
{
    public class CreateMerchRequestCommandHandler : IRequestHandler<CreateMerchRequestCommand>
    {
        public readonly IMerchRequestRepository _merchRequestRepository;

        public CreateMerchRequestCommandHandler(IMerchRequestRepository merchRequestRepository)
        {
            _merchRequestRepository = merchRequestRepository ??
                                      throw new ArgumentNullException($"{nameof(merchRequestRepository)}");
        }

        public async Task<Unit> Handle(CreateMerchRequestCommand request, CancellationToken cancellationToken)
        {
            
            var merchRequest = new MerchRequest(
                null,
                RequestStatus.InProgress//,
                //request.SkuCollection.Select(it => new Sku(it)).ToList()
                );
            
            //TODO Тут должен быть запрос к сервису поставок для получения идентификатора поставки
            // и этот идентификатор нужно будет проставить в модель
                            
            await _merchRequestRepository.CreateAsync(merchRequest, cancellationToken);
            await _merchRequestRepository.UnitOfWork.SaveEntitiesAsync(cancellationToken);
           
            return Unit.Value;
          
        }
    }
}