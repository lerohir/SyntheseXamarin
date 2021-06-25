using ExerciceSynthese.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciceSynthese.Dal
{
	//Cette classe va de sauvegarder ou de selectionner un profil.
	public class ProfilDal
	{
		private SQLiteConnection _dbb;
		public ProfilDal()
		{
			_dbb = App.SQLiteConnection;
		}

		public Profil Select(int id)
		{
			return _dbb.Table<Profil>().Where(x => x.Id == id).FirstOrDefault();
		}

		public void Sauvegarder(Profil profil)
		{
			if (profil.Id != 0)
				_dbb.Update(profil);
			else
				_dbb.Insert(profil);
		}
	}
}
