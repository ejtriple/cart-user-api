using System.Diagnostics.CodeAnalysis;
using Cart.User.Domain.Models;
using HotChocolate.Types;

namespace Cart.User.GraphQL
{
    public class BaseObjectType<T> : ObjectType<T>
        where T : IBaseModel
    {
        protected override void Configure(IObjectTypeDescriptor<T> descriptor)
        {
            base.Configure(descriptor);
            descriptor.BindFieldsExplicitly();
        }
    }
}