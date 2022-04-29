using Sanator.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp15.Tools;
using WpfApp15.ViewModels;

namespace Sanator.ViewModels
{
    class MainVM : BaseVM
    {
        public CommandVM Register { get; set; }
        public MainVM()
        {
            Register = new CommandVM(() => { new RegisterWindow().Show(); });
        }
    }

}
