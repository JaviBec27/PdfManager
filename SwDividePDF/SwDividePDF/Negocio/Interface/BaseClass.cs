using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace SwDividePDF.Negocio.Interface
{

    public abstract class BaseClass
    {
        protected BackgroundWorker worker;
        public string ErrorMessage;
        public BaseClass(BackgroundWorker worker)
        {
            this.worker = worker;
        }

        public BaseClass() { }

    }
}
