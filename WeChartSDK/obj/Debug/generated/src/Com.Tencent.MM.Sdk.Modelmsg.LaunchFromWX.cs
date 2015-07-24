using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.MM.Sdk.Modelmsg {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/class[@name='LaunchFromWX']"
	[global::Android.Runtime.Register ("com/tencent/mm/sdk/modelmsg/LaunchFromWX", DoNotGenerateAcw=true)]
	public partial class LaunchFromWX : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/class[@name='LaunchFromWX.Req']"
		[global::Android.Runtime.Register ("com/tencent/mm/sdk/modelmsg/LaunchFromWX$Req", DoNotGenerateAcw=true)]
		public partial class Req : global::Com.Tencent.MM.Sdk.Modelbase.BaseReq {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/tencent/mm/sdk/modelmsg/LaunchFromWX$Req", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Req); }
			}

			protected Req (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/class[@name='LaunchFromWX.Req']/constructor[@name='LaunchFromWX.Req' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public Req () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (Req)) {
					SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "()V"), JniHandleOwnership.TransferLocalRef);
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (JNIEnv.NewObject (class_ref, id_ctor), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_ctor_Landroid_os_Bundle_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/class[@name='LaunchFromWX.Req']/constructor[@name='LaunchFromWX.Req' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
			[Register (".ctor", "(Landroid/os/Bundle;)V", "")]
			public Req (global::Android.OS.Bundle p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (Req)) {
					SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Landroid/os/Bundle;)V", new JValue (p0)), JniHandleOwnership.TransferLocalRef);
					return;
				}

				if (id_ctor_Landroid_os_Bundle_ == IntPtr.Zero)
					id_ctor_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/os/Bundle;)V");
				SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Landroid_os_Bundle_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			}

			static Delegate cb_getType;
#pragma warning disable 0169
			static Delegate GetGetTypeHandler ()
			{
				if (cb_getType == null)
					cb_getType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetType);
				return cb_getType;
			}

			static int n_GetType (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Tencent.MM.Sdk.Modelmsg.LaunchFromWX.Req __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.MM.Sdk.Modelmsg.LaunchFromWX.Req> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Type;
			}
#pragma warning restore 0169

			static IntPtr id_getType;
			public override int Type {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/class[@name='LaunchFromWX.Req']/method[@name='getType' and count(parameter)=0]"
				[Register ("getType", "()I", "GetGetTypeHandler")]
				get {
					if (id_getType == IntPtr.Zero)
						id_getType = JNIEnv.GetMethodID (class_ref, "getType", "()I");

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getType);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, id_getType);
				}
			}

			static Delegate cb_checkArgs;
#pragma warning disable 0169
			static Delegate GetCheckArgsHandler ()
			{
				if (cb_checkArgs == null)
					cb_checkArgs = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_CheckArgs);
				return cb_checkArgs;
			}

			static bool n_CheckArgs (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Tencent.MM.Sdk.Modelmsg.LaunchFromWX.Req __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.MM.Sdk.Modelmsg.LaunchFromWX.Req> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.CheckArgs ();
			}
#pragma warning restore 0169

			static IntPtr id_checkArgs;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/class[@name='LaunchFromWX.Req']/method[@name='checkArgs' and count(parameter)=0]"
			[Register ("checkArgs", "()Z", "GetCheckArgsHandler")]
			public override bool CheckArgs ()
			{
				if (id_checkArgs == IntPtr.Zero)
					id_checkArgs = JNIEnv.GetMethodID (class_ref, "checkArgs", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_checkArgs);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_checkArgs);
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/class[@name='LaunchFromWX.Resp']"
		[global::Android.Runtime.Register ("com/tencent/mm/sdk/modelmsg/LaunchFromWX$Resp", DoNotGenerateAcw=true)]
		public partial class Resp : global::Com.Tencent.MM.Sdk.Modelbase.BaseResp {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/tencent/mm/sdk/modelmsg/LaunchFromWX$Resp", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Resp); }
			}

			protected Resp (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/class[@name='LaunchFromWX.Resp']/constructor[@name='LaunchFromWX.Resp' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public Resp () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (Resp)) {
					SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "()V"), JniHandleOwnership.TransferLocalRef);
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (JNIEnv.NewObject (class_ref, id_ctor), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_ctor_Landroid_os_Bundle_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/class[@name='LaunchFromWX.Resp']/constructor[@name='LaunchFromWX.Resp' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
			[Register (".ctor", "(Landroid/os/Bundle;)V", "")]
			public Resp (global::Android.OS.Bundle p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (Resp)) {
					SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Landroid/os/Bundle;)V", new JValue (p0)), JniHandleOwnership.TransferLocalRef);
					return;
				}

				if (id_ctor_Landroid_os_Bundle_ == IntPtr.Zero)
					id_ctor_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/os/Bundle;)V");
				SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Landroid_os_Bundle_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			}

			static Delegate cb_getType;
#pragma warning disable 0169
			static Delegate GetGetTypeHandler ()
			{
				if (cb_getType == null)
					cb_getType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetType);
				return cb_getType;
			}

			static int n_GetType (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Tencent.MM.Sdk.Modelmsg.LaunchFromWX.Resp __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.MM.Sdk.Modelmsg.LaunchFromWX.Resp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Type;
			}
#pragma warning restore 0169

			static IntPtr id_getType;
			public override int Type {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/class[@name='LaunchFromWX.Resp']/method[@name='getType' and count(parameter)=0]"
				[Register ("getType", "()I", "GetGetTypeHandler")]
				get {
					if (id_getType == IntPtr.Zero)
						id_getType = JNIEnv.GetMethodID (class_ref, "getType", "()I");

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getType);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, id_getType);
				}
			}

			static Delegate cb_checkArgs;
#pragma warning disable 0169
			static Delegate GetCheckArgsHandler ()
			{
				if (cb_checkArgs == null)
					cb_checkArgs = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_CheckArgs);
				return cb_checkArgs;
			}

			static bool n_CheckArgs (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Tencent.MM.Sdk.Modelmsg.LaunchFromWX.Resp __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.MM.Sdk.Modelmsg.LaunchFromWX.Resp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.CheckArgs ();
			}
#pragma warning restore 0169

			static IntPtr id_checkArgs;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/class[@name='LaunchFromWX.Resp']/method[@name='checkArgs' and count(parameter)=0]"
			[Register ("checkArgs", "()Z", "GetCheckArgsHandler")]
			public override bool CheckArgs ()
			{
				if (id_checkArgs == IntPtr.Zero)
					id_checkArgs = JNIEnv.GetMethodID (class_ref, "checkArgs", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_checkArgs);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_checkArgs);
			}

		}

		protected LaunchFromWX (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
