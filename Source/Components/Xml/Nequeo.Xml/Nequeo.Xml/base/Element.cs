﻿/*  Company :       Nequeo Pty Ltd, http://www.nequeo.com.au/
 *  Copyright :     Copyright © Nequeo Pty Ltd 2010 http://www.nequeo.com.au/
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
using System.Collections;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Xsl;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

using Nequeo.Xml.Xsl;
using Nequeo.Serialisation;
using Nequeo.Serialisation.Extension;

namespace Nequeo.Xml
{
    /// <summary>
    /// Xml element client.
    /// </summary>
    public sealed class Element
    {
        /// <summary>
        /// Create an element.
        /// </summary>
        /// <param name="elementName">The parent element name.</param>
        /// <param name="collection">The collection of child elements.</param>
        /// <returns>The created xml element.</returns>
        public static XElement CreateElement(XName elementName, Nequeo.Model.NameValue[] collection)
        {
            int i = 0;

            // The collection of name values.
            XElement[] elements = new XElement[collection.Length];

            // Create the element collection.
            // Iterate through the collection.
            foreach (Nequeo.Model.NameValue item in collection)
            {
                // Create the element.
                XElement xElement = new XElement(item.Name, item.Value);
                elements[i] = xElement;

                // Imcrement the array.
                i++;
            }

            // The element.
            XElement element = new XElement(elementName, elements);

            // Return the element.
            return element;
        }

        /// <summary>
        /// Create an element.
        /// </summary>
        /// <param name="elementName">The parent element name.</param>
        /// <param name="collection">The collection of child elements.</param>
        /// <returns>The created xml element.</returns>
        public static XElement CreateElement(XName elementName, NameValueCollection collection)
        {
            int i = 0;

            // The collection of name values.
            XElement[] elements = new XElement[collection.Count];

            // Create the element collection.
            // Iterate through the collection.
            foreach (string item in collection.AllKeys)
            {
                // Create the element.
                XElement xElement = new XElement(item, collection[item]);
                elements[i] = xElement;

                // Imcrement the array.
                i++;
            }

            // The element.
            XElement element = new XElement(elementName, elements);

            // Return the element.
            return element;
        }

        /// <summary>
        /// Create an element.
        /// </summary>
        /// <param name="elementName">The parent element name.</param>
        /// <param name="nextName">The child element name.</param>
        /// <returns>The created xml element.</returns>
        public static XElement CreateElement(XName elementName, XElement nextName)
        {
            // The element.
            XElement element = new XElement(elementName, nextName);

            // Return the element.
            return element;
        }

        /// <summary>
        /// Create an xml document from the data.
        /// </summary>
        /// <param name="data">The array of bytes that contains the xml data.</param>
        /// <returns>The xml document.</returns>
        public static XmlDocument Document(byte[] data)
        {
            // Load the xml data into the document.
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(new System.IO.MemoryStream(data));
            return xmlDoc;
        }

        /// <summary>
        /// Extract the specified node.
        /// </summary>
        /// <param name="data">The array of bytes that contains the xml data.</param>
        /// <param name="selectNode">The name of the selected node with a namespace; e.g. "//d:Text"</param>
        /// <returns>Represents an ordered collection of nodes.</returns>
        public static XmlNodeList ExtractNode(byte[] data, string selectNode)
        {
            // Load the xml data into the document.
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(new System.IO.MemoryStream(data));

            // Get the node.
            XmlNodeList textElements = xmlDoc.SelectNodes(selectNode);
            return textElements;
        }

        /// <summary>
        /// Extract the specified node.
        /// </summary>
        /// <param name="data">The array of bytes that contains the xml data.</param>
        /// <param name="namespaces">The array of namespaces. prefix and uri.</param>
        /// <param name="selectNode">The name of the selected node with a namespace; e.g. "//d:Text"</param>
        /// <returns>Represents an ordered collection of nodes.</returns>
        public static XmlNodeList ExtractNode(byte[] data, Nequeo.Model.NameValue[] namespaces, string selectNode)
        {
            // Load the xml data into the document.
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(new System.IO.MemoryStream(data));

            //Create namespace manager
            XmlNamespaceManager nsmgr = new XmlNamespaceManager(xmlDoc.NameTable);
            foreach (Nequeo.Model.NameValue item in namespaces)
            {
                // Add the namespace.
                nsmgr.AddNamespace(item.Name, item.Value);
            }

            // Get the node.
            XmlNodeList textElements = xmlDoc.SelectNodes(selectNode, nsmgr);
            return textElements;
        }

        /// <summary>
        /// Extract the specified node.
        /// </summary>
        /// <param name="xmlDoc">The xml document.</param>
        /// <param name="selectNode">The name of the selected node with a namespace; e.g. "//d:Text"</param>
        /// <returns>Represents an ordered collection of nodes.</returns>
        public static XmlNodeList ExtractNode(XmlDocument xmlDoc, string selectNode)
        {
            // Get the node.
            XmlNodeList textElements = xmlDoc.SelectNodes(selectNode);
            return textElements;
        }

        /// <summary>
        /// Extract the specified node.
        /// </summary>
        /// <param name="xmlDoc">The xml document.</param>
        /// <param name="namespaces">The array of namespaces. prefix and uri.</param>
        /// <param name="selectNode">The name of the selected node with a namespace; e.g. "//d:Text"</param>
        /// <returns>Represents an ordered collection of nodes.</returns>
        public static XmlNodeList ExtractNode(XmlDocument xmlDoc, Nequeo.Model.NameValue[] namespaces, string selectNode)
        {
            //Create namespace manager
            XmlNamespaceManager nsmgr = new XmlNamespaceManager(xmlDoc.NameTable);
            foreach (Nequeo.Model.NameValue item in namespaces)
            {
                // Add the namespace.
                nsmgr.AddNamespace(item.Name, item.Value);
            }

            // Get the node.
            XmlNodeList textElements = xmlDoc.SelectNodes(selectNode, nsmgr);
            return textElements;
        }
    }
}
