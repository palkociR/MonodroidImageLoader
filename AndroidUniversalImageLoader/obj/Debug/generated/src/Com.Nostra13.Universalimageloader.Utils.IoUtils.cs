using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nostra13.Universalimageloader.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nostra13.universalimageloader.utils']/class[@name='IoUtils']"
	[global::Android.Runtime.Register ("com/nostra13/universalimageloader/utils/IoUtils", DoNotGenerateAcw=true)]
	public sealed partial class IoUtils : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/nostra13/universalimageloader/utils/IoUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IoUtils); }
		}

		internal IoUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_copyStream_Ljava_io_InputStream_Ljava_io_OutputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.utils']/class[@name='IoUtils']/method[@name='copyStream' and count(parameter)=2 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='java.io.OutputStream']]"
		[Register ("copyStream", "(Ljava/io/InputStream;Ljava/io/OutputStream;)V", "")]
		public static void CopyStream (global::System.IO.Stream p0, global::System.IO.Stream p1)
		{
			if (id_copyStream_Ljava_io_InputStream_Ljava_io_OutputStream_ == IntPtr.Zero)
				id_copyStream_Ljava_io_InputStream_Ljava_io_OutputStream_ = JNIEnv.GetStaticMethodID (class_ref, "copyStream", "(Ljava/io/InputStream;Ljava/io/OutputStream;)V");
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			IntPtr native_p1 = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (p1);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_copyStream_Ljava_io_InputStream_Ljava_io_OutputStream_, new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

	}
}
