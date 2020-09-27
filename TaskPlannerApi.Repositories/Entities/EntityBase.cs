using System;

namespace TaskPlannerApi.Repositories.Entities
{
    /// <summary>
    /// Using this class for base will default the primary key of the entity to be int.
    /// </summary>
    public class EntityBase : EntityBase<int>
    {
    }

    /// <summary>
    /// The base entity.
    /// </summary>
    /// <typeparam name="TKey">The primary key parameter type for the entity.</typeparam>
    public class EntityBase<TKey> : IEntityBase where TKey: IEquatable<TKey>
    {
        /// <summary>
        /// Gets or sets the Id of the entity
        /// </summary>
        public int Id { get; set; }
    }

    public interface IEntityBase
    {
    }
}
