using EckTech.PasswordSafe.Core.Common.Types;
using EckTech.PasswordSafe.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EckTech.PasswordSafe.Services
{
    public class SafeService : ISafeService
    {
        private Session _session;

        public SafeService(Session session)
        {
        }

        public async Task AddSafeEntry(SafeEntry newEntry)
        {
            await Task.Delay(10);
        }

        public async Task<SafeEntry> GetSafeEntry(string id)
        {
            await Task.Delay(10);
            return null;
        }

        public async Task<IEnumerable<SafeEntry>> ListSafeEntries()
        {
            await Task.Delay(10);
            return null;
        }

        public async Task RemoveSafeEntry(string id)
        {
            await Task.Delay(10);
        }

        public async Task UpdateSafeEntry(string id, SafeEntry updatedEntry)
        {
            await Task.Delay(10);
        }
    }
}
