using EzValidation.Core.BaseClasses;
using EzValidation.Core.Enumerations;

namespace EzValidation.Core.Attributes.Comparison {

    public class Greater : EzValidationComparisonAttributeBase {

        /// <summary>
        /// Checks for Greater between property being attributed and the supplied dependent property.
        /// </summary>
        /// <remarks>
        /// To validate against a specific value use the format <code>[Greater("|YourSpecificValue|")]</code>
        /// For Dates   : To validate against the current date use the format <code>[Greater("CompareToCurrentDate")]</code>
        ///             : To validate against Tomorrow use the format <code>[Greater("CompareToTomorrow")]</code>
        ///             : To validate against Yesterday use the format <code>[Greater("CompareToYesterday")]</code>
        /// </remarks>
        /// <param name="dependentProperty">Dependent Property To Validate Against.</param>
        public Greater(string dependentProperty) : base(EzValidationOperatorType.Greater, dependentProperty) {}
    }
}