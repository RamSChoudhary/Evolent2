using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCApp.DTO;
using MvcApp.Globals;

namespace MvcApp.Models
{
    public class ContactInfoModel
    {
        /// <summary>
        /// Created By : Ram.S Choudhary
        /// Created Date : 1 May 2018
        /// Purpose : This method is responsible for getting all
        /// contact details info from DB.
        /// </summary>
        /// <returns></returns>
        public List<ContactInfo> GetContactDetails()
        {
            
            return Common.lstContactInfo;
        }

        /// <summary>
        /// Created By : Ram.S Choudhary
        /// Created Date : 1 May 2018
        /// Purpose : This method is responsible for adding 
        /// contact details info into DB.
        /// </summary>
        /// <param name="pContactInfos"></param>
        /// <returns></returns>
        public Int16 AddContactDetails(ContactInfo pContactInfo)
        {
            Int16 result = 0;
            if (pContactInfo != null)
            {
                ContactInfo objContactDetails = new ContactInfo();
                objContactDetails.ContactId = pContactInfo.ContactId;
                objContactDetails.Email = pContactInfo.Email;
                objContactDetails.FirstName = pContactInfo.FirstName;
                objContactDetails.LastName = pContactInfo.LastName;
                objContactDetails.PhoneNumber = pContactInfo.PhoneNumber;
                objContactDetails.Status = pContactInfo.Status;

                Common.lstContactInfo.Add(objContactDetails);
                result = 1;
            }
            return result;
        }

        /// <summary>
        /// Created By : Ram.S Choudhary
        /// Created Date : 1 May 2018
        /// Purpose : This method is responsible for updating
        /// contact details info into DB.
        /// </summary>
        /// <param name="pContactInfo"></param>
        /// <returns></returns>
        public int UpdateContactDetails(ContactInfo pContactInfo)
        {
            int result = 0;
            ContactInfo objContactDetails = GetContactDetails().Find(p => p.ContactId == pContactInfo.ContactId);
            if (objContactDetails != null)
            {
                objContactDetails.Email = pContactInfo.Email;
                objContactDetails.FirstName = pContactInfo.FirstName;
                objContactDetails.LastName = pContactInfo.LastName;
                objContactDetails.PhoneNumber = pContactInfo.PhoneNumber;
                objContactDetails.Status = pContactInfo.Status;

                result = 1;
            }
            return result;
        }

        /// <summary>
        /// Created By : Ram.S Choudhary
        /// Created Date : 1 May 2018
        /// Purpose : This method is responsible for deleteing
        /// contact details info into DB.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int DeleteContactDetails(int id)
        {
            int result = 0;
            result = GetContactDetails().RemoveAll(p => p.ContactId == id);
            return result;
        }

    }
}