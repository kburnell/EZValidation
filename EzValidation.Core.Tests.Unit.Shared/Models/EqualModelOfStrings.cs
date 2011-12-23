using EzValidation.Core.Attributes.Comparison;
using EzValidation.Core.Tests.Unit.Shared.Fakes;

namespace EzValidation.Core.Tests.Unit.Shared.Models {

    public class EqualModelOfStrings : FakeModelBase<Equal> {

        [Equal("|Hello World|")]
        public string Val1 { get; set; }

        [Equal("Val1", ErrorMessage = "* Must Equal Val1")]
        public string Val2 { get; set; }

        [Equal("CompareToCurrentDate")]
        public string Val3 { get; set; }

        [Equal("CompareToYesterday")]
        public string Val4 { get; set; }

        [Equal("CompareToTomorrow")]
        public string Val5 { get; set; }

    }
}