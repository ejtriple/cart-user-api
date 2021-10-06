using System;
using System.Threading.Tasks;
using Cart.User.Domain.Models;
using HotChocolate;
using HotChocolate.Types;

namespace Cart.User.GraphQL.Types.Queries
{
    [ExtendObjectType(OperationTypeNames.Query)]
    public class UserQueries
    {
        [GraphQLDescription("cart-user-api: Retrieves a user by a provided User Id.")]
        public async Task<UserModel> GetUser(Guid userId)
        {
            //TODO: Implement Service call for GetUser
            return await Task.FromResult(new UserModel
            {
                Uuid = Guid.NewGuid(),
                Name = "Elliot Triplett",
                CompanyName = "Surprise Tripletts",
                Website = "https://triplett.invalid",
                Revenue = "$1,000,000 - $5,000,000",
                SalesChannel = "Online",
                CreatedBy = "Test"
            });
        }
    }
}