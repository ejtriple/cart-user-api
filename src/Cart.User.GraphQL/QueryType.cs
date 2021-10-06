// using System;
// using Cart.User.GraphQL.Types.ObjectTypes;
// using HotChocolate.Types;
// using Microsoft.Extensions.DependencyInjection;
//
// namespace Cart.User.GraphQL
// {
//     public class QueryType: ObjectType<Query>
//     {
//         protected override void Configure(IObjectTypeDescriptor<Query> descriptor)
//         {
//             base.Configure(descriptor);
//
//             descriptor.Field(_ => _.GetUser(default))
//                 .Name("User")
//                 .Description("cart-user-api: Retrieves a user by ID.")
//                 .Type<UserType>();
//         }
//     }
// }