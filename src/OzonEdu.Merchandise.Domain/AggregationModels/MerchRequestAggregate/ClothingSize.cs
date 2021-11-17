using System;
using OzonEdu.Merchandise.Domain.Root;

namespace OzonEdu.Merchandise.Domain.AggregationModels.MerchRequestAggregate
{
    public class ClothingSize: Enumeration
    {
        public static ClothingSize XS = new(1, nameof(XS));
        public static ClothingSize S = new(2, nameof(S));
        public static ClothingSize M = new(3, nameof(M));
        public static ClothingSize L = new(4, nameof(L));
        public static ClothingSize XL = new(5, nameof(XL));
        public static ClothingSize XXL = new(6, nameof(XXL));

        public ClothingSize(int id, string name) : base(id, name)
        {
        }

        public static ClothingSize Parse(string sizeStr)
        {
            switch (sizeStr.ToUpper())
            {
                case "XS":
                    return XS;
                    break;
                case "S":
                    return S;
                    break;
                case "M":
                    return M;
                    break;
                case "L":
                    return L;
                    break;
                case "XL":
                    return XL;
                    break;
                case "XXL":
                    return XXL;
                    break;
                default:
                    throw new Exception($"unknown size : '{sizeStr}'");
                    break;
            }
        }
    }
}