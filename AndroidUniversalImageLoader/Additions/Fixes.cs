using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

// Fixes to get rid of "does not implement inherited abstract member" errors
namespace Com.Nostra13.Universalimageloader.Cache.Memory.Impl
{
	partial class FIFOLimitedMemoryCache
	{
		protected override int GetSize (Java.Lang.Object value)
		{
			return GetSize (value);
		}

		protected override Java.Lang.Ref.Reference CreateReference (Java.Lang.Object value)
		{
			return CreateReference (value);
		}
	}

	partial class LargestLimitedMemoryCache
	{
		protected override int GetSize (Java.Lang.Object value)
		{
			return GetSize (value);
		}

		protected override Java.Lang.Ref.Reference CreateReference (Java.Lang.Object value)
		{
			return CreateReference (value);
		}
	}

	partial class LRULimitedMemoryCache
	{
		protected override int GetSize (Java.Lang.Object value)
		{
			return GetSize (value);
		}

		protected override Java.Lang.Ref.Reference CreateReference (Java.Lang.Object value)
		{
			return CreateReference (value);
		}
	}

	partial class UsingFreqLimitedMemoryCache
	{
		protected override int GetSize (Java.Lang.Object value)
		{
			return GetSize (value);
		}

		protected override Java.Lang.Ref.Reference CreateReference (Java.Lang.Object value)
		{
			return CreateReference (value);
		}
	}

	partial class WeakMemoryCache
	{
		protected override Java.Lang.Ref.Reference CreateReference (Java.Lang.Object value)
		{
			return CreateReference (value);
		}
	}
	// Fixing ther error 'Com.Nostra13.Universalimageloader.Cache.Memory.Impl.LruMemoryCache' does not implement interface member 'Com.Nostra13.Universalimageloader.Cache.Memory.IMemoryCacheAware.Keys()'. 'Com.Nostra13.Universalimageloader.Cache.Memory.Impl.LruMemoryCache.Keys()' 
	// cannot implement 'Com.Nostra13.Universalimageloader.Cache.Memory.IMemoryCacheAware.Keys()' because it does not have the matching return type of 'System.Collections.ICollection'. -->
	partial class LruMemoryCache
	{
		System.Collections.ICollection Com.Nostra13.Universalimageloader.Cache.Memory.IMemoryCacheAware.Keys ()
		{
			return (System.Collections.ICollection)Keys ();
		}
	}
}
namespace Com.Nostra13.Universalimageloader.Core.Assist.Deque
{
	partial class LinkedBlockingDeque
	{
		partial class DescendingItr
		{
			public override Java.Lang.Object Next ()
			{
				return Next ();
			}
		};

		partial class Itr
		{
			public override Java.Lang.Object Next ()
			{
				return Next ();
			}
		}
	}
}