
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseModel
{
    /// <summary>
    /// 
    /// </summary>
    /// 
    [Serializable]
    public class Suggestion
    {

        public int SuggestionId { get; set; }

        public string CustomerName { get; set; }

        public string ConsumerDesc { get; set; }

        public string SuggestionDesc { get; set; }

        public DateTime SuggestTime { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public int StatusId { get; set; }

    }
}
