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
        public string Name { get; private set; }
        public string Description { get; private set; }
        public Status Status { get; set; }
        public DateTime? RequiredBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime StatusChangedDate { get; set; }
        public string SetName
        {
            set
            {
                if (value.Length > 20)
                    throw new Exception("Lenght greater");
                Name = value;
            }
        }
        public string SetDescription
        {
            set
            {
                if (value.Length > 100)
                    throw new Exception("Lenght greater");
                Description = value;
            }
        }
        public string SetStatus
        {
            set
            {
                if (value != Status.New.ToString() || value != Status.Inprogress.ToString()|| value != Status.Completed.ToString()|| value != Status.Deleted.ToString())
                    throw new Exception("Lenght greater");
                Status = (Status)Enum.Parse(typeof(Status),value);
            }
        }
    }
}
