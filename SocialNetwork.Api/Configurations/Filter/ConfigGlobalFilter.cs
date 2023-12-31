﻿using Microsoft.AspNetCore.Mvc;
using System.Text.Json.Serialization;

namespace SocialNetwork.Api.Configurations.Filter
{
    public static class ConfigGlobalFilter
    {
        public static void AddControllerWithCustomFilter(this IServiceCollection services)
        {
            services.AddControllers(option =>
            {
                option.Filters.Add(new GlobalValidationActionFilter());
            }).AddJsonOptions(options =>
            {
                options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles; // remove cycle when serialize using System.Text.Json
            });

            services.Configure<ApiBehaviorOptions>(options =>
            {
                options.SuppressModelStateInvalidFilter = true; //true to ignore modelState filter
            });
        }
    }
}
