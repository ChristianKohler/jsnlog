﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JSNLog.Exceptions
{
    public class SubTagHasTooManyAttributesException : JSNLogException
    {
        public SubTagHasTooManyAttributesException(string subTagName, string allowedAttributeName) : 
            base(string.Format("Too many attributes - In web.config, you can have at most one attribute for the {0} tag. The only attribute allowed is {1}", 
                                    subTagName, allowedAttributeName))
        {
        }
    }
}
