using System;
using System.ComponentModel.DataAnnotations;
namespace AspNetCoreTodo.Models
{
    public class TodoItem
    {
        /* This class defines what the database will need to store for each to-do item:
         * an ID, a title or name, whether the item is complete, and what the due date is. 
         */

        public Guid Id { get; set; } // globally unique identifier. Guids (or GUIDs) are long strings of letters and numbers, like 43ec09f2-7f70-4f4b-9559-65011d5781bb
        public bool IsDone { get; set; } // switches property to true when the user clicks an item's checkbox in the view
        [Required] // tells ASP.NET Core that this string can't be null or empty.
        public string Title { get; set; } // will hold the name or description of the to-do item
        public DateTimeOffset? DueAt { get; set; } // stores a date/time stamp along with a timezone offset from UTC. "?" means due date is nullable/optional
    }
}
