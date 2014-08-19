using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace sdpopsservice
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "SDPOPSService" in both code and config file together.
    public class SDPOPSService : ISDPOPSService
    {

        public bool setOwner(string env, int sdpid, string empalias)
        {
            return true;	 
        }

        public List<Sdp> searchSdpbyTam(string env, string tam)
        {
            List<Sdp> lsdp = new List<Sdp>();
            Sdp sdp1 = new Sdp
            {
		    Tam = "testtam1", Name="testname1",
            };

            Sdp sdp2 = new Sdp
            {
		    Tam = "testtam2", Name="testname2",
            };
            lsdp.Add(sdp1);
            lsdp.Add(sdp2);

            return lsdp;
        }

        public List<Sdp> searchSdpbyName(string env, string Name)
        {
            List<Sdp> lsdp = new List<Sdp>();
            Sdp sdp1 = new Sdp
            {
		    Tam = "testtam1", Name="testname1",
            };

            Sdp sdp2 = new Sdp
            {
		    Tam = "testtam2", Name="testname2",
            };
            lsdp.Add(sdp1);
            lsdp.Add(sdp2);

            return lsdp;
        
        }


        public List<OPSStaff> getAllOpsStaff()
        {
            
            List<OPSStaff> lsdp = new List<OPSStaff>();
            OPSStaff os1 = new OPSStaff
            {
		    Manager = "testmanager1", Name="testname1",
            };

            OPSStaff os2 = new OPSStaff
            {
		    Manager = "testmanager2", Name="testname2",
            };
            lsdp.Add(os1);
            lsdp.Add(os2);

            return lsdp;
        
        
        }
    }
}
