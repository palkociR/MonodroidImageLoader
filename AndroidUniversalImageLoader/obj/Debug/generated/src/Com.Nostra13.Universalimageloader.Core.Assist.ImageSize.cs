using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nostra13.Universalimageloader.Core.Assist {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist']/class[@name='ImageSize']"
	[global::Android.Runtime.Register ("com/nostra13/universalimageloader/core/assist/ImageSize", DoNotGenerateAcw=true)]
	public partial class ImageSize : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/nostra13/universalimageloader/core/assist/ImageSize", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ImageSize); }
		}

		protected ImageSize (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_II;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist']/class[@name='ImageSize']/constructor[@name='ImageSize' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register (".ctor", "(II)V", "")]
		public ImageSize (int p0, int p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ImageSize)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(II)V", new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor_II == IntPtr.Zero)
				id_ctor_II = JNIEnv.GetMethodID (class_ref, "<init>", "(II)V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor_II, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_ctor_III;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist']/class[@name='ImageSize']/constructor[@name='ImageSize' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register (".ctor", "(III)V", "")]
		public ImageSize (int p0, int p1, int p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ImageSize)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(III)V", new JValue (p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor_III == IntPtr.Zero)
				id_ctor_III = JNIEnv.GetMethodID (class_ref, "<init>", "(III)V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor_III, new JValue (p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_getHeight;
#pragma warning disable 0169
		static Delegate GetGetHeightHandler ()
		{
			if (cb_getHeight == null)
				cb_getHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetHeight);
			return cb_getHeight;
		}

		static int n_GetHeight (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nostra13.Universalimageloader.Core.Assist.ImageSize __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.ImageSize> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Height;
		}
#pragma warning restore 0169

		static IntPtr id_getHeight;
		public virtual int Height {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist']/class[@name='ImageSize']/method[@name='getHeight' and count(parameter)=0]"
			[Register ("getHeight", "()I", "GetGetHeightHandler")]
			get {
				if (id_getHeight == IntPtr.Zero)
					id_getHeight = JNIEnv.GetMethodID (class_ref, "getHeight", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getHeight);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, id_getHeight);
			}
		}

		static Delegate cb_getWidth;
#pragma warning disable 0169
		static Delegate GetGetWidthHandler ()
		{
			if (cb_getWidth == null)
				cb_getWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetWidth);
			return cb_getWidth;
		}

		static int n_GetWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nostra13.Universalimageloader.Core.Assist.ImageSize __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.ImageSize> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Width;
		}
#pragma warning restore 0169

		static IntPtr id_getWidth;
		public virtual int Width {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist']/class[@name='ImageSize']/method[@name='getWidth' and count(parameter)=0]"
			[Register ("getWidth", "()I", "GetGetWidthHandler")]
			get {
				if (id_getWidth == IntPtr.Zero)
					id_getWidth = JNIEnv.GetMethodID (class_ref, "getWidth", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getWidth);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, id_getWidth);
			}
		}

		static Delegate cb_scale_F;
#pragma warning disable 0169
		static Delegate GetScale_FHandler ()
		{
			if (cb_scale_F == null)
				cb_scale_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr>) n_Scale_F);
			return cb_scale_F;
		}

		static IntPtr n_Scale_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Nostra13.Universalimageloader.Core.Assist.ImageSize __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.ImageSize> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Scale (p0));
		}
#pragma warning restore 0169

		static IntPtr id_scale_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist']/class[@name='ImageSize']/method[@name='scale' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("scale", "(F)Lcom/nostra13/universalimageloader/core/assist/ImageSize;", "GetScale_FHandler")]
		public virtual global::Com.Nostra13.Universalimageloader.Core.Assist.ImageSize Scale (float p0)
		{
			if (id_scale_F == IntPtr.Zero)
				id_scale_F = JNIEnv.GetMethodID (class_ref, "scale", "(F)Lcom/nostra13/universalimageloader/core/assist/ImageSize;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.ImageSize> (JNIEnv.CallObjectMethod  (Handle, id_scale_F, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.ImageSize> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_scale_F, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_scaleDown_I;
#pragma warning disable 0169
		static Delegate GetScaleDown_IHandler ()
		{
			if (cb_scaleDown_I == null)
				cb_scaleDown_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_ScaleDown_I);
			return cb_scaleDown_I;
		}

		static IntPtr n_ScaleDown_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Nostra13.Universalimageloader.Core.Assist.ImageSize __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.ImageSize> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ScaleDown (p0));
		}
#pragma warning restore 0169

		static IntPtr id_scaleDown_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist']/class[@name='ImageSize']/method[@name='scaleDown' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("scaleDown", "(I)Lcom/nostra13/universalimageloader/core/assist/ImageSize;", "GetScaleDown_IHandler")]
		public virtual global::Com.Nostra13.Universalimageloader.Core.Assist.ImageSize ScaleDown (int p0)
		{
			if (id_scaleDown_I == IntPtr.Zero)
				id_scaleDown_I = JNIEnv.GetMethodID (class_ref, "scaleDown", "(I)Lcom/nostra13/universalimageloader/core/assist/ImageSize;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.ImageSize> (JNIEnv.CallObjectMethod  (Handle, id_scaleDown_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.ImageSize> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_scaleDown_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

	}
}
