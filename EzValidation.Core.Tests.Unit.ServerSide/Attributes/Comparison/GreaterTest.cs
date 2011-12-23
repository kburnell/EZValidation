using System;
using EzValidation.Core.Tests.Unit.Shared.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;

namespace EzValidation.Core.Tests.Unit.ServerSide.Attributes.Comparison {

    [TestClass]
    public class GreaterTest {

        #region << Longs >>

        [TestMethod]
        public void Greater_ValuesAreLongs_Val1AndVal2_BothNull_ExpectTrue() {
            //Arrange
            GreaterModelOfLongs model = new GreaterModelOfLongs {Val1 = null, Val2 = null};
            //Act
            bool isValid = model.PropertyIsValid("Val2");
            //Assert
            isValid.ShouldBeTrue();
        }

        [TestMethod]
        public void Greater_ValuesAreLongs_Val1IsNullAndVal2IsNotNull_ExpectTrue() {
            //Arrange
            GreaterModelOfLongs model = new GreaterModelOfLongs {Val1 = null, Val2 = 1};
            //Act
            bool isValid = model.PropertyIsValid("Val2");
            //Assert
            isValid.ShouldBeTrue();
        }

        [TestMethod]
        public void Greater_ValuesAreLongs_Val2EqualsVal1_ExpectFalse() {
            //Arrange
            GreaterModelOfLongs model = new GreaterModelOfLongs {Val1 = 1, Val2 = 1};
            //Act
            bool isValid = model.PropertyIsValid("Val2");
            //Assert
            isValid.ShouldBeFalse();
        }

        [TestMethod]
        public void Greater_ValuesAreLongs_Val2GreaterThanVal1_ExpectTrue() {
            //Arrange
            GreaterModelOfLongs model = new GreaterModelOfLongs {Val1 = 1, Val2 = 2};
            //Act
            bool isValid = model.PropertyIsValid("Val2");
            //Assert
            isValid.ShouldBeTrue();
        }

        [TestMethod]
        public void Greater_ValuesAreLongs_Val2LessThanVal2_ExpectFalse() {
            //Arrange
            GreaterModelOfLongs model = new GreaterModelOfLongs {Val1 = 2, Val2 = 1};
            //Act
            bool isValid = model.PropertyIsValid("Val2");
            //Assert
            isValid.ShouldBeFalse();
        }

        [TestMethod]
        public void Greater_ValuesAreLongs_SpecificValue_Val1GreaterThanSpecificValue_ExpectTrue() {
            //Arrange
            GreaterModelOfLongs model = new GreaterModelOfLongs {Val1 = 2};
            //Act
            bool isValid = model.PropertyIsValid("Val1");
            //Assert
            isValid.ShouldBeTrue();
        }

        [TestMethod]
        public void Greater_ValuesAreLongs_SpecificValue_Val1EqualSpecificValue_ExpectFalse() {
            //Arrange
            GreaterModelOfLongs model = new GreaterModelOfLongs {Val1 = 1};
            //Act
            bool isValid = model.PropertyIsValid("Val1");
            //Assert
            isValid.ShouldBeFalse();
        }

        [TestMethod]
        public void Greater_ValuesAreLongs_SpecificValue_Val1NotGreaterThanSpecificValue_ExpectFalse() {
            //Arrange
            GreaterModelOfLongs model = new GreaterModelOfLongs {Val1 = 0};
            //Act
            bool isValid = model.PropertyIsValid("Val1");
            //Assert
            isValid.ShouldBeFalse();
        }

        #endregion

        #region << Dates >>

        [TestMethod]
        public void Greater_ValuesAreDates_Val1AndVal2_BothNull_ExpectTrue() {
            //Arrange
            GreaterModelOfDates model = new GreaterModelOfDates {Val1 = null, Val2 = null};
            //Act
            bool isValid = model.PropertyIsValid("Val2");
            //Assert
            isValid.ShouldBeTrue();
        }

        [TestMethod]
        public void Greater_ValuesAreDates_Val1IsNullAndVal2IsNotNull_ExpectTrue() {
            //Arrange
            GreaterModelOfDates model = new GreaterModelOfDates {Val1 = null, Val2 = DateTime.Now};
            //Act
            bool isValid = model.PropertyIsValid("Val2");
            //Assert
            isValid.ShouldBeTrue();
        }

        [TestMethod]
        public void Greater_ValuesAreDates_Val2EqualsVal1_ExpectFalse() {
            //Arrange
            DateTime date = DateTime.Now.Date;
            GreaterModelOfDates model = new GreaterModelOfDates {Val1 = date, Val2 = date};
            //Act
            bool isValid = model.PropertyIsValid("Val2");
            //Assert
            isValid.ShouldBeFalse();
        }

        [TestMethod]
        public void Greater_ValuesAreDates_Val2GreatersVal1_ExpectTrue() {
            //Arrange
            DateTime date = DateTime.Now.Date;
            GreaterModelOfDates model = new GreaterModelOfDates {Val1 = date, Val2 = date.AddDays(1)};
            //Act
            bool isValid = model.PropertyIsValid("Val2");
            //Assert
            isValid.ShouldBeTrue();
        }

        [TestMethod]
        public void Greater_ValuesAreDates_Val1GreaterThanVal2_ExpectFalse() {
            //Arrange
            GreaterModelOfDates model = new GreaterModelOfDates {Val1 = DateTime.Now, Val2 = DateTime.Now.AddDays(-1)};
            //Act
            bool isValid = model.PropertyIsValid("Val2");
            //Assert
            isValid.ShouldBeFalse();
        }

        [TestMethod]
        public void Greater_ValuesAreDates_SpecificValue_Val1GreaterThanSpecificValue_ExpectTrue() {
            //Arrange
            GreaterModelOfDates model = new GreaterModelOfDates {Val1 = DateTime.Now};
            //Act
            bool isValid = model.PropertyIsValid("Val1");
            //Assert
            isValid.ShouldBeTrue();
        }

        [TestMethod]
        public void Greater_ValuesAreDates_SpecificValue_Val1EqualSpecificValue_ExpectFalse() {
            //Arrange
            GreaterModelOfDates model = new GreaterModelOfDates {Val1 = new DateTime(2010, 12, 31)};
            //Act
            bool isValid = model.PropertyIsValid("Val1");
            //Assert
            isValid.ShouldBeFalse();
        }

        [TestMethod]
        public void Greater_ValuesAreDates_SpecificValue_Val1NotGreaterThanSpecificValue_ExpectFalse() {
            //Arrange
            GreaterModelOfDates model = new GreaterModelOfDates {Val1 = new DateTime(1990, 1, 1)};
            //Act
            bool isValid = model.PropertyIsValid("Val1");
            //Assert
            isValid.ShouldBeFalse();
        }

        [TestMethod]
        public void Greater_ValuesAreDates_CompareToCurrentDate_Val3GreaterThanCurrentDate_ExpectTrue() {
            //Arrange
            GreaterModelOfDates model = new GreaterModelOfDates {Val3 = DateTime.Now.AddDays(1)};
            //Act
            bool isValid = model.PropertyIsValid("Val3");
            //Assert
            isValid.ShouldBeTrue();
        }

        [TestMethod]
        public void Greater_ValuesAreDates_CompareToCurrentDate_Val3EqualCurrentDate_ExpectFalse() {
            //Arrange
            GreaterModelOfDates model = new GreaterModelOfDates {Val3 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day)};
            //Act
            bool isValid = model.PropertyIsValid("Val3");
            //Assert
            isValid.ShouldBeFalse();
        }

        [TestMethod]
        public void Greater_ValuesAreDates_CompareToCurrentDate_Val3NotGreaterThanCurrentDate_ExpectFalse() {
            //Arrange
            GreaterModelOfDates model = new GreaterModelOfDates {Val3 = new DateTime(1990, 1, 1)};
            //Act
            bool isValid = model.PropertyIsValid("Val3");
            //Assert
            isValid.ShouldBeFalse();
        }

        #endregion

        #region << DatesAsStrings >>

        [TestMethod]
        public void Greater_ValuesAreDatesAsStrings_Val1AndVal2_BothNull_ExpectTrue() {
            //Arrange
            GreaterModelOfDatesAsStrings model = new GreaterModelOfDatesAsStrings {Val1 = null, Val2 = null};
            //Act
            bool isValid = model.PropertyIsValid("Val2");
            //Assert
            isValid.ShouldBeTrue();
        }

        [TestMethod]
        public void Greater_ValuesAreDatesAsStrings_Val1IsNullAndVal2IsNotNull_ExpectTrue() {
            //Arrange
            GreaterModelOfDatesAsStrings model = new GreaterModelOfDatesAsStrings { Val1 = null, Val2 = DateTime.Now.ToShortDateString() };
            //Act
            bool isValid = model.PropertyIsValid("Val2");
            //Assert
            isValid.ShouldBeTrue();
        }

        [TestMethod]
        public void Greater_ValuesAreDatesAsStrings_Val2EqualsVal1_ExpectFalse() {
            //Arrange
            DateTime date = DateTime.Now.Date;
            GreaterModelOfDatesAsStrings model = new GreaterModelOfDatesAsStrings { Val1 = date.ToShortDateString(), Val2 = date.ToShortDateString() };
            //Act
            bool isValid = model.PropertyIsValid("Val2");
            //Assert
            isValid.ShouldBeFalse();
        }

        [TestMethod]
        public void Greater_ValuesAreDatesAsStrings_Val2GreatersVal1_ExpectTrue() {
            //Arrange
            DateTime date = DateTime.Now.Date;
            GreaterModelOfDatesAsStrings model = new GreaterModelOfDatesAsStrings { Val1 = date.ToShortDateString(), Val2 = date.AddDays(1).ToShortDateString() };
            //Act
            bool isValid = model.PropertyIsValid("Val2");
            //Assert
            isValid.ShouldBeTrue();
        }

        [TestMethod]
        public void Greater_ValuesAreDatesAsStrings_Val1GreaterThanVal2_ExpectFalse() {
            //Arrange
            GreaterModelOfDatesAsStrings model = new GreaterModelOfDatesAsStrings { Val1 = DateTime.Now.ToShortDateString(), Val2 = DateTime.Now.AddDays(-1).ToShortDateString() };
            //Act
            bool isValid = model.PropertyIsValid("Val2");
            //Assert
            isValid.ShouldBeFalse();
        }

        [TestMethod]
        public void Greater_ValuesAreDatesAsStrings_SpecificValue_Val1GreaterThanSpecificValue_ExpectTrue() {
            //Arrange
            GreaterModelOfDatesAsStrings model = new GreaterModelOfDatesAsStrings { Val1 = DateTime.Now.ToShortDateString() };
            //Act
            bool isValid = model.PropertyIsValid("Val1");
            //Assert
            isValid.ShouldBeTrue();
        }

        [TestMethod]
        public void Greater_ValuesAreDatesAsStrings_SpecificValue_Val1EqualSpecificValue_ExpectFalse() {
            //Arrange
            GreaterModelOfDatesAsStrings model = new GreaterModelOfDatesAsStrings { Val1 = new DateTime(2010, 12, 31).ToShortDateString() };
            //Act
            bool isValid = model.PropertyIsValid("Val1");
            //Assert
            isValid.ShouldBeFalse();
        }

        [TestMethod]
        public void Greater_ValuesAreDatesAsStrings_SpecificValue_Val1NotGreaterThanSpecificValue_ExpectFalse() {
            //Arrange
            GreaterModelOfDatesAsStrings model = new GreaterModelOfDatesAsStrings {Val1 = new DateTime(1990, 1, 1).ToShortDateString()};
            //Act
            bool isValid = model.PropertyIsValid("Val1");
            //Assert
            isValid.ShouldBeFalse();
        }

        [TestMethod]
        public void Greater_ValuesAreDatesAsStrings_CompareToCurrentDate_Val3GreaterThanCurrentDate_ExpectTrue() {
            //Arrange
            GreaterModelOfDatesAsStrings model = new GreaterModelOfDatesAsStrings {Val3 = DateTime.Now.AddDays(1).ToShortDateString()};
            //Act
            bool isValid = model.PropertyIsValid("Val3");
            //Assert
            isValid.ShouldBeTrue();
        }

        [TestMethod]
        public void Greater_ValuesAreDatesAsStrings_CompareToCurrentDate_Val3EqualCurrentDate_ExpectFalse() {
            //Arrange
            GreaterModelOfDatesAsStrings model = new GreaterModelOfDatesAsStrings {Val3 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day).ToShortDateString()};
            //Act
            bool isValid = model.PropertyIsValid("Val3");
            //Assert
            isValid.ShouldBeFalse();
        }

        [TestMethod]
        public void Greater_ValuesAreDatesAsStrings_CompareToCurrentDate_Val3NotGreaterThanCurrentDate_ExpectFalse() {
            //Arrange
            GreaterModelOfDatesAsStrings model = new GreaterModelOfDatesAsStrings {Val3 = new DateTime(1990, 1, 1).ToShortDateString()};
            //Act
            bool isValid = model.PropertyIsValid("Val3");
            //Assert
            isValid.ShouldBeFalse();
        }

        #endregion
    }
}