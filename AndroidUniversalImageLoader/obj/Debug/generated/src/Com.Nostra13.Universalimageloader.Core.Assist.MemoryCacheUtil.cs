using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nostra13.Universalimageloader.Core.Assist {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist']/class[@name='MemoryCacheUtil']"
	[global::Android.Runtime.Register ("com/nostra13/universalimageloader/core/assist/MemoryCacheUtil", DoNotGenerateAcw=true)]
	public sealed partial class MemoryCacheUtil : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/nostra13/universalimageloader/core/assist/MemoryCacheUtil", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MemoryCacheUtil); }
		}

		internal MemoryCacheUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_createFuzzyKeyComparator;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist']/class[@name='MemoryCacheUtil']/method[@name='createFuzzyKeyComparator' and count(parameter)=0]"
		[Register ("createFuzzyKeyComparator", "()Ljava/util/Comparator;", "")]
		public static global::Java.Util.IComparator CreateFuzzyKeyComparator ()
		{
			if (id_createFuzzyKeyComparator == IntPtr.Zero)
				id_createFuzzyKeyComparator = JNIEnv.GetStaticMethodID (class_ref, "createFuzzyKeyComparator", "()Ljava/util/Comparator;");
			return global::Java.Lang.Object.GetObject<global::Java.Util.IComparator> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createFuzzyKeyComparator), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_findCacheKeysForImageUri_Ljava_lang_String_Lcom_nostra13_universalimageloader_cache_memory_MemoryCacheAware_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist']/class[@name='MemoryCacheUtil']/method[@name='findCacheKeysForImageUri' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.nostra13.universalimageloader.cache.memory.MemoryCacheAware']]"
		[Register ("findCacheKeysForImageUri", "(Ljava/lang/String;Lcom/nostra13/universalimageloader/cache/memory/MemoryCacheAware;)Ljava/util/List;", "")]
		public static global::System.Collections.Generic.IList<string> FindCacheKeysForImageUri (string p0, global::Com.Nostra13.Universalimageloader.Cache.Memory.IMemoryCacheAware p1)
		{
			if (id_findCacheKeysForImageUri_Ljava_lang_String_Lcom_nostra13_universalimageloader_cache_memory_MemoryCacheAware_ == IntPtr.Zero)
				id_findCacheKeysForImageUri_Ljava_lang_String_Lcom_nostra13_universalimageloader_cache_memory_MemoryCacheAware_ = JNIEnv.GetStaticMethodID (class_ref, "findCacheKeysForImageUri", "(Ljava/lang/String;Lcom/nostra13/universalimageloader/cache/memory/MemoryCacheAware;)Ljava/util/List;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::System.Collections.Generic.IList<string> __ret = global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_findCacheKeysForImageUri_Ljava_lang_String_Lcom_nostra13_universalimageloader_cache_memory_MemoryCacheAware_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_findCachedBitmapsForImageUri_Ljava_lang_String_Lcom_nostra13_universalimageloader_cache_memory_MemoryCacheAware_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist']/class[@name='MemoryCacheUtil']/method[@name='findCachedBitmapsForImageUri' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.nostra13.universalimageloader.cache.memory.MemoryCacheAware']]"
		[Register ("findCachedBitmapsForImageUri", "(Ljava/lang/String;Lcom/nostra13/universalimageloader/cache/memory/MemoryCacheAware;)Ljava/util/List;", "")]
		public static global::System.Collections.Generic.IList<global::Android.Graphics.Bitmap> FindCachedBitmapsForImageUri (string p0, global::Com.Nostra13.Universalimageloader.Cache.Memory.IMemoryCacheAware p1)
		{
			if (id_findCachedBitmapsForImageUri_Ljava_lang_String_Lcom_nostra13_universalimageloader_cache_memory_MemoryCacheAware_ == IntPtr.Zero)
				id_findCachedBitmapsForImageUri_Ljava_lang_String_Lcom_nostra13_universalimageloader_cache_memory_MemoryCacheAware_ = JNIEnv.GetStaticMethodID (class_ref, "findCachedBitmapsForImageUri", "(Ljava/lang/String;Lcom/nostra13/universalimageloader/cache/memory/MemoryCacheAware;)Ljava/util/List;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::System.Collections.Generic.IList<global::Android.Graphics.Bitmap> __ret = global::Android.Runtime.JavaList<global::Android.Graphics.Bitmap>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_findCachedBitmapsForImageUri_Ljava_lang_String_Lcom_nostra13_universalimageloader_cache_memory_MemoryCacheAware_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_generateKey_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_assist_ImageSize_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist']/class[@name='MemoryCacheUtil']/method[@name='generateKey' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.nostra13.universalimageloader.core.assist.ImageSize']]"
		[Register ("generateKey", "(Ljava/lang/String;Lcom/nostra13/universalimageloader/core/assist/ImageSize;)Ljava/lang/String;", "")]
		public static string GenerateKey (string p0, global::Com.Nostra13.Universalimageloader.Core.Assist.ImageSize p1)
		{
			if (id_generateKey_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_assist_ImageSize_ == IntPtr.Zero)
				id_generateKey_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_assist_ImageSize_ = JNIEnv.GetStaticMethodID (class_ref, "generateKey", "(Ljava/lang/String;Lcom/nostra13/universalimageloader/core/assist/ImageSize;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_generateKey_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_assist_ImageSize_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_removeFromCache_Ljava_lang_String_Lcom_nostra13_universalimageloader_cache_memory_MemoryCacheAware_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist']/class[@name='MemoryCacheUtil']/method[@name='removeFromCache' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.nostra13.universalimageloader.cache.memory.MemoryCacheAware']]"
		[Register ("removeFromCache", "(Ljava/lang/String;Lcom/nostra13/universalimageloader/cache/memory/MemoryCacheAware;)V", "")]
		public static void RemoveFromCache (string p0, global::Com.Nostra13.Universalimageloader.Cache.Memory.IMemoryCacheAware p1)
		{
			if (id_removeFromCache_Ljava_lang_String_Lcom_nostra13_universalimageloader_cache_memory_MemoryCacheAware_ == IntPtr.Zero)
				id_removeFromCache_Ljava_lang_String_Lcom_nostra13_universalimageloader_cache_memory_MemoryCacheAware_ = JNIEnv.GetStaticMethodID (class_ref, "removeFromCache", "(Ljava/lang/String;Lcom/nostra13/universalimageloader/cache/memory/MemoryCacheAware;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_removeFromCache_Ljava_lang_String_Lcom_nostra13_universalimageloader_cache_memory_MemoryCacheAware_, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}
}
