﻿using System.Linq;
using System.Threading.Tasks;
using VirtoCommerce.Platform.Core.Common;
using VirtoCommerce.QuoteModule.Data.Model;

namespace VirtoCommerce.QuoteModule.Data.Repositories
{
    public interface IQuoteRepository : IRepository
    {
        IQueryable<QuoteRequestEntity> QuoteRequests { get; }
        IQueryable<AddressEntity> Addresses { get; }
        IQueryable<AttachmentEntity> Attachments { get; }
        IQueryable<QuoteItemEntity> QuoteItems { get; }

        Task<QuoteRequestEntity[]> GetQuoteRequestByIdsAsync(params string[] ids);
    }
}
