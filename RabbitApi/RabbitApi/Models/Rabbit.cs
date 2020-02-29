using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace RabbitApi.Models
{
    public class Rabbit
    {
        public enum Gender
        {
            Male ,
            Female 
        }
        public enum FurColors
        {
            Black,
            White,
            Grey,
            Brown
        }
        public enum EyeColors
        {
            Blue ,
            Black ,
            Red 
        }


        [Required]
        
        public FurColors furColor { get; set; }
        public EyeColors eyeColor { get; set; }
        public Gender gender { get; set; }
        public DateTime dateOfBirth { get; set; }

     

        public void Move()
        {
            Console.WriteLine("The rabbit is moving left and right like crazy.");
        }
        public void Sleep()
        {
            Console.WriteLine("The rabbit is sleeping like a rock.");
        }
        public void Eat()
        {
            Console.WriteLine("The rabbit is eating some food");
        }
        public int Age
        {
            get { return (DateTime.Now - dateOfBirth).Days / 365; }
        }

        public override string ToString()
        {
            return $" furcoor:{furColor}, eyecolor:{eyeColor},gender:{gender}, age:{Age}";
        }
    }
}
