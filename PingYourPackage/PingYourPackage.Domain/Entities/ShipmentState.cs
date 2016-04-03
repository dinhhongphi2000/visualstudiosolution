using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using PingYourPackage.Domain.Entities.Core;
namespace PingYourPackage.Domain.Entities
{
    public class ShipmentState : IEntity
    {
        [Key]
        public Guid Key { get; set; }
        public Guid ShipmentKey { get; set;}
        [Required]
        public ShipmentStatus ShipmentStatus { get; set; }
        public DateTime CreateOn { get; set; }
        public Shipment Shipment { get; set; }
    }
}
