using SecurityFramework.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityFramework
{
    public class AuthectionService
    {
        private IThirdPartyAuthService _thirdPartyAuthService { get; set; }

        public AuthectionService(IThirdPartyAuthService thirdPartyAuthService)
        {
            _thirdPartyAuthService = thirdPartyAuthService;
        }

        public bool DoAuth(string userName, string password)
        {
            var response = _thirdPartyAuthService.DoAuthection(userName, password);

            if (response == "0000") return true;
            return false;
        }
    }
}
