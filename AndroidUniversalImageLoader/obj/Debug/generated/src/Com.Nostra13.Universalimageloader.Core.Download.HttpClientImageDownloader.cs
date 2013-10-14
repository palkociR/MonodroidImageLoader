using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nostra13.Universalimageloader.Core.Download {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nostra13.universalimageloader.core.download']/class[@name='HttpClientImageDownloader']"
	[global::Android.Runtime.Register ("com/nostra13/universalimageloader/core/download/HttpClientImageDownloader", DoNotGenerateAcw=true)]
	public partial class HttpClientImageDownloader : global::Com.Nostra13.Universalimageloader.Core.Download.BaseImageDownloader {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/nostra13/universalimageloader/core/download/HttpClientImageDownloader", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HttpClientImageDownloader); }
		}

		protected HttpClientImageDownloader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Lorg_apache_http_client_HttpClient_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nostra13.universalimageloader.core.download']/class[@name='HttpClientImageDownloader']/constructor[@name='HttpClientImageDownloader' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='org.apache.http.client.HttpClient']]"
		[Register (".ctor", "(Landroid/content/Context;Lorg/apache/http/client/HttpClient;)V", "")]
		public HttpClientImageDownloader (global::Android.Content.Context p0, global::Org.Apache.Http.Client.IHttpClient p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (HttpClientImageDownloader)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Landroid/content/Context;Lorg/apache/http/client/HttpClient;)V", new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor_Landroid_content_Context_Lorg_apache_http_client_HttpClient_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_Lorg_apache_http_client_HttpClient_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Lorg/apache/http/client/HttpClient;)V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Landroid_content_Context_Lorg_apache_http_client_HttpClient_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
		}

	}
}
