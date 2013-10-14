using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nostra13.Universalimageloader.Core.Assist {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist']/class[@name='PauseOnScrollListener']"
	[global::Android.Runtime.Register ("com/nostra13/universalimageloader/core/assist/PauseOnScrollListener", DoNotGenerateAcw=true)]
	public partial class PauseOnScrollListener : global::Java.Lang.Object, global::Android.Widget.AbsListView.IOnScrollListener {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/nostra13/universalimageloader/core/assist/PauseOnScrollListener", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PauseOnScrollListener); }
		}

		protected PauseOnScrollListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_nostra13_universalimageloader_core_ImageLoader_ZZ;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist']/class[@name='PauseOnScrollListener']/constructor[@name='PauseOnScrollListener' and count(parameter)=3 and parameter[1][@type='com.nostra13.universalimageloader.core.ImageLoader'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean']]"
		[Register (".ctor", "(Lcom/nostra13/universalimageloader/core/ImageLoader;ZZ)V", "")]
		public PauseOnScrollListener (global::Com.Nostra13.Universalimageloader.Core.ImageLoader p0, bool p1, bool p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (PauseOnScrollListener)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Lcom/nostra13/universalimageloader/core/ImageLoader;ZZ)V", new JValue (p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor_Lcom_nostra13_universalimageloader_core_ImageLoader_ZZ == IntPtr.Zero)
				id_ctor_Lcom_nostra13_universalimageloader_core_ImageLoader_ZZ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/nostra13/universalimageloader/core/ImageLoader;ZZ)V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Lcom_nostra13_universalimageloader_core_ImageLoader_ZZ, new JValue (p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_ctor_Lcom_nostra13_universalimageloader_core_ImageLoader_ZZLandroid_widget_AbsListView_OnScrollListener_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist']/class[@name='PauseOnScrollListener']/constructor[@name='PauseOnScrollListener' and count(parameter)=4 and parameter[1][@type='com.nostra13.universalimageloader.core.ImageLoader'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean'] and parameter[4][@type='android.widget.AbsListView.OnScrollListener']]"
		[Register (".ctor", "(Lcom/nostra13/universalimageloader/core/ImageLoader;ZZLandroid/widget/AbsListView$OnScrollListener;)V", "")]
		public PauseOnScrollListener (global::Com.Nostra13.Universalimageloader.Core.ImageLoader p0, bool p1, bool p2, global::Android.Widget.AbsListView.IOnScrollListener p3) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (PauseOnScrollListener)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Lcom/nostra13/universalimageloader/core/ImageLoader;ZZLandroid/widget/AbsListView$OnScrollListener;)V", new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3)), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor_Lcom_nostra13_universalimageloader_core_ImageLoader_ZZLandroid_widget_AbsListView_OnScrollListener_ == IntPtr.Zero)
				id_ctor_Lcom_nostra13_universalimageloader_core_ImageLoader_ZZLandroid_widget_AbsListView_OnScrollListener_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/nostra13/universalimageloader/core/ImageLoader;ZZLandroid/widget/AbsListView$OnScrollListener;)V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Lcom_nostra13_universalimageloader_core_ImageLoader_ZZLandroid_widget_AbsListView_OnScrollListener_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_onScroll_Landroid_widget_AbsListView_III;
#pragma warning disable 0169
		static Delegate GetOnScroll_Landroid_widget_AbsListView_IIIHandler ()
		{
			if (cb_onScroll_Landroid_widget_AbsListView_III == null)
				cb_onScroll_Landroid_widget_AbsListView_III = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int, int>) n_OnScroll_Landroid_widget_AbsListView_III);
			return cb_onScroll_Landroid_widget_AbsListView_III;
		}

		static void n_OnScroll_Landroid_widget_AbsListView_III (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, int p3)
		{
			global::Com.Nostra13.Universalimageloader.Core.Assist.PauseOnScrollListener __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.PauseOnScrollListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Widget.AbsListView p0 = global::Java.Lang.Object.GetObject<global::Android.Widget.AbsListView> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnScroll (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_onScroll_Landroid_widget_AbsListView_III;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist']/class[@name='PauseOnScrollListener']/method[@name='onScroll' and count(parameter)=4 and parameter[1][@type='android.widget.AbsListView'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("onScroll", "(Landroid/widget/AbsListView;III)V", "GetOnScroll_Landroid_widget_AbsListView_IIIHandler")]
		public virtual void OnScroll (global::Android.Widget.AbsListView p0, int p1, int p2, int p3)
		{
			if (id_onScroll_Landroid_widget_AbsListView_III == IntPtr.Zero)
				id_onScroll_Landroid_widget_AbsListView_III = JNIEnv.GetMethodID (class_ref, "onScroll", "(Landroid/widget/AbsListView;III)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onScroll_Landroid_widget_AbsListView_III, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_onScroll_Landroid_widget_AbsListView_III, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
		}

		static Delegate cb_onScrollStateChanged_Landroid_widget_AbsListView_I;
#pragma warning disable 0169
		static Delegate GetOnScrollStateChanged_Landroid_widget_AbsListView_IHandler ()
		{
			if (cb_onScrollStateChanged_Landroid_widget_AbsListView_I == null)
				cb_onScrollStateChanged_Landroid_widget_AbsListView_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_OnScrollStateChanged_Landroid_widget_AbsListView_I);
			return cb_onScrollStateChanged_Landroid_widget_AbsListView_I;
		}

		static void n_OnScrollStateChanged_Landroid_widget_AbsListView_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int native_p1)
		{
			global::Com.Nostra13.Universalimageloader.Core.Assist.PauseOnScrollListener __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.PauseOnScrollListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Widget.AbsListView p0 = global::Java.Lang.Object.GetObject<global::Android.Widget.AbsListView> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Widget.ScrollState p1 = (global::Android.Widget.ScrollState) native_p1;
			__this.OnScrollStateChanged (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onScrollStateChanged_Landroid_widget_AbsListView_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist']/class[@name='PauseOnScrollListener']/method[@name='onScrollStateChanged' and count(parameter)=2 and parameter[1][@type='android.widget.AbsListView'] and parameter[2][@type='int']]"
		[Register ("onScrollStateChanged", "(Landroid/widget/AbsListView;I)V", "GetOnScrollStateChanged_Landroid_widget_AbsListView_IHandler")]
		public virtual void OnScrollStateChanged (global::Android.Widget.AbsListView p0, global::Android.Widget.ScrollState p1)
		{
			if (id_onScrollStateChanged_Landroid_widget_AbsListView_I == IntPtr.Zero)
				id_onScrollStateChanged_Landroid_widget_AbsListView_I = JNIEnv.GetMethodID (class_ref, "onScrollStateChanged", "(Landroid/widget/AbsListView;I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onScrollStateChanged_Landroid_widget_AbsListView_I, new JValue (p0), new JValue ((int) p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_onScrollStateChanged_Landroid_widget_AbsListView_I, new JValue (p0), new JValue ((int) p1));
		}

	}
}
