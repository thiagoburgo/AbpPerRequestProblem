using System;
using System.Collections.Generic;
using System.Text;

namespace PerRequestProblemSite
{
    public class PerRequestContext : IPerRequestContext
    {
        public string Item1 { get; set; }
    }

    public interface IPerRequestContext {
        string Item1 { get; set; }
    }
}
