using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nostra13.Universalimageloader.Core.Assist {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist']/class[@name='DiscCacheUtil']"
	[global::Android.Runtime.Register ("com/nostra13/universalimageloader/core/assist/DiscCacheUtil", DoNotGenerateAcw=true)]
	public sealed partial class DiscCacheUtil : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/nostra13/universalimageloader/core/assist/DiscCacheUtil", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DiscCacheUtil); }
		}

		internal DiscCacheUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_findInCache_Ljava_lang_String_Lcom_nostra13_universalimageloader_cache_disc_DiscCacheAware_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist']/class[@name='DiscCacheUtil']/method[@name='findInCache' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.nostra13.universalimageloader.cache.disc.DiscCacheAware']]"
		[Register ("findInCache", "(Ljava/lang/String;Lcom/nostra13/universalimageloader/cache/disc/DiscCacheAware;)Ljava/io/File;", "")]
		public static global::Java.IO.File FindInCache (string p0, global::Com.Nostra13.Universalimageloader.Cache.Disc.IDiscCacheAware p1)
		{
			if (id_findInCache_Ljava_lang_String_Lcom_nostra13_universalimageloader_cache_disc_DiscCacheAware_ == IntPtr.Zero)
				id_findInCache_Ljava_lang_String_Lcom_nostra13_universalimageloader_cache_disc_DiscCacheAware_ = JNIEnv.GetStaticMethodID (class_ref, "findInCache", "(Ljava/lang/String;Lcom/nostra13/universalimageloader/cache/disc/DiscCacheAware;)Ljava/io/File;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Java.IO.File __ret = global::Java.Lang.Object.GetObject<global::Java.IO.File> (JNIEnv.CallStaticObjectMethod  (class_ref, id_findInCache_Ljava_lang_String_Lcom_nostra13_universalimageloader_cache_disc_DiscCacheAware_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_removeFromCache_Ljava_lang_String_Lcom_nostra13_universalimageloader_cache_disc_DiscCacheAware_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist']/class[@name='DiscCacheUtil']/method[@name='removeFromCache' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.nostra13.universalimageloader.cache.disc.DiscCacheAware']]"
		[Register ("removeFromCache", "(Ljava/lang/String;Lcom/nostra13/universalimageloader/cache/disc/DiscCacheAware;)Z", "")]
		public static bool RemoveFromCache (string p0, global::Com.Nostra13.Universalimageloader.Cache.Disc.IDiscCacheAware p1)
		{
			if (id_removeFromCache_Ljava_lang_String_Lcom_nostra13_universalimageloader_cache_disc_DiscCacheAware_ == IntPtr.Zero)
				id_removeFromCache_Ljava_lang_String_Lcom_nostra13_universalimageloader_cache_disc_DiscCacheAware_ = JNIEnv.GetStaticMethodID (class_ref, "removeFromCache", "(Ljava/lang/String;Lcom/nostra13/universalimageloader/cache/disc/DiscCacheAware;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_removeFromCache_Ljava_lang_String_Lcom_nostra13_universalimageloader_cache_disc_DiscCacheAware_, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}
}
