using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.MM.Sdk.Modelmsg {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/class[@name='WXImageObject']"
	[global::Android.Runtime.Register ("com/tencent/mm/sdk/modelmsg/WXImageObject", DoNotGenerateAcw=true)]
	public partial class WXImageObject : global::Java.Lang.Object, global::Com.Tencent.MM.Sdk.Modelmsg.WXMediaMessage.IMediaObject {


		static IntPtr imageData_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/class[@name='WXImageObject']/field[@name='imageData']"
		[Register ("imageData")]
		public IList<byte> ImageData {
			get {
				if (imageData_jfieldId == IntPtr.Zero)
					imageData_jfieldId = JNIEnv.GetFieldID (class_ref, "imageData", "[B");
				return JavaArray<byte>.FromJniHandle (JNIEnv.GetObjectField (Handle, imageData_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (imageData_jfieldId == IntPtr.Zero)
					imageData_jfieldId = JNIEnv.GetFieldID (class_ref, "imageData", "[B");
				IntPtr native_value = JavaArray<byte>.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, imageData_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr imagePath_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/class[@name='WXImageObject']/field[@name='imagePath']"
		[Register ("imagePath")]
		public string ImagePath {
			get {
				if (imagePath_jfieldId == IntPtr.Zero)
					imagePath_jfieldId = JNIEnv.GetFieldID (class_ref, "imagePath", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, imagePath_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (imagePath_jfieldId == IntPtr.Zero)
					imagePath_jfieldId = JNIEnv.GetFieldID (class_ref, "imagePath", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.SetField (Handle, imagePath_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr imageUrl_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/class[@name='WXImageObject']/field[@name='imageUrl']"
		[Register ("imageUrl")]
		public string ImageUrl {
			get {
				if (imageUrl_jfieldId == IntPtr.Zero)
					imageUrl_jfieldId = JNIEnv.GetFieldID (class_ref, "imageUrl", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, imageUrl_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (imageUrl_jfieldId == IntPtr.Zero)
					imageUrl_jfieldId = JNIEnv.GetFieldID (class_ref, "imageUrl", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.SetField (Handle, imageUrl_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		public static class InterfaceConsts {

			// The following are fields from: com.tencent.mm.sdk.modelmsg.WXMediaMessage.IMediaObject

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

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/mm/sdk/modelmsg/WXImageObject", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (WXImageObject); }
		}

		protected WXImageObject (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/class[@name='WXImageObject']/constructor[@name='WXImageObject' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public WXImageObject () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (WXImageObject)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "()V"), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_ctor_Landroid_graphics_Bitmap_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/class[@name='WXImageObject']/constructor[@name='WXImageObject' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
		[Register (".ctor", "(Landroid/graphics/Bitmap;)V", "")]
		public WXImageObject (global::Android.Graphics.Bitmap p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (WXImageObject)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Landroid/graphics/Bitmap;)V", new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor_Landroid_graphics_Bitmap_ == IntPtr.Zero)
				id_ctor_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/graphics/Bitmap;)V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Landroid_graphics_Bitmap_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_ctor_arrayB;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/class[@name='WXImageObject']/constructor[@name='WXImageObject' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register (".ctor", "([B)V", "")]
		public WXImageObject (byte[] p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewArray (p0);;
			if (GetType () != typeof (WXImageObject)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "([B)V", new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				return;
			}

			if (id_ctor_arrayB == IntPtr.Zero)
				id_ctor_arrayB = JNIEnv.GetMethodID (class_ref, "<init>", "([B)V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor_arrayB, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
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
			global::Com.Tencent.MM.Sdk.Modelmsg.WXImageObject __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.MM.Sdk.Modelmsg.WXImageObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CheckArgs ();
		}
#pragma warning restore 0169

		static IntPtr id_checkArgs;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/class[@name='WXImageObject']/method[@name='checkArgs' and count(parameter)=0]"
		[Register ("checkArgs", "()Z", "GetCheckArgsHandler")]
		public virtual bool CheckArgs ()
		{
			if (id_checkArgs == IntPtr.Zero)
				id_checkArgs = JNIEnv.GetMethodID (class_ref, "checkArgs", "()Z");

			if (GetType () == ThresholdType)
				return JNIEnv.CallBooleanMethod  (Handle, id_checkArgs);
			else
				return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_checkArgs);
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
			global::Com.Tencent.MM.Sdk.Modelmsg.WXImageObject __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.MM.Sdk.Modelmsg.WXImageObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Serialize (p0);
		}
#pragma warning restore 0169

		static IntPtr id_serialize_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/class[@name='WXImageObject']/method[@name='serialize' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("serialize", "(Landroid/os/Bundle;)V", "GetSerialize_Landroid_os_Bundle_Handler")]
		public virtual void Serialize (global::Android.OS.Bundle p0)
		{
			if (id_serialize_Landroid_os_Bundle_ == IntPtr.Zero)
				id_serialize_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "serialize", "(Landroid/os/Bundle;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_serialize_Landroid_os_Bundle_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_serialize_Landroid_os_Bundle_, new JValue (p0));
		}

		static Delegate cb_setImagePath_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetImagePath_Ljava_lang_String_Handler ()
		{
			if (cb_setImagePath_Ljava_lang_String_ == null)
				cb_setImagePath_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetImagePath_Ljava_lang_String_);
			return cb_setImagePath_Ljava_lang_String_;
		}

		static void n_SetImagePath_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.MM.Sdk.Modelmsg.WXImageObject __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.MM.Sdk.Modelmsg.WXImageObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetImagePath (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setImagePath_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/class[@name='WXImageObject']/method[@name='setImagePath' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setImagePath", "(Ljava/lang/String;)V", "GetSetImagePath_Ljava_lang_String_Handler")]
		public virtual void SetImagePath (string p0)
		{
			if (id_setImagePath_Ljava_lang_String_ == IntPtr.Zero)
				id_setImagePath_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setImagePath", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setImagePath_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setImagePath_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
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
			global::Com.Tencent.MM.Sdk.Modelmsg.WXImageObject __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.MM.Sdk.Modelmsg.WXImageObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Type ();
		}
#pragma warning restore 0169

		static IntPtr id_type;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/class[@name='WXImageObject']/method[@name='type' and count(parameter)=0]"
		[Register ("type", "()I", "GetTypeHandler")]
		public virtual int Type ()
		{
			if (id_type == IntPtr.Zero)
				id_type = JNIEnv.GetMethodID (class_ref, "type", "()I");

			if (GetType () == ThresholdType)
				return JNIEnv.CallIntMethod  (Handle, id_type);
			else
				return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, id_type);
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
			global::Com.Tencent.MM.Sdk.Modelmsg.WXImageObject __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.MM.Sdk.Modelmsg.WXImageObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Unserialize (p0);
		}
#pragma warning restore 0169

		static IntPtr id_unserialize_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/class[@name='WXImageObject']/method[@name='unserialize' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("unserialize", "(Landroid/os/Bundle;)V", "GetUnserialize_Landroid_os_Bundle_Handler")]
		public virtual void Unserialize (global::Android.OS.Bundle p0)
		{
			if (id_unserialize_Landroid_os_Bundle_ == IntPtr.Zero)
				id_unserialize_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "unserialize", "(Landroid/os/Bundle;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_unserialize_Landroid_os_Bundle_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_unserialize_Landroid_os_Bundle_, new JValue (p0));
		}

	}
}
