using Prism.Mvvm;
using System;

namespace EckTech.PasswordSafe.Core.Common.Types
{
    public class SafeEntry : BindableBase
    {
        public string Id { get; set; }

        public string CategoryId { get; set; }

        public string Title { get; set; }

        public string Password { get; set; }

        public string Notes { get; set; }

        public DateTime? Expires { get; set; }

        public PasswordStrength Strength { get; set; }
    }
}
