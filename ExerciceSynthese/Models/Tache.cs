using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciceSynthese.Models
{
	public class Tache
	{
		[PrimaryKey, AutoIncrement]
		public int Id { get; set; }
		public string Title { get; set; }
		public DateTime Date { get; set; }
		public string Description { get; set; }
		public bool Etat { get; set; }
	}
}
