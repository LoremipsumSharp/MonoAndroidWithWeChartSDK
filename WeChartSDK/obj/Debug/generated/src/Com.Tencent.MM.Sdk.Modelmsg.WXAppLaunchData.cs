using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.MM.Sdk.Modelmsg {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/class[@name='WXAppLaunchData']"
	[global::Android.Runtime.Register ("com/tencent/mm/sdk/modelmsg/WXAppLaunchData", DoNotGenerateAcw=true)]
	public sealed partial class WXAppLaunchData : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/class[@name='WXAppLaunchData']/field[@name='ACTION_HANDLE_WXAPPLAUNCH']"
		[Register ("ACTION_HANDLE_WXAPPLAUNCH")]
		public const string ActionHandleWxapplaunch = (string) ".ACTION_HANDLE_WXAPPLAUNCH";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/class[@name='WXAppLaunchData']/field[@name='ACTION_HANDLE_WXAPP_RESULT']"
		[Register ("ACTION_HANDLE_WXAPP_RESULT")]
		public const string ActionHandleWxappResult = (string) ".ACTION_HANDLE_WXAPP_RESULT";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/class[@name='WXAppLaunchData']/field[@name='ACTION_HANDLE_WXAPP_SHOW']"
		[Register ("ACTION_HANDLE_WXAPP_SHOW")]
		public const string ActionHandleWxappShow = (string) ".ACTION_HANDLE_WXAPP_SHOW";

		static IntPtr launchType_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/class[@name='WXAppLaunchData']/field[@name='launchType']"
		[Register ("launchType")]
		public int LaunchType {
			get {
				if (launchType_jfieldId == IntPtr.Zero)
					launchType_jfieldId = JNIEnv.GetFieldID (class_ref, "launchType", "I");
				return JNIEnv.GetIntField (Handle, launchType_jfieldId);
			}
			set {
				if (launchType_jfieldId == IntPtr.Zero)
					launchType_jfieldId = JNIEnv.GetFieldID (class_ref, "launchType", "I");
				JNIEnv.SetField (Handle, launchType_jfieldId, value);
			}
		}

		static IntPtr message_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/class[@name='WXAppLaunchData']/field[@name='message']"
		[Register ("message")]
		public string Message {
			get {
				if (message_jfieldId == IntPtr.Zero)
					message_jfieldId = JNIEnv.GetFieldID (class_ref, "message", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, message_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (message_jfieldId == IntPtr.Zero)
					message_jfieldId = JNIEnv.GetFieldID (class_ref, "message", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.SetField (Handle, message_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/class[@name='WXAppLaunchData.Builder']"
		[global::Android.Runtime.Register ("com/tencent/mm/sdk/modelmsg/WXAppLaunchData$Builder", DoNotGenerateAcw=true)]
		public partial class Builder : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/tencent/mm/sdk/modelmsg/WXAppLaunchData$Builder", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Builder); }
			}

			protected Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/class[@name='WXAppLaunchData.Builder']/constructor[@name='WXAppLaunchData.Builder' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public Builder () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (Builder)) {
					SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "()V"), JniHandleOwnership.TransferLocalRef);
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (JNIEnv.NewObject (class_ref, id_ctor), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_fromBundle_Landroid_os_Bundle_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/class[@name='WXAppLaunchData.Builder']/method[@name='fromBundle' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
			[Register ("fromBundle", "(Landroid/os/Bundle;)Lcom/tencent/mm/sdk/modelmsg/WXAppLaunchData;", "")]
			public static global::Com.Tencent.MM.Sdk.Modelmsg.WXAppLaunchData FromBundle (global::Android.OS.Bundle p0)
			{
				if (id_fromBundle_Landroid_os_Bundle_ == IntPtr.Zero)
					id_fromBundle_Landroid_os_Bundle_ = JNIEnv.GetStaticMethodID (class_ref, "fromBundle", "(Landroid/os/Bundle;)Lcom/tencent/mm/sdk/modelmsg/WXAppLaunchData;");
				global::Com.Tencent.MM.Sdk.Modelmsg.WXAppLaunchData __ret = global::Java.Lang.Object.GetObject<global::Com.Tencent.MM.Sdk.Modelmsg.WXAppLaunchData> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromBundle_Landroid_os_Bundle_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static IntPtr id_toBundle_Lcom_tencent_mm_sdk_modelmsg_WXAppLaunchData_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/class[@name='WXAppLaunchData.Builder']/method[@name='toBundle' and count(parameter)=1 and parameter[1][@type='com.tencent.mm.sdk.modelmsg.WXAppLaunchData']]"
			[Register ("toBundle", "(Lcom/tencent/mm/sdk/modelmsg/WXAppLaunchData;)Landroid/os/Bundle;", "")]
			public static global::Android.OS.Bundle ToBundle (global::Com.Tencent.MM.Sdk.Modelmsg.WXAppLaunchData p0)
			{
				if (id_toBundle_Lcom_tencent_mm_sdk_modelmsg_WXAppLaunchData_ == IntPtr.Zero)
					id_toBundle_Lcom_tencent_mm_sdk_modelmsg_WXAppLaunchData_ = JNIEnv.GetStaticMethodID (class_ref, "toBundle", "(Lcom/tencent/mm/sdk/modelmsg/WXAppLaunchData;)Landroid/os/Bundle;");
				global::Android.OS.Bundle __ret = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallStaticObjectMethod  (class_ref, id_toBundle_Lcom_tencent_mm_sdk_modelmsg_WXAppLaunchData_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/mm/sdk/modelmsg/WXAppLaunchData", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (WXAppLaunchData); }
		}

		internal WXAppLaunchData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/class[@name='WXAppLaunchData']/constructor[@name='WXAppLaunchData' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public WXAppLaunchData () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (WXAppLaunchData)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "()V"), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor), JniHandleOwnership.TransferLocalRef);
		}

	}
}
