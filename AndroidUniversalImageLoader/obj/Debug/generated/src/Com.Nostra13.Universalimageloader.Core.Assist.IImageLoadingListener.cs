using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nostra13.Universalimageloader.Core.Assist {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist']/interface[@name='ImageLoadingListener']"
	[Register ("com/nostra13/universalimageloader/core/assist/ImageLoadingListener", "", "Com.Nostra13.Universalimageloader.Core.Assist.IImageLoadingListenerInvoker")]
	public partial interface IImageLoadingListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist']/interface[@name='ImageLoadingListener']/method[@name='onLoadingCancelled' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.view.View']]"
		[Register ("onLoadingCancelled", "(Ljava/lang/String;Landroid/view/View;)V", "GetOnLoadingCancelled_Ljava_lang_String_Landroid_view_View_Handler:Com.Nostra13.Universalimageloader.Core.Assist.IImageLoadingListenerInvoker, AndroidUniversalImageLoader")]
		void OnLoadingCancelled (string p0, global::Android.Views.View p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist']/interface[@name='ImageLoadingListener']/method[@name='onLoadingComplete' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.view.View'] and parameter[3][@type='android.graphics.Bitmap']]"
		[Register ("onLoadingComplete", "(Ljava/lang/String;Landroid/view/View;Landroid/graphics/Bitmap;)V", "GetOnLoadingComplete_Ljava_lang_String_Landroid_view_View_Landroid_graphics_Bitmap_Handler:Com.Nostra13.Universalimageloader.Core.Assist.IImageLoadingListenerInvoker, AndroidUniversalImageLoader")]
		void OnLoadingComplete (string p0, global::Android.Views.View p1, global::Android.Graphics.Bitmap p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist']/interface[@name='ImageLoadingListener']/method[@name='onLoadingFailed' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.view.View'] and parameter[3][@type='com.nostra13.universalimageloader.core.assist.FailReason']]"
		[Register ("onLoadingFailed", "(Ljava/lang/String;Landroid/view/View;Lcom/nostra13/universalimageloader/core/assist/FailReason;)V", "GetOnLoadingFailed_Ljava_lang_String_Landroid_view_View_Lcom_nostra13_universalimageloader_core_assist_FailReason_Handler:Com.Nostra13.Universalimageloader.Core.Assist.IImageLoadingListenerInvoker, AndroidUniversalImageLoader")]
		void OnLoadingFailed (string p0, global::Android.Views.View p1, global::Com.Nostra13.Universalimageloader.Core.Assist.FailReason p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist']/interface[@name='ImageLoadingListener']/method[@name='onLoadingStarted' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.view.View']]"
		[Register ("onLoadingStarted", "(Ljava/lang/String;Landroid/view/View;)V", "GetOnLoadingStarted_Ljava_lang_String_Landroid_view_View_Handler:Com.Nostra13.Universalimageloader.Core.Assist.IImageLoadingListenerInvoker, AndroidUniversalImageLoader")]
		void OnLoadingStarted (string p0, global::Android.Views.View p1);

	}

	[global::Android.Runtime.Register ("com/nostra13/universalimageloader/core/assist/ImageLoadingListener", DoNotGenerateAcw=true)]
	internal class IImageLoadingListenerInvoker : global::Java.Lang.Object, IImageLoadingListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/nostra13/universalimageloader/core/assist/ImageLoadingListener");
		IntPtr class_ref;

		public static IImageLoadingListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IImageLoadingListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.nostra13.universalimageloader.core.assist.ImageLoadingListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IImageLoadingListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IImageLoadingListenerInvoker); }
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
			global::Com.Nostra13.Universalimageloader.Core.Assist.IImageLoadingListener __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.IImageLoadingListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p1 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnLoadingCancelled (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onLoadingCancelled_Ljava_lang_String_Landroid_view_View_;
		public void OnLoadingCancelled (string p0, global::Android.Views.View p1)
		{
			if (id_onLoadingCancelled_Ljava_lang_String_Landroid_view_View_ == IntPtr.Zero)
				id_onLoadingCancelled_Ljava_lang_String_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "onLoadingCancelled", "(Ljava/lang/String;Landroid/view/View;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallVoidMethod (Handle, id_onLoadingCancelled_Ljava_lang_String_Landroid_view_View_, new JValue (native_p0), new JValue (p1));
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
			global::Com.Nostra13.Universalimageloader.Core.Assist.IImageLoadingListener __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.IImageLoadingListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p1 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap p2 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnLoadingComplete (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_onLoadingComplete_Ljava_lang_String_Landroid_view_View_Landroid_graphics_Bitmap_;
		public void OnLoadingComplete (string p0, global::Android.Views.View p1, global::Android.Graphics.Bitmap p2)
		{
			if (id_onLoadingComplete_Ljava_lang_String_Landroid_view_View_Landroid_graphics_Bitmap_ == IntPtr.Zero)
				id_onLoadingComplete_Ljava_lang_String_Landroid_view_View_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "onLoadingComplete", "(Ljava/lang/String;Landroid/view/View;Landroid/graphics/Bitmap;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallVoidMethod (Handle, id_onLoadingComplete_Ljava_lang_String_Landroid_view_View_Landroid_graphics_Bitmap_, new JValue (native_p0), new JValue (p1), new JValue (p2));
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
			global::Com.Nostra13.Universalimageloader.Core.Assist.IImageLoadingListener __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.IImageLoadingListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p1 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Nostra13.Universalimageloader.Core.Assist.FailReason p2 = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.FailReason> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnLoadingFailed (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_onLoadingFailed_Ljava_lang_String_Landroid_view_View_Lcom_nostra13_universalimageloader_core_assist_FailReason_;
		public void OnLoadingFailed (string p0, global::Android.Views.View p1, global::Com.Nostra13.Universalimageloader.Core.Assist.FailReason p2)
		{
			if (id_onLoadingFailed_Ljava_lang_String_Landroid_view_View_Lcom_nostra13_universalimageloader_core_assist_FailReason_ == IntPtr.Zero)
				id_onLoadingFailed_Ljava_lang_String_Landroid_view_View_Lcom_nostra13_universalimageloader_core_assist_FailReason_ = JNIEnv.GetMethodID (class_ref, "onLoadingFailed", "(Ljava/lang/String;Landroid/view/View;Lcom/nostra13/universalimageloader/core/assist/FailReason;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallVoidMethod (Handle, id_onLoadingFailed_Ljava_lang_String_Landroid_view_View_Lcom_nostra13_universalimageloader_core_assist_FailReason_, new JValue (native_p0), new JValue (p1), new JValue (p2));
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
			global::Com.Nostra13.Universalimageloader.Core.Assist.IImageLoadingListener __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.IImageLoadingListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p1 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnLoadingStarted (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onLoadingStarted_Ljava_lang_String_Landroid_view_View_;
		public void OnLoadingStarted (string p0, global::Android.Views.View p1)
		{
			if (id_onLoadingStarted_Ljava_lang_String_Landroid_view_View_ == IntPtr.Zero)
				id_onLoadingStarted_Ljava_lang_String_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "onLoadingStarted", "(Ljava/lang/String;Landroid/view/View;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallVoidMethod (Handle, id_onLoadingStarted_Ljava_lang_String_Landroid_view_View_, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

	public partial class LoadingCancelledEventArgs : global::System.EventArgs {

		public LoadingCancelledEventArgs (string p0, global::Android.Views.View p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		string p0;
		public string P0 {
			get { return p0; }
		}

		global::Android.Views.View p1;
		public global::Android.Views.View P1 {
			get { return p1; }
		}
	}

	public partial class LoadingCompleteEventArgs : global::System.EventArgs {

		public LoadingCompleteEventArgs (string p0, global::Android.Views.View p1, global::Android.Graphics.Bitmap p2)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
		}

		string p0;
		public string P0 {
			get { return p0; }
		}

		global::Android.Views.View p1;
		public global::Android.Views.View P1 {
			get { return p1; }
		}

		global::Android.Graphics.Bitmap p2;
		public global::Android.Graphics.Bitmap P2 {
			get { return p2; }
		}
	}

	public partial class LoadingFailedEventArgs : global::System.EventArgs {

		public LoadingFailedEventArgs (string p0, global::Android.Views.View p1, global::Com.Nostra13.Universalimageloader.Core.Assist.FailReason p2)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
		}

		string p0;
		public string P0 {
			get { return p0; }
		}

		global::Android.Views.View p1;
		public global::Android.Views.View P1 {
			get { return p1; }
		}

		global::Com.Nostra13.Universalimageloader.Core.Assist.FailReason p2;
		public global::Com.Nostra13.Universalimageloader.Core.Assist.FailReason P2 {
			get { return p2; }
		}
	}

	public partial class LoadingStartedEventArgs : global::System.EventArgs {

		public LoadingStartedEventArgs (string p0, global::Android.Views.View p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		string p0;
		public string P0 {
			get { return p0; }
		}

		global::Android.Views.View p1;
		public global::Android.Views.View P1 {
			get { return p1; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/nostra13/universalimageloader/core/assist/ImageLoadingListenerImplementor")]
	internal sealed class IImageLoadingListenerImplementor : global::Java.Lang.Object, IImageLoadingListener {

		object sender;

		public IImageLoadingListenerImplementor (object sender)
			: base (global::Android.Runtime.JNIEnv.CreateInstance ("mono/com/nostra13/universalimageloader/core/assist/ImageLoadingListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
		{
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<LoadingCancelledEventArgs> OnLoadingCancelledHandler;
#pragma warning restore 0649

		public void OnLoadingCancelled (string p0, global::Android.Views.View p1)
		{
			var __h = OnLoadingCancelledHandler;
			if (__h != null)
				__h (sender, new LoadingCancelledEventArgs (p0, p1));
		}
#pragma warning disable 0649
		public EventHandler<LoadingCompleteEventArgs> OnLoadingCompleteHandler;
#pragma warning restore 0649

		public void OnLoadingComplete (string p0, global::Android.Views.View p1, global::Android.Graphics.Bitmap p2)
		{
			var __h = OnLoadingCompleteHandler;
			if (__h != null)
				__h (sender, new LoadingCompleteEventArgs (p0, p1, p2));
		}
#pragma warning disable 0649
		public EventHandler<LoadingFailedEventArgs> OnLoadingFailedHandler;
#pragma warning restore 0649

		public void OnLoadingFailed (string p0, global::Android.Views.View p1, global::Com.Nostra13.Universalimageloader.Core.Assist.FailReason p2)
		{
			var __h = OnLoadingFailedHandler;
			if (__h != null)
				__h (sender, new LoadingFailedEventArgs (p0, p1, p2));
		}
#pragma warning disable 0649
		public EventHandler<LoadingStartedEventArgs> OnLoadingStartedHandler;
#pragma warning restore 0649

		public void OnLoadingStarted (string p0, global::Android.Views.View p1)
		{
			var __h = OnLoadingStartedHandler;
			if (__h != null)
				__h (sender, new LoadingStartedEventArgs (p0, p1));
		}

		internal static bool __IsEmpty (IImageLoadingListenerImplementor value)
		{
			return value.OnLoadingCancelledHandler == null && value.OnLoadingCompleteHandler == null && value.OnLoadingFailedHandler == null && value.OnLoadingStartedHandler == null;
		}
	}

}
