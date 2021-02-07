namespace Pacco.Services.Availability.Core.Exceptions
{
    public class MissingResourseTagsException : DomainException
    {
        public MissingResourseTagsException() : base(message: $"Missing tags for the resourse.")
        {
        }
    }
}
