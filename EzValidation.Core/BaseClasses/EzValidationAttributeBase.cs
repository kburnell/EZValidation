using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using EzValidation.Core.Util;

namespace EzValidation.Core.BaseClasses {

    [AttributeUsage(AttributeTargets.Property)]
    public abstract class EzValidationAttributeBase : ValidationAttribute {

        #region << Constrtuctors >>

        static EzValidationAttributeBase() {
            EzValidationHookUp.HookUpAll();
        }

        #endregion

        #region << Public Properties >>

        public virtual string DefaultErrorMessage {
            get { return "{0} - Invalid"; }
        }

        public abstract bool IsValid(object value, object container);

        public virtual string Type {
            get { return GetType().Name.Replace("Attribute", ""); }
        }

        public Dictionary<string, object> ValidationParameters {
            get { return GetValidationParameters().ToDictionary(parms => parms.Key.ToLower(), parms => parms.Value); }
        }

        #endregion

        #region << Public Methods >>

        public override string FormatErrorMessage(string name) {
            if (string.IsNullOrEmpty(ErrorMessageResourceName) && string.IsNullOrEmpty(ErrorMessage))
                ErrorMessage = DefaultErrorMessage;

            return base.FormatErrorMessage(name);
        }

        protected virtual IEnumerable<KeyValuePair<string, object>> GetValidationParameters() {
            return new KeyValuePair<string, object>[0];
        }

        #endregion
    }
}