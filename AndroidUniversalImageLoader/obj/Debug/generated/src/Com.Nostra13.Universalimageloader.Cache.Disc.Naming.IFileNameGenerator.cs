using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nostra13.Universalimageloader.Cache.Disc.Naming {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.disc.naming']/interface[@name='FileNameGenerator']"
	[Register ("com/nostra13/universalimageloader/cache/disc/naming/FileNameGenerator", "", "Com.Nostra13.Universalimageloader.Cache.Disc.Naming.IFileNameGeneratorInvoker")]
	public partial interface IFileNameGenerator : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.disc.naming']/interface[@name='FileNameGenerator']/method[@name='generate' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("generate", "(Ljava/lang/String;)Ljava/lang/String;", "GetGenerate_Ljava_lang_String_Handler:Com.Nostra13.Universalimageloader.Cache.Disc.Naming.IFileNameGeneratorInvoker, AndroidUniversalImageLoader")]
		string Generate (string p0);

	}

	[global::Android.Runtime.Register ("com/nostra13/universalimageloader/cache/disc/naming/FileNameGenerator", DoNotGenerateAcw=true)]
	internal class IFileNameGeneratorInvoker : global::Java.Lang.Object, IFileNameGenerator {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/nostra13/universalimageloader/cache/disc/naming/FileNameGenerator");
		IntPtr class_ref;

		public static IFileNameGenerator GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IFileNameGenerator> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.nostra13.universalimageloader.cache.disc.naming.FileNameGenerator"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IFileNameGeneratorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IFileNameGeneratorInvoker); }
		}

		static Delegate cb_generate_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGenerate_Ljava_lang_String_Handler ()
		{
			if (cb_generate_Ljava_lang_String_ == null)
				cb_generate_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Generate_Ljava_lang_String_);
			return cb_generate_Ljava_lang_String_;
		}

		static IntPtr n_Generate_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nostra13.Universalimageloader.Cache.Disc.Naming.IFileNameGenerator __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Cache.Disc.Naming.IFileNameGenerator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Generate (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_generate_Ljava_lang_String_;
		public string Generate (string p0)
		{
			if (id_generate_Ljava_lang_String_ == IntPtr.Zero)
				id_generate_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "generate", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_generate_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}

}
