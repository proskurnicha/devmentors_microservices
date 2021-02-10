using System;

namespace Pacco.Services.Availability.Application.Exceptions
{
    public class ResourceAlreadyExistException : AppException
    {
        public ResourceAlreadyExistException(Guid id) : base(message: $"Resource with ID: '{id} already exists.'")
        {        
            
        }
    }
}
