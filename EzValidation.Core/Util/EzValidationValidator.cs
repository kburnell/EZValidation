using System.Collections.Generic;
using System.Web.Mvc;
using EzValidation.Core.BaseClasses;

namespace EzValidation.Core.Util {

    public class EzValidationValidator : DataAnnotationsModelValidator<EzValidationAttributeBase> {

        #region << Constructors >>

        public EzValidationValidator(ModelMetadata metadata, ControllerContext context, EzValidationAttributeBase attribute) : base(metadata, context, attribute) {}

        #endregion

        #region << Public Methods >>

        public override IEnumerable<ModelValidationResult> Validate(object container) {
            if (!Attribute.IsValid(Metadata.Model, container))
                yield return new ModelValidationResult {Message = ErrorMessage};
        }

        public override IEnumerable<ModelClientValidationRule> GetClientValidationRules() {
            ModelClientValidationRule result = new ModelClientValidationRule {ValidationType = Attribute.Type.ToLower(), ErrorMessage = ErrorMessage};
            foreach (KeyValuePair<string, object> validationParam in Attribute.ValidationParameters)
                result.ValidationParameters.Add(validationParam);
            yield return result;
        }

        #endregion

    }
}