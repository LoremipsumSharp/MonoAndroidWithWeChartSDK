using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.MM.Sdk.Modelmsg {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/class[@name='WXFileObject']"
	[global::Android.Runtime.Register ("com/tencent/mm/sdk/modelmsg/WXFileObject", DoNotGenerateAcw=true)]
	public partial class WXFileObject : global::Java.Lang.Object, global::Com.Tencent.MM.Sdk.Modelmsg.WXMediaMessage.IMediaObject {


		static IntPtr fileData_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/class[@name='WXFileObject']/field[@name='fileData']"
		[Register ("fileData")]
		public IList<byte> FileData {
			get {
				if (fileData_jfieldId == IntPtr.Zero)
					fileData_jfieldId = JNIEnv.GetFieldID (class_ref, "fileData", "[B");
				return JavaArray<byte>.FromJniHandle (JNIEnv.GetObjectField (Handle, fileData_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (fileData_jfieldId == IntPtr.Zero)
					fileData_jfieldId = JNIEnv.GetFieldID (class_ref, "fileData", "[B");
				IntPtr native_value = JavaArray<byte>.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, fileData_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr filePath_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/class[@name='WXFileObject']/field[@name='filePath']"
		[Register ("filePath")]
		public string FilePath {
			get {
				if (filePath_jfieldId == IntPtr.Zero)
					filePath_jfieldId = JNIEnv.GetFieldID (class_ref, "filePath", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, filePath_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (filePath_jfieldId == IntPtr.Zero)
					filePath_jfieldId = JNIEnv.GetFieldID (class_ref, "filePath", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.SetField (Handle, filePath_jfieldId, native_value);
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
				return JNIEnv.FindClass ("com/tencent/mm/sdk/modelmsg/WXFileObject", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (WXFileObject); }
		}

		protected WXFileObject (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/class[@name='WXFileObject']/constructor[@name='WXFileObject' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public WXFileObject () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (WXFileObject)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "()V"), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/class[@name='WXFileObject']/constructor[@name='WXFileObject' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public WXFileObject (string p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);;
			if (GetType () != typeof (WXFileObject)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Ljava/lang/String;)V", new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return;
			}

			if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
				id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_ctor_arrayB;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/class[@name='WXFileObject']/constructor[@name='WXFileObject' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register (".ctor", "([B)V", "")]
		public WXFileObject (byte[] p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewArray (p0);;
			if (GetType () != typeof (WXFileObject)) {
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
			global::Com.Tencent.MM.Sdk.Modelmsg.WXFileObject __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.MM.Sdk.Modelmsg.WXFileObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CheckArgs ();
		}
#pragma warning restore 0169

		static IntPtr id_checkArgs;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/class[@name='WXFileObject']/method[@name='checkArgs' and count(parameter)=0]"
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
			global::Com.Tencent.MM.Sdk.Modelmsg.WXFileObject __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.MM.Sdk.Modelmsg.WXFileObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Serialize (p0);
		}
#pragma warning restore 0169

		static IntPtr id_serialize_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/class[@name='WXFileObject']/method[@name='serialize' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
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

		static Delegate cb_setContentLengthLimit_I;
#pragma warning disable 0169
		static Delegate GetSetContentLengthLimit_IHandler ()
		{
			if (cb_setContentLengthLimit_I == null)
				cb_setContentLengthLimit_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetContentLengthLimit_I);
			return cb_setContentLengthLimit_I;
		}

		static void n_SetContentLengthLimit_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Tencent.MM.Sdk.Modelmsg.WXFileObject __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.MM.Sdk.Modelmsg.WXFileObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetContentLengthLimit (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setContentLengthLimit_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/class[@name='WXFileObject']/method[@name='setContentLengthLimit' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setContentLengthLimit", "(I)V", "GetSetContentLengthLimit_IHandler")]
		public virtual void SetContentLengthLimit (int p0)
		{
			if (id_setContentLengthLimit_I == IntPtr.Zero)
				id_setContentLengthLimit_I = JNIEnv.GetMethodID (class_ref, "setContentLengthLimit", "(I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setContentLengthLimit_I, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setContentLengthLimit_I, new JValue (p0));
		}

		static Delegate cb_setFileData_arrayB;
#pragma warning disable 0169
		static Delegate GetSetFileData_arrayBHandler ()
		{
			if (cb_setFileData_arrayB == null)
				cb_setFileData_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetFileData_arrayB);
			return cb_setFileData_arrayB;
		}

		static void n_SetFileData_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.MM.Sdk.Modelmsg.WXFileObject __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.MM.Sdk.Modelmsg.WXFileObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.SetFileData (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_setFileData_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/class[@name='WXFileObject']/method[@name='setFileData' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("setFileData", "([B)V", "GetSetFileData_arrayBHandler")]
		public virtual void SetFileData (byte[] p0)
		{
			if (id_setFileData_arrayB == IntPtr.Zero)
				id_setFileData_arrayB = JNIEnv.GetMethodID (class_ref, "setFileData", "([B)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setFileData_arrayB, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setFileData_arrayB, new JValue (native_p0));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setFilePath_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetFilePath_Ljava_lang_String_Handler ()
		{
			if (cb_setFilePath_Ljava_lang_String_ == null)
				cb_setFilePath_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetFilePath_Ljava_lang_String_);
			return cb_setFilePath_Ljava_lang_String_;
		}

		static void n_SetFilePath_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.MM.Sdk.Modelmsg.WXFileObject __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.MM.Sdk.Modelmsg.WXFileObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetFilePath (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setFilePath_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/class[@name='WXFileObject']/method[@name='setFilePath' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setFilePath", "(Ljava/lang/String;)V", "GetSetFilePath_Ljava_lang_String_Handler")]
		public virtual void SetFilePath (string p0)
		{
			if (id_setFilePath_Ljava_lang_String_ == IntPtr.Zero)
				id_setFilePath_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setFilePath", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setFilePath_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setFilePath_Ljava_lang_String_, new JValue (native_p0));
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
			global::Com.Tencent.MM.Sdk.Modelmsg.WXFileObject __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.MM.Sdk.Modelmsg.WXFileObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Type ();
		}
#pragma warning restore 0169

		static IntPtr id_type;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/class[@name='WXFileObject']/method[@name='type' and count(parameter)=0]"
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
			global::Com.Tencent.MM.Sdk.Modelmsg.WXFileObject __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.MM.Sdk.Modelmsg.WXFileObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Unserialize (p0);
		}
#pragma warning restore 0169

		static IntPtr id_unserialize_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mm.sdk.modelmsg']/class[@name='WXFileObject']/method[@name='unserialize' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
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
