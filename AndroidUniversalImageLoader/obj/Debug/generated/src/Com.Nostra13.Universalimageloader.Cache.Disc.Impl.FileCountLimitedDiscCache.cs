using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nostra13.Universalimageloader.Cache.Disc.Impl {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.disc.impl']/class[@name='FileCountLimitedDiscCache']"
	[global::Android.Runtime.Register ("com/nostra13/universalimageloader/cache/disc/impl/FileCountLimitedDiscCache", DoNotGenerateAcw=true)]
	public partial class FileCountLimitedDiscCache : global::Com.Nostra13.Universalimageloader.Cache.Disc.LimitedDiscCache {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/nostra13/universalimageloader/cache/disc/impl/FileCountLimitedDiscCache", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FileCountLimitedDiscCache); }
		}

		protected FileCountLimitedDiscCache (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_io_File_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.disc.impl']/class[@name='FileCountLimitedDiscCache']/constructor[@name='FileCountLimitedDiscCache' and count(parameter)=2 and parameter[1][@type='java.io.File'] and parameter[2][@type='int']]"
		[Register (".ctor", "(Ljava/io/File;I)V", "")]
		public FileCountLimitedDiscCache (global::Java.IO.File p0, int p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (FileCountLimitedDiscCache)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Ljava/io/File;I)V", new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor_Ljava_io_File_I == IntPtr.Zero)
				id_ctor_Ljava_io_File_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/io/File;I)V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Ljava_io_File_I, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_ctor_Ljava_io_File_Lcom_nostra13_universalimageloader_cache_disc_naming_FileNameGenerator_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.disc.impl']/class[@name='FileCountLimitedDiscCache']/constructor[@name='FileCountLimitedDiscCache' and count(parameter)=3 and parameter[1][@type='java.io.File'] and parameter[2][@type='com.nostra13.universalimageloader.cache.disc.naming.FileNameGenerator'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Ljava/io/File;Lcom/nostra13/universalimageloader/cache/disc/naming/FileNameGenerator;I)V", "")]
		public FileCountLimitedDiscCache (global::Java.IO.File p0, global::Com.Nostra13.Universalimageloader.Cache.Disc.Naming.IFileNameGenerator p1, int p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (FileCountLimitedDiscCache)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Ljava/io/File;Lcom/nostra13/universalimageloader/cache/disc/naming/FileNameGenerator;I)V", new JValue (p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor_Ljava_io_File_Lcom_nostra13_universalimageloader_cache_disc_naming_FileNameGenerator_I == IntPtr.Zero)
				id_ctor_Ljava_io_File_Lcom_nostra13_universalimageloader_cache_disc_naming_FileNameGenerator_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/io/File;Lcom/nostra13/universalimageloader/cache/disc/naming/FileNameGenerator;I)V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Ljava_io_File_Lcom_nostra13_universalimageloader_cache_disc_naming_FileNameGenerator_I, new JValue (p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_getSize_Ljava_io_File_;
#pragma warning disable 0169
		static Delegate GetGetSize_Ljava_io_File_Handler ()
		{
			if (cb_getSize_Ljava_io_File_ == null)
				cb_getSize_Ljava_io_File_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_GetSize_Ljava_io_File_);
			return cb_getSize_Ljava_io_File_;
		}

		static int n_GetSize_Ljava_io_File_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nostra13.Universalimageloader.Cache.Disc.Impl.FileCountLimitedDiscCache __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Cache.Disc.Impl.FileCountLimitedDiscCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.File p0 = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetSize (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getSize_Ljava_io_File_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.disc.impl']/class[@name='FileCountLimitedDiscCache']/method[@name='getSize' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("getSize", "(Ljava/io/File;)I", "GetGetSize_Ljava_io_File_Handler")]
		protected override int GetSize (global::Java.IO.File p0)
		{
			if (id_getSize_Ljava_io_File_ == IntPtr.Zero)
				id_getSize_Ljava_io_File_ = JNIEnv.GetMethodID (class_ref, "getSize", "(Ljava/io/File;)I");

			int __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallIntMethod  (Handle, id_getSize_Ljava_io_File_, new JValue (p0));
			else
				__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, id_getSize_Ljava_io_File_, new JValue (p0));
			return __ret;
		}

	}
}
