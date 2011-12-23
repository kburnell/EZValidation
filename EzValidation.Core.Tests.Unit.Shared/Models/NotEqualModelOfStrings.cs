using EzValidation.Core.Attributes.Comparison;
using EzValidation.Core.Tests.Unit.Shared.Fakes;

namespace EzValidation.Core.Tests.Unit.Shared.Models {

    public class NotEqualModelOfStrings : FakeModelBase<NotEqual> {

        [NotEqual("|Hello World|")]
        public string Val1 { get; set; }

        [NotEqual("Val1")]
        public string Val2 { get; set; }

        [NotEqual("CompareToCurrentDate")]
        public string Val3 { get; set; }
    }
}