//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v9.0.0-beta002+de0929762c60039b3a41dd34c48227ad85ae377f
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Linq.Expressions;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.PublishedCache;
using Umbraco.Cms.Infrastructure.ModelsBuilder;
using Umbraco.Cms.Core;
using Umbraco.Extensions;

namespace MyUmbraco9.Infrastructure.DocumentTypes.GeneratedModels
{
	// Mixin Content Type with alias "templateWebsiteSettings"
	/// <summary>Template Website Settings</summary>
	public partial interface ITemplateWebsiteSettings : IPublishedContent
	{
		/// <summary>Internal Redirect</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-beta002+de0929762c60039b3a41dd34c48227ad85ae377f")]
		global::Umbraco.Cms.Core.Models.PublishedContent.IPublishedContent UmbracoInternalRedirectId { get; }
	}

	/// <summary>Template Website Settings</summary>
	[PublishedModel("templateWebsiteSettings")]
	public partial class TemplateWebsiteSettings : PublishedContentModel, ITemplateWebsiteSettings
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-beta002+de0929762c60039b3a41dd34c48227ad85ae377f")]
		public new const string ModelTypeAlias = "templateWebsiteSettings";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-beta002+de0929762c60039b3a41dd34c48227ad85ae377f")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-beta002+de0929762c60039b3a41dd34c48227ad85ae377f")]
		public new static IPublishedContentType GetModelContentType(IPublishedSnapshotAccessor publishedSnapshotAccessor)
			=> PublishedModelUtility.GetModelContentType(publishedSnapshotAccessor, ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-beta002+de0929762c60039b3a41dd34c48227ad85ae377f")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(IPublishedSnapshotAccessor publishedSnapshotAccessor, Expression<Func<TemplateWebsiteSettings, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(publishedSnapshotAccessor), selector);
#pragma warning restore 0109

		private IPublishedValueFallback _publishedValueFallback;

		// ctor
		public TemplateWebsiteSettings(IPublishedContent content, IPublishedValueFallback publishedValueFallback)
			: base(content, publishedValueFallback)
		{
			_publishedValueFallback = publishedValueFallback;
		}

		// properties

		///<summary>
		/// Internal Redirect
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-beta002+de0929762c60039b3a41dd34c48227ad85ae377f")]
		[ImplementPropertyType("umbracoInternalRedirectId")]
		public virtual global::Umbraco.Cms.Core.Models.PublishedContent.IPublishedContent UmbracoInternalRedirectId => GetUmbracoInternalRedirectId(this, _publishedValueFallback);

		/// <summary>Static getter for Internal Redirect</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-beta002+de0929762c60039b3a41dd34c48227ad85ae377f")]
		public static global::Umbraco.Cms.Core.Models.PublishedContent.IPublishedContent GetUmbracoInternalRedirectId(ITemplateWebsiteSettings that, IPublishedValueFallback publishedValueFallback) => that.Value<global::Umbraco.Cms.Core.Models.PublishedContent.IPublishedContent>(publishedValueFallback, "umbracoInternalRedirectId");
	}
}
