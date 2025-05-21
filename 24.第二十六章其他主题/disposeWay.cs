using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MyClass : IDisposable
{
    bool disposed = false;

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);

    }

    ~MyClass()
    {
        Dispose(false);
    }

    protected virtual void Dispose(bool disposing)
    {
        if(disposed == false)
        {
            if(disposing == true)
            {
                ..//释放托管资源
            }
            //释放非托管资源
        ....
        }
        disposed = true;
    }
}
