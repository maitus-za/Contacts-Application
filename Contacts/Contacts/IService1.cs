using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Contacts
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {   // Methods
        [OperationContract]
        IEnumerable<Contact> GetContacts(); //IEmurable is to get collection of data

        [OperationContract]
        void InsertContact(Contact contact);

        [OperationContract]
        void UpdateContact(Contact contact);

        [OperationContract]
        void DeleteContact(int id); //id specifies the specific contact
    }

    [DataContract]
    public class Contact
    {
        [DataMember]
        [Key]
        [Required]
        public int Id { get; set; }

        [DataMember]
        [Required]
        public string FirstName { get; set; }

        [DataMember]
        public string MiddleName { get; set; }

        [DataMember]
        [Required]
        public string LastName { get; set; }

        [DataMember]
        [Required]
        public string PhoneNumbers { get; set; }

        [DataMember]
        public string Address { get; set; }
    }
}
