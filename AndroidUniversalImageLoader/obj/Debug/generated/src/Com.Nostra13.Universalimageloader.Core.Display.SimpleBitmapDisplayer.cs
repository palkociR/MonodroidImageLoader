using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nostra13.Universalimageloader.Core.Display {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nostra13.universalimageloader.core.display']/class[@name='SimpleBitmapDisplayer']"
	[global::Android.Runtime.Register ("com/nostra13/universalimageloader/core/display/SimpleBitmapDisplayer", DoNotGenerateAcw=true)]
	public sealed partial class SimpleBitmapDisplayer : global::Java.Lang.Object, global::Com.Nostra13.Universalimageloader.Core.Display.IBitmapDisplayer {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/nostra13/universalimageloader/core/display/SimpleBitmapDisplayer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SimpleBitmapDisplayer); }
		}

		internal SimpleBitmapDisplayer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nostra13.universalimageloader.core.display']/class[@name='SimpleBitmapDisplayer']/constructor[@name='SimpleBitmapDisplayer' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public SimpleBitmapDisplayer () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (SimpleBitmapDisplayer)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "()V"), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_display_Landroid_graphics_Bitmap_Landroid_widget_ImageView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.display']/class[@name='SimpleBitmapDisplayer']/method[@name='display' and count(parameter)=2 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='android.widget.ImageView']]"
		[Register ("display", "(Landroid/graphics/Bitmap;Landroid/widget/ImageView;)Landroid/graphics/Bitmap;", "")]
		public global::Android.Graphics.Bitmap Display (global::Android.Graphics.Bitmap p0, global::Android.Widget.ImageView p1)
		{
			if (id_display_Landroid_graphics_Bitmap_Landroid_widget_ImageView_ == IntPtr.Zero)
				id_display_Landroid_graphics_Bitmap_Landroid_widget_ImageView_ = JNIEnv.GetMethodID (class_ref, "display", "(Landroid/graphics/Bitmap;Landroid/widget/ImageView;)Landroid/graphics/Bitmap;");
			global::Android.Graphics.Bitmap __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallObjectMethod  (Handle, id_display_Landroid_graphics_Bitmap_Landroid_widget_ImageView_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}
}
