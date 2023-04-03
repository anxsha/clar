using MediatR;

namespace clar.SharedKernel;

public abstract class DomainEventBase : INotification {
  public DateTime DateOccurred { get; protected set; } = DateTime.UtcNow;
}
