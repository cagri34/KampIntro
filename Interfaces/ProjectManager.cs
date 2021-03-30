using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    class ProjectManager
    {
        public void Add(IPersonManager personManager)
        {
            personManager.Add();
        }
    }
}
