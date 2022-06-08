// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

using System;

namespace DocumentFormat.OpenXml.Features
{
    internal abstract class FeatureEvent<TArg> : IFeatureEvent<TArg>, IRaiseFeatureEvent<TArg>
    {
        public event Action<FeatureEventArgs<TArg>>? Change;

        public void OnChange(EventType type, TArg arg)
            => Change?.Invoke(new FeatureEventArgs<TArg>(type, arg));
    }
}
