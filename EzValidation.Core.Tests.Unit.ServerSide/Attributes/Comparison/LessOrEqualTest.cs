using System;
using EzValidation.Core.Tests.Unit.Shared.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;

namespace EzValidation.Core.Tests.Unit.ServerSide.Attributes.Comparison {

    [TestClass]
    public class LessOrEqualTest {

        #region << Longs >>

        [TestMethod]
        public void LessOrEqual_ValuesAreLongs_Val1AndVal2_BothNull_ExpectTrue() {
            //Arrange
            LessOrEqualModelOfLongs model = new LessOrEqualModelOfLongs {Val1 = null, Val2 = null};
            //Act
            bool isValid = model.PropertyIsValid("Val2");
            //Assert
            isValid.ShouldBeTrue();
        }

        [TestMethod]
        public void LessOrEqual_ValuesAreLongs_Val1IsNullAndVal2IsNotNull_ExpectFalse() {
            //Arrange
            LessOrEqualModelOfLongs model = new LessOrEqualModelOfLongs {Val1 = null, Val2 = 1};
            //Act
            bool isValid = model.PropertyIsValid("Val2");
            //Assert
            isValid.ShouldBeFalse();
        }

        [TestMethod]
        public void LessOrEqual_ValuesAreLongs_Val1IsNotNullAndVal2IsNull_ExpectTrue() {
            //Arrange
            LessOrEqualModelOfLongs model = new LessOrEqualModelOfLongs {Val1 = 1, Val2 = null};
            //Act
            bool isValid = model.PropertyIsValid("Val2");
            //Assert
            isValid.ShouldBeTrue();
        }

        [TestMethod]
        public void LessOrEqual_ValuesAreLongs_Val2EqualsVal1_ExpectTrue() {
            //Arrange
            LessOrEqualModelOfLongs model = new LessOrEqualModelOfLongs {Val1 = 1, Val2 = 1};
            //Act
            bool isValid = model.PropertyIsValid("Val2");
            //Assert
            isValid.ShouldBeTrue();
        }

        [TestMethod]
        public void LessOrEqual_ValuesAreLongs_Val2LessOrEqualThanVal1_ExpectTrue() {
            //Arrange
            LessOrEqualModelOfLongs model = new LessOrEqualModelOfLongs {Val1 = 2, Val2 = 1};
            //Act
            bool isValid = model.PropertyIsValid("Val2");
            //Assert
            isValid.ShouldBeTrue();
        }

        [TestMethod]
        public void LessOrEqual_ValuesAreLongs_Val1LessOrEqualThanVal2_ExpectFalse() {
            //Arrange
            LessOrEqualModelOfLongs model = new LessOrEqualModelOfLongs {Val1 = 1, Val2 = 2};
            //Act
            bool isValid = model.PropertyIsValid("Val2");
            //Assert
            isValid.ShouldBeFalse();
        }

        [TestMethod]
        public void LessOrEqual_ValuesAreLongs_SpecificValue_Val1LessThanSpecificValue_ExpectTrue() {
            //Arrange
            LessOrEqualModelOfLongs model = new LessOrEqualModelOfLongs {Val1 = 0};
            //Act
            bool isValid = model.PropertyIsValid("Val1");
            //Assert
            isValid.ShouldBeTrue();
        }

        [TestMethod]
        public void LessOrEqual_ValuesAreLongs_SpecificValue_Val1EqualSpecificValue_ExpectTrue() {
            //Arrange
            LessOrEqualModelOfLongs model = new LessOrEqualModelOfLongs {Val1 = 1};
            //Act
            bool isValid = model.PropertyIsValid("Val1");
            //Assert
            isValid.ShouldBeTrue();
        }

        [TestMethod]
        public void LessOrEqual_ValuesAreLongs_SpecificValue_Val1NotLessThanSpecificValue_ExpectFalse() {
            //Arrange
            LessOrEqualModelOfLongs model = new LessOrEqualModelOfLongs {Val1 = 2};
            //Act
            bool isValid = model.PropertyIsValid("Val1");
            //Assert
            isValid.ShouldBeFalse();
        }

        #endregion

        #region << Dates >>

        [TestMethod]
        public void LessOrEqual_ValuesAreDates_Val1AndVal2_BothNull_ExpectTrue() {
            //Arrange
            LessOrEqualModelOfDates model = new LessOrEqualModelOfDates {Val1 = null, Val2 = null};
            //Act
            bool isValid = model.PropertyIsValid("Val2");
            //Assert
            isValid.ShouldBeTrue();
        }

        [TestMethod]
        public void LessOrEqual_ValuesAreDates_Val1IsNullAndVal2IsNotNull_ExpectFalse() {
            //Arrange
            LessOrEqualModelOfDates model = new LessOrEqualModelOfDates {Val1 = null, Val2 = DateTime.Now};
            //Act
            bool isValid = model.PropertyIsValid("Val2");
            //Assert
            isValid.ShouldBeFalse();
        }

        [TestMethod]
        public void LessOrEqual_ValuesAreDates_Val1IsNotNullAndVal2IsNull_ExpectTrue() {
            //Arrange
            LessOrEqualModelOfDates model = new LessOrEqualModelOfDates {Val1 = DateTime.Now, Val2 = null};
            //Act
            bool isValid = model.PropertyIsValid("Val2");
            //Assert
            isValid.ShouldBeTrue();
        }

        [TestMethod]
        public void LessOrEqual_ValuesAreDates_Val2EqualsVal1_ExpectTrue() {
            //Arrange
            DateTime date = DateTime.Now.Date;
            LessOrEqualModelOfDates model = new LessOrEqualModelOfDates {Val1 = date, Val2 = date};
            //Act
            bool isValid = model.PropertyIsValid("Val2");
            //Assert
            isValid.ShouldBeTrue();
        }

        [TestMethod]
        public void LessOrEqual_ValuesAreDates_Val2LessThanVal1_ExpectTrue() {
            //Arrange
            DateTime date = DateTime.Now.Date;
            LessOrEqualModelOfDates model = new LessOrEqualModelOfDates {Val1 = date, Val2 = date.AddDays(-1)};
            //Act
            bool isValid = model.PropertyIsValid("Val2");
            //Assert
            isValid.ShouldBeTrue();
        }

        [TestMethod]
        public void LessOrEqual_ValuesAreDates_Val2GreaterThanVal2_ExpectFalse() {
            //Arrange
            LessOrEqualModelOfDates model = new LessOrEqualModelOfDates {Val1 = DateTime.Now, Val2 = DateTime.Now.AddDays(1)};
            //Act
            bool isValid = model.PropertyIsValid("Val2");
            //Assert
            isValid.ShouldBeFalse();
        }

        [TestMethod]
        public void LessOrEqual_ValuesAreDates_SpecificValue_Val1LessThanSpecificValue_ExpectTrue() {
            //Arrange
            LessOrEqualModelOfDates model = new LessOrEqualModelOfDates {Val1 = new DateTime(1990, 1, 1)};
            //Act
            bool isValid = model.PropertyIsValid("Val1");
            //Assert
            isValid.ShouldBeTrue();
        }

        [TestMethod]
        public void LessOrEqual_ValuesAreDates_SpecificValue_Val1EqualSpecificValue_ExpectTrue() {
            //Arrange
            LessOrEqualModelOfDates model = new LessOrEqualModelOfDates {Val1 = new DateTime(2010, 12, 31)};
            //Act
            bool isValid = model.PropertyIsValid("Val1");
            //Assert
            isValid.ShouldBeTrue();
        }

        [TestMethod]
        public void LessOrEqual_ValuesAreDates_SpecificValue_Val1NotLessThanSpecificValue_ExpectFalse() {
            //Arrange
            LessOrEqualModelOfDates model = new LessOrEqualModelOfDates {Val1 = new DateTime(2090, 1, 1)};
            //Act
            bool isValid = model.PropertyIsValid("Val1");
            //Assert
            isValid.ShouldBeFalse();
        }

        [TestMethod]
        public void LessOrEqual_ValuesAreDates_CompareToCurrentDate_Val3LessThanCurrentDate_ExpectTrue() {
            //Arrange
            LessOrEqualModelOfDates model = new LessOrEqualModelOfDates {Val3 = DateTime.Now.AddDays(-1)};
            //Act
            bool isValid = model.PropertyIsValid("Val3");
            //Assert
            isValid.ShouldBeTrue();
        }

        [TestMethod]
        public void LessOrEqual_ValuesAreDates_CompareToCurrentDate_Val3EqualCurrentDate_ExpectTrue() {
            //Arrange
            LessOrEqualModelOfDates model = new LessOrEqualModelOfDates {Val3 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day)};
            //Act
            bool isValid = model.PropertyIsValid("Val3");
            //Assert
            isValid.ShouldBeTrue();
        }

        [TestMethod]
        public void LessOrEqual_ValuesAreDates_CompareToCurrentDate_Val3NotLessThanCurrentDate_ExpectFalse() {
            //Arrange
            LessOrEqualModelOfDates model = new LessOrEqualModelOfDates {Val3 = DateTime.Now.AddDays(1)};
            //Act
            bool isValid = model.PropertyIsValid("Val3");
            //Assert
            isValid.ShouldBeFalse();
        }

        #endregion

        #region << DatesAsStrings >>

        [TestMethod]
        public void LessOrEqual_ValuesAreDatesAsStrings_Val1AndVal2_BothNull_ExpectTrue()
        {
            //Arrange
            LessOrEqualModelOfDatesAsStrings model = new LessOrEqualModelOfDatesAsStrings { Val1 = null, Val2 = null };
            //Act
            bool isValid = model.PropertyIsValid("Val2");
            //Assert
            isValid.ShouldBeTrue();
        }

        [TestMethod]
        public void LessOrEqual_ValuesAreDatesAsStrings_Val1IsNullAndVal2IsNotNull_ExpectFalse()
        {
            //Arrange
            LessOrEqualModelOfDatesAsStrings model = new LessOrEqualModelOfDatesAsStrings { Val1 = null, Val2 = DateTime.Now.ToShortDateString() };
            //Act
            bool isValid = model.PropertyIsValid("Val2");
            //Assert
            isValid.ShouldBeFalse();
        }

        [TestMethod]
        public void LessOrEqual_ValuesAreDatesAsStrings_Val1IsNotNullAndVal2IsNull_ExpectTrue()
        {
            //Arrange
            LessOrEqualModelOfDatesAsStrings model = new LessOrEqualModelOfDatesAsStrings { Val1 = DateTime.Now.ToShortDateString(), Val2 = null };
            //Act
            bool isValid = model.PropertyIsValid("Val2");
            //Assert
            isValid.ShouldBeTrue();
        }

        [TestMethod]
        public void LessOrEqual_ValuesAreDatesAsStrings_Val2EqualsVal1_ExpectTrue()
        {
            //Arrange
            DateTime date = DateTime.Now.Date;
            LessOrEqualModelOfDatesAsStrings model = new LessOrEqualModelOfDatesAsStrings { Val1 = date.ToShortDateString(), Val2 = date.ToShortDateString() };
            //Act
            bool isValid = model.PropertyIsValid("Val2");
            //Assert
            isValid.ShouldBeTrue();
        }

        [TestMethod]
        public void LessOrEqual_ValuesAreDatesAsStrings_Val2LessThanVal1_ExpectTrue()
        {
            //Arrange
            DateTime date = DateTime.Now.Date;
            LessOrEqualModelOfDatesAsStrings model = new LessOrEqualModelOfDatesAsStrings { Val1 = date.ToShortDateString(), Val2 = date.AddDays(-1).ToShortDateString() };
            //Act
            bool isValid = model.PropertyIsValid("Val2");
            //Assert
            isValid.ShouldBeTrue();
        }

        [TestMethod]
        public void LessOrEqual_ValuesAreDatesAsStrings_Val2GreaterThanVal2_ExpectFalse()
        {
            //Arrange
            LessOrEqualModelOfDatesAsStrings model = new LessOrEqualModelOfDatesAsStrings { Val1 = DateTime.Now.ToShortDateString(), Val2 = DateTime.Now.AddDays(1).ToShortDateString() };
            //Act
            bool isValid = model.PropertyIsValid("Val2");
            //Assert
            isValid.ShouldBeFalse();
        }

        [TestMethod]
        public void LessOrEqual_ValuesAreDatesAsStrings_SpecificValue_Val1LessThanSpecificValue_ExpectTrue()
        {
            //Arrange
            LessOrEqualModelOfDatesAsStrings model = new LessOrEqualModelOfDatesAsStrings { Val1 = new DateTime(1990, 1, 1).ToShortDateString() };
            //Act
            bool isValid = model.PropertyIsValid("Val1");
            //Assert
            isValid.ShouldBeTrue();
        }

        [TestMethod]
        public void LessOrEqual_ValuesAreDatesAsStrings_SpecificValue_Val1EqualSpecificValue_ExpectTrue()
        {
            //Arrange
            LessOrEqualModelOfDatesAsStrings model = new LessOrEqualModelOfDatesAsStrings { Val1 = new DateTime(2010, 12, 31).ToShortDateString() };
            //Act
            bool isValid = model.PropertyIsValid("Val1");
            //Assert
            isValid.ShouldBeTrue();
        }

        [TestMethod]
        public void LessOrEqual_ValuesAreDatesAsStrings_SpecificValue_Val1NotLessThanSpecificValue_ExpectFalse()
        {
            //Arrange
            LessOrEqualModelOfDatesAsStrings model = new LessOrEqualModelOfDatesAsStrings { Val1 = new DateTime(2090, 1, 1).ToShortDateString() };
            //Act
            bool isValid = model.PropertyIsValid("Val1");
            //Assert
            isValid.ShouldBeFalse();
        }

        [TestMethod]
        public void LessOrEqual_ValuesAreDatesAsStrings_CompareToCurrentDate_Val3LessThanCurrentDate_ExpectTrue()
        {
            //Arrange
            LessOrEqualModelOfDatesAsStrings model = new LessOrEqualModelOfDatesAsStrings { Val3 = DateTime.Now.AddDays(-1).ToShortDateString() };
            //Act
            bool isValid = model.PropertyIsValid("Val3");
            //Assert
            isValid.ShouldBeTrue();
        }

        [TestMethod]
        public void LessOrEqual_ValuesAreDatesAsStrings_CompareToCurrentDate_Val3EqualCurrentDate_ExpectTrue()
        {
            //Arrange
            LessOrEqualModelOfDatesAsStrings model = new LessOrEqualModelOfDatesAsStrings { Val3 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day).ToShortDateString() };
            //Act
            bool isValid = model.PropertyIsValid("Val3");
            //Assert
            isValid.ShouldBeTrue();
        }

        [TestMethod]
        public void LessOrEqual_ValuesAreDatesAsStrings_CompareToCurrentDate_Val3NotLessThanCurrentDate_ExpectFalse()
        {
            //Arrange
            LessOrEqualModelOfDatesAsStrings model = new LessOrEqualModelOfDatesAsStrings { Val3 = DateTime.Now.AddDays(1).ToShortDateString() };
            //Act
            bool isValid = model.PropertyIsValid("Val3");
            //Assert
            isValid.ShouldBeFalse();
        }

        #endregion
    }
}