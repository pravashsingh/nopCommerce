﻿using Nop.Core.Domain.Customers;
using Nop.Services.Caching;

namespace Nop.Services.Customers.Caching
{
    /// <summary>
    /// Represents a customer attribute value cache event consumer
    /// </summary>
    public partial class CustomerAttributeValueCacheEventConsumer : CacheEventConsumer<CustomerAttributeValue>
    {
        /// <summary>
        /// Clear cache data
        /// </summary>
        /// <param name="entity">Entity</param>
        protected override void ClearCache(CustomerAttributeValue entity)
        {
            base.Remove(NopCustomerServicesDefaults.CustomerAttributesAllCacheKey);
            base.Remove(NopCustomerServicesDefaults.CustomerAttributeValuesAllCacheKey.FillCacheKey(entity.CustomerAttributeId));
        }
    }
}