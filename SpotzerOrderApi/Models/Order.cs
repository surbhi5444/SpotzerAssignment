using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SpotzerOrderApi.Models
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        public string Partner { get; set; }
        [Required]
        public string OrderID { get; set; }
        [Required]
        public string TypeOfOrder { get; set; }
        [Required]
        public string SubmittedBy { get; set; }
        [Required]
        public string CompanyID { get; set; }
        [Required]

        #region Extra Fields
        public string CompanyName { get; set; }
        public string ContactFirstName { get; set; }
        public string ContactLastName { get; set; }
        public string ContactTitle { get; set; }
        public string ContactPhone { get; set; }
        public string ContactMobile { get; set; }
        public string ContactEmail { get; set; }
        public string ExposureID { get; set; }
        public string UDAC { get; set; }
        public string RelatedOrder { get; set; }
        #endregion

        public virtual ICollection<LineItem> LineItems { get; set; }
    }
}