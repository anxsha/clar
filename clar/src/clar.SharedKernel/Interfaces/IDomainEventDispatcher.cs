﻿namespace clar.SharedKernel.Interfaces;

public interface IDomainEventDispatcher {
  Task DispatchAndClearEvents(IEnumerable<EntityBase> entitiesWithEvents);
}
