using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using OzonEdu.Merchandise.Domain.Root;
using OzonEdu.Merchandise.Infrastructure.Repositories.Infrastructure.Interfaces;

namespace OzonEdu.Merchandise.Infrastructure.Repositories.Infrastructure
{
    public class ChangeTracker : IChangeTracker
    {
        public IDictionary<int, Entity> TrackedEntities => _usedEntitiesBackingField;
        
        private readonly ConcurrentDictionary<int, Entity> _usedEntitiesBackingField;

        public ChangeTracker()
        {
            _usedEntitiesBackingField = new ConcurrentDictionary<int, Entity>();
        }
        
        public void Track(Entity entity)
        {
            _usedEntitiesBackingField.TryAdd(entity.GetHashCode(), entity);
        }
    }
}