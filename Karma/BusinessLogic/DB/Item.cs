﻿using System;

namespace BusinessLogic
{
    /// <summary>
    /// Item template.
    /// </summary>
    public class Item : IComparable
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ContactInfo { get; set; }

        public string Category { get; set; }

        public DateTime Date { get; set; }

        public enum SortType
        {
            Date,
            Name
        }

        public Item()
        {
        }

        public Item(string[] itemInfo)
        {
            try
            {
                this.Name = itemInfo[0];
                this.Description = itemInfo[1];
                this.ContactInfo = itemInfo[2];
                this.Date = DateTime.Parse(itemInfo[3]);
            }
            catch (Exception)
            {

            }
            
        }


        public int CompareTo(object obj)
        {
            return Date.CompareTo(obj);
        }

       

    }

}
