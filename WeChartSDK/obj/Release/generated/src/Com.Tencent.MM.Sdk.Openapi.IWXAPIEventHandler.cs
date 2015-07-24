using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.MM.Sdk.Openapi {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.tencent.mm.sdk.openapi']/interface[@name='IWXAPIEventHandler']"
	[Register ("com/tencent/mm/sdk/openapi/IWXAPIEventHandler", "", "Com.Tencent.MM.Sdk.Openapi.IWXAPIEventHandlerInvoker")]
	public partial interface IWXAPIEventHandler : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mm.sdk.openapi']/interface[@name='IWXAPIEventHandler']/method[@name='onReq' and count(parameter)=1 and parameter[1][@type='com.tencent.mm.sdk.modelbase.BaseReq']]"
		[Register ("onReq", "(Lcom/tencent/mm/sdk/modelbase/BaseReq;)V", "GetOnReq_Lcom_tencent_mm_sdk_modelbase_BaseReq_Handler:Com.Tencent.MM.Sdk.Openapi.IWXAPIEventHandlerInvoker, WeChartSDK")]
		void OnReq (global::Com.Tencent.MM.Sdk.Modelbase.BaseReq p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mm.sdk.openapi']/interface[@name='IWXAPIEventHandler']/method[@name='onResp' and count(parameter)=1 and parameter[1][@type='com.tencent.mm.sdk.modelbase.BaseResp']]"
		[Register ("onResp", "(Lcom/tencent/mm/sdk/modelbase/BaseResp;)V", "GetOnResp_Lcom_tencent_mm_sdk_modelbase_BaseResp_Handler:Com.Tencent.MM.Sdk.Openapi.IWXAPIEventHandlerInvoker, WeChartSDK")]
		void OnResp (global::Com.Tencent.MM.Sdk.Modelbase.BaseResp p0);

	}

	[global::Android.Runtime.Register ("com/tencent/mm/sdk/openapi/IWXAPIEventHandler", DoNotGenerateAcw=true)]
	internal class IWXAPIEventHandlerInvoker : global::Java.Lang.Object, IWXAPIEventHandler {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/tencent/mm/sdk/openapi/IWXAPIEventHandler");
		IntPtr class_ref;

		public static IWXAPIEventHandler GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IWXAPIEventHandler> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.tencent.mm.sdk.openapi.IWXAPIEventHandler"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IWXAPIEventHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IWXAPIEventHandlerInvoker); }
		}

		static Delegate cb_onReq_Lcom_tencent_mm_sdk_modelbase_BaseReq_;
#pragma warning disable 0169
		static Delegate GetOnReq_Lcom_tencent_mm_sdk_modelbase_BaseReq_Handler ()
		{
			if (cb_onReq_Lcom_tencent_mm_sdk_modelbase_BaseReq_ == null)
				cb_onReq_Lcom_tencent_mm_sdk_modelbase_BaseReq_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnReq_Lcom_tencent_mm_sdk_modelbase_BaseReq_);
			return cb_onReq_Lcom_tencent_mm_sdk_modelbase_BaseReq_;
		}

		static void n_OnReq_Lcom_tencent_mm_sdk_modelbase_BaseReq_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.MM.Sdk.Openapi.IWXAPIEventHandler __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.MM.Sdk.Openapi.IWXAPIEventHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.MM.Sdk.Modelbase.BaseReq p0 = global::Java.Lang.Object.GetObject<global::Com.Tencent.MM.Sdk.Modelbase.BaseReq> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnReq (p0);
		}
#pragma warning restore 0169

		IntPtr id_onReq_Lcom_tencent_mm_sdk_modelbase_BaseReq_;
		public void OnReq (global::Com.Tencent.MM.Sdk.Modelbase.BaseReq p0)
		{
			if (id_onReq_Lcom_tencent_mm_sdk_modelbase_BaseReq_ == IntPtr.Zero)
				id_onReq_Lcom_tencent_mm_sdk_modelbase_BaseReq_ = JNIEnv.GetMethodID (class_ref, "onReq", "(Lcom/tencent/mm/sdk/modelbase/BaseReq;)V");
			JNIEnv.CallVoidMethod (Handle, id_onReq_Lcom_tencent_mm_sdk_modelbase_BaseReq_, new JValue (p0));
		}

		static Delegate cb_onResp_Lcom_tencent_mm_sdk_modelbase_BaseResp_;
#pragma warning disable 0169
		static Delegate GetOnResp_Lcom_tencent_mm_sdk_modelbase_BaseResp_Handler ()
		{
			if (cb_onResp_Lcom_tencent_mm_sdk_modelbase_BaseResp_ == null)
				cb_onResp_Lcom_tencent_mm_sdk_modelbase_BaseResp_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnResp_Lcom_tencent_mm_sdk_modelbase_BaseResp_);
			return cb_onResp_Lcom_tencent_mm_sdk_modelbase_BaseResp_;
		}

		static void n_OnResp_Lcom_tencent_mm_sdk_modelbase_BaseResp_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.MM.Sdk.Openapi.IWXAPIEventHandler __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.MM.Sdk.Openapi.IWXAPIEventHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.MM.Sdk.Modelbase.BaseResp p0 = global::Java.Lang.Object.GetObject<global::Com.Tencent.MM.Sdk.Modelbase.BaseResp> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnResp (p0);
		}
#pragma warning restore 0169

		IntPtr id_onResp_Lcom_tencent_mm_sdk_modelbase_BaseResp_;
		public void OnResp (global::Com.Tencent.MM.Sdk.Modelbase.BaseResp p0)
		{
			if (id_onResp_Lcom_tencent_mm_sdk_modelbase_BaseResp_ == IntPtr.Zero)
				id_onResp_Lcom_tencent_mm_sdk_modelbase_BaseResp_ = JNIEnv.GetMethodID (class_ref, "onResp", "(Lcom/tencent/mm/sdk/modelbase/BaseResp;)V");
			JNIEnv.CallVoidMethod (Handle, id_onResp_Lcom_tencent_mm_sdk_modelbase_BaseResp_, new JValue (p0));
		}

	}

}
