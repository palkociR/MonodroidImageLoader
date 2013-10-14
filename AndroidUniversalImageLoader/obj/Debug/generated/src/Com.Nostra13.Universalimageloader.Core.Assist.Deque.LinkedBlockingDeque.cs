using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nostra13.Universalimageloader.Core.Assist.Deque {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist.deque']/class[@name='LinkedBlockingDeque']"
	[global::Android.Runtime.Register ("com/nostra13/universalimageloader/core/assist/deque/LinkedBlockingDeque", DoNotGenerateAcw=true)]
	public partial class LinkedBlockingDeque : global::Java.Util.AbstractQueue, global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDeque, global::Java.IO.ISerializable {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist.deque']/class[@name='LinkedBlockingDeque.AbstractItr']"
		[global::Android.Runtime.Register ("com/nostra13/universalimageloader/core/assist/deque/LinkedBlockingDeque$AbstractItr", DoNotGenerateAcw=true)]
		public abstract partial class AbstractItr : global::Java.Lang.Object, global::Java.Util.IIterator {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/nostra13/universalimageloader/core/assist/deque/LinkedBlockingDeque$AbstractItr", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (AbstractItr); }
			}

			protected AbstractItr (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_hasNext;
#pragma warning disable 0169
			static Delegate GetHasNextHandler ()
			{
				if (cb_hasNext == null)
					cb_hasNext = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasNext);
				return cb_hasNext;
			}

			static bool n_HasNext (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.LinkedBlockingDeque.AbstractItr __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.LinkedBlockingDeque.AbstractItr> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.HasNext;
			}
#pragma warning restore 0169

			static IntPtr id_hasNext;
			public virtual bool HasNext {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist.deque']/class[@name='LinkedBlockingDeque.AbstractItr']/method[@name='hasNext' and count(parameter)=0]"
				[Register ("hasNext", "()Z", "GetHasNextHandler")]
				get {
					if (id_hasNext == IntPtr.Zero)
						id_hasNext = JNIEnv.GetMethodID (class_ref, "hasNext", "()Z");

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_hasNext);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_hasNext);
				}
			}

			static Delegate cb_remove;
#pragma warning disable 0169
			static Delegate GetRemoveHandler ()
			{
				if (cb_remove == null)
					cb_remove = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Remove);
				return cb_remove;
			}

			static void n_Remove (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.LinkedBlockingDeque.AbstractItr __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.LinkedBlockingDeque.AbstractItr> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Remove ();
			}
#pragma warning restore 0169

			static IntPtr id_remove;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist.deque']/class[@name='LinkedBlockingDeque.AbstractItr']/method[@name='remove' and count(parameter)=0]"
			[Register ("remove", "()V", "GetRemoveHandler")]
			public virtual void Remove ()
			{
				if (id_remove == IntPtr.Zero)
					id_remove = JNIEnv.GetMethodID (class_ref, "remove", "()V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_remove);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_remove);
			}

			static Delegate cb_next;
#pragma warning disable 0169
			static Delegate GetNextHandler ()
			{
				if (cb_next == null)
					cb_next = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Next);
				return cb_next;
			}

			static IntPtr n_Next (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.LinkedBlockingDeque.AbstractItr __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.LinkedBlockingDeque.AbstractItr> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Next ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist.deque']/class[@name='LinkedBlockingDeque.AbstractItr']/method[@name='next' and count(parameter)=0]"
			[Register ("next", "()Ljava/lang/Object;", "GetNextHandler")]
			public abstract global::Java.Lang.Object Next ();

		}

		[global::Android.Runtime.Register ("com/nostra13/universalimageloader/core/assist/deque/LinkedBlockingDeque$AbstractItr", DoNotGenerateAcw=true)]
		internal partial class AbstractItrInvoker : AbstractItr {

			public AbstractItrInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

			protected override global::System.Type ThresholdType {
				get { return typeof (AbstractItrInvoker); }
			}

			static IntPtr id_next;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist.deque']/class[@name='LinkedBlockingDeque.AbstractItr']/method[@name='next' and count(parameter)=0]"
			[Register ("next", "()Ljava/lang/Object;", "GetNextHandler")]
			public override global::Java.Lang.Object Next ()
			{
				if (id_next == IntPtr.Zero)
					id_next = JNIEnv.GetMethodID (class_ref, "next", "()Ljava/lang/Object;");
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_next), JniHandleOwnership.TransferLocalRef);
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist.deque']/class[@name='LinkedBlockingDeque.DescendingItr']"
		[global::Android.Runtime.Register ("com/nostra13/universalimageloader/core/assist/deque/LinkedBlockingDeque$DescendingItr", DoNotGenerateAcw=true)]
		public partial class DescendingItr : global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.LinkedBlockingDeque.AbstractItr {

			protected DescendingItr (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist.deque']/class[@name='LinkedBlockingDeque.Itr']"
		[global::Android.Runtime.Register ("com/nostra13/universalimageloader/core/assist/deque/LinkedBlockingDeque$Itr", DoNotGenerateAcw=true)]
		public partial class Itr : global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.LinkedBlockingDeque.AbstractItr {

			protected Itr (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist.deque']/class[@name='LinkedBlockingDeque.Node']"
		[global::Android.Runtime.Register ("com/nostra13/universalimageloader/core/assist/deque/LinkedBlockingDeque$Node", DoNotGenerateAcw=true)]
		public sealed partial class Node : global::Java.Lang.Object {

			internal Node (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/nostra13/universalimageloader/core/assist/deque/LinkedBlockingDeque", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LinkedBlockingDeque); }
		}

		protected LinkedBlockingDeque (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist.deque']/class[@name='LinkedBlockingDeque']/constructor[@name='LinkedBlockingDeque' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public LinkedBlockingDeque (int p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (LinkedBlockingDeque)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(I)V", new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor_I == IntPtr.Zero)
				id_ctor_I = JNIEnv.GetMethodID (class_ref, "<init>", "(I)V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist.deque']/class[@name='LinkedBlockingDeque']/constructor[@name='LinkedBlockingDeque' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public LinkedBlockingDeque () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (LinkedBlockingDeque)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "()V"), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_ctor_Ljava_util_Collection_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist.deque']/class[@name='LinkedBlockingDeque']/constructor[@name='LinkedBlockingDeque' and count(parameter)=1 and parameter[1][@type='java.util.Collection']]"
		[Register (".ctor", "(Ljava/util/Collection;)V", "")]
		public LinkedBlockingDeque (global::System.Collections.ICollection p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = global::Android.Runtime.JavaCollection.ToLocalJniHandle (p0);;
			if (GetType () != typeof (LinkedBlockingDeque)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Ljava/util/Collection;)V", new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (p0))), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return;
			}

			if (id_ctor_Ljava_util_Collection_ == IntPtr.Zero)
				id_ctor_Ljava_util_Collection_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/util/Collection;)V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Ljava_util_Collection_, new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (p0))), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_getFirst;
#pragma warning disable 0169
		static Delegate GetGetFirstHandler ()
		{
			if (cb_getFirst == null)
				cb_getFirst = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFirst);
			return cb_getFirst;
		}

		static IntPtr n_GetFirst (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.LinkedBlockingDeque __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.LinkedBlockingDeque> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.First);
		}
#pragma warning restore 0169

		static IntPtr id_getFirst;
		public virtual global::Java.Lang.Object First {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist.deque']/class[@name='LinkedBlockingDeque']/method[@name='getFirst' and count(parameter)=0]"
			[Register ("getFirst", "()Ljava/lang/Object;", "GetGetFirstHandler")]
			get {
				if (id_getFirst == IntPtr.Zero)
					id_getFirst = JNIEnv.GetMethodID (class_ref, "getFirst", "()Ljava/lang/Object;");

				if (GetType () == ThresholdType)
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_getFirst), JniHandleOwnership.TransferLocalRef);
				else
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getFirst), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getLast;
#pragma warning disable 0169
		static Delegate GetGetLastHandler ()
		{
			if (cb_getLast == null)
				cb_getLast = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLast);
			return cb_getLast;
		}

		static IntPtr n_GetLast (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.LinkedBlockingDeque __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.LinkedBlockingDeque> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Last);
		}
#pragma warning restore 0169

		static IntPtr id_getLast;
		public virtual global::Java.Lang.Object Last {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist.deque']/class[@name='LinkedBlockingDeque']/method[@name='getLast' and count(parameter)=0]"
			[Register ("getLast", "()Ljava/lang/Object;", "GetGetLastHandler")]
			get {
				if (id_getLast == IntPtr.Zero)
					id_getLast = JNIEnv.GetMethodID (class_ref, "getLast", "()Ljava/lang/Object;");

				if (GetType () == ThresholdType)
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_getLast), JniHandleOwnership.TransferLocalRef);
				else
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getLast), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_addFirst_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetAddFirst_Ljava_lang_Object_Handler ()
		{
			if (cb_addFirst_Ljava_lang_Object_ == null)
				cb_addFirst_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddFirst_Ljava_lang_Object_);
			return cb_addFirst_Ljava_lang_Object_;
		}

		static void n_AddFirst_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.LinkedBlockingDeque __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.LinkedBlockingDeque> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddFirst (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addFirst_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist.deque']/class[@name='LinkedBlockingDeque']/method[@name='addFirst' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("addFirst", "(Ljava/lang/Object;)V", "GetAddFirst_Ljava_lang_Object_Handler")]
		public virtual void AddFirst (global::Java.Lang.Object p0)
		{
			if (id_addFirst_Ljava_lang_Object_ == IntPtr.Zero)
				id_addFirst_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "addFirst", "(Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_addFirst_Ljava_lang_Object_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_addFirst_Ljava_lang_Object_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_addLast_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetAddLast_Ljava_lang_Object_Handler ()
		{
			if (cb_addLast_Ljava_lang_Object_ == null)
				cb_addLast_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddLast_Ljava_lang_Object_);
			return cb_addLast_Ljava_lang_Object_;
		}

		static void n_AddLast_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.LinkedBlockingDeque __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.LinkedBlockingDeque> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddLast (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addLast_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist.deque']/class[@name='LinkedBlockingDeque']/method[@name='addLast' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("addLast", "(Ljava/lang/Object;)V", "GetAddLast_Ljava_lang_Object_Handler")]
		public virtual void AddLast (global::Java.Lang.Object p0)
		{
			if (id_addLast_Ljava_lang_Object_ == IntPtr.Zero)
				id_addLast_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "addLast", "(Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_addLast_Ljava_lang_Object_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_addLast_Ljava_lang_Object_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_descendingIterator;
#pragma warning disable 0169
		static Delegate GetDescendingIteratorHandler ()
		{
			if (cb_descendingIterator == null)
				cb_descendingIterator = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_DescendingIterator);
			return cb_descendingIterator;
		}

		static IntPtr n_DescendingIterator (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.LinkedBlockingDeque __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.LinkedBlockingDeque> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DescendingIterator ());
		}
#pragma warning restore 0169

		static IntPtr id_descendingIterator;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist.deque']/class[@name='LinkedBlockingDeque']/method[@name='descendingIterator' and count(parameter)=0]"
		[Register ("descendingIterator", "()Ljava/util/Iterator;", "GetDescendingIteratorHandler")]
		public virtual global::Java.Util.IIterator DescendingIterator ()
		{
			if (id_descendingIterator == IntPtr.Zero)
				id_descendingIterator = JNIEnv.GetMethodID (class_ref, "descendingIterator", "()Ljava/util/Iterator;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Java.Util.IIterator> (JNIEnv.CallObjectMethod  (Handle, id_descendingIterator), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Java.Util.IIterator> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_descendingIterator), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_drainTo_Ljava_util_Collection_;
#pragma warning disable 0169
		static Delegate GetDrainTo_Ljava_util_Collection_Handler ()
		{
			if (cb_drainTo_Ljava_util_Collection_ == null)
				cb_drainTo_Ljava_util_Collection_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_DrainTo_Ljava_util_Collection_);
			return cb_drainTo_Ljava_util_Collection_;
		}

		static int n_DrainTo_Ljava_util_Collection_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.LinkedBlockingDeque __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.LinkedBlockingDeque> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.ICollection p0 = global::Android.Runtime.JavaCollection.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.DrainTo (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_drainTo_Ljava_util_Collection_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist.deque']/class[@name='LinkedBlockingDeque']/method[@name='drainTo' and count(parameter)=1 and parameter[1][@type='java.util.Collection']]"
		[Register ("drainTo", "(Ljava/util/Collection;)I", "GetDrainTo_Ljava_util_Collection_Handler")]
		public virtual int DrainTo (global::System.Collections.ICollection p0)
		{
			if (id_drainTo_Ljava_util_Collection_ == IntPtr.Zero)
				id_drainTo_Ljava_util_Collection_ = JNIEnv.GetMethodID (class_ref, "drainTo", "(Ljava/util/Collection;)I");
			IntPtr native_p0 = global::Android.Runtime.JavaCollection.ToLocalJniHandle (p0);

			int __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallIntMethod  (Handle, id_drainTo_Ljava_util_Collection_, new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (p0)));
			else
				__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, id_drainTo_Ljava_util_Collection_, new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (p0)));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_drainTo_Ljava_util_Collection_I;
#pragma warning disable 0169
		static Delegate GetDrainTo_Ljava_util_Collection_IHandler ()
		{
			if (cb_drainTo_Ljava_util_Collection_I == null)
				cb_drainTo_Ljava_util_Collection_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int>) n_DrainTo_Ljava_util_Collection_I);
			return cb_drainTo_Ljava_util_Collection_I;
		}

		static int n_DrainTo_Ljava_util_Collection_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.LinkedBlockingDeque __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.LinkedBlockingDeque> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.ICollection p0 = global::Android.Runtime.JavaCollection.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.DrainTo (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_drainTo_Ljava_util_Collection_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist.deque']/class[@name='LinkedBlockingDeque']/method[@name='drainTo' and count(parameter)=2 and parameter[1][@type='java.util.Collection'] and parameter[2][@type='int']]"
		[Register ("drainTo", "(Ljava/util/Collection;I)I", "GetDrainTo_Ljava_util_Collection_IHandler")]
		public virtual int DrainTo (global::System.Collections.ICollection p0, int p1)
		{
			if (id_drainTo_Ljava_util_Collection_I == IntPtr.Zero)
				id_drainTo_Ljava_util_Collection_I = JNIEnv.GetMethodID (class_ref, "drainTo", "(Ljava/util/Collection;I)I");
			IntPtr native_p0 = global::Android.Runtime.JavaCollection.ToLocalJniHandle (p0);

			int __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallIntMethod  (Handle, id_drainTo_Ljava_util_Collection_I, new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (p0)), new JValue (p1));
			else
				__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, id_drainTo_Ljava_util_Collection_I, new JValue (Java.Interop.JavaObjectExtensions.ToInteroperableCollection (p0)), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_iterator;
#pragma warning disable 0169
		static Delegate GetIteratorHandler ()
		{
			if (cb_iterator == null)
				cb_iterator = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Iterator);
			return cb_iterator;
		}

		static IntPtr n_Iterator (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.LinkedBlockingDeque __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.LinkedBlockingDeque> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Iterator ());
		}
#pragma warning restore 0169

		static IntPtr id_iterator;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist.deque']/class[@name='LinkedBlockingDeque']/method[@name='iterator' and count(parameter)=0]"
		[Register ("iterator", "()Ljava/util/Iterator;", "GetIteratorHandler")]
		public override global::Java.Util.IIterator Iterator ()
		{
			if (id_iterator == IntPtr.Zero)
				id_iterator = JNIEnv.GetMethodID (class_ref, "iterator", "()Ljava/util/Iterator;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Java.Util.IIterator> (JNIEnv.CallObjectMethod  (Handle, id_iterator), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Java.Util.IIterator> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_iterator), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_offer_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetOffer_Ljava_lang_Object_Handler ()
		{
			if (cb_offer_Ljava_lang_Object_ == null)
				cb_offer_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Offer_Ljava_lang_Object_);
			return cb_offer_Ljava_lang_Object_;
		}

		static bool n_Offer_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.LinkedBlockingDeque __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.LinkedBlockingDeque> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Offer (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_offer_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist.deque']/class[@name='LinkedBlockingDeque']/method[@name='offer' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("offer", "(Ljava/lang/Object;)Z", "GetOffer_Ljava_lang_Object_Handler")]
		public override bool Offer (global::Java.Lang.Object p0)
		{
			if (id_offer_Ljava_lang_Object_ == IntPtr.Zero)
				id_offer_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "offer", "(Ljava/lang/Object;)Z");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_offer_Ljava_lang_Object_, new JValue (native_p0));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_offer_Ljava_lang_Object_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_offer_Ljava_lang_Object_JLjava_util_concurrent_TimeUnit_;
#pragma warning disable 0169
		static Delegate GetOffer_Ljava_lang_Object_JLjava_util_concurrent_TimeUnit_Handler ()
		{
			if (cb_offer_Ljava_lang_Object_JLjava_util_concurrent_TimeUnit_ == null)
				cb_offer_Ljava_lang_Object_JLjava_util_concurrent_TimeUnit_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, long, IntPtr, bool>) n_Offer_Ljava_lang_Object_JLjava_util_concurrent_TimeUnit_);
			return cb_offer_Ljava_lang_Object_JLjava_util_concurrent_TimeUnit_;
		}

		static bool n_Offer_Ljava_lang_Object_JLjava_util_concurrent_TimeUnit_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1, IntPtr native_p2)
		{
			global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.LinkedBlockingDeque __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.LinkedBlockingDeque> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Concurrent.TimeUnit p2 = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.TimeUnit> (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Offer (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_offer_Ljava_lang_Object_JLjava_util_concurrent_TimeUnit_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist.deque']/class[@name='LinkedBlockingDeque']/method[@name='offer' and count(parameter)=3 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='long'] and parameter[3][@type='java.util.concurrent.TimeUnit']]"
		[Register ("offer", "(Ljava/lang/Object;JLjava/util/concurrent/TimeUnit;)Z", "GetOffer_Ljava_lang_Object_JLjava_util_concurrent_TimeUnit_Handler")]
		public virtual bool Offer (global::Java.Lang.Object p0, long p1, global::Java.Util.Concurrent.TimeUnit p2)
		{
			if (id_offer_Ljava_lang_Object_JLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
				id_offer_Ljava_lang_Object_JLjava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID (class_ref, "offer", "(Ljava/lang/Object;JLjava/util/concurrent/TimeUnit;)Z");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_offer_Ljava_lang_Object_JLjava_util_concurrent_TimeUnit_, new JValue (native_p0), new JValue (p1), new JValue (p2));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_offer_Ljava_lang_Object_JLjava_util_concurrent_TimeUnit_, new JValue (native_p0), new JValue (p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_offerFirst_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetOfferFirst_Ljava_lang_Object_Handler ()
		{
			if (cb_offerFirst_Ljava_lang_Object_ == null)
				cb_offerFirst_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OfferFirst_Ljava_lang_Object_);
			return cb_offerFirst_Ljava_lang_Object_;
		}

		static bool n_OfferFirst_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.LinkedBlockingDeque __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.LinkedBlockingDeque> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OfferFirst (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_offerFirst_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist.deque']/class[@name='LinkedBlockingDeque']/method[@name='offerFirst' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("offerFirst", "(Ljava/lang/Object;)Z", "GetOfferFirst_Ljava_lang_Object_Handler")]
		public virtual bool OfferFirst (global::Java.Lang.Object p0)
		{
			if (id_offerFirst_Ljava_lang_Object_ == IntPtr.Zero)
				id_offerFirst_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "offerFirst", "(Ljava/lang/Object;)Z");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_offerFirst_Ljava_lang_Object_, new JValue (native_p0));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_offerFirst_Ljava_lang_Object_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_offerFirst_Ljava_lang_Object_JLjava_util_concurrent_TimeUnit_;
#pragma warning disable 0169
		static Delegate GetOfferFirst_Ljava_lang_Object_JLjava_util_concurrent_TimeUnit_Handler ()
		{
			if (cb_offerFirst_Ljava_lang_Object_JLjava_util_concurrent_TimeUnit_ == null)
				cb_offerFirst_Ljava_lang_Object_JLjava_util_concurrent_TimeUnit_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, long, IntPtr, bool>) n_OfferFirst_Ljava_lang_Object_JLjava_util_concurrent_TimeUnit_);
			return cb_offerFirst_Ljava_lang_Object_JLjava_util_concurrent_TimeUnit_;
		}

		static bool n_OfferFirst_Ljava_lang_Object_JLjava_util_concurrent_TimeUnit_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1, IntPtr native_p2)
		{
			global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.LinkedBlockingDeque __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.LinkedBlockingDeque> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Concurrent.TimeUnit p2 = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.TimeUnit> (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OfferFirst (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_offerFirst_Ljava_lang_Object_JLjava_util_concurrent_TimeUnit_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist.deque']/class[@name='LinkedBlockingDeque']/method[@name='offerFirst' and count(parameter)=3 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='long'] and parameter[3][@type='java.util.concurrent.TimeUnit']]"
		[Register ("offerFirst", "(Ljava/lang/Object;JLjava/util/concurrent/TimeUnit;)Z", "GetOfferFirst_Ljava_lang_Object_JLjava_util_concurrent_TimeUnit_Handler")]
		public virtual bool OfferFirst (global::Java.Lang.Object p0, long p1, global::Java.Util.Concurrent.TimeUnit p2)
		{
			if (id_offerFirst_Ljava_lang_Object_JLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
				id_offerFirst_Ljava_lang_Object_JLjava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID (class_ref, "offerFirst", "(Ljava/lang/Object;JLjava/util/concurrent/TimeUnit;)Z");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_offerFirst_Ljava_lang_Object_JLjava_util_concurrent_TimeUnit_, new JValue (native_p0), new JValue (p1), new JValue (p2));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_offerFirst_Ljava_lang_Object_JLjava_util_concurrent_TimeUnit_, new JValue (native_p0), new JValue (p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_offerLast_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetOfferLast_Ljava_lang_Object_Handler ()
		{
			if (cb_offerLast_Ljava_lang_Object_ == null)
				cb_offerLast_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OfferLast_Ljava_lang_Object_);
			return cb_offerLast_Ljava_lang_Object_;
		}

		static bool n_OfferLast_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.LinkedBlockingDeque __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.LinkedBlockingDeque> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OfferLast (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_offerLast_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist.deque']/class[@name='LinkedBlockingDeque']/method[@name='offerLast' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("offerLast", "(Ljava/lang/Object;)Z", "GetOfferLast_Ljava_lang_Object_Handler")]
		public virtual bool OfferLast (global::Java.Lang.Object p0)
		{
			if (id_offerLast_Ljava_lang_Object_ == IntPtr.Zero)
				id_offerLast_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "offerLast", "(Ljava/lang/Object;)Z");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_offerLast_Ljava_lang_Object_, new JValue (native_p0));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_offerLast_Ljava_lang_Object_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_offerLast_Ljava_lang_Object_JLjava_util_concurrent_TimeUnit_;
#pragma warning disable 0169
		static Delegate GetOfferLast_Ljava_lang_Object_JLjava_util_concurrent_TimeUnit_Handler ()
		{
			if (cb_offerLast_Ljava_lang_Object_JLjava_util_concurrent_TimeUnit_ == null)
				cb_offerLast_Ljava_lang_Object_JLjava_util_concurrent_TimeUnit_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, long, IntPtr, bool>) n_OfferLast_Ljava_lang_Object_JLjava_util_concurrent_TimeUnit_);
			return cb_offerLast_Ljava_lang_Object_JLjava_util_concurrent_TimeUnit_;
		}

		static bool n_OfferLast_Ljava_lang_Object_JLjava_util_concurrent_TimeUnit_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1, IntPtr native_p2)
		{
			global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.LinkedBlockingDeque __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.LinkedBlockingDeque> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Concurrent.TimeUnit p2 = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.TimeUnit> (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OfferLast (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_offerLast_Ljava_lang_Object_JLjava_util_concurrent_TimeUnit_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist.deque']/class[@name='LinkedBlockingDeque']/method[@name='offerLast' and count(parameter)=3 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='long'] and parameter[3][@type='java.util.concurrent.TimeUnit']]"
		[Register ("offerLast", "(Ljava/lang/Object;JLjava/util/concurrent/TimeUnit;)Z", "GetOfferLast_Ljava_lang_Object_JLjava_util_concurrent_TimeUnit_Handler")]
		public virtual bool OfferLast (global::Java.Lang.Object p0, long p1, global::Java.Util.Concurrent.TimeUnit p2)
		{
			if (id_offerLast_Ljava_lang_Object_JLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
				id_offerLast_Ljava_lang_Object_JLjava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID (class_ref, "offerLast", "(Ljava/lang/Object;JLjava/util/concurrent/TimeUnit;)Z");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_offerLast_Ljava_lang_Object_JLjava_util_concurrent_TimeUnit_, new JValue (native_p0), new JValue (p1), new JValue (p2));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_offerLast_Ljava_lang_Object_JLjava_util_concurrent_TimeUnit_, new JValue (native_p0), new JValue (p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_peek;
#pragma warning disable 0169
		static Delegate GetPeekHandler ()
		{
			if (cb_peek == null)
				cb_peek = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Peek);
			return cb_peek;
		}

		static IntPtr n_Peek (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.LinkedBlockingDeque __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.LinkedBlockingDeque> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Peek ());
		}
#pragma warning restore 0169

		static IntPtr id_peek;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist.deque']/class[@name='LinkedBlockingDeque']/method[@name='peek' and count(parameter)=0]"
		[Register ("peek", "()Ljava/lang/Object;", "GetPeekHandler")]
		public override global::Java.Lang.Object Peek ()
		{
			if (id_peek == IntPtr.Zero)
				id_peek = JNIEnv.GetMethodID (class_ref, "peek", "()Ljava/lang/Object;");

			if (GetType () == ThresholdType)
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_peek), JniHandleOwnership.TransferLocalRef);
			else
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_peek), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_peekFirst;
#pragma warning disable 0169
		static Delegate GetPeekFirstHandler ()
		{
			if (cb_peekFirst == null)
				cb_peekFirst = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_PeekFirst);
			return cb_peekFirst;
		}

		static IntPtr n_PeekFirst (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.LinkedBlockingDeque __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.LinkedBlockingDeque> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PeekFirst ());
		}
#pragma warning restore 0169

		static IntPtr id_peekFirst;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist.deque']/class[@name='LinkedBlockingDeque']/method[@name='peekFirst' and count(parameter)=0]"
		[Register ("peekFirst", "()Ljava/lang/Object;", "GetPeekFirstHandler")]
		public virtual global::Java.Lang.Object PeekFirst ()
		{
			if (id_peekFirst == IntPtr.Zero)
				id_peekFirst = JNIEnv.GetMethodID (class_ref, "peekFirst", "()Ljava/lang/Object;");

			if (GetType () == ThresholdType)
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_peekFirst), JniHandleOwnership.TransferLocalRef);
			else
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_peekFirst), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_peekLast;
#pragma warning disable 0169
		static Delegate GetPeekLastHandler ()
		{
			if (cb_peekLast == null)
				cb_peekLast = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_PeekLast);
			return cb_peekLast;
		}

		static IntPtr n_PeekLast (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.LinkedBlockingDeque __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.LinkedBlockingDeque> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PeekLast ());
		}
#pragma warning restore 0169

		static IntPtr id_peekLast;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist.deque']/class[@name='LinkedBlockingDeque']/method[@name='peekLast' and count(parameter)=0]"
		[Register ("peekLast", "()Ljava/lang/Object;", "GetPeekLastHandler")]
		public virtual global::Java.Lang.Object PeekLast ()
		{
			if (id_peekLast == IntPtr.Zero)
				id_peekLast = JNIEnv.GetMethodID (class_ref, "peekLast", "()Ljava/lang/Object;");

			if (GetType () == ThresholdType)
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_peekLast), JniHandleOwnership.TransferLocalRef);
			else
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_peekLast), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_poll;
#pragma warning disable 0169
		static Delegate GetPollHandler ()
		{
			if (cb_poll == null)
				cb_poll = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Poll);
			return cb_poll;
		}

		static IntPtr n_Poll (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.LinkedBlockingDeque __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.LinkedBlockingDeque> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Poll ());
		}
#pragma warning restore 0169

		static IntPtr id_poll;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist.deque']/class[@name='LinkedBlockingDeque']/method[@name='poll' and count(parameter)=0]"
		[Register ("poll", "()Ljava/lang/Object;", "GetPollHandler")]
		public override global::Java.Lang.Object Poll ()
		{
			if (id_poll == IntPtr.Zero)
				id_poll = JNIEnv.GetMethodID (class_ref, "poll", "()Ljava/lang/Object;");

			if (GetType () == ThresholdType)
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_poll), JniHandleOwnership.TransferLocalRef);
			else
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_poll), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_poll_JLjava_util_concurrent_TimeUnit_;
#pragma warning disable 0169
		static Delegate GetPoll_JLjava_util_concurrent_TimeUnit_Handler ()
		{
			if (cb_poll_JLjava_util_concurrent_TimeUnit_ == null)
				cb_poll_JLjava_util_concurrent_TimeUnit_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr, IntPtr>) n_Poll_JLjava_util_concurrent_TimeUnit_);
			return cb_poll_JLjava_util_concurrent_TimeUnit_;
		}

		static IntPtr n_Poll_JLjava_util_concurrent_TimeUnit_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1)
		{
			global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.LinkedBlockingDeque __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.LinkedBlockingDeque> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Concurrent.TimeUnit p1 = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.TimeUnit> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Poll (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_poll_JLjava_util_concurrent_TimeUnit_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist.deque']/class[@name='LinkedBlockingDeque']/method[@name='poll' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit']]"
		[Register ("poll", "(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;", "GetPoll_JLjava_util_concurrent_TimeUnit_Handler")]
		public virtual global::Java.Lang.Object Poll (long p0, global::Java.Util.Concurrent.TimeUnit p1)
		{
			if (id_poll_JLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
				id_poll_JLjava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID (class_ref, "poll", "(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;");

			global::Java.Lang.Object __ret;
			if (GetType () == ThresholdType)
				__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_poll_JLjava_util_concurrent_TimeUnit_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_poll_JLjava_util_concurrent_TimeUnit_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_pollFirst;
#pragma warning disable 0169
		static Delegate GetPollFirstHandler ()
		{
			if (cb_pollFirst == null)
				cb_pollFirst = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_PollFirst);
			return cb_pollFirst;
		}

		static IntPtr n_PollFirst (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.LinkedBlockingDeque __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.LinkedBlockingDeque> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PollFirst ());
		}
#pragma warning restore 0169

		static IntPtr id_pollFirst;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist.deque']/class[@name='LinkedBlockingDeque']/method[@name='pollFirst' and count(parameter)=0]"
		[Register ("pollFirst", "()Ljava/lang/Object;", "GetPollFirstHandler")]
		public virtual global::Java.Lang.Object PollFirst ()
		{
			if (id_pollFirst == IntPtr.Zero)
				id_pollFirst = JNIEnv.GetMethodID (class_ref, "pollFirst", "()Ljava/lang/Object;");

			if (GetType () == ThresholdType)
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_pollFirst), JniHandleOwnership.TransferLocalRef);
			else
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_pollFirst), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_pollFirst_JLjava_util_concurrent_TimeUnit_;
#pragma warning disable 0169
		static Delegate GetPollFirst_JLjava_util_concurrent_TimeUnit_Handler ()
		{
			if (cb_pollFirst_JLjava_util_concurrent_TimeUnit_ == null)
				cb_pollFirst_JLjava_util_concurrent_TimeUnit_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr, IntPtr>) n_PollFirst_JLjava_util_concurrent_TimeUnit_);
			return cb_pollFirst_JLjava_util_concurrent_TimeUnit_;
		}

		static IntPtr n_PollFirst_JLjava_util_concurrent_TimeUnit_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1)
		{
			global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.LinkedBlockingDeque __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.LinkedBlockingDeque> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Concurrent.TimeUnit p1 = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.TimeUnit> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PollFirst (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_pollFirst_JLjava_util_concurrent_TimeUnit_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist.deque']/class[@name='LinkedBlockingDeque']/method[@name='pollFirst' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit']]"
		[Register ("pollFirst", "(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;", "GetPollFirst_JLjava_util_concurrent_TimeUnit_Handler")]
		public virtual global::Java.Lang.Object PollFirst (long p0, global::Java.Util.Concurrent.TimeUnit p1)
		{
			if (id_pollFirst_JLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
				id_pollFirst_JLjava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID (class_ref, "pollFirst", "(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;");

			global::Java.Lang.Object __ret;
			if (GetType () == ThresholdType)
				__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_pollFirst_JLjava_util_concurrent_TimeUnit_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_pollFirst_JLjava_util_concurrent_TimeUnit_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_pollLast;
#pragma warning disable 0169
		static Delegate GetPollLastHandler ()
		{
			if (cb_pollLast == null)
				cb_pollLast = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_PollLast);
			return cb_pollLast;
		}

		static IntPtr n_PollLast (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.LinkedBlockingDeque __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.LinkedBlockingDeque> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PollLast ());
		}
#pragma warning restore 0169

		static IntPtr id_pollLast;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist.deque']/class[@name='LinkedBlockingDeque']/method[@name='pollLast' and count(parameter)=0]"
		[Register ("pollLast", "()Ljava/lang/Object;", "GetPollLastHandler")]
		public virtual global::Java.Lang.Object PollLast ()
		{
			if (id_pollLast == IntPtr.Zero)
				id_pollLast = JNIEnv.GetMethodID (class_ref, "pollLast", "()Ljava/lang/Object;");

			if (GetType () == ThresholdType)
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_pollLast), JniHandleOwnership.TransferLocalRef);
			else
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_pollLast), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_pollLast_JLjava_util_concurrent_TimeUnit_;
#pragma warning disable 0169
		static Delegate GetPollLast_JLjava_util_concurrent_TimeUnit_Handler ()
		{
			if (cb_pollLast_JLjava_util_concurrent_TimeUnit_ == null)
				cb_pollLast_JLjava_util_concurrent_TimeUnit_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr, IntPtr>) n_PollLast_JLjava_util_concurrent_TimeUnit_);
			return cb_pollLast_JLjava_util_concurrent_TimeUnit_;
		}

		static IntPtr n_PollLast_JLjava_util_concurrent_TimeUnit_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1)
		{
			global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.LinkedBlockingDeque __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.LinkedBlockingDeque> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Concurrent.TimeUnit p1 = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.TimeUnit> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PollLast (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_pollLast_JLjava_util_concurrent_TimeUnit_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist.deque']/class[@name='LinkedBlockingDeque']/method[@name='pollLast' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit']]"
		[Register ("pollLast", "(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;", "GetPollLast_JLjava_util_concurrent_TimeUnit_Handler")]
		public virtual global::Java.Lang.Object PollLast (long p0, global::Java.Util.Concurrent.TimeUnit p1)
		{
			if (id_pollLast_JLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
				id_pollLast_JLjava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID (class_ref, "pollLast", "(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;");

			global::Java.Lang.Object __ret;
			if (GetType () == ThresholdType)
				__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_pollLast_JLjava_util_concurrent_TimeUnit_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_pollLast_JLjava_util_concurrent_TimeUnit_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_pop;
#pragma warning disable 0169
		static Delegate GetPopHandler ()
		{
			if (cb_pop == null)
				cb_pop = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Pop);
			return cb_pop;
		}

		static IntPtr n_Pop (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.LinkedBlockingDeque __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.LinkedBlockingDeque> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Pop ());
		}
#pragma warning restore 0169

		static IntPtr id_pop;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist.deque']/class[@name='LinkedBlockingDeque']/method[@name='pop' and count(parameter)=0]"
		[Register ("pop", "()Ljava/lang/Object;", "GetPopHandler")]
		public virtual global::Java.Lang.Object Pop ()
		{
			if (id_pop == IntPtr.Zero)
				id_pop = JNIEnv.GetMethodID (class_ref, "pop", "()Ljava/lang/Object;");

			if (GetType () == ThresholdType)
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_pop), JniHandleOwnership.TransferLocalRef);
			else
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_pop), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_push_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetPush_Ljava_lang_Object_Handler ()
		{
			if (cb_push_Ljava_lang_Object_ == null)
				cb_push_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Push_Ljava_lang_Object_);
			return cb_push_Ljava_lang_Object_;
		}

		static void n_Push_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.LinkedBlockingDeque __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.LinkedBlockingDeque> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Push (p0);
		}
#pragma warning restore 0169

		static IntPtr id_push_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist.deque']/class[@name='LinkedBlockingDeque']/method[@name='push' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("push", "(Ljava/lang/Object;)V", "GetPush_Ljava_lang_Object_Handler")]
		public virtual void Push (global::Java.Lang.Object p0)
		{
			if (id_push_Ljava_lang_Object_ == IntPtr.Zero)
				id_push_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "push", "(Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_push_Ljava_lang_Object_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_push_Ljava_lang_Object_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_put_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetPut_Ljava_lang_Object_Handler ()
		{
			if (cb_put_Ljava_lang_Object_ == null)
				cb_put_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Put_Ljava_lang_Object_);
			return cb_put_Ljava_lang_Object_;
		}

		static void n_Put_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.LinkedBlockingDeque __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.LinkedBlockingDeque> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Put (p0);
		}
#pragma warning restore 0169

		static IntPtr id_put_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist.deque']/class[@name='LinkedBlockingDeque']/method[@name='put' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("put", "(Ljava/lang/Object;)V", "GetPut_Ljava_lang_Object_Handler")]
		public virtual void Put (global::Java.Lang.Object p0)
		{
			if (id_put_Ljava_lang_Object_ == IntPtr.Zero)
				id_put_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "put", "(Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_put_Ljava_lang_Object_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_put_Ljava_lang_Object_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_putFirst_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetPutFirst_Ljava_lang_Object_Handler ()
		{
			if (cb_putFirst_Ljava_lang_Object_ == null)
				cb_putFirst_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_PutFirst_Ljava_lang_Object_);
			return cb_putFirst_Ljava_lang_Object_;
		}

		static void n_PutFirst_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.LinkedBlockingDeque __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.LinkedBlockingDeque> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PutFirst (p0);
		}
#pragma warning restore 0169

		static IntPtr id_putFirst_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist.deque']/class[@name='LinkedBlockingDeque']/method[@name='putFirst' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("putFirst", "(Ljava/lang/Object;)V", "GetPutFirst_Ljava_lang_Object_Handler")]
		public virtual void PutFirst (global::Java.Lang.Object p0)
		{
			if (id_putFirst_Ljava_lang_Object_ == IntPtr.Zero)
				id_putFirst_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "putFirst", "(Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_putFirst_Ljava_lang_Object_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_putFirst_Ljava_lang_Object_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_putLast_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetPutLast_Ljava_lang_Object_Handler ()
		{
			if (cb_putLast_Ljava_lang_Object_ == null)
				cb_putLast_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_PutLast_Ljava_lang_Object_);
			return cb_putLast_Ljava_lang_Object_;
		}

		static void n_PutLast_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.LinkedBlockingDeque __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.LinkedBlockingDeque> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PutLast (p0);
		}
#pragma warning restore 0169

		static IntPtr id_putLast_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist.deque']/class[@name='LinkedBlockingDeque']/method[@name='putLast' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("putLast", "(Ljava/lang/Object;)V", "GetPutLast_Ljava_lang_Object_Handler")]
		public virtual void PutLast (global::Java.Lang.Object p0)
		{
			if (id_putLast_Ljava_lang_Object_ == IntPtr.Zero)
				id_putLast_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "putLast", "(Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_putLast_Ljava_lang_Object_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_putLast_Ljava_lang_Object_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_remainingCapacity;
#pragma warning disable 0169
		static Delegate GetRemainingCapacityHandler ()
		{
			if (cb_remainingCapacity == null)
				cb_remainingCapacity = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_RemainingCapacity);
			return cb_remainingCapacity;
		}

		static int n_RemainingCapacity (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.LinkedBlockingDeque __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.LinkedBlockingDeque> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RemainingCapacity ();
		}
#pragma warning restore 0169

		static IntPtr id_remainingCapacity;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist.deque']/class[@name='LinkedBlockingDeque']/method[@name='remainingCapacity' and count(parameter)=0]"
		[Register ("remainingCapacity", "()I", "GetRemainingCapacityHandler")]
		public virtual int RemainingCapacity ()
		{
			if (id_remainingCapacity == IntPtr.Zero)
				id_remainingCapacity = JNIEnv.GetMethodID (class_ref, "remainingCapacity", "()I");

			if (GetType () == ThresholdType)
				return JNIEnv.CallIntMethod  (Handle, id_remainingCapacity);
			else
				return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, id_remainingCapacity);
		}

		static Delegate cb_removeFirst;
#pragma warning disable 0169
		static Delegate GetRemoveFirstHandler ()
		{
			if (cb_removeFirst == null)
				cb_removeFirst = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_RemoveFirst);
			return cb_removeFirst;
		}

		static IntPtr n_RemoveFirst (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.LinkedBlockingDeque __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.LinkedBlockingDeque> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RemoveFirst ());
		}
#pragma warning restore 0169

		static IntPtr id_removeFirst;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist.deque']/class[@name='LinkedBlockingDeque']/method[@name='removeFirst' and count(parameter)=0]"
		[Register ("removeFirst", "()Ljava/lang/Object;", "GetRemoveFirstHandler")]
		public virtual global::Java.Lang.Object RemoveFirst ()
		{
			if (id_removeFirst == IntPtr.Zero)
				id_removeFirst = JNIEnv.GetMethodID (class_ref, "removeFirst", "()Ljava/lang/Object;");

			if (GetType () == ThresholdType)
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_removeFirst), JniHandleOwnership.TransferLocalRef);
			else
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_removeFirst), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_removeFirstOccurrence_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetRemoveFirstOccurrence_Ljava_lang_Object_Handler ()
		{
			if (cb_removeFirstOccurrence_Ljava_lang_Object_ == null)
				cb_removeFirstOccurrence_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_RemoveFirstOccurrence_Ljava_lang_Object_);
			return cb_removeFirstOccurrence_Ljava_lang_Object_;
		}

		static bool n_RemoveFirstOccurrence_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.LinkedBlockingDeque __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.LinkedBlockingDeque> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RemoveFirstOccurrence (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_removeFirstOccurrence_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist.deque']/class[@name='LinkedBlockingDeque']/method[@name='removeFirstOccurrence' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("removeFirstOccurrence", "(Ljava/lang/Object;)Z", "GetRemoveFirstOccurrence_Ljava_lang_Object_Handler")]
		public virtual bool RemoveFirstOccurrence (global::Java.Lang.Object p0)
		{
			if (id_removeFirstOccurrence_Ljava_lang_Object_ == IntPtr.Zero)
				id_removeFirstOccurrence_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "removeFirstOccurrence", "(Ljava/lang/Object;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_removeFirstOccurrence_Ljava_lang_Object_, new JValue (p0));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_removeFirstOccurrence_Ljava_lang_Object_, new JValue (p0));
			return __ret;
		}

		static Delegate cb_removeLast;
#pragma warning disable 0169
		static Delegate GetRemoveLastHandler ()
		{
			if (cb_removeLast == null)
				cb_removeLast = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_RemoveLast);
			return cb_removeLast;
		}

		static IntPtr n_RemoveLast (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.LinkedBlockingDeque __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.LinkedBlockingDeque> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RemoveLast ());
		}
#pragma warning restore 0169

		static IntPtr id_removeLast;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist.deque']/class[@name='LinkedBlockingDeque']/method[@name='removeLast' and count(parameter)=0]"
		[Register ("removeLast", "()Ljava/lang/Object;", "GetRemoveLastHandler")]
		public virtual global::Java.Lang.Object RemoveLast ()
		{
			if (id_removeLast == IntPtr.Zero)
				id_removeLast = JNIEnv.GetMethodID (class_ref, "removeLast", "()Ljava/lang/Object;");

			if (GetType () == ThresholdType)
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_removeLast), JniHandleOwnership.TransferLocalRef);
			else
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_removeLast), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_removeLastOccurrence_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetRemoveLastOccurrence_Ljava_lang_Object_Handler ()
		{
			if (cb_removeLastOccurrence_Ljava_lang_Object_ == null)
				cb_removeLastOccurrence_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_RemoveLastOccurrence_Ljava_lang_Object_);
			return cb_removeLastOccurrence_Ljava_lang_Object_;
		}

		static bool n_RemoveLastOccurrence_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.LinkedBlockingDeque __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.LinkedBlockingDeque> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RemoveLastOccurrence (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_removeLastOccurrence_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist.deque']/class[@name='LinkedBlockingDeque']/method[@name='removeLastOccurrence' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("removeLastOccurrence", "(Ljava/lang/Object;)Z", "GetRemoveLastOccurrence_Ljava_lang_Object_Handler")]
		public virtual bool RemoveLastOccurrence (global::Java.Lang.Object p0)
		{
			if (id_removeLastOccurrence_Ljava_lang_Object_ == IntPtr.Zero)
				id_removeLastOccurrence_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "removeLastOccurrence", "(Ljava/lang/Object;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_removeLastOccurrence_Ljava_lang_Object_, new JValue (p0));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_removeLastOccurrence_Ljava_lang_Object_, new JValue (p0));
			return __ret;
		}

		static Delegate cb_size;
#pragma warning disable 0169
		static Delegate GetSizeHandler ()
		{
			if (cb_size == null)
				cb_size = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Size);
			return cb_size;
		}

		static int n_Size (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.LinkedBlockingDeque __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.LinkedBlockingDeque> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Size ();
		}
#pragma warning restore 0169

		static IntPtr id_size;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist.deque']/class[@name='LinkedBlockingDeque']/method[@name='size' and count(parameter)=0]"
		[Register ("size", "()I", "GetSizeHandler")]
		public override int Size ()
		{
			if (id_size == IntPtr.Zero)
				id_size = JNIEnv.GetMethodID (class_ref, "size", "()I");

			if (GetType () == ThresholdType)
				return JNIEnv.CallIntMethod  (Handle, id_size);
			else
				return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, id_size);
		}

		static Delegate cb_take;
#pragma warning disable 0169
		static Delegate GetTakeHandler ()
		{
			if (cb_take == null)
				cb_take = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Take);
			return cb_take;
		}

		static IntPtr n_Take (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.LinkedBlockingDeque __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.LinkedBlockingDeque> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Take ());
		}
#pragma warning restore 0169

		static IntPtr id_take;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist.deque']/class[@name='LinkedBlockingDeque']/method[@name='take' and count(parameter)=0]"
		[Register ("take", "()Ljava/lang/Object;", "GetTakeHandler")]
		public virtual global::Java.Lang.Object Take ()
		{
			if (id_take == IntPtr.Zero)
				id_take = JNIEnv.GetMethodID (class_ref, "take", "()Ljava/lang/Object;");

			if (GetType () == ThresholdType)
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_take), JniHandleOwnership.TransferLocalRef);
			else
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_take), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_takeFirst;
#pragma warning disable 0169
		static Delegate GetTakeFirstHandler ()
		{
			if (cb_takeFirst == null)
				cb_takeFirst = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_TakeFirst);
			return cb_takeFirst;
		}

		static IntPtr n_TakeFirst (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.LinkedBlockingDeque __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.LinkedBlockingDeque> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TakeFirst ());
		}
#pragma warning restore 0169

		static IntPtr id_takeFirst;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist.deque']/class[@name='LinkedBlockingDeque']/method[@name='takeFirst' and count(parameter)=0]"
		[Register ("takeFirst", "()Ljava/lang/Object;", "GetTakeFirstHandler")]
		public virtual global::Java.Lang.Object TakeFirst ()
		{
			if (id_takeFirst == IntPtr.Zero)
				id_takeFirst = JNIEnv.GetMethodID (class_ref, "takeFirst", "()Ljava/lang/Object;");

			if (GetType () == ThresholdType)
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_takeFirst), JniHandleOwnership.TransferLocalRef);
			else
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_takeFirst), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_takeLast;
#pragma warning disable 0169
		static Delegate GetTakeLastHandler ()
		{
			if (cb_takeLast == null)
				cb_takeLast = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_TakeLast);
			return cb_takeLast;
		}

		static IntPtr n_TakeLast (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.LinkedBlockingDeque __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.LinkedBlockingDeque> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TakeLast ());
		}
#pragma warning restore 0169

		static IntPtr id_takeLast;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist.deque']/class[@name='LinkedBlockingDeque']/method[@name='takeLast' and count(parameter)=0]"
		[Register ("takeLast", "()Ljava/lang/Object;", "GetTakeLastHandler")]
		public virtual global::Java.Lang.Object TakeLast ()
		{
			if (id_takeLast == IntPtr.Zero)
				id_takeLast = JNIEnv.GetMethodID (class_ref, "takeLast", "()Ljava/lang/Object;");

			if (GetType () == ThresholdType)
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_takeLast), JniHandleOwnership.TransferLocalRef);
			else
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_takeLast), JniHandleOwnership.TransferLocalRef);
		}

	}
}
