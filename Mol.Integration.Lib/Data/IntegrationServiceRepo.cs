using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mol.Integration.Lib.Data
{
    public class IntegrationServiceRepo
    {

        public bool IsAuthorized(string userName, string service, string method)
        {
            var result = false;
            using (MOL_Entities entites = new MOL_Entities())
            {
                var query = from insrcon in entites.MOL_IntegrationServiceConsumer
                            join insr in entites.MOL_IntegrationService on new { IntegrationServiceId = insrcon.IntegrationServiceId } equals new { IntegrationServiceId = insr.Id }
                            join con in entites.MOL_Consumer on new { ConsumerId = insrcon.ConsumerId } equals new { ConsumerId = con.Id }
                            where
                              con.ConsumerName == userName &&
                              insr.ServiceName == service &&
                              insr.MethodName == method &&
                              con.Deleted != true
                            select insrcon;
                if (query.Any())
                    result = !query.First<MOL_IntegrationServiceConsumer>().Revoke;
                    
            }
            return result;
        }

        public bool IsAuthenticated(string userName, string password)
        {
            var result = false;
            using (MOL_Entities entites = new MOL_Entities())
            {
                var query = from con in entites.MOL_Consumer
                            where
                              con.ConsumerName == userName &&
                              con.Password == password &&
                              con.Deleted != true
                            select con;
                result = query.Any();
            }
            return result;
        }

        public long InsertLog(string userName, bool authorized, string operation, string service, string message)
        {
            using (MOL_Entities entites = new MOL_Entities())
            {
                MOL_IntegrationServiceLogging transaction = new MOL_IntegrationServiceLogging
                {
                    TransactionDate = DateTime.Now,
                    Authorized = authorized,
                    Operation = operation,
                    Contract = service,
                    MessageBody = message,
                    UserName = userName
                };
                entites.MOL_IntegrationServiceLogging.Add(transaction);
                entites.SaveChanges();
                return transaction.Id;
            }
        }
    }
}
