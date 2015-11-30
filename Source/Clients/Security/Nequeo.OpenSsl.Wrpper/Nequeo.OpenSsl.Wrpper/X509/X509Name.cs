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
using System.Collections.Generic;
using System.Text;
using Nequeo.OpenSsl.Wrpper.Core;
using Nequeo.OpenSsl.Wrpper.Crypto;

namespace Nequeo.OpenSsl.Wrpper.X509
{
	/// <summary>
	/// Encapsulates the X509_NAME_* functions
	/// </summary>
	public class X509Name : BaseValueType, IComparable<X509Name>, IStackable
	{
		#region Initialization
		internal X509Name(IntPtr ptr, bool owner) 
			: base(ptr, owner) 
		{ }

		/// <summary>
		/// Calls X509_NAME_new()
		/// </summary>
		public X509Name() 
			: base(Native.ExpectNonNull(Native.X509_NAME_new()), true) 
		{ }

		/// <summary>
		/// Calls X509_NAME_dup()
		/// </summary>
		/// <param name="rhs"></param>
		public X509Name(X509Name rhs)
			: base(Native.ExpectNonNull(Native.X509_NAME_dup(rhs.ptr)), true)
		{
		}

		internal X509Name(IStack stack, IntPtr ptr)
			: base(ptr, true)
		{ }

		/// <summary>
		/// Calls X509_NAME_new()
		/// </summary>
		/// <param name="str"></param>
		public X509Name(string str)
			: this()
		{
			if (str.IndexOf('/') == -1 &&
				str.IndexOf('=') == -1)
			{
				this.Common = str;
				return;
			}

			string[] parts = str.Split('/');
			foreach (string part in parts)
			{
				if (part == "")
					continue;
				string[] nv = part.Split('=');
				string name = nv[0];
				string value = nv[1];
				this.AddEntryByName(name, value);
			}
		}

		/// <summary>
		/// Parses the string and returns an X509Name based on value.
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		public static implicit operator X509Name(string value)
		{
			return new X509Name(value);
		}
		#endregion

		#region Properties

        /// <summary>
		/// Returns X509_NAME_oneline()
		/// </summary>
		public string OneLine
		{
			get { return Native.PtrToStringAnsi(Native.X509_NAME_oneline(this.ptr, null, 0), true);	 }
		}
		
		/// <summary>
		/// Accessor to the name entry for 'CN'
		/// </summary>
		public string Common
		{
			get { return this.GetTextByName("CN"); }
			set { this.AddEntryByName("CN", value); }
		}

		/// <summary>
		/// Accessor to the name entry for 'C'
		/// </summary>
		public string Country
		{
			get { return this.GetTextByName("C"); }
			set { this.AddEntryByName("C", value); }
		}

		/// <summary>
		/// Accessor to the name entry for 'L'
		/// </summary>
		public string Locality
		{
			get { return this.GetTextByName("L"); }
			set { this.AddEntryByName("L", value); }
		}

		/// <summary>
		/// Accessor to the name entry for 'ST'
		/// </summary>
		public string StateOrProvince
		{
			get { return this.GetTextByName("ST"); }
			set { this.AddEntryByName("ST", value); }
		}

		/// <summary>
		/// Accessor to the name entry for 'O'
		/// </summary>
		public string Organization
		{
			get { return this.GetTextByName("O"); }
			set { this.AddEntryByName("O", value); }
		}

		/// <summary>
		/// Accessor to the name entry for 'OU'
		/// </summary>
		public string OrganizationUnit
		{
			get { return this.GetTextByName("OU"); }
			set { this.AddEntryByName("OU", value); }
		}

		/// <summary>
		/// Accessor to the name entry for 'G'
		/// </summary>
		public string Given
		{
			get { return this.GetTextByName("G"); }
			set { this.AddEntryByName("G", value); }
		}

		/// <summary>
		/// Accessor to the name entry for 'S'
		/// </summary>
		public string Surname
		{
			get { return this.GetTextByName("S"); }
			set { this.AddEntryByName("S", value); }
		}

		/// <summary>
		/// Accessor to the name entry for 'I'
		/// </summary>
		public string Initials
		{
			get { return this.GetTextByName("I"); }
			set { this.AddEntryByName("I", value); }
		}

		/// <summary>
		/// Accessor to the name entry for 'UID'
		/// </summary>
		public string UniqueIdentifier
		{
			get { return this.GetTextByName("UID"); }
			set { this.AddEntryByName("UID", value); }
		}

		/// <summary>
		/// Accessor to the name entry for 'SN'
		/// </summary>
		public string SerialNumber
		{
			get { return this.GetTextByName("SN"); }
			set { this.AddEntryByName("SN", value); }
		}

		/// <summary>
		/// Accessor to the name entry for 'T'
		/// </summary>
		public string Title
		{
			get { return this.GetTextByName("T"); }
			set { this.AddEntryByName("T", value); }
		}

		/// <summary>
		/// Accessor to the name entry for 'D'
		/// </summary>
		public string Description
		{
			get { return this.GetTextByName("D"); }
			set { this.AddEntryByName("D", value); }
		}

		/// <summary>
		/// Accessor to the name entry for 'X509'
		/// </summary>
		public string X509
		{
			get { return this.GetTextByName("X509"); }
			set { this.AddEntryByName("X509", value); }
		}

		/// <summary>
		/// Returns X509_NAME_entry_count()
		/// </summary>
		public int Count
		{
			get { return Native.X509_NAME_entry_count(this.ptr); }
		}

		/// <summary>
		/// Indexer to a name entry by name
		/// </summary>
		/// <param name="name"></param>
		/// <returns></returns>
		public string this[string name]
		{
			get { return this.GetTextByName(name); }
			set { this.AddEntryByName(name, value); }
		}

		/// <summary>
		/// Indexer to a name entry by index
		/// </summary>
		/// <param name="index"></param>
		/// <returns></returns>
		public string this[int index]
		{
			get 
			{
				// TODO: finish this
//				IntPtr pEntry = Native.X509_NAME_get_entry(this.ptr, index);
				return null;
			}
		}
		#endregion

		#region Methods
		/// <summary>
		/// Calls X509_NAME_add_entry_by_NID after converting the 
		/// name to a NID using OBJ_txt2nid()
		/// </summary>
		/// <param name="name"></param>
		/// <param name="value"></param>
		public void AddEntryByName(string name, string value)
		{
			this.AddEntryByNid(Native.TextToNID(name), value);
		}

		/// <summary>
		/// Calls X509_NAME_add_entry_by_NID()
		/// </summary>
		/// <param name="nid"></param>
		/// <param name="value"></param>
		public void AddEntryByNid(int nid, string value)
		{
			byte[] buf = Encoding.ASCII.GetBytes(value);
			Native.ExpectSuccess(Native.X509_NAME_add_entry_by_NID(
				this.ptr,
				nid,
				Native.MBSTRING_ASC,
				buf,
				buf.Length,
				-1,
				0));
		}

		/// <summary>
		/// Returns X509_NAME_get_text_by_NID()
		/// </summary>
		/// <param name="nid"></param>
		/// <returns></returns>
		public string GetTextByNid(int nid)
		{
			if (this.GetIndexByNid(nid, -1) == -1)
				return null;

			byte[] buf = new byte[1024];
			int len = Native.X509_NAME_get_text_by_NID(this.ptr, nid, buf, buf.Length);
			if (len <= 0)
				throw new OpenSslException();
			return Encoding.ASCII.GetString(buf, 0, len);
		}

		/// <summary>
		/// Returns X509_NAME_get_text_by_NID() after converting the name
		/// into a NID using OBJ_txt2nid()
		/// </summary>
		/// <param name="name"></param>
		/// <returns></returns>
		public string GetTextByName(string name)
		{
			return this.GetTextByNid(Native.TextToNID(name));
		}

		/// <summary>
		/// Calls X509_NAME_get_index_by_NID()
		/// </summary>
		/// <param name="nid"></param>
		/// <param name="lastpos"></param>
		/// <returns></returns>
		public int GetIndexByNid(int nid, int lastpos)
		{
			int ret = Native.X509_NAME_get_index_by_NID(this.ptr, nid, lastpos);
			if (ret == lastpos)
				return lastpos;
			if (ret < 0)
				throw new OpenSslException();
			return ret;
		}

		/// <summary>
		/// Returns the index of a name entry using GetIndexByNid()
		/// </summary>
		/// <param name="name"></param>
		/// <param name="lastpos"></param>
		/// <returns></returns>
		public int IndexOf(string name, int lastpos)
		{
			return GetIndexByNid(Native.TextToNID(name), lastpos);
		}

		/// <summary>
		/// Returns the index of a name entry using GetIndexByNid()
		/// </summary>
		/// <param name="name"></param>
		/// <returns></returns>
		public int IndexOf(string name)
		{
			return this.IndexOf(name, -1);
		}

		/// <summary>
		/// Returns true if the name entry with the specified name exists.
		/// </summary>
		/// <param name="name"></param>
		/// <returns></returns>
		public bool Contains(string name)
		{
			return this.IndexOf(name) >= 0;
		}

		/// <summary>
		/// Returns X509_NAME_digest()
		/// </summary>
		/// <param name="type"></param>
		/// <param name="cbSize"></param>
		/// <returns></returns>
		public ArraySegment<byte> Digest(MessageDigest type, int cbSize)
		{
			byte[] buf = new byte[cbSize];
			uint len = (uint)cbSize;
			Native.ExpectSuccess(Native.X509_NAME_digest(this.ptr, type.Handle, buf, ref len));
			return new ArraySegment<byte>(buf, 0, (int)len);
		}

		/// <summary>
		/// Calls X509_NAME_print_ex()
		/// </summary>
		/// <param name="bio"></param>
		public override void Print(BIO bio)
		{
			const int flags = 
				Native.ASN1_STRFLGS_RFC2253 |  
				Native.ASN1_STRFLGS_ESC_QUOTE | 
				Native.XN_FLAG_SEP_COMMA_PLUS | 
				Native.XN_FLAG_FN_SN;
			int ret = Native.X509_NAME_print_ex(bio.Handle, this.Handle, 0, flags);
			if (ret <= 0)
				throw new OpenSslException();
		}

		#endregion 

		#region Overrides

		/// <summary>
		/// Calls X509_NAME_free()
		/// </summary>
		protected override void OnDispose()
		{
			Native.X509_NAME_free(this.ptr);
		}

		internal override IntPtr DuplicateHandle()
		{
			return Native.X509_NAME_dup(this.ptr);
		}

		/// <summary>
		/// Returns CompareTo(rhs) == 0
		/// </summary>
		public override bool Equals(object rhs)
		{
			X509Name other = rhs as X509Name;
			if(other == null)
				return false;

			return this.CompareTo(other) == 0;
		}

		/// <summary>
		/// Returns ToString().GetHashCode()
		/// </summary>
		public override int GetHashCode()
		{
			return ToString().GetHashCode();
		}

		#endregion

		#region IComparable<X509Name> Members

		/// <summary>
		/// Returns X509_NAME_cmp()
		/// </summary>
		/// <param name="other"></param>
		/// <returns></returns>
		public int CompareTo(X509Name other)
		{
			return Native.X509_NAME_cmp(this.ptr, other.ptr);
		}

		#endregion
	}
}
