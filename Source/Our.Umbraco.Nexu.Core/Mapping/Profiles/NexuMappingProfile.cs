﻿namespace Our.Umbraco.Nexu.Core.Mapping.Profiles
{
    using System.Collections.Generic;

    using AutoMapper;

    using global::Umbraco.Core.Models;

    using Our.Umbraco.Nexu.Core.Mapping.TypeConverters;
    using Our.Umbraco.Nexu.Core.Models;

    /// <summary>
    /// The nexu mapping profile.
    /// </summary>
    internal class NexuMappingProfile : Profile
    {
        /// <summary>
        /// Configures the mapping profile
        /// </summary>
        protected override void Configure()
        {
            Mapper.CreateMap<IEnumerable<Relation>, IEnumerable<RelatedDocument>>().ConvertUsing<RelationsToRelatedDocumentsConverter>();
        }
    }
}
