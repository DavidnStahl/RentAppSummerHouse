using rentapp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rentapp.Services
{
    public interface IEmailService
    {
        void SendEmail(EmailViewModel model);
    }
}
