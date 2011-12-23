using EzValidation.Core.Attributes.Comparison;
using EzValidation.Core.Tests.Unit.Shared.Fakes;

namespace EzValidation.Core.Tests.Unit.Shared.Models {

    public class GreaterOrEqualModelOfLongs : FakeModelBase<GreaterOrEqual> {

        [GreaterOrEqual("|1|")]
        public long? Val1 { get; set; }

        [GreaterOrEqual("Val1")]
        public long? Val2 { get; set; }

        [GreaterOrEqual("Val2")]
        public long? Val3 { get; set; }
    }
}