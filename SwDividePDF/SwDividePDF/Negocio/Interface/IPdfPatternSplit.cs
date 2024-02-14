using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwDividePDF.Negocio.Interface
{
    public interface IPdfPatternSplit
    {
        void SplitPagesByDiccionary(string sourcePdfPath, Dictionary<int, int> divisorPattern, string pref, string name);
        void SplitPagesByPattern(string sourcePdfPath, List<FilePatternManagement> filePatterns, string name);
    }
}
