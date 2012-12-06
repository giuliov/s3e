/******************************************************************************* 
 *  Copyright 2008 Amazon Technologies, Inc.
 *  Licensed under the Apache License, Version 2.0 (the "License"); 
 *  
 *  You may not use this file except in compliance with the License. 
 *  You may obtain a copy of the License at: http://aws.amazon.com/apache2.0
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the 
 *  specific language governing permissions and limitations under the License.
 * ***************************************************************************** 
 *    __  _    _  ___ 
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 * 
 *  Amazon EC2 CSharp Library
 *  API Version: 2008-12-01
 *  Generated: Fri Dec 26 23:53:41 PST 2008 
 * 
 */

using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Text;


namespace Amazon.EC2.Model
{
    [XmlTypeAttribute(Namespace = "http://ec2.amazonaws.com/doc/2008-12-01/")]
    [XmlRootAttribute(Namespace = "http://ec2.amazonaws.com/doc/2008-12-01/", IsNullable = false)]
    public class BlockDeviceMapping
    {
    
        private String virtualNameField;

        private String deviceNameField;


        /// <summary>
        /// Gets and sets the VirtualName property.
        /// </summary>
        [XmlElementAttribute(ElementName = "VirtualName")]
        public String VirtualName
        {
            get { return this.virtualNameField ; }
            set { this.virtualNameField= value; }
        }



        /// <summary>
        /// Sets the VirtualName property
        /// </summary>
        /// <param name="virtualName">VirtualName property</param>
        /// <returns>this instance</returns>
        public BlockDeviceMapping WithVirtualName(String virtualName)
        {
            this.virtualNameField = virtualName;
            return this;
        }



        /// <summary>
        /// Checks if VirtualName property is set
        /// </summary>
        /// <returns>true if VirtualName property is set</returns>
        public Boolean IsSetVirtualName()
        {
            return  this.virtualNameField != null;

        }


        /// <summary>
        /// Gets and sets the DeviceName property.
        /// </summary>
        [XmlElementAttribute(ElementName = "DeviceName")]
        public String DeviceName
        {
            get { return this.deviceNameField ; }
            set { this.deviceNameField= value; }
        }



        /// <summary>
        /// Sets the DeviceName property
        /// </summary>
        /// <param name="deviceName">DeviceName property</param>
        /// <returns>this instance</returns>
        public BlockDeviceMapping WithDeviceName(String deviceName)
        {
            this.deviceNameField = deviceName;
            return this;
        }



        /// <summary>
        /// Checks if DeviceName property is set
        /// </summary>
        /// <returns>true if DeviceName property is set</returns>
        public Boolean IsSetDeviceName()
        {
            return  this.deviceNameField != null;

        }




        /// <summary>
        /// XML fragment representation of this object
        /// </summary>
        /// <returns>XML fragment for this object.</returns>
        /// <remarks>
        /// Name for outer tag expected to be set by calling method. 
        /// This fragment returns inner properties representation only
        /// </remarks>


        protected internal String ToXMLFragment() {
            StringBuilder xml = new StringBuilder();
            if (IsSetVirtualName()) {
                xml.Append("<VirtualName>");
                xml.Append(EscapeXML(this.VirtualName));
                xml.Append("</VirtualName>");
            }
            if (IsSetDeviceName()) {
                xml.Append("<DeviceName>");
                xml.Append(EscapeXML(this.DeviceName));
                xml.Append("</DeviceName>");
            }
            return xml.ToString();
        }

        /**
         * 
         * Escape XML special characters
         */
        private String EscapeXML(String str) {
            StringBuilder sb = new StringBuilder();
            foreach (Char c in str)
            {
                switch (c) {
                case '&':
                    sb.Append("&amp;");
                    break;
                case '<':
                    sb.Append("&lt;");
                    break;
                case '>':
                    sb.Append("&gt;");
                    break;
                case '\'':
                    sb.Append("&#039;");
                    break;
                case '"':
                    sb.Append("&quot;");
                    break;
                default:
                    sb.Append(c);
                    break;
                }
            }
            return sb.ToString();
        }



    }

}