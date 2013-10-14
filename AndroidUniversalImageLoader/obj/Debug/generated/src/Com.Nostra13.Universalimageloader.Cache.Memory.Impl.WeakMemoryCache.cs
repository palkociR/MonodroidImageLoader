using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nostra13.Universalimageloader.Cache.Memory.Impl {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.memory.impl']/class[@name='WeakMemoryCache']"
	[global::Android.Runtime.Register ("com/nostra13/universalimageloader/cache/memory/impl/WeakMemoryCache", DoNotGenerateAcw=true)]
	public partial class WeakMemoryCache : global::Com.Nostra13.Universalimageloader.Cache.Memory.BaseMemoryCache {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/nostra13/universalimageloader/cache/memory/impl/WeakMemoryCache", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (WeakMemoryCache); }
		}

		protected WeakMemoryCache (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.memory.impl']/class[@name='WeakMemoryCache']/constructor[@name='WeakMemoryCache' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public WeakMemoryCache () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (WeakMemoryCache)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "()V"), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Nostra13.Universalimageloader.Cache.Memory.Impl.WeakMemoryCache __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Cache.Memory.Impl.WeakMemoryCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateReference (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_createReference_Landroid_graphics_Bitmap_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.memory.impl']/class[@name='WeakMemoryCache']/method[@name='createReference' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
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

	}
}
