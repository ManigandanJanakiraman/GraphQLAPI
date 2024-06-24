using GraphQLProject.API.Mutation;
using GraphQLProject.API.Query;

namespace GraphQLProject.API.Schema
{
    public class MenuSchema : GraphQL.Types.Schema
    {
        public MenuSchema(MenuQuery menuQuery, MenuMutation menuMutation) { 
            Query = menuQuery;
            Mutation = menuMutation;
        }
    }
}
