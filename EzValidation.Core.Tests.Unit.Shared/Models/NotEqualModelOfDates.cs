using System;
using EzValidation.Core.Attributes.Comparison;
using EzValidation.Core.Tests.Unit.Shared.Fakes;

namespace EzValidation.Core.Tests.Unit.Shared.Models {

    public class NotEqualModelOfDates : FakeModelBase<NotEqual> {

        [NotEqual("|12/31/2010|")]
        public DateTime? Val1 { get; set; }

        [NotEqual("Val1")]
        public DateTime? Val2 { get; set; }

        [NotEqual("CompareToCurrentDate")]
        public DateTime? Val3 { get; set; }

        public DateTime? Val4 { get; set; }

        [NotEqual("Val4")]
        public DateTime? Val5 { get; set; }
    }
}