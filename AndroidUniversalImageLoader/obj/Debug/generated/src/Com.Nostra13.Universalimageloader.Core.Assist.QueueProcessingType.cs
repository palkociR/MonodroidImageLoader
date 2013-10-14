using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nostra13.Universalimageloader.Core.Assist {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist']/class[@name='QueueProcessingType']"
	[global::Android.Runtime.Register ("com/nostra13/universalimageloader/core/assist/QueueProcessingType", DoNotGenerateAcw=true)]
	public sealed partial class QueueProcessingType : global::Java.Lang.Enum {


		static IntPtr FIFO_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist']/class[@name='QueueProcessingType']/field[@name='FIFO']"
		[Register ("FIFO")]
		public static global::Com.Nostra13.Universalimageloader.Core.Assist.QueueProcessingType Fifo {
			get {
				if (FIFO_jfieldId == IntPtr.Zero)
					FIFO_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FIFO", "Lcom/nostra13/universalimageloader/core/assist/QueueProcessingType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FIFO_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.QueueProcessingType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (FIFO_jfieldId == IntPtr.Zero)
					FIFO_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FIFO", "Lcom/nostra13/universalimageloader/core/assist/QueueProcessingType;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, FIFO_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr LIFO_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist']/class[@name='QueueProcessingType']/field[@name='LIFO']"
		[Register ("LIFO")]
		public static global::Com.Nostra13.Universalimageloader.Core.Assist.QueueProcessingType Lifo {
			get {
				if (LIFO_jfieldId == IntPtr.Zero)
					LIFO_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LIFO", "Lcom/nostra13/universalimageloader/core/assist/QueueProcessingType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LIFO_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.QueueProcessingType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (LIFO_jfieldId == IntPtr.Zero)
					LIFO_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LIFO", "Lcom/nostra13/universalimageloader/core/assist/QueueProcessingType;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, LIFO_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/nostra13/universalimageloader/core/assist/QueueProcessingType", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (QueueProcessingType); }
		}

		internal QueueProcessingType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist']/class[@name='QueueProcessingType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/nostra13/universalimageloader/core/assist/QueueProcessingType;", "")]
		public static global::Com.Nostra13.Universalimageloader.Core.Assist.QueueProcessingType ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/nostra13/universalimageloader/core/assist/QueueProcessingType;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Com.Nostra13.Universalimageloader.Core.Assist.QueueProcessingType __ret = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.QueueProcessingType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist']/class[@name='QueueProcessingType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/nostra13/universalimageloader/core/assist/QueueProcessingType;", "")]
		public static global::Com.Nostra13.Universalimageloader.Core.Assist.QueueProcessingType[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/nostra13/universalimageloader/core/assist/QueueProcessingType;");
			return (global::Com.Nostra13.Universalimageloader.Core.Assist.QueueProcessingType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Nostra13.Universalimageloader.Core.Assist.QueueProcessingType));
		}

	}
}
