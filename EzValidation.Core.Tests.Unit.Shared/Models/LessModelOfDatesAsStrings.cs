using System;
using EzValidation.Core.Attributes.Comparison;
using EzValidation.Core.Tests.Unit.Shared.Fakes;

namespace EzValidation.Core.Tests.Unit.Shared.Models {

    public class LessModelOfDatesAsStrings : FakeModelBase<Less> {

        [Less("|12/31/2010|")]
        public string Val1 { get; set; }

        [Less("Val1")]
        public string Val2 { get; set; }

        [Less("CompareToCurrentDate")]
        public string Val3 { get; set; }

        [Less("Val3")]
        public string Val4 { get; set; }
    }
}