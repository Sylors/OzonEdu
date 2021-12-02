using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
<<<<<<< HEAD
using Dapper;
using Npgsql;
using OzonEdu.Merchandise.Domain.AggregationModels.MerchRequestAggregate;
using OzonEdu.Merchandise.Domain.Contracts;
using OzonEdu.Merchandise.Infrastructure.Repositories.Infrastructure;
using OzonEdu.Merchandise.Infrastructure.Repositories.Infrastructure.Interfaces;
=======
using OzonEdu.Merchandise.Domain.AggregationModels.MerchRequestAggregate;
using OzonEdu.Merchandise.Domain.Contracts;
>>>>>>> origin/workshop4

namespace OzonEdu.Merchandise.Infrastructure.Repositories.Implementation
{
    public class MerchRequestRepository : IMerchRequestRepository
    {
<<<<<<< HEAD
        private readonly IDbConnectionFactory<NpgsqlConnection> _dbConnectionFactory;       
        private readonly IQueryExecutor _queryExecutor;
        private const int Timeout = 5;
        public MerchRequestRepository(IDbConnectionFactory<NpgsqlConnection> dbConnectionFactory,IQueryExecutor queryExecutor)
        {
            _dbConnectionFactory = dbConnectionFactory;
            _queryExecutor = queryExecutor;
        }
        
        public async Task<List<MerchRequest>> GetMerchReceivedByEmployeeIdAsync(long employeeId, CancellationToken cancellationToken = default)
        {
            const string sql = @"
                SELECT 
                       mrs.
                FROM merch_requests AS mrs                
                WHERE mrs.employee_id = @EmployeeId;";

            var parameters = new
            {
                EmployeeId = employeeId,
            };
            var commandDefinition = new CommandDefinition(
                sql,
                parameters: parameters,
                commandTimeout: Timeout,
                cancellationToken: cancellationToken);
            var connection = await _dbConnectionFactory.CreateConnection(cancellationToken);
            
            // return await _queryExecutor.Execute(async () =>
            // {
            //     // var result = await connection.QueryAsync<Models.ItemType>(commandDefinition);
            //     // return result.Select(x => new Item(new ItemType(x.Id, x.Name)));
            // });
            return new List<MerchRequest>();
=======
        public Task<List<MerchRequest>> GetMerchReceivedByEmployeeIdAsync(long employeeId, CancellationToken cancellationToken = default)
        {
            throw new System.NotImplementedException();
>>>>>>> origin/workshop4
        }

        Task<long> IMerchRequestRepository.CreateAsync(MerchRequest merchRequest, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<MerchRequest>> GetAllRequestsInWorkAsync(CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        Task<MerchRequest> IRepository<MerchRequest>.CreateAsync(MerchRequest itemToCreate, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public Task<MerchRequest> UpdateAsync(MerchRequest itemToUpdate, CancellationToken cancellationToken = default)
        {
            throw new System.NotImplementedException();
        }
    }
}