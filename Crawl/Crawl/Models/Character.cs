﻿using Crawl.ViewModels;
using System.Collections.Generic;
using Crawl.Controllers;

namespace Crawl.Models
{
    // The Character is the higher level concept.  This is the Character with all attirbutes defined.
    public class Character : BaseCharacter
    {
        // Add in the actual attribute class
        public AttributeBase Attribute { get; set; }

        // Create a default Character for the instantiation
        private void CreateDefaultCharacter()
        {
            Name = "Unknown";
            Description = "Unknown";
            ImageURI = ItemsController.DefaultImageURICharacter;
            Item = "Unknown";
            // adding properties
            Level = 0;
            Alive = true;
            HealthPoints = 0;
            MaxHealth = 0;
            Attack = 0;
            Defense = 0;
            Speed = 0;
            ExperienceTotal = 0;
        }

        // Make sure Attribute is instantiated in the constructor
        public Character()
        {
            Attribute = new AttributeBase();
            Alive = true;
            CreateDefaultCharacter();
        }

        // Create a new character, based on a passed in BaseCharacter
        // Used for converting from database format to character
        public Character(BaseCharacter newData)
        {
            // Base information
            Name = newData.Name;
            Description = newData.Description;
            Level = newData.Level;
            ImageURI = newData.ImageURI;
            Alive = newData.Alive;
            HealthPoints = newData.HealthPoints;
            MaxHealth = newData.MaxHealth;
            Attack = newData.Attack;
            Defense = newData.Defense;
            Speed = newData.Speed;
            ExperienceTotal = newData.ExperienceTotal;

            // Database information
            Guid = newData.Guid;
            Id = newData.Id;
        }

        // Create a new character, based on existing Character
        public Character(Character newData)
        {
            // Implement
            CreateDefaultCharacter();
        }


        //1/29 i did this based on constructor for item called if needd
        // needed to create a new item with set values
        public Character(string name, string description, string imageuri, int level, int experiencetotal, int attack, int defense, int speed)
        {
            CreateDefaultCharacter();
            Name = name;
            Description = description;
            ImageURI = imageuri;
            ExperienceTotal = experiencetotal;
            Level = level;
            Attack = attack;
            Defense = defense;
            Speed = speed;

        }

        // Upgrades to a set level
        public void ScaleLevel(int level)
        {
            // Implement
        }

        // Update the character information
        // Updates the attribute string
        public void Update(Character newData)
        {
            // Implement
            // Base information
            Name = newData.Name;
            Description = newData.Description;
            Level = newData.Level;
            ImageURI = newData.ImageURI;
            Alive = newData.Alive;
            HealthPoints = newData.HealthPoints;
            MaxHealth = newData.MaxHealth;
            Attack = newData.Attack;
            Defense = newData.Defense;
            Speed = newData.Speed;
            ExperienceTotal = newData.ExperienceTotal;



            // Database information
            Guid = newData.Guid;
            Id = newData.Id;
        }

        // Helper to combine the attributes into a single line, to make it easier to display the item as a string
        public string FormatOutput()
        {
            var myReturn = " Implement";
            return myReturn;
        }

        #region Basics
        // Level Up
        public bool LevelUp()
        {
            // Implement
            return false;
        }

        // Level up to a number, say Level 3
        public int LevelUpToValue(int Value)
        {
            // Implement
            return Level;
        }

        // Add experience
        public bool AddExperience(int newExperience)
        {
            // Implement
            return false;
        }

        #endregion Basics

        #region GetAttributes
        // Get Attributes

        // Get Attack
        public int GetAttack()
        {
            // Base Attack
            var myReturn = Attribute.Attack;

            // Implement

            // Attack Bonus from Level

            // Get Attack bonus from Items

            return myReturn;
        }

        // Get Speed
        public int GetSpeed()
        {
            // Base value
            var myReturn = Attribute.Speed;

            // Implement

            // Get Bonus from Level

            // Get bonus from Items

            return myReturn;
        }

        // Get Defense
        public int GetDefense()
        {
            // Base value
            var myReturn = Attribute.Defense;

            // Implement

            // Get Bonus from Level

            // Get bonus from Items

            return myReturn;
        }

        // Get Max Health
        public int GetHealthMax()
        {
            // Base value
            var myReturn = Attribute.MaxHealth;

            // Implement

            // Get bonus from Items
            
            return myReturn;
        }

        // Get Current Health
        public int GetHealthCurrent()
        {
            // Base value
            var myReturn = Attribute.CurrentHealth;

            // Implement

            // Get bonus from Items

            return myReturn;
        }

        // Returns the Dice for the item
        // Sword 10, is Sword Dice 10
        public int GetDamageDice()
        {
            var myReturn = 0;

            // Implement

            
            return myReturn;
        }

        // Get the Level based damage
        // Then add the damage for the primary hand item as a Dice Roll
        public int GetDamageRollValue()
        {
            var myReturn = GetLevelBasedDamage();

            // Implement

            
            return myReturn;
        }

        #endregion GetAttributes

        #region Items
        // Drop All Items
        // Return a list of items for the pool of items
        public List<Item> DropAllItems()
        {
            var myReturn = new List<Item>();

            // Implement

            // Drop all Items
            
            return myReturn;
        }

        // Remove Item from a set location
        // Does this by adding a new item of Null to the location
        // This will return the previous item, and put null in its place
        // Returns the item that was at the location
        // Nulls out the location
        public Item RemoveItem(ItemLocationEnum itemlocation)
        {
            var myReturn = AddItem(itemlocation, null);

            // Save Changes
            return myReturn;
        }

        // Get the Item at a known string location (head, foot etc.)
        public Item GetItem(string itemString)
        {
            return ItemsViewModel.Instance.GetItem(itemString);
        }

        // Get the Item at a known string location (head, foot etc.)
        public Item GetItemByLocation(ItemLocationEnum itemLocation)
        {
            // Implement

            return null;
        }

        // Add Item
        // Looks up the Item
        // Puts the Item ID as a string in the location slot
        // If item is null, then puts null in the slot
        // Returns the item that was in the location
        public Item AddItem(ItemLocationEnum itemlocation, string itemID)
        {
            Item myReturn = new Item();

            // Implement

            return myReturn;
        }

        // Walk all the Items on the Character.
        // Add together all Items that modify the Attribute Enum Passed in
        // Return the sum
        public int GetItemBonus(AttributeEnum attributeEnum)
        {
            var myReturn = 0;
            Item myItem;
            // Implement

            return myReturn;
        }

        #endregion Items

        // Take Damage
        // If the damage recived, is > health, then death occurs
        // Return the number of experience received for this attack 
        // monsters give experience to characters.  Characters don't accept expereince from monsters
        public void TakeDamage(int damage)
        {
            // Implement
        }
    }
}