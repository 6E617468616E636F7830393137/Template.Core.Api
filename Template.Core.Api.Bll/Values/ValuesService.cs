using System.Collections.Generic;

namespace Template.Core.Api.Bll.Values
{
    public class ValuesService : IValuesService
    {
        public ValuesService()
        {
            
        }

        public IEnumerable<string> FindAll()
        {
            return new[] { "value1", "value2" };
        }

        public string Find(int id)
        {            
            return $"value{id}";
        }
    }
}
