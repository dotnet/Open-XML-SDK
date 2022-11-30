using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentFormat.OpenXml.Features;

internal interface ITargetFeature
{
    string Path { get; }

    string Extension { get; }
}
