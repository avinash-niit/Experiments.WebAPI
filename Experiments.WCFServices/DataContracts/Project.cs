using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Experiments.WCFServices.DataContracts
{
    [DataContract]
    public class Project
    {
        [DataMember]
        public long Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string CostCentre { get; set; }

        [DataMember]
        public string Code { get; set; }

        [DataMember]
        public DateTime StartDate { get; set; }

        [DataMember]
        public DateTime? ExpectedCompletionDate { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public byte[] RowVersion { get; set; }

        [DataMember]
        public bool Archived { get; set; }

        [DataMember]
        public bool Locked { get; set; }

        [DataMember]
        public DateTime Created { get; set; }

        [DataMember]
        public DateTime? LastModified { get; set; }
    }
}