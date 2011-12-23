using EzValidation.Core.Attributes.Comparison;
using EzValidation.Core.Tests.Unit.Shared.Fakes;

namespace EzValidation.Core.Tests.Unit.Shared.Models {

    public class GreaterModelOfDatesAsStrings : FakeModelBase<Greater> {

        [Greater("|12/31/2010|")]
        public string Val1 { get; set; }

        [Greater("Val1")]
        public string Val2 { get; set; }

        [Greater("CompareToCurrentDate")]
        public string Val3 { get; set; }

        [Greater("Val3")]
        public string Val4 { get; set; }
    }
}