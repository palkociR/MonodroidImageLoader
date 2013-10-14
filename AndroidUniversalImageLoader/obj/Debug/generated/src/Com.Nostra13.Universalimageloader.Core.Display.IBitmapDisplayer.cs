using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nostra13.Universalimageloader.Core.Display {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.nostra13.universalimageloader.core.display']/interface[@name='BitmapDisplayer']"
	[Register ("com/nostra13/universalimageloader/core/display/BitmapDisplayer", "", "Com.Nostra13.Universalimageloader.Core.Display.IBitmapDisplayerInvoker")]
	public partial interface IBitmapDisplayer : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.display']/interface[@name='BitmapDisplayer']/method[@name='display' and count(parameter)=2 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='android.widget.ImageView']]"
		[Register ("display", "(Landroid/graphics/Bitmap;Landroid/widget/ImageView;)Landroid/graphics/Bitmap;", "GetDisplay_Landroid_graphics_Bitmap_Landroid_widget_ImageView_Handler:Com.Nostra13.Universalimageloader.Core.Display.IBitmapDisplayerInvoker, AndroidUniversalImageLoader")]
		global::Android.Graphics.Bitmap Display (global::Android.Graphics.Bitmap p0, global::Android.Widget.ImageView p1);

	}

	[global::Android.Runtime.Register ("com/nostra13/universalimageloader/core/display/BitmapDisplayer", DoNotGenerateAcw=true)]
	internal class IBitmapDisplayerInvoker : global::Java.Lang.Object, IBitmapDisplayer {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/nostra13/universalimageloader/core/display/BitmapDisplayer");
		IntPtr class_ref;

		public static IBitmapDisplayer GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBitmapDisplayer> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.nostra13.universalimageloader.core.display.BitmapDisplayer"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBitmapDisplayerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IBitmapDisplayerInvoker); }
		}

		static Delegate cb_display_Landroid_graphics_Bitmap_Landroid_widget_ImageView_;
#pragma warning disable 0169
		static Delegate GetDisplay_Landroid_graphics_Bitmap_Landroid_widget_ImageView_Handler ()
		{
			if (cb_display_Landroid_graphics_Bitmap_Landroid_widget_ImageView_ == null)
				cb_display_Landroid_graphics_Bitmap_Landroid_widget_ImageView_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Display_Landroid_graphics_Bitmap_Landroid_widget_ImageView_);
			return cb_display_Landroid_graphics_Bitmap_Landroid_widget_ImageView_;
		}

		static IntPtr n_Display_Landroid_graphics_Bitmap_Landroid_widget_ImageView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Nostra13.Universalimageloader.Core.Display.IBitmapDisplayer __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Display.IBitmapDisplayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Widget.ImageView p1 = global::Java.Lang.Object.GetObject<global::Android.Widget.ImageView> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Display (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_display_Landroid_graphics_Bitmap_Landroid_widget_ImageView_;
		public global::Android.Graphics.Bitmap Display (global::Android.Graphics.Bitmap p0, global::Android.Widget.ImageView p1)
		{
			if (id_display_Landroid_graphics_Bitmap_Landroid_widget_ImageView_ == IntPtr.Zero)
				id_display_Landroid_graphics_Bitmap_Landroid_widget_ImageView_ = JNIEnv.GetMethodID (class_ref, "display", "(Landroid/graphics/Bitmap;Landroid/widget/ImageView;)Landroid/graphics/Bitmap;");
			global::Android.Graphics.Bitmap __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallObjectMethod (Handle, id_display_Landroid_graphics_Bitmap_Landroid_widget_ImageView_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}

}
