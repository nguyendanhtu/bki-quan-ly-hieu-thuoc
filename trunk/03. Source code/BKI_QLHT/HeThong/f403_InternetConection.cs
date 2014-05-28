using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace BKI_QLHT.HeThong
{
    class f403_InternetConection
    {
            [DllImport("wininet.dll")]
            private extern static bool InternetGetConnectedState(out int description, int reservedValue);
            public bool IsConnectedToInternet()
            {
                int desc;
                return InternetGetConnectedState(out desc, 0);
            }
        
    }
}
