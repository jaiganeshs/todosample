using System;
using System.Collections.Generic;
using System.Text;

namespace TodoSample
{
    public class TodoItem
    {
        public TodoItem(int srNo)
        {
            SrNo = srNo;
        }
        public int SrNo { get; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Status Status { get; set; }
        public DateTime? RequiredBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime StatusChangedDate { get; set; }
    }
}
