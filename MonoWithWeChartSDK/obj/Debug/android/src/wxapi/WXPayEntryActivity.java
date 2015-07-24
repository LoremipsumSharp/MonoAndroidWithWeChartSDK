package wxapi;


public class WXPayEntryActivity
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer,
		com.tencent.mm.sdk.openapi.IWXAPIEventHandler
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"n_onNewIntent:(Landroid/content/Intent;)V:GetOnNewIntent_Landroid_content_Intent_Handler\n" +
			"n_onReq:(Lcom/tencent/mm/sdk/modelbase/BaseReq;)V:GetOnReq_Lcom_tencent_mm_sdk_modelbase_BaseReq_Handler:Com.Tencent.MM.Sdk.Openapi.IWXAPIEventHandlerInvoker, WeChartSDK\n" +
			"n_onResp:(Lcom/tencent/mm/sdk/modelbase/BaseResp;)V:GetOnResp_Lcom_tencent_mm_sdk_modelbase_BaseResp_Handler:Com.Tencent.MM.Sdk.Openapi.IWXAPIEventHandlerInvoker, WeChartSDK\n" +
			"";
		mono.android.Runtime.register ("wxapi.WXPayEntryActivity, MonoWithWeChartSDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", WXPayEntryActivity.class, __md_methods);
	}


	public WXPayEntryActivity () throws java.lang.Throwable
	{
		super ();
		if (getClass () == WXPayEntryActivity.class)
			mono.android.TypeManager.Activate ("wxapi.WXPayEntryActivity, MonoWithWeChartSDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);


	public void onNewIntent (android.content.Intent p0)
	{
		n_onNewIntent (p0);
	}

	private native void n_onNewIntent (android.content.Intent p0);


	public void onReq (com.tencent.mm.sdk.modelbase.BaseReq p0)
	{
		n_onReq (p0);
	}

	private native void n_onReq (com.tencent.mm.sdk.modelbase.BaseReq p0);


	public void onResp (com.tencent.mm.sdk.modelbase.BaseResp p0)
	{
		n_onResp (p0);
	}

	private native void n_onResp (com.tencent.mm.sdk.modelbase.BaseResp p0);

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
