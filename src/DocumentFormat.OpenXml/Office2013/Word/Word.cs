using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentFormat.OpenXml.Office2013.Word
{
    public partial class Person : OpenXmlCompositeElement
    {
        /// <summary>
        /// Gets or sets the <see cref="Contact"/> value. It is only available for backwards compatibility
        /// until the next major version change. Please discontinue using this property.
        /// </summary>
        [Obsolete("This property will be removed in a future version")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public StringValue? Contact
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }
    }
}
