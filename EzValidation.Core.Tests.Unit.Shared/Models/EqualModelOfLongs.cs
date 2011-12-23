using EzValidation.Core.Attributes.Comparison;
using EzValidation.Core.Tests.Unit.Shared.Fakes;

namespace EzValidation.Core.Tests.Unit.Shared.Models {

    public class EqualModelOfLongs : FakeModelBase<Equal> {

        [Equal("|99|")]
        public long? Val1 { get; set; }

        [Equal("Val1")]
        public long? Val2 { get; set; }

        public long? Val3 { get; set; }

        [Equal("Val3")]
        public long? Val4 { get; set; }
    }
}