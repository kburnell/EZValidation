using System;
using EzValidation.Core.Attributes.Comparison;
using EzValidation.Core.Tests.Unit.Shared.Fakes;

namespace EzValidation.Core.Tests.Unit.Shared.Models {

    public class LessModelOfDates : FakeModelBase<Less> {

        [Less("|12/31/2010|")]
        public DateTime? Val1 { get; set; }

        [Less("Val1")]
        public DateTime? Val2 { get; set; }

        [Less("CompareToCurrentDate")]
        public DateTime? Val3 { get; set; }

        [Less("Val3")]
        public DateTime? Val4 { get; set; }
    }
}