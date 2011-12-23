using EzValidation.Core.Attributes.Comparison;
using EzValidation.Core.Tests.Unit.Shared.Fakes;

namespace EzValidation.Core.Tests.Unit.Shared.Models {

    public class LessModelOfLongs : FakeModelBase<Less> {

        [Less("|1|")]
        public long? Val1 { get; set; }

        [Less("Val1")]
        public long? Val2 { get; set; }

        [Less("Val2")]
        public long? Val3 { get; set; }
    }
}