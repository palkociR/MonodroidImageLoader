using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nostra13.Universalimageloader.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nostra13.universalimageloader.utils']/class[@name='ImageSizeUtils']"
	[global::Android.Runtime.Register ("com/nostra13/universalimageloader/utils/ImageSizeUtils", DoNotGenerateAcw=true)]
	public sealed partial class ImageSizeUtils : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/nostra13/universalimageloader/utils/ImageSizeUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ImageSizeUtils); }
		}

		internal ImageSizeUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_computeImageSampleSize_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_assist_ViewScaleType_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.utils']/class[@name='ImageSizeUtils']/method[@name='computeImageSampleSize' and count(parameter)=4 and parameter[1][@type='com.nostra13.universalimageloader.core.assist.ImageSize'] and parameter[2][@type='com.nostra13.universalimageloader.core.assist.ImageSize'] and parameter[3][@type='com.nostra13.universalimageloader.core.assist.ViewScaleType'] and parameter[4][@type='boolean']]"
		[Register ("computeImageSampleSize", "(Lcom/nostra13/universalimageloader/core/assist/ImageSize;Lcom/nostra13/universalimageloader/core/assist/ImageSize;Lcom/nostra13/universalimageloader/core/assist/ViewScaleType;Z)I", "")]
		public static int ComputeImageSampleSize (global::Com.Nostra13.Universalimageloader.Core.Assist.ImageSize p0, global::Com.Nostra13.Universalimageloader.Core.Assist.ImageSize p1, global::Com.Nostra13.Universalimageloader.Core.Assist.ViewScaleType p2, bool p3)
		{
			if (id_computeImageSampleSize_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_assist_ViewScaleType_Z == IntPtr.Zero)
				id_computeImageSampleSize_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_assist_ViewScaleType_Z = JNIEnv.GetStaticMethodID (class_ref, "computeImageSampleSize", "(Lcom/nostra13/universalimageloader/core/assist/ImageSize;Lcom/nostra13/universalimageloader/core/assist/ImageSize;Lcom/nostra13/universalimageloader/core/assist/ViewScaleType;Z)I");
			int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_computeImageSampleSize_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_assist_ViewScaleType_Z, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
			return __ret;
		}

		static IntPtr id_computeImageScale_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_assist_ViewScaleType_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.utils']/class[@name='ImageSizeUtils']/method[@name='computeImageScale' and count(parameter)=4 and parameter[1][@type='com.nostra13.universalimageloader.core.assist.ImageSize'] and parameter[2][@type='com.nostra13.universalimageloader.core.assist.ImageSize'] and parameter[3][@type='com.nostra13.universalimageloader.core.assist.ViewScaleType'] and parameter[4][@type='boolean']]"
		[Register ("computeImageScale", "(Lcom/nostra13/universalimageloader/core/assist/ImageSize;Lcom/nostra13/universalimageloader/core/assist/ImageSize;Lcom/nostra13/universalimageloader/core/assist/ViewScaleType;Z)F", "")]
		public static float ComputeImageScale (global::Com.Nostra13.Universalimageloader.Core.Assist.ImageSize p0, global::Com.Nostra13.Universalimageloader.Core.Assist.ImageSize p1, global::Com.Nostra13.Universalimageloader.Core.Assist.ViewScaleType p2, bool p3)
		{
			if (id_computeImageScale_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_assist_ViewScaleType_Z == IntPtr.Zero)
				id_computeImageScale_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_assist_ViewScaleType_Z = JNIEnv.GetStaticMethodID (class_ref, "computeImageScale", "(Lcom/nostra13/universalimageloader/core/assist/ImageSize;Lcom/nostra13/universalimageloader/core/assist/ImageSize;Lcom/nostra13/universalimageloader/core/assist/ViewScaleType;Z)F");
			float __ret = JNIEnv.CallStaticFloatMethod  (class_ref, id_computeImageScale_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_assist_ViewScaleType_Z, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
			return __ret;
		}

		static IntPtr id_defineTargetSizeForView_Landroid_widget_ImageView_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.utils']/class[@name='ImageSizeUtils']/method[@name='defineTargetSizeForView' and count(parameter)=3 and parameter[1][@type='android.widget.ImageView'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("defineTargetSizeForView", "(Landroid/widget/ImageView;II)Lcom/nostra13/universalimageloader/core/assist/ImageSize;", "")]
		public static global::Com.Nostra13.Universalimageloader.Core.Assist.ImageSize DefineTargetSizeForView (global::Android.Widget.ImageView p0, int p1, int p2)
		{
			if (id_defineTargetSizeForView_Landroid_widget_ImageView_II == IntPtr.Zero)
				id_defineTargetSizeForView_Landroid_widget_ImageView_II = JNIEnv.GetStaticMethodID (class_ref, "defineTargetSizeForView", "(Landroid/widget/ImageView;II)Lcom/nostra13/universalimageloader/core/assist/ImageSize;");
			global::Com.Nostra13.Universalimageloader.Core.Assist.ImageSize __ret = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.ImageSize> (JNIEnv.CallStaticObjectMethod  (class_ref, id_defineTargetSizeForView_Landroid_widget_ImageView_II, new JValue (p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}
}
