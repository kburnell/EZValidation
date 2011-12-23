using System;
using EzValidation.Core.Tests.Unit.Shared.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;

namespace EzValidation.Core.Tests.Unit.ServerSide.Attributes.Comparison {
    [TestClass]
    public class EqualTest {
        #region << Strings >>

        [TestMethod]
        public void Equal_ValuesAreStrings_Val1AndVal2BothEmpty_ExpectTrue() {
            //Arrange
            const string str = "";
            EqualModelOfStrings model = new EqualModelOfStrings {Val1 = str, Val2 = str};
            //Act
            bool isValid = model.PropertyIsValid("Val2");
            //Assert
            isValid.ShouldBeTrue();
        }

        [TestMethod]
        public void Equal_ValuesAreStrings_Val1IsEmptyAndVal2IsNot_ExpectFalse() {
            //Arrange
            const string str = "";
            const string otherStr = "Other String";
            EqualModelOfStrings model = new EqualModelOfStrings {Val1 = str, Val2 = otherStr};
            //Act
            bool isValid = model.PropertyIsValid("Val2");
            //Assert
            isValid.ShouldBeFalse();
        }

        [TestMethod]
        public void Equal_ValuesAreStrings_Val1EqualsVal2_ExpectTrue() {
            //Arrange
            const string str = "Hello World";
            EqualModelOfStrings model = new EqualModelOfStrings {Val1 = str, Val2 = str};
            //Act
            bool isValid = model.PropertyIsValid("Val2");
            //Assert
            isValid.ShouldBeTrue();
        }

        [TestMethod]
        public void Equal_ValuesAreStrings_Val1DoesNotEqualVal2_ExpectFalse() {
            //Arrange
            const string str = "Hello World";
            EqualModelOfStrings model = new EqualModelOfStrings {Val1 = str, Val2 = str + "XXX"};
            //Act
            bool isValid = model.PropertyIsValid("Val2");
            //Assert
            isValid.ShouldBeFalse();
        }

        [TestMethod]
        public void Equal_ValuesAreStrings_SpecificValue_Val1EqualsSpecificValue_ExpectTrue() {
            //Arrange
            const string str = "Hello World";
            EqualModelOfStrings model = new EqualModelOfStrings {Val1 = str};
            //Act
            bool isValid = model.PropertyIsValid("Val1");
            //Assert
            isValid.ShouldBeTrue();
        }

        [TestMethod]
        public void Equal_ValuesAreStrings_SpecificValue_Val1DoesNotEqualSpecificValue_ExpectFalse() {
            //Arrange
            const string str = "Goodbye World";
            EqualModelOfStrings model = new EqualModelOfStrings {Val1 = str};
            //Act
            bool isValid = model.PropertyIsValid("Val1");
            //Assert
            isValid.ShouldBeFalse();
        }

        [TestMethod]
        public void Equal_ValuesAreStrings_CompareToCurrentDate_Val3EqualsCurrentDate_ExpectTrue() {
            //Arrange
            string str = DateTime.Now.ToShortDateString();
            EqualModelOfStrings model = new EqualModelOfStrings {Val3 = str};
            //Act
            bool isValid = model.PropertyIsValid("Val3");
            //Assert
            isValid.ShouldBeTrue();
        }

        [TestMethod]
        public void Equal_ValuesAreStrings_CompareToCurrentDate_Val3DoesNotEqualCurrentDate_ExpectFalse() {
            //Arrange
            string str = "Hello World";
            EqualModelOfStrings model = new EqualModelOfStrings {Val3 = str};
            //Act
            bool isValid = model.PropertyIsValid("Val3");
            //Assert
            isValid.ShouldBeFalse();
        }

        #endregion

        #region << Longs >>

        [TestMethod]
        public void Equal_ValuesAreLongs_Val1AndVal2_BothNull_ExpectTrue() {
            //Arrange
            EqualModelOfLongs model = new EqualModelOfLongs {Val1 = null, Val2 = null};
            //Act
            bool isValid = model.PropertyIsValid("Val2");
            //Assert
            isValid.ShouldBeTrue();
        }

        [TestMethod]
        public void Equal_ValuesAreLongs_Val1IsNullAndVal2IsNotNull_ExpectFalse() {
            //Arrange
            EqualModelOfLongs model = new EqualModelOfLongs {Val1 = null, Val2 = 1};
            //Act
            bool isValid = model.PropertyIsValid("Val2");
            //Assert
            isValid.ShouldBeFalse();
        }

        [TestMethod]
        public void Equal_ValuesAreLongs_Val1EqualsVal2_ExpectTrue() {
            //Arrange
            EqualModelOfLongs model = new EqualModelOfLongs {Val1 = 1, Val2 = 1};
            //Act
            bool isValid = model.PropertyIsValid("Val2");
            //Assert
            isValid.ShouldBeTrue();
        }

        [TestMethod]
        public void Equal_ValuesAreLongs_Val1DoesNotEqualVal2_ExpectFalse() {
            //Arrange
            EqualModelOfLongs model = new EqualModelOfLongs {Val1 = 1, Val2 = 2};
            //Act
            bool isValid = model.PropertyIsValid("Val2");
            //Assert
            isValid.ShouldBeFalse();
        }

        [TestMethod]
        public void Equal_ValuesAreLongs_SpecificValue_Val1EqualsSpecificValue_ExpectTrue() {
            //Arrange
            EqualModelOfLongs model = new EqualModelOfLongs {Val1 = 99};
            //Act
            bool isValid = model.PropertyIsValid("Val1");
            //Assert
            isValid.ShouldBeTrue();
        }

        [TestMethod]
        public void Equal_ValuesAreLongs_SpecificValue_Val1DoesNotEqualSpecificValue_ExpectFalse() {
            //Arrange
            EqualModelOfLongs model = new EqualModelOfLongs {Val1 = 100};
            //Act
            bool isValid = model.PropertyIsValid("Val1");
            //Assert
            isValid.ShouldBeFalse();
        }

        #endregion

        #region << Dates >>

        #region << Model Property >>

        [TestMethod]
        public void Equal_ValuesAreDates_Val1AndVal2_BothNull_ExpectTrue() {
            //Arrange
            EqualModelOfDates model = new EqualModelOfDates {Val1 = null, Val2 = null};
            //Act
            bool isValid = model.PropertyIsValid("Val2");
            //Assert
            isValid.ShouldBeTrue();
        }

        [TestMethod]
        public void Equal_ValuesAreDates_Val1IsNullAndVal2IsNotNull_ExpectFalse() {
            //Arrange
            EqualModelOfDates model = new EqualModelOfDates {Val1 = null, Val2 = DateTime.Now};
            //Act
            bool isValid = model.PropertyIsValid("Val2");
            //Assert
            isValid.ShouldBeFalse();
        }

        [TestMethod]
        public void Equal_ValuesAreDates_Val1EqualsVal2_ExpectTrue() {
            //Arrange
            DateTime date = DateTime.Now.Date;
            EqualModelOfDates model = new EqualModelOfDates {Val1 = date, Val2 = date};
            //Act
            bool isValid = model.PropertyIsValid("Val2");
            //Assert
            isValid.ShouldBeTrue();
        }

        [TestMethod]
        public void Equal_ValuesAreDates_Val1DoesNotEqualVal2_ExpectFalse() {
            //Arrange
            EqualModelOfDates model = new EqualModelOfDates {Val1 = DateTime.Now, Val2 = DateTime.Now.AddDays(1)};
            //Act
            bool isValid = model.PropertyIsValid("Val2");
            //Assert
            isValid.ShouldBeFalse();
        }

        #endregion

        #region << Specific Value >>

        [TestMethod]
        public void Equal_ValuesAreDates_SpecificValue_Val1EqualsSpecificValue_ExpectTrue() {
            //Arrange
            EqualModelOfDates model = new EqualModelOfDates {Val1 = new DateTime(2010, 12, 31)};
            //Act
            bool isValid = model.PropertyIsValid("Val1");
            //Assert
            isValid.ShouldBeTrue();
        }

        [TestMethod]
        public void Equal_ValuesAreDates_SpecificValue_Val1DoesNotEqualSpecificValue_ExpectFalse() {
            //Arrange
            EqualModelOfDates model = new EqualModelOfDates {Val1 = DateTime.Now};
            //Act
            bool isValid = model.PropertyIsValid("Val1");
            //Assert
            isValid.ShouldBeFalse();
        }

        #endregion

        #region << Current Date >>

        [TestMethod]
        public void Equal_ValuesAreDates_CurrentDate_Val3EqualsCurrentDate_ExpectTrue() {
            //Arrange
            EqualModelOfDates model = new EqualModelOfDates {Val3 = DateTime.Now.Date};
            //Act
            bool isValid = model.PropertyIsValid("Val3");
            //Assert
            isValid.ShouldBeTrue();
        }

        [TestMethod]
        public void Equal_ValuesAreDates_CurrentDate_Val3DoesNotEqualCurrentDate_ExpectFalse() {
            //Arrange
            EqualModelOfDates model = new EqualModelOfDates{Val3 = DateTime.Now.AddDays(-1).Date};
            //Act
            bool isValid = model.PropertyIsValid("Val3");
            //Assert
            isValid.ShouldBeFalse();
        }

        #endregion

        #region << Yesterday >>

        [TestMethod]
        public void Equal_ValuesAreDates_Yesterday_Val6EqualsYesterday_ExpectTrue() {
            //Arrange
            EqualModelOfDates model = new EqualModelOfDates {Val6 = DateTime.Now.AddDays(-1).Date};
            //Act
            bool isValid = model.PropertyIsValid("Val6");
            //Assert
            isValid.ShouldBeTrue();
        }

        [TestMethod]
        public void Equal_ValuesAreDates_Yesterday_Val6IsNull_ExpectTrue() {
            //Arrange
            EqualModelOfDates model = new EqualModelOfDates {Val6 = null};
            //Act
            bool isValid = model.PropertyIsValid("Val6");
            //Assert
            isValid.ShouldBeTrue();
        }

        [TestMethod]
        public void Equal_ValuesAreDates_Yesterday_Val6DoesNotEqualYesterday_ExpectFalse() {
            //Arrange
            EqualModelOfDates model = new EqualModelOfDates {Val6 = DateTime.Now.Date};
            //Act
            bool isValid = model.PropertyIsValid("Val6");
            //Assert
            isValid.ShouldBeFalse();
        }

        #endregion

        #region << Tomorrow >>

        [TestMethod]
        public void Equal_ValuesAreDates_Tomorrow_Val7EqualsTomorrow_ExpectTrue() {
            //Arrange
            EqualModelOfDates model = new EqualModelOfDates {Val7 = DateTime.Now.AddDays(1).Date};
            //Act
            bool isValid = model.PropertyIsValid("Val7");
            //Assert
            isValid.ShouldBeTrue();
        }

        [TestMethod]
        public void Equal_ValuesAreDates_Tomorrow_Val7IsNull_ExpectTrue() {
            //Arrange
            EqualModelOfDates model = new EqualModelOfDates {Val7 = null};
            //Act
            bool isValid = model.PropertyIsValid("Val7");
            //Assert
            isValid.ShouldBeTrue();
        }

        [TestMethod]
        public void Equal_ValuesAreDates_Tomorrow_Val7DoesNotEqualTomorrow_ExpectFalse() {
            //Arrange
            EqualModelOfDates model = new EqualModelOfDates {Val7 = DateTime.Now.Date};
            //Act
            bool isValid = model.PropertyIsValid("Val7");
            //Assert
            isValid.ShouldBeFalse();
        }

        #endregion

        #endregion
    }
}