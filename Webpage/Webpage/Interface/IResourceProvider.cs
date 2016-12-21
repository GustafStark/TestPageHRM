using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webpage.Models;

namespace Webpage.Interface
{
    public interface IResourceProvider
    {
        object GetResource(string sName, string sCulture); 
    }
}
