using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{

    public class AppMasterDetailPageMenuItem
    {
        public AppMasterDetailPageMenuItem()
        {
            //TargetType = typeof(AppMasterDetailPageDetail);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}