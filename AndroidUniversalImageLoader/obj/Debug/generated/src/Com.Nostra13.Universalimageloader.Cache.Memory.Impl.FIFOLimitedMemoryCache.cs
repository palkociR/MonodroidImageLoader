using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nostra13.Universalimageloader.Cache.Memory.Impl {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.memory.impl']/class[@name='FIFOLimitedMemoryCache']"
	[global::Android.Runtime.Register ("com/nostra13/universalimageloader/cache/memory/impl/FIFOLimitedMemoryCache", DoNotGenerateAcw=true)]
	public partial class FIFOLimitedMemoryCache : global::Com.Nostra13.Universalimageloader.Cache.Memory.LimitedMemoryCache {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/nostra13/universalimageloader/cache/memory/impl/FIFOLimitedMemoryCache", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FIFOLimitedMemoryCache); }
		}

		protected FIFOLimitedMemoryCache (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.memory.impl']/class[@name='FIFOLimitedMemoryCache']/constructor[@name='FIFOLimitedMemoryCache' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public FIFOLimitedMemoryCache (int p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (FIFOLimitedMemoryCache)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(I)V", new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor_I == IntPtr.Zero)
				id_ctor_I = JNIEnv.GetMethodID (class_ref, "<init>", "(I)V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_createReference_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
		static Delegate GetCreateReference_Landroid_graphics_Bitmap_Handler ()
		{
			if (cb_createReference_Landroid_graphics_Bitmap_ == null)
				cb_createReference_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_CreateReference_Landroid_graphics_Bitmap_);
			return cb_createReference_Landroid_graphics_Bitmap_;
		}

		static IntPtr n_CreateReference_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nostra13.Universalimageloader.Cache.Memory.Impl.FIFOLimitedMemoryCache __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Cache.Memory.Impl.FIFOLimitedMemoryCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateReference (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_createReference_Landroid_graphics_Bitmap_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.memory.impl']/class[@name='FIFOLimitedMemoryCache']/method[@name='createReference' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
		[Register ("createReference", "(Landroid/graphics/Bitmap;)Ljava/lang/ref/Reference;", "GetCreateReference_Landroid_graphics_Bitmap_Handler")]
		protected virtual global::Java.Lang.Ref.Reference CreateReference (global::Android.Graphics.Bitmap p0)
		{
			if (id_createReference_Landroid_graphics_Bitmap_ == IntPtr.Zero)
				id_createReference_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "createReference", "(Landroid/graphics/Bitmap;)Ljava/lang/ref/Reference;");

			global::Java.Lang.Ref.Reference __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Ref.Reference> (JNIEnv.CallObjectMethod  (Handle, id_createReference_Landroid_graphics_Bitmap_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Ref.Reference> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_createReference_Landroid_graphics_Bitmap_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_getSize_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
		static Delegate GetGetSize_Landroid_graphics_Bitmap_Handler ()
		{
			if (cb_getSize_Landroid_graphics_Bitmap_ == null)
				cb_getSize_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_GetSize_Landroid_graphics_Bitmap_);
			return cb_getSize_Landroid_graphics_Bitmap_;
		}

		static int n_GetSize_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nostra13.Universalimageloader.Cache.Memory.Impl.FIFOLimitedMemoryCache __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Cache.Memory.Impl.FIFOLimitedMemoryCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetSize (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getSize_Landroid_graphics_Bitmap_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.memory.impl']/class[@name='FIFOLimitedMemoryCache']/method[@name='getSize' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
		[Register ("getSize", "(Landroid/graphics/Bitmap;)I", "GetGetSize_Landroid_graphics_Bitmap_Handler")]
		protected virtual int GetSize (global::Android.Graphics.Bitmap p0)
		{
			if (id_getSize_Landroid_graphics_Bitmap_ == IntPtr.Zero)
				id_getSize_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "getSize", "(Landroid/graphics/Bitmap;)I");

			int __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallIntMethod  (Handle, id_getSize_Landroid_graphics_Bitmap_, new JValue (p0));
			else
				__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, id_getSize_Landroid_graphics_Bitmap_, new JValue (p0));
			return __ret;
		}

		static Delegate cb_put_Ljava_lang_String_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
		static Delegate GetPut_Ljava_lang_String_Landroid_graphics_Bitmap_Handler ()
		{
			if (cb_put_Ljava_lang_String_Landroid_graphics_Bitmap_ == null)
				cb_put_Ljava_lang_String_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_Put_Ljava_lang_String_Landroid_graphics_Bitmap_);
			return cb_put_Ljava_lang_String_Landroid_graphics_Bitmap_;
		}

		static bool n_Put_Ljava_lang_String_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Nostra13.Universalimageloader.Cache.Memory.Impl.FIFOLimitedMemoryCache __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Cache.Memory.Impl.FIFOLimitedMemoryCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap p1 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Put (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_put_Ljava_lang_String_Landroid_graphics_Bitmap_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.memory.impl']/class[@name='FIFOLimitedMemoryCache']/method[@name='put' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.graphics.Bitmap']]"
		[Register ("put", "(Ljava/lang/String;Landroid/graphics/Bitmap;)Z", "GetPut_Ljava_lang_String_Landroid_graphics_Bitmap_Handler")]
		public virtual bool Put (string p0, global::Android.Graphics.Bitmap p1)
		{
			if (id_put_Ljava_lang_String_Landroid_graphics_Bitmap_ == IntPtr.Zero)
				id_put_Ljava_lang_String_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "put", "(Ljava/lang/String;Landroid/graphics/Bitmap;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_put_Ljava_lang_String_Landroid_graphics_Bitmap_, new JValue (native_p0), new JValue (p1));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_put_Ljava_lang_String_Landroid_graphics_Bitmap_, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_remove_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemove_Ljava_lang_String_Handler ()
		{
			if (cb_remove_Ljava_lang_String_ == null)
				cb_remove_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Remove_Ljava_lang_String_);
			return cb_remove_Ljava_lang_String_;
		}

		static void n_Remove_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nostra13.Universalimageloader.Cache.Memory.Impl.FIFOLimitedMemoryCache __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Cache.Memory.Impl.FIFOLimitedMemoryCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Remove (p0);
		}
#pragma warning restore 0169

		static IntPtr id_remove_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.memory.impl']/class[@name='FIFOLimitedMemoryCache']/method[@name='remove' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("remove", "(Ljava/lang/String;)V", "GetRemove_Ljava_lang_String_Handler")]
		public virtual void Remove (string p0)
		{
			if (id_remove_Ljava_lang_String_ == IntPtr.Zero)
				id_remove_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "remove", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_remove_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_remove_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

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
			global::Com.Nostra13.Universalimageloader.Cache.Memory.Impl.FIFOLimitedMemoryCache __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Cache.Memory.Impl.FIFOLimitedMemoryCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RemoveNext ());
		}
#pragma warning restore 0169

		static IntPtr id_removeNext;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.memory.impl']/class[@name='FIFOLimitedMemoryCache']/method[@name='removeNext' and count(parameter)=0]"
		[Register ("removeNext", "()Landroid/graphics/Bitmap;", "GetRemoveNextHandler")]
		protected override global::Java.Lang.Object RemoveNext ()
		{
			if (id_removeNext == IntPtr.Zero)
				id_removeNext = JNIEnv.GetMethodID (class_ref, "removeNext", "()Landroid/graphics/Bitmap;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_removeNext), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_removeNext), JniHandleOwnership.TransferLocalRef);
		}

	}
}
