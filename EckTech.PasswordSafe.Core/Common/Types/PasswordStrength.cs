using System.ComponentModel;

namespace EckTech.PasswordSafe.Core.Common.Types
{
    public enum PasswordStrength
    {
        Weak,
        Poor,
        Fair,
        Moderate,
        Good,
        Excellent,

        [Description("Ver Strong")]
        VeryStrong
    }
}
