using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Module13
{
    public interface IAudioRecordService
    {
        Task<string> RecordAudio();
        Task PlayAudio(string speech);
    }
}
