using System.Web.Mvc;
using EzValidation.Core.Attributes.Comparison;

namespace EzValidation.Core.Util {

    public class EzValidationHookUp {

        internal static void HookUpAll() {
            DataAnnotationsModelValidatorProvider.RegisterAdapter(typeof (Equal), typeof (EzValidationValidator));
            DataAnnotationsModelValidatorProvider.RegisterAdapter(typeof (NotEqual), typeof (EzValidationValidator));
            DataAnnotationsModelValidatorProvider.RegisterAdapter(typeof (Greater), typeof (EzValidationValidator));
            DataAnnotationsModelValidatorProvider.RegisterAdapter(typeof (Less), typeof (EzValidationValidator));
            DataAnnotationsModelValidatorProvider.RegisterAdapter(typeof (GreaterOrEqual), typeof (EzValidationValidator));
            DataAnnotationsModelValidatorProvider.RegisterAdapter(typeof (LessOrEqual), typeof (EzValidationValidator));
        }

    }
}