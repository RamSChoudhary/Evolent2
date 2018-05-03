//***********************************************************************************************************
//Created BY : Ram.S Choudhary
// Created Date : 01 May 2018
//Purpose : This class handles global or common functionalities in the project.
//***********************************************************************************************************

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCApp.DTO;

namespace MvcApp.Globals
{
    public static class Common
    {
        public static List<ContactInfo> lstContactInfo = new List<ContactInfo>();

        /// <summary>
        /// Created By: Ram.S Choudhary
        /// Created Date: 01 May 2018
        /// Purpose : This method adds the data into the global list.
        /// </summary>
        public static void AddData()
        {
            lstContactInfo.Add(new ContactInfo() { ContactId = 1, Email = "er.vivek@gmail.com", FirstName = "Vivek", LastName = "Sharma", PhoneNumber = "987123765", Status = true });
            lstContactInfo.Add(new ContactInfo() { ContactId = 2, Email = "rahul.nima@gmail.com", FirstName = "Rahul", LastName = "Nima", PhoneNumber = "987678123", Status = true });
            lstContactInfo.Add(new ContactInfo() { ContactId = 3, Email = "akki.576@gmail.com", FirstName = "Akshay", LastName = "Parkhi", PhoneNumber = "967845671", Status = true });
            lstContactInfo.Add(new ContactInfo() { ContactId = 4, Email = "venuks@gmail.com", FirstName = "Venu", LastName = "KS", PhoneNumber = "984576123", Status = true });
            lstContactInfo.Add(new ContactInfo() { ContactId = 5, Email = "atul.sing@gmail.com", FirstName = "Atul", LastName = "Singh", PhoneNumber = "9823839471", Status = true });
        }
    }
}