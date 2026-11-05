using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
  
        }
    }
    class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type {  get; set; }
        public double Rating { get; set; }

      
        public Restaurant(int id, string name, string type, double rating)
        {
            this.Id = id;
            this.Name = name;
            this.Type = type;
            this.Rating = rating;
        }
    }
}
