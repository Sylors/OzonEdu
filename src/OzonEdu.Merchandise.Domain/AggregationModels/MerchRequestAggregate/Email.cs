using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using OzonEdu.Merchandise.Domain.Root;

namespace OzonEdu.Merchandise.Domain.AggregationModels.MerchRequestAggregate
{
    public class Email : ValueObject
    {
        public string Value { get; private set; }

        private Email(string emailString)
        {
            Value = emailString;
        }
        
        public static Email Create(string emailString)
        {
            if (!IsValidEmail(emailString))
            {
                throw new Exception($"Email is invalid: {emailString}");
            
            }
            return new Email(emailString);
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
        
        private static bool IsValidEmail(string emailString)
            => Regex.IsMatch(emailString, @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
    }
}