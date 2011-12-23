using EzValidation.Core.BaseClasses;

namespace EzValidation.Core.Tests.Unit.Shared.Fakes {
    public abstract class FakeModelBase<T> where T : EzValidationDependentAttributeBase {

        public T Get(string property) {
            return (T) this.GetType().GetProperty(property).GetCustomAttributes(typeof (T), false)[0];
        }

        public bool PropertyIsValid(string property) {
            T attribute = this.Get(property);
            return attribute.IsValid(this.GetType().GetProperty(property).GetValue(this, null), this);
        }
    }
}