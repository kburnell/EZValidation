using EzValidation.Core.BaseClasses;
using EzValidation.Core.Enumerations;

namespace EzValidation.Core.Attributes.Comparison {

    public class Less : EzValidationComparisonAttributeBase {

        /// <summary>
        /// Checks for Less between property being attributed and the supplied dependent property.
        /// </summary>
        /// <remarks>
        /// To validate against a specific value use the format <code>[Less("|YourSpecificValue|")]</code>
        /// For Dates   : To validate against the current date use the format <code>[Less("CompareToCurrentDate")]</code>
        ///             : To validate against Tomorrow use the format <code>[Less("CompareToTomorrow")]</code>
        ///             : To validate against Yesterday use the format <code>[Less("CompareToYesterday")]</code>
        /// </remarks>
        /// <param name="dependentProperty">Dependent Property To Validate Against.</param>
        public Less(string dependentProperty) : base(EzValidationOperatorType.Less, dependentProperty) {}
    }
}