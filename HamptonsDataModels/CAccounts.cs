using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamptonsDataModels
{
    class CAccounts
    {
        public int AgentId { get; set; }
        public int OfficeId { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public string Username { get; set; }
        public string AccountEmail { get; set; }
        public int AuthOffices { get; set; }
        public int AuthOffice { get; set; }
        public int AuthAgent { get; set; }
        public int AuthAppraise { get; set; }
        public int AuthListingApprover { get; set; }
        public int AuthListingLinks { get; set; }
        public int AuthListingPhotos { get; set; }
        public int AuthListingDocs { get; set; }
        public int AuthAddAgent { get; set; }
        public int IsPublic { get; set; }
        public string LastLogin { get; set; }
        public int IsWebLogin { get; set; }
        public int RetsPt2 { get; set; }
        public int RetsRdc { get; set; }
        public int RetsZillow { get; set; }
        public int RetsTrulia { get; set; }
        public int RetsHomes { get; set; }
        public int RetsHomefinder { get; set; }
        public int RetsOnthemove { get; set; }
        public int RetsJuwai { get; set; }
        public int RetsIdx { get; set; }
        public int IsBroker { get; set; }
        public string JoinDate { get; set; }
        public string RenewDate { get; set; }
        public string AgentLicense { get; set; }
        public string AgentLicenseExpire { get; set; }
        public string AgentLicenseType { get; set; }
        public string AgentLicenseState { get; set; }
        public string AppraiserLicense { get; set; }
        public string AppraiserLicenseExpire { get; set; }
        public string Honorific { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string PostNom { get; set; }
        public string Title { get; set; }
        public string Biphone { get; set; }
        public string Bphone { get; set; }
        public string Bphoneext { get; set; }
        public string Bcell { get; set; }
        public string Bfax { get; set; }
        public string AccountUrl { get; set; }
        public string Profile { get; set; }
        public string PhotoUrl { get; set; }
        public string PhotoTimestamp { get; set; }
        public string MktDescPostfix { get; set; }
        public int AccountActive { get; set; }
    }
}