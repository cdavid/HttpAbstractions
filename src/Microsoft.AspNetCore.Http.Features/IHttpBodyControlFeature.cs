﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.AspNetCore.Http.Features
{
    /// <summary>
    /// Controls the IO behavior for the <see cref="IHttpRequestFeature.Body"/> and <see cref="IHttpResponseFeature.Body"/> 
    /// </summary>
    public interface IHttpBodyControlFeature
    {
        /// <summary>
        /// Gets or sets a value that controls whether synchronous IO is allowed for the <see cref="IHttpRequestFeature.Body"/> and <see cref="IHttpResponseFeature.Body"/> 
        /// </summary>
        bool AllowSynchronousIO { get; set; }
    }
}
