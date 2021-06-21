using EckTech.PasswordSafe.Core.Common.Types;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EckTech.PasswordSafe.Services.Interfaces
{
    public interface ISafeService
    {
        Task AddSafeEntry(SafeEntry newEntry);

        Task UpdateSafeEntry(string id, SafeEntry updatedEntry);

        Task RemoveSafeEntry(string id);

        Task<SafeEntry> GetSafeEntry(string id);

        Task<IEnumerable<SafeEntry>> ListSafeEntries();
    }
}