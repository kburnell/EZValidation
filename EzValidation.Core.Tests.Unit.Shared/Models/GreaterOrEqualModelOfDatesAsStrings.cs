using System;
using EzValidation.Core.Attributes.Comparison;
using EzValidation.Core.Tests.Unit.Shared.Fakes;

namespace EzValidation.Core.Tests.Unit.Shared.Models {

    public class GreaterOrEqualModelOfDatesAsStrings : FakeModelBase<GreaterOrEqual> {

        [GreaterOrEqual("|12/31/2010|")]
        public string Val1 { get; set; }

        [GreaterOrEqual("Val1")]
        public string Val2 { get; set; }

        [GreaterOrEqual("CompareToCurrentDate")]
        public string Val3 { get; set; }

        [GreaterOrEqual("Val3")]
        public string Val4 { get; set; }
    }
}