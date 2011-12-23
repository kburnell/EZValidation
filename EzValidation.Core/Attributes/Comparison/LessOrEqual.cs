using EzValidation.Core.BaseClasses;
using EzValidation.Core.Enumerations;

namespace EzValidation.Core.Attributes.Comparison {

    public class LessOrEqual : EzValidationComparisonAttributeBase {

        /// <summary>
        /// Checks for Less or Equal between property being attributed and the supplied dependent property.
        /// </summary>
        /// <remarks>
        /// To validate against a specific value use the format <code>[LessOrEqual("|YourSpecificValue|")]</code>
        /// For Dates   : To validate against the current date use the format <code>[LessOrEqual("CompareToCurrentDate")]</code>
        ///             : To validate against Tomorrow use the format <code>[LessOrEqual("CompareToTomorrow")]</code>
        ///             : To validate against Yesterday use the format <code>[LessOrEqual("CompareToYesterday")]</code>
        /// </remarks>
        /// <param name="dependentProperty">Dependent Property To Validate Against.</param>
        public LessOrEqual(string dependentProperty) : base(EzValidationOperatorType.LessOrEqual, dependentProperty) { }
    }
}