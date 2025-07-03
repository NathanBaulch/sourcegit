using System.Threading.Tasks;

namespace SourceGit.Models
{
    public interface IRepository
    {
        bool MayHaveSubmodules();

        Task RefreshBranchesAsync();
        Task RefreshWorktreesAsync();
        Task RefreshTagsAsync();
        Task RefreshCommitsAsync();
        Task RefreshSubmodulesAsync();
        Task RefreshWorkingCopyChangesAsync();
        Task RefreshStashesAsync();
    }
}
