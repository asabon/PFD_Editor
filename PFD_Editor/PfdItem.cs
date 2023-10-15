using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PFD_Editor
{
    public class PfdItem
    {
        public enum PfdItemType {
            WorkProduct,
            Process,
            Relationship,
        }
        public PfdItem()
        {
            id = 0;
            subject = "";
            description = "";
            type = PfdItemType.WorkProduct;
        }
        public PfdItem(int orgid) {
            id = orgid;
            subject = "";
            description = "";
            type = PfdItemType.WorkProduct;
        }
        public int id { get; set; }
        public string subject { get; set; }
        public string description { get; set; }
        public PfdItemType type { get; set; }
    }
}
