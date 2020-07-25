﻿using Autofac;
using Fur.DatabaseAccessor.Extensions;
using Fur.DatabaseAccessor.MultipleTenants.Provider;
using Fur.EntityFramework.Core.DbContexts;

namespace Fur.EntityFramework.Core
{
    public class FurEntityFrameworkCoreModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterDbContexts<FurSqlServerDbContext>(options =>
            {
                options.MultipleTenantProvider = typeof(MultipleTenantProvider);
            }, typeof(FurMultipleSqlServerDbContext));
        }
    }
}