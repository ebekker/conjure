using Conjure.Binding;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Conjure.Tests.Binder
{
    public class ValueBinderTests
    {
        [Fact]
        public void RootStringConstant()
        {
            var x = CreateExpression(() => "foo");
            var binder = ValueBinder.Create(x);

            binder.CanSetValue.Should().BeFalse();
            binder.ValueLabel.Should().BeNull();
            binder.TargetType.Should().Be(typeof(string));
            binder.TargetRoot.ToString().Should().Be(x.ToString());

            var targetPathLabels = string.Join(".", binder.TargetPath.Select(x => x.Label));
            targetPathLabels.Should().Be(nameof(System.String));
        }

        [Fact]
        public void RootBoolConstant()
        {
            var x = CreateExpression(() => true);
            var binder = ValueBinder.Create(x);

            // Binder will process as conversion to box up the value
            var y = CreateExpression(() => (object)true);

            binder.CanSetValue.Should().BeFalse();
            binder.ValueLabel.Should().BeNull();
            binder.TargetType.Should().Be(typeof(bool));
            binder.TargetRoot.ToString().Should().Be(y.ToString());

            var targetPathLabels = string.Join(".", binder.TargetPath.Select(x => x.Label));
            targetPathLabels.Should().Be(nameof(System.Boolean));
        }

        [Fact]
        public void RootIntConstant()
        {
            var x = CreateExpression(() => 42);
            var binder = ValueBinder.Create(x);

            // Binder will process as conversion to box up the value
            var y = CreateExpression(() => (object)42);

            binder.CanSetValue.Should().BeFalse();
            binder.ValueLabel.Should().BeNull();
            binder.TargetType.Should().Be(typeof(int));
            binder.TargetRoot.ToString().Should().Be(y.ToString());

            var targetPathLabels = string.Join(".", binder.TargetPath.Select(x => x.Label));
            targetPathLabels.Should().Be(nameof(System.Int32));
        }

        [Theory]
        [InlineData("foo")]
        [InlineData(true)]
        [InlineData(42)]
        public void RootField<T>(T value)
        {
            var localValue = value;
            var exp = CreateExpression(() => localValue);
            var binder = ValueBinder.Create(exp);

            binder.CanSetValue.Should().BeTrue();
            binder.ValueLabel.Should().Be(nameof(localValue));
            binder.TargetType.Should().Be(((MemberExpression)exp.Body).Expression.Type);

            //binder.TargetRoot.ToString().Should().Be(x.ToString());
            //var targetPathLabels = string.Join(".", binder.TargetPath.Select(x => x.Label));
            //targetPathLabels.Should().Be(pathLabels);
        }

        [Theory]
        [InlineData("foo")]
        [InlineData(true)]
        [InlineData(42)]
        public void ReadOnlyProperty<T>(T value)
        {
            var vh = new ReadOnlyValueHolder<T>(value);
            var exp = CreateExpression(() => vh.Value);
            var binder = ValueBinder.Create(exp);

            binder.CanSetValue.Should().BeFalse();
            binder.ValueLabel.Should().Be(nameof(vh.Value));
            binder.TargetType.Should().Be(vh.GetType());
        }

        [Theory]
        [InlineData("foo")]
        [InlineData(true)]
        [InlineData(42)]
        public void ReadWriteProperty<T>(T value)
        {
            var vh = new ReadWriteValueHolder<T>(value);
            var exp = CreateExpression(() => vh.Value);
            var binder = ValueBinder.Create(exp);

            binder.CanSetValue.Should().BeTrue();
            binder.ValueLabel.Should().Be(nameof(vh.Value));
            binder.TargetType.Should().Be(vh.GetType());
        }

        [Fact]
        public void ReadWritePropertyWithUnary()
        {
            var vh = new ReadWriteValueHolder<int>(42);
            var exp = CreateExpression(() => -vh.Value);
            var binder = ValueBinder.Create(exp);

            binder.CanSetValue.Should().BeTrue();
            binder.ValueLabel.Should().Be(nameof(vh.Value));
            binder.TargetType.Should().Be(vh.GetType());
        }

        [Theory]
        [InlineData("foo")]
        [InlineData(true)]
        [InlineData(42)]
        public void FunctionCall<T>(T value)
        {
            var vh = new ReadWriteValueHolder<T>(value);
            var exp = CreateExpression(() => vh.GetValue());
            var binder = ValueBinder.Create(exp);

            binder.CanSetValue.Should().BeFalse();
            binder.ValueLabel.Should().Be(nameof(vh.GetValue));
            binder.TargetType.Should().Be(typeof(T));
        }

        static Expression<Func<TValue>>  CreateExpression<TValue>(Expression<Func<TValue>> exp) => exp;


        class ReadOnlyValueHolder<T>
        {
            private T _Value;

            public ReadOnlyValueHolder(T value) => _Value = value;

            public T Value => _Value;
        }

        class ReadWriteValueHolder<T>
        {
            private T _Value;

            public ReadWriteValueHolder(T value) => _Value = value;

            public T Value
            {
                get => _Value;
                set => _Value = value;
            }

            public T GetValue() => _Value;
        }
    }
}
