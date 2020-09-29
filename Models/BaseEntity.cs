using System;

namespace PetClinicUI.Models
{
    
    [Serializable]
    public class BaseEntity
    {
        public int Id { get; set; }
        public bool IsNew { get; set; }
    }
}