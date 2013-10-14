using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nostra13.Universalimageloader.Core.Display {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nostra13.universalimageloader.core.display']/class[@name='RoundedBitmapDisplayer']"
	[global::Android.Runtime.Register ("com/nostra13/universalimageloader/core/display/RoundedBitmapDisplayer", DoNotGenerateAcw=true)]
	public partial class RoundedBitmapDisplayer : global::Java.Lang.Object, global::Com.Nostra13.Universalimageloader.Core.Display.IBitmapDisplayer {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/nostra13/universalimageloader/core/display/RoundedBitmapDisplayer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RoundedBitmapDisplayer); }
		}

		protected RoundedBitmapDisplayer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nostra13.universalimageloader.core.display']/class[@name='RoundedBitmapDisplayer']/constructor[@name='RoundedBitmapDisplayer' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public RoundedBitmapDisplayer (int p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (RoundedBitmapDisplayer)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(I)V", new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor_I == IntPtr.Zero)
				id_ctor_I = JNIEnv.GetMethodID (class_ref, "<init>", "(I)V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Nostra13.Universalimageloader.Core.Display.RoundedBitmapDisplayer __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Display.RoundedBitmapDisplayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Widget.ImageView p1 = global::Java.Lang.Object.GetObject<global::Android.Widget.ImageView> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Display (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_display_Landroid_graphics_Bitmap_Landroid_widget_ImageView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.display']/class[@name='RoundedBitmapDisplayer']/method[@name='display' and count(parameter)=2 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='android.widget.ImageView']]"
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

		static IntPtr id_roundCorners_Landroid_graphics_Bitmap_Landroid_widget_ImageView_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.display']/class[@name='RoundedBitmapDisplayer']/method[@name='roundCorners' and count(parameter)=3 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='android.widget.ImageView'] and parameter[3][@type='int']]"
		[Register ("roundCorners", "(Landroid/graphics/Bitmap;Landroid/widget/ImageView;I)Landroid/graphics/Bitmap;", "")]
		public static global::Android.Graphics.Bitmap RoundCorners (global::Android.Graphics.Bitmap p0, global::Android.Widget.ImageView p1, int p2)
		{
			if (id_roundCorners_Landroid_graphics_Bitmap_Landroid_widget_ImageView_I == IntPtr.Zero)
				id_roundCorners_Landroid_graphics_Bitmap_Landroid_widget_ImageView_I = JNIEnv.GetStaticMethodID (class_ref, "roundCorners", "(Landroid/graphics/Bitmap;Landroid/widget/ImageView;I)Landroid/graphics/Bitmap;");
			global::Android.Graphics.Bitmap __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallStaticObjectMethod  (class_ref, id_roundCorners_Landroid_graphics_Bitmap_Landroid_widget_ImageView_I, new JValue (p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}
}
