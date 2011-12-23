using System;
using EzValidation.Core.Tests.Unit.Shared.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;

namespace EzValidation.Core.Tests.Unit.ServerSide.Attributes.Comparison {

    [TestClass]
    public class NotEqualTest {

        #region << Strings >>

        [TestMethod]
        public void NotEqual_ValuesAreStrings_Val1AndVal2BothEmpty_ExpectFalse() {
            //Arrange
            const string str = "";
            NotEqualModelOfStrings model = new NotEqualModelOfStrings {Val1 = str, Val2 = str};
            //Act
            bool isValid = model.PropertyIsValid("Val2");
            //Assert
            isValid.ShouldBeFalse();
        }

        [TestMethod]
        public void NotEqual_ValuesAreStrings_Val1IsEmptyAndVal2IsNot_ExpectTrue() {
            //Arrange
            const string str = "";
            const string otherStr = "Other String";
            NotEqualModelOfStrings model = new NotEqualModelOfStrings {Val1 = str, Val2 = otherStr};
            //Act
            bool isValid = model.PropertyIsValid("Val2");
            //Assert
            isValid.ShouldBeTrue();
        }

        [TestMethod]
        public void NotEqual_ValuesAreStrings_Val1NotEqualVal2_ExpectFalse() {
            //Arrange
            const string str = "Hello World";
            NotEqualModelOfStrings model = new NotEqualModelOfStrings {Val1 = str, Val2 = str};
            //Act
            bool isValid = model.PropertyIsValid("Val2");
            //Assert
            isValid.ShouldBeFalse();
        }

        [TestMethod]
        public void NotEqual_ValuesAreStrings_Val1DoesNotEqualVal2_ExpectTrue() {
            //Arrange
            const string str = "Hello World";
            NotEqualModelOfStrings model = new NotEqualModelOfStrings {Val1 = str, Val2 = str + "XXX"};
            //Act
            bool isValid = model.PropertyIsValid("Val2");
            //Assert
            isValid.ShouldBeTrue();
        }

        [TestMethod]
        public void NotEqual_ValuesAreStrings_SpecificValue_Val1NotEqualSpecificValue_ExpectFalse() {
            //Arrange
            const string str = "Hello World";
            NotEqualModelOfStrings model = new NotEqualModelOfStrings {Val1 = str};
            //Act
            bool isValid = model.PropertyIsValid("Val1");
            //Assert
            isValid.ShouldBeFalse();
        }

        [TestMethod]
        public void NotEqual_ValuesAreStrings_SpecificValue_Val1DoesNotNotEqualpecificValue_ExpectTrue() {
            //Arrange
            const string str = "Goodbye World";
            NotEqualModelOfStrings model = new NotEqualModelOfStrings {Val1 = str};
            //Act
            bool isValid = model.PropertyIsValid("Val1");
            //Assert
            isValid.ShouldBeTrue();
        }

        [TestMethod]
        public void NotEqual_ValuesAreStrings_CompareToCurrentDate_Val3NotEqualCurrentDate_ExpectFalse() {
            //Arrange
            string str = DateTime.Now.ToShortDateString();
            NotEqualModelOfStrings model = new NotEqualModelOfStrings {Val3 = str};
            //Act
            bool isValid = model.PropertyIsValid("Val3");
            //Assert
            isValid.ShouldBeFalse();
        }

        [TestMethod]
        public void NotEqual_ValuesAreStrings_CompareToCurrentDate_Val3DoesNotEqualCurrentDate_ExpectTrue() {
            //Arrange
            string str = "Hello World";
            NotEqualModelOfStrings model = new NotEqualModelOfStrings {Val3 = str};
            //Act
            bool isValid = model.PropertyIsValid("Val3");
            //Assert
            isValid.ShouldBeTrue();
        }

        #endregion

        #region << Longs >>

        [TestMethod]
        public void NotEqual_ValuesAreLongs_Val1AndVal2_BothNull_ExpectTrue() {
            //Arrange
            NotEqualModelOfLongs model = new NotEqualModelOfLongs {Val1 = null, Val2 = null};
            //Act
            bool isValid = model.PropertyIsValid("Val2");
            //Assert
            isValid.ShouldBeTrue();
        }

        [TestMethod]
        public void NotEqual_ValuesAreLongs_Val1IsNullAndVal2IsNotNull_ExpectTrue() {
            //Arrange
            NotEqualModelOfLongs model = new NotEqualModelOfLongs {Val1 = null, Val2 = 1};
            //Act
            bool isValid = model.PropertyIsValid("Val2");
            //Assert
            isValid.ShouldBeTrue();
        }

        [TestMethod]
        public void NotEqual_ValuesAreLongs_Val1NotEqualVal2_ExpectFalse() {
            //Arrange
            NotEqualModelOfLongs model = new NotEqualModelOfLongs {Val1 = 1, Val2 = 1};
            //Act
            bool isValid = model.PropertyIsValid("Val2");
            //Assert
            isValid.ShouldBeFalse();
        }

        [TestMethod]
        public void NotEqual_ValuesAreLongs_Val1DoesNotEqualVal2_ExpectTrue() {
            //Arrange
            NotEqualModelOfLongs model = new NotEqualModelOfLongs {Val1 = 1, Val2 = 2};
            //Act
            bool isValid = model.PropertyIsValid("Val2");
            //Assert
            isValid.ShouldBeTrue();
        }

        [TestMethod]
        public void NotEqual_ValuesAreLongs_SpecificValue_Val1NotEqualSpecificValue_ExpectFalse() {
            //Arrange
            NotEqualModelOfLongs model = new NotEqualModelOfLongs {Val1 = 99};
            //Act
            bool isValid = model.PropertyIsValid("Val1");
            //Assert
            isValid.ShouldBeFalse();
        }

        [TestMethod]
        public void NotEqual_ValuesAreLongs_SpecificValue_Val1DoesNotNotEqualpecificValue_ExpectTrue() {
            //Arrange
            NotEqualModelOfLongs model = new NotEqualModelOfLongs {Val1 = 100};
            //Act
            bool isValid = model.PropertyIsValid("Val1");
            //Assert
            isValid.ShouldBeTrue();
        }

        #endregion

        #region << Dates >>

        [TestMethod]
        public void NotEqual_ValuesAreDates_Val1AndVal2_BothNull_ExpectTrue() {
            //Arrange
            NotEqualModelOfDates model = new NotEqualModelOfDates {Val1 = null, Val2 = null};
            //Act
            bool isValid = model.PropertyIsValid("Val2");
            //Assert
            isValid.ShouldBeTrue();
        }

        [TestMethod]
        public void NotEqual_ValuesAreDates_Val1IsNullAndVal2IsNotNull_ExpectTrue() {
            //Arrange
            NotEqualModelOfDates model = new NotEqualModelOfDates {Val1 = null, Val2 = DateTime.Now};
            //Act
            bool isValid = model.PropertyIsValid("Val2");
            //Assert
            isValid.ShouldBeTrue();
        }

        [TestMethod]
        public void NotEqual_ValuesAreDates_Val1NotEqualVal2_ExpectFalse() {
            //Arrange
            DateTime date = DateTime.Now.Date;
            NotEqualModelOfDates model = new NotEqualModelOfDates {Val1 = date, Val2 = date};
            //Act
            bool isValid = model.PropertyIsValid("Val2");
            //Assert
            isValid.ShouldBeFalse();
        }

        [TestMethod]
        public void NotEqual_ValuesAreDates_Val1DoesNotEqualVal2_ExpectTrue() {
            //Arrange
            NotEqualModelOfDates model = new NotEqualModelOfDates {Val1 = DateTime.Now, Val2 = DateTime.Now.AddDays(1)};
            //Act
            bool isValid = model.PropertyIsValid("Val2");
            //Assert
            isValid.ShouldBeTrue();
        }

        [TestMethod]
        public void NotEqual_ValuesAreDates_SpecificValue_Val1NotEqualSpecificValue_ExpectFalse() {
            //Arrange
            NotEqualModelOfDates model = new NotEqualModelOfDates {Val1 = new DateTime(2010, 12, 31)};
            //Act
            bool isValid = model.PropertyIsValid("Val1");
            //Assert
            isValid.ShouldBeFalse();
        }

        [TestMethod]
        public void NotEqual_ValuesAreDates_SpecificValue_Val1DoesNotNotEqualpecificValue_ExpectTrue() {
            //Arrange
            NotEqualModelOfDates model = new NotEqualModelOfDates {Val1 = DateTime.Now};
            //Act
            bool isValid = model.PropertyIsValid("Val1");
            //Assert
            isValid.ShouldBeTrue();
        }

        [TestMethod]
        public void NotEqual_ValuesAreDates_CurrentDate_Val3NotEqualCurrentDate_ExpectFalse() {
            //Arrange
            NotEqualModelOfDates model = new NotEqualModelOfDates {Val3 = DateTime.Now.Date};
            //Act
            bool isValid = model.PropertyIsValid("Val3");
            //Assert
            isValid.ShouldBeFalse();
        }

        [TestMethod]
        public void NotEqual_ValuesAreDates_SpecificValue_Val3DoesNotEquaCurrentDate_ExpectTrue() {
            //Arrange
            NotEqualModelOfDates model = new NotEqualModelOfDates {Val1 = DateTime.Now.AddDays(-1)};
            //Act
            bool isValid = model.PropertyIsValid("Val3");
            //Assert
            isValid.ShouldBeTrue();
        }

        #endregion
    }
}