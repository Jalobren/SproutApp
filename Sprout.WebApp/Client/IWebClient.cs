using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprout.WebApp.Client
{
    public interface IWebClient
    {
        Task<T> GetAsync<T>(string relativePath);
    }
}
