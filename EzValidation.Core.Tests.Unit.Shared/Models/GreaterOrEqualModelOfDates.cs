using System;
using EzValidation.Core.Attributes.Comparison;
using EzValidation.Core.Tests.Unit.Shared.Fakes;

namespace EzValidation.Core.Tests.Unit.Shared.Models {

    public class GreaterOrEqualModelOfDates : FakeModelBase<GreaterOrEqual> {

        [GreaterOrEqual("|12/31/2010|")]
        public DateTime? Val1 { get; set; }

        [GreaterOrEqual("Val1")]
        public DateTime? Val2 { get; set; }

        [GreaterOrEqual("CompareToCurrentDate")]
        public DateTime? Val3 { get; set; }

        [GreaterOrEqual("Val3")]
        public DateTime? Val4 { get; set; }
    }
}