using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nostra13.Universalimageloader.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='DisplayImageOptions']"
	[global::Android.Runtime.Register ("com/nostra13/universalimageloader/core/DisplayImageOptions", DoNotGenerateAcw=true)]
	public sealed partial class DisplayImageOptions : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='DisplayImageOptions.Builder']"
		[global::Android.Runtime.Register ("com/nostra13/universalimageloader/core/DisplayImageOptions$Builder", DoNotGenerateAcw=true)]
		public partial class Builder : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/nostra13/universalimageloader/core/DisplayImageOptions$Builder", ref java_class_handle);
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
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='DisplayImageOptions.Builder']/constructor[@name='DisplayImageOptions.Builder' and count(parameter)=0]"
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

			static Delegate cb_bitmapConfig_Landroid_graphics_Bitmap_Config_;
#pragma warning disable 0169
			static Delegate GetBitmapConfig_Landroid_graphics_Bitmap_Config_Handler ()
			{
				if (cb_bitmapConfig_Landroid_graphics_Bitmap_Config_ == null)
					cb_bitmapConfig_Landroid_graphics_Bitmap_Config_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_BitmapConfig_Landroid_graphics_Bitmap_Config_);
				return cb_bitmapConfig_Landroid_graphics_Bitmap_Config_;
			}

			static IntPtr n_BitmapConfig_Landroid_graphics_Bitmap_Config_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Graphics.Bitmap.Config p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap.Config> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.BitmapConfig (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_bitmapConfig_Landroid_graphics_Bitmap_Config_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='DisplayImageOptions.Builder']/method[@name='bitmapConfig' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap.Config']]"
			[Register ("bitmapConfig", "(Landroid/graphics/Bitmap$Config;)Lcom/nostra13/universalimageloader/core/DisplayImageOptions$Builder;", "GetBitmapConfig_Landroid_graphics_Bitmap_Config_Handler")]
			public virtual global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions.Builder BitmapConfig (global::Android.Graphics.Bitmap.Config p0)
			{
				if (id_bitmapConfig_Landroid_graphics_Bitmap_Config_ == IntPtr.Zero)
					id_bitmapConfig_Landroid_graphics_Bitmap_Config_ = JNIEnv.GetMethodID (class_ref, "bitmapConfig", "(Landroid/graphics/Bitmap$Config;)Lcom/nostra13/universalimageloader/core/DisplayImageOptions$Builder;");

				global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions.Builder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions.Builder> (JNIEnv.CallObjectMethod  (Handle, id_bitmapConfig_Landroid_graphics_Bitmap_Config_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_bitmapConfig_Landroid_graphics_Bitmap_Config_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return __ret;
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
				global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Build ());
			}
#pragma warning restore 0169

			static IntPtr id_build;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='DisplayImageOptions.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/nostra13/universalimageloader/core/DisplayImageOptions;", "GetBuildHandler")]
			public virtual global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions Build ()
			{
				if (id_build == IntPtr.Zero)
					id_build = JNIEnv.GetMethodID (class_ref, "build", "()Lcom/nostra13/universalimageloader/core/DisplayImageOptions;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions> (JNIEnv.CallObjectMethod  (Handle, id_build), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_build), JniHandleOwnership.TransferLocalRef);
			}

			static Delegate cb_cacheInMemory;
#pragma warning disable 0169
			static Delegate GetCacheInMemoryHandler ()
			{
				if (cb_cacheInMemory == null)
					cb_cacheInMemory = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_CacheInMemory);
				return cb_cacheInMemory;
			}

			static IntPtr n_CacheInMemory (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.CacheInMemory ());
			}
#pragma warning restore 0169

			static IntPtr id_cacheInMemory;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='DisplayImageOptions.Builder']/method[@name='cacheInMemory' and count(parameter)=0]"
			[Register ("cacheInMemory", "()Lcom/nostra13/universalimageloader/core/DisplayImageOptions$Builder;", "GetCacheInMemoryHandler")]
			public virtual global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions.Builder CacheInMemory ()
			{
				if (id_cacheInMemory == IntPtr.Zero)
					id_cacheInMemory = JNIEnv.GetMethodID (class_ref, "cacheInMemory", "()Lcom/nostra13/universalimageloader/core/DisplayImageOptions$Builder;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions.Builder> (JNIEnv.CallObjectMethod  (Handle, id_cacheInMemory), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_cacheInMemory), JniHandleOwnership.TransferLocalRef);
			}

			static Delegate cb_cacheOnDisc;
#pragma warning disable 0169
			static Delegate GetCacheOnDiscHandler ()
			{
				if (cb_cacheOnDisc == null)
					cb_cacheOnDisc = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_CacheOnDisc);
				return cb_cacheOnDisc;
			}

			static IntPtr n_CacheOnDisc (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.CacheOnDisc ());
			}
#pragma warning restore 0169

			static IntPtr id_cacheOnDisc;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='DisplayImageOptions.Builder']/method[@name='cacheOnDisc' and count(parameter)=0]"
			[Register ("cacheOnDisc", "()Lcom/nostra13/universalimageloader/core/DisplayImageOptions$Builder;", "GetCacheOnDiscHandler")]
			public virtual global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions.Builder CacheOnDisc ()
			{
				if (id_cacheOnDisc == IntPtr.Zero)
					id_cacheOnDisc = JNIEnv.GetMethodID (class_ref, "cacheOnDisc", "()Lcom/nostra13/universalimageloader/core/DisplayImageOptions$Builder;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions.Builder> (JNIEnv.CallObjectMethod  (Handle, id_cacheOnDisc), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_cacheOnDisc), JniHandleOwnership.TransferLocalRef);
			}

			static Delegate cb_cloneFrom_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_;
#pragma warning disable 0169
			static Delegate GetCloneFrom_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_Handler ()
			{
				if (cb_cloneFrom_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_ == null)
					cb_cloneFrom_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_CloneFrom_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_);
				return cb_cloneFrom_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_;
			}

			static IntPtr n_CloneFrom_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions p0 = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CloneFrom (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_cloneFrom_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='DisplayImageOptions.Builder']/method[@name='cloneFrom' and count(parameter)=1 and parameter[1][@type='com.nostra13.universalimageloader.core.DisplayImageOptions']]"
			[Register ("cloneFrom", "(Lcom/nostra13/universalimageloader/core/DisplayImageOptions;)Lcom/nostra13/universalimageloader/core/DisplayImageOptions$Builder;", "GetCloneFrom_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_Handler")]
			public virtual global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions.Builder CloneFrom (global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions p0)
			{
				if (id_cloneFrom_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_ == IntPtr.Zero)
					id_cloneFrom_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_ = JNIEnv.GetMethodID (class_ref, "cloneFrom", "(Lcom/nostra13/universalimageloader/core/DisplayImageOptions;)Lcom/nostra13/universalimageloader/core/DisplayImageOptions$Builder;");

				global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions.Builder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions.Builder> (JNIEnv.CallObjectMethod  (Handle, id_cloneFrom_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_cloneFrom_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static Delegate cb_decodingOptions_Landroid_graphics_BitmapFactory_Options_;
#pragma warning disable 0169
			static Delegate GetDecodingOptions_Landroid_graphics_BitmapFactory_Options_Handler ()
			{
				if (cb_decodingOptions_Landroid_graphics_BitmapFactory_Options_ == null)
					cb_decodingOptions_Landroid_graphics_BitmapFactory_Options_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_DecodingOptions_Landroid_graphics_BitmapFactory_Options_);
				return cb_decodingOptions_Landroid_graphics_BitmapFactory_Options_;
			}

			static IntPtr n_DecodingOptions_Landroid_graphics_BitmapFactory_Options_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Graphics.BitmapFactory.Options p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.BitmapFactory.Options> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DecodingOptions (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_decodingOptions_Landroid_graphics_BitmapFactory_Options_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='DisplayImageOptions.Builder']/method[@name='decodingOptions' and count(parameter)=1 and parameter[1][@type='android.graphics.BitmapFactory.Options']]"
			[Register ("decodingOptions", "(Landroid/graphics/BitmapFactory$Options;)Lcom/nostra13/universalimageloader/core/DisplayImageOptions$Builder;", "GetDecodingOptions_Landroid_graphics_BitmapFactory_Options_Handler")]
			public virtual global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions.Builder DecodingOptions (global::Android.Graphics.BitmapFactory.Options p0)
			{
				if (id_decodingOptions_Landroid_graphics_BitmapFactory_Options_ == IntPtr.Zero)
					id_decodingOptions_Landroid_graphics_BitmapFactory_Options_ = JNIEnv.GetMethodID (class_ref, "decodingOptions", "(Landroid/graphics/BitmapFactory$Options;)Lcom/nostra13/universalimageloader/core/DisplayImageOptions$Builder;");

				global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions.Builder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions.Builder> (JNIEnv.CallObjectMethod  (Handle, id_decodingOptions_Landroid_graphics_BitmapFactory_Options_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_decodingOptions_Landroid_graphics_BitmapFactory_Options_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static Delegate cb_delayBeforeLoading_I;
#pragma warning disable 0169
			static Delegate GetDelayBeforeLoading_IHandler ()
			{
				if (cb_delayBeforeLoading_I == null)
					cb_delayBeforeLoading_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_DelayBeforeLoading_I);
				return cb_delayBeforeLoading_I;
			}

			static IntPtr n_DelayBeforeLoading_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.DelayBeforeLoading (p0));
			}
#pragma warning restore 0169

			static IntPtr id_delayBeforeLoading_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='DisplayImageOptions.Builder']/method[@name='delayBeforeLoading' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("delayBeforeLoading", "(I)Lcom/nostra13/universalimageloader/core/DisplayImageOptions$Builder;", "GetDelayBeforeLoading_IHandler")]
			public virtual global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions.Builder DelayBeforeLoading (int p0)
			{
				if (id_delayBeforeLoading_I == IntPtr.Zero)
					id_delayBeforeLoading_I = JNIEnv.GetMethodID (class_ref, "delayBeforeLoading", "(I)Lcom/nostra13/universalimageloader/core/DisplayImageOptions$Builder;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions.Builder> (JNIEnv.CallObjectMethod  (Handle, id_delayBeforeLoading_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_delayBeforeLoading_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			}

			static Delegate cb_displayer_Lcom_nostra13_universalimageloader_core_display_BitmapDisplayer_;
#pragma warning disable 0169
			static Delegate GetDisplayer_Lcom_nostra13_universalimageloader_core_display_BitmapDisplayer_Handler ()
			{
				if (cb_displayer_Lcom_nostra13_universalimageloader_core_display_BitmapDisplayer_ == null)
					cb_displayer_Lcom_nostra13_universalimageloader_core_display_BitmapDisplayer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Displayer_Lcom_nostra13_universalimageloader_core_display_BitmapDisplayer_);
				return cb_displayer_Lcom_nostra13_universalimageloader_core_display_BitmapDisplayer_;
			}

			static IntPtr n_Displayer_Lcom_nostra13_universalimageloader_core_display_BitmapDisplayer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Nostra13.Universalimageloader.Core.Display.IBitmapDisplayer p0 = (global::Com.Nostra13.Universalimageloader.Core.Display.IBitmapDisplayer)global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Display.IBitmapDisplayer> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Displayer (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_displayer_Lcom_nostra13_universalimageloader_core_display_BitmapDisplayer_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='DisplayImageOptions.Builder']/method[@name='displayer' and count(parameter)=1 and parameter[1][@type='com.nostra13.universalimageloader.core.display.BitmapDisplayer']]"
			[Register ("displayer", "(Lcom/nostra13/universalimageloader/core/display/BitmapDisplayer;)Lcom/nostra13/universalimageloader/core/DisplayImageOptions$Builder;", "GetDisplayer_Lcom_nostra13_universalimageloader_core_display_BitmapDisplayer_Handler")]
			public virtual global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions.Builder Displayer (global::Com.Nostra13.Universalimageloader.Core.Display.IBitmapDisplayer p0)
			{
				if (id_displayer_Lcom_nostra13_universalimageloader_core_display_BitmapDisplayer_ == IntPtr.Zero)
					id_displayer_Lcom_nostra13_universalimageloader_core_display_BitmapDisplayer_ = JNIEnv.GetMethodID (class_ref, "displayer", "(Lcom/nostra13/universalimageloader/core/display/BitmapDisplayer;)Lcom/nostra13/universalimageloader/core/DisplayImageOptions$Builder;");

				global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions.Builder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions.Builder> (JNIEnv.CallObjectMethod  (Handle, id_displayer_Lcom_nostra13_universalimageloader_core_display_BitmapDisplayer_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_displayer_Lcom_nostra13_universalimageloader_core_display_BitmapDisplayer_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static Delegate cb_extraForDownloader_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetExtraForDownloader_Ljava_lang_Object_Handler ()
			{
				if (cb_extraForDownloader_Ljava_lang_Object_ == null)
					cb_extraForDownloader_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ExtraForDownloader_Ljava_lang_Object_);
				return cb_extraForDownloader_Ljava_lang_Object_;
			}

			static IntPtr n_ExtraForDownloader_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ExtraForDownloader (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_extraForDownloader_Ljava_lang_Object_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='DisplayImageOptions.Builder']/method[@name='extraForDownloader' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
			[Register ("extraForDownloader", "(Ljava/lang/Object;)Lcom/nostra13/universalimageloader/core/DisplayImageOptions$Builder;", "GetExtraForDownloader_Ljava_lang_Object_Handler")]
			public virtual global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions.Builder ExtraForDownloader (global::Java.Lang.Object p0)
			{
				if (id_extraForDownloader_Ljava_lang_Object_ == IntPtr.Zero)
					id_extraForDownloader_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "extraForDownloader", "(Ljava/lang/Object;)Lcom/nostra13/universalimageloader/core/DisplayImageOptions$Builder;");

				global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions.Builder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions.Builder> (JNIEnv.CallObjectMethod  (Handle, id_extraForDownloader_Ljava_lang_Object_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_extraForDownloader_Ljava_lang_Object_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static Delegate cb_handler_Landroid_os_Handler_;
#pragma warning disable 0169
			static Delegate GetHandler_Landroid_os_Handler_Handler ()
			{
				if (cb_handler_Landroid_os_Handler_ == null)
					cb_handler_Landroid_os_Handler_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Handler_Landroid_os_Handler_);
				return cb_handler_Landroid_os_Handler_;
			}

			static IntPtr n_Handler_Landroid_os_Handler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.Handler p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Handler> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Handler (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_handler_Landroid_os_Handler_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='DisplayImageOptions.Builder']/method[@name='handler' and count(parameter)=1 and parameter[1][@type='android.os.Handler']]"
			[Register ("handler", "(Landroid/os/Handler;)Lcom/nostra13/universalimageloader/core/DisplayImageOptions$Builder;", "GetHandler_Landroid_os_Handler_Handler")]
			public virtual global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions.Builder Handler (global::Android.OS.Handler p0)
			{
				if (id_handler_Landroid_os_Handler_ == IntPtr.Zero)
					id_handler_Landroid_os_Handler_ = JNIEnv.GetMethodID (class_ref, "handler", "(Landroid/os/Handler;)Lcom/nostra13/universalimageloader/core/DisplayImageOptions$Builder;");

				global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions.Builder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions.Builder> (JNIEnv.CallObjectMethod  (Handle, id_handler_Landroid_os_Handler_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_handler_Landroid_os_Handler_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static Delegate cb_imageScaleType_Lcom_nostra13_universalimageloader_core_assist_ImageScaleType_;
#pragma warning disable 0169
			static Delegate GetImageScaleType_Lcom_nostra13_universalimageloader_core_assist_ImageScaleType_Handler ()
			{
				if (cb_imageScaleType_Lcom_nostra13_universalimageloader_core_assist_ImageScaleType_ == null)
					cb_imageScaleType_Lcom_nostra13_universalimageloader_core_assist_ImageScaleType_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ImageScaleType_Lcom_nostra13_universalimageloader_core_assist_ImageScaleType_);
				return cb_imageScaleType_Lcom_nostra13_universalimageloader_core_assist_ImageScaleType_;
			}

			static IntPtr n_ImageScaleType_Lcom_nostra13_universalimageloader_core_assist_ImageScaleType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Nostra13.Universalimageloader.Core.Assist.ImageScaleType p0 = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.ImageScaleType> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ImageScaleType (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_imageScaleType_Lcom_nostra13_universalimageloader_core_assist_ImageScaleType_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='DisplayImageOptions.Builder']/method[@name='imageScaleType' and count(parameter)=1 and parameter[1][@type='com.nostra13.universalimageloader.core.assist.ImageScaleType']]"
			[Register ("imageScaleType", "(Lcom/nostra13/universalimageloader/core/assist/ImageScaleType;)Lcom/nostra13/universalimageloader/core/DisplayImageOptions$Builder;", "GetImageScaleType_Lcom_nostra13_universalimageloader_core_assist_ImageScaleType_Handler")]
			public virtual global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions.Builder ImageScaleType (global::Com.Nostra13.Universalimageloader.Core.Assist.ImageScaleType p0)
			{
				if (id_imageScaleType_Lcom_nostra13_universalimageloader_core_assist_ImageScaleType_ == IntPtr.Zero)
					id_imageScaleType_Lcom_nostra13_universalimageloader_core_assist_ImageScaleType_ = JNIEnv.GetMethodID (class_ref, "imageScaleType", "(Lcom/nostra13/universalimageloader/core/assist/ImageScaleType;)Lcom/nostra13/universalimageloader/core/DisplayImageOptions$Builder;");

				global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions.Builder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions.Builder> (JNIEnv.CallObjectMethod  (Handle, id_imageScaleType_Lcom_nostra13_universalimageloader_core_assist_ImageScaleType_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_imageScaleType_Lcom_nostra13_universalimageloader_core_assist_ImageScaleType_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static Delegate cb_postProcessor_Lcom_nostra13_universalimageloader_core_process_BitmapProcessor_;
#pragma warning disable 0169
			static Delegate GetPostProcessor_Lcom_nostra13_universalimageloader_core_process_BitmapProcessor_Handler ()
			{
				if (cb_postProcessor_Lcom_nostra13_universalimageloader_core_process_BitmapProcessor_ == null)
					cb_postProcessor_Lcom_nostra13_universalimageloader_core_process_BitmapProcessor_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_PostProcessor_Lcom_nostra13_universalimageloader_core_process_BitmapProcessor_);
				return cb_postProcessor_Lcom_nostra13_universalimageloader_core_process_BitmapProcessor_;
			}

			static IntPtr n_PostProcessor_Lcom_nostra13_universalimageloader_core_process_BitmapProcessor_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Nostra13.Universalimageloader.Core.Process.IBitmapProcessor p0 = (global::Com.Nostra13.Universalimageloader.Core.Process.IBitmapProcessor)global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Process.IBitmapProcessor> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PostProcessor (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_postProcessor_Lcom_nostra13_universalimageloader_core_process_BitmapProcessor_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='DisplayImageOptions.Builder']/method[@name='postProcessor' and count(parameter)=1 and parameter[1][@type='com.nostra13.universalimageloader.core.process.BitmapProcessor']]"
			[Register ("postProcessor", "(Lcom/nostra13/universalimageloader/core/process/BitmapProcessor;)Lcom/nostra13/universalimageloader/core/DisplayImageOptions$Builder;", "GetPostProcessor_Lcom_nostra13_universalimageloader_core_process_BitmapProcessor_Handler")]
			public virtual global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions.Builder PostProcessor (global::Com.Nostra13.Universalimageloader.Core.Process.IBitmapProcessor p0)
			{
				if (id_postProcessor_Lcom_nostra13_universalimageloader_core_process_BitmapProcessor_ == IntPtr.Zero)
					id_postProcessor_Lcom_nostra13_universalimageloader_core_process_BitmapProcessor_ = JNIEnv.GetMethodID (class_ref, "postProcessor", "(Lcom/nostra13/universalimageloader/core/process/BitmapProcessor;)Lcom/nostra13/universalimageloader/core/DisplayImageOptions$Builder;");

				global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions.Builder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions.Builder> (JNIEnv.CallObjectMethod  (Handle, id_postProcessor_Lcom_nostra13_universalimageloader_core_process_BitmapProcessor_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_postProcessor_Lcom_nostra13_universalimageloader_core_process_BitmapProcessor_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static Delegate cb_preProcessor_Lcom_nostra13_universalimageloader_core_process_BitmapProcessor_;
#pragma warning disable 0169
			static Delegate GetPreProcessor_Lcom_nostra13_universalimageloader_core_process_BitmapProcessor_Handler ()
			{
				if (cb_preProcessor_Lcom_nostra13_universalimageloader_core_process_BitmapProcessor_ == null)
					cb_preProcessor_Lcom_nostra13_universalimageloader_core_process_BitmapProcessor_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_PreProcessor_Lcom_nostra13_universalimageloader_core_process_BitmapProcessor_);
				return cb_preProcessor_Lcom_nostra13_universalimageloader_core_process_BitmapProcessor_;
			}

			static IntPtr n_PreProcessor_Lcom_nostra13_universalimageloader_core_process_BitmapProcessor_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Nostra13.Universalimageloader.Core.Process.IBitmapProcessor p0 = (global::Com.Nostra13.Universalimageloader.Core.Process.IBitmapProcessor)global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Process.IBitmapProcessor> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PreProcessor (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_preProcessor_Lcom_nostra13_universalimageloader_core_process_BitmapProcessor_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='DisplayImageOptions.Builder']/method[@name='preProcessor' and count(parameter)=1 and parameter[1][@type='com.nostra13.universalimageloader.core.process.BitmapProcessor']]"
			[Register ("preProcessor", "(Lcom/nostra13/universalimageloader/core/process/BitmapProcessor;)Lcom/nostra13/universalimageloader/core/DisplayImageOptions$Builder;", "GetPreProcessor_Lcom_nostra13_universalimageloader_core_process_BitmapProcessor_Handler")]
			public virtual global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions.Builder PreProcessor (global::Com.Nostra13.Universalimageloader.Core.Process.IBitmapProcessor p0)
			{
				if (id_preProcessor_Lcom_nostra13_universalimageloader_core_process_BitmapProcessor_ == IntPtr.Zero)
					id_preProcessor_Lcom_nostra13_universalimageloader_core_process_BitmapProcessor_ = JNIEnv.GetMethodID (class_ref, "preProcessor", "(Lcom/nostra13/universalimageloader/core/process/BitmapProcessor;)Lcom/nostra13/universalimageloader/core/DisplayImageOptions$Builder;");

				global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions.Builder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions.Builder> (JNIEnv.CallObjectMethod  (Handle, id_preProcessor_Lcom_nostra13_universalimageloader_core_process_BitmapProcessor_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_preProcessor_Lcom_nostra13_universalimageloader_core_process_BitmapProcessor_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static Delegate cb_resetViewBeforeLoading;
#pragma warning disable 0169
			static Delegate GetResetViewBeforeLoadingHandler ()
			{
				if (cb_resetViewBeforeLoading == null)
					cb_resetViewBeforeLoading = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ResetViewBeforeLoading);
				return cb_resetViewBeforeLoading;
			}

			static IntPtr n_ResetViewBeforeLoading (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.ResetViewBeforeLoading ());
			}
#pragma warning restore 0169

			static IntPtr id_resetViewBeforeLoading;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='DisplayImageOptions.Builder']/method[@name='resetViewBeforeLoading' and count(parameter)=0]"
			[Register ("resetViewBeforeLoading", "()Lcom/nostra13/universalimageloader/core/DisplayImageOptions$Builder;", "GetResetViewBeforeLoadingHandler")]
			public virtual global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions.Builder ResetViewBeforeLoading ()
			{
				if (id_resetViewBeforeLoading == IntPtr.Zero)
					id_resetViewBeforeLoading = JNIEnv.GetMethodID (class_ref, "resetViewBeforeLoading", "()Lcom/nostra13/universalimageloader/core/DisplayImageOptions$Builder;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions.Builder> (JNIEnv.CallObjectMethod  (Handle, id_resetViewBeforeLoading), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_resetViewBeforeLoading), JniHandleOwnership.TransferLocalRef);
			}

			static Delegate cb_showImageForEmptyUri_I;
#pragma warning disable 0169
			static Delegate GetShowImageForEmptyUri_IHandler ()
			{
				if (cb_showImageForEmptyUri_I == null)
					cb_showImageForEmptyUri_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_ShowImageForEmptyUri_I);
				return cb_showImageForEmptyUri_I;
			}

			static IntPtr n_ShowImageForEmptyUri_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.ShowImageForEmptyUri (p0));
			}
#pragma warning restore 0169

			static IntPtr id_showImageForEmptyUri_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='DisplayImageOptions.Builder']/method[@name='showImageForEmptyUri' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("showImageForEmptyUri", "(I)Lcom/nostra13/universalimageloader/core/DisplayImageOptions$Builder;", "GetShowImageForEmptyUri_IHandler")]
			public virtual global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions.Builder ShowImageForEmptyUri (int p0)
			{
				if (id_showImageForEmptyUri_I == IntPtr.Zero)
					id_showImageForEmptyUri_I = JNIEnv.GetMethodID (class_ref, "showImageForEmptyUri", "(I)Lcom/nostra13/universalimageloader/core/DisplayImageOptions$Builder;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions.Builder> (JNIEnv.CallObjectMethod  (Handle, id_showImageForEmptyUri_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_showImageForEmptyUri_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			}

			static Delegate cb_showImageOnFail_I;
#pragma warning disable 0169
			static Delegate GetShowImageOnFail_IHandler ()
			{
				if (cb_showImageOnFail_I == null)
					cb_showImageOnFail_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_ShowImageOnFail_I);
				return cb_showImageOnFail_I;
			}

			static IntPtr n_ShowImageOnFail_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.ShowImageOnFail (p0));
			}
#pragma warning restore 0169

			static IntPtr id_showImageOnFail_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='DisplayImageOptions.Builder']/method[@name='showImageOnFail' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("showImageOnFail", "(I)Lcom/nostra13/universalimageloader/core/DisplayImageOptions$Builder;", "GetShowImageOnFail_IHandler")]
			public virtual global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions.Builder ShowImageOnFail (int p0)
			{
				if (id_showImageOnFail_I == IntPtr.Zero)
					id_showImageOnFail_I = JNIEnv.GetMethodID (class_ref, "showImageOnFail", "(I)Lcom/nostra13/universalimageloader/core/DisplayImageOptions$Builder;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions.Builder> (JNIEnv.CallObjectMethod  (Handle, id_showImageOnFail_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_showImageOnFail_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			}

			static Delegate cb_showStubImage_I;
#pragma warning disable 0169
			static Delegate GetShowStubImage_IHandler ()
			{
				if (cb_showStubImage_I == null)
					cb_showStubImage_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_ShowStubImage_I);
				return cb_showStubImage_I;
			}

			static IntPtr n_ShowStubImage_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.ShowStubImage (p0));
			}
#pragma warning restore 0169

			static IntPtr id_showStubImage_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='DisplayImageOptions.Builder']/method[@name='showStubImage' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("showStubImage", "(I)Lcom/nostra13/universalimageloader/core/DisplayImageOptions$Builder;", "GetShowStubImage_IHandler")]
			public virtual global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions.Builder ShowStubImage (int p0)
			{
				if (id_showStubImage_I == IntPtr.Zero)
					id_showStubImage_I = JNIEnv.GetMethodID (class_ref, "showStubImage", "(I)Lcom/nostra13/universalimageloader/core/DisplayImageOptions$Builder;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions.Builder> (JNIEnv.CallObjectMethod  (Handle, id_showStubImage_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_showStubImage_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/nostra13/universalimageloader/core/DisplayImageOptions", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DisplayImageOptions); }
		}

		internal DisplayImageOptions (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getDecodingOptions;
		public global::Android.Graphics.BitmapFactory.Options DecodingOptions {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='DisplayImageOptions']/method[@name='getDecodingOptions' and count(parameter)=0]"
			[Register ("getDecodingOptions", "()Landroid/graphics/BitmapFactory$Options;", "GetGetDecodingOptionsHandler")]
			get {
				if (id_getDecodingOptions == IntPtr.Zero)
					id_getDecodingOptions = JNIEnv.GetMethodID (class_ref, "getDecodingOptions", "()Landroid/graphics/BitmapFactory$Options;");
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.BitmapFactory.Options> (JNIEnv.CallObjectMethod  (Handle, id_getDecodingOptions), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getDelayBeforeLoading;
		public int DelayBeforeLoading {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='DisplayImageOptions']/method[@name='getDelayBeforeLoading' and count(parameter)=0]"
			[Register ("getDelayBeforeLoading", "()I", "GetGetDelayBeforeLoadingHandler")]
			get {
				if (id_getDelayBeforeLoading == IntPtr.Zero)
					id_getDelayBeforeLoading = JNIEnv.GetMethodID (class_ref, "getDelayBeforeLoading", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_getDelayBeforeLoading);
			}
		}

		static IntPtr id_getDisplayer;
		public global::Com.Nostra13.Universalimageloader.Core.Display.IBitmapDisplayer Displayer {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='DisplayImageOptions']/method[@name='getDisplayer' and count(parameter)=0]"
			[Register ("getDisplayer", "()Lcom/nostra13/universalimageloader/core/display/BitmapDisplayer;", "GetGetDisplayerHandler")]
			get {
				if (id_getDisplayer == IntPtr.Zero)
					id_getDisplayer = JNIEnv.GetMethodID (class_ref, "getDisplayer", "()Lcom/nostra13/universalimageloader/core/display/BitmapDisplayer;");
				return global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Display.IBitmapDisplayer> (JNIEnv.CallObjectMethod  (Handle, id_getDisplayer), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getExtraForDownloader;
		public global::Java.Lang.Object ExtraForDownloader {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='DisplayImageOptions']/method[@name='getExtraForDownloader' and count(parameter)=0]"
			[Register ("getExtraForDownloader", "()Ljava/lang/Object;", "GetGetExtraForDownloaderHandler")]
			get {
				if (id_getExtraForDownloader == IntPtr.Zero)
					id_getExtraForDownloader = JNIEnv.GetMethodID (class_ref, "getExtraForDownloader", "()Ljava/lang/Object;");
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_getExtraForDownloader), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getHandler;
		public global::Android.OS.Handler Handler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='DisplayImageOptions']/method[@name='getHandler' and count(parameter)=0]"
			[Register ("getHandler", "()Landroid/os/Handler;", "GetGetHandlerHandler")]
			get {
				if (id_getHandler == IntPtr.Zero)
					id_getHandler = JNIEnv.GetMethodID (class_ref, "getHandler", "()Landroid/os/Handler;");
				return global::Java.Lang.Object.GetObject<global::Android.OS.Handler> (JNIEnv.CallObjectMethod  (Handle, id_getHandler), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getImageForEmptyUri;
		public int ImageForEmptyUri {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='DisplayImageOptions']/method[@name='getImageForEmptyUri' and count(parameter)=0]"
			[Register ("getImageForEmptyUri", "()I", "GetGetImageForEmptyUriHandler")]
			get {
				if (id_getImageForEmptyUri == IntPtr.Zero)
					id_getImageForEmptyUri = JNIEnv.GetMethodID (class_ref, "getImageForEmptyUri", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_getImageForEmptyUri);
			}
		}

		static IntPtr id_getImageOnFail;
		public int ImageOnFail {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='DisplayImageOptions']/method[@name='getImageOnFail' and count(parameter)=0]"
			[Register ("getImageOnFail", "()I", "GetGetImageOnFailHandler")]
			get {
				if (id_getImageOnFail == IntPtr.Zero)
					id_getImageOnFail = JNIEnv.GetMethodID (class_ref, "getImageOnFail", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_getImageOnFail);
			}
		}

		static IntPtr id_getImageScaleType;
		public global::Com.Nostra13.Universalimageloader.Core.Assist.ImageScaleType ImageScaleType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='DisplayImageOptions']/method[@name='getImageScaleType' and count(parameter)=0]"
			[Register ("getImageScaleType", "()Lcom/nostra13/universalimageloader/core/assist/ImageScaleType;", "GetGetImageScaleTypeHandler")]
			get {
				if (id_getImageScaleType == IntPtr.Zero)
					id_getImageScaleType = JNIEnv.GetMethodID (class_ref, "getImageScaleType", "()Lcom/nostra13/universalimageloader/core/assist/ImageScaleType;");
				return global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.ImageScaleType> (JNIEnv.CallObjectMethod  (Handle, id_getImageScaleType), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_isCacheInMemory;
		public bool IsCacheInMemory {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='DisplayImageOptions']/method[@name='isCacheInMemory' and count(parameter)=0]"
			[Register ("isCacheInMemory", "()Z", "GetIsCacheInMemoryHandler")]
			get {
				if (id_isCacheInMemory == IntPtr.Zero)
					id_isCacheInMemory = JNIEnv.GetMethodID (class_ref, "isCacheInMemory", "()Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_isCacheInMemory);
			}
		}

		static IntPtr id_isCacheOnDisc;
		public bool IsCacheOnDisc {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='DisplayImageOptions']/method[@name='isCacheOnDisc' and count(parameter)=0]"
			[Register ("isCacheOnDisc", "()Z", "GetIsCacheOnDiscHandler")]
			get {
				if (id_isCacheOnDisc == IntPtr.Zero)
					id_isCacheOnDisc = JNIEnv.GetMethodID (class_ref, "isCacheOnDisc", "()Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_isCacheOnDisc);
			}
		}

		static IntPtr id_isResetViewBeforeLoading;
		public bool IsResetViewBeforeLoading {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='DisplayImageOptions']/method[@name='isResetViewBeforeLoading' and count(parameter)=0]"
			[Register ("isResetViewBeforeLoading", "()Z", "GetIsResetViewBeforeLoadingHandler")]
			get {
				if (id_isResetViewBeforeLoading == IntPtr.Zero)
					id_isResetViewBeforeLoading = JNIEnv.GetMethodID (class_ref, "isResetViewBeforeLoading", "()Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_isResetViewBeforeLoading);
			}
		}

		static IntPtr id_getPostProcessor;
		public global::Com.Nostra13.Universalimageloader.Core.Process.IBitmapProcessor PostProcessor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='DisplayImageOptions']/method[@name='getPostProcessor' and count(parameter)=0]"
			[Register ("getPostProcessor", "()Lcom/nostra13/universalimageloader/core/process/BitmapProcessor;", "GetGetPostProcessorHandler")]
			get {
				if (id_getPostProcessor == IntPtr.Zero)
					id_getPostProcessor = JNIEnv.GetMethodID (class_ref, "getPostProcessor", "()Lcom/nostra13/universalimageloader/core/process/BitmapProcessor;");
				return global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Process.IBitmapProcessor> (JNIEnv.CallObjectMethod  (Handle, id_getPostProcessor), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getPreProcessor;
		public global::Com.Nostra13.Universalimageloader.Core.Process.IBitmapProcessor PreProcessor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='DisplayImageOptions']/method[@name='getPreProcessor' and count(parameter)=0]"
			[Register ("getPreProcessor", "()Lcom/nostra13/universalimageloader/core/process/BitmapProcessor;", "GetGetPreProcessorHandler")]
			get {
				if (id_getPreProcessor == IntPtr.Zero)
					id_getPreProcessor = JNIEnv.GetMethodID (class_ref, "getPreProcessor", "()Lcom/nostra13/universalimageloader/core/process/BitmapProcessor;");
				return global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Process.IBitmapProcessor> (JNIEnv.CallObjectMethod  (Handle, id_getPreProcessor), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getStubImage;
		public int StubImage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='DisplayImageOptions']/method[@name='getStubImage' and count(parameter)=0]"
			[Register ("getStubImage", "()I", "GetGetStubImageHandler")]
			get {
				if (id_getStubImage == IntPtr.Zero)
					id_getStubImage = JNIEnv.GetMethodID (class_ref, "getStubImage", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_getStubImage);
			}
		}

		static IntPtr id_createSimple;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='DisplayImageOptions']/method[@name='createSimple' and count(parameter)=0]"
		[Register ("createSimple", "()Lcom/nostra13/universalimageloader/core/DisplayImageOptions;", "")]
		public static global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions CreateSimple ()
		{
			if (id_createSimple == IntPtr.Zero)
				id_createSimple = JNIEnv.GetStaticMethodID (class_ref, "createSimple", "()Lcom/nostra13/universalimageloader/core/DisplayImageOptions;");
			return global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createSimple), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_shouldDelayBeforeLoading;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='DisplayImageOptions']/method[@name='shouldDelayBeforeLoading' and count(parameter)=0]"
		[Register ("shouldDelayBeforeLoading", "()Z", "")]
		public bool ShouldDelayBeforeLoading ()
		{
			if (id_shouldDelayBeforeLoading == IntPtr.Zero)
				id_shouldDelayBeforeLoading = JNIEnv.GetMethodID (class_ref, "shouldDelayBeforeLoading", "()Z");
			return JNIEnv.CallBooleanMethod  (Handle, id_shouldDelayBeforeLoading);
		}

		static IntPtr id_shouldPostProcess;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='DisplayImageOptions']/method[@name='shouldPostProcess' and count(parameter)=0]"
		[Register ("shouldPostProcess", "()Z", "")]
		public bool ShouldPostProcess ()
		{
			if (id_shouldPostProcess == IntPtr.Zero)
				id_shouldPostProcess = JNIEnv.GetMethodID (class_ref, "shouldPostProcess", "()Z");
			return JNIEnv.CallBooleanMethod  (Handle, id_shouldPostProcess);
		}

		static IntPtr id_shouldPreProcess;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='DisplayImageOptions']/method[@name='shouldPreProcess' and count(parameter)=0]"
		[Register ("shouldPreProcess", "()Z", "")]
		public bool ShouldPreProcess ()
		{
			if (id_shouldPreProcess == IntPtr.Zero)
				id_shouldPreProcess = JNIEnv.GetMethodID (class_ref, "shouldPreProcess", "()Z");
			return JNIEnv.CallBooleanMethod  (Handle, id_shouldPreProcess);
		}

		static IntPtr id_shouldShowImageForEmptyUri;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='DisplayImageOptions']/method[@name='shouldShowImageForEmptyUri' and count(parameter)=0]"
		[Register ("shouldShowImageForEmptyUri", "()Z", "")]
		public bool ShouldShowImageForEmptyUri ()
		{
			if (id_shouldShowImageForEmptyUri == IntPtr.Zero)
				id_shouldShowImageForEmptyUri = JNIEnv.GetMethodID (class_ref, "shouldShowImageForEmptyUri", "()Z");
			return JNIEnv.CallBooleanMethod  (Handle, id_shouldShowImageForEmptyUri);
		}

		static IntPtr id_shouldShowImageOnFail;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='DisplayImageOptions']/method[@name='shouldShowImageOnFail' and count(parameter)=0]"
		[Register ("shouldShowImageOnFail", "()Z", "")]
		public bool ShouldShowImageOnFail ()
		{
			if (id_shouldShowImageOnFail == IntPtr.Zero)
				id_shouldShowImageOnFail = JNIEnv.GetMethodID (class_ref, "shouldShowImageOnFail", "()Z");
			return JNIEnv.CallBooleanMethod  (Handle, id_shouldShowImageOnFail);
		}

		static IntPtr id_shouldShowStubImage;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='DisplayImageOptions']/method[@name='shouldShowStubImage' and count(parameter)=0]"
		[Register ("shouldShowStubImage", "()Z", "")]
		public bool ShouldShowStubImage ()
		{
			if (id_shouldShowStubImage == IntPtr.Zero)
				id_shouldShowStubImage = JNIEnv.GetMethodID (class_ref, "shouldShowStubImage", "()Z");
			return JNIEnv.CallBooleanMethod  (Handle, id_shouldShowStubImage);
		}

	}
}
