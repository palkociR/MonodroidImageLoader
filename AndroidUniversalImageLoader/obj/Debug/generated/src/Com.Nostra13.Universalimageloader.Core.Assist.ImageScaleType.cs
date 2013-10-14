using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nostra13.Universalimageloader.Core.Assist {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist']/class[@name='ImageScaleType']"
	[global::Android.Runtime.Register ("com/nostra13/universalimageloader/core/assist/ImageScaleType", DoNotGenerateAcw=true)]
	public sealed partial class ImageScaleType : global::Java.Lang.Enum {


		static IntPtr EXACTLY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist']/class[@name='ImageScaleType']/field[@name='EXACTLY']"
		[Register ("EXACTLY")]
		public static global::Com.Nostra13.Universalimageloader.Core.Assist.ImageScaleType Exactly {
			get {
				if (EXACTLY_jfieldId == IntPtr.Zero)
					EXACTLY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EXACTLY", "Lcom/nostra13/universalimageloader/core/assist/ImageScaleType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EXACTLY_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.ImageScaleType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (EXACTLY_jfieldId == IntPtr.Zero)
					EXACTLY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EXACTLY", "Lcom/nostra13/universalimageloader/core/assist/ImageScaleType;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, EXACTLY_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr EXACTLY_STRETCHED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist']/class[@name='ImageScaleType']/field[@name='EXACTLY_STRETCHED']"
		[Register ("EXACTLY_STRETCHED")]
		public static global::Com.Nostra13.Universalimageloader.Core.Assist.ImageScaleType ExactlyStretched {
			get {
				if (EXACTLY_STRETCHED_jfieldId == IntPtr.Zero)
					EXACTLY_STRETCHED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EXACTLY_STRETCHED", "Lcom/nostra13/universalimageloader/core/assist/ImageScaleType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EXACTLY_STRETCHED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.ImageScaleType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (EXACTLY_STRETCHED_jfieldId == IntPtr.Zero)
					EXACTLY_STRETCHED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EXACTLY_STRETCHED", "Lcom/nostra13/universalimageloader/core/assist/ImageScaleType;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, EXACTLY_STRETCHED_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr IN_SAMPLE_INT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist']/class[@name='ImageScaleType']/field[@name='IN_SAMPLE_INT']"
		[Register ("IN_SAMPLE_INT")]
		public static global::Com.Nostra13.Universalimageloader.Core.Assist.ImageScaleType InSampleInt {
			get {
				if (IN_SAMPLE_INT_jfieldId == IntPtr.Zero)
					IN_SAMPLE_INT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IN_SAMPLE_INT", "Lcom/nostra13/universalimageloader/core/assist/ImageScaleType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, IN_SAMPLE_INT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.ImageScaleType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (IN_SAMPLE_INT_jfieldId == IntPtr.Zero)
					IN_SAMPLE_INT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IN_SAMPLE_INT", "Lcom/nostra13/universalimageloader/core/assist/ImageScaleType;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, IN_SAMPLE_INT_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr IN_SAMPLE_POWER_OF_2_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist']/class[@name='ImageScaleType']/field[@name='IN_SAMPLE_POWER_OF_2']"
		[Register ("IN_SAMPLE_POWER_OF_2")]
		public static global::Com.Nostra13.Universalimageloader.Core.Assist.ImageScaleType InSamplePowerOf2 {
			get {
				if (IN_SAMPLE_POWER_OF_2_jfieldId == IntPtr.Zero)
					IN_SAMPLE_POWER_OF_2_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IN_SAMPLE_POWER_OF_2", "Lcom/nostra13/universalimageloader/core/assist/ImageScaleType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, IN_SAMPLE_POWER_OF_2_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.ImageScaleType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (IN_SAMPLE_POWER_OF_2_jfieldId == IntPtr.Zero)
					IN_SAMPLE_POWER_OF_2_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IN_SAMPLE_POWER_OF_2", "Lcom/nostra13/universalimageloader/core/assist/ImageScaleType;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, IN_SAMPLE_POWER_OF_2_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr NONE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist']/class[@name='ImageScaleType']/field[@name='NONE']"
		[Register ("NONE")]
		public static global::Com.Nostra13.Universalimageloader.Core.Assist.ImageScaleType None {
			get {
				if (NONE_jfieldId == IntPtr.Zero)
					NONE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NONE", "Lcom/nostra13/universalimageloader/core/assist/ImageScaleType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NONE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.ImageScaleType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (NONE_jfieldId == IntPtr.Zero)
					NONE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NONE", "Lcom/nostra13/universalimageloader/core/assist/ImageScaleType;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, NONE_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/nostra13/universalimageloader/core/assist/ImageScaleType", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ImageScaleType); }
		}

		internal ImageScaleType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist']/class[@name='ImageScaleType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/nostra13/universalimageloader/core/assist/ImageScaleType;", "")]
		public static global::Com.Nostra13.Universalimageloader.Core.Assist.ImageScaleType ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/nostra13/universalimageloader/core/assist/ImageScaleType;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Com.Nostra13.Universalimageloader.Core.Assist.ImageScaleType __ret = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.ImageScaleType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist']/class[@name='ImageScaleType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/nostra13/universalimageloader/core/assist/ImageScaleType;", "")]
		public static global::Com.Nostra13.Universalimageloader.Core.Assist.ImageScaleType[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/nostra13/universalimageloader/core/assist/ImageScaleType;");
			return (global::Com.Nostra13.Universalimageloader.Core.Assist.ImageScaleType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Nostra13.Universalimageloader.Core.Assist.ImageScaleType));
		}

	}
}
