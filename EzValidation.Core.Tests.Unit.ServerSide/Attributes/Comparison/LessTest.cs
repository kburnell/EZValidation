using System;
using EzValidation.Core.Tests.Unit.Shared.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;

namespace EzValidation.Core.Tests.Unit.ServerSide.Attributes.Comparison {

    [TestClass]
    public class LessTest {

        #region << Longs >>

        [TestMethod]
        public void Less_ValuesAreLongs_Val1AndVal2_BothNull_ExpectTrue() {
            //Arrange
            LessModelOfLongs model = new LessModelOfLongs {Val1 = null, Val2 = null};
            //Act
            bool isValid = model.PropertyIsValid("Val2");
            //Assert
            isValid.ShouldBeTrue();
        }

        [TestMethod]
        public void Less_ValuesAreLongs_Val1IsNullAndVal2IsNotNull_ExpectFalse() {
            //Arrange
            LessModelOfLongs model = new LessModelOfLongs {Val1 = null, Val2 = 1};
            //Act
            bool isValid = model.PropertyIsValid("Val2");
            //Assert
            isValid.ShouldBeFalse();
        }

        [TestMethod]
        public void Less_ValuesAreLongs_Val1IsNotNullAndVal2IsNull_ExpectTrue()
        {
            //Arrange
            LessModelOfLongs model = new LessModelOfLongs { Val1 = 1, Val2 = null };
            //Act
            bool isValid = model.PropertyIsValid("Val2");
            //Assert
            isValid.ShouldBeTrue();
        }

        [TestMethod]
        public void Less_ValuesAreLongs_Val2EqualsVal1_ExpectFalse() {
            //Arrange
            LessModelOfLongs model = new LessModelOfLongs {Val1 = 1, Val2 = 1};
            //Act
            bool isValid = model.PropertyIsValid("Val2");
            //Assert
            isValid.ShouldBeFalse();
        }

        [TestMethod]
        public void Less_ValuesAreLongs_Val2LessThanVal1_ExpectTrue() {
            //Arrange
            LessModelOfLongs model = new LessModelOfLongs {Val1 = 2, Val2 = 1};
            //Act
            bool isValid = model.PropertyIsValid("Val2");
            //Assert
            isValid.ShouldBeTrue();
        }

        [TestMethod]
        public void Less_ValuesAreLongs_Val1LessThanVal2_ExpectFalse() {
            //Arrange
            LessModelOfLongs model = new LessModelOfLongs {Val1 = 1, Val2 = 2};
            //Act
            bool isValid = model.PropertyIsValid("Val2");
            //Assert
            isValid.ShouldBeFalse();
        }

        [TestMethod]
        public void Less_ValuesAreLongs_SpecificValue_Val1LessThanSpecificValue_ExpectTrue()
        {
            //Arrange
            LessModelOfLongs model = new LessModelOfLongs { Val1 = 0 };
            //Act
            bool isValid = model.PropertyIsValid("Val1");
            //Assert
            isValid.ShouldBeTrue();
        }

        [TestMethod]
        public void Less_ValuesAreLongs_SpecificValue_Val1EqualSpecificValue_ExpectFalse()
        {
            //Arrange
            LessModelOfLongs model = new LessModelOfLongs { Val1 = 1 };
            //Act
            bool isValid = model.PropertyIsValid("Val1");
            //Assert
            isValid.ShouldBeFalse();
        }

        [TestMethod]
        public void Less_ValuesAreLongs_SpecificValue_Val1NotLessThanSpecificValue_ExpectFalse()
        {
            //Arrange
            LessModelOfLongs model = new LessModelOfLongs { Val1 = 2 };
            //Act
            bool isValid = model.PropertyIsValid("Val1");
            //Assert
            isValid.ShouldBeFalse();
        }

        #endregion

        #region << Dates >>

        [TestMethod]
        public void Less_ValuesAreDates_Val1AndVal2_BothNull_ExpectTrue() {
            //Arrange
            LessModelOfDates model = new LessModelOfDates {Val1 = null, Val2 = null};
            //Act
            bool isValid = model.PropertyIsValid("Val2");
            //Assert
            isValid.ShouldBeTrue();
        }

        [TestMethod]
        public void Less_ValuesAreDates_Val1IsNullAndVal2IsNotNull_ExpectFalse() {
            //Arrange
            LessModelOfDates model = new LessModelOfDates {Val1 = null, Val2 = DateTime.Now};
            //Act
            bool isValid = model.PropertyIsValid("Val2");
            //Assert
            isValid.ShouldBeFalse();
        }

        [TestMethod]
        public void Less_ValuesAreDates_Val1IsNotNullAndVal2IsNull_ExpectTrue()
        {
            //Arrange
            LessModelOfDates model = new LessModelOfDates { Val1 = DateTime.Now, Val2 = null };
            //Act
            bool isValid = model.PropertyIsValid("Val2");
            //Assert
            isValid.ShouldBeTrue();
        }

        [TestMethod]
        public void Less_ValuesAreDates_Val2EqualsVal1_ExpectFalse() {
            //Arrange
            DateTime date = DateTime.Now.Date;
            LessModelOfDates model = new LessModelOfDates {Val1 = date, Val2 = date};
            //Act
            bool isValid = model.PropertyIsValid("Val2");
            //Assert
            isValid.ShouldBeFalse();
        }

        [TestMethod]
        public void Less_ValuesAreDates_Val2LesssThanVal1_ExpectTrue() {
            //Arrange
            DateTime date = DateTime.Now.Date;
            LessModelOfDates model = new LessModelOfDates {Val1 = date, Val2 = date.AddDays(-1)};
            //Act
            bool isValid = model.PropertyIsValid("Val2");
            //Assert
            isValid.ShouldBeTrue();
        }

        [TestMethod]
        public void Less_ValuesAreDates_Val2NotLessThanVal2_ExpectFalse() {
            //Arrange
            LessModelOfDates model = new LessModelOfDates {Val1 = DateTime.Now, Val2 = DateTime.Now.AddDays(1)};
            //Act
            bool isValid = model.PropertyIsValid("Val2");
            //Assert
            isValid.ShouldBeFalse();
        }

        [TestMethod]
        public void Less_ValuesAreDates_SpecificValue_Val1LessThanSpecificValue_ExpectTrue()
        {
            //Arrange
            LessModelOfDates model = new LessModelOfDates { Val1 = new DateTime(1990,1,1)};
            //Act
            bool isValid = model.PropertyIsValid("Val1");
            //Assert
            isValid.ShouldBeTrue();
        }

        [TestMethod]
        public void Less_ValuesAreDates_SpecificValue_Val1EqualSpecificValue_ExpectFalse()
        {
            //Arrange
            LessModelOfDates model = new LessModelOfDates { Val1 = new DateTime(2010, 12, 31) };
            //Act
            bool isValid = model.PropertyIsValid("Val1");
            //Assert
            isValid.ShouldBeFalse();
        }

        [TestMethod]
        public void Less_ValuesAreDates_SpecificValue_Val1NotLessThanSpecificValue_ExpectFalse()
        {
            //Arrange
            LessModelOfDates model = new LessModelOfDates { Val1 = new DateTime(2090, 1, 1) };
            //Act
            bool isValid = model.PropertyIsValid("Val1");
            //Assert
            isValid.ShouldBeFalse();
        }

        [TestMethod]
        public void Less_ValuesAreDates_CompareToCurrentDate_Val3LessThanCurrentDate_ExpectTrue()
        {
            //Arrange
            LessModelOfDates model = new LessModelOfDates { Val3 = DateTime.Now.AddDays(-1) };
            //Act
            bool isValid = model.PropertyIsValid("Val3");
            //Assert
            isValid.ShouldBeTrue();
        }

        [TestMethod]
        public void Less_ValuesAreDates_CompareToCurrentDate_Val3EqualCurrentDate_ExpectFalse()
        {
            //Arrange
            LessModelOfDates model = new LessModelOfDates { Val3 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day) };
            //Act
            bool isValid = model.PropertyIsValid("Val3");
            //Assert
            isValid.ShouldBeFalse();
        }

        [TestMethod]
        public void Less_ValuesAreDates_CompareToCurrentDate_Val3NotLessThanCurrentDate_ExpectFalse()
        {
            //Arrange
            LessModelOfDates model = new LessModelOfDates { Val3 = DateTime.Now.AddDays(1) };
            //Act
            bool isValid = model.PropertyIsValid("Val3");
            //Assert
            isValid.ShouldBeFalse();
        }

        #endregion

        #region << DatesAsStrings >>

        [TestMethod]
        public void Less_ValuesAreDatesAsStrings_Val1AndVal2_BothNull_ExpectTrue()
        {
            //Arrange
            LessModelOfDatesAsStrings model = new LessModelOfDatesAsStrings { Val1 = null, Val2 = null };
            //Act
            bool isValid = model.PropertyIsValid("Val2");
            //Assert
            isValid.ShouldBeTrue();
        }

        [TestMethod]
        public void Less_ValuesAreDatesAsStrings_Val1IsNullAndVal2IsNotNull_ExpectFalse()
        {
            //Arrange
            LessModelOfDatesAsStrings model = new LessModelOfDatesAsStrings { Val1 = null, Val2 = DateTime.Now.ToShortDateString() };
            //Act
            bool isValid = model.PropertyIsValid("Val2");
            //Assert
            isValid.ShouldBeFalse();
        }

        [TestMethod]
        public void Less_ValuesAreDatesAsStrings_Val1IsNotNullAndVal2IsNull_ExpectTrue()
        {
            //Arrange
            LessModelOfDatesAsStrings model = new LessModelOfDatesAsStrings { Val1 = DateTime.Now.ToShortDateString(), Val2 = null };
            //Act
            bool isValid = model.PropertyIsValid("Val2");
            //Assert
            isValid.ShouldBeTrue();
        }

        [TestMethod]
        public void Less_ValuesAreDatesAsStrings_Val2EqualsVal1_ExpectFalse()
        {
            //Arrange
            DateTime date = DateTime.Now.Date;
            LessModelOfDatesAsStrings model = new LessModelOfDatesAsStrings { Val1 = date.ToShortDateString(), Val2 = date.ToShortDateString() };
            //Act
            bool isValid = model.PropertyIsValid("Val2");
            //Assert
            isValid.ShouldBeFalse();
        }

        [TestMethod]
        public void Less_ValuesAreDatesAsStrings_Val2LesssThanVal1_ExpectTrue()
        {
            //Arrange
            DateTime date = DateTime.Now.Date;
            LessModelOfDatesAsStrings model = new LessModelOfDatesAsStrings { Val1 = date.ToShortDateString(), Val2 = date.AddDays(-1).ToShortDateString() };
            //Act
            bool isValid = model.PropertyIsValid("Val2");
            //Assert
            isValid.ShouldBeTrue();
        }

        [TestMethod]
        public void Less_ValuesAreDatesAsStrings_Val2NotLessThanVal2_ExpectFalse()
        {
            //Arrange
            LessModelOfDatesAsStrings model = new LessModelOfDatesAsStrings { Val1 = DateTime.Now.ToShortDateString(), Val2 = DateTime.Now.AddDays(1).ToShortDateString() };
            //Act
            bool isValid = model.PropertyIsValid("Val2");
            //Assert
            isValid.ShouldBeFalse();
        }

        [TestMethod]
        public void Less_ValuesAreDatesAsStrings_SpecificValue_Val1LessThanSpecificValue_ExpectTrue()
        {
            //Arrange
            LessModelOfDatesAsStrings model = new LessModelOfDatesAsStrings { Val1 = new DateTime(1990, 1, 1).ToShortDateString() };
            //Act
            bool isValid = model.PropertyIsValid("Val1");
            //Assert
            isValid.ShouldBeTrue();
        }

        [TestMethod]
        public void Less_ValuesAreDatesAsStrings_SpecificValue_Val1EqualSpecificValue_ExpectFalse()
        {
            //Arrange
            LessModelOfDatesAsStrings model = new LessModelOfDatesAsStrings { Val1 = new DateTime(2010, 12, 31).ToShortDateString() };
            //Act
            bool isValid = model.PropertyIsValid("Val1");
            //Assert
            isValid.ShouldBeFalse();
        }

        [TestMethod]
        public void Less_ValuesAreDatesAsStrings_SpecificValue_Val1NotLessThanSpecificValue_ExpectFalse()
        {
            //Arrange
            LessModelOfDatesAsStrings model = new LessModelOfDatesAsStrings { Val1 = new DateTime(2090, 1, 1).ToShortDateString() };
            //Act
            bool isValid = model.PropertyIsValid("Val1");
            //Assert
            isValid.ShouldBeFalse();
        }

        [TestMethod]
        public void Less_ValuesAreDatesAsStrings_CompareToCurrentDate_Val3LessThanCurrentDate_ExpectTrue()
        {
            //Arrange
            LessModelOfDatesAsStrings model = new LessModelOfDatesAsStrings { Val3 = DateTime.Now.AddDays(-1).ToShortDateString() };
            //Act
            bool isValid = model.PropertyIsValid("Val3");
            //Assert
            isValid.ShouldBeTrue();
        }

        [TestMethod]
        public void Less_ValuesAreDatesAsStrings_CompareToCurrentDate_Val3EqualCurrentDate_ExpectFalse()
        {
            //Arrange
            LessModelOfDatesAsStrings model = new LessModelOfDatesAsStrings { Val3 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day).ToShortDateString() };
            //Act
            bool isValid = model.PropertyIsValid("Val3");
            //Assert
            isValid.ShouldBeFalse();
        }

        [TestMethod]
        public void Less_ValuesAreDatesAsStrings_CompareToCurrentDate_Val3NotLessThanCurrentDate_ExpectFalse()
        {
            //Arrange
            LessModelOfDatesAsStrings model = new LessModelOfDatesAsStrings { Val3 = DateTime.Now.AddDays(1).ToShortDateString() };
            //Act
            bool isValid = model.PropertyIsValid("Val3");
            //Assert
            isValid.ShouldBeFalse();
        }

        #endregion
    }
}