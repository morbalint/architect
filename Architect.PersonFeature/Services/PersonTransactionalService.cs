﻿using System;
using System.Threading;
using System.Threading.Tasks;

using Architect.Common.Infrastructure;
using Architect.Common.Infrastructure.DataTransfer.Response;
using Architect.PersonFeature.DataTransfer.Request;
using Architect.PersonFeature.DataTransfer.Response;

namespace Architect.PersonFeature.Services
{
    public class PersonTransactionalService : IPersonTransactionalService
    {
        protected readonly IPersonService service;

        public PersonTransactionalService(IPersonService service)
        {
            this.service = service.ArgumentNullCheck(nameof(service));
        }

        public virtual async Task<IStatusResponse> ChangeAddressAsync(
            ChangeAddressRequest model, CancellationToken token = default)
        {
            model.ArgumentNullCheck(nameof(model));

            using (var scope = TransactionFactory.CreateTransaction())
            {
                var result = await service.ChangeAddressAsync(model, token)
                    .ConfigureAwaitFalse();
                scope.Complete();

                return result;
            }
        }

        public virtual async Task<IStatusResponse> ChangeNameAsync(
            ChangeNameRequest model, CancellationToken token = default)
        {
            model.ArgumentNullCheck(nameof(model));

            using (var scope = TransactionFactory.CreateTransaction())
            {
                var result = await service.ChangeNameAsync(model, token)
                    .ConfigureAwaitFalse();
                scope.Complete();

                return result;
            }
        }

        public virtual async Task<IStatusResponse> CreateAsync(
            CreatePersonRequest model, CancellationToken token = default)
        {
            model.ArgumentNullCheck(nameof(model));

            using (var scope = TransactionFactory.CreateTransaction())
            {
                var result = await service.CreateAsync(model, token);
                scope.Complete();

                return result;
            }
        }

        public virtual async Task<IStatusResponse> DeleteAsync(
            DeletePersonRequest model, CancellationToken token = default)
        {
            model.ArgumentNullCheck(nameof(model));

            using (var scope = TransactionFactory.CreateTransaction())
            {
                var result = await service.DeleteAsync(model, token);
                scope.Complete();

                return result;
            }
        }

        public virtual async Task<IDataResponse<PersonViewModel>> GetAsync(
            int id, CancellationToken token = default)
        {
            id.ArgumentOutOfRangeCheck(nameof(id));

            var result = await service.GetAsync(id, token);

            return result;
        }

        public virtual async Task<IStatusResponse> UpdateAsync(
            UpdatePersonRequest model, CancellationToken token = default)
        {
            model.ArgumentNullCheck(nameof(model));

            using (var scope = TransactionFactory.CreateTransaction())
            {
                var result = await service.UpdateAsync(model, token);
                scope.Complete();

                return result;
            }
        }
    }
}
