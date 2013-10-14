using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nostra13.Universalimageloader.Core.Decode {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nostra13.universalimageloader.core.decode']/class[@name='ImageDecodingInfo']"
	[global::Android.Runtime.Register ("com/nostra13/universalimageloader/core/decode/ImageDecodingInfo", DoNotGenerateAcw=true)]
	public partial class ImageDecodingInfo : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/nostra13/universalimageloader/core/decode/ImageDecodingInfo", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ImageDecodingInfo); }
		}

		protected ImageDecodingInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_assist_ViewScaleType_Lcom_nostra13_universalimageloader_core_download_ImageDownloader_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nostra13.universalimageloader.core.decode']/class[@name='ImageDecodingInfo']/constructor[@name='ImageDecodingInfo' and count(parameter)=6 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.nostra13.universalimageloader.core.assist.ImageSize'] and parameter[4][@type='com.nostra13.universalimageloader.core.assist.ViewScaleType'] and parameter[5][@type='com.nostra13.universalimageloader.core.download.ImageDownloader'] and parameter[6][@type='com.nostra13.universalimageloader.core.DisplayImageOptions']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Lcom/nostra13/universalimageloader/core/assist/ImageSize;Lcom/nostra13/universalimageloader/core/assist/ViewScaleType;Lcom/nostra13/universalimageloader/core/download/ImageDownloader;Lcom/nostra13/universalimageloader/core/DisplayImageOptions;)V", "")]
		public ImageDecodingInfo (string p0, string p1, global::Com.Nostra13.Universalimageloader.Core.Assist.ImageSize p2, global::Com.Nostra13.Universalimageloader.Core.Assist.ViewScaleType p3, global::Com.Nostra13.Universalimageloader.Core.Download.IImageDownloader p4, global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions p5) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);;
			IntPtr native_p1 = JNIEnv.NewString (p1);;
			if (GetType () != typeof (ImageDecodingInfo)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Ljava/lang/String;Ljava/lang/String;Lcom/nostra13/universalimageloader/core/assist/ImageSize;Lcom/nostra13/universalimageloader/core/assist/ViewScaleType;Lcom/nostra13/universalimageloader/core/download/ImageDownloader;Lcom/nostra13/universalimageloader/core/DisplayImageOptions;)V", new JValue (native_p0), new JValue (native_p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (p5)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				return;
			}

			if (id_ctor_Ljava_lang_String_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_assist_ViewScaleType_Lcom_nostra13_universalimageloader_core_download_ImageDownloader_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_ == IntPtr.Zero)
				id_ctor_Ljava_lang_String_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_assist_ViewScaleType_Lcom_nostra13_universalimageloader_core_download_ImageDownloader_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;Lcom/nostra13/universalimageloader/core/assist/ImageSize;Lcom/nostra13/universalimageloader/core/assist/ViewScaleType;Lcom/nostra13/universalimageloader/core/download/ImageDownloader;Lcom/nostra13/universalimageloader/core/DisplayImageOptions;)V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_assist_ViewScaleType_Lcom_nostra13_universalimageloader_core_download_ImageDownloader_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_, new JValue (native_p0), new JValue (native_p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (p5)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_getDecodingOptions;
#pragma warning disable 0169
		static Delegate GetGetDecodingOptionsHandler ()
		{
			if (cb_getDecodingOptions == null)
				cb_getDecodingOptions = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDecodingOptions);
			return cb_getDecodingOptions;
		}

		static IntPtr n_GetDecodingOptions (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nostra13.Universalimageloader.Core.Decode.ImageDecodingInfo __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Decode.ImageDecodingInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DecodingOptions);
		}
#pragma warning restore 0169

		static IntPtr id_getDecodingOptions;
		public virtual global::Android.Graphics.BitmapFactory.Options DecodingOptions {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.decode']/class[@name='ImageDecodingInfo']/method[@name='getDecodingOptions' and count(parameter)=0]"
			[Register ("getDecodingOptions", "()Landroid/graphics/BitmapFactory$Options;", "GetGetDecodingOptionsHandler")]
			get {
				if (id_getDecodingOptions == IntPtr.Zero)
					id_getDecodingOptions = JNIEnv.GetMethodID (class_ref, "getDecodingOptions", "()Landroid/graphics/BitmapFactory$Options;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.BitmapFactory.Options> (JNIEnv.CallObjectMethod  (Handle, id_getDecodingOptions), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.BitmapFactory.Options> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getDecodingOptions), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getDownloader;
#pragma warning disable 0169
		static Delegate GetGetDownloaderHandler ()
		{
			if (cb_getDownloader == null)
				cb_getDownloader = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDownloader);
			return cb_getDownloader;
		}

		static IntPtr n_GetDownloader (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nostra13.Universalimageloader.Core.Decode.ImageDecodingInfo __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Decode.ImageDecodingInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Downloader);
		}
#pragma warning restore 0169

		static IntPtr id_getDownloader;
		public virtual global::Com.Nostra13.Universalimageloader.Core.Download.IImageDownloader Downloader {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.decode']/class[@name='ImageDecodingInfo']/method[@name='getDownloader' and count(parameter)=0]"
			[Register ("getDownloader", "()Lcom/nostra13/universalimageloader/core/download/ImageDownloader;", "GetGetDownloaderHandler")]
			get {
				if (id_getDownloader == IntPtr.Zero)
					id_getDownloader = JNIEnv.GetMethodID (class_ref, "getDownloader", "()Lcom/nostra13/universalimageloader/core/download/ImageDownloader;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Download.IImageDownloader> (JNIEnv.CallObjectMethod  (Handle, id_getDownloader), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Download.IImageDownloader> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getDownloader), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getExtraForDownloader;
#pragma warning disable 0169
		static Delegate GetGetExtraForDownloaderHandler ()
		{
			if (cb_getExtraForDownloader == null)
				cb_getExtraForDownloader = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetExtraForDownloader);
			return cb_getExtraForDownloader;
		}

		static IntPtr n_GetExtraForDownloader (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nostra13.Universalimageloader.Core.Decode.ImageDecodingInfo __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Decode.ImageDecodingInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ExtraForDownloader);
		}
#pragma warning restore 0169

		static IntPtr id_getExtraForDownloader;
		public virtual global::Java.Lang.Object ExtraForDownloader {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.decode']/class[@name='ImageDecodingInfo']/method[@name='getExtraForDownloader' and count(parameter)=0]"
			[Register ("getExtraForDownloader", "()Ljava/lang/Object;", "GetGetExtraForDownloaderHandler")]
			get {
				if (id_getExtraForDownloader == IntPtr.Zero)
					id_getExtraForDownloader = JNIEnv.GetMethodID (class_ref, "getExtraForDownloader", "()Ljava/lang/Object;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_getExtraForDownloader), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getExtraForDownloader), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getImageKey;
#pragma warning disable 0169
		static Delegate GetGetImageKeyHandler ()
		{
			if (cb_getImageKey == null)
				cb_getImageKey = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetImageKey);
			return cb_getImageKey;
		}

		static IntPtr n_GetImageKey (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nostra13.Universalimageloader.Core.Decode.ImageDecodingInfo __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Decode.ImageDecodingInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ImageKey);
		}
#pragma warning restore 0169

		static IntPtr id_getImageKey;
		public virtual string ImageKey {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.decode']/class[@name='ImageDecodingInfo']/method[@name='getImageKey' and count(parameter)=0]"
			[Register ("getImageKey", "()Ljava/lang/String;", "GetGetImageKeyHandler")]
			get {
				if (id_getImageKey == IntPtr.Zero)
					id_getImageKey = JNIEnv.GetMethodID (class_ref, "getImageKey", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getImageKey), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getImageKey), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getImageScaleType;
#pragma warning disable 0169
		static Delegate GetGetImageScaleTypeHandler ()
		{
			if (cb_getImageScaleType == null)
				cb_getImageScaleType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetImageScaleType);
			return cb_getImageScaleType;
		}

		static IntPtr n_GetImageScaleType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nostra13.Universalimageloader.Core.Decode.ImageDecodingInfo __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Decode.ImageDecodingInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ImageScaleType);
		}
#pragma warning restore 0169

		static IntPtr id_getImageScaleType;
		public virtual global::Com.Nostra13.Universalimageloader.Core.Assist.ImageScaleType ImageScaleType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.decode']/class[@name='ImageDecodingInfo']/method[@name='getImageScaleType' and count(parameter)=0]"
			[Register ("getImageScaleType", "()Lcom/nostra13/universalimageloader/core/assist/ImageScaleType;", "GetGetImageScaleTypeHandler")]
			get {
				if (id_getImageScaleType == IntPtr.Zero)
					id_getImageScaleType = JNIEnv.GetMethodID (class_ref, "getImageScaleType", "()Lcom/nostra13/universalimageloader/core/assist/ImageScaleType;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.ImageScaleType> (JNIEnv.CallObjectMethod  (Handle, id_getImageScaleType), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.ImageScaleType> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getImageScaleType), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getImageUri;
#pragma warning disable 0169
		static Delegate GetGetImageUriHandler ()
		{
			if (cb_getImageUri == null)
				cb_getImageUri = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetImageUri);
			return cb_getImageUri;
		}

		static IntPtr n_GetImageUri (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nostra13.Universalimageloader.Core.Decode.ImageDecodingInfo __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Decode.ImageDecodingInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ImageUri);
		}
#pragma warning restore 0169

		static IntPtr id_getImageUri;
		public virtual string ImageUri {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.decode']/class[@name='ImageDecodingInfo']/method[@name='getImageUri' and count(parameter)=0]"
			[Register ("getImageUri", "()Ljava/lang/String;", "GetGetImageUriHandler")]
			get {
				if (id_getImageUri == IntPtr.Zero)
					id_getImageUri = JNIEnv.GetMethodID (class_ref, "getImageUri", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getImageUri), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getImageUri), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getTargetSize;
#pragma warning disable 0169
		static Delegate GetGetTargetSizeHandler ()
		{
			if (cb_getTargetSize == null)
				cb_getTargetSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTargetSize);
			return cb_getTargetSize;
		}

		static IntPtr n_GetTargetSize (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nostra13.Universalimageloader.Core.Decode.ImageDecodingInfo __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Decode.ImageDecodingInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TargetSize);
		}
#pragma warning restore 0169

		static IntPtr id_getTargetSize;
		public virtual global::Com.Nostra13.Universalimageloader.Core.Assist.ImageSize TargetSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.decode']/class[@name='ImageDecodingInfo']/method[@name='getTargetSize' and count(parameter)=0]"
			[Register ("getTargetSize", "()Lcom/nostra13/universalimageloader/core/assist/ImageSize;", "GetGetTargetSizeHandler")]
			get {
				if (id_getTargetSize == IntPtr.Zero)
					id_getTargetSize = JNIEnv.GetMethodID (class_ref, "getTargetSize", "()Lcom/nostra13/universalimageloader/core/assist/ImageSize;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.ImageSize> (JNIEnv.CallObjectMethod  (Handle, id_getTargetSize), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.ImageSize> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getTargetSize), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getViewScaleType;
#pragma warning disable 0169
		static Delegate GetGetViewScaleTypeHandler ()
		{
			if (cb_getViewScaleType == null)
				cb_getViewScaleType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetViewScaleType);
			return cb_getViewScaleType;
		}

		static IntPtr n_GetViewScaleType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nostra13.Universalimageloader.Core.Decode.ImageDecodingInfo __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Decode.ImageDecodingInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ViewScaleType);
		}
#pragma warning restore 0169

		static IntPtr id_getViewScaleType;
		public virtual global::Com.Nostra13.Universalimageloader.Core.Assist.ViewScaleType ViewScaleType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.decode']/class[@name='ImageDecodingInfo']/method[@name='getViewScaleType' and count(parameter)=0]"
			[Register ("getViewScaleType", "()Lcom/nostra13/universalimageloader/core/assist/ViewScaleType;", "GetGetViewScaleTypeHandler")]
			get {
				if (id_getViewScaleType == IntPtr.Zero)
					id_getViewScaleType = JNIEnv.GetMethodID (class_ref, "getViewScaleType", "()Lcom/nostra13/universalimageloader/core/assist/ViewScaleType;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.ViewScaleType> (JNIEnv.CallObjectMethod  (Handle, id_getViewScaleType), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.ViewScaleType> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getViewScaleType), JniHandleOwnership.TransferLocalRef);
			}
		}

	}
}
