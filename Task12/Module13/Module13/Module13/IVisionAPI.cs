using Module13.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Module13
{
    public interface IVisionAPI
    {
        Task<ImageResult> MakeAnalysisRequest(string imageFilePath);
        
    }
}
