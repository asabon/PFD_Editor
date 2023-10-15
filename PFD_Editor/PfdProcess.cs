using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFD_Editor
{
    public class PfdProcess : PfdItem
    {
        public PfdProcess()
        {
            this.id = 0;
            this.subject = "";
            this.description = "";
            this.type = PfdItemType.Process;
            this.inputIdList = new List<int>();
            this.outputIdList = new List<int>();
        }

        public PfdProcess(PfdProcess original)
        {
            this.id = original.id;
            this.subject = original.subject;
            this.description = original.description;
            this.type = PfdItemType.Process;
            this.inputIdList = new List<int>();
            foreach(int inputId  in original.inputIdList)
            {
                this.inputIdList.Add(inputId);
            }
            this.outputIdList = new List<int>();
            foreach (int outputId in original.outputIdList)
            {
                this.outputIdList.Add(outputId);
            }
        }

        public List<int> inputIdList { get; set; }
        public List<int> outputIdList { get; set; }
    }
}
