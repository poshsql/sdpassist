using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace sdpopsservice
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ISDPOPSService" in both code and config file together.
    [ServiceContract]
    public interface ISDPOPSService
    {
        [OperationContract]
        bool setOwner(string env, int sdpid, string empalias);

	[OperationContract]	    
	List<Sdp> searchSdpbyTam(string env, string tam);

	[OperationContract]	    
	List<Sdp> searchSdpbyName(string env, string Name);

	[OperationContract]	    
	List<OPSStaff> getAllOpsStaff();
    }
}
