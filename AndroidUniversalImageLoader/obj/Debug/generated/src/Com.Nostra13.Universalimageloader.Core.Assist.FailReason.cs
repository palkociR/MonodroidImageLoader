using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nostra13.Universalimageloader.Core.Assist {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist']/class[@name='FailReason']"
	[global::Android.Runtime.Register ("com/nostra13/universalimageloader/core/assist/FailReason", DoNotGenerateAcw=true)]
	public partial class FailReason : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist']/class[@name='FailReason.FailType']"
		[global::Android.Runtime.Register ("com/nostra13/universalimageloader/core/assist/FailReason$FailType", DoNotGenerateAcw=true)]
		public sealed partial class FailType : global::Java.Lang.Enum {


			static IntPtr DECODING_ERROR_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist']/class[@name='FailReason.FailType']/field[@name='DECODING_ERROR']"
			[Register ("DECODING_ERROR")]
			public static global::Com.Nostra13.Universalimageloader.Core.Assist.FailReason.FailType DecodingError {
				get {
					if (DECODING_ERROR_jfieldId == IntPtr.Zero)
						DECODING_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DECODING_ERROR", "Lcom/nostra13/universalimageloader/core/assist/FailReason$FailType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DECODING_ERROR_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.FailReason.FailType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (DECODING_ERROR_jfieldId == IntPtr.Zero)
						DECODING_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DECODING_ERROR", "Lcom/nostra13/universalimageloader/core/assist/FailReason$FailType;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, DECODING_ERROR_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr IO_ERROR_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist']/class[@name='FailReason.FailType']/field[@name='IO_ERROR']"
			[Register ("IO_ERROR")]
			public static global::Com.Nostra13.Universalimageloader.Core.Assist.FailReason.FailType IoError {
				get {
					if (IO_ERROR_jfieldId == IntPtr.Zero)
						IO_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IO_ERROR", "Lcom/nostra13/universalimageloader/core/assist/FailReason$FailType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, IO_ERROR_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.FailReason.FailType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (IO_ERROR_jfieldId == IntPtr.Zero)
						IO_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IO_ERROR", "Lcom/nostra13/universalimageloader/core/assist/FailReason$FailType;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, IO_ERROR_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr NETWORK_DENIED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist']/class[@name='FailReason.FailType']/field[@name='NETWORK_DENIED']"
			[Register ("NETWORK_DENIED")]
			public static global::Com.Nostra13.Universalimageloader.Core.Assist.FailReason.FailType NetworkDenied {
				get {
					if (NETWORK_DENIED_jfieldId == IntPtr.Zero)
						NETWORK_DENIED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NETWORK_DENIED", "Lcom/nostra13/universalimageloader/core/assist/FailReason$FailType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NETWORK_DENIED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.FailReason.FailType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (NETWORK_DENIED_jfieldId == IntPtr.Zero)
						NETWORK_DENIED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NETWORK_DENIED", "Lcom/nostra13/universalimageloader/core/assist/FailReason$FailType;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, NETWORK_DENIED_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr OUT_OF_MEMORY_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist']/class[@name='FailReason.FailType']/field[@name='OUT_OF_MEMORY']"
			[Register ("OUT_OF_MEMORY")]
			public static global::Com.Nostra13.Universalimageloader.Core.Assist.FailReason.FailType OutOfMemory {
				get {
					if (OUT_OF_MEMORY_jfieldId == IntPtr.Zero)
						OUT_OF_MEMORY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "OUT_OF_MEMORY", "Lcom/nostra13/universalimageloader/core/assist/FailReason$FailType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, OUT_OF_MEMORY_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.FailReason.FailType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (OUT_OF_MEMORY_jfieldId == IntPtr.Zero)
						OUT_OF_MEMORY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "OUT_OF_MEMORY", "Lcom/nostra13/universalimageloader/core/assist/FailReason$FailType;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, OUT_OF_MEMORY_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr UNKNOWN_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist']/class[@name='FailReason.FailType']/field[@name='UNKNOWN']"
			[Register ("UNKNOWN")]
			public static global::Com.Nostra13.Universalimageloader.Core.Assist.FailReason.FailType Unknown {
				get {
					if (UNKNOWN_jfieldId == IntPtr.Zero)
						UNKNOWN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNKNOWN", "Lcom/nostra13/universalimageloader/core/assist/FailReason$FailType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UNKNOWN_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.FailReason.FailType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (UNKNOWN_jfieldId == IntPtr.Zero)
						UNKNOWN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNKNOWN", "Lcom/nostra13/universalimageloader/core/assist/FailReason$FailType;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, UNKNOWN_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/nostra13/universalimageloader/core/assist/FailReason$FailType", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (FailType); }
			}

			internal FailType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist']/class[@name='FailReason.FailType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/nostra13/universalimageloader/core/assist/FailReason$FailType;", "")]
			public static global::Com.Nostra13.Universalimageloader.Core.Assist.FailReason.FailType ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/nostra13/universalimageloader/core/assist/FailReason$FailType;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				global::Com.Nostra13.Universalimageloader.Core.Assist.FailReason.FailType __ret = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.FailReason.FailType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist']/class[@name='FailReason.FailType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/nostra13/universalimageloader/core/assist/FailReason$FailType;", "")]
			public static global::Com.Nostra13.Universalimageloader.Core.Assist.FailReason.FailType[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/nostra13/universalimageloader/core/assist/FailReason$FailType;");
				return (global::Com.Nostra13.Universalimageloader.Core.Assist.FailReason.FailType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Nostra13.Universalimageloader.Core.Assist.FailReason.FailType));
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/nostra13/universalimageloader/core/assist/FailReason", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FailReason); }
		}

		protected FailReason (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_nostra13_universalimageloader_core_assist_FailReason_FailType_Ljava_lang_Throwable_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist']/class[@name='FailReason']/constructor[@name='FailReason' and count(parameter)=2 and parameter[1][@type='com.nostra13.universalimageloader.core.assist.FailReason.FailType'] and parameter[2][@type='java.lang.Throwable']]"
		[Register (".ctor", "(Lcom/nostra13/universalimageloader/core/assist/FailReason$FailType;Ljava/lang/Throwable;)V", "")]
		public FailReason (global::Com.Nostra13.Universalimageloader.Core.Assist.FailReason.FailType p0, global::Java.Lang.Throwable p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (FailReason)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Lcom/nostra13/universalimageloader/core/assist/FailReason$FailType;Ljava/lang/Throwable;)V", new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor_Lcom_nostra13_universalimageloader_core_assist_FailReason_FailType_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_ctor_Lcom_nostra13_universalimageloader_core_assist_FailReason_FailType_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/nostra13/universalimageloader/core/assist/FailReason$FailType;Ljava/lang/Throwable;)V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Lcom_nostra13_universalimageloader_core_assist_FailReason_FailType_Ljava_lang_Throwable_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_getCause;
#pragma warning disable 0169
		static Delegate GetGetCauseHandler ()
		{
			if (cb_getCause == null)
				cb_getCause = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCause);
			return cb_getCause;
		}

		static IntPtr n_GetCause (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nostra13.Universalimageloader.Core.Assist.FailReason __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.FailReason> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Cause);
		}
#pragma warning restore 0169

		static IntPtr id_getCause;
		public virtual global::Java.Lang.Throwable Cause {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist']/class[@name='FailReason']/method[@name='getCause' and count(parameter)=0]"
			[Register ("getCause", "()Ljava/lang/Throwable;", "GetGetCauseHandler")]
			get {
				if (id_getCause == IntPtr.Zero)
					id_getCause = JNIEnv.GetMethodID (class_ref, "getCause", "()Ljava/lang/Throwable;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (JNIEnv.CallObjectMethod  (Handle, id_getCause), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getCause), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getType;
#pragma warning disable 0169
		static Delegate GetGetTypeHandler ()
		{
			if (cb_getType == null)
				cb_getType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetType);
			return cb_getType;
		}

		static IntPtr n_GetType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nostra13.Universalimageloader.Core.Assist.FailReason __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.FailReason> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Type);
		}
#pragma warning restore 0169

		static IntPtr id_getType;
		public virtual global::Com.Nostra13.Universalimageloader.Core.Assist.FailReason.FailType Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist']/class[@name='FailReason']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()Lcom/nostra13/universalimageloader/core/assist/FailReason$FailType;", "GetGetTypeHandler")]
			get {
				if (id_getType == IntPtr.Zero)
					id_getType = JNIEnv.GetMethodID (class_ref, "getType", "()Lcom/nostra13/universalimageloader/core/assist/FailReason$FailType;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.FailReason.FailType> (JNIEnv.CallObjectMethod  (Handle, id_getType), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.FailReason.FailType> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getType), JniHandleOwnership.TransferLocalRef);
			}
		}

	}
}
