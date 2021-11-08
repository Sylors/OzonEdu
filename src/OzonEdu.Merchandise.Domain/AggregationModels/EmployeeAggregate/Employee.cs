using OzonEdu.Merchandise.Domain.Models;

namespace OzonEdu.Merchandise.Domain.AggregationModels.EmployeeAggregate
{
    public class Employee : Entity
    {
        public Employee(Id id, FirstName firstName, SecondName secondName, MiddleName middleName, Email email)
        {
            Id = id;
            FirstName = firstName;
            SecondName = secondName;
            MiddleName = middleName;
            Email = email;
        }

        public Id Id { get; }
        public FirstName FirstName { get; }
        public SecondName SecondName { get; }
        public MiddleName MiddleName { get; }
        public Email Email { get; }
    }
}