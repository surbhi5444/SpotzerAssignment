﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SpotzerOrderApi.Models
{
    public class AdWordCampaign
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AdWordCampaignID { get; set; }
        public string CampaignName { get; set; }
        public string CampaignAddressLine1 { get; set; }
        public string CampaignPostCode { get; set; }
        public string CampaignRadius { get; set; }
        public string LeadPhoneNumber { get; set; }
        public string SMSPhoneNumber { get; set; }
        public string UniqueSellingPoint1 { get; set; }
        public string UniqueSellingPoint2 { get; set; }
        public string UniqueSellingPoint3 { get; set; }
        public string Offer { get; set; }
        public string DestinationURL { get; set; }
    }
}