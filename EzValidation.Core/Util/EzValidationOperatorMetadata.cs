using System;
using System.Collections.Generic;
using EzValidation.Core.Enumerations;

namespace EzValidation.Core.Util
{
    public class EzValidationOperatorMetadata {

        #region << Private Fields >>

        private static Dictionary<EzValidationOperatorType, EzValidationOperatorMetadata> _operatorMetadata;

        #endregion

        #region << Public Properties >>

        public string ErrorMessage { get; set; }
        public Func<object, object, bool> IsValid { get; set; }

        public static EzValidationOperatorMetadata Get(EzValidationOperatorType @operator) {
            return _operatorMetadata[@operator];
        }

        #endregion

        #region  << Constructors >>

        static EzValidationOperatorMetadata() {
            CreateEzValidationOperatorMetadata();
        }

        #endregion

        #region << Private Methods >>

        private static void CreateEzValidationOperatorMetadata() {
            _operatorMetadata = new Dictionary<EzValidationOperatorType, EzValidationOperatorMetadata> {
                {EzValidationOperatorType.Equal, GetEqualToMetadata() },
                {EzValidationOperatorType.NotEqual, GetNotEqualToMetadata() },
                {EzValidationOperatorType.Greater, GetGreaterThanMetadata() },
                {EzValidationOperatorType.Less,GetLessThanMetadata()},
                {EzValidationOperatorType.GreaterOrEqual, GetGreaterThanOrEqualToMetadata()},
                {EzValidationOperatorType.LessOrEqual, GetLessThanOrEqualToMetadata()},
            };
        }

        private static EzValidationOperatorMetadata GetEqualToMetadata() {
            return new EzValidationOperatorMetadata {
                ErrorMessage = "Equal To",
                IsValid = (value, dependentValue) => {
                                if (value == null) return true;
                                if (dependentValue == null) return false;
                                return value.Equals(dependentValue);
                            }
            };
        }

        private static EzValidationOperatorMetadata GetNotEqualToMetadata() {
            return new EzValidationOperatorMetadata {
                ErrorMessage = "Not Equal To",
                IsValid = (value, dependentValue) => {
                                if (value == null) return true;
                                if (dependentValue == null) return true;
                                return !value.Equals(dependentValue);
                            }
            };
        }

        private static EzValidationOperatorMetadata GetGreaterThanMetadata() {
            return new EzValidationOperatorMetadata {
                ErrorMessage = "Greater Than",
                IsValid = (value, dependentValue) => {
                                if (value == null) return true;
                                if (dependentValue == null) return true;
                                return Comparer<object>.Default.Compare(value, dependentValue) >= 1;
                            }
            };
        }

        private static EzValidationOperatorMetadata GetLessThanMetadata() {
            return new EzValidationOperatorMetadata {
                ErrorMessage = "Less Than",
                IsValid = (value, dependentValue) => {
                                if (value == null) return true;
                                if (dependentValue == null) return false;
                                return Comparer<object>.Default.Compare(value, dependentValue) <= -1;
                            }
            };
        }

        private static EzValidationOperatorMetadata GetGreaterThanOrEqualToMetadata() {
            return new EzValidationOperatorMetadata {
                ErrorMessage = "Greater Than or Equal To",
                IsValid = (value, dependentValue) => {
                            if (value == null) return true;
                            if (dependentValue == null) return true;
                            return Get(EzValidationOperatorType.Equal).IsValid(value, dependentValue) || Comparer<object>.Default.Compare(value, dependentValue) >= 1;
                        }
            };
        }

        private static EzValidationOperatorMetadata GetLessThanOrEqualToMetadata() {
            return new EzValidationOperatorMetadata {
                ErrorMessage = "Less Than or Equal To",
                IsValid = (value, dependentValue) => {
                                if (value == null) return true;
                                if (dependentValue == null) return false;
                                return Get(EzValidationOperatorType.Equal).IsValid(value, dependentValue) || Comparer<object>.Default.Compare(value, dependentValue) <= -1;
                            }
            };
        }

        #endregion

    }
}
