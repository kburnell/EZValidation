using EzValidation.Core.Attributes.Comparison;
using EzValidation.Core.Tests.Unit.Shared.Fakes;

namespace EzValidation.Core.Tests.Unit.Shared.Models {

    public class GreaterModelOfLongs : FakeModelBase<Greater> {

        [Greater("|1|")]
        public long? Val1 { get; set; }

        [Greater("Val1")]
        public long? Val2 { get; set; }

        [Greater("Val2")]
        public long? Val3 { get; set; }

    }
}