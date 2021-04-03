using System;
using System.Collections.Generic;

namespace books_app
{
	class book
	{
		public string Name { get; set; }
		public string Author { get; set; }
		public string Genre { get; set; }
		public int Publish_Date { get; set; }
		public string Description { get; set; }

		public book(string title, string writer, string genre, int release_date, string description)
		{
			this.Name = title;
			this.Author = writer;
			this.Genre = genre;
			this.Publish_Date = release_date;
			this.Description = description;
		}

		public override String ToString() 
        {
			return Name + " " + Author + " " + Genre + " " + Publish_Date + " " + Description + " ";
        }
	}
}
