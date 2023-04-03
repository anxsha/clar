using Ardalis.Result;

namespace clar.Core.Interfaces;

public interface IDeleteContributorService {
  public Task<Result> DeleteContributor(int contributorId);
}
