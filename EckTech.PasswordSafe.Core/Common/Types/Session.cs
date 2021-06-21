using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EckTech.PasswordSafe.Core.Common.Types
{
    public class Session : BindableBase
    {
        private User _user;

        public User User => _user;

        public string Token { get; set; }

    }
}
