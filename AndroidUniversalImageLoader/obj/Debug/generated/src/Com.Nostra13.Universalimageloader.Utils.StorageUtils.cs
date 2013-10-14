using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nostra13.Universalimageloader.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nostra13.universalimageloader.utils']/class[@name='StorageUtils']"
	[global::Android.Runtime.Register ("com/nostra13/universalimageloader/utils/StorageUtils", DoNotGenerateAcw=true)]
	public sealed partial class StorageUtils : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/nostra13/universalimageloader/utils/StorageUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (StorageUtils); }
		}

		internal StorageUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getCacheDirectory_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.utils']/class[@name='StorageUtils']/method[@name='getCacheDirectory' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getCacheDirectory", "(Landroid/content/Context;)Ljava/io/File;", "")]
		public static global::Java.IO.File GetCacheDirectory (global::Android.Content.Context p0)
		{
			if (id_getCacheDirectory_Landroid_content_Context_ == IntPtr.Zero)
				id_getCacheDirectory_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getCacheDirectory", "(Landroid/content/Context;)Ljava/io/File;");
			global::Java.IO.File __ret = global::Java.Lang.Object.GetObject<global::Java.IO.File> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getCacheDirectory_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_getIndividualCacheDirectory_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.utils']/class[@name='StorageUtils']/method[@name='getIndividualCacheDirectory' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getIndividualCacheDirectory", "(Landroid/content/Context;)Ljava/io/File;", "")]
		public static global::Java.IO.File GetIndividualCacheDirectory (global::Android.Content.Context p0)
		{
			if (id_getIndividualCacheDirectory_Landroid_content_Context_ == IntPtr.Zero)
				id_getIndividualCacheDirectory_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getIndividualCacheDirectory", "(Landroid/content/Context;)Ljava/io/File;");
			global::Java.IO.File __ret = global::Java.Lang.Object.GetObject<global::Java.IO.File> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getIndividualCacheDirectory_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_getOwnCacheDirectory_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.utils']/class[@name='StorageUtils']/method[@name='getOwnCacheDirectory' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("getOwnCacheDirectory", "(Landroid/content/Context;Ljava/lang/String;)Ljava/io/File;", "")]
		public static global::Java.IO.File GetOwnCacheDirectory (global::Android.Content.Context p0, string p1)
		{
			if (id_getOwnCacheDirectory_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_getOwnCacheDirectory_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getOwnCacheDirectory", "(Landroid/content/Context;Ljava/lang/String;)Ljava/io/File;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			global::Java.IO.File __ret = global::Java.Lang.Object.GetObject<global::Java.IO.File> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getOwnCacheDirectory_Landroid_content_Context_Ljava_lang_String_, new JValue (p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

	}
}
