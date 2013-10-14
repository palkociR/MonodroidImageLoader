using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nostra13.Universalimageloader.Core.Download {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nostra13.universalimageloader.core.download']/class[@name='SlowNetworkImageDownloader']"
	[global::Android.Runtime.Register ("com/nostra13/universalimageloader/core/download/SlowNetworkImageDownloader", DoNotGenerateAcw=true)]
	public partial class SlowNetworkImageDownloader : global::Java.Lang.Object, global::Com.Nostra13.Universalimageloader.Core.Download.IImageDownloader {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/nostra13/universalimageloader/core/download/SlowNetworkImageDownloader", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SlowNetworkImageDownloader); }
		}

		protected SlowNetworkImageDownloader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_nostra13_universalimageloader_core_download_ImageDownloader_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nostra13.universalimageloader.core.download']/class[@name='SlowNetworkImageDownloader']/constructor[@name='SlowNetworkImageDownloader' and count(parameter)=1 and parameter[1][@type='com.nostra13.universalimageloader.core.download.ImageDownloader']]"
		[Register (".ctor", "(Lcom/nostra13/universalimageloader/core/download/ImageDownloader;)V", "")]
		public SlowNetworkImageDownloader (global::Com.Nostra13.Universalimageloader.Core.Download.IImageDownloader p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (SlowNetworkImageDownloader)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Lcom/nostra13/universalimageloader/core/download/ImageDownloader;)V", new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor_Lcom_nostra13_universalimageloader_core_download_ImageDownloader_ == IntPtr.Zero)
				id_ctor_Lcom_nostra13_universalimageloader_core_download_ImageDownloader_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/nostra13/universalimageloader/core/download/ImageDownloader;)V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Lcom_nostra13_universalimageloader_core_download_ImageDownloader_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_getStream_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetGetStream_Ljava_lang_String_Ljava_lang_Object_Handler ()
		{
			if (cb_getStream_Ljava_lang_String_Ljava_lang_Object_ == null)
				cb_getStream_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetStream_Ljava_lang_String_Ljava_lang_Object_);
			return cb_getStream_Ljava_lang_String_Ljava_lang_Object_;
		}

		static IntPtr n_GetStream_Ljava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Nostra13.Universalimageloader.Core.Download.SlowNetworkImageDownloader __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Download.SlowNetworkImageDownloader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (__this.GetStream (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getStream_Ljava_lang_String_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.download']/class[@name='SlowNetworkImageDownloader']/method[@name='getStream' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
		[Register ("getStream", "(Ljava/lang/String;Ljava/lang/Object;)Ljava/io/InputStream;", "GetGetStream_Ljava_lang_String_Ljava_lang_Object_Handler")]
		public virtual global::System.IO.Stream GetStream (string p0, global::Java.Lang.Object p1)
		{
			if (id_getStream_Ljava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
				id_getStream_Ljava_lang_String_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "getStream", "(Ljava/lang/String;Ljava/lang/Object;)Ljava/io/InputStream;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::System.IO.Stream __ret;
			if (GetType () == ThresholdType)
				__ret = global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getStream_Ljava_lang_String_Ljava_lang_Object_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getStream_Ljava_lang_String_Ljava_lang_Object_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}
}
