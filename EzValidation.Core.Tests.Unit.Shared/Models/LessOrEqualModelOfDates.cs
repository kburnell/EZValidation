using System;
using EzValidation.Core.Attributes.Comparison;
using EzValidation.Core.Tests.Unit.Shared.Fakes;

namespace EzValidation.Core.Tests.Unit.Shared.Models {

    public class LessOrEqualModelOfDates : FakeModelBase<LessOrEqual> {

        [LessOrEqual("|12/31/2010|")]
        public DateTime? Val1 { get; set; }

        [LessOrEqual("Val1")]
        public DateTime? Val2 { get; set; }

        [LessOrEqual("CompareToCurrentDate")]
        public DateTime? Val3 { get; set; }

        [LessOrEqual("Val3")]
        public DateTime? Val4 { get; set; }
    }
}