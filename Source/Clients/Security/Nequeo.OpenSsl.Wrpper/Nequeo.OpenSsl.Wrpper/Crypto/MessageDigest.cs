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

// Copyright (c) 2006-2011 Frank Laub
// All rights reserved.
//
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
using System.Runtime.InteropServices;
using Nequeo.OpenSsl.Wrpper.Core;

namespace Nequeo.OpenSsl.Wrpper.Crypto
{
	#region MessageDigest
	/// <summary>
	/// Wraps the EVP_MD object
	/// </summary>
	public class MessageDigest : Base
	{
		private EVP_MD raw;
		/// <summary>
		/// Creates a EVP_MD struct
		/// </summary>
		/// <param name="ptr"></param>
		/// <param name="owner"></param>
		internal MessageDigest(IntPtr ptr, bool owner) : base(ptr, owner) 
		{
			this.raw = (EVP_MD)Marshal.PtrToStructure(this.ptr, typeof(EVP_MD));
		}

		/// <summary>
		/// Prints MessageDigest
		/// </summary>
		/// <param name="bio"></param>
		public override void Print(BIO bio)
		{
			bio.Write("MessageDigest");
		}

		/// <summary>
		/// Not implemented, these objects should never be disposed.
		/// </summary>
		protected override void OnDispose() {
			throw new NotImplementedException();
		}

		/// <summary>
		/// Calls EVP_get_digestbyname()
		/// </summary>
		/// <param name="name"></param>
		/// <returns></returns>
		public static MessageDigest CreateByName(string name) {
			byte[] buf = Encoding.ASCII.GetBytes(name);
			IntPtr ptr = Native.EVP_get_digestbyname(buf);
			if (ptr == IntPtr.Zero)
				return null;
			return new MessageDigest(ptr, false);
		}

		/// <summary>
		/// Calls OBJ_NAME_do_all_sorted(OBJ_NAME_TYPE_CIPHER_METH)
		/// </summary>
		public static string[] AllNamesSorted 
		{
			get { return new NameCollector(Native.OBJ_NAME_TYPE_MD_METH, true).Result.ToArray(); }
		}

		/// <summary>
		/// Calls OBJ_NAME_do_all(OBJ_NAME_TYPE_CIPHER_METH)
		/// </summary>
		public static string[] AllNames 
		{
			get { return new NameCollector(Native.OBJ_NAME_TYPE_MD_METH, false).Result.ToArray(); }
		}

		#region EVP_MD
		[StructLayout(LayoutKind.Sequential)]
		struct EVP_MD
		{
			public int type;
			public int pkey_type;
			public int md_size;
			public uint flags;
			public IntPtr init;
			public IntPtr update;
			public IntPtr final;
			public IntPtr copy;
			public IntPtr cleanup;
			public IntPtr sign;
			public IntPtr verify;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
			public int[] required_pkey_type;
			public int block_size;
			public int ctx_size;
		}
		#endregion

		#region MessageDigests
		/// <summary>
		/// EVP_md_null()
		/// </summary>
		public static MessageDigest Null = new MessageDigest(Native.EVP_md_null(), false);

		/// <summary>
		/// EVP_md4()
		/// </summary>
		public static MessageDigest MD4 = new MessageDigest(Native.EVP_md4(), false);
		
		/// <summary>
		/// EVP_md5()
		/// </summary>
		public static MessageDigest MD5 = new MessageDigest(Native.EVP_md5(), false);
		
		/// <summary>
		/// EVP_sha()
		/// </summary>
		public static MessageDigest SHA = new MessageDigest(Native.EVP_sha(), false);
		
		/// <summary>
		/// EVP_sha1()
		/// </summary>
		public static MessageDigest SHA1 = new MessageDigest(Native.EVP_sha1(), false);
		
		/// <summary>
		/// EVP_sha224()
		/// </summary>
		public static MessageDigest SHA224 = new MessageDigest(Native.EVP_sha224(), false);
		
		/// <summary>
		/// EVP_sha256()
		/// </summary>
		public static MessageDigest SHA256 = new MessageDigest(Native.EVP_sha256(), false);
		
		/// <summary>
		/// EVP_sha384()
		/// </summary>
		public static MessageDigest SHA384 = new MessageDigest(Native.EVP_sha384(), false);
		
		/// <summary>
		/// EVP_sha512()
		/// </summary>
		public static MessageDigest SHA512 = new MessageDigest(Native.EVP_sha512(), false);
		
		/// <summary>
		/// EVP_dss()
		/// </summary>
		public static MessageDigest DSS = new MessageDigest(Native.EVP_dss(), false);
		
		/// <summary>
		/// EVP_dss1()
		/// </summary>
		public static MessageDigest DSS1 = new MessageDigest(Native.EVP_dss1(), false);
		
		/// <summary>
		/// EVP_ripemd160()
		/// </summary>
		public static MessageDigest RipeMD160 = new MessageDigest(Native.EVP_ripemd160(), false);

		/// <summary>
		/// EVP_ecdsa()
		/// </summary>
		public static MessageDigest ECDSA = new MessageDigest(Native.EVP_ecdsa(), false);
		#endregion

		#region Properties
		/// <summary>
		/// Returns the block_size field
		/// </summary>
		public int BlockSize
		{
			get { return this.raw.block_size; }
		}

		/// <summary>
		/// Returns the md_size field
		/// </summary>
		public int Size
		{
			get { return this.raw.md_size; }
		}

		/// <summary>
		/// Returns the type field using OBJ_nid2ln()
		/// </summary>
		public string LongName
		{
			get { return Native.OBJ_nid2ln(this.raw.type); }
		}

		/// <summary>
		/// Returns the type field using OBJ_nid2sn()
		/// </summary>
		public string Name
		{
			get { return Native.OBJ_nid2sn(this.raw.type); }
		}

		#endregion
	}
	#endregion

	#region EVP_MD_CTX
	[StructLayout(LayoutKind.Sequential)]
	struct EVP_MD_CTX
	{
		public IntPtr digest;
		public IntPtr engine;
		public uint flags;
		public IntPtr md_data;
		public IntPtr pctx;
		public IntPtr update;
	}
	#endregion

	/// <summary>
	/// Wraps the EVP_MD_CTX object
	/// </summary>
	public class MessageDigestContext : Base
	{
		private MessageDigest md;

		/// <summary>
		/// Calls BIO_get_md_ctx() then BIO_get_md()
		/// </summary>
		/// <param name="bio"></param>
		public MessageDigestContext(BIO bio)
			: base(Native.ExpectNonNull(Native.BIO_get_md_ctx(bio.Handle)), false)
		{
			this.md = new MessageDigest(Native.ExpectNonNull(Native.BIO_get_md(bio.Handle)), false);
		}

		/// <summary>
		/// Calls EVP_MD_CTX_create() then EVP_MD_CTX_init()
		/// </summary>
		/// <param name="md"></param>
		public MessageDigestContext(MessageDigest md)
			: base(Native.EVP_MD_CTX_create(), true)
		{
			Native.EVP_MD_CTX_init(this.ptr);
			this.md = md;
		}

		/// <summary>
		/// Prints the long name
		/// </summary>
		/// <param name="bio"></param>
		public override void Print(BIO bio)
		{
			bio.Write("MessageDigestContext: " + this.md.LongName);
		}

		#region Methods

		/// <summary>
		/// Calls EVP_DigestInit_ex(), EVP_DigestUpdate(), and EVP_DigestFinal_ex()
		/// </summary>
		/// <param name="msg"></param>
		/// <returns></returns>
		public byte[] Digest(byte[] msg) 
		{
			byte[] digest = new byte[this.md.Size];
			uint len = (uint)digest.Length;
			Native.ExpectSuccess(Native.EVP_DigestInit_ex(this.ptr, this.md.Handle, IntPtr.Zero));
			Native.ExpectSuccess(Native.EVP_DigestUpdate(this.ptr, msg, (uint)msg.Length));
			Native.ExpectSuccess(Native.EVP_DigestFinal_ex(this.ptr, digest, ref len));
			return digest;
		}

		/// <summary>
		/// Calls EVP_DigestInit_ex()
		/// </summary>
		public void Init()
		{
			Native.ExpectSuccess(Native.EVP_DigestInit_ex(this.ptr, this.md.Handle, IntPtr.Zero));
		}

		/// <summary>
		/// Calls EVP_DigestUpdate()
		/// </summary>
		/// <param name="msg"></param>
		public void Update(byte[] msg)
		{
			Native.ExpectSuccess(Native.EVP_DigestUpdate(this.ptr, msg, (uint)msg.Length));
		}

		/// <summary>
		/// Calls EVP_DigestFinal_ex()
		/// </summary>
		/// <returns></returns>
		public byte[] DigestFinal()
		{
			byte[] digest = new byte[this.md.Size];
			uint len = (uint)digest.Length;
			Native.ExpectSuccess(Native.EVP_DigestFinal_ex(this.ptr, digest, ref len));
			return digest;
		}

		/// <summary>
		/// Calls EVP_SignFinal()
		/// </summary>
		/// <param name="pkey"></param>
		/// <returns></returns>
		public byte[] SignFinal(CryptoKey pkey)
		{
			byte[] sig = new byte[pkey.Size];
			uint len = (uint)sig.Length;
			Native.ExpectSuccess(Native.EVP_SignFinal(this.ptr, sig, ref len, pkey.Handle));
			return sig;
		}

		/// <summary>
		/// Calls EVP_VerifyFinal()
		/// </summary>
		/// <param name="sig"></param>
		/// <param name="pkey"></param>
		/// <returns></returns>
		public bool VerifyFinal(byte[] sig, CryptoKey pkey)
		{
			int ret = Native.ExpectSuccess(Native.EVP_VerifyFinal(this.ptr, sig, (uint)sig.Length, pkey.Handle));
			return ret == 1;
		}

		/// <summary>
		/// Calls EVP_DigestInit_ex(), EVP_DigestUpdate(), and EVP_SignFinal()
		/// </summary>
		/// <param name="msg"></param>
		/// <param name="pkey"></param>
		/// <returns></returns>
		public byte[] Sign(byte[] msg, CryptoKey pkey) 
		{
			byte[] sig = new byte[pkey.Size];
			uint len = (uint)sig.Length;
			Native.ExpectSuccess(Native.EVP_DigestInit_ex(this.ptr, this.md.Handle, IntPtr.Zero));
			Native.ExpectSuccess(Native.EVP_DigestUpdate(this.ptr, msg, (uint)msg.Length));
			Native.ExpectSuccess(Native.EVP_SignFinal(this.ptr, sig, ref len, pkey.Handle));
			byte[] ret = new byte[len];
			Buffer.BlockCopy(sig, 0, ret, 0, (int)len);
			return ret;
		}

		/// <summary>
		/// Calls EVP_SignFinal()
		/// </summary>
		/// <param name="md"></param>
		/// <param name="bio"></param>
		/// <param name="pkey"></param>
		/// <returns></returns>
		public static byte[] Sign(MessageDigest md, BIO bio, CryptoKey pkey)
		{
			BIO bmd = BIO.MessageDigest(md);
			bmd.Push(bio);

			while (true)
			{
				ArraySegment<byte> bytes = bmd.ReadBytes(1024 * 4);
				if (bytes.Count == 0)
					break;
			}

			MessageDigestContext ctx = new MessageDigestContext(bmd);

			byte[] sig = new byte[pkey.Size];
			uint len = (uint)sig.Length;
			Native.ExpectSuccess(Native.EVP_SignFinal(ctx.Handle, sig, ref len, pkey.Handle));
			byte[] ret = new byte[len];
			Buffer.BlockCopy(sig, 0, ret, 0, (int)len);
			return ret;
		}

		/// <summary>
		/// Calls EVP_DigestInit_ex(), EVP_DigestUpdate(), and EVP_VerifyFinal()
		/// </summary>
		/// <param name="msg"></param>
		/// <param name="sig"></param>
		/// <param name="pkey"></param>
		/// <returns></returns>
		public bool Verify(byte[] msg, byte[] sig, CryptoKey pkey) 
		{
			Native.ExpectSuccess(Native.EVP_DigestInit_ex(this.ptr, this.md.Handle, IntPtr.Zero));
			Native.ExpectSuccess(Native.EVP_DigestUpdate(this.ptr, msg, (uint)msg.Length));
			int ret = Native.ExpectSuccess(Native.EVP_VerifyFinal(this.ptr, sig, (uint)sig.Length, pkey.Handle));
			return ret == 1;
		}

		/// <summary>
		/// Calls EVP_VerifyFinal()
		/// </summary>
		/// <param name="md"></param>
		/// <param name="bio"></param>
		/// <param name="sig"></param>
		/// <param name="pkey"></param>
		/// <returns></returns>
		public static bool Verify(MessageDigest md, BIO bio, byte[] sig, CryptoKey pkey)
		{
			BIO bmd = BIO.MessageDigest(md);
			bmd.Push(bio);

			while (true)
			{
				ArraySegment<byte> bytes = bmd.ReadBytes(1024 * 4);
				if (bytes.Count == 0)
					break;
			}

			MessageDigestContext ctx = new MessageDigestContext(bmd);

			int ret = Native.ExpectSuccess(Native.EVP_VerifyFinal(ctx.Handle, sig, (uint)sig.Length, pkey.Handle));
			return ret == 1;
		}

		#endregion

		#region IDisposable Members

		/// <summary>
		/// Calls EVP_MD_CTX_cleanup() and EVP_MD_CTX_destroy()
		/// </summary>
		protected override void OnDispose() {
			Native.EVP_MD_CTX_cleanup(this.ptr);
			Native.EVP_MD_CTX_destroy(this.ptr);
		}

		#endregion
	}
}