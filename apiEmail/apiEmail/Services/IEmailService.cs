using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiEmail
{
    public interface IEmailService
    {
        void SendEmail(string value);
    }
}
