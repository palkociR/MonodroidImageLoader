using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nostra13.Universalimageloader.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='DefaultConfigurationFactory']"
	[global::Android.Runtime.Register ("com/nostra13/universalimageloader/core/DefaultConfigurationFactory", DoNotGenerateAcw=true)]
	public partial class DefaultConfigurationFactory : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='DefaultConfigurationFactory.DefaultThreadFactory']"
		[global::Android.Runtime.Register ("com/nostra13/universalimageloader/core/DefaultConfigurationFactory$DefaultThreadFactory", DoNotGenerateAcw=true)]
		public partial class DefaultThreadFactory : global::Java.Lang.Object, global::Java.Util.Concurrent.IThreadFactory {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/nostra13/universalimageloader/core/DefaultConfigurationFactory$DefaultThreadFactory", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (DefaultThreadFactory); }
			}

			protected DefaultThreadFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_newThread_Ljava_lang_Runnable_;
#pragma warning disable 0169
			static Delegate GetNewThread_Ljava_lang_Runnable_Handler ()
			{
				if (cb_newThread_Ljava_lang_Runnable_ == null)
					cb_newThread_Ljava_lang_Runnable_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_NewThread_Ljava_lang_Runnable_);
				return cb_newThread_Ljava_lang_Runnable_;
			}

			static IntPtr n_NewThread_Ljava_lang_Runnable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Nostra13.Universalimageloader.Core.DefaultConfigurationFactory.DefaultThreadFactory __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.DefaultConfigurationFactory.DefaultThreadFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.IRunnable p0 = (global::Java.Lang.IRunnable)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.NewThread (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_newThread_Ljava_lang_Runnable_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='DefaultConfigurationFactory.DefaultThreadFactory']/method[@name='newThread' and count(parameter)=1 and parameter[1][@type='java.lang.Runnable']]"
			[Register ("newThread", "(Ljava/lang/Runnable;)Ljava/lang/Thread;", "GetNewThread_Ljava_lang_Runnable_Handler")]
			public virtual global::Java.Lang.Thread NewThread (global::Java.Lang.IRunnable p0)
			{
				if (id_newThread_Ljava_lang_Runnable_ == IntPtr.Zero)
					id_newThread_Ljava_lang_Runnable_ = JNIEnv.GetMethodID (class_ref, "newThread", "(Ljava/lang/Runnable;)Ljava/lang/Thread;");

				global::Java.Lang.Thread __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Thread> (JNIEnv.CallObjectMethod  (Handle, id_newThread_Ljava_lang_Runnable_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Thread> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_newThread_Ljava_lang_Runnable_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/nostra13/universalimageloader/core/DefaultConfigurationFactory", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DefaultConfigurationFactory); }
		}

		protected DefaultConfigurationFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='DefaultConfigurationFactory']/constructor[@name='DefaultConfigurationFactory' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public DefaultConfigurationFactory () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (DefaultConfigurationFactory)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "()V"), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_createBitmapDisplayer;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='DefaultConfigurationFactory']/method[@name='createBitmapDisplayer' and count(parameter)=0]"
		[Register ("createBitmapDisplayer", "()Lcom/nostra13/universalimageloader/core/display/BitmapDisplayer;", "")]
		public static global::Com.Nostra13.Universalimageloader.Core.Display.IBitmapDisplayer CreateBitmapDisplayer ()
		{
			if (id_createBitmapDisplayer == IntPtr.Zero)
				id_createBitmapDisplayer = JNIEnv.GetStaticMethodID (class_ref, "createBitmapDisplayer", "()Lcom/nostra13/universalimageloader/core/display/BitmapDisplayer;");
			return global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Display.IBitmapDisplayer> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createBitmapDisplayer), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_createDiscCache_Landroid_content_Context_Lcom_nostra13_universalimageloader_cache_disc_naming_FileNameGenerator_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='DefaultConfigurationFactory']/method[@name='createDiscCache' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.nostra13.universalimageloader.cache.disc.naming.FileNameGenerator'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("createDiscCache", "(Landroid/content/Context;Lcom/nostra13/universalimageloader/cache/disc/naming/FileNameGenerator;II)Lcom/nostra13/universalimageloader/cache/disc/DiscCacheAware;", "")]
		public static global::Com.Nostra13.Universalimageloader.Cache.Disc.IDiscCacheAware CreateDiscCache (global::Android.Content.Context p0, global::Com.Nostra13.Universalimageloader.Cache.Disc.Naming.IFileNameGenerator p1, int p2, int p3)
		{
			if (id_createDiscCache_Landroid_content_Context_Lcom_nostra13_universalimageloader_cache_disc_naming_FileNameGenerator_II == IntPtr.Zero)
				id_createDiscCache_Landroid_content_Context_Lcom_nostra13_universalimageloader_cache_disc_naming_FileNameGenerator_II = JNIEnv.GetStaticMethodID (class_ref, "createDiscCache", "(Landroid/content/Context;Lcom/nostra13/universalimageloader/cache/disc/naming/FileNameGenerator;II)Lcom/nostra13/universalimageloader/cache/disc/DiscCacheAware;");
			global::Com.Nostra13.Universalimageloader.Cache.Disc.IDiscCacheAware __ret = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Cache.Disc.IDiscCacheAware> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createDiscCache_Landroid_content_Context_Lcom_nostra13_universalimageloader_cache_disc_naming_FileNameGenerator_II, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_createExecutor_IILcom_nostra13_universalimageloader_core_assist_QueueProcessingType_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='DefaultConfigurationFactory']/method[@name='createExecutor' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='com.nostra13.universalimageloader.core.assist.QueueProcessingType']]"
		[Register ("createExecutor", "(IILcom/nostra13/universalimageloader/core/assist/QueueProcessingType;)Ljava/util/concurrent/Executor;", "")]
		public static global::Java.Util.Concurrent.IExecutor CreateExecutor (int p0, int p1, global::Com.Nostra13.Universalimageloader.Core.Assist.QueueProcessingType p2)
		{
			if (id_createExecutor_IILcom_nostra13_universalimageloader_core_assist_QueueProcessingType_ == IntPtr.Zero)
				id_createExecutor_IILcom_nostra13_universalimageloader_core_assist_QueueProcessingType_ = JNIEnv.GetStaticMethodID (class_ref, "createExecutor", "(IILcom/nostra13/universalimageloader/core/assist/QueueProcessingType;)Ljava/util/concurrent/Executor;");
			global::Java.Util.Concurrent.IExecutor __ret = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IExecutor> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createExecutor_IILcom_nostra13_universalimageloader_core_assist_QueueProcessingType_, new JValue (p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_createFileNameGenerator;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='DefaultConfigurationFactory']/method[@name='createFileNameGenerator' and count(parameter)=0]"
		[Register ("createFileNameGenerator", "()Lcom/nostra13/universalimageloader/cache/disc/naming/FileNameGenerator;", "")]
		public static global::Com.Nostra13.Universalimageloader.Cache.Disc.Naming.IFileNameGenerator CreateFileNameGenerator ()
		{
			if (id_createFileNameGenerator == IntPtr.Zero)
				id_createFileNameGenerator = JNIEnv.GetStaticMethodID (class_ref, "createFileNameGenerator", "()Lcom/nostra13/universalimageloader/cache/disc/naming/FileNameGenerator;");
			return global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Cache.Disc.Naming.IFileNameGenerator> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createFileNameGenerator), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_createImageDecoder_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='DefaultConfigurationFactory']/method[@name='createImageDecoder' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("createImageDecoder", "(Z)Lcom/nostra13/universalimageloader/core/decode/ImageDecoder;", "")]
		public static global::Com.Nostra13.Universalimageloader.Core.Decode.IImageDecoder CreateImageDecoder (bool p0)
		{
			if (id_createImageDecoder_Z == IntPtr.Zero)
				id_createImageDecoder_Z = JNIEnv.GetStaticMethodID (class_ref, "createImageDecoder", "(Z)Lcom/nostra13/universalimageloader/core/decode/ImageDecoder;");
			return global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Decode.IImageDecoder> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createImageDecoder_Z, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_createImageDownloader_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='DefaultConfigurationFactory']/method[@name='createImageDownloader' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("createImageDownloader", "(Landroid/content/Context;)Lcom/nostra13/universalimageloader/core/download/ImageDownloader;", "")]
		public static global::Com.Nostra13.Universalimageloader.Core.Download.IImageDownloader CreateImageDownloader (global::Android.Content.Context p0)
		{
			if (id_createImageDownloader_Landroid_content_Context_ == IntPtr.Zero)
				id_createImageDownloader_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "createImageDownloader", "(Landroid/content/Context;)Lcom/nostra13/universalimageloader/core/download/ImageDownloader;");
			global::Com.Nostra13.Universalimageloader.Core.Download.IImageDownloader __ret = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Download.IImageDownloader> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createImageDownloader_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_createMemoryCache_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='DefaultConfigurationFactory']/method[@name='createMemoryCache' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("createMemoryCache", "(I)Lcom/nostra13/universalimageloader/cache/memory/MemoryCacheAware;", "")]
		public static global::Com.Nostra13.Universalimageloader.Cache.Memory.IMemoryCacheAware CreateMemoryCache (int p0)
		{
			if (id_createMemoryCache_I == IntPtr.Zero)
				id_createMemoryCache_I = JNIEnv.GetStaticMethodID (class_ref, "createMemoryCache", "(I)Lcom/nostra13/universalimageloader/cache/memory/MemoryCacheAware;");
			return global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Cache.Memory.IMemoryCacheAware> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createMemoryCache_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_createReserveDiscCache_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='DefaultConfigurationFactory']/method[@name='createReserveDiscCache' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("createReserveDiscCache", "(Landroid/content/Context;)Lcom/nostra13/universalimageloader/cache/disc/DiscCacheAware;", "")]
		public static global::Com.Nostra13.Universalimageloader.Cache.Disc.IDiscCacheAware CreateReserveDiscCache (global::Android.Content.Context p0)
		{
			if (id_createReserveDiscCache_Landroid_content_Context_ == IntPtr.Zero)
				id_createReserveDiscCache_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "createReserveDiscCache", "(Landroid/content/Context;)Lcom/nostra13/universalimageloader/cache/disc/DiscCacheAware;");
			global::Com.Nostra13.Universalimageloader.Cache.Disc.IDiscCacheAware __ret = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Cache.Disc.IDiscCacheAware> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createReserveDiscCache_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}
}
