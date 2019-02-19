using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Interfaces;

namespace Core.Bll
{
    public class UtilidadesBLL
    {
        public ILogger Logger { get; set; }

        public UtilidadesBLL ( ILogger logger)
        {
            this.Logger = logger;
        }

        public void DoTask()
        {
            this.Logger.Handle("TEST");
        }
    }
}
