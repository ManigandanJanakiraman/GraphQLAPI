using GraphQLProject.API.Interfaces;
using GraphQLProject.API.Models;

namespace GraphQLProject.API.Services
{
    public class MenuRepository : IMenuRepository
    {

        private static List<Menu> MenuList = new List<Menu>()
        {
            new Menu() {Id=1, Name="Classic Burger", Description="A juicy chicken burger with lettuce and cheese", Price=8.99},
            new Menu() {Id=2, Name="Margherita Pizza", Description="Tomato, mozzarella, and basil pizza", Price=10.50},
            new Menu() {Id=3, Name="Spaghetti Carbonara", Description="Pasta with creamy sauce, bacon, and parmesan", Price=12.75},
            new Menu() {Id=4, Name="Caesar Salad", Description="Romaine lettuce, croutons, parmesan cheese, and Caesar dressing", Price=7.50},
            new Menu() {Id=5, Name="Chicken Tikka Masala", Description="Grilled chicken in a creamy tomato sauce with spices", Price=14.25}
        };


        public Menu AddMenu(Menu menu)
        {
            throw new NotImplementedException();
        }

        public void DeleteMenu(int id)
        {
            throw new NotImplementedException();
        }

        public List<Menu> GetAllMenu()
        {
            return MenuList;
        }

        public Menu GetMenuById(int id)
        {
            return MenuList[id];
        }

        public Menu UpdateMenu(int id, Menu menu)
        {
            throw new NotImplementedException();
        }
    }
}
