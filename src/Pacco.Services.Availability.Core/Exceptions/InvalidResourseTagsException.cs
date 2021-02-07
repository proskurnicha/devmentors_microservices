namespace Pacco.Services.Availability.Core.Exceptions
{
    public class InvalidResourseTagsException : DomainException
    {
        public InvalidResourseTagsException() : base(message: "Invalid tags for the resource.")
        {

        }
    }
}
