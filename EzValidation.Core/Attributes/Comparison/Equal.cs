using EzValidation.Core.BaseClasses;
using EzValidation.Core.Enumerations;

namespace EzValidation.Core.Attributes.Comparison {

    /// <summary>
    /// Test
    /// </summary>
    public class Equal : EzValidationComparisonAttributeBase {

        /// <summary>
        /// Checks for equality between property being attributed and the supplied dependent property.
        /// </summary>
        /// <remarks>
        /// To validate against a specific value use the format <code>[Equal("|YourSpecificValue|")]</code>
        /// For Dates   : To validate against the current date use the format <code>[Equal("CompareToCurrentDate")]</code>
        ///             : To validate against Tomorrow use the format <code>[Equal("CompareToTomorrow")]</code>
        ///             : To validate against Yesterday use the format <code>[Equal("CompareToYesterday")]</code>
        /// </remarks>
        /// <param name="dependentProperty">Dependent Property To Validate Against.</param>
        public Equal(string dependentProperty) : base(EzValidationOperatorType.Equal, dependentProperty) {}
    }
}