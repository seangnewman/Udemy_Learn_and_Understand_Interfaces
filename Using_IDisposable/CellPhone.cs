using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Using_IDisposable
{
    class CellPhone:IDisposable
    {
        private bool Disposed = false;

        private void FreeResources(bool disposing)
        {
            if (Disposed)
            {
                return;
            }

            Disposed = true;

            if (disposing)
            {
                // Free managed resources ...
            }

            // Free unmanaged resources ...
        }

        public void Dispose()
        {
            FreeResources(true);
            GC.SuppressFinalize(this);
        }

        ~CellPhone()
        {
            FreeResources(false);
        }
    }
}
