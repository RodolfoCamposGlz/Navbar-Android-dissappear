using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using Android.Views;
using Android.Support.Design.Widget;
using Android.Graphics.Drawables;
using Android.Graphics;

namespace ParkingaAndroid
{
    [Activity(Label = "ParkingaAndroid", MainLauncher = true, Icon = "@mipmap/icon", Theme = "@style/Theme.AppCompat.Light.NoActionBar")]
    public class MainActivity : AppCompatActivity
    {
        int bandera=0;
        int intColorCode = 0;
        AppBarLayout appBarLayout;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            RequestWindowFeature(WindowFeatures.NoTitle);
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            appBarLayout = FindViewById<AppBarLayout>(Resource.Id.appbar);
            Android.Support.V7.Widget.Toolbar toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);    
            SetSupportActionBar(toolbar);
           
            appBarLayout.OffsetChanged += (sender, args) =>
            {
				
                intColorCode = -(args.VerticalOffset);
                if (intColorCode > 400)
                {
                    intColorCode = 255;

                }

			else
					intColorCode = intColorCode - 150;

				toolbar.Background.Alpha = intColorCode;
                toolbar.Alpha = intColorCode;

			};
        }
    }
}


                //toolbar.GetBackground().setAlpha(intColorCode);
                //toolbar.setAlpha(intColorCode);

            /* appBarLayout.addOnOffsetChangedListener(new AppBarLayout.OnOffsetChangedListener()
            {

             @Override

             public void onOffsetChanged(AppBarLayout appBarLayout, int verticalOffset)
             {


                 intColorCode = -(verticalOffset);
                 if (intColorCode > 255)
                     intColorCode = 255;

                 toolbar.getBackground().setAlpha(intColorCode);
                 toolbar.setAlpha(intColorCode);


             }
         });
         */




            // Get our button from the layout resource,
            // and attach an event to it

            //var Imagen = FindViewById<ImageView>(Resource.Id.imagen);
            //Imagen.SetImageResource(Resource.Drawable.shoe);
            //var Imagen2 = FindViewById<ImageView>(Resource.Id.imagen1);
            //Imagen2.SetImageResource(Resource.Drawable.shoe);



