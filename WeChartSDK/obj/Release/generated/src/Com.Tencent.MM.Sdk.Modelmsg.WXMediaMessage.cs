using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.MM.Sdk.Modelmsg {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/class[@name='WXMediaMessage']"
	[global::Android.Runtime.Register ("com/tencent/mm/sdk/modelmsg/WXMediaMessage", DoNotGenerateAcw=true)]
	public sealed partial class WXMediaMessage : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/class[@name='WXMediaMessage']/field[@name='ACTION_WXAPPMESSAGE']"
		[Register ("ACTION_WXAPPMESSAGE")]
		public const string ActionWxappmessage = (string) "com.tencent.mm.sdk.openapi.Intent.ACTION_WXAPPMESSAGE";

		static IntPtr description_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/class[@name='WXMediaMessage']/field[@name='description']"
		[Register ("description")]
		public string Description {
			get {
				if (description_jfieldId == IntPtr.Zero)
					description_jfieldId = JNIEnv.GetFieldID (class_ref, "description", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, description_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (description_jfieldId == IntPtr.Zero)
					description_jfieldId = JNIEnv.GetFieldID (class_ref, "description", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.SetField (Handle, description_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mediaObject_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/class[@name='WXMediaMessage']/field[@name='mediaObject']"
		[Register ("mediaObject")]
		public global::Com.Tencent.MM.Sdk.Modelmsg.WXMediaMessage.IMediaObject mediaObject_Rename {
			get {
				if (mediaObject_jfieldId == IntPtr.Zero)
					mediaObject_jfieldId = JNIEnv.GetFieldID (class_ref, "mediaObject", "Lcom/tencent/mm/sdk/modelmsg/WXMediaMessage$IMediaObject;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mediaObject_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.MM.Sdk.Modelmsg.WXMediaMessage.IMediaObject> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mediaObject_jfieldId == IntPtr.Zero)
					mediaObject_jfieldId = JNIEnv.GetFieldID (class_ref, "mediaObject", "Lcom/tencent/mm/sdk/modelmsg/WXMediaMessage$IMediaObject;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mediaObject_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mediaTagName_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/class[@name='WXMediaMessage']/field[@name='mediaTagName']"
		[Register ("mediaTagName")]
		public string MediaTagName {
			get {
				if (mediaTagName_jfieldId == IntPtr.Zero)
					mediaTagName_jfieldId = JNIEnv.GetFieldID (class_ref, "mediaTagName", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mediaTagName_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mediaTagName_jfieldId == IntPtr.Zero)
					mediaTagName_jfieldId = JNIEnv.GetFieldID (class_ref, "mediaTagName", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.SetField (Handle, mediaTagName_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr sdkVer_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/class[@name='WXMediaMessage']/field[@name='sdkVer']"
		[Register ("sdkVer")]
		public int SdkVer {
			get {
				if (sdkVer_jfieldId == IntPtr.Zero)
					sdkVer_jfieldId = JNIEnv.GetFieldID (class_ref, "sdkVer", "I");
				return JNIEnv.GetIntField (Handle, sdkVer_jfieldId);
			}
			set {
				if (sdkVer_jfieldId == IntPtr.Zero)
					sdkVer_jfieldId = JNIEnv.GetFieldID (class_ref, "sdkVer", "I");
				JNIEnv.SetField (Handle, sdkVer_jfieldId, value);
			}
		}

		static IntPtr thumbData_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/class[@name='WXMediaMessage']/field[@name='thumbData']"
		[Register ("thumbData")]
		public IList<byte> ThumbData {
			get {
				if (thumbData_jfieldId == IntPtr.Zero)
					thumbData_jfieldId = JNIEnv.GetFieldID (class_ref, "thumbData", "[B");
				return JavaArray<byte>.FromJniHandle (JNIEnv.GetObjectField (Handle, thumbData_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (thumbData_jfieldId == IntPtr.Zero)
					thumbData_jfieldId = JNIEnv.GetFieldID (class_ref, "thumbData", "[B");
				IntPtr native_value = JavaArray<byte>.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, thumbData_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr title_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/class[@name='WXMediaMessage']/field[@name='title']"
		[Register ("title")]
		public string Title {
			get {
				if (title_jfieldId == IntPtr.Zero)
					title_jfieldId = JNIEnv.GetFieldID (class_ref, "title", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, title_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (title_jfieldId == IntPtr.Zero)
					title_jfieldId = JNIEnv.GetFieldID (class_ref, "title", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.SetField (Handle, title_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/class[@name='WXMediaMessage.Builder']"
		[global::Android.Runtime.Register ("com/tencent/mm/sdk/modelmsg/WXMediaMessage$Builder", DoNotGenerateAcw=true)]
		public partial class Builder : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/class[@name='WXMediaMessage.Builder']/field[@name='KEY_IDENTIFIER']"
			[Register ("KEY_IDENTIFIER")]
			public const string KeyIdentifier = (string) "_wxobject_identifier_";
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/tencent/mm/sdk/modelmsg/WXMediaMessage$Builder", ref java_class_handle);
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
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/class[@name='WXMediaMessage.Builder']/constructor[@name='WXMediaMessage.Builder' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/class[@name='WXMediaMessage.Builder']/method[@name='fromBundle' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
			[Register ("fromBundle", "(Landroid/os/Bundle;)Lcom/tencent/mm/sdk/modelmsg/WXMediaMessage;", "")]
			public static global::Com.Tencent.MM.Sdk.Modelmsg.WXMediaMessage FromBundle (global::Android.OS.Bundle p0)
			{
				if (id_fromBundle_Landroid_os_Bundle_ == IntPtr.Zero)
					id_fromBundle_Landroid_os_Bundle_ = JNIEnv.GetStaticMethodID (class_ref, "fromBundle", "(Landroid/os/Bundle;)Lcom/tencent/mm/sdk/modelmsg/WXMediaMessage;");
				global::Com.Tencent.MM.Sdk.Modelmsg.WXMediaMessage __ret = global::Java.Lang.Object.GetObject<global::Com.Tencent.MM.Sdk.Modelmsg.WXMediaMessage> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromBundle_Landroid_os_Bundle_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static IntPtr id_toBundle_Lcom_tencent_mm_sdk_modelmsg_WXMediaMessage_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/class[@name='WXMediaMessage.Builder']/method[@name='toBundle' and count(parameter)=1 and parameter[1][@type='com.tencent.mm.sdk.modelmsg.WXMediaMessage']]"
			[Register ("toBundle", "(Lcom/tencent/mm/sdk/modelmsg/WXMediaMessage;)Landroid/os/Bundle;", "")]
			public static global::Android.OS.Bundle ToBundle (global::Com.Tencent.MM.Sdk.Modelmsg.WXMediaMessage p0)
			{
				if (id_toBundle_Lcom_tencent_mm_sdk_modelmsg_WXMediaMessage_ == IntPtr.Zero)
					id_toBundle_Lcom_tencent_mm_sdk_modelmsg_WXMediaMessage_ = JNIEnv.GetStaticMethodID (class_ref, "toBundle", "(Lcom/tencent/mm/sdk/modelmsg/WXMediaMessage;)Landroid/os/Bundle;");
				global::Android.OS.Bundle __ret = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallStaticObjectMethod  (class_ref, id_toBundle_Lcom_tencent_mm_sdk_modelmsg_WXMediaMessage_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

		}

		[Register ("com/tencent/mm/sdk/modelmsg/WXMediaMessage$IMediaObject")]
		public abstract class MediaObject {

			internal MediaObject ()
			{
			}

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/interface[@name='WXMediaMessage.IMediaObject']/field[@name='TYPE_APPDATA']"
			[Register ("TYPE_APPDATA")]
			public const int TypeAppdata = (int) 7;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/interface[@name='WXMediaMessage.IMediaObject']/field[@name='TYPE_EMOJI']"
			[Register ("TYPE_EMOJI")]
			public const int TypeEmoji = (int) 8;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/interface[@name='WXMediaMessage.IMediaObject']/field[@name='TYPE_FILE']"
			[Register ("TYPE_FILE")]
			public const int TypeFile = (int) 6;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/interface[@name='WXMediaMessage.IMediaObject']/field[@name='TYPE_IMAGE']"
			[Register ("TYPE_IMAGE")]
			public const int TypeImage = (int) 2;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/interface[@name='WXMediaMessage.IMediaObject']/field[@name='TYPE_MUSIC']"
			[Register ("TYPE_MUSIC")]
			public const int TypeMusic = (int) 3;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/interface[@name='WXMediaMessage.IMediaObject']/field[@name='TYPE_PRODUCT']"
			[Register ("TYPE_PRODUCT")]
			public const int TypeProduct = (int) 10;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/interface[@name='WXMediaMessage.IMediaObject']/field[@name='TYPE_TEXT']"
			[Register ("TYPE_TEXT")]
			public const int TypeText = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/interface[@name='WXMediaMessage.IMediaObject']/field[@name='TYPE_UNKNOWN']"
			[Register ("TYPE_UNKNOWN")]
			public const int TypeUnknown = (int) 0;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/interface[@name='WXMediaMessage.IMediaObject']/field[@name='TYPE_URL']"
			[Register ("TYPE_URL")]
			public const int TypeUrl = (int) 5;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/interface[@name='WXMediaMessage.IMediaObject']/field[@name='TYPE_VIDEO']"
			[Register ("TYPE_VIDEO")]
			public const int TypeVideo = (int) 4;
		}

		[System.Obsolete ("Use the 'MediaObject' type. This type will be removed in Mono for Android 5.0.")]
		public abstract class MediaObjectConsts : MediaObject {

			private MediaObjectConsts ()
			{
			}
		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/interface[@name='WXMediaMessage.IMediaObject']"
		[Register ("com/tencent/mm/sdk/modelmsg/WXMediaMessage$IMediaObject", "", "Com.Tencent.MM.Sdk.Modelmsg.WXMediaMessage/IMediaObjectInvoker")]
		public partial interface IMediaObject : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/interface[@name='WXMediaMessage.IMediaObject']/method[@name='checkArgs' and count(parameter)=0]"
			[Register ("checkArgs", "()Z", "GetCheckArgsHandler:Com.Tencent.MM.Sdk.Modelmsg.WXMediaMessage/IMediaObjectInvoker, WeChartSDK")]
			bool CheckArgs ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/interface[@name='WXMediaMessage.IMediaObject']/method[@name='serialize' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
			[Register ("serialize", "(Landroid/os/Bundle;)V", "GetSerialize_Landroid_os_Bundle_Handler:Com.Tencent.MM.Sdk.Modelmsg.WXMediaMessage/IMediaObjectInvoker, WeChartSDK")]
			void Serialize (global::Android.OS.Bundle p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/interface[@name='WXMediaMessage.IMediaObject']/method[@name='type' and count(parameter)=0]"
			[Register ("type", "()I", "GetTypeHandler:Com.Tencent.MM.Sdk.Modelmsg.WXMediaMessage/IMediaObjectInvoker, WeChartSDK")]
			int Type ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/interface[@name='WXMediaMessage.IMediaObject']/method[@name='unserialize' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
			[Register ("unserialize", "(Landroid/os/Bundle;)V", "GetUnserialize_Landroid_os_Bundle_Handler:Com.Tencent.MM.Sdk.Modelmsg.WXMediaMessage/IMediaObjectInvoker, WeChartSDK")]
			void Unserialize (global::Android.OS.Bundle p0);

		}

		[global::Android.Runtime.Register ("com/tencent/mm/sdk/modelmsg/WXMediaMessage$IMediaObject", DoNotGenerateAcw=true)]
		internal class IMediaObjectInvoker : global::Java.Lang.Object, IMediaObject {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/tencent/mm/sdk/modelmsg/WXMediaMessage$IMediaObject");
			IntPtr class_ref;

			public static IMediaObject GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IMediaObject> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.tencent.mm.sdk.modelmsg.WXMediaMessage.IMediaObject"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IMediaObjectInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IMediaObjectInvoker); }
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
				global::Com.Tencent.MM.Sdk.Modelmsg.WXMediaMessage.IMediaObject __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.MM.Sdk.Modelmsg.WXMediaMessage.IMediaObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.CheckArgs ();
			}
#pragma warning restore 0169

			IntPtr id_checkArgs;
			public bool CheckArgs ()
			{
				if (id_checkArgs == IntPtr.Zero)
					id_checkArgs = JNIEnv.GetMethodID (class_ref, "checkArgs", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_checkArgs);
			}

			static Delegate cb_serialize_Landroid_os_Bundle_;
#pragma warning disable 0169
			static Delegate GetSerialize_Landroid_os_Bundle_Handler ()
			{
				if (cb_serialize_Landroid_os_Bundle_ == null)
					cb_serialize_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Serialize_Landroid_os_Bundle_);
				return cb_serialize_Landroid_os_Bundle_;
			}

			static void n_Serialize_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Tencent.MM.Sdk.Modelmsg.WXMediaMessage.IMediaObject __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.MM.Sdk.Modelmsg.WXMediaMessage.IMediaObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.Serialize (p0);
			}
#pragma warning restore 0169

			IntPtr id_serialize_Landroid_os_Bundle_;
			public void Serialize (global::Android.OS.Bundle p0)
			{
				if (id_serialize_Landroid_os_Bundle_ == IntPtr.Zero)
					id_serialize_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "serialize", "(Landroid/os/Bundle;)V");
				JNIEnv.CallVoidMethod (Handle, id_serialize_Landroid_os_Bundle_, new JValue (p0));
			}

			static Delegate cb_type;
#pragma warning disable 0169
			static Delegate GetTypeHandler ()
			{
				if (cb_type == null)
					cb_type = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Type);
				return cb_type;
			}

			static int n_Type (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Tencent.MM.Sdk.Modelmsg.WXMediaMessage.IMediaObject __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.MM.Sdk.Modelmsg.WXMediaMessage.IMediaObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Type ();
			}
#pragma warning restore 0169

			IntPtr id_type;
			public int Type ()
			{
				if (id_type == IntPtr.Zero)
					id_type = JNIEnv.GetMethodID (class_ref, "type", "()I");
				return JNIEnv.CallIntMethod (Handle, id_type);
			}

			static Delegate cb_unserialize_Landroid_os_Bundle_;
#pragma warning disable 0169
			static Delegate GetUnserialize_Landroid_os_Bundle_Handler ()
			{
				if (cb_unserialize_Landroid_os_Bundle_ == null)
					cb_unserialize_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Unserialize_Landroid_os_Bundle_);
				return cb_unserialize_Landroid_os_Bundle_;
			}

			static void n_Unserialize_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Tencent.MM.Sdk.Modelmsg.WXMediaMessage.IMediaObject __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.MM.Sdk.Modelmsg.WXMediaMessage.IMediaObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.Unserialize (p0);
			}
#pragma warning restore 0169

			IntPtr id_unserialize_Landroid_os_Bundle_;
			public void Unserialize (global::Android.OS.Bundle p0)
			{
				if (id_unserialize_Landroid_os_Bundle_ == IntPtr.Zero)
					id_unserialize_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "unserialize", "(Landroid/os/Bundle;)V");
				JNIEnv.CallVoidMethod (Handle, id_unserialize_Landroid_os_Bundle_, new JValue (p0));
			}

		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/mm/sdk/modelmsg/WXMediaMessage", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (WXMediaMessage); }
		}

		internal WXMediaMessage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/class[@name='WXMediaMessage']/constructor[@name='WXMediaMessage' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public WXMediaMessage () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (WXMediaMessage)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "()V"), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_ctor_Lcom_tencent_mm_sdk_modelmsg_WXMediaMessage_IMediaObject_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/class[@name='WXMediaMessage']/constructor[@name='WXMediaMessage' and count(parameter)=1 and parameter[1][@type='com.tencent.mm.sdk.modelmsg.WXMediaMessage.IMediaObject']]"
		[Register (".ctor", "(Lcom/tencent/mm/sdk/modelmsg/WXMediaMessage$IMediaObject;)V", "")]
		public WXMediaMessage (global::Com.Tencent.MM.Sdk.Modelmsg.WXMediaMessage.IMediaObject p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (WXMediaMessage)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Lcom/tencent/mm/sdk/modelmsg/WXMediaMessage$IMediaObject;)V", new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor_Lcom_tencent_mm_sdk_modelmsg_WXMediaMessage_IMediaObject_ == IntPtr.Zero)
				id_ctor_Lcom_tencent_mm_sdk_modelmsg_WXMediaMessage_IMediaObject_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/tencent/mm/sdk/modelmsg/WXMediaMessage$IMediaObject;)V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Lcom_tencent_mm_sdk_modelmsg_WXMediaMessage_IMediaObject_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_getType;
		public int Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/class[@name='WXMediaMessage']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()I", "GetGetTypeHandler")]
			get {
				if (id_getType == IntPtr.Zero)
					id_getType = JNIEnv.GetMethodID (class_ref, "getType", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_getType);
			}
		}

		static IntPtr id_setThumbImage_Landroid_graphics_Bitmap_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/class[@name='WXMediaMessage']/method[@name='setThumbImage' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
		[Register ("setThumbImage", "(Landroid/graphics/Bitmap;)V", "")]
		public void SetThumbImage (global::Android.Graphics.Bitmap p0)
		{
			if (id_setThumbImage_Landroid_graphics_Bitmap_ == IntPtr.Zero)
				id_setThumbImage_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "setThumbImage", "(Landroid/graphics/Bitmap;)V");
			JNIEnv.CallVoidMethod  (Handle, id_setThumbImage_Landroid_graphics_Bitmap_, new JValue (p0));
		}

	}
}
