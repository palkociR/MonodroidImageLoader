using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nostra13.Universalimageloader.Cache.Disc.Impl {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.disc.impl']/class[@name='UnlimitedDiscCache']"
	[global::Android.Runtime.Register ("com/nostra13/universalimageloader/cache/disc/impl/UnlimitedDiscCache", DoNotGenerateAcw=true)]
	public partial class UnlimitedDiscCache : global::Com.Nostra13.Universalimageloader.Cache.Disc.BaseDiscCache {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/nostra13/universalimageloader/cache/disc/impl/UnlimitedDiscCache", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UnlimitedDiscCache); }
		}

		protected UnlimitedDiscCache (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_io_File_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.disc.impl']/class[@name='UnlimitedDiscCache']/constructor[@name='UnlimitedDiscCache' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register (".ctor", "(Ljava/io/File;)V", "")]
		public UnlimitedDiscCache (global::Java.IO.File p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (UnlimitedDiscCache)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Ljava/io/File;)V", new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor_Ljava_io_File_ == IntPtr.Zero)
				id_ctor_Ljava_io_File_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/io/File;)V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Ljava_io_File_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_ctor_Ljava_io_File_Lcom_nostra13_universalimageloader_cache_disc_naming_FileNameGenerator_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.disc.impl']/class[@name='UnlimitedDiscCache']/constructor[@name='UnlimitedDiscCache' and count(parameter)=2 and parameter[1][@type='java.io.File'] and parameter[2][@type='com.nostra13.universalimageloader.cache.disc.naming.FileNameGenerator']]"
		[Register (".ctor", "(Ljava/io/File;Lcom/nostra13/universalimageloader/cache/disc/naming/FileNameGenerator;)V", "")]
		public UnlimitedDiscCache (global::Java.IO.File p0, global::Com.Nostra13.Universalimageloader.Cache.Disc.Naming.IFileNameGenerator p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (UnlimitedDiscCache)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Ljava/io/File;Lcom/nostra13/universalimageloader/cache/disc/naming/FileNameGenerator;)V", new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor_Ljava_io_File_Lcom_nostra13_universalimageloader_cache_disc_naming_FileNameGenerator_ == IntPtr.Zero)
				id_ctor_Ljava_io_File_Lcom_nostra13_universalimageloader_cache_disc_naming_FileNameGenerator_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/io/File;Lcom/nostra13/universalimageloader/cache/disc/naming/FileNameGenerator;)V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Ljava_io_File_Lcom_nostra13_universalimageloader_cache_disc_naming_FileNameGenerator_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Nostra13.Universalimageloader.Cache.Disc.Impl.UnlimitedDiscCache __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Cache.Disc.Impl.UnlimitedDiscCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.File p1 = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Put (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_put_Ljava_lang_String_Ljava_io_File_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.disc.impl']/class[@name='UnlimitedDiscCache']/method[@name='put' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.io.File']]"
		[Register ("put", "(Ljava/lang/String;Ljava/io/File;)V", "GetPut_Ljava_lang_String_Ljava_io_File_Handler")]
		public override void Put (string p0, global::Java.IO.File p1)
		{
			if (id_put_Ljava_lang_String_Ljava_io_File_ == IntPtr.Zero)
				id_put_Ljava_lang_String_Ljava_io_File_ = JNIEnv.GetMethodID (class_ref, "put", "(Ljava/lang/String;Ljava/io/File;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_put_Ljava_lang_String_Ljava_io_File_, new JValue (native_p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_put_Ljava_lang_String_Ljava_io_File_, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}
}
