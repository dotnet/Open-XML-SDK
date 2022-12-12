// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml.Features
{
    /// <summary>
    /// Type of event used for change notification.
    /// </summary>
    public enum EventType
    {
        /// <summary>
        /// The default type when there is no event.
        /// </summary>
        None,

        /// <summary>
        /// When the item is closed.
        /// </summary>
        Closed,

        /// <summary>
        /// When the item is closing.
        /// </summary>
        Closing,

        /// <summary>
        /// When the item is deleting.
        /// </summary>
        Deleting,

        /// <summary>
        /// When the item is deleted.
        /// </summary>
        Deleted,

        /// <summary>
        /// When the item is being created.
        /// </summary>
        Creating,

        /// <summary>
        /// When the item is created.
        /// </summary>
        Created,

        /// <summary>
        /// When the item is being removed.
        /// </summary>
        Removing,

        /// <summary>
        /// When the item is removed.
        /// </summary>
        Removed,

        /// <summary>
        /// When the item is reloading.
        /// </summary>
        Reloading,

        /// <summary>
        /// When the item is reloaded.
        /// </summary>
        Reloaded,

        /// <summary>
        /// When the item is being saved.
        /// </summary>
        Saved,

        /// <summary>
        /// When the item is saved.
        /// </summary>
        Saving,

        /// <summary>
        /// When the item is being added.
        /// </summary>
        Adding,

        /// <summary>
        /// When the item is added.
        /// </summary>
        Added,
    }
}
