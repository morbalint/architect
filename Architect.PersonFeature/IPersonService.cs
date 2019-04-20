﻿using Architect.Database.Infrastructure;
using Architect.PersonFeature.DataTransfer.Request;
using Architect.PersonFeature.DataTransfer.Response;

namespace Architect.PersonFeature
{
    public interface IPersonService : IService<PersonViewModel, CreatePersonRequest, UpdatePersonRequest,DeletePersonRequest>
    {
    }
}
