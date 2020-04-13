﻿using Nop.Core.Domain.Orders;
using Nop.Services.Caching;

namespace Nop.Services.Orders.CacheEventConsumers
{
    /// <summary>
    /// Represents a checkout attribute cache event consumer
    /// </summary>
    public partial class CheckoutAttributeCacheEventConsumer : CacheEventConsumer<CheckoutAttribute>
    {
        /// <summary>
        /// Clear cache data
        /// </summary>
        /// <param name="entity">Entity</param>
        protected override void ClearCache(CheckoutAttribute entity)
        {
            RemoveByPrefix(NopOrderDefaults.CheckoutAttributesAllPrefixCacheKey);
            var cacheKey = _cacheKeyService.PrepareKeyForDefaultCache(NopOrderDefaults.CheckoutAttributeValuesAllCacheKey, entity);
            Remove(cacheKey);
        }
    }
}