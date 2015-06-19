using System;
using System.Collections.Generic;
using System.IdentityModel.Claims;
using System.Linq;
using System.Security.Principal;
using System.ServiceModel;
using System.Text;
using System.Threading;
using Mol.Integration.Lib.Data;

namespace Mol.Integration.Lib.Authorization
{
    public class CustomPrincipal : IPrincipal
    {
        private IIdentity _identity;
        //private string[] _roles;

        public CustomPrincipal(IIdentity identity)
        {
            this._identity = identity;
        }

        // helper method for easy access (without casting)
        public static CustomPrincipal Current
        {
            get
            {
                return Thread.CurrentPrincipal as CustomPrincipal;
            }
        }

        IIdentity IPrincipal.Identity
        {
            get
            {
                return this._identity;
            }
        }

        // return all roles
        //public string[] Roles
        //{
        //    get
        //    {
        //        EnsureRoles();
        //        return _roles;
        //    }
        //}

        bool IPrincipal.IsInRole(string role)
        {
            if (_identity != null && _identity.IsAuthenticated && !string.IsNullOrWhiteSpace(role))
            {
                string contract = OperationContext.Current.EndpointDispatcher.ContractName;
                string operation = string.Empty;
                foreach (var item in OperationContext.Current.EndpointDispatcher.DispatchRuntime.Operations)
                {
                    if (item.Action == OperationContext.Current.IncomingMessageHeaders.Action)
                    {
                        operation = item.Name;
                        break;
                    }
                }
                IntegrationServiceRepo repo = new IntegrationServiceRepo();
                return repo.IsAuthorized(_identity.Name, contract, operation);
            }
            return false;

            //string[] roles = Roles.Providers["RoleProvider"].GetRolesForUser(Identity.Name);
            //return roles.Any(s => role.Contains(s)); 
        }

        // read Role of user from database
        //protected virtual void EnsureRoles()
        //{
        //    if (_identity.Name == "tamkeen")
        //        _roles = new string[1] { "Admin" };
        //    else
        //        _roles = new string[1] { "User" };
        //}
    }
}
