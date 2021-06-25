using ExerciceSynthese.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciceSynthese.Dal
{
	//Cette classe va permettre de selection une ou plusieurs taches ainsi que de sauvagrder une tache.
	public class TacheDal
	{
		private SQLiteConnection _dbb;
		public TacheDal()
		{
			_dbb = App.SQLiteConnection;
		}
		
		public List<Tache> SelectAll()
		{
			return _dbb.Table<Tache>().ToList();
		}

		public Tache Select(int id)
		{
			return _dbb.Table<Tache>().Where(x => x.Id == id).FirstOrDefault();
		}

		public void Sauvegarder(Tache tache)
		{
			if (tache.Id != 0)
				_dbb.Update(tache);
			else
				_dbb.Insert(tache);
		}
	}
}
