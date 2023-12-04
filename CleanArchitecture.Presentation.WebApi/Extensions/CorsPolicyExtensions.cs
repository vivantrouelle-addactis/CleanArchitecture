﻿using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitecture.Presentation.WebApi.Extensions
{
    public static class CorsPolicyExtensions
    {
        public static void ConfigureCorsPolicy(this IServiceCollection services)
        {
            services.AddCors(opt =>
            {
                opt.AddDefaultPolicy(builder => builder
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());
            });
        }
    }
}
