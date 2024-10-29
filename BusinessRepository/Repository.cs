using DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel.VMModel;

namespace BusinessRepository
{
    public class Repository:IRepository
    {

        testing_ECommerceEntities db = new testing_ECommerceEntities();
        Status status = new Status();


        public VMLogin CheckLogin(VMRequest vmrequest)
        {
            VMLogin vmlogin = new VMLogin();
            try
            {
                LoginMaster lgmaster = db.LoginMasters.Where(x => x.UserName == vmrequest.UserName && x.IsActive == true).FirstOrDefault();

                if(lgmaster != null && lgmaster.UserName == vmrequest.UserName && lgmaster.Password == vmrequest.Password || lgmaster.UserRoleId == 1 || lgmaster.UserRoleId == 2 )
                {
                    bool loginSucess = db.LoginMasters.Where(x => x.UserName == vmrequest.UserName && x.Password == vmrequest.Password && x.IsActive == true).Any();

                    if (loginSucess)
                    {
                        vmlogin = new VMLogin()
                        {
                            UserName = vmrequest.UserName,
                            Password = vmrequest.Password,
                            UserRoleId = lgmaster.UserRoleId,
                            IsLoginSuccess = loginSucess,
                        };
                    }
                }
                return vmlogin;

            }
            catch(Exception ex)
            {
                return vmlogin;
            }
          
        }



        public Status AddLoginDetails(VMLogin  vmlogin)
        {
            try
            {

                LoginMaster lgmast = db.LoginMasters.Where(x => x.LoginId == vmlogin.LoginId).FirstOrDefault();

                if(lgmast == null)
                {
                    lgmast = new LoginMaster();
                    lgmast.LoginId = vmlogin.LoginId;
                    lgmast.UserName = vmlogin.UserName;
                    lgmast.Password = vmlogin.Password;
                    lgmast.UserRoleId = vmlogin.UserRoleId;

                    lgmast.IsActive = true;
                    lgmast.CreatedBy = 1;
                    lgmast.CreatedDate = DateTime.Now;

                    db.LoginMasters.Add(lgmast);
                    db.SaveChanges();

                    status.code = System.Net.HttpStatusCode.OK;
                    status.message = "Login Details Saved....";

                }

            }
            catch(Exception ex)
            {
                status.code = System.Net.HttpStatusCode.BadRequest;
                status.message = "Error....";
            }
            return status;

        }



    }
}
