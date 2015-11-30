// Copyright � Microsoft Open Technologies, Inc.
// All Rights Reserved       
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with the License. You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0

// THIS CODE IS PROVIDED ON AN *AS IS* BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, EITHER EXPRESS OR IMPLIED, INCLUDING WITHOUT LIMITATION ANY IMPLIED WARRANTIES OR CONDITIONS OF TITLE, FITNESS FOR A PARTICULAR PURPOSE, MERCHANTABLITY OR NON-INFRINGEMENT.

// See the Apache 2 License for the specific language governing permissions and limitations under the License.

/* LICENSE ISSUES
* ==============
 
* The OpenSSL toolkit stays under a dual license, i.e. both the conditions of
* the OpenSSL License and the original SSLeay license apply to the toolkit.
* See below for the actual license texts. Actually both licenses are BSD-style
* Open Source licenses. In case of any license issues related to OpenSSL
* please contact openssl-core@openssl.org.
 
* OpenSSL License
* ---------------
*/

/* ====================================================================
* Copyright (c) 1998-2011 The OpenSSL Project.  All rights reserved.
*
* Redistribution and use in source and binary forms, with or without
* modification, are permitted provided that the following conditions
* are met:
*
* 1. Redistributions of source code must retain the above copyright
*    notice, this list of conditions and the following disclaimer.
*
* 2. Redistributions in binary form must reproduce the above copyright
*    notice, this list of conditions and the following disclaimer in
*    the documentation and/or other materials provided with the
*    distribution.
*
* 3. All advertising materials mentioning features or use of this
*    software must display the following acknowledgment:
*    "This product includes software developed by the OpenSSL Project
*    for use in the OpenSSL Toolkit. (http://www.openssl.org/)"
*
* 4. The names "OpenSSL Toolkit" and "OpenSSL Project" must not be used to
*    endorse or promote products derived from this software without
*    prior written permission. For written permission, please contact
*    openssl-core@openssl.org.
*
* 5. Products derived from this software may not be called "OpenSSL"
*    nor may "OpenSSL" appear in their names without prior written
*    permission of the OpenSSL Project.
*
* 6. Redistributions of any form whatsoever must retain the following
*    acknowledgment:
*    "This product includes software developed by the OpenSSL Project
*    for use in the OpenSSL Toolkit (http://www.openssl.org/)"
*
* THIS SOFTWARE IS PROVIDED BY THE OpenSSL PROJECT ``AS IS'' AND ANY
* EXPRESSED OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE
* IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR
* PURPOSE ARE DISCLAIMED.  IN NO EVENT SHALL THE OpenSSL PROJECT OR
* ITS CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL,
* SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT
* NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES;
* LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION)
* HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT,
* STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE)
* ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED
* OF THE POSSIBILITY OF SUCH DAMAGE.
* ====================================================================
*
* This product includes cryptographic software written by Eric Young
* (eay@cryptsoft.com).  This product includes software written by Tim
* Hudson (tjh@cryptsoft.com).
*
*/

//Original SSLeay License
//-----------------------

/* Copyright (C) 1995-1998 Eric Young (eay@cryptsoft.com)
* All rights reserved.
*
* This package is an SSL implementation written
* by Eric Young (eay@cryptsoft.com).
* The implementation was written so as to conform with Netscapes SSL.
*
* This library is free for commercial and non-commercial use as long as
* the following conditions are aheared to.  The following conditions
* apply to all code found in this distribution, be it the RC4, RSA,
* lhash, DES, etc., code; not just the SSL code.  The SSL documentation
* included with this distribution is covered by the same copyright terms
* except that the holder is Tim Hudson (tjh@cryptsoft.com).
*
* Copyright remains Eric Young's, and as such any Copyright notices in
* the code are not to be removed.
* If this package is used in a product, Eric Young should be given attribution
* as the author of the parts of the library used.
* This can be in the form of a textual message at program startup or
* in documentation (online or textual) provided with the package.
*
* Redistribution and use in source and binary forms, with or without
* modification, are permitted provided that the following conditions
* are met:
* 1. Redistributions of source code must retain the copyright
*    notice, this list of conditions and the following disclaimer.
* 2. Redistributions in binary form must reproduce the above copyright
*    notice, this list of conditions and the following disclaimer in the
*    documentation and/or other materials provided with the distribution.
* 3. All advertising materials mentioning features or use of this software
*    must display the following acknowledgement:
*    "This product includes cryptographic software written by
*     Eric Young (eay@cryptsoft.com)"
*    The word 'cryptographic' can be left out if the rouines from the library
*    being used are not cryptographic related :-).
* 4. If you include any Windows specific code (or a derivative thereof) from
*    the apps directory (application code) you must include an acknowledgement:
*    "This product includes software written by Tim Hudson (tjh@cryptsoft.com)"
*
* THIS SOFTWARE IS PROVIDED BY ERIC YOUNG ``AS IS'' AND
* ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE
* IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE
* ARE DISCLAIMED.  IN NO EVENT SHALL THE AUTHOR OR CONTRIBUTORS BE LIABLE
* FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL
* DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS
* OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION)
* HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT
* LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY
* OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF
* SUCH DAMAGE.
*
* The licence and distribution terms for any publically available version or
* derivative of this code cannot be changed.  i.e. this code cannot simply be
* copied and put under another distribution licence
* [including the GNU Public Licence.]
*/

// Copyright (c) 2006-2007 Frank Laub
// All rights reserved.

// Redistribution and use in source and binary forms, with or without
// modification, are permitted provided that the following conditions
// are met:
// 1. Redistributions of source code must retain the above copyright
//    notice, this list of conditions and the following disclaimer.
// 2. Redistributions in binary form must reproduce the above copyright
//    notice, this list of conditions and the following disclaimer in the
//    documentation and/or other materials provided with the distribution.
// 3. The name of the author may not be used to endorse or promote products
//    derived from this software without specific prior written permission.
//
// THIS SOFTWARE IS PROVIDED BY THE AUTHOR ``AS IS'' AND ANY EXPRESS OR
// IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES
// OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED.
// IN NO EVENT SHALL THE AUTHOR BE LIABLE FOR ANY DIRECT, INDIRECT,
// INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT
// NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE,
// DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY
// THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
// (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF
// THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace Nequeo.OpenSsl.Wrpper.Core
{
	/// <summary>
	/// The Stack class can only contain objects marked with this interface.
	/// </summary>
	public interface IStackable
	{
	}

	internal interface IStack
	{
	}

	/// <summary>
	/// Encapsultes the sk_* functions
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public class Stack<T> : BaseValueType, IStack, IList<T> where T : Base, IStackable
	{
		#region Initialization
		internal Stack(IntPtr ptr, bool owner)
			: base(ptr, owner)
		{
		}

		/// <summary>
		/// Calls sk_new_null()
		/// </summary>
		public Stack()
			: base(Native.ExpectNonNull(Native.sk_new_null()), true)
		{
		}

		#endregion

		#region Methods

		/// <summary>
		/// Calls sk_shift()
		/// </summary>
		/// <returns></returns>
		public T Shift()
		{
			IntPtr ptr = Native.sk_shift(this.ptr);
			return CreateInstance(ptr);
		}

		#endregion

		#region Enumerator
		class Enumerator : IEnumerator<T>
		{
			private Stack<T> parent;
			private int index = -1;
			public Enumerator(Stack<T> parent)
			{
				this.parent = parent;
			}

			#region IEnumerator<T> Members

			public T Current
			{
				get
				{
					if (this.index < 0 || this.index >= this.parent.Count)
						throw new InvalidOperationException();

					IntPtr ptr = Native.ExpectNonNull(Native.sk_value(this.parent.Handle, index));
					// Create a new item
					T item = parent.CreateInstance(ptr);
					// Addref the item
					item.AddRef();
					// return it
					return item;
				}
			}

			#endregion

			#region IDisposable Members
			public void Dispose()
			{
			}
			#endregion

			#region IEnumerator Members

			object System.Collections.IEnumerator.Current
			{
				get { return this.Current; }
			}

			public bool MoveNext()
			{
				this.index++;
				if (this.index < this.parent.Count)
					return true;
				return false;
			}

			public void Reset()
			{
				this.index = -1;
			}

			#endregion
		}
		#endregion

		#region Overrides
		/// <summary>
		/// Calls sk_free()
		/// </summary>
		protected override void OnDispose()
		{
			// Free the items
			Clear();

			Native.sk_free(this.ptr);
		}

		/// <summary>
		/// Calls sk_dup()
		/// </summary>
		/// <returns></returns>
		internal override IntPtr DuplicateHandle()
		{
			return Native.sk_dup(this.ptr);
		}

		#endregion

		#region IList<T> Members

		/// <summary>
		/// Returns sk_find()
		/// </summary>
		/// <param name="item"></param>
		/// <returns></returns>
		public int IndexOf(T item)
		{
			return Native.sk_find(this.ptr, item.Handle);
		}

		/// <summary>
		/// Calls sk_insert()
		/// </summary>
		/// <param name="index"></param>
		/// <param name="item"></param>
		public void Insert(int index, T item)
		{
			// Insert the item into the stack
			Native.ExpectSuccess(Native.sk_insert(this.ptr, item.Handle, index));
			// Addref the item
			item.AddRef();
		}

		/// <summary>
		/// Calls sk_delete()
		/// </summary>
		/// <param name="index"></param>
		public void RemoveAt(int index)
		{
			Native.ExpectNonNull(Native.sk_delete(this.ptr, index));
		}

		/// <summary>
		/// Indexer that returns sk_value() or calls sk_insert()
		/// </summary>
		/// <param name="index"></param>
		/// <returns></returns>
		public T this[int index]
		{
			get
			{
				// Get the native pointer from the stack
				IntPtr ptr = Native.ExpectNonNull(Native.sk_value(this.ptr, index));
				// Create a new object
				T item = CreateInstance(ptr);
				// Addref the object
				item.AddRef();
				// Return the managed object
				return item;
			}
			set
			{
				// Insert the item in the stack
				int ret = Native.sk_insert(this.ptr, value.Handle, index);
				if (ret < 0)
					throw new OpenSslException();
				// Addref the native pointer
				value.AddRef();
			}
		}

		#endregion

		#region ICollection<T> Members

		/// <summary>
		/// Calls sk_push()
		/// </summary>
		/// <param name="item"></param>
		public void Add(T item)
		{
			// Add the item to the stack
			if (Native.sk_push(this.ptr, item.Handle) <= 0)
				throw new OpenSslException();
			// Addref the native pointer
			item.AddRef();
		}

		/// <summary>
		/// Clear all items from the stack
		/// </summary>
		public void Clear()
		{
			IntPtr value_ptr = Native.sk_shift(this.ptr);
			while (value_ptr != IntPtr.Zero)
			{
				T item = CreateInstance(value_ptr);
				item.Dispose();
				value_ptr = Native.sk_shift(this.ptr);
			}
		}

		/// <summary>
		/// Returns true if the specified item exists in this stack.
		/// </summary>
		/// <param name="item"></param>
		/// <returns></returns>
		public bool Contains(T item)
		{
			foreach (T element in this)
			{
				if (element.Equals(item))
					return true;
			}
			return false;
			//int ret = Native.sk_find(this.ptr, item.Handle);
			//if (ret >= 0 && ret < this.Count)
			//    return true;
			//return false;
		}

		/// <summary>
		/// Not implemented
		/// </summary>
		/// <param name="array"></param>
		/// <param name="arrayIndex"></param>
		public void CopyTo(T[] array, int arrayIndex)
		{
			throw new Exception("The method or operation is not implemented.");
		}

		/// <summary>
		/// Returns sk_num()
		/// </summary>
		public int Count
		{
			get
			{
				int ret = Native.sk_num(this.ptr);
				if (ret < 0)
					throw new OpenSslException();
				return ret;
			}
		}

		/// <summary>
		/// Returns false.
		/// </summary>
		public bool IsReadOnly
		{
			get { return false; }
		}

		/// <summary>
		/// Calls sk_delete_ptr()
		/// </summary>
		/// <param name="item"></param>
		/// <returns></returns>
		public bool Remove(T item)
		{
			IntPtr ptr = Native.sk_delete_ptr(this.ptr, item.Handle);
			if (ptr != IntPtr.Zero)
			{
				return true;
			}
			return false;
		}

		#endregion

		#region IEnumerable<T> Members

		/// <summary>
		/// Returns an enumerator for this stack
		/// </summary>
		/// <returns></returns>
		public IEnumerator<T> GetEnumerator()
		{
			return new Enumerator(this);
		}

		#endregion

		#region IEnumerable Members

		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return new Enumerator(this);
		}

		#endregion

		#region Helpers

		private T CreateInstance(IntPtr ptr)
		{
			object[] args = new object[] {
				(IStack)this,
				ptr
			};
			BindingFlags flags =
				BindingFlags.NonPublic |
				BindingFlags.Public |
				BindingFlags.Instance;
			T item = (T)Activator.CreateInstance(typeof(T), flags, null, args, null);
			return item;
		}

		#endregion
	}
}
