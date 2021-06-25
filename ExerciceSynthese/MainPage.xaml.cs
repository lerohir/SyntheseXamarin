using ExerciceSynthese.Dal;
using ExerciceSynthese.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ExerciceSynthese
{
	public partial class MainPage : ContentPage
	{
        List<Tache> taches = new List<Tache>();
        Tache tache = new Tache();

        public MainPage()
		{
			InitializeComponent();

			//Date
			lbDate.Text = DateTime.Today.ToString();

			//Remplir listeView
			
			taches = new TacheDal().SelectAll();

			lstvTaches.ItemsSource = taches;

            //Acces View Bouton

            lstvTaches.ItemTapped += LstvTaches_ItemTapped;

		}

        private void LstvTaches_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            object tacheselect = e.Item;
            
            Navigation.PushModalAsync(new Detail((Tache)e.Item));
            
        }

        protected override void OnAppearing()
        {
            taches = new TacheDal().SelectAll();
            lstvTaches.ItemsSource = taches;
            base.OnAppearing();
        }

        private void ibCompte_Clicked(object sender, EventArgs e)
        {
			Navigation.PushModalAsync(new Compte());

        }

        private void ibPlus_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Detail());


        }

        private void Switch_Toggled(object sender, ToggledEventArgs e)
        {
                Tache tache = (Tache)((Switch)sender).BindingContext;
                tache.Etat = e.Value;
                new TacheDal().Sauvegarder(tache);

        }

    }
}
