using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nostra13.Universalimageloader.Cache.Disc {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.disc']/interface[@name='DiscCacheAware']"
	[Register ("com/nostra13/universalimageloader/cache/disc/DiscCacheAware", "", "Com.Nostra13.Universalimageloader.Cache.Disc.IDiscCacheAwareInvoker")]
	public partial interface IDiscCacheAware : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.disc']/interface[@name='DiscCacheAware']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "GetClearHandler:Com.Nostra13.Universalimageloader.Cache.Disc.IDiscCacheAwareInvoker, AndroidUniversalImageLoader")]
		void Clear ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.disc']/interface[@name='DiscCacheAware']/method[@name='get' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("get", "(Ljava/lang/String;)Ljava/io/File;", "GetGet_Ljava_lang_String_Handler:Com.Nostra13.Universalimageloader.Cache.Disc.IDiscCacheAwareInvoker, AndroidUniversalImageLoader")]
		global::Java.IO.File Get (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.disc']/interface[@name='DiscCacheAware']/method[@name='put' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.io.File']]"
		[Register ("put", "(Ljava/lang/String;Ljava/io/File;)V", "GetPut_Ljava_lang_String_Ljava_io_File_Handler:Com.Nostra13.Universalimageloader.Cache.Disc.IDiscCacheAwareInvoker, AndroidUniversalImageLoader")]
		void Put (string p0, global::Java.IO.File p1);

	}

	[global::Android.Runtime.Register ("com/nostra13/universalimageloader/cache/disc/DiscCacheAware", DoNotGenerateAcw=true)]
	internal class IDiscCacheAwareInvoker : global::Java.Lang.Object, IDiscCacheAware {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/nostra13/universalimageloader/cache/disc/DiscCacheAware");
		IntPtr class_ref;

		public static IDiscCacheAware GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDiscCacheAware> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.nostra13.universalimageloader.cache.disc.DiscCacheAware"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDiscCacheAwareInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IDiscCacheAwareInvoker); }
		}

		static Delegate cb_clear;
#pragma warning disable 0169
		static Delegate GetClearHandler ()
		{
			if (cb_clear == null)
				cb_clear = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Clear);
			return cb_clear;
		}

		static void n_Clear (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nostra13.Universalimageloader.Cache.Disc.IDiscCacheAware __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Cache.Disc.IDiscCacheAware> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		IntPtr id_clear;
		public void Clear ()
		{
			if (id_clear == IntPtr.Zero)
				id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()V");
			JNIEnv.CallVoidMethod (Handle, id_clear);
		}

		static Delegate cb_get_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGet_Ljava_lang_String_Handler ()
		{
			if (cb_get_Ljava_lang_String_ == null)
				cb_get_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Get_Ljava_lang_String_);
			return cb_get_Ljava_lang_String_;
		}

		static IntPtr n_Get_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nostra13.Universalimageloader.Cache.Disc.IDiscCacheAware __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Cache.Disc.IDiscCacheAware> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Get (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_get_Ljava_lang_String_;
		public global::Java.IO.File Get (string p0)
		{
			if (id_get_Ljava_lang_String_ == IntPtr.Zero)
				id_get_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "get", "(Ljava/lang/String;)Ljava/io/File;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Java.IO.File __ret = global::Java.Lang.Object.GetObject<global::Java.IO.File> (JNIEnv.CallObjectMethod (Handle, id_get_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_put_Ljava_lang_String_Ljava_io_File_;
#pragma warning disable 0169
		static Delegate GetPut_Ljava_lang_String_Ljava_io_File_Handler ()
		{
			if (cb_put_Ljava_lang_String_Ljava_io_File_ == null)
				cb_put_Ljava_lang_String_Ljava_io_File_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Put_Ljava_lang_String_Ljava_io_File_);
			return cb_put_Ljava_lang_String_Ljava_io_File_;
		}

		static void n_Put_Ljava_lang_String_Ljava_io_File_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Nostra13.Universalimageloader.Cache.Disc.IDiscCacheAware __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Cache.Disc.IDiscCacheAware> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.File p1 = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Put (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_put_Ljava_lang_String_Ljava_io_File_;
		public void Put (string p0, global::Java.IO.File p1)
		{
			if (id_put_Ljava_lang_String_Ljava_io_File_ == IntPtr.Zero)
				id_put_Ljava_lang_String_Ljava_io_File_ = JNIEnv.GetMethodID (class_ref, "put", "(Ljava/lang/String;Ljava/io/File;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallVoidMethod (Handle, id_put_Ljava_lang_String_Ljava_io_File_, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

}
