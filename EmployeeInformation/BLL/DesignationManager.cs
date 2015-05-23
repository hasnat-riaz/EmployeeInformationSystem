using System.Collections.Generic;
using EmployeeInformation.DAL.DAO;
using EmployeeInformation.DAL.Gateway;

namespace EmployeeInformation.BLL
{
    public class DesignationManager
    {
        private DesignationGateway designationGateway = new DesignationGateway();

        public List<Designation> GetAll()
        {
            return designationGateway.GetAll();
        }

        public bool Save(Designation aDesignation, out string saveMessage)
        {
            if (aDesignation.Code == string.Empty)
            {
                saveMessage = "Designation code missing";
                return false;

            }
            else if (aDesignation.Title == string.Empty)
            {
                saveMessage = "Designation title missing";
                return false;
            }
            else if (designationGateway.HasThisDesignationCode(aDesignation.Code))
            {
                saveMessage = "Your system already has this designation code. Try again.";
                return false;
            }
            else if (designationGateway.HasThisDesignationTitle(aDesignation.Title))
            {
                saveMessage = "Your system already has this designation title. Try again.";
                return false;
            }
            else
            {
                saveMessage = "Designation has been saved.";
                return designationGateway.Save(aDesignation);
            }
        }
    }
}