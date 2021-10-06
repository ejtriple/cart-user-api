using Cart.User.Domain.Models;
using HotChocolate.Types;

namespace Cart.User.GraphQL.Types.ObjectTypes
{
    public class UserType: BaseObjectType<UserModel>
    {
        protected override void Configure(IObjectTypeDescriptor<UserModel> descriptor)
        {
            // Base behaviour is set to explicitly define fields. This allows us to not need to expose
            // all properties of our models. Could revisit as Hot Chocolate will infer graphql type based on C# type.
            base.Configure(descriptor);
            descriptor.Name("User");
            descriptor.Field(_ => _.Uuid).Name("id").Type<NonNullType<IdType>>();
            descriptor.Field(_ => _.Name).Type<StringType>();
            descriptor.Field(_ => _.CompanyName).Type<StringType>();
            descriptor.Field(_ => _.Website).Type<StringType>();
            descriptor.Field(_ => _.Revenue).Type<StringType>();
            descriptor.Field(_ => _.SalesChannel).Type<StringType>();
        }
    }
}