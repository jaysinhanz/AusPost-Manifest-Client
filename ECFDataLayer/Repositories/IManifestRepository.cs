using System;
using System.Collections.Generic;
using System.Text;
using ECFDataLayer.Mappings;

namespace ECFDataLayer.Repositories
{
    public interface IManifestRepository
    {
        PCMSManifest GetFirstManifest();
    }
}
