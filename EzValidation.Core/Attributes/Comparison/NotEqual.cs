using EzValidation.Core.BaseClasses;
using EzValidation.Core.Enumerations;

namespace EzValidation.Core.Attributes.Comparison {

    public class NotEqual : EzValidationComparisonAttributeBase {

        /// <summary>
        /// Checks for Not Equal between property being attributed and the supplied dependent property.
        /// </summary>
        /// <remarks>
        /// To validate against a specific value use the format <code>[NotEqual("|YourSpecificValue|")]</code>
        /// For Dates   : To validate against the current date use the format <code>[NotEqual("CompareToCurrentDate")]</code>
        ///             : To validate against Tomorrow use the format <code>[NotEqual("CompareToTomorrow")]</code>
        ///             : To validate against Yesterday use the format <code>[NotEqual("CompareToYesterday")]</code>
        /// </remarks>
        /// <param name="dependentProperty">Dependent Property To Validate Against.</param>
        public NotEqual(string dependentProperty) : base(EzValidationOperatorType.NotEqual, dependentProperty) {}
    }
}