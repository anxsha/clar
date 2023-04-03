﻿using Ardalis.Specification;

namespace clar.SharedKernel.Interfaces;

public interface IReadRepository<T> : IReadRepositoryBase<T> where T : class, IAggregateRoot { }
