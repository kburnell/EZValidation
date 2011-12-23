using System;
using EzValidation.Core.Attributes.Comparison;
using EzValidation.Core.Tests.Unit.Shared.Fakes;

namespace EzValidation.Core.Tests.Unit.Shared.Models {

    public class EqualModelOfDates : FakeModelBase<Equal> {

        [Equal("|12/31/2010|")]
        public DateTime? Val1 { get; set; }

        [Equal("Val1")]
        public DateTime? Val2 { get; set; }

        [Equal("CompareToCurrentDate")]
        public DateTime? Val3 { get; set; }

        public DateTime? Val4 { get; set; }

        [Equal("Val4")]
        public DateTime? Val5 { get; set; }

        [Equal("CompareToYesterday")]
        public DateTime? Val6 { get; set; }

        [Equal("CompareToTomorrow")]
        public DateTime? Val7 { get; set; }
    }
}