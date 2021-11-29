using System;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using OzonEdu.Merchandise.Domain.Root;

namespace OzonEdu.Merchandise.Domain.AggregationModels.MerchRequestAggregate
{
    public class SetType: Enumeration
    {
        public static SetType WelcomePack = new SetType(1, "Welcome-pack");
        public static SetType StarterPack = new SetType(2, "Starter-pack");
        public static SetType ConferenceListenerPack = new SetType(3, "Conference-listener-pack");
        public static SetType ConferenceSpeakerPack = new SetType(4, "Conference-speaker-pack");
        public static SetType VeteranPack = new SetType(5, "Veteran-pack");

        public SetType(int id, string name) : base(id, name)
        {
            if (id <= 0)
            {
                throw new Exception($"Can't create SetType with negative id : '{id}'");
            }
        }
        
        public static SetType Parse(string setTypeStr)
        {
            switch (setTypeStr)
            {
                case "Welcome-pack":
                    return WelcomePack;
                    break;
                case "Starter-pack":
                    return StarterPack;
                    break;
                case "Conference-listener-pack":
                    return ConferenceListenerPack;
                    break;
                case "Conference-speaker-pack":
                    return ConferenceSpeakerPack;
                    break;
                case "Veteran-pack":
                    return VeteranPack;
                    break;
                default:
                    throw new Exception($"Unknown set type : '{setTypeStr}'");
                    break;
            }
        }
    }
}