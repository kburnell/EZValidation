using System;
using System.Collections.Generic;
using System.Linq;
using EzValidation.Core.Util;

namespace EzValidation.Core.BaseClasses {

    public abstract class EzValidationDependentAttributeBase : EzValidationAttributeBase {

        #region << Public Properties

        private readonly string _dependentProperty;

        #endregion

        #region << Constructors >>

        static EzValidationDependentAttributeBase() {
            EzValidationHookUp.HookUpAll();
        }

        protected EzValidationDependentAttributeBase(string dependentProperty) {
            _dependentProperty = dependentProperty;
        }

        #endregion

        #region << Public Properties >>

        public override string DefaultErrorMessage {
            get { return "{0} - Invalid Based On {1}."; }
        }

        public override bool IsValid(object value, object container) {
            object dependentValue = GetDependentValue(container);
            if (value != null && dependentValue != null) {
                try {
                    DateTime date = new DateTime();
                    if (DateTime.TryParse(value.ToString(), out date)) {
                        value = Convert.ChangeType(value, date.GetType());
                    }
                    if (DateTime.TryParse(dependentValue.ToString(), out date)) {
                        dependentValue = Convert.ChangeType(dependentValue, date.GetType());
                    }
                    else
                        dependentValue = Convert.ChangeType(dependentValue, value.GetType());
                }
                catch (Exception) {
                    throw new InvalidOperationException("EzValidation: Specific value must be same type, or a type that is able to be cast to the type of property being validated!");
                }
            }
            return IsValid(value, dependentValue, container);
        }

        #endregion

        #region << Public Methods

        public override string FormatErrorMessage(string name) {
            if (string.IsNullOrEmpty(ErrorMessageResourceName) && string.IsNullOrEmpty(ErrorMessage))
                ErrorMessage = DefaultErrorMessage;
            return string.Format(ErrorMessageString, name, _dependentProperty);
        }

        protected override IEnumerable<KeyValuePair<string, object>> GetValidationParameters() {
            return base.GetValidationParameters().Union(new[] {new KeyValuePair<string, object>("DependentProperty", _dependentProperty)});
        }

        public abstract bool IsValid(object value, object dependentValue, object container);

        #endregion

        #region << Private Methods >>

        private object GetDependentValue(object container) {
            if (_dependentProperty.IndexOf('|') != -1)
                return _dependentProperty.Split(new[] {'|'}, StringSplitOptions.RemoveEmptyEntries)[0];
            if (_dependentProperty.Equals(Constants.Constants.CompareToCurrentDate)) return DateTime.Now.Date.ToShortDateString();
            if (_dependentProperty.Equals(Constants.Constants.CompareToYesterday)) return DateTime.Now.AddDays(-1).Date.ToShortDateString();
            if (_dependentProperty.Equals(Constants.Constants.CompareToTomorrow)) return DateTime.Now.AddDays(1).Date.ToShortDateString();
            if (_dependentProperty.Equals(Constants.Constants.CompareToCurrentDateAndTime)) return DateTime.Now.ToString();
            return container.GetType()
                .GetProperty(_dependentProperty)
                .GetValue(container, null);
        }

        #endregion

        #region << Private Methods >>

        

        #endregion
    }
}