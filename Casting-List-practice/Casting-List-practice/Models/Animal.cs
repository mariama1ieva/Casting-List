using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting_List_practice.Models
{
    internal class Animal
    {
        //public Animal()
        //{
        //    Console.WriteLine("Animal constructor");
        //}
        public int Id { get; set; }
        public string Name { get; set; }
        
        public virtual void Sound()
        {
            Console.WriteLine("Animal sound");
        }
    }
}
