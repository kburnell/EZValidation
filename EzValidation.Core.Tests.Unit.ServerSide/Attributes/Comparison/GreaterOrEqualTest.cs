using System;
using EzValidation.Core.Tests.Unit.Shared.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;

namespace EzValidation.Core.Tests.Unit.ServerSide.Attributes.Comparison {

    [TestClass]
    public class GreaterOrEqualTest {

        #region << Longs >>

        [TestMethod]
        public void GreaterOrEqual_ValuesAreLongs_Val1AndVal2_BothNull_ExpectTrue() {
            //Arrange
            GreaterOrEqualModelOfLongs model = new GreaterOrEqualModelOfLongs {Val1 = null, Val2 = null};
            //Act
            bool isValid = model.PropertyIsValid("Val2");
            //Assert
            isValid.ShouldBeTrue();
        }

        [TestMethod]
        public void GreaterOrEqual_ValuesAreLongs_Val1IsNullAndVal2IsNotNull_ExpectTrue() {
            //Arrange
            GreaterOrEqualModelOfLongs model = new GreaterOrEqualModelOfLongs {Val1 = null, Val2 = 1};
            //Act
            bool isValid = model.PropertyIsValid("Val2");
            //Assert
            isValid.ShouldBeTrue();
        }

        [TestMethod]
        public void GreaterOrEqual_ValuesAreLongs_Val2EqualsVal1_ExpectTrue() {
            //Arrange
            GreaterOrEqualModelOfLongs model = new GreaterOrEqualModelOfLongs {Val1 = 1, Val2 = 1};
            //Act
            bool isValid = model.PropertyIsValid("Val2");
            //Assert
            isValid.ShouldBeTrue();
        }

        [TestMethod]
        public void GreaterOrEqual_ValuesAreLongs_Val2GreaterOrEqualThanVal1_ExpectTrue() {
            //Arrange
            GreaterOrEqualModelOfLongs model = new GreaterOrEqualModelOfLongs {Val1 = 1, Val2 = 2};
            //Act
            bool isValid = model.PropertyIsValid("Val2");
            //Assert
            isValid.ShouldBeTrue();
        }

        [TestMethod]
        public void GreaterOrEqual_ValuesAreLongs_Val2LessThanVal2_ExpectFalse() {
            //Arrange
            GreaterOrEqualModelOfLongs model = new GreaterOrEqualModelOfLongs {Val1 = 2, Val2 = 1};
            //Act
            bool isValid = model.PropertyIsValid("Val2");
            //Assert
            isValid.ShouldBeFalse();
        }

        [TestMethod]
        public void GreaterOrEqual_ValuesAreLongs_SpecificValue_Val1GreaterThanSpecificValue_ExpectTrue() {
            //Arrange
            GreaterOrEqualModelOfLongs model = new GreaterOrEqualModelOfLongs {Val1 = 2};
            //Act
            bool isValid = model.PropertyIsValid("Val1");
            //Assert
            isValid.ShouldBeTrue();
        }

        [TestMethod]
        public void GreaterOrEqual_ValuesAreLongs_SpecificValue_Val1EqualSpecificValue_ExpectTrue() {
            //Arrange
            GreaterOrEqualModelOfLongs model = new GreaterOrEqualModelOfLongs {Val1 = 1};
            //Act
            bool isValid = model.PropertyIsValid("Val1");
            //Assert
            isValid.ShouldBeTrue();
        }

        [TestMethod]
        public void GreaterOrEqual_ValuesAreLongs_SpecificValue_Val1NotGreaterThanSpecificValue_ExpectFalse() {
            //Arrange
            GreaterOrEqualModelOfLongs model = new GreaterOrEqualModelOfLongs {Val1 = 0};
            //Act
            bool isValid = model.PropertyIsValid("Val1");
            //Assert
            isValid.ShouldBeFalse();
        }

        #endregion

        #region << Dates >>

        [TestMethod]
        public void GreaterOrEqual_ValuesAreDates_Val1AndVal2_BothNull_ExpectTrue() {
            //Arrange
            GreaterOrEqualModelOfDates model = new GreaterOrEqualModelOfDates {Val1 = null, Val2 = null};
            //Act
            bool isValid = model.PropertyIsValid("Val2");
            //Assert
            isValid.ShouldBeTrue();
        }

        [TestMethod]
        public void GreaterOrEqual_ValuesAreDates_Val1IsNullAndVal2IsNotNull_ExpectTrue() {
            //Arrange
            GreaterOrEqualModelOfDates model = new GreaterOrEqualModelOfDates {Val1 = null, Val2 = DateTime.Now};
            //Act
            bool isValid = model.PropertyIsValid("Val2");
            //Assert
            isValid.ShouldBeTrue();
        }

        [TestMethod]
        public void GreaterOrEqual_ValuesAreDates_Val2EqualsVal1_ExpectTrue() {
            //Arrange
            DateTime date = DateTime.Now.Date;
            GreaterOrEqualModelOfDates model = new GreaterOrEqualModelOfDates {Val1 = date, Val2 = date};
            //Act
            bool isValid = model.PropertyIsValid("Val2");
            //Assert
            isValid.ShouldBeTrue();
        }

        [TestMethod]
        public void GreaterOrEqual_ValuesAreDates_Val2GreaterOrEqualsVal1_ExpectTrue() {
            //Arrange
            DateTime date = DateTime.Now.Date;
            GreaterOrEqualModelOfDates model = new GreaterOrEqualModelOfDates {Val1 = date, Val2 = date.AddDays(1)};
            //Act
            bool isValid = model.PropertyIsValid("Val2");
            //Assert
            isValid.ShouldBeTrue();
        }

        [TestMethod]
        public void GreaterOrEqual_ValuesAreDates_Val1GreaterOrEqualThanVal2_ExpectFalse() {
            //Arrange
            GreaterOrEqualModelOfDates model = new GreaterOrEqualModelOfDates {Val1 = DateTime.Now, Val2 = DateTime.Now.AddDays(-1)};
            //Act
            bool isValid = model.PropertyIsValid("Val2");
            //Assert
            isValid.ShouldBeFalse();
        }

        [TestMethod]
        public void GreaterOrEqual_ValuesAreDates_SpecificValue_Val1GreaterThanSpecificValue_ExpectTrue()
        {
            //Arrange
            GreaterOrEqualModelOfDates model = new GreaterOrEqualModelOfDates { Val1 = DateTime.Now };
            //Act
            bool isValid = model.PropertyIsValid("Val1");
            //Assert
            isValid.ShouldBeTrue();
        }

        [TestMethod]
        public void GreaterOrEqual_ValuesAreDates_SpecificValue_Val1EqualSpecificValue_ExpectTrue()
        {
            //Arrange
            GreaterOrEqualModelOfDates model = new GreaterOrEqualModelOfDates { Val1 = new DateTime(2010, 12, 31) };
            //Act
            bool isValid = model.PropertyIsValid("Val1");
            //Assert
            isValid.ShouldBeTrue();
        }

        [TestMethod]
        public void GreaterOrEqual_ValuesAreDates_SpecificValue_Val1NotGreaterThanSpecificValue_ExpectFalse()
        {
            //Arrange
            GreaterOrEqualModelOfDates model = new GreaterOrEqualModelOfDates { Val1 = new DateTime(1990, 1, 1) };
            //Act
            bool isValid = model.PropertyIsValid("Val1");
            //Assert
            isValid.ShouldBeFalse();
        }

        [TestMethod]
        public void GreaterOrEqual_ValuesAreDates_CompareToCurrentDate_Val3GreaterThanCurrentDate_ExpectTrue()
        {
            //Arrange
            GreaterOrEqualModelOfDates model = new GreaterOrEqualModelOfDates { Val3 = DateTime.Now.AddDays(1) };
            //Act
            bool isValid = model.PropertyIsValid("Val3");
            //Assert
            isValid.ShouldBeTrue();
        }

        [TestMethod]
        public void GreaterOrEqual_ValuesAreDates_CompareToCurrentDate_Val3EqualCurrentDate_ExpectTrue()
        {
            //Arrange
            GreaterOrEqualModelOfDates model = new GreaterOrEqualModelOfDates { Val3 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day) };
            //Act
            bool isValid = model.PropertyIsValid("Val1");
            //Assert
            isValid.ShouldBeTrue();
        }

        [TestMethod]
        public void GreaterOrEqual_ValuesAreDates_CompareToCurrentDate_Val3NotGreaterThanCurrentDate_ExpectFalse()
        {
            //Arrange
            GreaterOrEqualModelOfDates model = new GreaterOrEqualModelOfDates { Val3 = new DateTime(1990, 1, 1) };
            //Act
            bool isValid = model.PropertyIsValid("Val3");
            //Assert
            isValid.ShouldBeFalse();
        }

        #endregion

        #region << DatesAsStrings >>

        [TestMethod]
        public void GreaterOrEqual_ValuesAreDatesAsStrings_Val1AndVal2_BothNull_ExpectTrue()
        {
            //Arrange
            GreaterOrEqualModelOfDatesAsStrings model = new GreaterOrEqualModelOfDatesAsStrings { Val1 = null, Val2 = null };
            //Act
            bool isValid = model.PropertyIsValid("Val2");
            //Assert
            isValid.ShouldBeTrue();
        }

        [TestMethod]
        public void GreaterOrEqual_ValuesAreDatesAsStrings_Val1IsNullAndVal2IsNotNull_ExpectTrue()
        {
            //Arrange
            GreaterOrEqualModelOfDatesAsStrings model = new GreaterOrEqualModelOfDatesAsStrings { Val1 = null, Val2 = DateTime.Now.ToShortDateString() };
            //Act
            bool isValid = model.PropertyIsValid("Val2");
            //Assert
            isValid.ShouldBeTrue();
        }

        [TestMethod]
        public void GreaterOrEqual_ValuesAreDatesAsStrings_Val2EqualsVal1_ExpectTrue()
        {
            //Arrange
            DateTime date = DateTime.Now.Date;
            GreaterOrEqualModelOfDatesAsStrings model = new GreaterOrEqualModelOfDatesAsStrings { Val1 = date.ToShortDateString(), Val2 = date.ToShortDateString() };
            //Act
            bool isValid = model.PropertyIsValid("Val2");
            //Assert
            isValid.ShouldBeTrue();
        }

        [TestMethod]
        public void GreaterOrEqual_ValuesAreDatesAsStrings_Val2GreaterOrEqualsVal1_ExpectTrue()
        {
            //Arrange
            DateTime date = DateTime.Now.Date;
            GreaterOrEqualModelOfDatesAsStrings model = new GreaterOrEqualModelOfDatesAsStrings { Val1 = date.ToShortDateString(), Val2 = date.AddDays(1).ToShortDateString() };
            //Act
            bool isValid = model.PropertyIsValid("Val2");
            //Assert
            isValid.ShouldBeTrue();
        }

        [TestMethod]
        public void GreaterOrEqual_ValuesAreDatesAsStrings_Val1GreaterOrEqualThanVal2_ExpectFalse()
        {
            //Arrange
            GreaterOrEqualModelOfDatesAsStrings model = new GreaterOrEqualModelOfDatesAsStrings { Val1 = DateTime.Now.ToShortDateString(), Val2 = DateTime.Now.AddDays(-1).ToShortDateString() };
            //Act
            bool isValid = model.PropertyIsValid("Val2");
            //Assert
            isValid.ShouldBeFalse();
        }

        [TestMethod]
        public void GreaterOrEqual_ValuesAreDatesAsStrings_SpecificValue_Val1GreaterThanSpecificValue_ExpectTrue()
        {
            //Arrange
            GreaterOrEqualModelOfDatesAsStrings model = new GreaterOrEqualModelOfDatesAsStrings { Val1 = DateTime.Now.ToShortDateString() };
            //Act
            bool isValid = model.PropertyIsValid("Val1");
            //Assert
            isValid.ShouldBeTrue();
        }

        [TestMethod]
        public void GreaterOrEqual_ValuesAreDatesAsStrings_SpecificValue_Val1EqualSpecificValue_ExpectTrue()
        {
            //Arrange
            GreaterOrEqualModelOfDatesAsStrings model = new GreaterOrEqualModelOfDatesAsStrings { Val1 = new DateTime(2010, 12, 31).ToShortDateString() };
            //Act
            bool isValid = model.PropertyIsValid("Val1");
            //Assert
            isValid.ShouldBeTrue();
        }

        [TestMethod]
        public void GreaterOrEqual_ValuesAreDatesAsStrings_SpecificValue_Val1NotGreaterThanSpecificValue_ExpectFalse()
        {
            //Arrange
            GreaterOrEqualModelOfDatesAsStrings model = new GreaterOrEqualModelOfDatesAsStrings { Val1 = new DateTime(1990, 1, 1).ToShortDateString() };
            //Act
            bool isValid = model.PropertyIsValid("Val1");
            //Assert
            isValid.ShouldBeFalse();
        }

        [TestMethod]
        public void GreaterOrEqual_ValuesAreDatesAsStrings_CompareToCurrentDate_Val3GreaterThanCurrentDate_ExpectTrue()
        {
            //Arrange
            GreaterOrEqualModelOfDatesAsStrings model = new GreaterOrEqualModelOfDatesAsStrings { Val3 = DateTime.Now.AddDays(1).ToShortDateString() };
            //Act
            bool isValid = model.PropertyIsValid("Val3");
            //Assert
            isValid.ShouldBeTrue();
        }

        [TestMethod]
        public void GreaterOrEqual_ValuesAreDatesAsStrings_CompareToCurrentDate_Val3EqualCurrentDate_ExpectTrue()
        {
            //Arrange
            GreaterOrEqualModelOfDatesAsStrings model = new GreaterOrEqualModelOfDatesAsStrings { Val3 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day).ToShortDateString() };
            //Act
            bool isValid = model.PropertyIsValid("Val1");
            //Assert
            isValid.ShouldBeTrue();
        }

        [TestMethod]
        public void GreaterOrEqual_ValuesAreDatesAsStrings_CompareToCurrentDate_Val3NotGreaterThanCurrentDate_ExpectFalse()
        {
            //Arrange
            GreaterOrEqualModelOfDatesAsStrings model = new GreaterOrEqualModelOfDatesAsStrings { Val3 = new DateTime(1990, 1, 1).ToShortDateString() };
            //Act
            bool isValid = model.PropertyIsValid("Val3");
            //Assert
            isValid.ShouldBeFalse();
        }

        #endregion
    }
}