using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nostra13.Universalimageloader.Core.Decode {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.nostra13.universalimageloader.core.decode']/interface[@name='ImageDecoder']"
	[Register ("com/nostra13/universalimageloader/core/decode/ImageDecoder", "", "Com.Nostra13.Universalimageloader.Core.Decode.IImageDecoderInvoker")]
	public partial interface IImageDecoder : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.decode']/interface[@name='ImageDecoder']/method[@name='decode' and count(parameter)=1 and parameter[1][@type='com.nostra13.universalimageloader.core.decode.ImageDecodingInfo']]"
		[Register ("decode", "(Lcom/nostra13/universalimageloader/core/decode/ImageDecodingInfo;)Landroid/graphics/Bitmap;", "GetDecode_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_Handler:Com.Nostra13.Universalimageloader.Core.Decode.IImageDecoderInvoker, AndroidUniversalImageLoader")]
		global::Android.Graphics.Bitmap Decode (global::Com.Nostra13.Universalimageloader.Core.Decode.ImageDecodingInfo p0);

	}

	[global::Android.Runtime.Register ("com/nostra13/universalimageloader/core/decode/ImageDecoder", DoNotGenerateAcw=true)]
	internal class IImageDecoderInvoker : global::Java.Lang.Object, IImageDecoder {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/nostra13/universalimageloader/core/decode/ImageDecoder");
		IntPtr class_ref;

		public static IImageDecoder GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IImageDecoder> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.nostra13.universalimageloader.core.decode.ImageDecoder"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IImageDecoderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IImageDecoderInvoker); }
		}

		static Delegate cb_decode_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_;
#pragma warning disable 0169
		static Delegate GetDecode_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_Handler ()
		{
			if (cb_decode_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_ == null)
				cb_decode_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Decode_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_);
			return cb_decode_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_;
		}

		static IntPtr n_Decode_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nostra13.Universalimageloader.Core.Decode.IImageDecoder __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Decode.IImageDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Nostra13.Universalimageloader.Core.Decode.ImageDecodingInfo p0 = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Decode.ImageDecodingInfo> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Decode (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_decode_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_;
		public global::Android.Graphics.Bitmap Decode (global::Com.Nostra13.Universalimageloader.Core.Decode.ImageDecodingInfo p0)
		{
			if (id_decode_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_ == IntPtr.Zero)
				id_decode_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_ = JNIEnv.GetMethodID (class_ref, "decode", "(Lcom/nostra13/universalimageloader/core/decode/ImageDecodingInfo;)Landroid/graphics/Bitmap;");
			global::Android.Graphics.Bitmap __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallObjectMethod (Handle, id_decode_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}

}
