using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Mol.Integration.Lib.Common;
using Mol.Integration.Lib.Contract.Data;
using Mol.Integration.Lib.Contract.Fault;

namespace Mol.Integration.Lib.Contract.Service
{
    [ServiceContract(Namespace = Constants.Namespace)]
    public interface INICService
    {
        [FaultContract(typeof(NICFaultContract))]
        [OperationContract]
        bool CancelVisa(double requestNumber, double borderNumber);


        [FaultContract(typeof(NICFaultContract))]
        [OperationContract]
        DependentsData QueryDependentsByID(double IdNo);

        [FaultContract(typeof(NICFaultContract))]
        [OperationContract]
        bool GetLabrorPrisonStatus(double IdNo);

        [FaultContract(typeof(NICFaultContract))]
        [OperationContract]
        bool AuthenticateUserByMobile(double IdNo, string smsCode);

        [FaultContract(typeof(NICFaultContract))]
        [OperationContract]
        string Test(string Name);
    }

}
