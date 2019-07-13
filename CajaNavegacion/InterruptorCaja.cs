using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V4.Widget;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;

namespace CajaNavegacion
{
    class InterruptorCaja : ActionBarDrawerToggle
    {
        public InterruptorCaja(Activity activity, DrawerLayout drawerLayout) : base(activity, drawerLayout, Resource.Mipmap.ic_launcher, Resource.Mipmap.ic_launcher)
        {

        }

        public override void OnDrawerClosed(View drawerView)
        {
            base.OnDrawerClosed(drawerView);
            var handler = DrawerClosed;
            if (handler != null)
                handler(this, EventArgs.Empty);
        }

        public override void OnDrawerOpened(View drawerView)
        {
            base.OnDrawerOpened(drawerView);
            var handler = DrawerOpened;
            if (handler != null)
                handler(this, EventArgs.Empty);
        }

        public event EventHandler DrawerClosed;
        public event EventHandler DrawerOpened;

    }
}