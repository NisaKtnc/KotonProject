using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koton.Entities.Models
{
    public abstract class BaseEntity : IBaseEntity
    {
        public DateTime createdDate {  get; set; }    
        public string createdUsername { get; set; } 
        public DateTime? modifiedTime { get; set; }
        public string? modifiedUsername { get; set; }
        public DateTime? deletedTime { get; set; }
        public string deletedUsername { get; set; }
        public bool IsActive { get; set; }  
        public bool IsDeleted { get; set; }

        public BaseEntity() 
        {
            
        }
    }
    
    
}

