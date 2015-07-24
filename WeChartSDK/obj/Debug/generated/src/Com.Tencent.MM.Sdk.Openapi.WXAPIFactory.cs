using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.MM.Sdk.Openapi {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.mm.sdk.openapi']/class[@name='WXAPIFactory']"
	[global::Android.Runtime.Register ("com/tencent/mm/sdk/openapi/WXAPIFactory", DoNotGenerateAcw=true)]
	public partial class WXAPIFactory : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/mm/sdk/openapi/WXAPIFactory", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (WXAPIFactory); }
		}

		protected WXAPIFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_createWXAPI_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mm.sdk.openapi']/class[@name='WXAPIFactory']/method[@name='createWXAPI' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("createWXAPI", "(Landroid/content/Context;Ljava/lang/String;)Lcom/tencent/mm/sdk/openapi/IWXAPI;", "")]
		public static global::Com.Tencent.MM.Sdk.Openapi.IWXAPI CreateWXAPI (global::Android.Content.Context p0, string p1)
		{
			if (id_createWXAPI_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_createWXAPI_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "createWXAPI", "(Landroid/content/Context;Ljava/lang/String;)Lcom/tencent/mm/sdk/openapi/IWXAPI;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			global::Com.Tencent.MM.Sdk.Openapi.IWXAPI __ret = global::Java.Lang.Object.GetObject<global::Com.Tencent.MM.Sdk.Openapi.IWXAPI> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createWXAPI_Landroid_content_Context_Ljava_lang_String_, new JValue (p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static IntPtr id_createWXAPI_Landroid_content_Context_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mm.sdk.openapi']/class[@name='WXAPIFactory']/method[@name='createWXAPI' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean']]"
		[Register ("createWXAPI", "(Landroid/content/Context;Ljava/lang/String;Z)Lcom/tencent/mm/sdk/openapi/IWXAPI;", "")]
		public static global::Com.Tencent.MM.Sdk.Openapi.IWXAPI CreateWXAPI (global::Android.Content.Context p0, string p1, bool p2)
		{
			if (id_createWXAPI_Landroid_content_Context_Ljava_lang_String_Z == IntPtr.Zero)
				id_createWXAPI_Landroid_content_Context_Ljava_lang_String_Z = JNIEnv.GetStaticMethodID (class_ref, "createWXAPI", "(Landroid/content/Context;Ljava/lang/String;Z)Lcom/tencent/mm/sdk/openapi/IWXAPI;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			global::Com.Tencent.MM.Sdk.Openapi.IWXAPI __ret = global::Java.Lang.Object.GetObject<global::Com.Tencent.MM.Sdk.Openapi.IWXAPI> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createWXAPI_Landroid_content_Context_Ljava_lang_String_Z, new JValue (p0), new JValue (native_p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

	}
}
