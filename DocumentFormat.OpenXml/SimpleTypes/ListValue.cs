// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace DocumentFormat.OpenXml
{
    /// <summary>
    /// Represents the list value attributes (xsd:list).
    /// </summary>
    [DebuggerDisplay("{InnerText}")]
    public class ListValue<T> : OpenXmlSimpleType, IEnumerable<T>
        where T : OpenXmlSimpleType, new()
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const string _listSeparator = " ";

        private ObservableCollection<T> _list;

        /// <summary>
        /// Initializes a new instance of the ListValue class.
        /// </summary>
        public ListValue()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ListValue class using the supplied list of values.
        /// </summary>
        /// <param name="list">The list of the values.</param>
        public ListValue(IEnumerable<T> list)
            : base()
        {
            if (list == null)
            {
                throw new ArgumentNullException(nameof(list));
            }

            this._list = new ObservableCollection<T>();
            this._list.CollectionChanged += this.CollectionChanged;

            foreach (var item in list)
            {
                this._list.Add(item.Clone() as T);
            }
        }

        /// <summary>
        /// Initializes a new instance of the ListValue class by deep copying the supplied ListValue class.
        /// </summary>
        /// <param name="source">The source ListValue class.</param>
        public ListValue(ListValue<T> source)
            : this(source.Items)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }
        }

        /// <inheritdoc/>
        public override bool HasValue
        {
            get
            {
                if (this._list == null)
                {
                    if (!String.IsNullOrEmpty(this.TextValue))
                    {
                        TryParse();
                    }
                }

                if (this._list == null)
                {
                    return false;
                }
                else
                {
                    return this._list.Count > 0;
                }
            }
        }

        /// <summary>
        /// Gets the values.
        /// </summary>
        public ICollection<T> Items
        {
            get
            {
                if (this._list == null)
                {
                    if (!String.IsNullOrEmpty(this.TextValue))
                    {
                        Parse();
                    }
                    else
                    {
                        this._list = new ObservableCollection<T>();
                        this._list.CollectionChanged += this.CollectionChanged;
                    }
                }

                Debug.Assert(this._list != null);
                return this._list;
            }
        }

        /// <summary>
        /// Convert the text to meaningful value.
        /// </summary>
        internal override void Parse()
        {
            this._list = new ObservableCollection<T>();
            this._list.CollectionChanged += this.CollectionChanged;

            if (!String.IsNullOrEmpty(this.TextValue))
            {
                // split the string by white-space characters as the delimiters.
                string[] items = this.TextValue.Split((char[])null, StringSplitOptions.RemoveEmptyEntries);

                foreach (var item in items)
                {
                    var itemValue = new T
                    {
                        InnerText = item
                    };
                    this._list.Add(itemValue);
                }
            }
        }

        /// <summary>
        /// Convert the text to meaningful value.
        /// </summary>
        /// <returns></returns>
        internal override bool TryParse()
        {
            if (!String.IsNullOrEmpty(this.TextValue))
            {
                // split the string by white-space characters as the delimiters.
                string[] items = this.TextValue.Split((char[])null, StringSplitOptions.RemoveEmptyEntries);

                var list = new ObservableCollection<T>();

                foreach (var item in items)
                {
                    var itemValue = new T
                    {
                        InnerText = item
                    };
                    list.Add(itemValue);
                }

                this._list = list;
                this._list.CollectionChanged += this.CollectionChanged;
                return true;
            }

            return false;
        }

        /// <summary>
        /// Gets or sets the inner XML text.
        /// </summary>
        public override string InnerText
        {
            get
            {
                if (this.TextValue == null && this._list != null)
                {
                    StringBuilder textString = new StringBuilder();
                    string separator = String.Empty;

                    foreach (T value in this._list)
                    {
                        if (value != null)
                        {
                            textString.Append(separator);
                            textString.Append(value.ToString());
                            separator = _listSeparator;
                        }
                    }
                    this.TextValue = textString.ToString();
                }
                return this.TextValue;
            }

            set
            {
                this.TextValue = value;
                this._list = null;
            }
        }

        private protected override OpenXmlSimpleType CloneImpl() => new ListValue<T>(this);

        private void CollectionChanged(Object sender, NotifyCollectionChangedEventArgs e)
        {
            // clear the TextValue when the collection is changed.
            this.TextValue = null;
        }

        /// <inheritdoc/>
        public IEnumerator<T> GetEnumerator() => Items.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
