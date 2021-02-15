﻿using Convey.Persistence.MongoDB;
using Pacco.Services.Availability.Core.Entities;
using Pacco.Services.Availability.Core.Repositories;
using Pacco.Services.Availability.Infrastructure.Mongo.Documents;
using System;
using System.Threading.Tasks;

namespace Pacco.Services.Availability.Infrastructure.Mongo.Repositories
{
    internal sealed class ResourcesMongoRepository : IResourcesRepository
    {
        private readonly IMongoRepository<ResourceDocument, Guid> _repository;
        public ResourcesMongoRepository(IMongoRepository<ResourceDocument, Guid> repository)
            => _repository = repository;

        public async Task<Resource> GetAsync(AggregateId id)
        {
            var document = await _repository.GetAsync(r => r.Id == id);
            return document?.AsEntity();
        }

        public async Task AddAsync(Resource resource)
            => await _repository.AddAsync(resource.AsDocument());

        public async Task DeleteAsync(AggregateId id)
        {
            await _repository.DeleteAsync(r => r.Id == id);
        }

        public async Task UpdateAsync(Resource resource)
        {
            await _repository.UpdateAsync(resource.AsDocument());
        }
    }
}
