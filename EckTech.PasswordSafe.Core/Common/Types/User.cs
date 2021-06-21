using Prism.Mvvm;
using System.Collections.Generic;

namespace EckTech.PasswordSafe.Core.Common.Types
{
    public class User : BindableBase
    {
        public string UserName { get; set; }

        public string Email { get; set; }

        public IEnumerable<Role> Roles { get; set; }
    }
}
