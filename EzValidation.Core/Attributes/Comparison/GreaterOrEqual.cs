using EzValidation.Core.BaseClasses;
using EzValidation.Core.Enumerations;

namespace EzValidation.Core.Attributes.Comparison {

    public class GreaterOrEqual : EzValidationComparisonAttributeBase {

        /// <summary>
        /// Checks for Greater or Equal between property being attributed and the supplied dependent property.
        /// </summary>
        /// <remarks>
        /// To validate against a specific value use the format <code>[GreaterOrEqual("|YourSpecificValue|")]</code>
        /// For Dates   : To validate against the current date use the format <code>[GreaterOrEqual("CompareToCurrentDate")]</code>
        ///             : To validate against Tomorrow use the format <code>[GreaterOrEqual("CompareToTomorrow")]</code>
        ///             : To validate against Yesterday use the format <code>[GreaterOrEqual("CompareToYesterday")]</code>
        /// </remarks>
        /// <param name="dependentProperty">Dependent Property To Validate Against.</param>
        public GreaterOrEqual(string dependentProperty) : base(EzValidationOperatorType.GreaterOrEqual, dependentProperty) {}
    }
}