using EzValidation.Core.Attributes.Comparison;
using EzValidation.Core.Tests.Unit.Shared.Fakes;

namespace EzValidation.Core.Tests.Unit.Shared.Models {

    public class NotEqualModelOfLongs : FakeModelBase<NotEqual> {

        [NotEqual("|99|")]
        public long? Val1 { get; set; }

        [NotEqual("Val1")]
        public long? Val2 { get; set; }

        public long? Val3 { get; set; }

        [NotEqual("Val3")]
        public long? Val4 { get; set; }
    }
}