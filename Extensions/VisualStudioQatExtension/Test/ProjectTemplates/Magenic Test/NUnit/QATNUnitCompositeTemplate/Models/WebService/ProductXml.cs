﻿using System;

namespace $safeprojectname$.WebService
{
    /// <summary>
    /// Class for product
    /// </summary>
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.datacontract.org/2004/07/AutomationTestSite.$safeprojectname$")]
    [System.Xml.Serialization.XmlRootAttribute(ElementName = "Product", Namespace = "http://schemas.datacontract.org/2004/07/AutomationTestSite.$safeprojectname$", IsNullable = false)]
    public class $safeitemname$
    {
        /// <summary>
        /// Gets or sets the id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the product name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the product category
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// Gets or sets the product price
        /// </summary>
        public double Price { get; set; }
    }
}
