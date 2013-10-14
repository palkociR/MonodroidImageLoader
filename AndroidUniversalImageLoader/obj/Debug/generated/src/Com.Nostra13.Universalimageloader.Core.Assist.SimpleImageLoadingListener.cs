using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nostra13.Universalimageloader.Core.Assist {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist']/class[@name='SimpleImageLoadingListener']"
	[global::Android.Runtime.Register ("com/nostra13/universalimageloader/core/assist/SimpleImageLoadingListener", DoNotGenerateAcw=true)]
	public partial class SimpleImageLoadingListener : global::Java.Lang.Object, global::Com.Nostra13.Universalimageloader.Core.Assist.IImageLoadingListener {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/nostra13/universalimageloader/core/assist/SimpleImageLoadingListener", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SimpleImageLoadingListener); }
		}

		protected SimpleImageLoadingListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist']/class[@name='SimpleImageLoadingListener']/constructor[@name='SimpleImageLoadingListener' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public SimpleImageLoadingListener () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (SimpleImageLoadingListener)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "()V"), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_onLoadingCancelled_Ljava_lang_String_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetOnLoadingCancelled_Ljava_lang_String_Landroid_view_View_Handler ()
		{
			if (cb_onLoadingCancelled_Ljava_lang_String_Landroid_view_View_ == null)
				cb_onLoadingCancelled_Ljava_lang_String_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnLoadingCancelled_Ljava_lang_String_Landroid_view_View_);
			return cb_onLoadingCancelled_Ljava_lang_String_Landroid_view_View_;
		}

		static void n_OnLoadingCancelled_Ljava_lang_String_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Nostra13.Universalimageloader.Core.Assist.SimpleImageLoadingListener __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.SimpleImageLoadingListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p1 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnLoadingCancelled (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onLoadingCancelled_Ljava_lang_String_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist']/class[@name='SimpleImageLoadingListener']/method[@name='onLoadingCancelled' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.view.View']]"
		[Register ("onLoadingCancelled", "(Ljava/lang/String;Landroid/view/View;)V", "GetOnLoadingCancelled_Ljava_lang_String_Landroid_view_View_Handler")]
		public virtual void OnLoadingCancelled (string p0, global::Android.Views.View p1)
		{
			if (id_onLoadingCancelled_Ljava_lang_String_Landroid_view_View_ == IntPtr.Zero)
				id_onLoadingCancelled_Ljava_lang_String_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "onLoadingCancelled", "(Ljava/lang/String;Landroid/view/View;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onLoadingCancelled_Ljava_lang_String_Landroid_view_View_, new JValue (native_p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_onLoadingCancelled_Ljava_lang_String_Landroid_view_View_, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_onLoadingComplete_Ljava_lang_String_Landroid_view_View_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
		static Delegate GetOnLoadingComplete_Ljava_lang_String_Landroid_view_View_Landroid_graphics_Bitmap_Handler ()
		{
			if (cb_onLoadingComplete_Ljava_lang_String_Landroid_view_View_Landroid_graphics_Bitmap_ == null)
				cb_onLoadingComplete_Ljava_lang_String_Landroid_view_View_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnLoadingComplete_Ljava_lang_String_Landroid_view_View_Landroid_graphics_Bitmap_);
			return cb_onLoadingComplete_Ljava_lang_String_Landroid_view_View_Landroid_graphics_Bitmap_;
		}

		static void n_OnLoadingComplete_Ljava_lang_String_Landroid_view_View_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Nostra13.Universalimageloader.Core.Assist.SimpleImageLoadingListener __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.SimpleImageLoadingListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p1 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap p2 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnLoadingComplete (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_onLoadingComplete_Ljava_lang_String_Landroid_view_View_Landroid_graphics_Bitmap_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist']/class[@name='SimpleImageLoadingListener']/method[@name='onLoadingComplete' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.view.View'] and parameter[3][@type='android.graphics.Bitmap']]"
		[Register ("onLoadingComplete", "(Ljava/lang/String;Landroid/view/View;Landroid/graphics/Bitmap;)V", "GetOnLoadingComplete_Ljava_lang_String_Landroid_view_View_Landroid_graphics_Bitmap_Handler")]
		public virtual void OnLoadingComplete (string p0, global::Android.Views.View p1, global::Android.Graphics.Bitmap p2)
		{
			if (id_onLoadingComplete_Ljava_lang_String_Landroid_view_View_Landroid_graphics_Bitmap_ == IntPtr.Zero)
				id_onLoadingComplete_Ljava_lang_String_Landroid_view_View_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "onLoadingComplete", "(Ljava/lang/String;Landroid/view/View;Landroid/graphics/Bitmap;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onLoadingComplete_Ljava_lang_String_Landroid_view_View_Landroid_graphics_Bitmap_, new JValue (native_p0), new JValue (p1), new JValue (p2));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_onLoadingComplete_Ljava_lang_String_Landroid_view_View_Landroid_graphics_Bitmap_, new JValue (native_p0), new JValue (p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_onLoadingFailed_Ljava_lang_String_Landroid_view_View_Lcom_nostra13_universalimageloader_core_assist_FailReason_;
#pragma warning disable 0169
		static Delegate GetOnLoadingFailed_Ljava_lang_String_Landroid_view_View_Lcom_nostra13_universalimageloader_core_assist_FailReason_Handler ()
		{
			if (cb_onLoadingFailed_Ljava_lang_String_Landroid_view_View_Lcom_nostra13_universalimageloader_core_assist_FailReason_ == null)
				cb_onLoadingFailed_Ljava_lang_String_Landroid_view_View_Lcom_nostra13_universalimageloader_core_assist_FailReason_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnLoadingFailed_Ljava_lang_String_Landroid_view_View_Lcom_nostra13_universalimageloader_core_assist_FailReason_);
			return cb_onLoadingFailed_Ljava_lang_String_Landroid_view_View_Lcom_nostra13_universalimageloader_core_assist_FailReason_;
		}

		static void n_OnLoadingFailed_Ljava_lang_String_Landroid_view_View_Lcom_nostra13_universalimageloader_core_assist_FailReason_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Nostra13.Universalimageloader.Core.Assist.SimpleImageLoadingListener __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.SimpleImageLoadingListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p1 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Nostra13.Universalimageloader.Core.Assist.FailReason p2 = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.FailReason> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnLoadingFailed (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_onLoadingFailed_Ljava_lang_String_Landroid_view_View_Lcom_nostra13_universalimageloader_core_assist_FailReason_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist']/class[@name='SimpleImageLoadingListener']/method[@name='onLoadingFailed' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.view.View'] and parameter[3][@type='com.nostra13.universalimageloader.core.assist.FailReason']]"
		[Register ("onLoadingFailed", "(Ljava/lang/String;Landroid/view/View;Lcom/nostra13/universalimageloader/core/assist/FailReason;)V", "GetOnLoadingFailed_Ljava_lang_String_Landroid_view_View_Lcom_nostra13_universalimageloader_core_assist_FailReason_Handler")]
		public virtual void OnLoadingFailed (string p0, global::Android.Views.View p1, global::Com.Nostra13.Universalimageloader.Core.Assist.FailReason p2)
		{
			if (id_onLoadingFailed_Ljava_lang_String_Landroid_view_View_Lcom_nostra13_universalimageloader_core_assist_FailReason_ == IntPtr.Zero)
				id_onLoadingFailed_Ljava_lang_String_Landroid_view_View_Lcom_nostra13_universalimageloader_core_assist_FailReason_ = JNIEnv.GetMethodID (class_ref, "onLoadingFailed", "(Ljava/lang/String;Landroid/view/View;Lcom/nostra13/universalimageloader/core/assist/FailReason;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onLoadingFailed_Ljava_lang_String_Landroid_view_View_Lcom_nostra13_universalimageloader_core_assist_FailReason_, new JValue (native_p0), new JValue (p1), new JValue (p2));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_onLoadingFailed_Ljava_lang_String_Landroid_view_View_Lcom_nostra13_universalimageloader_core_assist_FailReason_, new JValue (native_p0), new JValue (p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_onLoadingStarted_Ljava_lang_String_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetOnLoadingStarted_Ljava_lang_String_Landroid_view_View_Handler ()
		{
			if (cb_onLoadingStarted_Ljava_lang_String_Landroid_view_View_ == null)
				cb_onLoadingStarted_Ljava_lang_String_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnLoadingStarted_Ljava_lang_String_Landroid_view_View_);
			return cb_onLoadingStarted_Ljava_lang_String_Landroid_view_View_;
		}

		static void n_OnLoadingStarted_Ljava_lang_String_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Nostra13.Universalimageloader.Core.Assist.SimpleImageLoadingListener __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.SimpleImageLoadingListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p1 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnLoadingStarted (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onLoadingStarted_Ljava_lang_String_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist']/class[@name='SimpleImageLoadingListener']/method[@name='onLoadingStarted' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.view.View']]"
		[Register ("onLoadingStarted", "(Ljava/lang/String;Landroid/view/View;)V", "GetOnLoadingStarted_Ljava_lang_String_Landroid_view_View_Handler")]
		public virtual void OnLoadingStarted (string p0, global::Android.Views.View p1)
		{
			if (id_onLoadingStarted_Ljava_lang_String_Landroid_view_View_ == IntPtr.Zero)
				id_onLoadingStarted_Ljava_lang_String_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "onLoadingStarted", "(Ljava/lang/String;Landroid/view/View;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onLoadingStarted_Ljava_lang_String_Landroid_view_View_, new JValue (native_p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_onLoadingStarted_Ljava_lang_String_Landroid_view_View_, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}
}
