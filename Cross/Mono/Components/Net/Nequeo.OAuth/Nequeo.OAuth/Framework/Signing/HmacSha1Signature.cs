﻿/*  Company :       Nequeo Pty Ltd, http://www.nequeo.com.au/
 *  Copyright :     Copyright © Nequeo Pty Ltd 2012 http://www.nequeo.com.au/
 * 
 *  File :          
 *  Purpose :       
 * 
 */

#region Nequeo Pty Ltd License
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
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.IO;

using Nequeo.Cryptography.Signing;
using Nequeo.Net.OAuth.Framework.Utility;

namespace Nequeo.Net.OAuth.Framework.Signing
{
    /// <summary>
    /// HMAC-SHA1 signing implementation.
    /// </summary>
    public class HmacSha1Signature : IContextSignature
    {
        /// <summary>
        /// Gets the method name.
        /// </summary>
        public string MethodName
		{
			get { return SignatureMethod.HmacSha1; }
		}

        /// <summary>
        /// Sign the current OAuth context.
        /// </summary>
        /// <param name="authContext">The OAuth context.</param>
        /// <param name="signingContext">The signing context.</param>
		public void SignContext(IOAuthContext authContext, SigningContext signingContext)
		{
			authContext.Signature = GenerateSignature(authContext, signingContext);
		}

        /// <summary>
        /// Validate the OAuth signature.
        /// </summary>
        /// <param name="authContext">The OAuth context.</param>
        /// <param name="signingContext">The signing context.</param>
        /// <returns>True if valid; else false.</returns>
		public bool ValidateSignature(IOAuthContext authContext, SigningContext signingContext)
		{
			return authContext.Signature.EqualsInConstantTime(GenerateSignature(authContext, signingContext));
		}

        /// <summary>
        /// Generate Signature
        /// </summary>
        /// <param name="authContext">The auth context.</param>
        /// <param name="signingContext">The signing context.</param>
        /// <returns>The generated signature.</returns>
		static string GenerateSignature(IToken authContext, SigningContext signingContext)
		{
			string consumerSecret = (signingContext.ConsumerSecret != null)
			                        	? UriUtility.UrlEncode(signingContext.ConsumerSecret)
			                        	: "";
			string tokenSecret = (authContext.TokenSecret != null)
			                     	? UriUtility.UrlEncode(authContext.TokenSecret)
			                     	: null;
			string hashSource = string.Format("{0}&{1}", consumerSecret, tokenSecret);

			var hashAlgorithm = new HMACSHA1 {Key = Encoding.ASCII.GetBytes(hashSource)};

			return ComputeHash(hashAlgorithm, signingContext.SignatureBase);
		}

        /// <summary>
        /// Compute Hash
        /// </summary>
        /// <param name="hashAlgorithm">The hash algorthim.</param>
        /// <param name="data">The data to hash.</param>
        /// <returns>The generated hash value.</returns>
		static string ComputeHash(HashAlgorithm hashAlgorithm, string data)
		{
			if (hashAlgorithm == null)
			{
				throw new ArgumentNullException("hashAlgorithm");
			}

			if (string.IsNullOrEmpty(data))
			{
				throw new ArgumentNullException("data");
			}

			byte[] dataBuffer = Encoding.ASCII.GetBytes(data);
			byte[] hashBytes = hashAlgorithm.ComputeHash(dataBuffer);

			return Convert.ToBase64String(hashBytes);
		}
    }
}
