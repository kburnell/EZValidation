using EzValidation.Core.Attributes.Comparison;
using EzValidation.Core.Tests.Unit.Shared.Fakes;

namespace EzValidation.Core.Tests.Unit.Shared.Models {

    public class LessOrEqualModelOfLongs : FakeModelBase<LessOrEqual> {

        [LessOrEqual("|1|")]
        public long? Val1 { get; set; }

        [LessOrEqual("Val1")]
        public long? Val2 { get; set; }

        [LessOrEqual("Val2")]
        public long? Val3 { get; set; }
    }
}