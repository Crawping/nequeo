/* Company :       Nequeo Pty Ltd, http://www.nequeo.com.au/
*  Copyright :     Copyright � Nequeo Pty Ltd 2016 http://www.nequeo.com.au/
*
*  File :          RedshiftCloudAccount.cpp
*  Purpose :       Redshift Cloud account provider class.
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

#include "stdafx.h"

#include "RedshiftCloudAccount.h"

using namespace Nequeo::AWS::Storage;

static const char* REDSHIFT_CLIENT_TAG = "NequeoRedshiftClient";

///	<summary>
///	Cloud account provider.
///	</summary>
/// <param name="account">The AWS services account.</param>
RedshiftCloudAccount::RedshiftCloudAccount(const AwsAccount& account) : _disposed(false), _account(account)
{
	// Create the client.
	_client = Aws::MakeUnique<Aws::Redshift::RedshiftClient>(REDSHIFT_CLIENT_TAG, _account._credentials, _account._clientConfiguration);
}

///	<summary>
///	Cloud account provider.
///	</summary>
RedshiftCloudAccount::~RedshiftCloudAccount()
{
	if (!_disposed)
	{
		_disposed = true;
	}
}

/// <summary>
/// Gets the Redshift client.
/// </summary>
/// <return>The Redshift client.</return>
const Aws::Redshift::RedshiftClient& RedshiftCloudAccount::GetClient() const
{
	return *(_client.get());
}

///	<summary>
///	Get the service URI.
///	</summary>
///	<return>The service URI.</return>
std::string RedshiftCloudAccount::GetServiceUri()
{
	return std::string(Aws::Redshift::RedshiftEndpoint::ForRegion(_account._clientConfiguration.region).c_str());
}