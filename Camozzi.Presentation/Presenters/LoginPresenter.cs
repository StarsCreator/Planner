using System;
using Camozzi.Model.Repository;
using Camozzi.Model.Services;
using Camozzi.Presentation.Injection;
using Camozzi.Presentation.Views;
using System.Security.Cryptography;
using System.Text;

namespace Camozzi.Presentation.Presenters
{
    public class LoginPresenter : BasePresenter<ILoginView>
    {
        private readonly IUserRepository Users;
        public LoginPresenter(IApplicationController controller, ILoginView view, IUserRepository users):base(controller,view)
        {
            Users = users;
            View.Ok += View_Ok;

            View.Users = Users.GetAll(); ;
        }

        void View_Ok()
        {
           /* using (MD5 md5Hash = MD5.Create())
            {
                string hash = GetMd5Hash(md5Hash,View.Password);

                if (VerifyMd5Hash(md5Hash,Users.))
                {
                    
                    View.Close();
                }
            }*/
                Controller.Run<MainPresenter, User>((User)View.UserName);
            View.Close();
                //Users.Dispose();
            //}
           // else
           // {
            //    View.ClearPswFld();
            //}
        }

        static string GetMd5Hash(MD5 md5Hash, string input)
        {

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }

        static bool VerifyMd5Hash(MD5 md5Hash, string input, string hash)
        {
            // Hash the input.
            string hashOfInput = GetMd5Hash(md5Hash, input);

            // Create a StringComparer an compare the hashes.
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;

            if (0 == comparer.Compare(hashOfInput, hash))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
