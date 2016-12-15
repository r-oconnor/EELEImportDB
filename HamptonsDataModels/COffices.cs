using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamptonsDataModels
{
    class COffices
    {
        public int OfficeId { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public string OfficeName { get; set; }
        public string FranchiseName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string LicenseState { get; set; }
        public string LicenseCountry { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string County { get; set; }
        public string ContactEmail { get; set; }
        public string LogoUrl { get; set; }
        public string LogoTimestamp { get; set; }
        public string WebUrl { get; set; }
        public int RetsRdc { get; set; }
        public int RetsZillow { get; set; }
        public int RetsTrulia { get; set; }
        public int RetsPt2 { get; set; }
        public int RetsHomes { get; set; }
        public int RetsHomefinder { get; set; }
        public int RetsOnthemove { get; set; }
        public int RetsJuwai { get; set; }
        public int RetsIdx { get; set; }
        public string Profile { get; set; }
        public string FacebookUrl { get; set; }
        public string TwitterUrl { get; set; }
        public int FtrListingApproval { get; set; }
        public int FtrListingChanges { get; set; }
        public int FtrListingPhotos { get; set; }
        public int FtrListingDocs { get; set; }
        public int FtrListingLinks { get; set; }
        public int IsActive { get; set; }
        public string MktDescPostfix { get; set; }
    }
}
