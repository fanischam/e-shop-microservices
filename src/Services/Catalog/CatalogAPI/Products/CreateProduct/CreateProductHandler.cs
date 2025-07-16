using MediatR;

namespace CatalogAPI.Products.CreateProduct
{
    public record CreateProductCommand(string Name, List<string> Category, string Description, string ImageFile, decimal Price)
        : IRequest<CreateProductResult>;
    public record CreateProductResult(Guid Id);

    internal class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, CreateProductResult>
    {
        public Task<CreateProductResult> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            // Logic to create a product would go here
            // For now, we will return a dummy result
            var productId = Guid.NewGuid();
            return Task.FromResult(new CreateProductResult(productId));
        }
    }
}
