using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens;
using System.Linq;
using System.ServiceModel;
using System.Text;
using Mol.Integration.Lib.Data;

namespace Mol.Integration.Lib.Authentication
{
    public class UserNamePasswordValidator : System.IdentityModel.Selectors.UserNamePasswordValidator
    {
        public override void Validate(string userName, string password)
        {
            if (String.IsNullOrEmpty(userName) || String.IsNullOrEmpty(password))
            {
                throw new SecurityTokenException();
            }

            IntegrationServiceRepo repo = new IntegrationServiceRepo();
            if (!repo.IsAuthenticated(userName, password))
            {
                throw new SecurityTokenException("Incorrect User name or Password");
            }
        }
    }
}
