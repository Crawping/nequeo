/* Company :       Nequeo Pty Ltd, http://www.nequeo.com.au/
*  Copyright :     Copyright � Nequeo Pty Ltd 2016 http://www.nequeo.com.au/
*
*  File :          WebServer.h
*  Purpose :       Http web server class.
*
*/

/*
Permission is hereby granted, free of charge, to any person
obtaining a copy of this software and associated documentation
files (the "Software"), to deal in the Software without
restriction, including without limitation the rights to use,
copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the
Software is furnished to do so, subject to the following
conditions:

The above copyright notice and this permission notice shall be
included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
OTHER DEALINGS IN THE SOFTWARE.
*/

#pragma once

#include "stdafx.h"
#include "Global.h"

#include "WebContext.h"
#include "IPVersionType.h"

namespace Nequeo {
	namespace Net {
		namespace Http 
		{
			typedef std::function<void(const WebContext*)> WebContextHandler;

			/// <summary>
			/// Http web server.
			/// </summary>
			class EXPORT_NEQUEO_NET_BOOST_SERVER_API WebServer
			{
			public:
				/// <summary>
				/// Http web server.
				/// </summary>
				/// <param name="port">The listening port number.</param>
				/// <param name="ipv">The IP version to use.</param>
				/// <param name="isSecure">Is the server secure (must set the public and private key files).</param>
				/// <param name="timeoutRequest">The request time out.</param>
				/// <param name="timeoutContent">The send and receive time out.</param>
				/// <param name="numberOfThreads">The number of threads to use(set to 1 is more than statisfactory).</param>
				WebServer(unsigned short port, IPVersionType ipv = IPVersionType::IPv4, bool isSecure = false, 
					long timeoutRequest = 5, long timeoutContent = 300, size_t numberOfThreads = 1);

				/// <summary>
				/// Http web server.
				/// </summary>
				/// <param name="port">The listening port number.</param>
				/// <param name="endpoint">The endpoint address to listen on.</param>
				/// <param name="isSecure">Is the server secure (must set the public and private key files).</param>
				/// <param name="timeoutRequest">The request time out.</param>
				/// <param name="timeoutContent">The send and receive time out.</param>
				/// <param name="numberOfThreads">The number of threads to use(set to 1 is more than statisfactory).</param>
				WebServer(unsigned short port, const std::string& endpoint, bool isSecure = false, 
					long timeoutRequest = 5, long timeoutContent = 300, size_t numberOfThreads = 1);

				/// <summary>
				/// Http web server.
				/// </summary>
				virtual ~WebServer();

				/// <summary>
				/// On web context request.
				/// </summary>
				/// <param name="webContext">The web context callback function.</param>
				void OnWebContext(const WebContextHandler& webContext);

				///	<summary>
				///	Start the server.
				///	</summary>
				void Start();

				///	<summary>
				///	Stop the server.
				///	</summary>
				void Stop();

				///	<summary>
				///	Start the server.
				///	</summary>
				void StartThread();

				///	<summary>
				///	Stop the server.
				///	</summary>
				void StopThread();

				/// <summary>
				/// On web context request.
				/// </summary>
				/// <param name="publicKeyFile">The public certificate file path.</param>
				/// <param name="privateKeyFile">The private (un-encrypted, encrypted - use password) key file.</param>
				/// <param name="privateKeyPassword">The private key password (decrypt encrypted private key file).</param>
				void SetSecurePublicPrivateKeys(
					const std::string& publicKeyFile,
					const std::string& privateKeyFile, 
					const std::string& privateKeyPassword);

				/// <summary>
				/// Is the server listening.
				/// </summary>
				/// <return>True if the server is listening; else false.</return>
				bool IsListening() const;

				/// <summary>
				/// Is the server secure.
				/// </summary>
				/// <return>True if the server is secure; else false.</return>
				bool IsSecure() const;

				/// <summary>
				/// The IP version type.
				/// </summary>
				/// <return>The IP version type.</return>
				IPVersionType IPVersion() const;

				/// <summary>
				/// Gets or sets the server name.
				/// </summary>
				/// <param name="serverName">The server name.</param>
				/// <return>The servername.</return>
				const std::string& GetServerName() const;
				void SetServerName(const std::string& serverName);

				/// <summary>
				/// Get the port number.
				/// </summary>
				/// <return>The port number.</return>
				unsigned short Port() const;

				/// <summary>
				/// Get the endpoint.
				/// </summary>
				/// <return>The endpoint.</return>
				const std::string& GetEndpoint() const;

			private:
				bool _disposed;
				bool _listening;
				bool _isSecure;
				bool _hasEndpoint;

				bool _internalThread;
				std::thread _thread;
				int _serverIndex;

				unsigned short _port;
				IPVersionType _ipv;
				std::string _serverName;
				std::string _endpoint;
				long _timeoutRequest;
				long _timeoutContent;
				size_t _numberOfThreads;

				std::string _publicKeyFile;
				std::string _privateKeyFile;
				std::string _privateKeyPassword;

				WebContextHandler _onWebContext;
			};
		}
	}
}