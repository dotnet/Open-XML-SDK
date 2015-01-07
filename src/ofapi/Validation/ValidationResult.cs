// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocumentFormat.OpenXml.Validation
{
    /// <summary>
    /// Validation results
    /// </summary>
    internal class ValidationResult
    {
        /// <summary>
        /// Initializes a new instance of the ValidationResult.
        /// </summary>
        internal ValidationResult()
        {
            this.Valid = true;
            this.Errors = new List<ValidationErrorInfo>();
        }

        /// <summary>
        /// Gets a value indicating whether the validation is canceled.
        /// </summary>
        internal bool Canceled { get; set; }

        /// <summary>
        /// Gets a value indicating whether the validation returns ok.
        /// </summary>
        internal bool Valid { get; set; }

        /// <summary>
        /// Gets all the validation errors.
        /// </summary>
        /// <remarks>
        /// TODO: tune performance.
        /// </remarks>
        internal List<ValidationErrorInfo> Errors { get; private set; }

        /// <summary>
        /// Gets or sets the maximum number of errors. A zero (0) value means no limitation.
        /// When the errors >= MaxNumberOfErrors, errors will not be recorded, and MaxNumberOfErrorsEvent will be fired.
        /// </summary>
        internal int MaxNumberOfErrors
        {
            get;
            set;
        }

        /// <summary>
        /// Removes all errors and set Valida to true. 
        /// </summary>
        internal void Clear()
        {
            this.Valid = true;
            this.Canceled = false;
            this.Errors.Clear();
        }

        internal void AddError(ValidationErrorInfo error)
        {
            this.Valid = false;
            this.Errors.Add(error);
        }

        /// <summary>
        /// Event handler on validation errors.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="errorEventArgs"></param>
        internal void OnValidationError(object sender, ValidationErrorEventArgs errorEventArgs)
        {
            if (errorEventArgs.ValidationErrorInfo != null)
            {
                if (this.MaxNumberOfErrors > 0 && this.Errors.Count >= this.MaxNumberOfErrors)
                {
                    var eventHandler = this.MaxNumberOfErrorsEventHandler;
                    if (eventHandler != null)
                    {
                        eventHandler(this, null);
                    }
                }
                else
                {
                    this.Valid = false;
                    this.Errors.Add(errorEventArgs.ValidationErrorInfo);
                }
            }
            else
            {
                System.Diagnostics.Debug.Assert(errorEventArgs.ValidationErrorInfo != null);
            }
        }

        /// <summary>
        /// Event handler to be called on maximum validation errors have been fired.
        /// </summary>
        internal event EventHandler<EventArgs> MaxNumberOfErrorsEventHandler;
        // internal TimeSpan ElapsedTime { get; set; }
    }
}
