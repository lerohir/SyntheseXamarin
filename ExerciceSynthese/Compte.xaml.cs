using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ExerciceSynthese.Dal;
using ExerciceSynthese.Models;

namespace ExerciceSynthese
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Compte : ContentPage
    {
        public Compte()
        {
            InitializeComponent();
            Profil profil = new Profil();
            profil = new ProfilDal().Select(1);
            if ( profil != null)
            {
                entNom.Text = profil.Nom;
                entPrenom.Text = profil.Prenom;
                entAge.Text = (profil.Age).ToString();
            }
            

        }

        private void Retour_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();

        }

        private void Ok_Clicked(object sender, EventArgs e)
        {
            Profil profil = new Profil() { Nom = entNom.Text, Prenom = entPrenom.Text, Age = Convert.ToInt32(entAge.Text), Id=1 };
            new ProfilDal().Sauvegarder(profil);

            Navigation.PopModalAsync();

        }
    }
}