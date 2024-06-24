using GraphQL.Types;
using GraphQLProject.API.Models;

namespace GraphQLProject.API.Type
{
    public class MenuType:ObjectGraphType<Menu>
    {
        public MenuType()
        {
            Field(m => m.Id);
            Field(m => m.Name);
            Field(m => m.Price);
            Field(m => m.Description);
        }
    }
}
