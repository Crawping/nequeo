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

// Copyright (c) 2009 Ben Henderson
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
using System.Linq;
using System.Runtime.InteropServices;
using Nequeo.OpenSsl.Wrpper.Extensions;
using Nequeo.OpenSsl.Wrpper.Core;
using Nequeo.OpenSsl.Wrpper.Crypto;
using Nequeo.OpenSsl.Wrpper.X509;

namespace Nequeo.OpenSsl.Wrpper.SSL
{
    internal delegate int ClientCertCallbackHandler(Ssl ssl, out X509Certificate cert, out CryptoKey key);

    /// <summary>
    ///     Wraps the SST_CTX structure and methods
    /// </summary>
    internal sealed class SslContext : Base
    {
        #region Members

        //private SSL_CTX raw;
        private ClientCertCallbackThunk _clientCertCallbackThunk;
        private VerifyCertCallbackThunk _verifyCertCallbackThunk;

        #endregion

        private static AlpnCallback alpnCb;
        private static AlpnExtension alpnExt;

        /// <summary>
        ///     Calls SSL_CTX_new()
        /// </summary>
        /// <param name="sslMethod"></param>
        /// <param name="end"></param>
        /// <param name="includeAlpn"></param>
        /// <param name="protoList"></param>
        public SslContext(SslMethod sslMethod, ConnectionEnd end, bool includeAlpn, IEnumerable<string> protoList = null)
            :
                base(Native.ExpectNonNull(Native.SSL_CTX_new(sslMethod.Handle)), true)
        {
            if (!includeAlpn)
                return;

            alpnExt = new AlpnExtension(Handle, protoList);

            if (end == ConnectionEnd.Server)
            {
                alpnCb = alpnExt.AlpnCb;
                var alpnCbPtr = Marshal.GetFunctionPointerForDelegate(alpnCb);
                var arg = new IntPtr();
                Native.SSL_CTX_set_alpn_select_cb(Handle, alpnCbPtr, arg);
            }
        }

        #region Properties

        /// <summary>
        ///     Calls SSL_CTX_set_options
        /// </summary>
        public SslOptions Options
        {
            set { Native.ExpectSuccess(Native.SSL_CTX_set_options(ptr, (int) value)); }
            get { return (SslOptions) Native.SSL_CTX_get_options(ptr); }
        }

        public SslMode Mode
        {
            set { Native.ExpectSuccess(Native.SSL_CTX_set_mode(ptr, (int) value)); }
            get { return (SslMode) Native.SSL_CTX_get_mode(ptr); }
        }

        #endregion

        internal bool AlpnIncluded
        {
            get { return alpnExt != null; }
        }

        internal class ClientCertCallbackThunk
        {
            private ClientCertCallbackHandler OnClientCertCallback;
            private Native.client_cert_cb nativeCallback;

            public ClientCertCallbackThunk(ClientCertCallbackHandler callback)
            {
                OnClientCertCallback = callback;
            }

            public Native.client_cert_cb Callback
            {
                get
                {
                    if (OnClientCertCallback == null)
                    {
                        return null;
                    }
                    if (nativeCallback != null)
                    {
                        return nativeCallback;
                    }

                    nativeCallback = OnClientCertThunk;
                    return nativeCallback;
                }
            }

            internal int OnClientCertThunk(IntPtr ssl_ptr, out IntPtr cert_ptr, out IntPtr key_ptr)
            {
                X509Certificate cert = null;
                CryptoKey key = null;
                Ssl ssl = new Ssl(ssl_ptr, false);
                cert_ptr = IntPtr.Zero;
                key_ptr = IntPtr.Zero;

                int nRet = OnClientCertCallback(ssl, out cert, out key);
                if (nRet != 0)
                {
                    if (cert != null)
                    {
                        cert_ptr = cert.Handle;
                    }
                    if (key != null)
                    {
                        key_ptr = key.Handle;
                    }
                }
                return nRet;
            }
        }

        internal class VerifyCertCallbackThunk
        {
            private RemoteCertificateValidationHandler OnVerifyCert;
            private Native.VerifyCertCallback nativeCallback;

            public VerifyCertCallbackThunk(RemoteCertificateValidationHandler callback)
            {
                OnVerifyCert = callback;
            }

            public Native.VerifyCertCallback Callback
            {
                get
                {
                    if (OnVerifyCert == null)
                    {
                        return null;
                    }
                    if (nativeCallback != null)
                    {
                        return nativeCallback;
                    }
                    nativeCallback = OnVerifyCertThunk;
                    return nativeCallback;
                }
            }

            internal int OnVerifyCertThunk(int ok, IntPtr store_ctx)
            {
                var ctx = new X509StoreContext(store_ctx, false);
                X509Certificate cert = ctx.CurrentCert;
                int depth = ctx.ErrorDepth;
                var result = (VerifyResult) ctx.Error;
                // build the X509Chain from the store
                var store = ctx.Store;
                var objStack = store.Objects;
                var chain = new X509Chain();

                foreach (var objCert in objStack.Select(obj => obj.Certificate).Where(objCert => objCert != null))
                {
                    chain.Add(objCert);
                }
                // Call the managed delegate
                return OnVerifyCert(this, cert, chain, depth, result) ? 1 : 0;
            }
        }

        #region Methods

        /// <summary>
        ///     Calls SSL_CTX_set_client_CA_list/SSL_CTX_get_client_CA_list
        ///     The Stack and the X509Name objects contined within them
        ///     are freed when the context is disposed.  Make sure that
        ///     the Stack and X509Name objects have set IsOwner to false
        ///     before assigning them to the context.
        /// </summary>
        public Core.Stack<X509Name> CAList
        {
            get
            {
                var ptr = Native.SSL_CTX_get_client_CA_list(this.ptr);
                var name_stack = new Core.Stack<X509Name>(ptr, false);
                return name_stack;
            }
            set
            {
                // Remove the native pointer ownership from the Stack object
                value.IsOwner = false;
                Native.SSL_CTX_set_client_CA_list(ptr, value.Handle);
            }
        }

        /// <summary>
        ///     Sets the certificate store for the context - calls SSL_CTX_set_cert_store
        ///     The X509Store object and contents will be freed when the context is disposed.
        ///     Ensure that the store object and it's contents have IsOwner set to false
        ///     before assigning them into the context.
        /// </summary>
        /// <param name="store"></param>
        public void SetCertificateStore(X509Store store)
        {
            // Remove the native pointer ownership from the object
            // Reference counts don't work for the X509_STORE, so
            // we just remove ownership from the X509Store object
            store.IsOwner = false;
            Native.SSL_CTX_set_cert_store(ptr, store.Handle);
        }

        /// <summary>
        ///     Sets the certificate verification mode and callback - calls SSL_CTX_set_verify
        /// </summary>
        /// <param name="mode"></param>
        /// <param name="callback"></param>
        public void SetVerify(VerifyMode mode, RemoteCertificateValidationHandler callback)
        {
            _verifyCertCallbackThunk = new VerifyCertCallbackThunk(callback);
            Native.SSL_CTX_set_verify(ptr, (int) mode, _verifyCertCallbackThunk.Callback);
        }

        /// <summary>
        ///     Sets the certificate verification depth - calls SSL_CTX_set_verify_depth
        /// </summary>
        /// <param name="depth"></param>
        public void SetVerifyDepth(int depth)
        {
            Native.SSL_CTX_set_verify_depth(ptr, depth);
        }

        public Core.Stack<X509Name> LoadClientCAFile(string filename)
        {
            var stack = Native.SSL_load_client_CA_file(filename);
            var name_stack = new Core.Stack<X509Name>(stack, true);
            return name_stack;
        }

        public int LoadVerifyLocations(string caFile, string caPath)
        {
            return Native.ExpectSuccess(Native.SSL_CTX_load_verify_locations(ptr, caFile, caPath));
        }

        public int SetDefaultVerifyPaths()
        {
            return Native.ExpectSuccess(Native.SSL_CTX_set_default_verify_paths(ptr));
        }

        public int SetCipherList(string cipherList)
        {
            return Native.ExpectSuccess(Native.SSL_CTX_set_cipher_list(ptr, cipherList));
        }

        public int UseCertificate(X509Certificate cert)
        {
            return Native.ExpectSuccess(Native.SSL_CTX_use_certificate(ptr, cert.Handle));
        }

        public int UseCertificateChainFile(string filename)
        {
            return Native.ExpectSuccess(Native.SSL_CTX_use_certificate_chain_file(ptr, filename));
        }

        public int UsePrivateKey(CryptoKey key)
        {
            return Native.ExpectSuccess(Native.SSL_CTX_use_PrivateKey(ptr, key.Handle));
        }

        public int UsePrivateKeyFile(string filename, SslFileType type)
        {
            return Native.ExpectSuccess(Native.SSL_CTX_use_PrivateKey_file(ptr, filename, (int) type));
        }

        public int CheckPrivateKey()
        {
            return Native.ExpectSuccess(Native.SSL_CTX_check_private_key(ptr));
        }

        public int SetSessionIdContext(byte[] sid_ctx)
        {
            return Native.ExpectSuccess(Native.SSL_CTX_set_session_id_context(ptr, sid_ctx, (uint) sid_ctx.Length));
        }

        public void SetClientCertCallback(ClientCertCallbackHandler callback)
        {
            _clientCertCallbackThunk = new ClientCertCallbackThunk(callback);
            Native.SSL_CTX_set_client_cert_cb(ptr, _clientCertCallbackThunk.Callback);
        }

        public List<string> GetCipherList()
        {
            var ret = new List<string>();
            var raw = (SSL_CTX) Marshal.PtrToStructure(ptr, typeof (SSL_CTX));
            var stack = new Core.Stack<SslCipher>(raw.cipher_list, false);
            foreach (var cipher in stack)
            {
                var cipher_ptr = Native.SSL_CIPHER_description(cipher.Handle, null, 0);
                if (cipher_ptr == IntPtr.Zero)
                    continue;

                string strCipher = Marshal.PtrToStringAnsi(cipher_ptr);
                ret.Add(strCipher);
                Native.OPENSSL_free(cipher_ptr);
            }
            return ret;
        }

        #endregion

        #region IDisposable Members

        /// <summary>
        ///     base override - calls SSL_CTX_free()
        /// </summary>
        protected override void OnDispose()
        {
            Native.SSL_CTX_free(ptr);
        }

        #endregion
    }
}