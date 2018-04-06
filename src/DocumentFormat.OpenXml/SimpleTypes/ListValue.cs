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

            _list = new ObservableCollection<T>();
            _list.CollectionChanged += CollectionChanged;

            foreach (var item in list)
            {
                _list.Add(item.Clone() as T);
            }
        }

        /// <summary>
        /// Initializes a new instance of the ListValue class by deep copying the supplied ListValue class.
        /// </summary>
        /// <param name="source">The source ListValue class.</param>
        public ListValue(ListValue<T> source)
            : this(source.Items)
        {
        }

        /// <inheritdoc/>
        public override bool HasValue
        {
            get
            {
                if (_list == null)
                {
                    if (!string.IsNullOrEmpty(TextValue))
                    {
                        TryParse();
                    }
                }

                if (_list == null)
                {
                    return false;
                }
                else
                {
                    return _list.Count > 0;
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
                if (_list == null)
                {
                    if (!string.IsNullOrEmpty(TextValue))
                    {
                        Parse();
                    }
                    else
                    {
                        _list = new ObservableCollection<T>();
                        _list.CollectionChanged += CollectionChanged;
                    }
                }

                Debug.Assert(_list != null);
                return _list;
            }
        }

        /// <summary>
        /// Convert the text to meaningful value.
        /// </summary>
        private void Parse()
        {
            _list = new ObservableCollection<T>();
            _list.CollectionChanged += CollectionChanged;

            if (!string.IsNullOrEmpty(TextValue))
            {
                // split the string by white-space characters as the delimiters.
                string[] items = TextValue.Split((char[])null, StringSplitOptions.RemoveEmptyEntries);

                foreach (var item in items)
                {
                    var itemValue = new T
                    {
                        InnerText = item,
                    };
                    _list.Add(itemValue);
                }
            }
        }

        /// <summary>
        /// Convert the text to meaningful value.
        /// </summary>
        /// <returns></returns>
        private bool TryParse()
        {
            if (!string.IsNullOrEmpty(TextValue))
            {
                // split the string by white-space characters as the delimiters.
                string[] items = TextValue.Split((char[])null, StringSplitOptions.RemoveEmptyEntries);

                var list = new ObservableCollection<T>();

                foreach (var item in items)
                {
                    var itemValue = new T
                    {
                        InnerText = item,
                    };
                    list.Add(itemValue);
                }

                _list = list;
                _list.CollectionChanged += CollectionChanged;
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
                if (TextValue == null && _list != null)
                {
                    StringBuilder textString = new StringBuilder();
                    string separator = string.Empty;

                    foreach (T value in _list)
                    {
                        if (value != null)
                        {
                            textString.Append(separator);
                            textString.Append(value.ToString());
                            separator = _listSeparator;
                        }
                    }

                    TextValue = textString.ToString();
                }

                return TextValue;
            }

            set
            {
                TextValue = value;
                _list = null;
            }
        }

        private protected override OpenXmlSimpleType CloneImpl() => new ListValue<T>(this);

        private void CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            // clear the TextValue when the collection is changed.
            TextValue = null;
        }

        /// <inheritdoc/>
        public IEnumerator<T> GetEnumerator() => Items.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
