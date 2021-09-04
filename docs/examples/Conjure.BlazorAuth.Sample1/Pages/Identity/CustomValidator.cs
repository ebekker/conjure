using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System.Linq.Expressions;

namespace Conjure.BlazorAuth.Sample1.Pages.Identity
{
    public class CustomValidator : ComponentBase, IDisposable
    {
        [CascadingParameter]
        private EditContext? EditContext { get; set; }

        private ValidationMessageStore? _messageStore;
        private FieldIdentifier _modelFieldId;

        protected override void OnInitialized()
        {
            if (EditContext == null)
            {
                throw new ArgumentNullException(nameof(EditContext));
            }

            _messageStore = new(EditContext);
            EditContext.OnValidationRequested += EditContext_OnValidationRequested;
            EditContext.OnFieldChanged += EditContext_OnFieldChanged;

            // Based on:
            //    https://github.com/dotnet/aspnetcore/blob/8b30d862de6c9146f466061d51aa3f1414ee2337/src/Components/Web/src/Forms/ValidationSummary.cs#L68
            // This is the special Field ID formulation to represent
            // model-scoped errors instead of field-scoped errors
            _modelFieldId = new FieldIdentifier(EditContext.Model, string.Empty);
        }

        public object? Model => EditContext?.Model;

        public void Add(FieldIdentifier fi, string error)
        {
            _messageStore?.Add(fi, error);
            EditContext?.NotifyValidationStateChanged();
        }

        public void Add(FieldIdentifier fi, IEnumerable<string> errors)
        {
            foreach (var error in errors)
            {
                _messageStore?.Add(fi, error);
            }
            EditContext?.NotifyValidationStateChanged();
        }

        public void Add(string error)
        {
            _messageStore?.Add(_modelFieldId, error);
            EditContext?.NotifyValidationStateChanged();
        }

        public void Add(IEnumerable<string> errors)
        {
            foreach (var error in errors)
            {
                _messageStore?.Add(_modelFieldId, error);
            }
            EditContext?.NotifyValidationStateChanged();
        }

        public void ClearErrors()
        {
            _messageStore?.Clear();
            EditContext?.NotifyValidationStateChanged();
        }

        private void EditContext_OnFieldChanged(object? sender, FieldChangedEventArgs e)
        {
            _messageStore?.Clear(e.FieldIdentifier);
        }

        private void EditContext_OnValidationRequested(object? sender, ValidationRequestedEventArgs e)
        {
            _messageStore?.Clear();
        }

        public void Dispose()
        {
            if (EditContext != null)
            {
                EditContext.OnFieldChanged += EditContext_OnFieldChanged;
                EditContext.OnValidationRequested += EditContext_OnValidationRequested;
            }
        }
    }
}
