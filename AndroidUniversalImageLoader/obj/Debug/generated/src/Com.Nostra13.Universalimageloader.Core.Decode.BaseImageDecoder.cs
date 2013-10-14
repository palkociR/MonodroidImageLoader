using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nostra13.Universalimageloader.Core.Decode {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nostra13.universalimageloader.core.decode']/class[@name='BaseImageDecoder']"
	[global::Android.Runtime.Register ("com/nostra13/universalimageloader/core/decode/BaseImageDecoder", DoNotGenerateAcw=true)]
	public partial class BaseImageDecoder : global::Java.Lang.Object, global::Com.Nostra13.Universalimageloader.Core.Decode.IImageDecoder {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.nostra13.universalimageloader.core.decode']/class[@name='BaseImageDecoder']/field[@name='ERROR_CANT_DECODE_IMAGE']"
		[Register ("ERROR_CANT_DECODE_IMAGE")]
		protected const string ErrorCantDecodeImage = (string) "Image can't be decoded [%s]";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.nostra13.universalimageloader.core.decode']/class[@name='BaseImageDecoder']/field[@name='LOG_FLIP_IMAGE']"
		[Register ("LOG_FLIP_IMAGE")]
		protected const string LogFlipImage = (string) "Flip image horizontally [%s]";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.nostra13.universalimageloader.core.decode']/class[@name='BaseImageDecoder']/field[@name='LOG_ROTATE_IMAGE']"
		[Register ("LOG_ROTATE_IMAGE")]
		protected const string LogRotateImage = (string) "Rotate image on %1$d° [%2$s]";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.nostra13.universalimageloader.core.decode']/class[@name='BaseImageDecoder']/field[@name='LOG_SABSAMPLE_IMAGE']"
		[Register ("LOG_SABSAMPLE_IMAGE")]
		protected const string LogSabsampleImage = (string) "Subsample original image (%1$s) to %2$s (scale = %3$d) [%4$s]";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.nostra13.universalimageloader.core.decode']/class[@name='BaseImageDecoder']/field[@name='LOG_SCALE_IMAGE']"
		[Register ("LOG_SCALE_IMAGE")]
		protected const string LogScaleImage = (string) "Scale subsampled image (%1$s) to %2$s (scale = %3$.5f) [%4$s]";

		static IntPtr loggingEnabled_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.nostra13.universalimageloader.core.decode']/class[@name='BaseImageDecoder']/field[@name='loggingEnabled']"
		[Register ("loggingEnabled")]
		protected bool LoggingEnabled {
			get {
				if (loggingEnabled_jfieldId == IntPtr.Zero)
					loggingEnabled_jfieldId = JNIEnv.GetFieldID (class_ref, "loggingEnabled", "Z");
				return JNIEnv.GetBooleanField (Handle, loggingEnabled_jfieldId);
			}
			set {
				if (loggingEnabled_jfieldId == IntPtr.Zero)
					loggingEnabled_jfieldId = JNIEnv.GetFieldID (class_ref, "loggingEnabled", "Z");
				JNIEnv.SetField (Handle, loggingEnabled_jfieldId, value);
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.nostra13.universalimageloader.core.decode']/class[@name='BaseImageDecoder.ExifInfo']"
		[global::Android.Runtime.Register ("com/nostra13/universalimageloader/core/decode/BaseImageDecoder$ExifInfo", DoNotGenerateAcw=true)]
		protected internal partial class ExifInfo : global::Java.Lang.Object {

			protected ExifInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.nostra13.universalimageloader.core.decode']/class[@name='BaseImageDecoder.ImageFileInfo']"
		[global::Android.Runtime.Register ("com/nostra13/universalimageloader/core/decode/BaseImageDecoder$ImageFileInfo", DoNotGenerateAcw=true)]
		protected internal partial class ImageFileInfo : global::Java.Lang.Object {

			protected ImageFileInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/nostra13/universalimageloader/core/decode/BaseImageDecoder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseImageDecoder); }
		}

		protected BaseImageDecoder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Z;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nostra13.universalimageloader.core.decode']/class[@name='BaseImageDecoder']/constructor[@name='BaseImageDecoder' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register (".ctor", "(Z)V", "")]
		public BaseImageDecoder (bool p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (BaseImageDecoder)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Z)V", new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor_Z == IntPtr.Zero)
				id_ctor_Z = JNIEnv.GetMethodID (class_ref, "<init>", "(Z)V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Z, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nostra13.universalimageloader.core.decode']/class[@name='BaseImageDecoder']/constructor[@name='BaseImageDecoder' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public BaseImageDecoder () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (BaseImageDecoder)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "()V"), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_considerExactScaleAndOrientaiton_Landroid_graphics_Bitmap_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_IZ;
#pragma warning disable 0169
		static Delegate GetConsiderExactScaleAndOrientaiton_Landroid_graphics_Bitmap_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_IZHandler ()
		{
			if (cb_considerExactScaleAndOrientaiton_Landroid_graphics_Bitmap_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_IZ == null)
				cb_considerExactScaleAndOrientaiton_Landroid_graphics_Bitmap_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_IZ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int, bool, IntPtr>) n_ConsiderExactScaleAndOrientaiton_Landroid_graphics_Bitmap_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_IZ);
			return cb_considerExactScaleAndOrientaiton_Landroid_graphics_Bitmap_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_IZ;
		}

		static IntPtr n_ConsiderExactScaleAndOrientaiton_Landroid_graphics_Bitmap_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_IZ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, bool p3)
		{
			global::Com.Nostra13.Universalimageloader.Core.Decode.BaseImageDecoder __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Decode.BaseImageDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Nostra13.Universalimageloader.Core.Decode.ImageDecodingInfo p1 = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Decode.ImageDecodingInfo> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ConsiderExactScaleAndOrientaiton (p0, p1, p2, p3));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_considerExactScaleAndOrientaiton_Landroid_graphics_Bitmap_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_IZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.decode']/class[@name='BaseImageDecoder']/method[@name='considerExactScaleAndOrientaiton' and count(parameter)=4 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='com.nostra13.universalimageloader.core.decode.ImageDecodingInfo'] and parameter[3][@type='int'] and parameter[4][@type='boolean']]"
		[Register ("considerExactScaleAndOrientaiton", "(Landroid/graphics/Bitmap;Lcom/nostra13/universalimageloader/core/decode/ImageDecodingInfo;IZ)Landroid/graphics/Bitmap;", "GetConsiderExactScaleAndOrientaiton_Landroid_graphics_Bitmap_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_IZHandler")]
		protected virtual global::Android.Graphics.Bitmap ConsiderExactScaleAndOrientaiton (global::Android.Graphics.Bitmap p0, global::Com.Nostra13.Universalimageloader.Core.Decode.ImageDecodingInfo p1, int p2, bool p3)
		{
			if (id_considerExactScaleAndOrientaiton_Landroid_graphics_Bitmap_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_IZ == IntPtr.Zero)
				id_considerExactScaleAndOrientaiton_Landroid_graphics_Bitmap_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_IZ = JNIEnv.GetMethodID (class_ref, "considerExactScaleAndOrientaiton", "(Landroid/graphics/Bitmap;Lcom/nostra13/universalimageloader/core/decode/ImageDecodingInfo;IZ)Landroid/graphics/Bitmap;");

			global::Android.Graphics.Bitmap __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallObjectMethod  (Handle, id_considerExactScaleAndOrientaiton_Landroid_graphics_Bitmap_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_IZ, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_considerExactScaleAndOrientaiton_Landroid_graphics_Bitmap_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_IZ, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3)), JniHandleOwnership.TransferLocalRef);
			return __ret;
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
			global::Com.Nostra13.Universalimageloader.Core.Decode.BaseImageDecoder __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Decode.BaseImageDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Nostra13.Universalimageloader.Core.Decode.ImageDecodingInfo p0 = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Decode.ImageDecodingInfo> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Decode (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_decode_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.decode']/class[@name='BaseImageDecoder']/method[@name='decode' and count(parameter)=1 and parameter[1][@type='com.nostra13.universalimageloader.core.decode.ImageDecodingInfo']]"
		[Register ("decode", "(Lcom/nostra13/universalimageloader/core/decode/ImageDecodingInfo;)Landroid/graphics/Bitmap;", "GetDecode_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_Handler")]
		public virtual global::Android.Graphics.Bitmap Decode (global::Com.Nostra13.Universalimageloader.Core.Decode.ImageDecodingInfo p0)
		{
			if (id_decode_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_ == IntPtr.Zero)
				id_decode_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_ = JNIEnv.GetMethodID (class_ref, "decode", "(Lcom/nostra13/universalimageloader/core/decode/ImageDecodingInfo;)Landroid/graphics/Bitmap;");

			global::Android.Graphics.Bitmap __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallObjectMethod  (Handle, id_decode_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_decode_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_decodeStream_Ljava_io_InputStream_Landroid_graphics_BitmapFactory_Options_;
#pragma warning disable 0169
		static Delegate GetDecodeStream_Ljava_io_InputStream_Landroid_graphics_BitmapFactory_Options_Handler ()
		{
			if (cb_decodeStream_Ljava_io_InputStream_Landroid_graphics_BitmapFactory_Options_ == null)
				cb_decodeStream_Ljava_io_InputStream_Landroid_graphics_BitmapFactory_Options_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_DecodeStream_Ljava_io_InputStream_Landroid_graphics_BitmapFactory_Options_);
			return cb_decodeStream_Ljava_io_InputStream_Landroid_graphics_BitmapFactory_Options_;
		}

		static IntPtr n_DecodeStream_Ljava_io_InputStream_Landroid_graphics_BitmapFactory_Options_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Nostra13.Universalimageloader.Core.Decode.BaseImageDecoder __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Decode.BaseImageDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream p0 = global::Android.Runtime.InputStreamInvoker.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.BitmapFactory.Options p1 = global::Java.Lang.Object.GetObject<global::Android.Graphics.BitmapFactory.Options> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DecodeStream (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_decodeStream_Ljava_io_InputStream_Landroid_graphics_BitmapFactory_Options_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.decode']/class[@name='BaseImageDecoder']/method[@name='decodeStream' and count(parameter)=2 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='android.graphics.BitmapFactory.Options']]"
		[Register ("decodeStream", "(Ljava/io/InputStream;Landroid/graphics/BitmapFactory$Options;)Landroid/graphics/Bitmap;", "GetDecodeStream_Ljava_io_InputStream_Landroid_graphics_BitmapFactory_Options_Handler")]
		protected virtual global::Android.Graphics.Bitmap DecodeStream (global::System.IO.Stream p0, global::Android.Graphics.BitmapFactory.Options p1)
		{
			if (id_decodeStream_Ljava_io_InputStream_Landroid_graphics_BitmapFactory_Options_ == IntPtr.Zero)
				id_decodeStream_Ljava_io_InputStream_Landroid_graphics_BitmapFactory_Options_ = JNIEnv.GetMethodID (class_ref, "decodeStream", "(Ljava/io/InputStream;Landroid/graphics/BitmapFactory$Options;)Landroid/graphics/Bitmap;");
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);

			global::Android.Graphics.Bitmap __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallObjectMethod  (Handle, id_decodeStream_Ljava_io_InputStream_Landroid_graphics_BitmapFactory_Options_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_decodeStream_Ljava_io_InputStream_Landroid_graphics_BitmapFactory_Options_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_defineExifOrientation_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDefineExifOrientation_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_defineExifOrientation_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_defineExifOrientation_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_DefineExifOrientation_Ljava_lang_String_Ljava_lang_String_);
			return cb_defineExifOrientation_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_DefineExifOrientation_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Nostra13.Universalimageloader.Core.Decode.BaseImageDecoder __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Decode.BaseImageDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DefineExifOrientation (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_defineExifOrientation_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.decode']/class[@name='BaseImageDecoder']/method[@name='defineExifOrientation' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("defineExifOrientation", "(Ljava/lang/String;Ljava/lang/String;)Lcom/nostra13/universalimageloader/core/decode/BaseImageDecoder$ExifInfo;", "GetDefineExifOrientation_Ljava_lang_String_Ljava_lang_String_Handler")]
		protected virtual global::Com.Nostra13.Universalimageloader.Core.Decode.BaseImageDecoder.ExifInfo DefineExifOrientation (string p0, string p1)
		{
			if (id_defineExifOrientation_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_defineExifOrientation_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "defineExifOrientation", "(Ljava/lang/String;Ljava/lang/String;)Lcom/nostra13/universalimageloader/core/decode/BaseImageDecoder$ExifInfo;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);

			global::Com.Nostra13.Universalimageloader.Core.Decode.BaseImageDecoder.ExifInfo __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Decode.BaseImageDecoder.ExifInfo> (JNIEnv.CallObjectMethod  (Handle, id_defineExifOrientation_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Decode.BaseImageDecoder.ExifInfo> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_defineExifOrientation_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_defineImageSizeAndRotation_Ljava_io_InputStream_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDefineImageSizeAndRotation_Ljava_io_InputStream_Ljava_lang_String_Handler ()
		{
			if (cb_defineImageSizeAndRotation_Ljava_io_InputStream_Ljava_lang_String_ == null)
				cb_defineImageSizeAndRotation_Ljava_io_InputStream_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_DefineImageSizeAndRotation_Ljava_io_InputStream_Ljava_lang_String_);
			return cb_defineImageSizeAndRotation_Ljava_io_InputStream_Ljava_lang_String_;
		}

		static IntPtr n_DefineImageSizeAndRotation_Ljava_io_InputStream_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Nostra13.Universalimageloader.Core.Decode.BaseImageDecoder __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Decode.BaseImageDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream p0 = global::Android.Runtime.InputStreamInvoker.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DefineImageSizeAndRotation (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_defineImageSizeAndRotation_Ljava_io_InputStream_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.decode']/class[@name='BaseImageDecoder']/method[@name='defineImageSizeAndRotation' and count(parameter)=2 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='java.lang.String']]"
		[Register ("defineImageSizeAndRotation", "(Ljava/io/InputStream;Ljava/lang/String;)Lcom/nostra13/universalimageloader/core/decode/BaseImageDecoder$ImageFileInfo;", "GetDefineImageSizeAndRotation_Ljava_io_InputStream_Ljava_lang_String_Handler")]
		protected virtual global::Com.Nostra13.Universalimageloader.Core.Decode.BaseImageDecoder.ImageFileInfo DefineImageSizeAndRotation (global::System.IO.Stream p0, string p1)
		{
			if (id_defineImageSizeAndRotation_Ljava_io_InputStream_Ljava_lang_String_ == IntPtr.Zero)
				id_defineImageSizeAndRotation_Ljava_io_InputStream_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "defineImageSizeAndRotation", "(Ljava/io/InputStream;Ljava/lang/String;)Lcom/nostra13/universalimageloader/core/decode/BaseImageDecoder$ImageFileInfo;");
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);

			global::Com.Nostra13.Universalimageloader.Core.Decode.BaseImageDecoder.ImageFileInfo __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Decode.BaseImageDecoder.ImageFileInfo> (JNIEnv.CallObjectMethod  (Handle, id_defineImageSizeAndRotation_Ljava_io_InputStream_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Decode.BaseImageDecoder.ImageFileInfo> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_defineImageSizeAndRotation_Ljava_io_InputStream_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_getImageStream_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_;
#pragma warning disable 0169
		static Delegate GetGetImageStream_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_Handler ()
		{
			if (cb_getImageStream_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_ == null)
				cb_getImageStream_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetImageStream_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_);
			return cb_getImageStream_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_;
		}

		static IntPtr n_GetImageStream_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nostra13.Universalimageloader.Core.Decode.BaseImageDecoder __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Decode.BaseImageDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Nostra13.Universalimageloader.Core.Decode.ImageDecodingInfo p0 = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Decode.ImageDecodingInfo> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (__this.GetImageStream (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getImageStream_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.decode']/class[@name='BaseImageDecoder']/method[@name='getImageStream' and count(parameter)=1 and parameter[1][@type='com.nostra13.universalimageloader.core.decode.ImageDecodingInfo']]"
		[Register ("getImageStream", "(Lcom/nostra13/universalimageloader/core/decode/ImageDecodingInfo;)Ljava/io/InputStream;", "GetGetImageStream_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_Handler")]
		protected virtual global::System.IO.Stream GetImageStream (global::Com.Nostra13.Universalimageloader.Core.Decode.ImageDecodingInfo p0)
		{
			if (id_getImageStream_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_ == IntPtr.Zero)
				id_getImageStream_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_ = JNIEnv.GetMethodID (class_ref, "getImageStream", "(Lcom/nostra13/universalimageloader/core/decode/ImageDecodingInfo;)Ljava/io/InputStream;");

			global::System.IO.Stream __ret;
			if (GetType () == ThresholdType)
				__ret = global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getImageStream_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getImageStream_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_prepareDecodingOptions_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_;
#pragma warning disable 0169
		static Delegate GetPrepareDecodingOptions_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_Handler ()
		{
			if (cb_prepareDecodingOptions_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_ == null)
				cb_prepareDecodingOptions_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_PrepareDecodingOptions_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_);
			return cb_prepareDecodingOptions_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_;
		}

		static IntPtr n_PrepareDecodingOptions_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Nostra13.Universalimageloader.Core.Decode.BaseImageDecoder __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Decode.BaseImageDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Nostra13.Universalimageloader.Core.Assist.ImageSize p0 = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.ImageSize> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Nostra13.Universalimageloader.Core.Decode.ImageDecodingInfo p1 = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Decode.ImageDecodingInfo> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PrepareDecodingOptions (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_prepareDecodingOptions_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.decode']/class[@name='BaseImageDecoder']/method[@name='prepareDecodingOptions' and count(parameter)=2 and parameter[1][@type='com.nostra13.universalimageloader.core.assist.ImageSize'] and parameter[2][@type='com.nostra13.universalimageloader.core.decode.ImageDecodingInfo']]"
		[Register ("prepareDecodingOptions", "(Lcom/nostra13/universalimageloader/core/assist/ImageSize;Lcom/nostra13/universalimageloader/core/decode/ImageDecodingInfo;)Landroid/graphics/BitmapFactory$Options;", "GetPrepareDecodingOptions_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_Handler")]
		protected virtual global::Android.Graphics.BitmapFactory.Options PrepareDecodingOptions (global::Com.Nostra13.Universalimageloader.Core.Assist.ImageSize p0, global::Com.Nostra13.Universalimageloader.Core.Decode.ImageDecodingInfo p1)
		{
			if (id_prepareDecodingOptions_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_ == IntPtr.Zero)
				id_prepareDecodingOptions_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_ = JNIEnv.GetMethodID (class_ref, "prepareDecodingOptions", "(Lcom/nostra13/universalimageloader/core/assist/ImageSize;Lcom/nostra13/universalimageloader/core/decode/ImageDecodingInfo;)Landroid/graphics/BitmapFactory$Options;");

			global::Android.Graphics.BitmapFactory.Options __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.BitmapFactory.Options> (JNIEnv.CallObjectMethod  (Handle, id_prepareDecodingOptions_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.BitmapFactory.Options> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_prepareDecodingOptions_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_setLoggingEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetLoggingEnabled_ZHandler ()
		{
			if (cb_setLoggingEnabled_Z == null)
				cb_setLoggingEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetLoggingEnabled_Z);
			return cb_setLoggingEnabled_Z;
		}

		static void n_SetLoggingEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Nostra13.Universalimageloader.Core.Decode.BaseImageDecoder __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Decode.BaseImageDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetLoggingEnabled (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setLoggingEnabled_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.decode']/class[@name='BaseImageDecoder']/method[@name='setLoggingEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setLoggingEnabled", "(Z)V", "GetSetLoggingEnabled_ZHandler")]
		public virtual void SetLoggingEnabled (bool p0)
		{
			if (id_setLoggingEnabled_Z == IntPtr.Zero)
				id_setLoggingEnabled_Z = JNIEnv.GetMethodID (class_ref, "setLoggingEnabled", "(Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setLoggingEnabled_Z, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setLoggingEnabled_Z, new JValue (p0));
		}

	}
}
