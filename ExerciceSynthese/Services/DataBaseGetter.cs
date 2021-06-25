using ExerciceSynthese.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ExerciceSynthese.Services
{
	//Permet de créer la base de données.
	public class DataBaseGetter
	{
		public SQLiteConnection Get()
		{
			string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "GestionTache.db3");
			var db = new SQLiteConnection(dbPath);
			db.CreateTable<Tache>();
			db.CreateTable<Profil>();
			return db;
		}
	}
}
