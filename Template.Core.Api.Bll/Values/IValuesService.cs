using System.Collections.Generic;

namespace Template.Core.Api.Bll.Values
{
    public interface IValuesService
    {
        IEnumerable<string> FindAll();
        string Find(int id);
    }
}
