using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Playwright;

namespace framework.Pages
{
    public class OrganizationsPage
    {
        private IPage _page;

        //Constructor
        public OrganizationsPage(IPage page)
        {
            _page = page;
        }

        #region Locators
        private ILocator _btnCreateOrganization => _page.GetByRole(AriaRole.Button, new() { Name = "Create Organization" });
        
        #endregion Locators

        /**
         * 
         * summary Function that allow Select an Organization 
         * from the list sorted in the table, this funcion can be select
         * using the following parameters
         * param name="organizationName" is the name of Organization to search
         * 
         * **/
        public async Task SelectOrganization(string organizationName)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /**
         * summary Function that allow create an Organization using the following 
         * parameters
         * **/
        public async Task CreateOrganization()
        {
            try
            {

            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message); 
            }
        }

    }
}
