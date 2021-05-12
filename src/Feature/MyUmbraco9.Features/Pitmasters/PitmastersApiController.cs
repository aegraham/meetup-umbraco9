// --------------------------------------------------------------------------------------------------------------------
// <copyright company="twentysix" file="PitmastersApiController.cs">
// Copyright (c) twentysix.  All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace MyUmbraco9.Features.Pitmasters
{
    using System.Linq;

    using Microsoft.AspNetCore.Mvc;

    using MyUmbraco9.Infrastructure.DocumentTypes.GeneratedModels;

    using Umbraco.Cms.Core;
    using Umbraco.Cms.Web.Common.Controllers;

    public class PitmastersApiController : UmbracoApiController
    {
        private readonly IPublishedContentQuery _contentQuery;
        public PitmastersApiController(IPublishedContentQuery contentQuery)
        {
            _contentQuery = contentQuery;
        }

 
        [HttpGet]
        public string GetPitmasters()
        {
            var pitmasters = _contentQuery.ContentAtRoot().OfType<PitMasters>().FirstOrDefault();
            var returnValue = string.Empty;
            foreach (Pitmaster child in pitmasters.Children)
            {
                returnValue += child.FullName;
            }
            
            return returnValue;
        }
    }
}