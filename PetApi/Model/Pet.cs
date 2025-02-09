﻿namespace PetApi.Model
{
    public class Pet
    {
        public Pet(string name, string type, string color, int price)
        {
            Name = name;
            Type = type;
            Color = color;
            Price = price;
        }

        public string Name { get; set; }
        public string Type { get; set; }
        public string Color { get; set; }
        public int Price { get; set; }

        public override bool Equals(object? obj)
        {
            var pet = obj as Pet;
            return pet != null && 
                   pet.Name == Name && 
                   pet.Type == Type &&
                   pet.Color == Color &&
                   pet.Price == Price;
        }
    }
}
