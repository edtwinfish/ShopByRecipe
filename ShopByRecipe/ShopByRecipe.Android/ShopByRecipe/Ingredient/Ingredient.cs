using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace ShopByRecipe.Droid.ShopByRecipe.Ingredient
{
    class Ingredient
    {
        // how to deal with unique auto generate ID???
        // do i even need ID???
        int ID;
        String Description;

        public Ingredient(String Description)
        {
            this.Description = Description;
        }
    }
}