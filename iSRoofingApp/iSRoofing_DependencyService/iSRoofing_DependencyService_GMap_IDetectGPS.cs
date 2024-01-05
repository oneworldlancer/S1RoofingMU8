using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace S1RoofingMU.iSRoofingApp.iSRoofing_DependencyService
{
  public interface iSRoofing_DependencyService_GMap_IDetectGPS
    {
        bool isGPSEnabled();

        Task OpenGPS();
        }
    }
