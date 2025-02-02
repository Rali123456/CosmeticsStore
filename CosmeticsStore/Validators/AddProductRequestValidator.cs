using FluentValidation;
using CosmeticsStore.Models.Requests;

namespace CosmeticsStore.Validators
{
    public class AddProductRequestValidator : AbstractValidator<AddProductRequest>
    {
        public AddProductRequestValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Product name cannot be empty.")
                .NotNull().WithMessage("Product name cannot be null.")
                .MaximumLength(100).WithMessage("Product name cannot be longer than 100 characters.")
                .MinimumLength(3).WithMessage("Product name must be at least 3 characters long.");

            RuleFor(x => x.Description)
                .NotEmpty().WithMessage("Product description cannot be empty.")
                .NotNull().WithMessage("Product description cannot be null.")
                .MaximumLength(500).WithMessage("Product description cannot be longer than 500 characters.");

            RuleFor(x => x.Price)
                .GreaterThan(0).WithMessage("Price must be greater than 0.")
                .LessThanOrEqualTo(10000).WithMessage("Price cannot exceed 10000.");

            RuleFor(x => x.Category)
                .NotEmpty().WithMessage("Product category cannot be empty.")
                .NotNull().WithMessage("Product category cannot be null.")
                .MaximumLength(50).WithMessage("Category name cannot be longer than 50 characters.");
        }
    }
}

