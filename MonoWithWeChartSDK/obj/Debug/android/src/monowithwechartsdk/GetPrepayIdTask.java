package monowithwechartsdk;


public class GetPrepayIdTask
	extends android.os.AsyncTask
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onPreExecute:()V:GetOnPreExecuteHandler\n" +
			"n_doInBackground:([Ljava/lang/Object;)Ljava/lang/Object;:GetDoInBackground_arrayLjava_lang_Object_Handler\n" +
			"n_onPostExecute:(Ljava/lang/Object;)V:GetOnPostExecute_Ljava_lang_Object_Handler\n" +
			"";
		mono.android.Runtime.register ("MonoWithWeChartSDK.GetPrepayIdTask, MonoWithWeChartSDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", GetPrepayIdTask.class, __md_methods);
	}


	public GetPrepayIdTask () throws java.lang.Throwable
	{
		super ();
		if (getClass () == GetPrepayIdTask.class)
			mono.android.TypeManager.Activate ("MonoWithWeChartSDK.GetPrepayIdTask, MonoWithWeChartSDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	public GetPrepayIdTask (android.app.Activity p0, java.lang.String p1) throws java.lang.Throwable
	{
		super ();
		if (getClass () == GetPrepayIdTask.class)
			mono.android.TypeManager.Activate ("MonoWithWeChartSDK.GetPrepayIdTask, MonoWithWeChartSDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.App.Activity, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:System.String, mscorlib, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e", this, new java.lang.Object[] { p0, p1 });
	}


	public void onPreExecute ()
	{
		n_onPreExecute ();
	}

	private native void n_onPreExecute ();


	public java.lang.Object doInBackground (java.lang.Object[] p0)
	{
		return n_doInBackground (p0);
	}

	private native java.lang.Object n_doInBackground (java.lang.Object[] p0);


	public void onPostExecute (java.lang.Object p0)
	{
		n_onPostExecute (p0);
	}

	private native void n_onPostExecute (java.lang.Object p0);

	java.util.ArrayList refList;
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
