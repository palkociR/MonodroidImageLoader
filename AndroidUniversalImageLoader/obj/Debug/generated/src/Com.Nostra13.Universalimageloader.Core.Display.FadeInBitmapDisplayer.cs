using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nostra13.Universalimageloader.Core.Display {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nostra13.universalimageloader.core.display']/class[@name='FadeInBitmapDisplayer']"
	[global::Android.Runtime.Register ("com/nostra13/universalimageloader/core/display/FadeInBitmapDisplayer", DoNotGenerateAcw=true)]
	public partial class FadeInBitmapDisplayer : global::Java.Lang.Object, global::Com.Nostra13.Universalimageloader.Core.Display.IBitmapDisplayer {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/nostra13/universalimageloader/core/display/FadeInBitmapDisplayer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FadeInBitmapDisplayer); }
		}

		protected FadeInBitmapDisplayer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nostra13.universalimageloader.core.display']/class[@name='FadeInBitmapDisplayer']/constructor[@name='FadeInBitmapDisplayer' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public FadeInBitmapDisplayer (int p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (FadeInBitmapDisplayer)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(I)V", new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor_I == IntPtr.Zero)
				id_ctor_I = JNIEnv.GetMethodID (class_ref, "<init>", "(I)V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_animate_Landroid_widget_ImageView_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.display']/class[@name='FadeInBitmapDisplayer']/method[@name='animate' and count(parameter)=2 and parameter[1][@type='android.widget.ImageView'] and parameter[2][@type='int']]"
		[Register ("animate", "(Landroid/widget/ImageView;I)V", "")]
		public static void Animate (global::Android.Widget.ImageView p0, int p1)
		{
			if (id_animate_Landroid_widget_ImageView_I == IntPtr.Zero)
				id_animate_Landroid_widget_ImageView_I = JNIEnv.GetStaticMethodID (class_ref, "animate", "(Landroid/widget/ImageView;I)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_animate_Landroid_widget_ImageView_I, new JValue (p0), new JValue (p1));
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
			global::Com.Nostra13.Universalimageloader.Core.Display.FadeInBitmapDisplayer __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Display.FadeInBitmapDisplayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Widget.ImageView p1 = global::Java.Lang.Object.GetObject<global::Android.Widget.ImageView> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Display (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_display_Landroid_graphics_Bitmap_Landroid_widget_ImageView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.display']/class[@name='FadeInBitmapDisplayer']/method[@name='display' and count(parameter)=2 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='android.widget.ImageView']]"
		[Register ("display", "(Landroid/graphics/Bitmap;Landroid/widget/ImageView;)Landroid/graphics/Bitmap;", "GetDisplay_Landroid_graphics_Bitmap_Landroid_widget_ImageView_Handler")]
		public virtual global::Android.Graphics.Bitmap Display (global::Android.Graphics.Bitmap p0, global::Android.Widget.ImageView p1)
		{
			if (id_display_Landroid_graphics_Bitmap_Landroid_widget_ImageView_ == IntPtr.Zero)
				id_display_Landroid_graphics_Bitmap_Landroid_widget_ImageView_ = JNIEnv.GetMethodID (class_ref, "display", "(Landroid/graphics/Bitmap;Landroid/widget/ImageView;)Landroid/graphics/Bitmap;");

			global::Android.Graphics.Bitmap __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallObjectMethod  (Handle, id_display_Landroid_graphics_Bitmap_Landroid_widget_ImageView_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_display_Landroid_graphics_Bitmap_Landroid_widget_ImageView_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}
}
