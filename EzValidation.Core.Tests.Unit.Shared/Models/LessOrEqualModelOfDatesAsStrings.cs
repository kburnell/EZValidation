using EzValidation.Core.Attributes.Comparison;
using EzValidation.Core.Tests.Unit.Shared.Fakes;

namespace EzValidation.Core.Tests.Unit.Shared.Models {

    public class LessOrEqualModelOfDatesAsStrings : FakeModelBase<LessOrEqual> {

        [LessOrEqual("|12/31/2010|")]
        public string Val1 { get; set; }

        [LessOrEqual("Val1")]
        public string Val2 { get; set; }

        [LessOrEqual("CompareToCurrentDate")]
        public string Val3 { get; set; }

        [LessOrEqual("Val3")]
        public string Val4 { get; set; }
    }
}