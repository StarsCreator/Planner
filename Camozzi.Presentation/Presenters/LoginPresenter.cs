using System;
using System.Linq;
using Camozzi.Model.Repository;
using Camozzi.Presentation.Injection;
using Camozzi.Presentation.Views;
using Camozzi.Model.DataService;
using Camozzi.Model.Services;

namespace Camozzi.Presentation.Presenters
{
    public class LoginPresenter : BasePresenter<ILoginView>
    {
        private readonly IUserRepository _users;
        private readonly ISettings _settings;

        public LoginPresenter(IApplicationController controller, ILoginView view, IUserRepository users,ISettings settings)
            : base(controller, view)
        {
            View.Ok += View_Ok;
            _users = users;
            _settings = settings;
            _users.UpdateContext();
            View.Users = _users.GetAll().OrderBy(x=>x.DeptId).Select(user => user.Name).ToList();
            if (!String.IsNullOrEmpty(_settings.LastUser))
            {
                View.UserName = _settings.LastUser;
            }
        }

        private void View_Ok()
        {
            /* using (MD5 md5Hash = MD5.Create())
            {
                string hash = GetMd5Hash(md5Hash,View.Password);

                if (VerifyMd5Hash(md5Hash,Users.))
                {
                    
                    View.Close();
                }
            }*/
            using (var client = new CServiceClient("BasicHttpBinding_ICService"))
            {
                if (!client.CheckPassword(View.Password, _users.FindByName(View.UserName).Id))
                {
                    View.ClearPswFld();
                    return;
                }
            }
            Controller.Run<MainPresenter, UserDto>(_users.FindByName(View.UserName));
            View.Close();


            //Users.Dispose();
            //}
            // else
            // {
            //    View.ClearPswFld();
            //}
            //}

            //static string GetMd5Hash(HashAlgorithm md5Hash, string input)
            //{

            //    // Convert the input string to a byte array and compute the hash.
            //    var data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            //    // Create a new Stringbuilder to collect the bytes
            //    // and create a string.
            //    var sBuilder = new StringBuilder();

            //    // Loop through each byte of the hashed data 
            //    // and format each one as a hexadecimal string.
            //    foreach (byte t in data)
            //    {
            //        sBuilder.Append(t.ToString("x2"));
            //    }

            //    // Return the hexadecimal string.
            //    return sBuilder.ToString();
            //}

            //static bool VerifyMd5Hash(MD5 md5Hash, string input, string hash)
            //{
            //    // Hash the input.
            //    var hashOfInput = GetMd5Hash(md5Hash, input);

            //    // Create a StringComparer an compare the hashes.
            //    var comparer = StringComparer.OrdinalIgnoreCase;

            //    return 0 == comparer.Compare(hashOfInput, hash);
            //}
        }
    }
}