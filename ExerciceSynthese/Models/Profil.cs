using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciceSynthese.Models
{
	public class Profil
	{
		[PrimaryKey, AutoIncrement]
		public int Id { get; set; }
		public string Prenom { get; set; }
		public int Age { get; set; }
		public string Nom { get; set; }

	}
}
