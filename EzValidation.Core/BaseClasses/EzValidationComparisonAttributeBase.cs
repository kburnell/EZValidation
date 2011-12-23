using System.Collections.Generic;
using System.Linq;
using EzValidation.Core.Enumerations;
using EzValidation.Core.Util;

namespace EzValidation.Core.BaseClasses {

    public abstract class EzValidationComparisonAttributeBase : EzValidationDependentAttributeBase {

        #region << Private Fields >>

        private readonly EzValidationOperatorMetadata _metadata;

        #endregion

        #region << Public/Protected Properties >>

        public EzValidationOperatorType Operator { get; private set; }

        public override string Type { get { return "Comparison"; } }
        public override string DefaultErrorMessage { get { return "{0} Must Be" + _metadata.ErrorMessage + " {1}."; } }

        #endregion

        #region << Constructors >>

        protected EzValidationComparisonAttributeBase(EzValidationOperatorType @operator, string dependentProperty) : base(dependentProperty) {
            Operator = @operator;
            _metadata = EzValidationOperatorMetadata.Get(Operator);
        }

        #endregion

        #region << Public/Protected Methods >>

        protected override IEnumerable<KeyValuePair<string, object>> GetValidationParameters() {
            return base.GetValidationParameters().Union(new[] {new KeyValuePair<string, object>("Operator", Operator.ToString())});
        }

        public override bool IsValid(object value, object dependentValue, object container) {
            return _metadata.IsValid(value, dependentValue);
        }

        #endregion
    }
}