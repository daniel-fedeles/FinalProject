namespace MedicalReminder.Models
{
    public class Doctor:IDEntity
    {

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Specialization { get; set; }

        public string Hospital { get; set; }

        public virtual Prescription Prescription { get; set; }

    }
}