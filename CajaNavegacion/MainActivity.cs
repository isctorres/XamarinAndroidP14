using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Support.V4.Widget;
using Android.Content.Res;

namespace CajaNavegacion
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private InterruptorCaja interruptorCaja;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            string titulo = "";
            DrawerLayout drawerLayout = FindViewById<DrawerLayout>(Resource.Id.drawerLayout);
            FrameLayout drawerContentMain = FindViewById<FrameLayout>(Resource.Id.drawerContentMain);
            ListView drawerListMenu = FindViewById<ListView>(Resource.Id.drawerListMenu);
            drawerListMenu.Adapter = new ArrayAdapter(this,
                Android.Resource.Layout.SimpleListItem1,
                new[] { "Acerca de", "Nuevo", "Guardar", "Deshacer" });
            drawerListMenu.ItemClick += (sender, e) => {
                //Toast.MakeText(this, e.Id+"", ToastLength.Long).Show();
                Bundle args = new Bundle();
                switch (e.Id)
                {
                    case 0:
                        ContentFragmentUno content = new ContentFragmentUno();
                        args.PutString("Acerca de..", drawerListMenu.GetItemAtPosition(e.Position).ToString());
                        content.Arguments = args;
                        SupportFragmentManager.BeginTransaction().Replace(Resource.Id.drawerContentMain, content).Commit();
                        titulo = "Acerca de";
                        break;
                    case 1:
                        NuevoFragment nuevo = new NuevoFragment();
                        args.PutString("Nuevo", drawerListMenu.GetItemAtPosition(e.Position).ToString());
                        nuevo.Arguments = args;
                        SupportFragmentManager.BeginTransaction().Replace(Resource.Id.drawerContentMain, nuevo).Commit();
                        titulo = "Nuevo";
                        break;
                    case 2:
                        GuardarFragment guardar = new GuardarFragment();
                        args.PutString("Guardar", drawerListMenu.GetItemAtPosition(e.Position).ToString());
                        guardar.Arguments = args;
                        SupportFragmentManager.BeginTransaction().Replace(Resource.Id.drawerContentMain, guardar).Commit();
                        titulo = "Guardar";
                        break;
                    case 3:
                        DeshacerFragment deshacer = new DeshacerFragment();
                        args.PutString("Deshacer", drawerListMenu.GetItemAtPosition(e.Position).ToString());
                        deshacer.Arguments = args;
                        SupportFragmentManager.BeginTransaction().Replace(Resource.Id.drawerContentMain, deshacer).Commit();
                        titulo = "Deshacer";
                        break;
                }
                
                drawerListMenu.SetItemChecked(e.Position, true);
                drawerLayout.CloseDrawer(drawerListMenu);
            };

            interruptorCaja = new InterruptorCaja(this, drawerLayout);
            interruptorCaja.DrawerClosed += delegate {
                SupportActionBar.Title = titulo;
                InvalidateOptionsMenu();
            };
            interruptorCaja.DrawerOpened += delegate {
                SupportActionBar.Title = "Aplicación";
                InvalidateOptionsMenu();
            };
            drawerLayout.AddDrawerListener(interruptorCaja);
            SupportActionBar.SetDisplayHomeAsUpEnabled(true);
            SupportActionBar.SetHomeButtonEnabled(true);
        }

        protected override void OnPostCreate(Bundle savedInstanceState)
        {
            base.OnPostCreate(savedInstanceState);
            interruptorCaja.SyncState();
        }

        public override void OnConfigurationChanged(Configuration newConfig)
        {
            base.OnConfigurationChanged(newConfig);
            interruptorCaja.OnConfigurationChanged(newConfig);
        }

        public override bool OnOptionsItemSelected(Android.Views.IMenuItem item)
        {
            if (interruptorCaja.OnOptionsItemSelected(item))
            {
                return true;
            }
            return base.OnOptionsItemSelected(item);
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}