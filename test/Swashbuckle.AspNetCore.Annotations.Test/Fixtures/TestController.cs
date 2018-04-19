﻿using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Swashbuckle.AspNetCore.Annotations.Test
{
    [SwaggerOperationFilter(typeof(VendorExtensionsOperationFilter))]
    internal class TestController
    {
        public void ActionWithNoAttributes()
        { }

        [SwaggerOperation("CustomOperationId", Tags = new[] { "customTag" }, Schemes = new[] { "customScheme" })]
        public void ActionWithSwaggerOperationAttribute()
        { }

        [SwaggerOperationFilter(typeof(VendorExtensionsOperationFilter))]
        public void ActionWithSwaggerOperationFilterAttribute()
        { }

        [SwaggerResponse(204, typeof(void), "No content is returned.")]
        [SwaggerResponse(400, typeof(IDictionary<string, string>), "This returns a dictionary.")]
        public IActionResult ActionWithSwaggerResponseAttributes()
        {
            throw new NotImplementedException();
        }
    }
}