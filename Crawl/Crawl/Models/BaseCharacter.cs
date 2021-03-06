﻿using Crawl.GameEngine;

namespace Crawl.Models
{
    public class BaseCharacter : BasePlayer<BaseCharacter>
    {
        // Just base from here down. 
        // This is what will be saved to the Database

        // So when working with the database, pass Character

        public BaseCharacter()
        {

        }

        // Makes BaseCharacter using character for constructor
        public BaseCharacter(Character newData)
        {
            // Base information
            Name = newData.Name;
            Description = newData.Description;
            Level = newData.Level;
            ExperienceTotal = newData.ExperienceTotal;
            ImageURI = newData.ImageURI;
            Item = newData.Item;
            Alive = newData.Alive;
            HealthPoints = newData.HealthPoints;
            MaxHealth = newData.MaxHealth;
            Attack = newData.Attack;
            Defense = newData.Defense;
            Speed = newData.Speed;

            // Database information
            Guid = newData.Guid;
            Id = newData.Id;

            // Populate the Attributes
            AttributeString = newData.AttributeString;

            // Set the strings for the items
            Head = newData.Head;
            Feet = newData.Feet;
            Necklass = newData.Necklass;
            RightFinger = newData.RightFinger;
            LeftFinger = newData.LeftFinger;
            Feet = newData.Feet;
        }

        // Update character from the passed in data
        public void Update(BaseCharacter newData)
        {
                return;
        
        }

    }
}