using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nostra13.Universalimageloader.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nostra13.universalimageloader.utils']/class[@name='L']"
	[global::Android.Runtime.Register ("com/nostra13/universalimageloader/utils/L", DoNotGenerateAcw=true)]
	public sealed partial class L : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/nostra13/universalimageloader/utils/L", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (L); }
		}

		internal L (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_d_Ljava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.utils']/class[@name='L']/method[@name='d' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object[]']]"
		[Register ("d", "(Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public static void D (string p0, params global:: Java.Lang.Object[] p1)
		{
			if (id_d_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_d_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "d", "(Ljava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_d_Ljava_lang_String_arrayLjava_lang_Object_, new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_e_Ljava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.utils']/class[@name='L']/method[@name='e' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object[]']]"
		[Register ("e", "(Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public static void E (string p0, params global:: Java.Lang.Object[] p1)
		{
			if (id_e_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_e_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "e", "(Ljava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_e_Ljava_lang_String_arrayLjava_lang_Object_, new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_e_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.utils']/class[@name='L']/method[@name='e' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("e", "(Ljava/lang/Throwable;)V", "")]
		public static void E (global::Java.Lang.Throwable p0)
		{
			if (id_e_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_e_Ljava_lang_Throwable_ = JNIEnv.GetStaticMethodID (class_ref, "e", "(Ljava/lang/Throwable;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_e_Ljava_lang_Throwable_, new JValue (p0));
		}

		static IntPtr id_e_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.utils']/class[@name='L']/method[@name='e' and count(parameter)=3 and parameter[1][@type='java.lang.Throwable'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object[]']]"
		[Register ("e", "(Ljava/lang/Throwable;Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public static void E (global::Java.Lang.Throwable p0, string p1, params global:: Java.Lang.Object[] p2)
		{
			if (id_e_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_e_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "e", "(Ljava/lang/Throwable;Ljava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_e_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_, new JValue (p0), new JValue (native_p1), new JValue (native_p2));
			JNIEnv.DeleteLocalRef (native_p1);
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_i_Ljava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.utils']/class[@name='L']/method[@name='i' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object[]']]"
		[Register ("i", "(Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public static void I (string p0, params global:: Java.Lang.Object[] p1)
		{
			if (id_i_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_i_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "i", "(Ljava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_i_Ljava_lang_String_arrayLjava_lang_Object_, new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_w_Ljava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.utils']/class[@name='L']/method[@name='w' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object[]']]"
		[Register ("w", "(Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public static void W (string p0, params global:: Java.Lang.Object[] p1)
		{
			if (id_w_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_w_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "w", "(Ljava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_w_Ljava_lang_String_arrayLjava_lang_Object_, new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
