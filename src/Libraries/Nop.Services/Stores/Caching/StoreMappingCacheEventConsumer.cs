﻿using Nop.Core.Domain.Stores;
using Nop.Services.Caching;

namespace Nop.Services.Stores.Caching
{
    /// <summary>
    /// Represents a store mapping cache event consumer
    /// </summary>
    public partial class StoreMappingCacheEventConsumer : CacheEventConsumer<StoreMapping>
    {
        /// <summary>
        /// Clear cache data
        /// </summary>
        /// <param name="entity">Entity</param>
        protected override void ClearCache(StoreMapping entity)
        {
            var entityId = entity.EntityId;
            var entityName = entity.EntityName;

            var key = NopStoreDefaults.StoreMappingsByEntityIdNameCacheKey.FillCacheKey(entityId, entityName);

            Remove(key);

            key = NopStoreDefaults.StoreMappingIdsByEntityIdNameCacheKey.FillCacheKey(entityId, entityName);
            
            Remove(key);
        }
    }
}
