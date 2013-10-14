using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nostra13.Universalimageloader.Core.Download {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nostra13.universalimageloader.core.download']/class[@name='BaseImageDownloader']"
	[global::Android.Runtime.Register ("com/nostra13/universalimageloader/core/download/BaseImageDownloader", DoNotGenerateAcw=true)]
	public partial class BaseImageDownloader : global::Java.Lang.Object, global::Com.Nostra13.Universalimageloader.Core.Download.IImageDownloader {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.nostra13.universalimageloader.core.download']/class[@name='BaseImageDownloader']/field[@name='ALLOWED_URI_CHARS']"
		[Register ("ALLOWED_URI_CHARS")]
		protected const string AllowedUriChars = (string) "@#&=*+-_.,:!?()/~'%";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.nostra13.universalimageloader.core.download']/class[@name='BaseImageDownloader']/field[@name='BUFFER_SIZE']"
		[Register ("BUFFER_SIZE")]
		protected const int BufferSize = (int) 8192;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.nostra13.universalimageloader.core.download']/class[@name='BaseImageDownloader']/field[@name='DEFAULT_HTTP_CONNECT_TIMEOUT']"
		[Register ("DEFAULT_HTTP_CONNECT_TIMEOUT")]
		public const int DefaultHttpConnectTimeout = (int) 5000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.nostra13.universalimageloader.core.download']/class[@name='BaseImageDownloader']/field[@name='DEFAULT_HTTP_READ_TIMEOUT']"
		[Register ("DEFAULT_HTTP_READ_TIMEOUT")]
		public const int DefaultHttpReadTimeout = (int) 20000;

		static IntPtr connectTimeout_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.nostra13.universalimageloader.core.download']/class[@name='BaseImageDownloader']/field[@name='connectTimeout']"
		[Register ("connectTimeout")]
		protected int ConnectTimeout {
			get {
				if (connectTimeout_jfieldId == IntPtr.Zero)
					connectTimeout_jfieldId = JNIEnv.GetFieldID (class_ref, "connectTimeout", "I");
				return JNIEnv.GetIntField (Handle, connectTimeout_jfieldId);
			}
			set {
				if (connectTimeout_jfieldId == IntPtr.Zero)
					connectTimeout_jfieldId = JNIEnv.GetFieldID (class_ref, "connectTimeout", "I");
				JNIEnv.SetField (Handle, connectTimeout_jfieldId, value);
			}
		}

		static IntPtr context_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.nostra13.universalimageloader.core.download']/class[@name='BaseImageDownloader']/field[@name='context']"
		[Register ("context")]
		protected global::Android.Content.Context Context {
			get {
				if (context_jfieldId == IntPtr.Zero)
					context_jfieldId = JNIEnv.GetFieldID (class_ref, "context", "Landroid/content/Context;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, context_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (context_jfieldId == IntPtr.Zero)
					context_jfieldId = JNIEnv.GetFieldID (class_ref, "context", "Landroid/content/Context;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, context_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr readTimeout_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.nostra13.universalimageloader.core.download']/class[@name='BaseImageDownloader']/field[@name='readTimeout']"
		[Register ("readTimeout")]
		protected int ReadTimeout {
			get {
				if (readTimeout_jfieldId == IntPtr.Zero)
					readTimeout_jfieldId = JNIEnv.GetFieldID (class_ref, "readTimeout", "I");
				return JNIEnv.GetIntField (Handle, readTimeout_jfieldId);
			}
			set {
				if (readTimeout_jfieldId == IntPtr.Zero)
					readTimeout_jfieldId = JNIEnv.GetFieldID (class_ref, "readTimeout", "I");
				JNIEnv.SetField (Handle, readTimeout_jfieldId, value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/nostra13/universalimageloader/core/download/BaseImageDownloader", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseImageDownloader); }
		}

		protected BaseImageDownloader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_II;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nostra13.universalimageloader.core.download']/class[@name='BaseImageDownloader']/constructor[@name='BaseImageDownloader' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;II)V", "")]
		public BaseImageDownloader (global::Android.Content.Context p0, int p1, int p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (BaseImageDownloader)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Landroid/content/Context;II)V", new JValue (p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor_Landroid_content_Context_II == IntPtr.Zero)
				id_ctor_Landroid_content_Context_II = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;II)V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Landroid_content_Context_II, new JValue (p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nostra13.universalimageloader.core.download']/class[@name='BaseImageDownloader']/constructor[@name='BaseImageDownloader' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public BaseImageDownloader (global::Android.Content.Context p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (BaseImageDownloader)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Landroid/content/Context;)V", new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_getStream_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetGetStream_Ljava_lang_String_Ljava_lang_Object_Handler ()
		{
			if (cb_getStream_Ljava_lang_String_Ljava_lang_Object_ == null)
				cb_getStream_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetStream_Ljava_lang_String_Ljava_lang_Object_);
			return cb_getStream_Ljava_lang_String_Ljava_lang_Object_;
		}

		static IntPtr n_GetStream_Ljava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Nostra13.Universalimageloader.Core.Download.BaseImageDownloader __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Download.BaseImageDownloader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (__this.GetStream (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getStream_Ljava_lang_String_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.download']/class[@name='BaseImageDownloader']/method[@name='getStream' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
		[Register ("getStream", "(Ljava/lang/String;Ljava/lang/Object;)Ljava/io/InputStream;", "GetGetStream_Ljava_lang_String_Ljava_lang_Object_Handler")]
		public virtual global::System.IO.Stream GetStream (string p0, global::Java.Lang.Object p1)
		{
			if (id_getStream_Ljava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
				id_getStream_Ljava_lang_String_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "getStream", "(Ljava/lang/String;Ljava/lang/Object;)Ljava/io/InputStream;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::System.IO.Stream __ret;
			if (GetType () == ThresholdType)
				__ret = global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getStream_Ljava_lang_String_Ljava_lang_Object_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getStream_Ljava_lang_String_Ljava_lang_Object_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getStreamFromAssets_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetGetStreamFromAssets_Ljava_lang_String_Ljava_lang_Object_Handler ()
		{
			if (cb_getStreamFromAssets_Ljava_lang_String_Ljava_lang_Object_ == null)
				cb_getStreamFromAssets_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetStreamFromAssets_Ljava_lang_String_Ljava_lang_Object_);
			return cb_getStreamFromAssets_Ljava_lang_String_Ljava_lang_Object_;
		}

		static IntPtr n_GetStreamFromAssets_Ljava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Nostra13.Universalimageloader.Core.Download.BaseImageDownloader __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Download.BaseImageDownloader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (__this.GetStreamFromAssets (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getStreamFromAssets_Ljava_lang_String_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.download']/class[@name='BaseImageDownloader']/method[@name='getStreamFromAssets' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
		[Register ("getStreamFromAssets", "(Ljava/lang/String;Ljava/lang/Object;)Ljava/io/InputStream;", "GetGetStreamFromAssets_Ljava_lang_String_Ljava_lang_Object_Handler")]
		protected virtual global::System.IO.Stream GetStreamFromAssets (string p0, global::Java.Lang.Object p1)
		{
			if (id_getStreamFromAssets_Ljava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
				id_getStreamFromAssets_Ljava_lang_String_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "getStreamFromAssets", "(Ljava/lang/String;Ljava/lang/Object;)Ljava/io/InputStream;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::System.IO.Stream __ret;
			if (GetType () == ThresholdType)
				__ret = global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getStreamFromAssets_Ljava_lang_String_Ljava_lang_Object_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getStreamFromAssets_Ljava_lang_String_Ljava_lang_Object_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getStreamFromContent_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetGetStreamFromContent_Ljava_lang_String_Ljava_lang_Object_Handler ()
		{
			if (cb_getStreamFromContent_Ljava_lang_String_Ljava_lang_Object_ == null)
				cb_getStreamFromContent_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetStreamFromContent_Ljava_lang_String_Ljava_lang_Object_);
			return cb_getStreamFromContent_Ljava_lang_String_Ljava_lang_Object_;
		}

		static IntPtr n_GetStreamFromContent_Ljava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Nostra13.Universalimageloader.Core.Download.BaseImageDownloader __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Download.BaseImageDownloader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (__this.GetStreamFromContent (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getStreamFromContent_Ljava_lang_String_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.download']/class[@name='BaseImageDownloader']/method[@name='getStreamFromContent' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
		[Register ("getStreamFromContent", "(Ljava/lang/String;Ljava/lang/Object;)Ljava/io/InputStream;", "GetGetStreamFromContent_Ljava_lang_String_Ljava_lang_Object_Handler")]
		protected virtual global::System.IO.Stream GetStreamFromContent (string p0, global::Java.Lang.Object p1)
		{
			if (id_getStreamFromContent_Ljava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
				id_getStreamFromContent_Ljava_lang_String_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "getStreamFromContent", "(Ljava/lang/String;Ljava/lang/Object;)Ljava/io/InputStream;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::System.IO.Stream __ret;
			if (GetType () == ThresholdType)
				__ret = global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getStreamFromContent_Ljava_lang_String_Ljava_lang_Object_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getStreamFromContent_Ljava_lang_String_Ljava_lang_Object_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getStreamFromDrawable_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetGetStreamFromDrawable_Ljava_lang_String_Ljava_lang_Object_Handler ()
		{
			if (cb_getStreamFromDrawable_Ljava_lang_String_Ljava_lang_Object_ == null)
				cb_getStreamFromDrawable_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetStreamFromDrawable_Ljava_lang_String_Ljava_lang_Object_);
			return cb_getStreamFromDrawable_Ljava_lang_String_Ljava_lang_Object_;
		}

		static IntPtr n_GetStreamFromDrawable_Ljava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Nostra13.Universalimageloader.Core.Download.BaseImageDownloader __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Download.BaseImageDownloader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (__this.GetStreamFromDrawable (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getStreamFromDrawable_Ljava_lang_String_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.download']/class[@name='BaseImageDownloader']/method[@name='getStreamFromDrawable' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
		[Register ("getStreamFromDrawable", "(Ljava/lang/String;Ljava/lang/Object;)Ljava/io/InputStream;", "GetGetStreamFromDrawable_Ljava_lang_String_Ljava_lang_Object_Handler")]
		protected virtual global::System.IO.Stream GetStreamFromDrawable (string p0, global::Java.Lang.Object p1)
		{
			if (id_getStreamFromDrawable_Ljava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
				id_getStreamFromDrawable_Ljava_lang_String_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "getStreamFromDrawable", "(Ljava/lang/String;Ljava/lang/Object;)Ljava/io/InputStream;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::System.IO.Stream __ret;
			if (GetType () == ThresholdType)
				__ret = global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getStreamFromDrawable_Ljava_lang_String_Ljava_lang_Object_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getStreamFromDrawable_Ljava_lang_String_Ljava_lang_Object_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getStreamFromFile_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetGetStreamFromFile_Ljava_lang_String_Ljava_lang_Object_Handler ()
		{
			if (cb_getStreamFromFile_Ljava_lang_String_Ljava_lang_Object_ == null)
				cb_getStreamFromFile_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetStreamFromFile_Ljava_lang_String_Ljava_lang_Object_);
			return cb_getStreamFromFile_Ljava_lang_String_Ljava_lang_Object_;
		}

		static IntPtr n_GetStreamFromFile_Ljava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Nostra13.Universalimageloader.Core.Download.BaseImageDownloader __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Download.BaseImageDownloader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (__this.GetStreamFromFile (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getStreamFromFile_Ljava_lang_String_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.download']/class[@name='BaseImageDownloader']/method[@name='getStreamFromFile' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
		[Register ("getStreamFromFile", "(Ljava/lang/String;Ljava/lang/Object;)Ljava/io/InputStream;", "GetGetStreamFromFile_Ljava_lang_String_Ljava_lang_Object_Handler")]
		protected virtual global::System.IO.Stream GetStreamFromFile (string p0, global::Java.Lang.Object p1)
		{
			if (id_getStreamFromFile_Ljava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
				id_getStreamFromFile_Ljava_lang_String_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "getStreamFromFile", "(Ljava/lang/String;Ljava/lang/Object;)Ljava/io/InputStream;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::System.IO.Stream __ret;
			if (GetType () == ThresholdType)
				__ret = global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getStreamFromFile_Ljava_lang_String_Ljava_lang_Object_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getStreamFromFile_Ljava_lang_String_Ljava_lang_Object_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getStreamFromNetwork_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetGetStreamFromNetwork_Ljava_lang_String_Ljava_lang_Object_Handler ()
		{
			if (cb_getStreamFromNetwork_Ljava_lang_String_Ljava_lang_Object_ == null)
				cb_getStreamFromNetwork_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetStreamFromNetwork_Ljava_lang_String_Ljava_lang_Object_);
			return cb_getStreamFromNetwork_Ljava_lang_String_Ljava_lang_Object_;
		}

		static IntPtr n_GetStreamFromNetwork_Ljava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Nostra13.Universalimageloader.Core.Download.BaseImageDownloader __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Download.BaseImageDownloader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (__this.GetStreamFromNetwork (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getStreamFromNetwork_Ljava_lang_String_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.download']/class[@name='BaseImageDownloader']/method[@name='getStreamFromNetwork' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
		[Register ("getStreamFromNetwork", "(Ljava/lang/String;Ljava/lang/Object;)Ljava/io/InputStream;", "GetGetStreamFromNetwork_Ljava_lang_String_Ljava_lang_Object_Handler")]
		protected virtual global::System.IO.Stream GetStreamFromNetwork (string p0, global::Java.Lang.Object p1)
		{
			if (id_getStreamFromNetwork_Ljava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
				id_getStreamFromNetwork_Ljava_lang_String_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "getStreamFromNetwork", "(Ljava/lang/String;Ljava/lang/Object;)Ljava/io/InputStream;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::System.IO.Stream __ret;
			if (GetType () == ThresholdType)
				__ret = global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getStreamFromNetwork_Ljava_lang_String_Ljava_lang_Object_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getStreamFromNetwork_Ljava_lang_String_Ljava_lang_Object_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getStreamFromOtherSource_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetGetStreamFromOtherSource_Ljava_lang_String_Ljava_lang_Object_Handler ()
		{
			if (cb_getStreamFromOtherSource_Ljava_lang_String_Ljava_lang_Object_ == null)
				cb_getStreamFromOtherSource_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetStreamFromOtherSource_Ljava_lang_String_Ljava_lang_Object_);
			return cb_getStreamFromOtherSource_Ljava_lang_String_Ljava_lang_Object_;
		}

		static IntPtr n_GetStreamFromOtherSource_Ljava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Nostra13.Universalimageloader.Core.Download.BaseImageDownloader __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Download.BaseImageDownloader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (__this.GetStreamFromOtherSource (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getStreamFromOtherSource_Ljava_lang_String_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.download']/class[@name='BaseImageDownloader']/method[@name='getStreamFromOtherSource' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
		[Register ("getStreamFromOtherSource", "(Ljava/lang/String;Ljava/lang/Object;)Ljava/io/InputStream;", "GetGetStreamFromOtherSource_Ljava_lang_String_Ljava_lang_Object_Handler")]
		protected virtual global::System.IO.Stream GetStreamFromOtherSource (string p0, global::Java.Lang.Object p1)
		{
			if (id_getStreamFromOtherSource_Ljava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
				id_getStreamFromOtherSource_Ljava_lang_String_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "getStreamFromOtherSource", "(Ljava/lang/String;Ljava/lang/Object;)Ljava/io/InputStream;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::System.IO.Stream __ret;
			if (GetType () == ThresholdType)
				__ret = global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getStreamFromOtherSource_Ljava_lang_String_Ljava_lang_Object_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getStreamFromOtherSource_Ljava_lang_String_Ljava_lang_Object_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}
}
