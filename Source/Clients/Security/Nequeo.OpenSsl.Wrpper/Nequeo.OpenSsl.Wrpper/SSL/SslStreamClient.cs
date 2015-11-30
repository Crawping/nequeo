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
using System.IO;
using Nequeo.OpenSsl.Wrpper.Core;
using Nequeo.OpenSsl.Wrpper.Crypto;
using Nequeo.OpenSsl.Wrpper.Extensions;
using Nequeo.OpenSsl.Wrpper.X509;
using Nequeo.OpenSsl.Wrpper;

namespace Nequeo.OpenSsl.Wrpper.SSL
{
	internal class SslStreamClient : SslStreamBase
	{
		string targetHost;
		X509List clientCertificates;
		X509Chain caCertificates;
		// Internal callback for client certificate selection
		protected ClientCertCallbackHandler internalCertificateSelectionCallback;

		public SslStreamClient(Stream stream,
			bool ownStream,
			string targetHost,
			X509List clientCertificates,
			X509Chain caCertificates,
			SslProtocols enabledSslProtocols,
			SslStrength sslStrength,
			bool checkCertificateRevocationStatus,
			RemoteCertificateValidationHandler remoteCallback,
			LocalCertificateSelectionHandler localCallback)
			: base(stream, ownStream)
		{
			this.targetHost = targetHost;
			this.clientCertificates = clientCertificates;
			this.caCertificates = caCertificates;
			this.checkCertificateRevocationStatus = checkCertificateRevocationStatus;
			remoteCertificateSelectionCallback = remoteCallback;
			localCertificateSelectionCallback = localCallback;
			internalCertificateSelectionCallback = InternalClientCertificateSelectionCallback;
			InitializeClientContext(clientCertificates, enabledSslProtocols, sslStrength, checkCertificateRevocationStatus);
		}

		protected void InitializeClientContext(X509List certificates, SslProtocols enabledSslProtocols, SslStrength sslStrength, bool checkCertificateRevocation)
		{
            // Initialize the context with specified TLS version
            sslContext = new SslContext(SslMethod.TLSv12_client_method, ConnectionEnd.Client, true, new[] { Protocols.Http2, Protocols.Http1});
            
			// Remove support for protocols not specified in the enabledSslProtocols
			if ((enabledSslProtocols & SslProtocols.Ssl2) != SslProtocols.Ssl2)
			{
				sslContext.Options |= SslOptions.SSL_OP_NO_SSLv2;
			}
			if ((enabledSslProtocols & SslProtocols.Ssl3) != SslProtocols.Ssl3 &&
				((enabledSslProtocols & SslProtocols.Default) != SslProtocols.Default))
			{
				// no SSLv3 support
				sslContext.Options |= SslOptions.SSL_OP_NO_SSLv3;
			}
			if ((enabledSslProtocols & SslProtocols.Tls) != SslProtocols.Tls &&
				(enabledSslProtocols & SslProtocols.Default) != SslProtocols.Default)
			{
				sslContext.Options |= SslOptions.SSL_OP_NO_TLSv1;
			}

			// Set the Local certificate selection callback
			sslContext.SetClientCertCallback(internalCertificateSelectionCallback);
			// Set the enabled cipher list
			sslContext.SetCipherList(GetCipherString(false, enabledSslProtocols, sslStrength));
			// Set the callbacks for remote cert verification and local cert selection
			if (remoteCertificateSelectionCallback != null)
			{
				sslContext.SetVerify(VerifyMode.SSL_VERIFY_PEER | VerifyMode.SSL_VERIFY_FAIL_IF_NO_PEER_CERT, remoteCertificateSelectionCallback);
			}
			// Set the CA list into the store
			if (caCertificates != null)
			{
				var store = new X509Store(caCertificates);
				sslContext.SetCertificateStore(store);
			}
			// Set up the read/write bio's
			read_bio = BIO.MemoryBuffer(false);
			write_bio = BIO.MemoryBuffer(false);
			ssl = new Ssl(sslContext);

            sniCb = sniExt.ClientSniCb;
            sniExt.AttachSniExtensionClient(ssl.Handle, sslContext.Handle, sniCb);

			ssl.SetBIO(read_bio, write_bio);
			read_bio.SetClose(BIO.CloseOption.Close);
			write_bio.SetClose(BIO.CloseOption.Close);
			// Set the Ssl object into Client mode
			ssl.SetConnectState();
		}

		internal protected override bool ProcessHandshake()
		{
			bool ret = false;

			// Check to see if we have an exception from the previous call
			//!!if (handshakeException != null)
			//!!{
			//!!    throw handshakeException;
			//!!}

			int nRet = 0;
			if (handShakeState == HandshakeState.InProcess)
			{
				nRet = ssl.Connect();
			}
			else if (handShakeState == HandshakeState.RenegotiateInProcess ||
					 handShakeState == HandshakeState.Renegotiate)
			{
				handShakeState = HandshakeState.RenegotiateInProcess;
				nRet = ssl.DoHandshake();
			}
			if (nRet <= 0)
			{
				SslError lastError = ssl.GetError(nRet);
				if (lastError == SslError.SSL_ERROR_WANT_READ)
				{
					// Do nothing -- the base stream will write the data from the bio
					// when this call returns
				}
				else if (lastError == SslError.SSL_ERROR_WANT_WRITE)
				{
					// unexpected error
					//!!TODO - debug log
				}
				else
				{
					// We should have alert data in the bio that needs to be written
					// We'll save the exception, allow the write to start, and then throw the exception
					// when we come back into the AsyncHandshakeCall
					if (write_bio.BytesPending > 0)
					{
						handshakeException = new OpenSslException();
					}
					else
					{
						throw new OpenSslException();
					}
				}
			}
			else
			{
				// Successful handshake
				ret = true;
			}

			return ret;
		}

		public int InternalClientCertificateSelectionCallback(Ssl ssl, out X509Certificate x509_cert, out CryptoKey key)
		{
			int nRet = 0;
			x509_cert = null;
			key = null;

			Core.Stack<X509Name> name_stack = ssl.CAList;
			string[] strIssuers = new string[name_stack.Count];
			int count = 0;

			foreach (X509Name name in name_stack)
			{
				strIssuers[count++] = name.OneLine;
			}

			if (localCertificateSelectionCallback != null)
			{
				X509Certificate cert = localCertificateSelectionCallback(this, targetHost, clientCertificates, ssl.GetPeerCertificate(), strIssuers);
				if (cert != null && cert.HasPrivateKey)
				{
					x509_cert = cert;
					key = cert.PrivateKey;
					// Addref the cert and private key
					x509_cert.AddRef();
					key.AddRef();
					// return success
					nRet = 1;
				}
			}

			return nRet;
		}
	}
}
