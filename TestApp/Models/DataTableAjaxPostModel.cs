using System.Collections.Generic;

namespace TestApp.Models
{
    public class DataTableAjaxPostModel
    {

        //TODO implement the rest of the parameters
        public int sEcho { get; set; }

        public int iColumns { get; set; }

        public int iDisplayStart { get; set; }

        public int iDisplayLength { get; set; }

        public string sSearch { get; set; }
    }
}