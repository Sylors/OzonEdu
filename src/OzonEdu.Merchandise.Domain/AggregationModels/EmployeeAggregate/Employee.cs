using OzonEdu.Merchandise.Domain.Models;

namespace OzonEdu.Merchandise.Domain.AggregationModels.EmployeeAggregate
{
    public class Employee : Entity, IAggregationRoot
    {
        public Employee(Id id, FirstName firstName, SecondName secondName, MiddleName middleName, Email email)
        {
            Id = id;
            FirstName = firstName;
            SecondName = secondName;
            MiddleName = middleName;
            Email = email;
        }

        public Id Id { get; private set; }
        public FirstName FirstName { get; private set; }
        public SecondName SecondName { get; private set; }
        public MiddleName MiddleName { get; private set; }
        public Email Email { get; private set; }
    }
}