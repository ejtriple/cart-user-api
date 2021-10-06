// using System;
// using System.Threading.Tasks;
// using Cart.User.Domain.Models;
// using HotChocolate.Types;
// using Microsoft.Extensions.DependencyInjection;
//
// namespace Cart.User.GraphQL
// {
//     public class Query
//     {
//         public async Task<UserModel> GetUser(Guid userId)
//         {
//             //TODO: Implement Service call for GetUser
//             return await Task.FromResult(new UserModel
//             {
//                 Uuid = Guid.NewGuid(),
//                 Name = "Elliot Triplett",
//                 CompanyName = "Surprise Tripletts",
//                 Website = "https://triplett.invalid",
//                 Revenue = "$1,000,000 - $5,000,000",
//                 SalesChannel = "Online"
//             });
//         }
//     }
// }