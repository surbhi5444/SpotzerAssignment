using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SpotzerOrderApi.Models
{
    public class LineItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LineItemID { get; set; }

        [Required]
        public int ID { get; set; }
        [Required]
        public string ProductID { get; set; }
        [Required]
        public string ProductType { get; set; }
        [Required]
        public string Notes { get; set; }
        [Required]
        public string Category { get; set; }

        #region reference properties
        [ForeignKey("Order")]
        public int OrderID { get; set; }
        public Order Order { get; set; }
        public  WebsiteDetails WebsiteDetails { get; set; }
        public  AdWordCampaign AdWordCampaign { get; set; }
        #endregion
    }
}