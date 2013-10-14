using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nostra13.Universalimageloader.Cache.Memory {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.memory']/class[@name='LimitedMemoryCache']"
	[global::Android.Runtime.Register ("com/nostra13/universalimageloader/cache/memory/LimitedMemoryCache", DoNotGenerateAcw=true)]
	public abstract partial class LimitedMemoryCache : global::Com.Nostra13.Universalimageloader.Cache.Memory.BaseMemoryCache {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/nostra13/universalimageloader/cache/memory/LimitedMemoryCache", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LimitedMemoryCache); }
		}

		protected LimitedMemoryCache (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.memory']/class[@name='LimitedMemoryCache']/constructor[@name='LimitedMemoryCache' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public LimitedMemoryCache (int p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (LimitedMemoryCache)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(I)V", new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor_I == IntPtr.Zero)
				id_ctor_I = JNIEnv.GetMethodID (class_ref, "<init>", "(I)V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_getSizeLimit;
#pragma warning disable 0169
		static Delegate GetGetSizeLimitHandler ()
		{
			if (cb_getSizeLimit == null)
				cb_getSizeLimit = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSizeLimit);
			return cb_getSizeLimit;
		}

		static int n_GetSizeLimit (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nostra13.Universalimageloader.Cache.Memory.LimitedMemoryCache __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Cache.Memory.LimitedMemoryCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SizeLimit;
		}
#pragma warning restore 0169

		static IntPtr id_getSizeLimit;
		protected virtual int SizeLimit {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.memory']/class[@name='LimitedMemoryCache']/method[@name='getSizeLimit' and count(parameter)=0]"
			[Register ("getSizeLimit", "()I", "GetGetSizeLimitHandler")]
			get {
				if (id_getSizeLimit == IntPtr.Zero)
					id_getSizeLimit = JNIEnv.GetMethodID (class_ref, "getSizeLimit", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getSizeLimit);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, id_getSizeLimit);
			}
		}

		static Delegate cb_getSize_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetGetSize_Ljava_lang_Object_Handler ()
		{
			if (cb_getSize_Ljava_lang_Object_ == null)
				cb_getSize_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_GetSize_Ljava_lang_Object_);
			return cb_getSize_Ljava_lang_Object_;
		}

		static int n_GetSize_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nostra13.Universalimageloader.Cache.Memory.LimitedMemoryCache __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Cache.Memory.LimitedMemoryCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetSize (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.memory']/class[@name='LimitedMemoryCache']/method[@name='getSize' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("getSize", "(Ljava/lang/Object;)I", "GetGetSize_Ljava_lang_Object_Handler")]
		protected abstract int GetSize (global::Java.Lang.Object p0);

		static Delegate cb_removeNext;
#pragma warning disable 0169
		static Delegate GetRemoveNextHandler ()
		{
			if (cb_removeNext == null)
				cb_removeNext = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_RemoveNext);
			return cb_removeNext;
		}

		static IntPtr n_RemoveNext (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nostra13.Universalimageloader.Cache.Memory.LimitedMemoryCache __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Cache.Memory.LimitedMemoryCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RemoveNext ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.memory']/class[@name='LimitedMemoryCache']/method[@name='removeNext' and count(parameter)=0]"
		[Register ("removeNext", "()Ljava/lang/Object;", "GetRemoveNextHandler")]
		protected abstract global::Java.Lang.Object RemoveNext ();

	}

	[global::Android.Runtime.Register ("com/nostra13/universalimageloader/cache/memory/LimitedMemoryCache", DoNotGenerateAcw=true)]
	internal partial class LimitedMemoryCacheInvoker : LimitedMemoryCache {

		public LimitedMemoryCacheInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (LimitedMemoryCacheInvoker); }
		}

		static IntPtr id_getSize_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.memory']/class[@name='LimitedMemoryCache']/method[@name='getSize' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("getSize", "(Ljava/lang/Object;)I", "GetGetSize_Ljava_lang_Object_Handler")]
		protected override int GetSize (global::Java.Lang.Object p0)
		{
			if (id_getSize_Ljava_lang_Object_ == IntPtr.Zero)
				id_getSize_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "getSize", "(Ljava/lang/Object;)I");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			int __ret = JNIEnv.CallIntMethod  (Handle, id_getSize_Ljava_lang_Object_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_removeNext;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.memory']/class[@name='LimitedMemoryCache']/method[@name='removeNext' and count(parameter)=0]"
		[Register ("removeNext", "()Ljava/lang/Object;", "GetRemoveNextHandler")]
		protected override global::Java.Lang.Object RemoveNext ()
		{
			if (id_removeNext == IntPtr.Zero)
				id_removeNext = JNIEnv.GetMethodID (class_ref, "removeNext", "()Ljava/lang/Object;");
			return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_removeNext), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_createReference_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.memory']/class[@name='BaseMemoryCache']/method[@name='createReference' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("createReference", "(Ljava/lang/Object;)Ljava/lang/ref/Reference;", "GetCreateReference_Ljava_lang_Object_Handler")]
		protected override global::Java.Lang.Ref.Reference CreateReference (global::Java.Lang.Object p0)
		{
			if (id_createReference_Ljava_lang_Object_ == IntPtr.Zero)
				id_createReference_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "createReference", "(Ljava/lang/Object;)Ljava/lang/ref/Reference;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			global::Java.Lang.Ref.Reference __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Ref.Reference> (JNIEnv.CallObjectMethod  (Handle, id_createReference_Ljava_lang_Object_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}

}
