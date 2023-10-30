#pragma warning disable SA1300 // Element should begin with upper-case letter
namespace iMean.Framework.Entities
#pragma warning restore SA1300 // Element should begin with upper-case letter
{
    /// <summary>
    /// Represents an Entity contract defined by its unique identifier.
    /// </summary>
    public interface IEntity
    {
        /// <summary>
        /// Gets an entity by its unique identifier.
        /// </summary>
        int Id { get; init; }
    }
}
