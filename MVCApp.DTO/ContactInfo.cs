//***********************************************************************************************************
//Created BY : Ram.S Choudhary
// Created Date : 01 May 2018
//Purpose : This class handles DTO (Data Transfer Objects) of Contact info operations.
//Also it is responsible for there validations.
//***********************************************************************************************************


using System;
using System.ComponentModel.DataAnnotations;

namespace MVCApp.DTO
{
    public class ContactInfo
    {
        private Int32? _ContactId;
        
        private string _FirstName;
        
        private string _LastName;
        
        private string _Email;

        private string _PhoneNumber;
        
        private Boolean? _Status;

        [Display(Name = "Id")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Id must be numeric")]
        public Int32? ContactId
        {
            get { return _ContactId; }
            set { _ContactId = value; }
        }

        [Display(Name = "First Name")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter First Name.", ErrorMessageResourceName = null, ErrorMessageResourceType = null)]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        public string FirstName
        {
            get { return _FirstName; }
            set { _FirstName = value; }
        }

        [Display(Name = "Last Name")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter Last Name.", ErrorMessageResourceName = null, ErrorMessageResourceType = null)]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        public string LastName
        {
            get { return _LastName; }
            set { _LastName = value; }
        }

        [EmailAddress(ErrorMessage = "Please enter Email.", ErrorMessageResourceName = null, ErrorMessageResourceType = null)]
        [Display(Name = "Email")]
        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter Phone Number.", ErrorMessageResourceName = null, ErrorMessageResourceType = null)]
        [Display(Name = "Phone Number")]
        public string PhoneNumber
        {
            get { return _PhoneNumber; }
            set { _PhoneNumber = value; }
        }

        public Boolean? Status
        {
            get { return _Status; }
            set { _Status = value; }
        }
    }
}
