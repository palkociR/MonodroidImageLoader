using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nostra13.Universalimageloader.Core.Process {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.nostra13.universalimageloader.core.process']/interface[@name='BitmapProcessor']"
	[Register ("com/nostra13/universalimageloader/core/process/BitmapProcessor", "", "Com.Nostra13.Universalimageloader.Core.Process.IBitmapProcessorInvoker")]
	public partial interface IBitmapProcessor : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.process']/interface[@name='BitmapProcessor']/method[@name='process' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
		[Register ("process", "(Landroid/graphics/Bitmap;)Landroid/graphics/Bitmap;", "GetProcess_Landroid_graphics_Bitmap_Handler:Com.Nostra13.Universalimageloader.Core.Process.IBitmapProcessorInvoker, AndroidUniversalImageLoader")]
		global::Android.Graphics.Bitmap Process (global::Android.Graphics.Bitmap p0);

	}

	[global::Android.Runtime.Register ("com/nostra13/universalimageloader/core/process/BitmapProcessor", DoNotGenerateAcw=true)]
	internal class IBitmapProcessorInvoker : global::Java.Lang.Object, IBitmapProcessor {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/nostra13/universalimageloader/core/process/BitmapProcessor");
		IntPtr class_ref;

		public static IBitmapProcessor GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBitmapProcessor> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.nostra13.universalimageloader.core.process.BitmapProcessor"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBitmapProcessorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IBitmapProcessorInvoker); }
		}

		static Delegate cb_process_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
		static Delegate GetProcess_Landroid_graphics_Bitmap_Handler ()
		{
			if (cb_process_Landroid_graphics_Bitmap_ == null)
				cb_process_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Process_Landroid_graphics_Bitmap_);
			return cb_process_Landroid_graphics_Bitmap_;
		}

		static IntPtr n_Process_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nostra13.Universalimageloader.Core.Process.IBitmapProcessor __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Process.IBitmapProcessor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Process (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_process_Landroid_graphics_Bitmap_;
		public global::Android.Graphics.Bitmap Process (global::Android.Graphics.Bitmap p0)
		{
			if (id_process_Landroid_graphics_Bitmap_ == IntPtr.Zero)
				id_process_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "process", "(Landroid/graphics/Bitmap;)Landroid/graphics/Bitmap;");
			global::Android.Graphics.Bitmap __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallObjectMethod (Handle, id_process_Landroid_graphics_Bitmap_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}

}
