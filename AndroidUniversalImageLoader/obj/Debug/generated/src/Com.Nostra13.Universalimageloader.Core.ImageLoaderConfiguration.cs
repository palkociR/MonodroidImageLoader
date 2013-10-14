using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nostra13.Universalimageloader.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='ImageLoaderConfiguration']"
	[global::Android.Runtime.Register ("com/nostra13/universalimageloader/core/ImageLoaderConfiguration", DoNotGenerateAcw=true)]
	public sealed partial class ImageLoaderConfiguration : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='ImageLoaderConfiguration.Builder']"
		[global::Android.Runtime.Register ("com/nostra13/universalimageloader/core/ImageLoaderConfiguration$Builder", DoNotGenerateAcw=true)]
		public partial class Builder : global::Java.Lang.Object {


			static IntPtr DEFAULT_TASK_PROCESSING_TYPE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='ImageLoaderConfiguration.Builder']/field[@name='DEFAULT_TASK_PROCESSING_TYPE']"
			[Register ("DEFAULT_TASK_PROCESSING_TYPE")]
			public static global::Com.Nostra13.Universalimageloader.Core.Assist.QueueProcessingType DefaultTaskProcessingType {
				get {
					if (DEFAULT_TASK_PROCESSING_TYPE_jfieldId == IntPtr.Zero)
						DEFAULT_TASK_PROCESSING_TYPE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEFAULT_TASK_PROCESSING_TYPE", "Lcom/nostra13/universalimageloader/core/assist/QueueProcessingType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DEFAULT_TASK_PROCESSING_TYPE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.QueueProcessingType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (DEFAULT_TASK_PROCESSING_TYPE_jfieldId == IntPtr.Zero)
						DEFAULT_TASK_PROCESSING_TYPE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEFAULT_TASK_PROCESSING_TYPE", "Lcom/nostra13/universalimageloader/core/assist/QueueProcessingType;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, DEFAULT_TASK_PROCESSING_TYPE_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			// Metadata.xml XPath field reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='ImageLoaderConfiguration.Builder']/field[@name='DEFAULT_THREAD_POOL_SIZE']"
			[Register ("DEFAULT_THREAD_POOL_SIZE")]
			public const int DefaultThreadPoolSize = (int) 3;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='ImageLoaderConfiguration.Builder']/field[@name='DEFAULT_THREAD_PRIORITY']"
			[Register ("DEFAULT_THREAD_PRIORITY")]
			public const int DefaultThreadPriority = (int) 4;
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/nostra13/universalimageloader/core/ImageLoaderConfiguration$Builder", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Builder); }
			}

			protected Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Landroid_content_Context_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='ImageLoaderConfiguration.Builder']/constructor[@name='ImageLoaderConfiguration.Builder' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
			[Register (".ctor", "(Landroid/content/Context;)V", "")]
			public Builder (global::Android.Content.Context p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (Builder)) {
					SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Landroid/content/Context;)V", new JValue (p0)), JniHandleOwnership.TransferLocalRef);
					return;
				}

				if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
				SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			}

			static Delegate cb_build;
#pragma warning disable 0169
			static Delegate GetBuildHandler ()
			{
				if (cb_build == null)
					cb_build = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Build);
				return cb_build;
			}

			static IntPtr n_Build (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Nostra13.Universalimageloader.Core.ImageLoaderConfiguration.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.ImageLoaderConfiguration.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Build ());
			}
#pragma warning restore 0169

			static IntPtr id_build;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='ImageLoaderConfiguration.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/nostra13/universalimageloader/core/ImageLoaderConfiguration;", "GetBuildHandler")]
			public virtual global::Com.Nostra13.Universalimageloader.Core.ImageLoaderConfiguration Build ()
			{
				if (id_build == IntPtr.Zero)
					id_build = JNIEnv.GetMethodID (class_ref, "build", "()Lcom/nostra13/universalimageloader/core/ImageLoaderConfiguration;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.ImageLoaderConfiguration> (JNIEnv.CallObjectMethod  (Handle, id_build), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.ImageLoaderConfiguration> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_build), JniHandleOwnership.TransferLocalRef);
			}

			static Delegate cb_defaultDisplayImageOptions_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_;
#pragma warning disable 0169
			static Delegate GetDefaultDisplayImageOptions_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_Handler ()
			{
				if (cb_defaultDisplayImageOptions_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_ == null)
					cb_defaultDisplayImageOptions_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_DefaultDisplayImageOptions_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_);
				return cb_defaultDisplayImageOptions_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_;
			}

			static IntPtr n_DefaultDisplayImageOptions_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Nostra13.Universalimageloader.Core.ImageLoaderConfiguration.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.ImageLoaderConfiguration.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions p0 = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DefaultDisplayImageOptions (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_defaultDisplayImageOptions_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='ImageLoaderConfiguration.Builder']/method[@name='defaultDisplayImageOptions' and count(parameter)=1 and parameter[1][@type='com.nostra13.universalimageloader.core.DisplayImageOptions']]"
			[Register ("defaultDisplayImageOptions", "(Lcom/nostra13/universalimageloader/core/DisplayImageOptions;)Lcom/nostra13/universalimageloader/core/ImageLoaderConfiguration$Builder;", "GetDefaultDisplayImageOptions_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_Handler")]
			public virtual global::Com.Nostra13.Universalimageloader.Core.ImageLoaderConfiguration.Builder DefaultDisplayImageOptions (global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions p0)
			{
				if (id_defaultDisplayImageOptions_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_ == IntPtr.Zero)
					id_defaultDisplayImageOptions_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_ = JNIEnv.GetMethodID (class_ref, "defaultDisplayImageOptions", "(Lcom/nostra13/universalimageloader/core/DisplayImageOptions;)Lcom/nostra13/universalimageloader/core/ImageLoaderConfiguration$Builder;");

				global::Com.Nostra13.Universalimageloader.Core.ImageLoaderConfiguration.Builder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.ImageLoaderConfiguration.Builder> (JNIEnv.CallObjectMethod  (Handle, id_defaultDisplayImageOptions_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.ImageLoaderConfiguration.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_defaultDisplayImageOptions_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static Delegate cb_denyCacheImageMultipleSizesInMemory;
#pragma warning disable 0169
			static Delegate GetDenyCacheImageMultipleSizesInMemoryHandler ()
			{
				if (cb_denyCacheImageMultipleSizesInMemory == null)
					cb_denyCacheImageMultipleSizesInMemory = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_DenyCacheImageMultipleSizesInMemory);
				return cb_denyCacheImageMultipleSizesInMemory;
			}

			static IntPtr n_DenyCacheImageMultipleSizesInMemory (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Nostra13.Universalimageloader.Core.ImageLoaderConfiguration.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.ImageLoaderConfiguration.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.DenyCacheImageMultipleSizesInMemory ());
			}
#pragma warning restore 0169

			static IntPtr id_denyCacheImageMultipleSizesInMemory;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='ImageLoaderConfiguration.Builder']/method[@name='denyCacheImageMultipleSizesInMemory' and count(parameter)=0]"
			[Register ("denyCacheImageMultipleSizesInMemory", "()Lcom/nostra13/universalimageloader/core/ImageLoaderConfiguration$Builder;", "GetDenyCacheImageMultipleSizesInMemoryHandler")]
			public virtual global::Com.Nostra13.Universalimageloader.Core.ImageLoaderConfiguration.Builder DenyCacheImageMultipleSizesInMemory ()
			{
				if (id_denyCacheImageMultipleSizesInMemory == IntPtr.Zero)
					id_denyCacheImageMultipleSizesInMemory = JNIEnv.GetMethodID (class_ref, "denyCacheImageMultipleSizesInMemory", "()Lcom/nostra13/universalimageloader/core/ImageLoaderConfiguration$Builder;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.ImageLoaderConfiguration.Builder> (JNIEnv.CallObjectMethod  (Handle, id_denyCacheImageMultipleSizesInMemory), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.ImageLoaderConfiguration.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_denyCacheImageMultipleSizesInMemory), JniHandleOwnership.TransferLocalRef);
			}

			static Delegate cb_discCache_Lcom_nostra13_universalimageloader_cache_disc_DiscCacheAware_;
#pragma warning disable 0169
			static Delegate GetDiscCache_Lcom_nostra13_universalimageloader_cache_disc_DiscCacheAware_Handler ()
			{
				if (cb_discCache_Lcom_nostra13_universalimageloader_cache_disc_DiscCacheAware_ == null)
					cb_discCache_Lcom_nostra13_universalimageloader_cache_disc_DiscCacheAware_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_DiscCache_Lcom_nostra13_universalimageloader_cache_disc_DiscCacheAware_);
				return cb_discCache_Lcom_nostra13_universalimageloader_cache_disc_DiscCacheAware_;
			}

			static IntPtr n_DiscCache_Lcom_nostra13_universalimageloader_cache_disc_DiscCacheAware_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Nostra13.Universalimageloader.Core.ImageLoaderConfiguration.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.ImageLoaderConfiguration.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Nostra13.Universalimageloader.Cache.Disc.IDiscCacheAware p0 = (global::Com.Nostra13.Universalimageloader.Cache.Disc.IDiscCacheAware)global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Cache.Disc.IDiscCacheAware> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DiscCache (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_discCache_Lcom_nostra13_universalimageloader_cache_disc_DiscCacheAware_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='ImageLoaderConfiguration.Builder']/method[@name='discCache' and count(parameter)=1 and parameter[1][@type='com.nostra13.universalimageloader.cache.disc.DiscCacheAware']]"
			[Register ("discCache", "(Lcom/nostra13/universalimageloader/cache/disc/DiscCacheAware;)Lcom/nostra13/universalimageloader/core/ImageLoaderConfiguration$Builder;", "GetDiscCache_Lcom_nostra13_universalimageloader_cache_disc_DiscCacheAware_Handler")]
			public virtual global::Com.Nostra13.Universalimageloader.Core.ImageLoaderConfiguration.Builder DiscCache (global::Com.Nostra13.Universalimageloader.Cache.Disc.IDiscCacheAware p0)
			{
				if (id_discCache_Lcom_nostra13_universalimageloader_cache_disc_DiscCacheAware_ == IntPtr.Zero)
					id_discCache_Lcom_nostra13_universalimageloader_cache_disc_DiscCacheAware_ = JNIEnv.GetMethodID (class_ref, "discCache", "(Lcom/nostra13/universalimageloader/cache/disc/DiscCacheAware;)Lcom/nostra13/universalimageloader/core/ImageLoaderConfiguration$Builder;");

				global::Com.Nostra13.Universalimageloader.Core.ImageLoaderConfiguration.Builder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.ImageLoaderConfiguration.Builder> (JNIEnv.CallObjectMethod  (Handle, id_discCache_Lcom_nostra13_universalimageloader_cache_disc_DiscCacheAware_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.ImageLoaderConfiguration.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_discCache_Lcom_nostra13_universalimageloader_cache_disc_DiscCacheAware_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static Delegate cb_discCacheExtraOptions_IILandroid_graphics_Bitmap_CompressFormat_I;
#pragma warning disable 0169
			static Delegate GetDiscCacheExtraOptions_IILandroid_graphics_Bitmap_CompressFormat_IHandler ()
			{
				if (cb_discCacheExtraOptions_IILandroid_graphics_Bitmap_CompressFormat_I == null)
					cb_discCacheExtraOptions_IILandroid_graphics_Bitmap_CompressFormat_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr, int, IntPtr>) n_DiscCacheExtraOptions_IILandroid_graphics_Bitmap_CompressFormat_I);
				return cb_discCacheExtraOptions_IILandroid_graphics_Bitmap_CompressFormat_I;
			}

			static IntPtr n_DiscCacheExtraOptions_IILandroid_graphics_Bitmap_CompressFormat_I (IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2, int p3)
			{
				global::Com.Nostra13.Universalimageloader.Core.ImageLoaderConfiguration.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.ImageLoaderConfiguration.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Graphics.Bitmap.CompressFormat p2 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap.CompressFormat> (native_p2, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DiscCacheExtraOptions (p0, p1, p2, p3));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_discCacheExtraOptions_IILandroid_graphics_Bitmap_CompressFormat_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='ImageLoaderConfiguration.Builder']/method[@name='discCacheExtraOptions' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='android.graphics.Bitmap.CompressFormat'] and parameter[4][@type='int']]"
			[Register ("discCacheExtraOptions", "(IILandroid/graphics/Bitmap$CompressFormat;I)Lcom/nostra13/universalimageloader/core/ImageLoaderConfiguration$Builder;", "GetDiscCacheExtraOptions_IILandroid_graphics_Bitmap_CompressFormat_IHandler")]
			public virtual global::Com.Nostra13.Universalimageloader.Core.ImageLoaderConfiguration.Builder DiscCacheExtraOptions (int p0, int p1, global::Android.Graphics.Bitmap.CompressFormat p2, int p3)
			{
				if (id_discCacheExtraOptions_IILandroid_graphics_Bitmap_CompressFormat_I == IntPtr.Zero)
					id_discCacheExtraOptions_IILandroid_graphics_Bitmap_CompressFormat_I = JNIEnv.GetMethodID (class_ref, "discCacheExtraOptions", "(IILandroid/graphics/Bitmap$CompressFormat;I)Lcom/nostra13/universalimageloader/core/ImageLoaderConfiguration$Builder;");

				global::Com.Nostra13.Universalimageloader.Core.ImageLoaderConfiguration.Builder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.ImageLoaderConfiguration.Builder> (JNIEnv.CallObjectMethod  (Handle, id_discCacheExtraOptions_IILandroid_graphics_Bitmap_CompressFormat_I, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3)), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.ImageLoaderConfiguration.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_discCacheExtraOptions_IILandroid_graphics_Bitmap_CompressFormat_I, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static Delegate cb_discCacheFileCount_I;
#pragma warning disable 0169
			static Delegate GetDiscCacheFileCount_IHandler ()
			{
				if (cb_discCacheFileCount_I == null)
					cb_discCacheFileCount_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_DiscCacheFileCount_I);
				return cb_discCacheFileCount_I;
			}

			static IntPtr n_DiscCacheFileCount_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Nostra13.Universalimageloader.Core.ImageLoaderConfiguration.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.ImageLoaderConfiguration.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.DiscCacheFileCount (p0));
			}
#pragma warning restore 0169

			static IntPtr id_discCacheFileCount_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='ImageLoaderConfiguration.Builder']/method[@name='discCacheFileCount' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("discCacheFileCount", "(I)Lcom/nostra13/universalimageloader/core/ImageLoaderConfiguration$Builder;", "GetDiscCacheFileCount_IHandler")]
			public virtual global::Com.Nostra13.Universalimageloader.Core.ImageLoaderConfiguration.Builder DiscCacheFileCount (int p0)
			{
				if (id_discCacheFileCount_I == IntPtr.Zero)
					id_discCacheFileCount_I = JNIEnv.GetMethodID (class_ref, "discCacheFileCount", "(I)Lcom/nostra13/universalimageloader/core/ImageLoaderConfiguration$Builder;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.ImageLoaderConfiguration.Builder> (JNIEnv.CallObjectMethod  (Handle, id_discCacheFileCount_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.ImageLoaderConfiguration.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_discCacheFileCount_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			}

			static Delegate cb_discCacheFileNameGenerator_Lcom_nostra13_universalimageloader_cache_disc_naming_FileNameGenerator_;
#pragma warning disable 0169
			static Delegate GetDiscCacheFileNameGenerator_Lcom_nostra13_universalimageloader_cache_disc_naming_FileNameGenerator_Handler ()
			{
				if (cb_discCacheFileNameGenerator_Lcom_nostra13_universalimageloader_cache_disc_naming_FileNameGenerator_ == null)
					cb_discCacheFileNameGenerator_Lcom_nostra13_universalimageloader_cache_disc_naming_FileNameGenerator_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_DiscCacheFileNameGenerator_Lcom_nostra13_universalimageloader_cache_disc_naming_FileNameGenerator_);
				return cb_discCacheFileNameGenerator_Lcom_nostra13_universalimageloader_cache_disc_naming_FileNameGenerator_;
			}

			static IntPtr n_DiscCacheFileNameGenerator_Lcom_nostra13_universalimageloader_cache_disc_naming_FileNameGenerator_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Nostra13.Universalimageloader.Core.ImageLoaderConfiguration.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.ImageLoaderConfiguration.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Nostra13.Universalimageloader.Cache.Disc.Naming.IFileNameGenerator p0 = (global::Com.Nostra13.Universalimageloader.Cache.Disc.Naming.IFileNameGenerator)global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Cache.Disc.Naming.IFileNameGenerator> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DiscCacheFileNameGenerator (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_discCacheFileNameGenerator_Lcom_nostra13_universalimageloader_cache_disc_naming_FileNameGenerator_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='ImageLoaderConfiguration.Builder']/method[@name='discCacheFileNameGenerator' and count(parameter)=1 and parameter[1][@type='com.nostra13.universalimageloader.cache.disc.naming.FileNameGenerator']]"
			[Register ("discCacheFileNameGenerator", "(Lcom/nostra13/universalimageloader/cache/disc/naming/FileNameGenerator;)Lcom/nostra13/universalimageloader/core/ImageLoaderConfiguration$Builder;", "GetDiscCacheFileNameGenerator_Lcom_nostra13_universalimageloader_cache_disc_naming_FileNameGenerator_Handler")]
			public virtual global::Com.Nostra13.Universalimageloader.Core.ImageLoaderConfiguration.Builder DiscCacheFileNameGenerator (global::Com.Nostra13.Universalimageloader.Cache.Disc.Naming.IFileNameGenerator p0)
			{
				if (id_discCacheFileNameGenerator_Lcom_nostra13_universalimageloader_cache_disc_naming_FileNameGenerator_ == IntPtr.Zero)
					id_discCacheFileNameGenerator_Lcom_nostra13_universalimageloader_cache_disc_naming_FileNameGenerator_ = JNIEnv.GetMethodID (class_ref, "discCacheFileNameGenerator", "(Lcom/nostra13/universalimageloader/cache/disc/naming/FileNameGenerator;)Lcom/nostra13/universalimageloader/core/ImageLoaderConfiguration$Builder;");

				global::Com.Nostra13.Universalimageloader.Core.ImageLoaderConfiguration.Builder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.ImageLoaderConfiguration.Builder> (JNIEnv.CallObjectMethod  (Handle, id_discCacheFileNameGenerator_Lcom_nostra13_universalimageloader_cache_disc_naming_FileNameGenerator_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.ImageLoaderConfiguration.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_discCacheFileNameGenerator_Lcom_nostra13_universalimageloader_cache_disc_naming_FileNameGenerator_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static Delegate cb_discCacheSize_I;
#pragma warning disable 0169
			static Delegate GetDiscCacheSize_IHandler ()
			{
				if (cb_discCacheSize_I == null)
					cb_discCacheSize_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_DiscCacheSize_I);
				return cb_discCacheSize_I;
			}

			static IntPtr n_DiscCacheSize_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Nostra13.Universalimageloader.Core.ImageLoaderConfiguration.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.ImageLoaderConfiguration.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.DiscCacheSize (p0));
			}
#pragma warning restore 0169

			static IntPtr id_discCacheSize_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='ImageLoaderConfiguration.Builder']/method[@name='discCacheSize' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("discCacheSize", "(I)Lcom/nostra13/universalimageloader/core/ImageLoaderConfiguration$Builder;", "GetDiscCacheSize_IHandler")]
			public virtual global::Com.Nostra13.Universalimageloader.Core.ImageLoaderConfiguration.Builder DiscCacheSize (int p0)
			{
				if (id_discCacheSize_I == IntPtr.Zero)
					id_discCacheSize_I = JNIEnv.GetMethodID (class_ref, "discCacheSize", "(I)Lcom/nostra13/universalimageloader/core/ImageLoaderConfiguration$Builder;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.ImageLoaderConfiguration.Builder> (JNIEnv.CallObjectMethod  (Handle, id_discCacheSize_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.ImageLoaderConfiguration.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_discCacheSize_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			}

			static Delegate cb_enableLogging;
#pragma warning disable 0169
			static Delegate GetEnableLoggingHandler ()
			{
				if (cb_enableLogging == null)
					cb_enableLogging = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_EnableLogging);
				return cb_enableLogging;
			}

			static IntPtr n_EnableLogging (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Nostra13.Universalimageloader.Core.ImageLoaderConfiguration.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.ImageLoaderConfiguration.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.EnableLogging ());
			}
#pragma warning restore 0169

			static IntPtr id_enableLogging;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='ImageLoaderConfiguration.Builder']/method[@name='enableLogging' and count(parameter)=0]"
			[Register ("enableLogging", "()Lcom/nostra13/universalimageloader/core/ImageLoaderConfiguration$Builder;", "GetEnableLoggingHandler")]
			public virtual global::Com.Nostra13.Universalimageloader.Core.ImageLoaderConfiguration.Builder EnableLogging ()
			{
				if (id_enableLogging == IntPtr.Zero)
					id_enableLogging = JNIEnv.GetMethodID (class_ref, "enableLogging", "()Lcom/nostra13/universalimageloader/core/ImageLoaderConfiguration$Builder;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.ImageLoaderConfiguration.Builder> (JNIEnv.CallObjectMethod  (Handle, id_enableLogging), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.ImageLoaderConfiguration.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_enableLogging), JniHandleOwnership.TransferLocalRef);
			}

			static Delegate cb_imageDecoder_Lcom_nostra13_universalimageloader_core_decode_ImageDecoder_;
#pragma warning disable 0169
			static Delegate GetImageDecoder_Lcom_nostra13_universalimageloader_core_decode_ImageDecoder_Handler ()
			{
				if (cb_imageDecoder_Lcom_nostra13_universalimageloader_core_decode_ImageDecoder_ == null)
					cb_imageDecoder_Lcom_nostra13_universalimageloader_core_decode_ImageDecoder_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ImageDecoder_Lcom_nostra13_universalimageloader_core_decode_ImageDecoder_);
				return cb_imageDecoder_Lcom_nostra13_universalimageloader_core_decode_ImageDecoder_;
			}

			static IntPtr n_ImageDecoder_Lcom_nostra13_universalimageloader_core_decode_ImageDecoder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Nostra13.Universalimageloader.Core.ImageLoaderConfiguration.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.ImageLoaderConfiguration.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Nostra13.Universalimageloader.Core.Decode.IImageDecoder p0 = (global::Com.Nostra13.Universalimageloader.Core.Decode.IImageDecoder)global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Decode.IImageDecoder> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ImageDecoder (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_imageDecoder_Lcom_nostra13_universalimageloader_core_decode_ImageDecoder_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='ImageLoaderConfiguration.Builder']/method[@name='imageDecoder' and count(parameter)=1 and parameter[1][@type='com.nostra13.universalimageloader.core.decode.ImageDecoder']]"
			[Register ("imageDecoder", "(Lcom/nostra13/universalimageloader/core/decode/ImageDecoder;)Lcom/nostra13/universalimageloader/core/ImageLoaderConfiguration$Builder;", "GetImageDecoder_Lcom_nostra13_universalimageloader_core_decode_ImageDecoder_Handler")]
			public virtual global::Com.Nostra13.Universalimageloader.Core.ImageLoaderConfiguration.Builder ImageDecoder (global::Com.Nostra13.Universalimageloader.Core.Decode.IImageDecoder p0)
			{
				if (id_imageDecoder_Lcom_nostra13_universalimageloader_core_decode_ImageDecoder_ == IntPtr.Zero)
					id_imageDecoder_Lcom_nostra13_universalimageloader_core_decode_ImageDecoder_ = JNIEnv.GetMethodID (class_ref, "imageDecoder", "(Lcom/nostra13/universalimageloader/core/decode/ImageDecoder;)Lcom/nostra13/universalimageloader/core/ImageLoaderConfiguration$Builder;");

				global::Com.Nostra13.Universalimageloader.Core.ImageLoaderConfiguration.Builder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.ImageLoaderConfiguration.Builder> (JNIEnv.CallObjectMethod  (Handle, id_imageDecoder_Lcom_nostra13_universalimageloader_core_decode_ImageDecoder_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.ImageLoaderConfiguration.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_imageDecoder_Lcom_nostra13_universalimageloader_core_decode_ImageDecoder_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static Delegate cb_imageDownloader_Lcom_nostra13_universalimageloader_core_download_ImageDownloader_;
#pragma warning disable 0169
			static Delegate GetImageDownloader_Lcom_nostra13_universalimageloader_core_download_ImageDownloader_Handler ()
			{
				if (cb_imageDownloader_Lcom_nostra13_universalimageloader_core_download_ImageDownloader_ == null)
					cb_imageDownloader_Lcom_nostra13_universalimageloader_core_download_ImageDownloader_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ImageDownloader_Lcom_nostra13_universalimageloader_core_download_ImageDownloader_);
				return cb_imageDownloader_Lcom_nostra13_universalimageloader_core_download_ImageDownloader_;
			}

			static IntPtr n_ImageDownloader_Lcom_nostra13_universalimageloader_core_download_ImageDownloader_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Nostra13.Universalimageloader.Core.ImageLoaderConfiguration.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.ImageLoaderConfiguration.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Nostra13.Universalimageloader.Core.Download.IImageDownloader p0 = (global::Com.Nostra13.Universalimageloader.Core.Download.IImageDownloader)global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Download.IImageDownloader> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ImageDownloader (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_imageDownloader_Lcom_nostra13_universalimageloader_core_download_ImageDownloader_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='ImageLoaderConfiguration.Builder']/method[@name='imageDownloader' and count(parameter)=1 and parameter[1][@type='com.nostra13.universalimageloader.core.download.ImageDownloader']]"
			[Register ("imageDownloader", "(Lcom/nostra13/universalimageloader/core/download/ImageDownloader;)Lcom/nostra13/universalimageloader/core/ImageLoaderConfiguration$Builder;", "GetImageDownloader_Lcom_nostra13_universalimageloader_core_download_ImageDownloader_Handler")]
			public virtual global::Com.Nostra13.Universalimageloader.Core.ImageLoaderConfiguration.Builder ImageDownloader (global::Com.Nostra13.Universalimageloader.Core.Download.IImageDownloader p0)
			{
				if (id_imageDownloader_Lcom_nostra13_universalimageloader_core_download_ImageDownloader_ == IntPtr.Zero)
					id_imageDownloader_Lcom_nostra13_universalimageloader_core_download_ImageDownloader_ = JNIEnv.GetMethodID (class_ref, "imageDownloader", "(Lcom/nostra13/universalimageloader/core/download/ImageDownloader;)Lcom/nostra13/universalimageloader/core/ImageLoaderConfiguration$Builder;");

				global::Com.Nostra13.Universalimageloader.Core.ImageLoaderConfiguration.Builder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.ImageLoaderConfiguration.Builder> (JNIEnv.CallObjectMethod  (Handle, id_imageDownloader_Lcom_nostra13_universalimageloader_core_download_ImageDownloader_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.ImageLoaderConfiguration.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_imageDownloader_Lcom_nostra13_universalimageloader_core_download_ImageDownloader_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static Delegate cb_memoryCache_Lcom_nostra13_universalimageloader_cache_memory_MemoryCacheAware_;
#pragma warning disable 0169
			static Delegate GetMemoryCache_Lcom_nostra13_universalimageloader_cache_memory_MemoryCacheAware_Handler ()
			{
				if (cb_memoryCache_Lcom_nostra13_universalimageloader_cache_memory_MemoryCacheAware_ == null)
					cb_memoryCache_Lcom_nostra13_universalimageloader_cache_memory_MemoryCacheAware_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_MemoryCache_Lcom_nostra13_universalimageloader_cache_memory_MemoryCacheAware_);
				return cb_memoryCache_Lcom_nostra13_universalimageloader_cache_memory_MemoryCacheAware_;
			}

			static IntPtr n_MemoryCache_Lcom_nostra13_universalimageloader_cache_memory_MemoryCacheAware_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Nostra13.Universalimageloader.Core.ImageLoaderConfiguration.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.ImageLoaderConfiguration.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Nostra13.Universalimageloader.Cache.Memory.IMemoryCacheAware p0 = (global::Com.Nostra13.Universalimageloader.Cache.Memory.IMemoryCacheAware)global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Cache.Memory.IMemoryCacheAware> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.MemoryCache (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_memoryCache_Lcom_nostra13_universalimageloader_cache_memory_MemoryCacheAware_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='ImageLoaderConfiguration.Builder']/method[@name='memoryCache' and count(parameter)=1 and parameter[1][@type='com.nostra13.universalimageloader.cache.memory.MemoryCacheAware']]"
			[Register ("memoryCache", "(Lcom/nostra13/universalimageloader/cache/memory/MemoryCacheAware;)Lcom/nostra13/universalimageloader/core/ImageLoaderConfiguration$Builder;", "GetMemoryCache_Lcom_nostra13_universalimageloader_cache_memory_MemoryCacheAware_Handler")]
			public virtual global::Com.Nostra13.Universalimageloader.Core.ImageLoaderConfiguration.Builder MemoryCache (global::Com.Nostra13.Universalimageloader.Cache.Memory.IMemoryCacheAware p0)
			{
				if (id_memoryCache_Lcom_nostra13_universalimageloader_cache_memory_MemoryCacheAware_ == IntPtr.Zero)
					id_memoryCache_Lcom_nostra13_universalimageloader_cache_memory_MemoryCacheAware_ = JNIEnv.GetMethodID (class_ref, "memoryCache", "(Lcom/nostra13/universalimageloader/cache/memory/MemoryCacheAware;)Lcom/nostra13/universalimageloader/core/ImageLoaderConfiguration$Builder;");

				global::Com.Nostra13.Universalimageloader.Core.ImageLoaderConfiguration.Builder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.ImageLoaderConfiguration.Builder> (JNIEnv.CallObjectMethod  (Handle, id_memoryCache_Lcom_nostra13_universalimageloader_cache_memory_MemoryCacheAware_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.ImageLoaderConfiguration.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_memoryCache_Lcom_nostra13_universalimageloader_cache_memory_MemoryCacheAware_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static Delegate cb_memoryCacheExtraOptions_II;
#pragma warning disable 0169
			static Delegate GetMemoryCacheExtraOptions_IIHandler ()
			{
				if (cb_memoryCacheExtraOptions_II == null)
					cb_memoryCacheExtraOptions_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr>) n_MemoryCacheExtraOptions_II);
				return cb_memoryCacheExtraOptions_II;
			}

			static IntPtr n_MemoryCacheExtraOptions_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
			{
				global::Com.Nostra13.Universalimageloader.Core.ImageLoaderConfiguration.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.ImageLoaderConfiguration.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.MemoryCacheExtraOptions (p0, p1));
			}
#pragma warning restore 0169

			static IntPtr id_memoryCacheExtraOptions_II;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='ImageLoaderConfiguration.Builder']/method[@name='memoryCacheExtraOptions' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register ("memoryCacheExtraOptions", "(II)Lcom/nostra13/universalimageloader/core/ImageLoaderConfiguration$Builder;", "GetMemoryCacheExtraOptions_IIHandler")]
			public virtual global::Com.Nostra13.Universalimageloader.Core.ImageLoaderConfiguration.Builder MemoryCacheExtraOptions (int p0, int p1)
			{
				if (id_memoryCacheExtraOptions_II == IntPtr.Zero)
					id_memoryCacheExtraOptions_II = JNIEnv.GetMethodID (class_ref, "memoryCacheExtraOptions", "(II)Lcom/nostra13/universalimageloader/core/ImageLoaderConfiguration$Builder;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.ImageLoaderConfiguration.Builder> (JNIEnv.CallObjectMethod  (Handle, id_memoryCacheExtraOptions_II, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.ImageLoaderConfiguration.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_memoryCacheExtraOptions_II, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			}

			static Delegate cb_memoryCacheSize_I;
#pragma warning disable 0169
			static Delegate GetMemoryCacheSize_IHandler ()
			{
				if (cb_memoryCacheSize_I == null)
					cb_memoryCacheSize_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_MemoryCacheSize_I);
				return cb_memoryCacheSize_I;
			}

			static IntPtr n_MemoryCacheSize_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Nostra13.Universalimageloader.Core.ImageLoaderConfiguration.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.ImageLoaderConfiguration.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.MemoryCacheSize (p0));
			}
#pragma warning restore 0169

			static IntPtr id_memoryCacheSize_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='ImageLoaderConfiguration.Builder']/method[@name='memoryCacheSize' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("memoryCacheSize", "(I)Lcom/nostra13/universalimageloader/core/ImageLoaderConfiguration$Builder;", "GetMemoryCacheSize_IHandler")]
			public virtual global::Com.Nostra13.Universalimageloader.Core.ImageLoaderConfiguration.Builder MemoryCacheSize (int p0)
			{
				if (id_memoryCacheSize_I == IntPtr.Zero)
					id_memoryCacheSize_I = JNIEnv.GetMethodID (class_ref, "memoryCacheSize", "(I)Lcom/nostra13/universalimageloader/core/ImageLoaderConfiguration$Builder;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.ImageLoaderConfiguration.Builder> (JNIEnv.CallObjectMethod  (Handle, id_memoryCacheSize_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.ImageLoaderConfiguration.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_memoryCacheSize_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			}

			static Delegate cb_taskExecutor_Ljava_util_concurrent_Executor_;
#pragma warning disable 0169
			static Delegate GetTaskExecutor_Ljava_util_concurrent_Executor_Handler ()
			{
				if (cb_taskExecutor_Ljava_util_concurrent_Executor_ == null)
					cb_taskExecutor_Ljava_util_concurrent_Executor_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_TaskExecutor_Ljava_util_concurrent_Executor_);
				return cb_taskExecutor_Ljava_util_concurrent_Executor_;
			}

			static IntPtr n_TaskExecutor_Ljava_util_concurrent_Executor_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Nostra13.Universalimageloader.Core.ImageLoaderConfiguration.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.ImageLoaderConfiguration.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Util.Concurrent.IExecutor p0 = (global::Java.Util.Concurrent.IExecutor)global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IExecutor> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.TaskExecutor (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_taskExecutor_Ljava_util_concurrent_Executor_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='ImageLoaderConfiguration.Builder']/method[@name='taskExecutor' and count(parameter)=1 and parameter[1][@type='java.util.concurrent.Executor']]"
			[Register ("taskExecutor", "(Ljava/util/concurrent/Executor;)Lcom/nostra13/universalimageloader/core/ImageLoaderConfiguration$Builder;", "GetTaskExecutor_Ljava_util_concurrent_Executor_Handler")]
			public virtual global::Com.Nostra13.Universalimageloader.Core.ImageLoaderConfiguration.Builder TaskExecutor (global::Java.Util.Concurrent.IExecutor p0)
			{
				if (id_taskExecutor_Ljava_util_concurrent_Executor_ == IntPtr.Zero)
					id_taskExecutor_Ljava_util_concurrent_Executor_ = JNIEnv.GetMethodID (class_ref, "taskExecutor", "(Ljava/util/concurrent/Executor;)Lcom/nostra13/universalimageloader/core/ImageLoaderConfiguration$Builder;");

				global::Com.Nostra13.Universalimageloader.Core.ImageLoaderConfiguration.Builder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.ImageLoaderConfiguration.Builder> (JNIEnv.CallObjectMethod  (Handle, id_taskExecutor_Ljava_util_concurrent_Executor_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.ImageLoaderConfiguration.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_taskExecutor_Ljava_util_concurrent_Executor_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static Delegate cb_taskExecutorForCachedImages_Ljava_util_concurrent_Executor_;
#pragma warning disable 0169
			static Delegate GetTaskExecutorForCachedImages_Ljava_util_concurrent_Executor_Handler ()
			{
				if (cb_taskExecutorForCachedImages_Ljava_util_concurrent_Executor_ == null)
					cb_taskExecutorForCachedImages_Ljava_util_concurrent_Executor_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_TaskExecutorForCachedImages_Ljava_util_concurrent_Executor_);
				return cb_taskExecutorForCachedImages_Ljava_util_concurrent_Executor_;
			}

			static IntPtr n_TaskExecutorForCachedImages_Ljava_util_concurrent_Executor_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Nostra13.Universalimageloader.Core.ImageLoaderConfiguration.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.ImageLoaderConfiguration.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Util.Concurrent.IExecutor p0 = (global::Java.Util.Concurrent.IExecutor)global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IExecutor> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.TaskExecutorForCachedImages (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_taskExecutorForCachedImages_Ljava_util_concurrent_Executor_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='ImageLoaderConfiguration.Builder']/method[@name='taskExecutorForCachedImages' and count(parameter)=1 and parameter[1][@type='java.util.concurrent.Executor']]"
			[Register ("taskExecutorForCachedImages", "(Ljava/util/concurrent/Executor;)Lcom/nostra13/universalimageloader/core/ImageLoaderConfiguration$Builder;", "GetTaskExecutorForCachedImages_Ljava_util_concurrent_Executor_Handler")]
			public virtual global::Com.Nostra13.Universalimageloader.Core.ImageLoaderConfiguration.Builder TaskExecutorForCachedImages (global::Java.Util.Concurrent.IExecutor p0)
			{
				if (id_taskExecutorForCachedImages_Ljava_util_concurrent_Executor_ == IntPtr.Zero)
					id_taskExecutorForCachedImages_Ljava_util_concurrent_Executor_ = JNIEnv.GetMethodID (class_ref, "taskExecutorForCachedImages", "(Ljava/util/concurrent/Executor;)Lcom/nostra13/universalimageloader/core/ImageLoaderConfiguration$Builder;");

				global::Com.Nostra13.Universalimageloader.Core.ImageLoaderConfiguration.Builder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.ImageLoaderConfiguration.Builder> (JNIEnv.CallObjectMethod  (Handle, id_taskExecutorForCachedImages_Ljava_util_concurrent_Executor_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.ImageLoaderConfiguration.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_taskExecutorForCachedImages_Ljava_util_concurrent_Executor_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static Delegate cb_tasksProcessingOrder_Lcom_nostra13_universalimageloader_core_assist_QueueProcessingType_;
#pragma warning disable 0169
			static Delegate GetTasksProcessingOrder_Lcom_nostra13_universalimageloader_core_assist_QueueProcessingType_Handler ()
			{
				if (cb_tasksProcessingOrder_Lcom_nostra13_universalimageloader_core_assist_QueueProcessingType_ == null)
					cb_tasksProcessingOrder_Lcom_nostra13_universalimageloader_core_assist_QueueProcessingType_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_TasksProcessingOrder_Lcom_nostra13_universalimageloader_core_assist_QueueProcessingType_);
				return cb_tasksProcessingOrder_Lcom_nostra13_universalimageloader_core_assist_QueueProcessingType_;
			}

			static IntPtr n_TasksProcessingOrder_Lcom_nostra13_universalimageloader_core_assist_QueueProcessingType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Nostra13.Universalimageloader.Core.ImageLoaderConfiguration.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.ImageLoaderConfiguration.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Nostra13.Universalimageloader.Core.Assist.QueueProcessingType p0 = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.QueueProcessingType> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.TasksProcessingOrder (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_tasksProcessingOrder_Lcom_nostra13_universalimageloader_core_assist_QueueProcessingType_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='ImageLoaderConfiguration.Builder']/method[@name='tasksProcessingOrder' and count(parameter)=1 and parameter[1][@type='com.nostra13.universalimageloader.core.assist.QueueProcessingType']]"
			[Register ("tasksProcessingOrder", "(Lcom/nostra13/universalimageloader/core/assist/QueueProcessingType;)Lcom/nostra13/universalimageloader/core/ImageLoaderConfiguration$Builder;", "GetTasksProcessingOrder_Lcom_nostra13_universalimageloader_core_assist_QueueProcessingType_Handler")]
			public virtual global::Com.Nostra13.Universalimageloader.Core.ImageLoaderConfiguration.Builder TasksProcessingOrder (global::Com.Nostra13.Universalimageloader.Core.Assist.QueueProcessingType p0)
			{
				if (id_tasksProcessingOrder_Lcom_nostra13_universalimageloader_core_assist_QueueProcessingType_ == IntPtr.Zero)
					id_tasksProcessingOrder_Lcom_nostra13_universalimageloader_core_assist_QueueProcessingType_ = JNIEnv.GetMethodID (class_ref, "tasksProcessingOrder", "(Lcom/nostra13/universalimageloader/core/assist/QueueProcessingType;)Lcom/nostra13/universalimageloader/core/ImageLoaderConfiguration$Builder;");

				global::Com.Nostra13.Universalimageloader.Core.ImageLoaderConfiguration.Builder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.ImageLoaderConfiguration.Builder> (JNIEnv.CallObjectMethod  (Handle, id_tasksProcessingOrder_Lcom_nostra13_universalimageloader_core_assist_QueueProcessingType_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.ImageLoaderConfiguration.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_tasksProcessingOrder_Lcom_nostra13_universalimageloader_core_assist_QueueProcessingType_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static Delegate cb_threadPoolSize_I;
#pragma warning disable 0169
			static Delegate GetThreadPoolSize_IHandler ()
			{
				if (cb_threadPoolSize_I == null)
					cb_threadPoolSize_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_ThreadPoolSize_I);
				return cb_threadPoolSize_I;
			}

			static IntPtr n_ThreadPoolSize_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Nostra13.Universalimageloader.Core.ImageLoaderConfiguration.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.ImageLoaderConfiguration.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.ThreadPoolSize (p0));
			}
#pragma warning restore 0169

			static IntPtr id_threadPoolSize_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='ImageLoaderConfiguration.Builder']/method[@name='threadPoolSize' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("threadPoolSize", "(I)Lcom/nostra13/universalimageloader/core/ImageLoaderConfiguration$Builder;", "GetThreadPoolSize_IHandler")]
			public virtual global::Com.Nostra13.Universalimageloader.Core.ImageLoaderConfiguration.Builder ThreadPoolSize (int p0)
			{
				if (id_threadPoolSize_I == IntPtr.Zero)
					id_threadPoolSize_I = JNIEnv.GetMethodID (class_ref, "threadPoolSize", "(I)Lcom/nostra13/universalimageloader/core/ImageLoaderConfiguration$Builder;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.ImageLoaderConfiguration.Builder> (JNIEnv.CallObjectMethod  (Handle, id_threadPoolSize_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.ImageLoaderConfiguration.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_threadPoolSize_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			}

			static Delegate cb_threadPriority_I;
#pragma warning disable 0169
			static Delegate GetThreadPriority_IHandler ()
			{
				if (cb_threadPriority_I == null)
					cb_threadPriority_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_ThreadPriority_I);
				return cb_threadPriority_I;
			}

			static IntPtr n_ThreadPriority_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Nostra13.Universalimageloader.Core.ImageLoaderConfiguration.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.ImageLoaderConfiguration.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.ThreadPriority (p0));
			}
#pragma warning restore 0169

			static IntPtr id_threadPriority_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='ImageLoaderConfiguration.Builder']/method[@name='threadPriority' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("threadPriority", "(I)Lcom/nostra13/universalimageloader/core/ImageLoaderConfiguration$Builder;", "GetThreadPriority_IHandler")]
			public virtual global::Com.Nostra13.Universalimageloader.Core.ImageLoaderConfiguration.Builder ThreadPriority (int p0)
			{
				if (id_threadPriority_I == IntPtr.Zero)
					id_threadPriority_I = JNIEnv.GetMethodID (class_ref, "threadPriority", "(I)Lcom/nostra13/universalimageloader/core/ImageLoaderConfiguration$Builder;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.ImageLoaderConfiguration.Builder> (JNIEnv.CallObjectMethod  (Handle, id_threadPriority_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.ImageLoaderConfiguration.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_threadPriority_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/nostra13/universalimageloader/core/ImageLoaderConfiguration", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ImageLoaderConfiguration); }
		}

		internal ImageLoaderConfiguration (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_createDefault_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='ImageLoaderConfiguration']/method[@name='createDefault' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("createDefault", "(Landroid/content/Context;)Lcom/nostra13/universalimageloader/core/ImageLoaderConfiguration;", "")]
		public static global::Com.Nostra13.Universalimageloader.Core.ImageLoaderConfiguration CreateDefault (global::Android.Content.Context p0)
		{
			if (id_createDefault_Landroid_content_Context_ == IntPtr.Zero)
				id_createDefault_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "createDefault", "(Landroid/content/Context;)Lcom/nostra13/universalimageloader/core/ImageLoaderConfiguration;");
			global::Com.Nostra13.Universalimageloader.Core.ImageLoaderConfiguration __ret = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.ImageLoaderConfiguration> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createDefault_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}
}
