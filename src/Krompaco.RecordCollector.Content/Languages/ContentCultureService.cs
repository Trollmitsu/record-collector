﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Krompaco.RecordCollector.Content.Languages
{
    public class ContentCultureService
    {
#pragma warning disable CA1822 // Mark members as static
        public bool DoesCultureExist(string cultureName)
#pragma warning restore CA1822 // Mark members as static
        {
            return CultureInfo.GetCultures(CultureTypes.AllCultures)
                .Any(culture => string.Equals(culture.Name, cultureName, StringComparison.CurrentCultureIgnoreCase));
        }
    }
}