package md501adad5b41639b7c6aa090f81a33dfab;


public class InterruptorCaja
	extends android.support.v7.app.ActionBarDrawerToggle
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onDrawerClosed:(Landroid/view/View;)V:GetOnDrawerClosed_Landroid_view_View_Handler\n" +
			"n_onDrawerOpened:(Landroid/view/View;)V:GetOnDrawerOpened_Landroid_view_View_Handler\n" +
			"";
		mono.android.Runtime.register ("CajaNavegacion.InterruptorCaja, CajaNavegacion", InterruptorCaja.class, __md_methods);
	}


	public InterruptorCaja (android.app.Activity p0, android.support.v4.widget.DrawerLayout p1, android.support.v7.widget.Toolbar p2, int p3, int p4)
	{
		super (p0, p1, p2, p3, p4);
		if (getClass () == InterruptorCaja.class)
			mono.android.TypeManager.Activate ("CajaNavegacion.InterruptorCaja, CajaNavegacion", "Android.App.Activity, Mono.Android:Android.Support.V4.Widget.DrawerLayout, Xamarin.Android.Support.DrawerLayout:Android.Support.V7.Widget.Toolbar, Xamarin.Android.Support.v7.AppCompat:System.Int32, mscorlib:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2, p3, p4 });
	}


	public InterruptorCaja (android.app.Activity p0, android.support.v4.widget.DrawerLayout p1, int p2, int p3)
	{
		super (p0, p1, p2, p3);
		if (getClass () == InterruptorCaja.class)
			mono.android.TypeManager.Activate ("CajaNavegacion.InterruptorCaja, CajaNavegacion", "Android.App.Activity, Mono.Android:Android.Support.V4.Widget.DrawerLayout, Xamarin.Android.Support.DrawerLayout:System.Int32, mscorlib:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2, p3 });
	}


	public void onDrawerClosed (android.view.View p0)
	{
		n_onDrawerClosed (p0);
	}

	private native void n_onDrawerClosed (android.view.View p0);


	public void onDrawerOpened (android.view.View p0)
	{
		n_onDrawerOpened (p0);
	}

	private native void n_onDrawerOpened (android.view.View p0);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
