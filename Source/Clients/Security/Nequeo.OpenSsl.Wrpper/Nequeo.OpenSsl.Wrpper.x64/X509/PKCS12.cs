﻿// Copyright © Microsoft Open Technologies, Inc.
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

// Copyright (c) 2009-2011 Frank Laub
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
using System.Text;
using System.Runtime.InteropServices;
using Nequeo.OpenSsl.Wrpper.Core;
using Nequeo.OpenSsl.Wrpper.Crypto;

namespace Nequeo.OpenSsl.Wrpper.X509
{
	/// <summary>
	/// Wraps PCKS12_*
	/// </summary>
	public class PKCS12 : Base
	{
		#region PKCS12 structure

		[StructLayout(LayoutKind.Sequential)]
		struct _PKCS12
		{
			public IntPtr version;     //ASN1_INTEGER *version;
			public IntPtr mac;         //PKCS12_MAC_DATA *mac;
			public IntPtr authsafes;   //PKCS7 *authsafes;
		}
		#endregion

		/// <summary>
		/// Password-Based Encryption (from PKCS #5)
		/// </summary>
		public enum PBE
		{
			/// <summary>
			/// 
			/// </summary>
			Default = 0,
			/// <summary>
			/// NID_pbeWithMD2AndDES_CBC
			/// </summary>
			MD2_DES = 9,
			/// <summary>
			/// NID_pbeWithMD5AndDES_CBC
			/// </summary>
			MD5_DES = 10,
			/// <summary>
			/// NID_pbeWithMD2AndRC2_CBC
			/// </summary>
			MD2_RC2_64 = 168,
			/// <summary>
			/// NID_pbeWithMD5AndRC2_CBC
			/// </summary>
			MD5_RC2_64 = 169,
			/// <summary>
			/// NID_pbeWithSHA1AndDES_CBC
			/// </summary>
			SHA1_DES = 170,
			/// <summary>
			/// NID_pbeWithSHA1AndRC2_CBC
			/// </summary>
			SHA1_RC2_64 = 68,
			/// <summary>
			/// NID_pbe_WithSHA1And128BitRC4
			/// </summary>
			SHA1_RC4_128 = 144,
			/// <summary>
			/// NID_pbe_WithSHA1And40BitRC4
			/// </summary>
			SHA1_RC4_40 = 145,
			/// <summary>
			/// NID_pbe_WithSHA1And3_Key_TripleDES_CBC
			/// </summary>
			SHA1_3DES = 146,
			/// <summary>
			/// NID_pbe_WithSHA1And2_Key_TripleDES_CBC
			/// </summary>
			SHA1_2DES = 147,
			/// <summary>
			/// NID_pbe_WithSHA1And128BitRC2_CBC
			/// </summary>
			SHA1_RC2_128 = 148,
			/// <summary>
			/// NID_pbe_WithSHA1And40BitRC2_CBC
			/// </summary>
			SHA1_RC2_40 = 149
		}
		
		/// <summary>
		/// This is a non standard extension that is only currently interpreted by MSIE
		/// </summary>
		public enum KeyType
		{
			/// <summary>
			/// omit the flag from the private key
			/// </summary>
			KEY_DEFAULT = 0,
		
			/// <summary>
			/// the key can be used for signing only
			/// </summary>
			KEY_SIG = 0x80,
		
			/// <summary>
			/// the key can be used for signing and encryption
			/// </summary>
			KEY_EX = 0x10,
		}

		#region Initialization

		/// <summary>
		/// Calls PKCS12_create()
		/// </summary>
		/// <param name="password"></param>
		/// <param name="key"></param>
		/// <param name="cert"></param>
		/// <param name="ca"></param>
		public PKCS12(string password, CryptoKey key, X509Certificate cert, Stack<X509Certificate> ca) :
			base(Create(password, null, key, cert, ca, PBE.Default, PBE.Default, 0, KeyType.KEY_DEFAULT), true) {
			Init(password);
		}

		/// <summary>
		/// Calls PKCS12_create() with more options
		/// </summary>
		/// <param name="password"></param>
		/// <param name="name">friendly name</param>
		/// <param name="key"></param>
		/// <param name="cert"></param>
		/// <param name="ca"></param>
		/// <param name="keyPbe">How to encrypt the key</param>
		/// <param name="certPbe">How to encrypt the certificate</param>
		/// <param name="iterations"># of iterations during encryption</param>
		/// <param name="keyType"></param>
		public PKCS12(string password, string name, CryptoKey key, X509Certificate cert, Stack<X509Certificate> ca, PBE keyPbe, PBE certPbe, int iterations, KeyType keyType) :
			base(Create(password, name, key, cert, ca, keyPbe, certPbe, iterations, keyType), true) {
			Init(password);
		}

		private static IntPtr Create(
			string password, 
			string name, 
			CryptoKey key, 
			X509Certificate cert,
			Stack<X509Certificate> ca,
			PBE keyPbe,
			PBE certPbe,
			int iterations,
			KeyType keyType) {
			return Native.ExpectNonNull(Native.PKCS12_create(
				password, 
				name, 
				key.Handle, 
				cert.Handle, 
				ca.Handle, 
				(int)keyPbe,
				(int)certPbe,
				iterations, 
				1, 
				(int)keyType));
		}

		/// <summary>
		/// Calls d2i_PKCS12_bio() and then PKCS12_parse()
		/// </summary>
		/// <param name="bio"></param>
		/// <param name="password"></param>
		public PKCS12(BIO bio, string password)
			: base(Native.ExpectNonNull(Native.d2i_PKCS12_bio(bio.Handle, IntPtr.Zero)), true) {
			Init(password);
		}

		private void Init(string password) {
			IntPtr cert;
			IntPtr pkey;
			IntPtr cacerts;

			// Parse the PKCS12 object and get privatekey, cert, cacerts if available
			Native.ExpectSuccess(Native.PKCS12_parse(this.ptr, password, out pkey, out cert, out cacerts));

			if (cert != IntPtr.Zero) {
				this.certificate = new X509Certificate(cert, true);
				if (pkey != IntPtr.Zero) {
					this.privateKey = new CryptoKey(pkey, true);

					// We have a private key, assign it to the cert
					this.certificate.PrivateKey = this.privateKey.CopyRef();
				}
			}

			if (cacerts != IntPtr.Zero) {
				this.caCertificates = new Stack<X509Certificate>(cacerts, true);
			}
			else {
				this.caCertificates = new Stack<X509Certificate>();
			}
		}

		#endregion

		/// <summary>
		/// Calls i2d_PKCS12_bio()
		/// </summary>
		/// <param name="bio"></param>
		public void Write(BIO bio) {
			Native.ExpectSuccess(Native.i2d_PKCS12_bio(bio.Handle, this.Handle));
		}

		#region Properties

		/// <summary>
		/// Returns the Certificate, with the PrivateKey attached if there is one.
		/// </summary>
		public X509Certificate Certificate
		{
			get
			{
				if (certificate != null)
				{
					X509Certificate cert = this.certificate.CopyRef();
					if (privateKey != null)
						cert.PrivateKey = this.privateKey.CopyRef();
					return cert;
				}
				return null;
			}
		}

		/// <summary>
		/// Returns the PrivateKey
		/// </summary>
		public CryptoKey PrivateKey
		{
			get
			{
				if (privateKey != null)
					return this.privateKey.CopyRef();
				return null;
			}
		}

		/// <summary>
		/// Returns a stack of CA Certificates
		/// </summary>
		public Stack<X509Certificate> CACertificates
		{
			get { return caCertificates; }
		}

		#endregion

		#region Overrides

		/// <summary>
		/// Calls PKCS12_free()
		/// </summary>
		protected override void OnDispose()
		{
			if (certificate != null)
			{
				certificate.Dispose();
				certificate = null;
			}
			if (privateKey != null)
			{
				privateKey.Dispose();
				privateKey = null;
			}
			if (caCertificates != null)
			{
				caCertificates.Dispose();
				caCertificates = null;
			}
			Native.PKCS12_free(this.ptr);
		}

		#endregion

		#region Fields
		private CryptoKey privateKey;
		private X509Certificate certificate;
		private Stack<X509Certificate> caCertificates;
		#endregion
	}
}
