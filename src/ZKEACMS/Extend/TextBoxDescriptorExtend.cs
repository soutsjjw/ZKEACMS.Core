﻿using Easy.ViewPort.Descriptor;
using System;
using System.Collections.Generic;
using System.Text;

namespace ZKEACMS.Extend
{
    public static class TextBoxDescriptorExtend
    {
        public static TextBoxDescriptor PageSelector(this TextBoxDescriptor descriptor)
        {
            return descriptor.AddClass(StringKeys.SelectPageClass).AddProperty("data-url", Urls.SelectPage);
        }
        public static TextBoxDescriptor MediaSelector(this TextBoxDescriptor descriptor)
        {
            return descriptor.AddClass(StringKeys.SelectImageClass).AddProperty("data-url", Urls.SelectMedia);
        }
    }
}
